//namespace PersonalAccounting.DAL.Migrations
//{
//    using System;
//    using System.Data.Entity.Migrations;
    
//    public partial class initial14000129 : DbMigration
//    {
//        public override void Up()
//        {
//            CreateTable(
//                "nch.Commodities",
//                c => new
//                    {
//                        Id = c.Int(nullable: false, identity: true),
//                        ReceiverId = c.Int(),
//                        CommodityTypeId = c.Int(nullable: false),
//                        ReceivedBy = c.String(maxLength: 2147483647),
//                        CommodityDate = c.DateTime(nullable: false),
//                        CreatedBy = c.Int(),
//                        CreatedOn = c.DateTime(),
//                        LastUpdate = c.DateTime(),
//                        UpdateBy = c.Int(),
//                        IsDeleted = c.Boolean(),
//                        Status = c.String(maxLength: 2147483647),
//                        Description = c.String(maxLength: 2147483647),
//                        Concurrency = c.Binary(),
//                    })
//                .PrimaryKey(t => t.Id)
//                .ForeignKey("nch.CommodityTypes", t => t.CommodityTypeId, cascadeDelete: true)
//                .ForeignKey("nch.Persons", t => t.ReceiverId)
//                .ForeignKey("nch.Users", t => t.CreatedBy)
//                .ForeignKey("nch.Users", t => t.UpdateBy)
//                .Index(t => t.ReceiverId, name: "IX_Commodities_ReceiverId")
//                .Index(t => t.CommodityTypeId, name: "IX_Commodities_CommodityTypeId")
//                .Index(t => t.CreatedBy, name: "IX_Commodities_CreatedBy")
//                .Index(t => t.UpdateBy, name: "IX_Commodities_UpdateBy");
            
//            CreateTable(
//                "nch.CommodityTypes",
//                c => new
//                    {
//                        Id = c.Int(nullable: false, identity: true),
//                        Title = c.String(nullable: false, maxLength: 50),
//                        CreatedBy = c.Int(),
//                        CreatedOn = c.DateTime(),
//                        LastUpdate = c.DateTime(),
//                        UpdateBy = c.Int(),
//                        IsDeleted = c.Boolean(),
//                        Status = c.String(maxLength: 2147483647),
//                        Description = c.String(maxLength: 2147483647),
//                        Concurrency = c.Binary(),
//                    })
//                .PrimaryKey(t => t.Id)
//                .ForeignKey("nch.Users", t => t.CreatedBy)
//                .ForeignKey("nch.Users", t => t.UpdateBy)
//                .Index(t => t.CreatedBy, name: "IX_CommodityTypes_CreatedBy")
//                .Index(t => t.UpdateBy, name: "IX_CommodityTypes_UpdateBy");
            
//            CreateTable(
//                "nch.Users",
//                c => new
//                    {
//                        Id = c.Int(nullable: false, identity: true),
//                        UserName = c.String(nullable: false, maxLength: 256),
//                        Password = c.String(nullable: false, maxLength: 128),
//                        Email = c.String(maxLength: 255),
//                        IsApproved = c.Boolean(nullable: false),
//                        IsLockout = c.Boolean(nullable: false),
//                        PasswordFailuresSinceLastSuccess = c.Int(),
//                        LastPasswordFailureDate = c.DateTime(),
//                        LastActivityDate = c.DateTime(),
//                        LastActiveDurationValue = c.Long(nullable: false),
//                        LastLockoutDate = c.DateTime(),
//                        LastLoginDate = c.DateTime(),
//                        PreviousLastLoginDate = c.DateTime(),
//                        LoginCount = c.Int(),
//                        LastPasswordChangedDate = c.DateTime(),
//                        Ip = c.String(maxLength: 19),
//                        PersonId = c.Int(nullable: false),
//                        CreatedBy = c.Int(),
//                        CreatedOn = c.DateTime(),
//                        LastUpdate = c.DateTime(),
//                        UpdateBy = c.Int(),
//                        IsDeleted = c.Boolean(),
//                        Status = c.String(maxLength: 10),
//                        Description = c.String(maxLength: 2147483647),
//                        Concurrency = c.Binary(),
//                    })
//                .PrimaryKey(t => t.Id)
//                .ForeignKey("nch.Persons", t => t.PersonId, cascadeDelete: true)
//                .ForeignKey("nch.Users", t => t.CreatedBy)
//                .ForeignKey("nch.Users", t => t.UpdateBy)
//                .Index(t => t.UserName, unique: true, name: "IX_Username")
//                .Index(t => t.PersonId, name: "IX_Users_PersonId")
//                .Index(t => t.CreatedBy, name: "IX_Users_CreatedBy")
//                .Index(t => t.UpdateBy, name: "IX_Users_UpdateBy");
            
//            CreateTable(
//                "nch.Persons",
//                c => new
//                    {
//                        Id = c.Int(nullable: false, identity: true),
//                        FullName = c.String(nullable: false, maxLength: 50),
//                        Gender = c.String(maxLength: 2147483647),
//                        Picture = c.Binary(),
//                        CreatedBy = c.Int(),
//                        CreatedOn = c.DateTime(),
//                        LastUpdate = c.DateTime(),
//                        UpdateBy = c.Int(),
//                        IsDeleted = c.Boolean(),
//                        Status = c.String(maxLength: 2147483647),
//                        Description = c.String(maxLength: 2147483647),
//                        Concurrency = c.Binary(),
//                    })
//                .PrimaryKey(t => t.Id)
//                .ForeignKey("nch.Users", t => t.CreatedBy)
//                .ForeignKey("nch.Users", t => t.UpdateBy)
//                .Index(t => t.CreatedBy, name: "IX_Persons_CreatedBy")
//                .Index(t => t.UpdateBy, name: "IX_Persons_UpdateBy");
            
