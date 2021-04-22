using PersonalAccounting.Domain.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Annotations;

namespace PersonalAccounting.DAL.Infrastructure
{
    public class SqliteModelConfiguration
    {
        public static void Configure(DbModelBuilder modelBuilder)
        {
            ConfigureRoleEntity(modelBuilder);
            ConfigureUserEntity(modelBuilder);
            ConfigureArticleEntity(modelBuilder);
            ConfigureArticleGroupEntity(modelBuilder);
            ConfigureBankAccountEntity(modelBuilder);
            ConfigureBankEntity(modelBuilder);
            ConfigureDiaryNoteEntity(modelBuilder);
            ConfigureExpenseEntity(modelBuilder);
            ConfigureExpenseDocumentEntity(modelBuilder);
            ConfigureFormEntity(modelBuilder);
            ConfigureFundEntity(modelBuilder);
            ConfigureTransferMoneyEntity(modelBuilder);
            ConfigureIncomeTypeEntity(modelBuilder);
            ConfigureIncomeEntity(modelBuilder);
            ConfigureCommodityTypeEntity(modelBuilder);
            ConfigureCommodityEntity(modelBuilder);
            ConfigureMeasurementUnitEntity(modelBuilder);
            ConfigureMentalConditionEntity(modelBuilder);
            ConfigurePermissionEntity(modelBuilder);
            ConfigurePersonEntity(modelBuilder);
            ConfigureWeatherConditionEntity(modelBuilder);
            ConfigureLogEntity(modelBuilder);
        }

