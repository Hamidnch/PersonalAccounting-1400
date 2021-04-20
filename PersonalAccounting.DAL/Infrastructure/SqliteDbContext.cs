using EFSecondLevelCache;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.Validation;
using System.Data.SQLite;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace PersonalAccounting.DAL.Infrastructure
{
    //public class MigrationsContextFactory : IDbContextFactory<SqliteDbContext>
    //{
    //    public SqliteDbContext Create()
    //    {
    //        return new SqliteDbContext(@"data source=.\db\PA.nch;foreign keys=true;");
    //    }
    //}

    //[DbConfigurationType(typeof(CustomHistoryConfiguration))]

    public class SqliteDbContext : DbContext, IUnitOfWork
    {
        private DbTransaction _transaction;

        public SqliteDbContext(string connectionString)
            : base(new SQLiteConnection() { ConnectionString = connectionString }, true) // "name=PersonalAccountingDB"
        {
            Configure();
        }
        private void Configure()
        {
            Configuration.ProxyCreationEnabled = true;
            Configuration.LazyLoadingEnabled = true;
        }
        public SqliteDbContext(DbConnection connection, bool contextOwnsConnection)
            : base(connection, contextOwnsConnection)
        {
            Configuration.ProxyCreationEnabled = true;
            Configuration.LazyLoadingEnabled = true;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //SqliteModelConfiguration.Configure(modelBuilder);

            if (modelBuilder == null)
                throw new ArgumentNullException(nameof(modelBuilder));

            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.HasDefaultSchema("nch");

            //this.ApplyCorrectYeKe();

            var asm = Assembly.GetExecutingAssembly();
            LoadEntityConfigurations(asm, modelBuilder, "PersonalAccounting.DAL.Mapping");

            // For debug mode
            var initializer = new SqliteDbInitializer(modelBuilder);
            Database.SetInitializer(initializer);
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<SqliteDbContext, Configuration>(true));

            base.OnModelCreating(modelBuilder);
        }

        #region Private Functions
        private static void LoadEntityConfigurations(Assembly asm, DbModelBuilder modelBuilder, string nameSpace)
        {
            var configurations = asm.GetTypes()
                .Where(type => type.BaseType != null &&
                               type.Namespace == nameSpace &&
                               type.BaseType.IsGenericType &&
                               type.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>))
                .ToList();

            configurations.ForEach(type =>
            {
                dynamic instance = Activator.CreateInstance(type);
                modelBuilder.Configurations.Add(instance);
            });
        }
        #endregion Private Functions

        #region IUnitOfWork
        private void OpenConnection()
        {
            if (Database.Connection.State != ConnectionState.Open)
            {
                Database.Connection.Open();
            }
        }
        private void ReleaseCurrentTransaction()
        {
            if (_transaction == null) return;
            _transaction.Dispose();
            _transaction = null;
        }

        //public T Update<T>(T entity, Expression<Func<IUpdateConfiguration<T>, object>> mapping)
        //    where T : class, new()
        //{
        //    return this.UpdateGraph(entity, mapping);
        //}

        public bool LazyLoadingEnabled
        {
            get => Configuration.LazyLoadingEnabled;
            set => Configuration.LazyLoadingEnabled = value;
        }
        public bool IsInTransaction => _transaction != null;
        public void BeginTransaction()
        {
            BeginTransaction(IsolationLevel.ReadCommitted);
        }

        public void BeginTransaction(IsolationLevel isolationLevel)
        {
            if (_transaction != null)
            {
                throw new ApplicationException(
                    "Cannot begin a new transaction while an existing transaction is still running. " +
                    "Please commit or rollback the existing transaction before starting a new one.");
            }
            OpenConnection();
            _transaction = Database.Connection.BeginTransaction(isolationLevel);
        }

        public void RollBackTransaction()
        {
            if (_transaction == null)
            {
                throw new ApplicationException("Cannot roll back a transaction while there is no transaction running.");
            }

            try
            {
                _transaction.Rollback();
            }
            finally
            {
                ReleaseCurrentTransaction();
            }
        }

        public void CommitTransaction()
        {
            if (_transaction == null)
            {
                throw new
                    ApplicationException("Cannot roll back a transaction while there is no transaction running.");
            }

            try
            {
                SaveChanges();
                _transaction.Commit();
            }
            catch
            {
                _transaction.Rollback();
                throw;
            }
            finally
            {
                ReleaseCurrentTransaction();
            }
        }

        private string[] GetChangedEntityNames()
        {
            return ChangeTracker.Entries()
                .Where(x => x.State == EntityState.Added ||
                            x.State == EntityState.Modified ||
                            x.State == EntityState.Deleted)
                .Select(x => ObjectContext.GetObjectType(x.Entity.GetType()).FullName)
                .Distinct()
                .ToArray();
        }

        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }

        public void MarkAsChanged<TEntity>(TEntity entity) where TEntity : class
        {
            Entry(entity).State = EntityState.Modified;
        }

        public void MarkAsDetached<TEntity>(TEntity entity) where TEntity : class
        {
            Entry(entity).State = EntityState.Detached;
        }

        public void MarkAsAdded<TEntity>(TEntity entity) where TEntity : class
        {
            Entry(entity).State = EntityState.Added;
        }

        public void MarkAsDeleted<TEntity>(TEntity entity) where TEntity : class
        {
            Entry(entity).State = EntityState.Deleted;
        }

        public IList<T> GetRows<T>(string sql, params object[] parameters) where T : class
        {
            return Database.SqlQuery<T>(sql, parameters).ToList();
        }

        public override int SaveChanges()
        {
            return SaveAllChanges();
        }

        public override Task<int> SaveChangesAsync()
        {
            return SaveAllChangesAsync();
        }

        public int SaveAllChanges(bool invalidateCacheDependencies = true)
        {
            int result;

            try
            {
                result = base.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                // Retrieve the error messages as a list of strings.
                var errorMessages = ex.EntityValidationErrors
                    .SelectMany(x => x.ValidationErrors)
                    .Select(x => x.ErrorMessage);

                // Join the list to a single string.
                var fullErrorMessage = string.Join("; ", errorMessages);

                // Combine the original exception message with the new one.
                var exceptionMessage = string.Concat(ex.Message, " The validation errors are: ",
                    fullErrorMessage);

                // Throw a new DbEntityValidationException with the improved exception message.
                throw new DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors);
            }

            if (!invalidateCacheDependencies) return result;
            var changedEntityNames = GetChangedEntityNames();
            new EFCacheServiceProvider().InvalidateCacheDependencies(changedEntityNames);
            return result;
        }

        public async Task<int> SaveAllChangesAsync(bool invalidateCacheDependencies = true)
        {
            int result;

            try
            {
                result = await base.SaveChangesAsync();
            }
            catch (DbEntityValidationException ex)
            {
                // Retrieve the error messages as a list of strings.
                var errorMessages = ex.EntityValidationErrors
                    .SelectMany(x => x.ValidationErrors)
                    .Select(x => x.ErrorMessage);

                // Join the list to a single string.
                var fullErrorMessage = string.Join("; ", errorMessages);

                // Combine the original exception message with the new one.
                var exceptionMessage = string.Concat(ex.Message, " The validation errors are: ",
                    fullErrorMessage);

                // Throw a new DbEntityValidationException with the improved exception message.
                throw new DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors);
            }

            if (!invalidateCacheDependencies) return result;
            var changedEntityNames = GetChangedEntityNames();
            new EFCacheServiceProvider().InvalidateCacheDependencies(changedEntityNames);
            return result;
        }

        public IEnumerable<TEntity> AddThisRange<TEntity>(IEnumerable<TEntity> entities)
            where TEntity : class
        {
            return ((DbSet<TEntity>)Set<TEntity>()).AddRange(entities);
        }

        public void ForceDatabaseInitialize()
        {
            Database.Initialize(true);
        }

        //public void EnableFiltering(string name)
        //{
        //    this.EnableFilter(name);
        //}

        //public void EnableFiltering(string name, string parameter, object value)
        //{
        //    this.EnableFilter(name).SetParameter(parameter, value);
        //}

        //public void DisableFiltering(string name)
        //{
        //    this.DisableFilter(name);
        //}

        //public void BulkInsertData<T>(IList<T> data)
        //{
        //    this.BulkInsert(data);
        //}

        public bool ValidateOnSaveEnabled
        {
            get => Configuration.ValidateOnSaveEnabled;
            set => Configuration.ValidateOnSaveEnabled = value;
        }

        public bool ProxyCreationEnabled
        {
            get => Configuration.ProxyCreationEnabled;
            set => Configuration.ProxyCreationEnabled = value;
        }

        bool IUnitOfWork.AutoDetectChangesEnabled
        {
            get => Configuration.AutoDetectChangesEnabled;
            set => Configuration.AutoDetectChangesEnabled = value;
        }

        public bool ForceNoTracking { get; set; }

        #endregion IUnitOfWork}
    }
}