//            CreateTable(
//                "nch.Expenses",
//                c => new
//                    {
//                        Id = c.Int(nullable: false, identity: true),
//                        Row = c.Int(),
//                        ArticleId = c.Int(nullable: false),
//                        FundId = c.Int(),
//                        Rate = c.Double(nullable: false),
//                        Count = c.Double(nullable: false),
//                        Price = c.Double(nullable: false),
//                        ByPersonId = c.Int(nullable: false),
//                        ForPersonId = c.Int(),
//                        MeasurementUnitId = c.Int(),
//                        DocumentId = c.Int(nullable: false),
//                        CreatedBy = c.Int(),
//                        CreatedOn = c.DateTime(),
//                        LastUpdate = c.DateTime(),
//                        UpdateBy = c.Int(),
//                        IsDeleted = c.Boolean(),
//                        Status = c.String(maxLength: 2147483647),
//                        Description = c.String(maxLength: 2147483647),
//                        Concurrency = c.Binary(),
//                        Person_Id = c.Int(),
//                        Person_Id1 = c.Int(),
//                    })
//                .PrimaryKey(t => t.Id)
//                .ForeignKey("nch.Articles", t => t.ArticleId, cascadeDelete: true)
//                .ForeignKey("nch.Persons", t => t.ByPersonId, cascadeDelete: true)
//                .ForeignKey("nch.ExpenseDocuments", t => t.DocumentId, cascadeDelete: true)
//                .ForeignKey("nch.Persons", t => t.ForPersonId)
//                .ForeignKey("nch.Funds", t => t.FundId)
//                .ForeignKey("nch.MeasurementUnits", t => t.MeasurementUnitId)
//                .ForeignKey("nch.Users", t => t.CreatedBy)
//                .ForeignKey("nch.Users", t => t.UpdateBy)
//                .ForeignKey("nch.Persons", t => t.Person_Id)
//                .ForeignKey("nch.Persons", t => t.Person_Id1)
//                .Index(t => t.ArticleId, name: "IX_Expenses_ArticleId")
//                .Index(t => t.FundId, name: "IX_Expenses_FundId")
//                .Index(t => t.ByPersonId, name: "IX_Expenses_ByPersonId")
//                .Index(t => t.ForPersonId, name: "IX_Expenses_ForPersonId")
//                .Index(t => t.MeasurementUnitId, name: "IX_Expenses_MeasurementUnitId")
//                .Index(t => t.DocumentId, name: "IX_Expenses_DocumentId")
//                .Index(t => t.CreatedBy, name: "IX_Expenses_CreatedBy")
//                .Index(t => t.UpdateBy, name: "IX_Expenses_UpdateBy")
//                .Index(t => t.Person_Id, name: "IX_Expenses_Person_Id")
//                .Index(t => t.Person_Id1, name: "IX_Expenses_Person_Id1");
            
//            CreateTable(
//                "nch.Articles",
//                c => new
//                    {
//                        Id = c.Int(nullable: false, identity: true),
//                        Name = c.String(nullable: false, maxLength: 50),
//                        LatinName = c.String(maxLength: 50),
//                        GroupId = c.Int(),
//                        Picture = c.Binary(),
//                        CreatedBy = c.Int(),
//                        CreatedOn = c.DateTime(),
//                        LastUpdate = c.DateTime(),
//                        UpdateBy = c.Int(),
//                        IsDeleted = c.Boolean(),
//                        Status = c.String(maxLength: 50),
//                        Description = c.String(maxLength: 2147483647),
//                        Concurrency = c.Binary(),
//                    })
//                .PrimaryKey(t => t.Id)
//                .ForeignKey("nch.ArticleGroups", t => t.GroupId)
//                .ForeignKey("nch.Users", t => t.CreatedBy)
//                .ForeignKey("nch.Users", t => t.UpdateBy)
//                .Index(t => t.GroupId, name: "IX_Articles_GroupId")
//                .Index(t => t.CreatedBy, name: "IX_Articles_CreatedBy")
//                .Index(t => t.UpdateBy, name: "IX_Articles_UpdateBy");
            
//            CreateTable(
//                "nch.ArticleGroups",
//                c => new
//                    {
//                        Id = c.Int(nullable: false, identity: true),
//                        Name = c.String(nullable: false, maxLength: 50),
//                        LatinName = c.String(maxLength: 2147483647),
//                        CreatedBy = c.Int(),
//                        CreatedOn = c.DateTime(),
//                        LastUpdate = c.DateTime(),
//                        UpdateBy = c.Int(),
//                        IsDeleted = c.Boolean(),
//                        Status = c.String(maxLength: 2147483647),
//                        Description = c.String(maxLength: 2147483647),
//                        Concurrency = c.Binary(),
//                    })
//                .PrimaryKey(t => t.Id)
//                .ForeignKey("nch.Users", t => t.CreatedBy)
//                .ForeignKey("nch.Users", t => t.UpdateBy)
//                .Index(t => t.CreatedBy, name: "IX_ArticleGroups_CreatedBy")
//                .Index(t => t.UpdateBy, name: "IX_ArticleGroups_UpdateBy");
            
//            CreateTable(
//                "nch.MeasurementUnits",
//                c => new
//                    {
//                        Id = c.Int(nullable: false, identity: true),
//                        Name = c.String(nullable: false, maxLength: 50),
//                        CreatedBy = c.Int(),
//                        CreatedOn = c.DateTime(),
//                        LastUpdate = c.DateTime(),
//                        UpdateBy = c.Int(),
//                        IsDeleted = c.Boolean(),
//                        Status = c.String(maxLength: 2147483647),
//                        Description = c.String(maxLength: 2147483647),
//                        Concurrency = c.Binary(),
//                    })
//                .PrimaryKey(t => t.Id)
//                .ForeignKey("nch.Users", t => t.CreatedBy)
//                .ForeignKey("nch.Users", t => t.UpdateBy)
//                .Index(t => t.CreatedBy, name: "IX_MeasurementUnits_CreatedBy")
//                .Index(t => t.UpdateBy, name: "IX_MeasurementUnits_UpdateBy");
            