        private static void ConfigureRoleEntity(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().ToTable("Roles") //, "nch");
                .HasKey(r => r.Id);

            modelBuilder.Entity<Role>().Property(r => r.Id).HasColumnOrder(1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Role>().Property(r => r.Name).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Role>().Property(r => r.CreatedOn).HasColumnType("datetime");
            modelBuilder.Entity<Role>().Property(r => r.LastUpdate).HasColumnType("datetime");
            //modelBuilder.Entity<Role>().Property(r => r.RowVersion).IsRowVersion();

            //Relationship
            modelBuilder.Entity<Role>().HasOptional(p => p.SelfUser)
                .WithMany()
                .HasForeignKey(p => p.CreatedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>().HasOptional(p => p.UpdateUser)
                .WithMany()
                .HasForeignKey(p => p.UpdateBy)
                .WillCascadeOnDelete(false);
        }
        private static void ConfigureUserEntity(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users") //, "nch");
               .HasKey(u => u.Id);
            modelBuilder.Entity<User>().Property(u => u.Id).HasColumnOrder(1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<User>().Property(u => u.UserName).HasMaxLength(256).IsRequired()
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("IX_Username") { IsUnique = true })); ;
            modelBuilder.Entity<User>().Property(u => u.Password).HasMaxLength(128).IsRequired();
            modelBuilder.Entity<User>().Property(u => u.CreatedOn).HasColumnType("datetime").IsOptional();
            modelBuilder.Entity<User>().Property(u => u.LastUpdate).HasColumnType("datetime").IsOptional();
            modelBuilder.Entity<User>().Property(u => u.LastActivityDate).HasColumnType("datetime").IsOptional();
            modelBuilder.Entity<User>().Property(u => u.LastLockoutDate).HasColumnType("datetime").IsOptional();
            modelBuilder.Entity<User>().Property(u => u.LastLoginDate).HasColumnType("datetime").IsOptional();
            modelBuilder.Entity<User>().Property(u => u.LastPasswordChangedDate).HasColumnType("datetime").IsOptional();
            modelBuilder.Entity<User>().Property(u => u.LastPasswordFailureDate).HasColumnType("datetime").IsOptional();
            modelBuilder.Entity<User>().Property(u => u.Status).HasMaxLength(10);
            modelBuilder.Entity<User>().Property(u => u.Ip).HasMaxLength(19).IsOptional();
            modelBuilder.Entity<User>().Property(u => u.Email).HasMaxLength(255).IsOptional();
            modelBuilder.Entity<User>().Property(u => u.Description).IsMaxLength().IsOptional();
            //modelBuilder.Entity<User>().Property(u => u.RowVersion).IsRowVersion();

            //Relationships
            //HasOptional(u => u.Role)
            //    .WithMany()
            //    .HasForeignKey(u => u.RoleId)
            //    .WillCascadeOnDelete(false);

            //   HasRequired(u => u.Role)
            //.WithMany(r => r.Users)
            //.HasForeignKey(u => u.RoleId)
            //.WillCascadeOnDelete(false);

            //HasRequired(q => q.Person)
            //    .WithRequiredPrincipal(p => p.User);

            // HasOptional(t => t.Person)
            //.WithMany()
            //.Map(d => d.MapKey("PersonId"));

            modelBuilder.Entity<User>().HasOptional(u => u.SelfUser)
                .WithMany()
                .HasForeignKey(u => u.CreatedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>().HasOptional(p => p.UpdateUser)
                .WithMany()
                .HasForeignKey(p => p.UpdateBy)
                .WillCascadeOnDelete(false);

            //Many to Many
            modelBuilder.Entity<User>().HasMany(t => t.Roles)
                .WithMany(c => c.Users)
                .Map(t => t.ToTable("UserRoles")
                    .MapLeftKey("UserId")
                    .MapRightKey("RoleId"));

            //HasMany(r => r.Roles)
            //    .WithMany(u => u.Users)
            //    .Map(m =>
            //    {
            //        m.ToTable("UserRoles", "nch");
            //        m.MapLeftKey("UserId");
            //        m.MapRightKey("RoleId");
            //    });

            //HasRequired(u => u.Role)
            //    .WithMany(r => r.Users)
            //    .HasForeignKey(u => u.RoleId);

            //HasMany(r => r.Roles)
            //    .WithMany(u => u.Users)
            //    .Map(m =>
            //    {
            //        m.ToTable("UsersRoles", "nch");
            //        m.MapLeftKey("UserId");
            //        m.MapRightKey("RoleId");
            //    });
        }
        private static void ConfigureArticleEntity(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>().ToTable("Articles") //, "nch");
                .HasKey(a => a.Id);
            modelBuilder.Entity<Article>().Property(a => a.Id).HasColumnOrder(1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Article>().Property(a => a.Name).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Article>().Property(a => a.LatinName).HasMaxLength(50).IsOptional();
            modelBuilder.Entity<Article>().Property(a => a.CreatedOn).HasColumnType("datetime");
            modelBuilder.Entity<Article>().Property(a => a.LastUpdate).HasColumnType("datetime");
            modelBuilder.Entity<Article>().Property(a => a.Status).HasMaxLength(50);
            modelBuilder.Entity<Article>().Property(a => a.Description).IsOptional().IsMaxLength();
            //modelBuilder.Entity<Article>().Property(a => a.RowVersion).IsRowVersion();

            //Relationship
            modelBuilder.Entity<Article>().HasOptional(p => p.SelfUser)
                .WithMany()
                .HasForeignKey(p => p.CreatedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Article>().HasOptional(p => p.UpdateUser)
                .WithMany()
                .HasForeignKey(p => p.UpdateBy)
                .WillCascadeOnDelete(false);
        }
        private static void ConfigureArticleGroupEntity(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ArticleGroup>().ToTable("ArticleGroups") //, "nch");
                .HasKey(ag => ag.Id);
            modelBuilder.Entity<ArticleGroup>().Property(ag => ag.Id)
                .HasColumnOrder(1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<ArticleGroup>().Property(ag => ag.Name).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<ArticleGroup>().Property(ag => ag.LatinName).IsOptional();
            modelBuilder.Entity<ArticleGroup>().Property(ag => ag.CreatedOn).HasColumnType("datetime");
            modelBuilder.Entity<ArticleGroup>().Property(ag => ag.LastUpdate).HasColumnType("datetime");
            modelBuilder.Entity<ArticleGroup>().Property(ag => ag.Description).IsOptional().IsMaxLength();
            //modelBuilder.Entity<ArticleGroup>().Property(ag => ag.RowVersion).IsRowVersion();

            //Relationship
            modelBuilder.Entity<ArticleGroup>().HasOptional(p => p.SelfUser)
                .WithMany()
                .HasForeignKey(p => p.CreatedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ArticleGroup>().HasOptional(p => p.UpdateUser)
                .WithMany()
                .HasForeignKey(p => p.UpdateBy)
                .WillCascadeOnDelete(false);
        }
        private static void ConfigureBankAccountEntity(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BankAccount>().ToTable("BankAccounts") //, "nch");
                .HasKey(ba => ba.Id);
            modelBuilder.Entity<BankAccount>().Property(ba => ba.Id)
                .HasColumnOrder(1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<BankAccount>().Property(ba => ba.Name).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<BankAccount>().Property(ba => ba.AccountNumber).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<BankAccount>().Property(ba => ba.PersonId).IsRequired();
            modelBuilder.Entity<BankAccount>().Property(ba => ba.BankId).IsRequired();
            modelBuilder.Entity<BankAccount>().Property(ba => ba.CreatedOn).HasColumnType("datetime");
            modelBuilder.Entity<BankAccount>().Property(ba => ba.LastUpdate).HasColumnType("datetime");
            modelBuilder.Entity<BankAccount>().Property(ba => ba.Status).IsOptional();
            modelBuilder.Entity<BankAccount>().Property(ba => ba.Description).IsOptional().IsMaxLength();
            //modelBuilder.Entity<BankAccount>().Property(ba => ba.RowVersion).IsRowVersion();

            //Relationship
            modelBuilder.Entity<BankAccount>().HasOptional(p => p.SelfUser)
                .WithMany()
                .HasForeignKey(p => p.CreatedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BankAccount>().HasOptional(p => p.UpdateUser)
                .WithMany()
                .HasForeignKey(p => p.UpdateBy)
                .WillCascadeOnDelete(false);
        }
        private static void ConfigureBankEntity(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bank>().ToTable("Banks") //, "nch");
                .HasKey(b => b.Id);
            modelBuilder.Entity<Bank>().Property(b => b.Id)
                .HasColumnOrder(1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Bank>().Property(b => b.Name).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Bank>().Property(b => b.Department).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Bank>().Property(b => b.CreatedOn).HasColumnType("datetime");
            modelBuilder.Entity<Bank>().Property(b => b.LastUpdate).HasColumnType("datetime");
            modelBuilder.Entity<Bank>().Property(b => b.Status).IsOptional();
            modelBuilder.Entity<Bank>().Property(b => b.Description).IsOptional().IsMaxLength();
            //modelBuilder.Entity<Bank>().Property(b => b.RowVersion).IsRowVersion();

            //Relationship
            modelBuilder.Entity<Bank>().HasOptional(p => p.SelfUser)
                .WithMany()
                .HasForeignKey(p => p.CreatedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Bank>().HasOptional(p => p.UpdateUser)
                .WithMany()
                .HasForeignKey(p => p.UpdateBy)
                .WillCascadeOnDelete(false);
        }
        private static void ConfigureDiaryNoteEntity(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DiaryNote>().ToTable("DiaryNotes") //, "nch");
                .HasKey(b => b.Id);
            modelBuilder.Entity<DiaryNote>().Property(b => b.Id)
                .HasColumnOrder(1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<DiaryNote>().Property(b => b.UserId).IsRequired();
            modelBuilder.Entity<DiaryNote>().Property(b => b.Date).HasColumnType("datetime");
            modelBuilder.Entity<DiaryNote>().Property(b => b.Note).HasColumnType("ntext");

            //Relationship
            modelBuilder.Entity<DiaryNote>().HasOptional(p => p.SelfUser)
                .WithMany()
                .HasForeignKey(p => p.CreatedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DiaryNote>().HasOptional(p => p.UpdateUser)
                .WithMany()
                .HasForeignKey(p => p.UpdateBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DiaryNote>().HasOptional(u => u.User)
                .WithMany(r => r.DiaryNotes)
                .HasForeignKey(u => u.UserId);

            modelBuilder.Entity<DiaryNote>().HasOptional(u => u.WeatherCondition)
                .WithMany(r => r.DiaryNotes)
                .HasForeignKey(u => u.WeatherConditionId);

            modelBuilder.Entity<DiaryNote>().HasOptional(u => u.MentalCondition)
                .WithMany(r => r.DiaryNotes)
                .HasForeignKey(u => u.MentalConditionId);
        }
        private static void ConfigureExpenseEntity(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Expense>().ToTable("Expenses") //, "nch");
                .HasKey(e => e.Id);
            modelBuilder.Entity<Expense>().Property(e => e.Id)
                .HasColumnOrder(1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Expense>().Property(e => e.ArticleId).IsRequired();
            modelBuilder.Entity<Expense>().Property(e => e.Count).IsRequired();
            modelBuilder.Entity<Expense>().Property(e => e.Price).IsRequired();
            modelBuilder.Entity<Expense>().Property(e => e.ByPersonId).IsRequired();
            modelBuilder.Entity<Expense>().Property(e => e.Description).IsOptional().IsMaxLength();
            //modelBuilder.Entity<Expense>().Property(e => e.RowVersion).IsRowVersion();

            //Relationship
            modelBuilder.Entity<Expense>().HasOptional(p => p.SelfUser)
                .WithMany()
                .HasForeignKey(p => p.CreatedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Expense>().HasOptional(p => p.UpdateUser)
                .WithMany()
                .HasForeignKey(p => p.UpdateBy)
                .WillCascadeOnDelete(false);
        }
        private static void ConfigureExpenseDocumentEntity(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ExpenseDocument>().ToTable("ExpenseDocuments") //, "nch");
                .HasKey(ed => ed.Id);
            modelBuilder.Entity<ExpenseDocument>().Property(ed => ed.Id)
                .HasColumnOrder(1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<ExpenseDocument>().Property(ed => ed.RegisterDate).HasColumnType("datetime");
            modelBuilder.Entity<ExpenseDocument>().Property(ed => ed.CreatedOn).HasColumnType("datetime");
            modelBuilder.Entity<ExpenseDocument>().Property(ed => ed.LastUpdate).HasColumnType("datetime");
            //modelBuilder.Entity<ExpenseDocument>().Property(ed => ed.RowVersion).IsRowVersion();

            //Relationship

            //modelBuilder.Entity<ExpenseDocument>().HasOptional(p => p.User)
            //    .WithMany(p=> p.ExpenseDocuments)
            //    .HasForeignKey(p => p.UserId)
            //    .WillCascadeOnDelete(false);

            modelBuilder.Entity<ExpenseDocument>().HasOptional(p => p.SelfUser)
                .WithMany()
                .HasForeignKey(p => p.CreatedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ExpenseDocument>().HasOptional(p => p.UpdateUser)
                .WithMany()
                .HasForeignKey(p => p.UpdateBy)
                .WillCascadeOnDelete(false);
        }
        private static void ConfigureFormEntity(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FormEntity>().ToTable("FormEntities") //, "nch");
                .HasKey(r => r.Id);
            modelBuilder.Entity<FormEntity>().Property(r => r.Id).HasColumnOrder(1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<FormEntity>().Property(r => r.Name).HasMaxLength(255).IsRequired();
            modelBuilder.Entity<FormEntity>().Property(r => r.SystemName).HasMaxLength(200).IsRequired();
            modelBuilder.Entity<FormEntity>().Property(r => r.CreatedOn).HasColumnType("datetime");
            modelBuilder.Entity<FormEntity>().Property(r => r.LastUpdate).HasColumnType("datetime");
            //modelBuilder.Entity<FormEntity>().Property(r => r.RowVersion).IsRowVersion();

            //Relationship
            modelBuilder.Entity<FormEntity>().HasOptional(p => p.SelfUser)
                .WithMany()
                .HasForeignKey(p => p.CreatedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FormEntity>().HasOptional(p => p.UpdateUser)
                .WithMany()
                .HasForeignKey(p => p.UpdateBy)
                .WillCascadeOnDelete(false);
        }
        private static void ConfigureFundEntity(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fund>().ToTable("Funds") //, "nch");
                .HasKey(f => f.Id);
            modelBuilder.Entity<Fund>().Property(f => f.Id)
                .HasColumnOrder(1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Fund>().Property(f => f.Type).IsRequired();
            modelBuilder.Entity<Fund>().Property(f => f.Title).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Fund>().Property(f => f.BankAccountId).IsOptional();
            //modelBuilder.Entity<Fund>().Property(f => f.FundCurrentValue).IsRequired();
            modelBuilder.Entity<Fund>().Property(f => f.CreatedOn).HasColumnType("datetime");
            modelBuilder.Entity<Fund>().Property(f => f.LastUpdate).HasColumnType("datetime");
            modelBuilder.Entity<Fund>().Property(f => f.Status).IsOptional();
            modelBuilder.Entity<Fund>().Property(f => f.Description).IsOptional().IsMaxLength();
            //modelBuilder.Entity<Fund>().Property(f => f.RowVersion).IsRowVersion();

            //Relationship
            modelBuilder.Entity<Fund>().HasOptional(p => p.SelfUser)
                .WithMany()
                .HasForeignKey(p => p.CreatedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Fund>().HasOptional(p => p.UpdateUser)
                .WithMany()
                .HasForeignKey(p => p.UpdateBy)
                .WillCascadeOnDelete(false);
        }

        private static void ConfigureTransferMoneyEntity(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TransferMoney>().ToTable("TransferMonies") //, "nch");
                .HasKey(f => f.Id);
            modelBuilder.Entity<TransferMoney>().Property(f => f.Id)
                .HasColumnOrder(1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<TransferMoney>().Property(f => f.Amount).IsRequired();
            modelBuilder.Entity<TransferMoney>().Property(f => f.OriginFundId).IsRequired();
            modelBuilder.Entity<TransferMoney>().Property(f => f.DestinationFundId).IsOptional();
            modelBuilder.Entity<TransferMoney>().Property(f => f.CreatedOn).HasColumnType("datetime");
            modelBuilder.Entity<TransferMoney>().Property(f => f.LastUpdate).HasColumnType("datetime");
            modelBuilder.Entity<TransferMoney>().Property(f => f.Status).IsOptional();
            modelBuilder.Entity<TransferMoney>().Property(f => f.Description).IsOptional().IsMaxLength();

            //Relationship
            modelBuilder.Entity<TransferMoney>().HasOptional(p => p.SelfUser)
                .WithMany()
                .HasForeignKey(p => p.CreatedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TransferMoney>().HasOptional(p => p.UpdateUser)
                .WithMany()
                .HasForeignKey(p => p.UpdateBy)
                .WillCascadeOnDelete(false);
        }

        private static void ConfigureIncomeEntity(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Income>().ToTable("Incomes") //, "nch");
                .HasKey(i => i.Id);
            modelBuilder.Entity<Income>().Property(i => i.Id)
                .HasColumnOrder(1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Income>().Property(i => i.IncomeDate).HasColumnType("datetime").IsRequired();
            modelBuilder.Entity<Income>().Property(i => i.Amount).IsRequired();
            modelBuilder.Entity<Income>().Property(i => i.ReceivedBy).IsOptional();
            modelBuilder.Entity<Income>().Property(i => i.CreatedOn).HasColumnType("datetime");
            modelBuilder.Entity<Income>().Property(i => i.LastUpdate).HasColumnType("datetime");
            //modelBuilder.Entity<Income>().Property(i => i.RowVersion).IsRowVersion();

            //Relationship
            modelBuilder.Entity<Income>().HasOptional(p => p.SelfUser)
                .WithMany()
                .HasForeignKey(p => p.CreatedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Income>().HasOptional(p => p.UpdateUser)
                .WithMany()
                .HasForeignKey(p => p.UpdateBy)
                .WillCascadeOnDelete(false);
        }
        private static void ConfigureIncomeTypeEntity(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IncomeType>().ToTable("IncomeTypes") //, "nch");
                .HasKey(it => it.Id);
            modelBuilder.Entity<IncomeType>().Property(it => it.Id)
                .HasColumnOrder(1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<IncomeType>().Property(it => it.Title).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<IncomeType>().Property(it => it.CreatedOn).HasColumnType("datetime");
            modelBuilder.Entity<IncomeType>().Property(it => it.LastUpdate).HasColumnType("datetime");
            //modelBuilder.Entity<IncomeType>().Property(it => it.RowVersion).IsRowVersion();

            //Relationship
            modelBuilder.Entity<IncomeType>().HasOptional(p => p.SelfUser)
                .WithMany()
                .HasForeignKey(p => p.CreatedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IncomeType>().HasOptional(p => p.UpdateUser)
                .WithMany()
                .HasForeignKey(p => p.UpdateBy)
                .WillCascadeOnDelete(false);
        }
        private static void ConfigureCommodityEntity(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Commodity>().ToTable("Commodities") //, "nch");
                .HasKey(i => i.Id);
            modelBuilder.Entity<Commodity>().Property(i => i.Id)
                .HasColumnOrder(1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Commodity>().Property(i => i.CommodityDate).HasColumnType("datetime").IsRequired();
            modelBuilder.Entity<Commodity>().Property(i => i.ReceiverId).IsRequired();
            modelBuilder.Entity<Commodity>().Property(i => i.ReceivedBy).IsRequired();
            modelBuilder.Entity<Commodity>().Property(i => i.CreatedOn).HasColumnType("datetime");
            modelBuilder.Entity<Commodity>().Property(i => i.LastUpdate).HasColumnType("datetime");
            //modelBuilder.Entity<Income>().Property(i => i.RowVersion).IsRowVersion();

            //Relationship
            modelBuilder.Entity<Commodity>().HasOptional(p => p.SelfUser)
                .WithMany()
                .HasForeignKey(p => p.CreatedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Commodity>().HasOptional(p => p.UpdateUser)
                .WithMany()
                .HasForeignKey(p => p.UpdateBy)
                .WillCascadeOnDelete(false);
        }
        private static void ConfigureCommodityTypeEntity(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CommodityType>()
                .ToTable("CommodityTypes") //, "nch");
                .HasKey(it => it.Id);
            modelBuilder.Entity<CommodityType>()
                .Property(it => it.Id).HasColumnOrder(1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<CommodityType>().Property(it => it.Title).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<CommodityType>().Property(it => it.CreatedOn).HasColumnType("datetime");
            modelBuilder.Entity<CommodityType>().Property(it => it.LastUpdate).HasColumnType("datetime");
            //modelBuilder.Entity<IncomeType>().Property(it => it.RowVersion).IsRowVersion();

            //Relationship
            modelBuilder.Entity<CommodityType>().HasOptional(p => p.SelfUser)
                .WithMany()
                .HasForeignKey(p => p.CreatedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CommodityType>().HasOptional(p => p.UpdateUser)
                .WithMany()
                .HasForeignKey(p => p.UpdateBy)
                .WillCascadeOnDelete(false);
        }

        private static void ConfigureMeasurementUnitEntity(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MeasurementUnit>().ToTable("MeasurementUnits") //, "nch");
                .HasKey(mu => mu.Id);
            modelBuilder.Entity<MeasurementUnit>().Property(mu => mu.Id)
                .HasColumnOrder(1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<MeasurementUnit>().Property(mu => mu.Name).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<MeasurementUnit>().Property(mu => mu.CreatedOn).HasColumnType("datetime");
            modelBuilder.Entity<MeasurementUnit>().Property(mu => mu.LastUpdate).HasColumnType("datetime");
            //modelBuilder.Entity<MeasurementUnit>().Property(mu => mu.RowVersion).IsRowVersion();

            //Relationship
            modelBuilder.Entity<MeasurementUnit>().HasOptional(p => p.SelfUser)
                .WithMany()
                .HasForeignKey(p => p.CreatedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MeasurementUnit>().HasOptional(p => p.UpdateUser)
                .WithMany()
                .HasForeignKey(p => p.UpdateBy)
                .WillCascadeOnDelete(false);
        }
        private static void ConfigureMentalConditionEntity(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MentalCondition>().ToTable("MentalConditions") //, "nch");
                .HasKey(a => a.Id);
            modelBuilder.Entity<MentalCondition>().Property(a => a.Id).HasColumnOrder(1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<MentalCondition>().Property(a => a.Title).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<MentalCondition>().Property(a => a.CreatedOn).HasColumnType("datetime");
            modelBuilder.Entity<MentalCondition>().Property(a => a.LastUpdate).HasColumnType("datetime");
            modelBuilder.Entity<MentalCondition>().Property(a => a.Status).HasMaxLength(50);
            modelBuilder.Entity<MentalCondition>().Property(a => a.Description).IsOptional().IsMaxLength();
            //modelBuilder.Entity<MentalCondition>().Property(a => a.RowVersion).IsRowVersion();

            //Relationship
            modelBuilder.Entity<MentalCondition>().HasOptional(p => p.SelfUser)
                .WithMany()
                .HasForeignKey(p => p.CreatedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MentalCondition>().HasOptional(p => p.UpdateUser)
                .WithMany()
                .HasForeignKey(p => p.UpdateBy)
                .WillCascadeOnDelete(false);
        }
        private static void ConfigurePermissionEntity(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Permission>().ToTable("Permissions") //, "nch");
                .HasKey(r => r.Id);
            modelBuilder.Entity<Permission>().Property(r => r.Id).HasColumnOrder(1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Permission>().Property(r => r.Name).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Permission>().Property(r => r.IsSelected).IsRequired();
            modelBuilder.Entity<Permission>().Property(r => r.CreatedOn).HasColumnType("datetime");
            modelBuilder.Entity<Permission>().Property(r => r.LastUpdate).HasColumnType("datetime");
            //modelBuilder.Entity<Permission>().Property(r => r.RowVersion).IsRowVersion();

            //Relationship
            modelBuilder.Entity<Permission>().HasOptional(p => p.SelfUser)
                .WithMany()
                .HasForeignKey(p => p.CreatedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Permission>().HasOptional(p => p.UpdateUser)
                .WithMany()
                .HasForeignKey(p => p.UpdateBy)
                .WillCascadeOnDelete(false);

            //Many to Many
            modelBuilder.Entity<Permission>().HasMany(t => t.Roles)
                .WithMany(c => c.Permissions)
                .Map(t => t.ToTable("RolePermissions")
                    .MapLeftKey("PermissionId")
                    .MapRightKey("RoleId"));

            modelBuilder.Entity<Permission>().HasMany(t => t.FormEntities)
                .WithMany(c => c.Permissions)
                .Map(t => t.ToTable("FormEntityPermissions")
                    .MapLeftKey("PermissionId")
                    .MapRightKey("FormEntityId"));

            //HasRequired(u => u.Role)
            //    .WithMany()
            //    .HasForeignKey(u => u.RoleId)
            //    .WillCascadeOnDelete(false);

            //HasRequired(u => u.FormEntity)
            //    .WithMany()
            //    .HasForeignKey(u => u.FormEntityId)
            //    .WillCascadeOnDelete(false);
        }
        private static void ConfigurePersonEntity(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().ToTable("Persons") //, "nch");
                .HasKey(p => p.Id);
            modelBuilder.Entity<Person>().Property(p => p.Id).HasColumnOrder(1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Person>().Property(p => p.FullName).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Person>().Property(u => u.CreatedOn).HasColumnType("datetime");
            modelBuilder.Entity<Person>().Property(u => u.LastUpdate).HasColumnType("datetime");
            modelBuilder.Entity<Person>().Property(p => p.Picture).HasColumnType("image");
            modelBuilder.Entity<Person>().Property(p => p.Status).IsOptional();
            modelBuilder.Entity<Person>().Property(p => p.Description).IsOptional().IsMaxLength();
            //modelBuilder.Entity<Person>().Property(p => p.RowVersion).IsRowVersion();

            //Relationship
            modelBuilder.Entity<Person>().HasOptional(p => p.SelfUser)
                .WithMany()
                .HasForeignKey(p => p.CreatedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>().HasOptional(p => p.UpdateUser)
                .WithMany()
                .HasForeignKey(p => p.UpdateBy)
                .WillCascadeOnDelete(false);
        }
        private static void ConfigureWeatherConditionEntity(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WeatherCondition>().ToTable("WeatherConditions") //, "nch");
                .HasKey(a => a.Id);
            modelBuilder.Entity<WeatherCondition>().Property(a => a.Id).HasColumnOrder(1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<WeatherCondition>().Property(a => a.Title).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<WeatherCondition>().Property(a => a.CreatedOn).HasColumnType("datetime");
            modelBuilder.Entity<WeatherCondition>().Property(a => a.LastUpdate).HasColumnType("datetime");
            modelBuilder.Entity<WeatherCondition>().Property(a => a.Status).HasMaxLength(50);
            modelBuilder.Entity<WeatherCondition>().Property(a => a.Description).IsOptional().IsMaxLength();
            //modelBuilder.Entity<WeatherCondition>().Property(a => a.RowVersion).IsRowVersion();

            //Relationship
            modelBuilder.Entity<WeatherCondition>().HasOptional(p => p.SelfUser)
                .WithMany()
                .HasForeignKey(p => p.CreatedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WeatherCondition>().HasOptional(p => p.UpdateUser)
                .WithMany()
                .HasForeignKey(p => p.UpdateBy)
                .WillCascadeOnDelete(false);
        }
        private static void ConfigureLogEntity(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Log>().ToTable("Logs") //, "nch");
                .HasKey(r => r.Id);

            modelBuilder.Entity<Log>().Property(r => r.Id).HasColumnOrder(1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Log>().Property(r => r.ShortMessage).HasMaxLength(255).IsRequired();
            modelBuilder.Entity<Log>().Property(r => r.FullMessage).IsMaxLength().IsRequired();
            modelBuilder.Entity<Log>().Property(r => r.FormName).HasMaxLength(500).IsOptional();
            modelBuilder.Entity<Log>().Property(r => r.Action).HasMaxLength(50).IsOptional();
            modelBuilder.Entity<Log>().Property(r => r.CreatedOn).HasColumnType("datetime");
            modelBuilder.Entity<Log>().Property(r => r.LastUpdate).HasColumnType("datetime");
            modelBuilder.Entity<Log>().Property(f => f.Status).IsOptional();
            modelBuilder.Entity<Log>().Property(f => f.Description).IsOptional().IsMaxLength();
            //modelBuilder.Entity<Log>().Property(f => f.Concurrency).IsRowVersion();

            //Relationship
            modelBuilder.Entity<Log>().HasOptional(p => p.SelfUser)
                .WithMany()
                .HasForeignKey(p => p.CreatedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Log>().HasOptional(p => p.UpdateUser)
                .WithMany()
                .HasForeignKey(p => p.UpdateBy)
                .WillCascadeOnDelete(false);
        }
    }
}