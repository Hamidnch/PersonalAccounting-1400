//using System;
//using System.Collections.Generic;
//using System.Data.Common;
//using System.Data.Entity;
//using System.Data.Entity.Migrations.History;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PersonalAccounting.DAL.Infrastructure
//{
//    public class CustomHistoryContext : HistoryContext
//    {
//        public CustomHistoryContext(DbConnection dbConnection, string defaultSchema)
//            : base(dbConnection, defaultSchema)
//        {
//        }

//        protected override void OnModelCreating(DbModelBuilder modelBuilder)
//        {
//            base.OnModelCreating(modelBuilder);
//            modelBuilder.HasDefaultSchema("dbo");
//            modelBuilder.Entity<HistoryRow>().ToTable(tableName: "__MigrationHistory", schemaName: "dbo");
//            //modelBuilder.Entity<HistoryRow>().ToTable(tableName: "__MigrationHistory", schemaName: "dbo");
//        }
//    }

//    public class CustomHistoryConfiguration : DbConfiguration
//    {
//        public CustomHistoryConfiguration()
//        {
//            this.SetHistoryContext("System.Data.SqlClient",
//                (connection, defaultSchema) => new CustomHistoryContext(connection, "dbo"));
//        }
//    }
//}