//            CreateTable(
//                "nch.ExpenseDocuments",
//                c => new
//                    {
//                        Id = c.Int(nullable: false, identity: true),
//                        RegisterDate = c.DateTime(),
//                        CreatedBy = c.Int(),
//                        CreatedOn = c.DateTime(),
//                        LastUpdate = c.DateTime(),
//                        UpdateBy = c.Int(),
//                        IsDeleted = c.Boolean(),
//                        Status = c.String(maxLength: 2147483647),
//                        Description = c.String(maxLength: 2147483647),
//                        Concurrency = c.Binary(),
//                    })
//                .PrimaryKey(t => t.Id)
//                .ForeignKey("nch.Users", t => t.CreatedBy)
//                .ForeignKey("nch.Users", t => t.UpdateBy)
//                .Index(t => t.CreatedBy, name: "IX_ExpenseDocuments_CreatedBy")
//                .Index(t => t.UpdateBy, name: "IX_ExpenseDocuments_UpdateBy");
            
//            CreateTable(
//                "nch.Funds",
//                c => new
//                    {
//                        Id = c.Int(nullable: false, identity: true),
//                        Type = c.Int(nullable: false),
//                        Title = c.String(nullable: false, maxLength: 50),
//                        BankAccountId = c.Int(),
//                        PrimaryValue = c.Double(nullable: false),
//                        CurrentValue = c.Double(nullable: false),
//                        CreatedBy = c.Int(),
//                        CreatedOn = c.DateTime(),
//                        LastUpdate = c.DateTime(),
//                        UpdateBy = c.Int(),
//                        IsDeleted = c.Boolean(),
//                        Status = c.String(maxLength: 2147483647),
//                        Description = c.String(maxLength: 2147483647),
//                        Concurrency = c.Binary(),
//                    })
//                .PrimaryKey(t => t.Id)
//                .ForeignKey("nch.BankAccounts", t => t.BankAccountId)
//                .ForeignKey("nch.Users", t => t.CreatedBy)
//                .ForeignKey("nch.Users", t => t.UpdateBy)
//                .Index(t => t.BankAccountId, name: "IX_Funds_BankAccountId")
//                .Index(t => t.CreatedBy, name: "IX_Funds_CreatedBy")
//                .Index(t => t.UpdateBy, name: "IX_Funds_UpdateBy");
            
//            CreateTable(
//                "nch.BankAccounts",
//                c => new
//                    {
//                        Id = c.Int(nullable: false, identity: true),
//                        Name = c.String(nullable: false, maxLength: 50),
//                        AccountNumber = c.String(nullable: false, maxLength: 50),
//                        BankId = c.Int(nullable: false),
//                        PersonId = c.Int(nullable: false),
//                        CreatedBy = c.Int(),
//                        CreatedOn = c.DateTime(),
//                        LastUpdate = c.DateTime(),
//                        UpdateBy = c.Int(),
//                        IsDeleted = c.Boolean(),
//                        Status = c.String(maxLength: 2147483647),
//                        Description = c.String(maxLength: 2147483647),
//                        Concurrency = c.Binary(),
//                    })
//                .PrimaryKey(t => t.Id)
//                .ForeignKey("nch.Banks", t => t.BankId, cascadeDelete: true)
//                .ForeignKey("nch.Persons", t => t.PersonId, cascadeDelete: true)
//                .ForeignKey("nch.Users", t => t.CreatedBy)
//                .ForeignKey("nch.Users", t => t.UpdateBy)
//                .Index(t => t.BankId, name: "IX_BankAccounts_BankId")
//                .Index(t => t.PersonId, name: "IX_BankAccounts_PersonId")
//                .Index(t => t.CreatedBy, name: "IX_BankAccounts_CreatedBy")
//                .Index(t => t.UpdateBy, name: "IX_BankAccounts_UpdateBy");
            
//            CreateTable(
//                "nch.Banks",
//                c => new
//                    {
//                        Id = c.Int(nullable: false, identity: true),
//                        Name = c.String(nullable: false, maxLength: 50),
//                        Department = c.String(nullable: false, maxLength: 50),
//                        CreatedBy = c.Int(),
//                        CreatedOn = c.DateTime(),
//                        LastUpdate = c.DateTime(),
//                        UpdateBy = c.Int(),
//                        IsDeleted = c.Boolean(),
//                        Status = c.String(maxLength: 2147483647),
//                        Description = c.String(maxLength: 2147483647),
//                        Concurrency = c.Binary(),
//                    })
//                .PrimaryKey(t => t.Id)
//                .ForeignKey("nch.Users", t => t.CreatedBy)
//                .ForeignKey("nch.Users", t => t.UpdateBy)
//                .Index(t => t.CreatedBy, name: "IX_Banks_CreatedBy")
//                .Index(t => t.UpdateBy, name: "IX_Banks_UpdateBy");
            
//            CreateTable(
//                "nch.Roles",
//                c => new
//                    {
//                        Id = c.Int(nullable: false, identity: true),
//                        Name = c.String(nullable: false, maxLength: 50),
//                        CreatedBy = c.Int(),
//                        CreatedOn = c.DateTime(),
//                        LastUpdate = c.DateTime(),
//                        UpdateBy = c.Int(),
//                        IsDeleted = c.Boolean(),
//                        Status = c.String(maxLength: 2147483647),
//                        Description = c.String(maxLength: 2147483647),
//                        Concurrency = c.Binary(),
//                    })
//                .PrimaryKey(t => t.Id)
//                .ForeignKey("nch.Users", t => t.CreatedBy)
//                .ForeignKey("nch.Users", t => t.UpdateBy)
//                .Index(t => t.CreatedBy, name: "IX_Roles_CreatedBy")
//                .Index(t => t.UpdateBy, name: "IX_Roles_UpdateBy");
            
