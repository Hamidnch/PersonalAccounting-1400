using PersonalAccounting.CommonLibrary.Helper;
using SQLite.CodeFirst;
using System.Data.Entity;

namespace PersonalAccounting.DAL.Infrastructure
{
    public class SqliteDbInitializer : SqliteDropCreateDatabaseWhenModelChanges<SqliteDbContext>
    {
        public SqliteDbInitializer(DbModelBuilder modelBuilder)
            : base(modelBuilder, typeof(SqliteCustomHistory))
        {
            this.ApplyCorrectYeKe();
            //modelBuilder.HasDefaultSchema("nch");
        }

        protected override void Seed(SqliteDbContext context)
        {
            // Here you can seed your core data if you have any.

        }
    }
}
