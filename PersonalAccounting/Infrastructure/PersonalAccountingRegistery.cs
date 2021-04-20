using PersonalAccounting.BLL.IService;
using PersonalAccounting.BLL.Service;
using PersonalAccounting.DAL.Infrastructure;
using PersonalAccounting.Domain.Entity;
using PersonalAccounting.Domain.ViewModel;
using PersonalAccounting.UI.Helper;
using StructureMap;

namespace PersonalAccounting.UI.Infrastructure
{
    public class PersonalAccountingRegistry : Registry
    {
        public PersonalAccountingRegistry()
        {
            this.Scan(scanner =>
            {
#pragma warning disable CC0037//scanner.AssembliesFromPath(
                //    path: Path.Combine(Application.StartupPath, "plugins"),
                // Remove commented code.
                //    // یک اسمبلی نباید دوبار بارگذاری شود
                //    assemblyFilter: assembly =>
                //    !assembly.FullName.Equals(typeof(IShareholderService).Assembly.FullName));
#pragma warning restore CC0037 // Remove commented code.

                scanner.TheCallingAssembly();
                scanner.WithDefaultConventions();
                scanner.AddAllTypesOf<IUserService>().NameBy(item => item.FullName);
            });

            //For<IUnitOfWork>().Use<PersonalAccountingContext>();
            For<IUnitOfWork>().Use<SqliteDbContext>()
                .Ctor<string>("connectionString")
                //.Is(@"data source=.\db\PA.nch;foreign keys=true;Password=Develop][");
                //.Is(@"data source=.\db\PA.nch;Version=3;foreign keys=true;FailIfMissing=True;");
                //.Is(@"data source=.\db\PA.nch;foreign keys=true;");
                .Is(InitialHelper.dbPath);

            For<ILoggerService>().Use<LoggerService>();
            For<IExpenseDocumentService>().Use<ExpenseDocumentService>();
            For<IExpenseService>().Use<ExpenseService>();
            For<IFundService>().Use<FundService>();
            For<ITransferMoneyService>().Use<TransferMoneyService>();
            For<IMeasurementUnitService>().Use<MeasurementUnitService>();
            For<IFormEntityService>().Use<FormEntityService>();
            For<IRoleService>().Use<RoleService>();
            For<IUserService>().Use<UserService>();
            For<IPermissionService>().Use<PermissionService>();
            For<IDiaryNoteService>().Use<DiaryNoteService>();

            For<IRepositoryService<ArticleGroup, ViewModelLoadAllArticleGroup,
                ViewModelSimpleLoadArticleGroup>>().Use<ArticleGroupService>();
            For<IRepositoryService<Article, ViewModelLoadAllArticle,
                ViewModelSimpleLoadArticle>>().Use<ArticleService>();
            For<IRepositoryService<BankAccount, ViewModelLoadAllBankAccount,
                ViewModelSimpleLoadBankAccount>>().Use<BankAccountService>();
            For<IRepositoryService<Bank, ViewModelLoadAllBank, Bank>>().Use<BankService>();
            For<IRepositoryService<Income, ViewModelLoadAllIncome, Income>>().Use<IncomeService>();
            For<IRepositoryService<IncomeType, ViewModelLoadAllIncomeType, IncomeType>>().Use<IncomeTypeService>();

            For<IRepositoryService<Commodity, ViewModelLoadAllCommodity, Commodity>>().Use<CommodityService>();
            For<IRepositoryService<CommodityType, ViewModelLoadAllCommodityType, CommodityType>>().Use<CommodityTypeService>();

            For<IRepositoryService<Person, ViewModelLoadAllPerson, ViewModelSimpleLoadPerson>>().Use<PersonService>();
            For<IRepositoryService<MentalCondition, ViewModelLoadAllMentalCondition, ViewModelSimpleLoadMentalCondition>>()
                .Use<MentalConditionService>();
            For<IRepositoryService<WeatherCondition, ViewModelLoadAllWeatherCondition, ViewModelSimpleLoadWeatherCondition>>()
                .Use<WeatherConditionService>();
        }
    }
}