//            CreateTable(
//                "nch.Permissions",
//                c => new
//                    {
//                        Id = c.Int(nullable: false, identity: true),
//                        SystemName = c.String(maxLength: 2147483647),
//                        Name = c.String(nullable: false, maxLength: 50),
//                        IsSelected = c.Boolean(nullable: false),
//                        CreatedBy = c.Int(),
//                        CreatedOn = c.DateTime(),
//                        LastUpdate = c.DateTime(),
//                        UpdateBy = c.Int(),
//                        IsDeleted = c.Boolean(),
//                        Status = c.String(maxLength: 2147483647),
//                        Description = c.String(maxLength: 2147483647),
//                        Concurrency = c.Binary(),
//                    })
//                .PrimaryKey(t => t.Id)
//                .ForeignKey("nch.Users", t => t.CreatedBy)
//                .ForeignKey("nch.Users", t => t.UpdateBy)
//                .Index(t => t.CreatedBy, name: "IX_Permissions_CreatedBy")
//                .Index(t => t.UpdateBy, name: "IX_Permissions_UpdateBy");
            
//            CreateTable(
//                "nch.FormEntities",
//                c => new
//                    {
//                        Id = c.Int(nullable: false, identity: true),
//                        Name = c.String(nullable: false, maxLength: 255),
//                        SystemName = c.String(nullable: false, maxLength: 200),
//                        CreatedBy = c.Int(),
//                        CreatedOn = c.DateTime(),
//                        LastUpdate = c.DateTime(),
//                        UpdateBy = c.Int(),
//                        IsDeleted = c.Boolean(),
//                        Status = c.String(maxLength: 2147483647),
//                        Description = c.String(maxLength: 2147483647),
//                        Concurrency = c.Binary(),
//                    })
//                .PrimaryKey(t => t.Id)
//                .ForeignKey("nch.Users", t => t.CreatedBy)
//                .ForeignKey("nch.Users", t => t.UpdateBy)
//                .Index(t => t.CreatedBy, name: "IX_FormEntities_CreatedBy")
//                .Index(t => t.UpdateBy, name: "IX_FormEntities_UpdateBy");
            
//            CreateTable(
//                "nch.Logs",
//                c => new
//                    {
//                        Id = c.Int(nullable: false, identity: true),
//                        LogLevelId = c.Int(nullable: false),
//                        ShortMessage = c.String(nullable: false, maxLength: 255),
//                        FullMessage = c.String(nullable: false, maxLength: 2147483647),
//                        FormName = c.String(maxLength: 500),
//                        Action = c.String(maxLength: 50),
//                        LogLevel = c.Int(nullable: false),
//                        CreatedBy = c.Int(),
//                        CreatedOn = c.DateTime(),
//                        LastUpdate = c.DateTime(),
//                        UpdateBy = c.Int(),
//                        IsDeleted = c.Boolean(),
//                        Status = c.String(maxLength: 2147483647),
//                        Description = c.String(maxLength: 2147483647),
//                        Concurrency = c.Binary(),
//                    })
//                .PrimaryKey(t => t.Id)
//                .ForeignKey("nch.Users", t => t.CreatedBy)
//                .ForeignKey("nch.Users", t => t.UpdateBy)
//                .Index(t => t.CreatedBy, name: "IX_Logs_CreatedBy")
//                .Index(t => t.UpdateBy, name: "IX_Logs_UpdateBy");
            
//            CreateTable(
//                "nch.MentalConditions",
//                c => new
//                    {
//                        Id = c.Int(nullable: false, identity: true),
//                        Title = c.String(nullable: false, maxLength: 50),
//                        Picture = c.Binary(),
//                        CreatedBy = c.Int(),
//                        CreatedOn = c.DateTime(),
//                        LastUpdate = c.DateTime(),
//                        UpdateBy = c.Int(),
//                        IsDeleted = c.Boolean(),
//                        Status = c.String(maxLength: 50),
//                        Description = c.String(maxLength: 2147483647),
//                        Concurrency = c.Binary(),
//                    })
//                .PrimaryKey(t => t.Id)
//                .ForeignKey("nch.Users", t => t.CreatedBy)
//                .ForeignKey("nch.Users", t => t.UpdateBy)
//                .Index(t => t.CreatedBy, name: "IX_MentalConditions_CreatedBy")
//                .Index(t => t.UpdateBy, name: "IX_MentalConditions_UpdateBy");
            
//            CreateTable(
//                "nch.DiaryNotes",
//                c => new
//                    {
//                        Id = c.Int(nullable: false, identity: true),
//                        Date = c.DateTime(nullable: false),
//                        Note = c.String(maxLength: 2147483647),
//                        WeatherConditionId = c.Int(),
//                        MentalConditionId = c.Int(),
//                        CreatedBy = c.Int(),
//                        CreatedOn = c.DateTime(),
//                        LastUpdate = c.DateTime(),
//                        UpdateBy = c.Int(),
//                        IsDeleted = c.Boolean(),
//                        Status = c.String(maxLength: 2147483647),
//                        Description = c.String(maxLength: 2147483647),
//                        Concurrency = c.Binary(),
//                    })
//                .PrimaryKey(t => t.Id)
//                .ForeignKey("nch.MentalConditions", t => t.MentalConditionId)
//                .ForeignKey("nch.Users", t => t.CreatedBy)
//                .ForeignKey("nch.Users", t => t.UpdateBy)
//                .ForeignKey("nch.WeatherConditions", t => t.WeatherConditionId)
//                .Index(t => t.WeatherConditionId, name: "IX_DiaryNotes_WeatherConditionId")
//                .Index(t => t.MentalConditionId, name: "IX_DiaryNotes_MentalConditionId")
//                .Index(t => t.CreatedBy, name: "IX_DiaryNotes_CreatedBy")
//                .Index(t => t.UpdateBy, name: "IX_DiaryNotes_UpdateBy");
            
//            CreateTable(
//                "nch.WeatherConditions",
//                c => new
//                    {
//                        Id = c.Int(nullable: false, identity: true),
//                        Title = c.String(nullable: false, maxLength: 50),
//                        Picture = c.Binary(),
//                        CreatedBy = c.Int(),
//                        CreatedOn = c.DateTime(),
//                        LastUpdate = c.DateTime(),
//                        UpdateBy = c.Int(),
//                        IsDeleted = c.Boolean(),
//                        Status = c.String(maxLength: 50),
//                        Description = c.String(maxLength: 2147483647),
//                        Concurrency = c.Binary(),
//                    })
//                .PrimaryKey(t => t.Id)
//                .ForeignKey("nch.Users", t => t.CreatedBy)
//                .ForeignKey("nch.Users", t => t.UpdateBy)
//                .Index(t => t.CreatedBy, name: "IX_WeatherConditions_CreatedBy")
//                .Index(t => t.UpdateBy, name: "IX_WeatherConditions_UpdateBy");
            
//            CreateTable(
//                "nch.TransferMonies",
//                c => new
//                    {
//                        Id = c.Int(nullable: false, identity: true),
//                        Amount = c.Double(nullable: false),
//                        OriginFundId = c.Int(nullable: false),
//                        DestinationFundId = c.Int(nullable: false),
//                        BankCommission = c.Double(nullable: false),
//                        CreatedBy = c.Int(),
//                        CreatedOn = c.DateTime(),
//                        LastUpdate = c.DateTime(),
//                        UpdateBy = c.Int(),
//                        IsDeleted = c.Boolean(),
//                        Status = c.String(maxLength: 2147483647),
//                        Description = c.String(maxLength: 2147483647),
//                        Concurrency = c.Binary(),
//                    })
//                .PrimaryKey(t => t.Id)
//                .ForeignKey("nch.Funds", t => t.DestinationFundId, cascadeDelete: true)
//                .ForeignKey("nch.Funds", t => t.OriginFundId, cascadeDelete: true)
//                .ForeignKey("nch.Users", t => t.CreatedBy)
//                .ForeignKey("nch.Users", t => t.UpdateBy)
//                .Index(t => t.OriginFundId, name: "IX_TransferMonies_OriginFundId")
//                .Index(t => t.DestinationFundId, name: "IX_TransferMonies_DestinationFundId")
//                .Index(t => t.CreatedBy, name: "IX_TransferMonies_CreatedBy")
//                .Index(t => t.UpdateBy, name: "IX_TransferMonies_UpdateBy");
            
//            CreateTable(
//                "nch.Incomes",
//                c => new
//                    {
//                        Id = c.Int(nullable: false, identity: true),
//                        TypeId = c.Int(nullable: false),
//                        ReceivedBy = c.String(maxLength: 2147483647),
//                        FundId = c.Int(nullable: false),
//                        FundCurrentValue = c.Double(nullable: false),
//                        IncomeDate = c.DateTime(nullable: false),
//                        Amount = c.Double(nullable: false),
//                        CreatedBy = c.Int(),
//                        CreatedOn = c.DateTime(),
//                        LastUpdate = c.DateTime(),
//                        UpdateBy = c.Int(),
//                        IsDeleted = c.Boolean(),
//                        Status = c.String(maxLength: 2147483647),
//                        Description = c.String(maxLength: 2147483647),
//                        Concurrency = c.Binary(),
//                    })
//                .PrimaryKey(t => t.Id)
//                .ForeignKey("nch.Funds", t => t.FundId, cascadeDelete: true)
//                .ForeignKey("nch.IncomeTypes", t => t.TypeId, cascadeDelete: true)
//                .ForeignKey("nch.Users", t => t.CreatedBy)
//                .ForeignKey("nch.Users", t => t.UpdateBy)
//                .Index(t => t.TypeId, name: "IX_Incomes_TypeId")
//                .Index(t => t.FundId, name: "IX_Incomes_FundId")
//                .Index(t => t.CreatedBy, name: "IX_Incomes_CreatedBy")
//                .Index(t => t.UpdateBy, name: "IX_Incomes_UpdateBy");
            
//            CreateTable(
//                "nch.IncomeTypes",
//                c => new
//                    {
//                        Id = c.Int(nullable: false, identity: true),
//                        Title = c.String(nullable: false, maxLength: 50),
//                        CreatedBy = c.Int(),
//                        CreatedOn = c.DateTime(),
//                        LastUpdate = c.DateTime(),
//                        UpdateBy = c.Int(),
//                        IsDeleted = c.Boolean(),
//                        Status = c.String(maxLength: 2147483647),
//                        Description = c.String(maxLength: 2147483647),
//                        Concurrency = c.Binary(),
//                    })
//                .PrimaryKey(t => t.Id)
//                .ForeignKey("nch.Users", t => t.CreatedBy)
//                .ForeignKey("nch.Users", t => t.UpdateBy)
//                .Index(t => t.CreatedBy, name: "IX_IncomeTypes_CreatedBy")
//                .Index(t => t.UpdateBy, name: "IX_IncomeTypes_UpdateBy");
            
//            CreateTable(
//                "nch.SqliteCustomHistories",
//                c => new
//                    {
//                        Id = c.Int(nullable: false, identity: true),
//                        Hash = c.String(maxLength: 2147483647),
//                        Context = c.String(maxLength: 2147483647),
//                        CreateDate = c.DateTime(nullable: false),
//                    })
//                .PrimaryKey(t => t.Id);
            
//            CreateTable(
//                "nch.ArticleMeasurementUnits",
//                c => new
//                    {
//                        ArticleId = c.Int(nullable: false),
//                        MeasurementUnitId = c.Int(nullable: false),
//                    })
//                .PrimaryKey(t => new { t.ArticleId, t.MeasurementUnitId })
//                .ForeignKey("nch.Articles", t => t.ArticleId, cascadeDelete: true)
//                .ForeignKey("nch.MeasurementUnits", t => t.MeasurementUnitId, cascadeDelete: true)
//                .Index(t => t.ArticleId, name: "IX_ArticleMeasurementUnits_ArticleId")
//                .Index(t => t.MeasurementUnitId, name: "IX_ArticleMeasurementUnits_MeasurementUnitId");
            
//            CreateTable(
//                "nch.FormEntityPermissions",
//                c => new
//                    {
//                        PermissionId = c.Int(nullable: false),
//                        FormEntityId = c.Int(nullable: false),
//                    })
//                .PrimaryKey(t => new { t.PermissionId, t.FormEntityId })
//                .ForeignKey("nch.Permissions", t => t.PermissionId, cascadeDelete: true)
//                .ForeignKey("nch.FormEntities", t => t.FormEntityId, cascadeDelete: true)
//                .Index(t => t.PermissionId, name: "IX_FormEntityPermissions_PermissionId")
//                .Index(t => t.FormEntityId, name: "IX_FormEntityPermissions_FormEntityId");
            
//            CreateTable(
//                "nch.RolePermissions",
//                c => new
//                    {
//                        PermissionId = c.Int(nullable: false),
//                        RoleId = c.Int(nullable: false),
//                    })
//                .PrimaryKey(t => new { t.PermissionId, t.RoleId })
//                .ForeignKey("nch.Permissions", t => t.PermissionId, cascadeDelete: true)
//                .ForeignKey("nch.Roles", t => t.RoleId, cascadeDelete: true)
//                .Index(t => t.PermissionId, name: "IX_RolePermissions_PermissionId")
//                .Index(t => t.RoleId, name: "IX_RolePermissions_RoleId");
            
//            CreateTable(
//                "nch.UserRoles",
//                c => new
//                    {
//                        UserId = c.Int(nullable: false),
//                        RoleId = c.Int(nullable: false),
//                    })
//                .PrimaryKey(t => new { t.UserId, t.RoleId })
//                .ForeignKey("nch.Users", t => t.UserId, cascadeDelete: true)
//                .ForeignKey("nch.Roles", t => t.RoleId, cascadeDelete: true)
//                .Index(t => t.UserId, name: "IX_UserRoles_UserId")
//                .Index(t => t.RoleId, name: "IX_UserRoles_RoleId");
            
//        }
        
//        public override void Down()
//        {
//            DropForeignKey("nch.Incomes", "UpdateBy", "nch.Users");
//            DropForeignKey("nch.Incomes", "CreatedBy", "nch.Users");
//            DropForeignKey("nch.Incomes", "TypeId", "nch.IncomeTypes");
//            DropForeignKey("nch.IncomeTypes", "UpdateBy", "nch.Users");
//            DropForeignKey("nch.IncomeTypes", "CreatedBy", "nch.Users");
//            DropForeignKey("nch.Incomes", "FundId", "nch.Funds");
//            DropForeignKey("nch.TransferMonies", "UpdateBy", "nch.Users");
//            DropForeignKey("nch.TransferMonies", "CreatedBy", "nch.Users");
//            DropForeignKey("nch.TransferMonies", "OriginFundId", "nch.Funds");
//            DropForeignKey("nch.TransferMonies", "DestinationFundId", "nch.Funds");
//            DropForeignKey("nch.MentalConditions", "UpdateBy", "nch.Users");
//            DropForeignKey("nch.MentalConditions", "CreatedBy", "nch.Users");
//            DropForeignKey("nch.DiaryNotes", "WeatherConditionId", "nch.WeatherConditions");
//            DropForeignKey("nch.WeatherConditions", "UpdateBy", "nch.Users");
//            DropForeignKey("nch.WeatherConditions", "CreatedBy", "nch.Users");
//            DropForeignKey("nch.DiaryNotes", "UpdateBy", "nch.Users");
//            DropForeignKey("nch.DiaryNotes", "CreatedBy", "nch.Users");
//            DropForeignKey("nch.DiaryNotes", "MentalConditionId", "nch.MentalConditions");
//            DropForeignKey("nch.Logs", "UpdateBy", "nch.Users");
//            DropForeignKey("nch.Logs", "CreatedBy", "nch.Users");
//            DropForeignKey("nch.Commodities", "UpdateBy", "nch.Users");
//            DropForeignKey("nch.Commodities", "CreatedBy", "nch.Users");
//            DropForeignKey("nch.Commodities", "ReceiverId", "nch.Persons");
//            DropForeignKey("nch.Commodities", "CommodityTypeId", "nch.CommodityTypes");
//            DropForeignKey("nch.CommodityTypes", "UpdateBy", "nch.Users");
//            DropForeignKey("nch.CommodityTypes", "CreatedBy", "nch.Users");
//            DropForeignKey("nch.Users", "UpdateBy", "nch.Users");
//            DropForeignKey("nch.Users", "CreatedBy", "nch.Users");
//            DropForeignKey("nch.UserRoles", "RoleId", "nch.Roles");
//            DropForeignKey("nch.UserRoles", "UserId", "nch.Users");
//            DropForeignKey("nch.Roles", "UpdateBy", "nch.Users");
//            DropForeignKey("nch.Roles", "CreatedBy", "nch.Users");
//            DropForeignKey("nch.Permissions", "UpdateBy", "nch.Users");
//            DropForeignKey("nch.Permissions", "CreatedBy", "nch.Users");
//            DropForeignKey("nch.RolePermissions", "RoleId", "nch.Roles");
//            DropForeignKey("nch.RolePermissions", "PermissionId", "nch.Permissions");
//            DropForeignKey("nch.FormEntityPermissions", "FormEntityId", "nch.FormEntities");
//            DropForeignKey("nch.FormEntityPermissions", "PermissionId", "nch.Permissions");
//            DropForeignKey("nch.FormEntities", "UpdateBy", "nch.Users");
//            DropForeignKey("nch.FormEntities", "CreatedBy", "nch.Users");
//            DropForeignKey("nch.Users", "PersonId", "nch.Persons");
//            DropForeignKey("nch.Persons", "UpdateBy", "nch.Users");
//            DropForeignKey("nch.Persons", "CreatedBy", "nch.Users");
//            DropForeignKey("nch.Expenses", "Person_Id1", "nch.Persons");
//            DropForeignKey("nch.Expenses", "Person_Id", "nch.Persons");
//            DropForeignKey("nch.Expenses", "UpdateBy", "nch.Users");
//            DropForeignKey("nch.Expenses", "CreatedBy", "nch.Users");
//            DropForeignKey("nch.Expenses", "MeasurementUnitId", "nch.MeasurementUnits");
//            DropForeignKey("nch.Expenses", "FundId", "nch.Funds");
//            DropForeignKey("nch.Funds", "UpdateBy", "nch.Users");
//            DropForeignKey("nch.Funds", "CreatedBy", "nch.Users");
//            DropForeignKey("nch.Funds", "BankAccountId", "nch.BankAccounts");
//            DropForeignKey("nch.BankAccounts", "UpdateBy", "nch.Users");
//            DropForeignKey("nch.BankAccounts", "CreatedBy", "nch.Users");
//            DropForeignKey("nch.BankAccounts", "PersonId", "nch.Persons");
//            DropForeignKey("nch.BankAccounts", "BankId", "nch.Banks");
//            DropForeignKey("nch.Banks", "UpdateBy", "nch.Users");
//            DropForeignKey("nch.Banks", "CreatedBy", "nch.Users");
//            DropForeignKey("nch.Expenses", "ForPersonId", "nch.Persons");
//            DropForeignKey("nch.ExpenseDocuments", "UpdateBy", "nch.Users");
//            DropForeignKey("nch.ExpenseDocuments", "CreatedBy", "nch.Users");
//            DropForeignKey("nch.Expenses", "DocumentId", "nch.ExpenseDocuments");
//            DropForeignKey("nch.Expenses", "ByPersonId", "nch.Persons");
//            DropForeignKey("nch.Expenses", "ArticleId", "nch.Articles");
//            DropForeignKey("nch.Articles", "UpdateBy", "nch.Users");
//            DropForeignKey("nch.Articles", "CreatedBy", "nch.Users");
//            DropForeignKey("nch.ArticleMeasurementUnits", "MeasurementUnitId", "nch.MeasurementUnits");
//            DropForeignKey("nch.ArticleMeasurementUnits", "ArticleId", "nch.Articles");
//            DropForeignKey("nch.MeasurementUnits", "UpdateBy", "nch.Users");
//            DropForeignKey("nch.MeasurementUnits", "CreatedBy", "nch.Users");
//            DropForeignKey("nch.Articles", "GroupId", "nch.ArticleGroups");
//            DropForeignKey("nch.ArticleGroups", "UpdateBy", "nch.Users");
//            DropForeignKey("nch.ArticleGroups", "CreatedBy", "nch.Users");
//            DropIndex("nch.UserRoles", "IX_UserRoles_RoleId");
//            DropIndex("nch.UserRoles", "IX_UserRoles_UserId");
//            DropIndex("nch.RolePermissions", "IX_RolePermissions_RoleId");
//            DropIndex("nch.RolePermissions", "IX_RolePermissions_PermissionId");
//            DropIndex("nch.FormEntityPermissions", "IX_FormEntityPermissions_FormEntityId");
//            DropIndex("nch.FormEntityPermissions", "IX_FormEntityPermissions_PermissionId");
//            DropIndex("nch.ArticleMeasurementUnits", "IX_ArticleMeasurementUnits_MeasurementUnitId");
//            DropIndex("nch.ArticleMeasurementUnits", "IX_ArticleMeasurementUnits_ArticleId");
//            DropIndex("nch.IncomeTypes", "IX_IncomeTypes_UpdateBy");
//            DropIndex("nch.IncomeTypes", "IX_IncomeTypes_CreatedBy");
//            DropIndex("nch.Incomes", "IX_Incomes_UpdateBy");
//            DropIndex("nch.Incomes", "IX_Incomes_CreatedBy");
//            DropIndex("nch.Incomes", "IX_Incomes_FundId");
//            DropIndex("nch.Incomes", "IX_Incomes_TypeId");
//            DropIndex("nch.TransferMonies", "IX_TransferMonies_UpdateBy");
//            DropIndex("nch.TransferMonies", "IX_TransferMonies_CreatedBy");
//            DropIndex("nch.TransferMonies", "IX_TransferMonies_DestinationFundId");
//            DropIndex("nch.TransferMonies", "IX_TransferMonies_OriginFundId");
//            DropIndex("nch.WeatherConditions", "IX_WeatherConditions_UpdateBy");
//            DropIndex("nch.WeatherConditions", "IX_WeatherConditions_CreatedBy");
//            DropIndex("nch.DiaryNotes", "IX_DiaryNotes_UpdateBy");
//            DropIndex("nch.DiaryNotes", "IX_DiaryNotes_CreatedBy");
//            DropIndex("nch.DiaryNotes", "IX_DiaryNotes_MentalConditionId");
//            DropIndex("nch.DiaryNotes", "IX_DiaryNotes_WeatherConditionId");
//            DropIndex("nch.MentalConditions", "IX_MentalConditions_UpdateBy");
//            DropIndex("nch.MentalConditions", "IX_MentalConditions_CreatedBy");
//            DropIndex("nch.Logs", "IX_Logs_UpdateBy");
//            DropIndex("nch.Logs", "IX_Logs_CreatedBy");
//            DropIndex("nch.FormEntities", "IX_FormEntities_UpdateBy");
//            DropIndex("nch.FormEntities", "IX_FormEntities_CreatedBy");
//            DropIndex("nch.Permissions", "IX_Permissions_UpdateBy");
//            DropIndex("nch.Permissions", "IX_Permissions_CreatedBy");
//            DropIndex("nch.Roles", "IX_Roles_UpdateBy");
//            DropIndex("nch.Roles", "IX_Roles_CreatedBy");
//            DropIndex("nch.Banks", "IX_Banks_UpdateBy");
//            DropIndex("nch.Banks", "IX_Banks_CreatedBy");
//            DropIndex("nch.BankAccounts", "IX_BankAccounts_UpdateBy");
//            DropIndex("nch.BankAccounts", "IX_BankAccounts_CreatedBy");
//            DropIndex("nch.BankAccounts", "IX_BankAccounts_PersonId");
//            DropIndex("nch.BankAccounts", "IX_BankAccounts_BankId");
//            DropIndex("nch.Funds", "IX_Funds_UpdateBy");
//            DropIndex("nch.Funds", "IX_Funds_CreatedBy");
//            DropIndex("nch.Funds", "IX_Funds_BankAccountId");
//            DropIndex("nch.ExpenseDocuments", "IX_ExpenseDocuments_UpdateBy");
//            DropIndex("nch.ExpenseDocuments", "IX_ExpenseDocuments_CreatedBy");
//            DropIndex("nch.MeasurementUnits", "IX_MeasurementUnits_UpdateBy");
//            DropIndex("nch.MeasurementUnits", "IX_MeasurementUnits_CreatedBy");
//            DropIndex("nch.ArticleGroups", "IX_ArticleGroups_UpdateBy");
//            DropIndex("nch.ArticleGroups", "IX_ArticleGroups_CreatedBy");
//            DropIndex("nch.Articles", "IX_Articles_UpdateBy");
//            DropIndex("nch.Articles", "IX_Articles_CreatedBy");
//            DropIndex("nch.Articles", "IX_Articles_GroupId");
//            DropIndex("nch.Expenses", "IX_Expenses_Person_Id1");
//            DropIndex("nch.Expenses", "IX_Expenses_Person_Id");
//            DropIndex("nch.Expenses", "IX_Expenses_UpdateBy");
//            DropIndex("nch.Expenses", "IX_Expenses_CreatedBy");
//            DropIndex("nch.Expenses", "IX_Expenses_DocumentId");
//            DropIndex("nch.Expenses", "IX_Expenses_MeasurementUnitId");
//            DropIndex("nch.Expenses", "IX_Expenses_ForPersonId");
//            DropIndex("nch.Expenses", "IX_Expenses_ByPersonId");
//            DropIndex("nch.Expenses", "IX_Expenses_FundId");
//            DropIndex("nch.Expenses", "IX_Expenses_ArticleId");
//            DropIndex("nch.Persons", "IX_Persons_UpdateBy");
//            DropIndex("nch.Persons", "IX_Persons_CreatedBy");
//            DropIndex("nch.Users", "IX_Users_UpdateBy");
//            DropIndex("nch.Users", "IX_Users_CreatedBy");
//            DropIndex("nch.Users", "IX_Users_PersonId");
//            DropIndex("nch.Users", "IX_Username");
//            DropIndex("nch.CommodityTypes", "IX_CommodityTypes_UpdateBy");
//            DropIndex("nch.CommodityTypes", "IX_CommodityTypes_CreatedBy");
//            DropIndex("nch.Commodities", "IX_Commodities_UpdateBy");
//            DropIndex("nch.Commodities", "IX_Commodities_CreatedBy");
//            DropIndex("nch.Commodities", "IX_Commodities_CommodityTypeId");
//            DropIndex("nch.Commodities", "IX_Commodities_ReceiverId");
//            DropTable("nch.UserRoles");
//            DropTable("nch.RolePermissions");
//            DropTable("nch.FormEntityPermissions");
//            DropTable("nch.ArticleMeasurementUnits");
//            DropTable("nch.SqliteCustomHistories");
//            DropTable("nch.IncomeTypes");
//            DropTable("nch.Incomes");
//            DropTable("nch.TransferMonies");
//            DropTable("nch.WeatherConditions");
//            DropTable("nch.DiaryNotes");
//            DropTable("nch.MentalConditions");
//            DropTable("nch.Logs");
//            DropTable("nch.FormEntities");
//            DropTable("nch.Permissions");
//            DropTable("nch.Roles");
//            DropTable("nch.Banks");
//            DropTable("nch.BankAccounts");
//            DropTable("nch.Funds");
//            DropTable("nch.ExpenseDocuments");
//            DropTable("nch.MeasurementUnits");
//            DropTable("nch.ArticleGroups");
//            DropTable("nch.Articles");
//            DropTable("nch.Expenses");
//            DropTable("nch.Persons");
//            DropTable("nch.Users");
//            DropTable("nch.CommodityTypes");
//            DropTable("nch.Commodities");
//        }
//    }
//}
