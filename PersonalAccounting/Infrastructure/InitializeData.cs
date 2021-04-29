using PersonalAccounting.BLL.IService;
using PersonalAccounting.CommonLibrary.Helper;
using PersonalAccounting.CommonLibrary.Properties;
using PersonalAccounting.Domain.Entity;
using PersonalAccounting.Domain.ViewModel;
using PersonalAccounting.UI.Helper;
using System;
using System.Drawing.Imaging;
using System.Reflection;
using System.Windows.Forms;

namespace PersonalAccounting.UI.Infrastructure
{
    public class InitializeData
    {
        private readonly IRepositoryService<Person, ViewModelLoadAllPerson, ViewModelSimpleLoadPerson> _personService;
        private readonly IRoleService _roleService;
        private readonly IUserService _userService;
        private readonly IFormEntityService _formEntityService;
        private readonly IPermissionService _permissionService;
        private readonly ILoggerService _loggerService;

        public InitializeData(IRepositoryService<Person, ViewModelLoadAllPerson,
                ViewModelSimpleLoadPerson> personService,
            IRoleService roleService, IUserService userService,
            IFormEntityService formEntityService, IPermissionService permissionService,
            ILoggerService loggerService)
        {
            _personService = personService;
            _roleService = roleService;
            _userService = userService;
            _formEntityService = formEntityService;
            _permissionService = permissionService;
            _loggerService = loggerService;
        }

        public void ExecuteSeedData()
        {
            //StartDatabase();

            SeedRoles();
            SeedPersons();
            SeedUsers();
            SeedPermissions();
            SeedFormEntities();
        }

        private void SeedRoles()
        {
            void AddRoles(Role role)
            {
                if (!_roleService.ExistAsync(role).Result)
                {
                    _roleService.CreateAsync(role);

                    //Create a log
                    _loggerService.InformationAsync(string.Empty, string.Empty, $"Create a admin role with id {role.Id} and name {role.Name}");
                }
            }

            var role1 = new Role(DefaultConstants.AdminRole, DateTime.Now,
                null, InitialHelper.CurrentUser?.Id, DefaultConstants.ActiveOptionString, string.Empty);
            var role2 = new Role(DefaultConstants.SupervisorRole, DateTime.Now,
                null, InitialHelper.CurrentUser?.Id, DefaultConstants.ActiveOptionString, string.Empty);
            var role3 = new Role(DefaultConstants.UserRole, DateTime.Now,
                null, InitialHelper.CurrentUser?.Id, DefaultConstants.ActiveOptionString, string.Empty);

            AddRoles(role1);
            AddRoles(role2);
            AddRoles(role3);
        }

        private void SeedPersons()
        {
            void AddPerson(Person person)
            {
                if (!_personService.ExistAsync(person).Result)
                {
                    _personService.CreateAsync(person);

                    //Create a log
                    _loggerService.InformationAsync(string.Empty, string.Empty, $"Create a new person with id {person.Id} and name {person.FullName}");
                }
            }

            var person1 = new Person("حمید", DefaultConstants.GenderMaleOptionString, DateTime.Now, null,
                CommonHelper.ConvertPicBoxImageToByte(Resources.DefaultUser, ImageFormat.Png),
                InitialHelper.CurrentUser?.Id, DefaultConstants.ActiveOptionString, string.Empty);

            var person2 = new Person(DefaultConstants.AdminRole,
                DefaultConstants.GenderMaleOptionString, DateTime.Now, null,
                CommonHelper.ConvertPicBoxImageToByte(Resources.DefaultUser, ImageFormat.Png),
                InitialHelper.CurrentUser?.Id, DefaultConstants.ActiveOptionString, string.Empty);

            AddPerson(person1);
            AddPerson(person2);
        }

        private void SeedUsers()
        {
            void AddUser(User user, Role role)
            {
                if (!_userService.ExistAsync(user.UserName).Result)
                {
                    _userService.CreateAsync(user);

                    //Create a log
                    _loggerService.InformationAsync(string.Empty, string.Empty, $"Create a new user with id {user.Id} and name {user.UserName}");
                }

                //var usr = _userService.GetByUsernameAsync(user.UserName).Result;
                if (!_roleService.IsRoleForUserAsync(role, user).Result)
                {
                    _roleService.AssignToUserAsync(user, role);
                }
            }

            var personId1 = _personService.GetByNameAsync("حمید").Result.Id;

            var user1 = new User(personId1, "Hamidnch",
                Utility.HashPassword("1231"), "Hamidnch2007@gmail.com",
                true, false, 0, DateTime.Now,
                DateTime.Now, null,
                null, null, null,
                null, string.Empty, DefaultConstants.ActiveOptionString, string.Empty, null);

            var adminRole = _roleService.GetByNameAsync(DefaultConstants.AdminRole).Result;

            AddUser(user1, adminRole);

            var personId2 = _personService.GetByNameAsync(DefaultConstants.AdminRole).Result.Id;
            var user2 = new User(personId2, DefaultConstants.DefaultAdminUserName,
                Utility.HashPassword(DefaultConstants.DefaultAdminPassword),
                DefaultConstants.DefaultAdminEmail,
                true, false, 0, DateTime.Now,
                DateTime.Now, null,
                null, null, null,
                null, string.Empty, DefaultConstants.ActiveOptionString, string.Empty, null);

            AddUser(user2, adminRole);
        }

        private static string NormalizeFormName(string name)
        {
            var formName = name;
            switch (name)
            {
                case "FrmArticle":
                    formName = "کالاها";
                    break;
                case "FrmArticleGroup":
                    formName = "گروه کالا";
                    break;
                case "FrmBank":
                    formName = "بانک ها";
                    break;
                case "FrmBankAccount":
                    formName = "حسابهای بانکی";
                    break;
                case "FrmDiaryNote":
                    formName = "ثبت یادداشت های روزانه";
                    break;
                case "FrmExpense":
                    formName = "ثبت هزینه ها";
                    break;
                //case "FrmFind":
                //    formName = "جستجو در متن";
                //    break;
                //case "FrmReplace":
                //    formName = "جایگزین کردن متن";
                //    break;
                case "FrmFund":
                    formName = "صندوق ها";
                    break;
                case "FrmTransferMoney":
                    formName = "انتقال مبلغ بین صندوقها";
                    break;
                case "FrmIncomeType":
                    formName = "انواع درآمدها";
                    break;
                case "FrmIncome":
                    formName = "در آمدها";
                    break;
                case "FrmCommodityType":
                    formName = "انواع دریافتی ها";
                    break;
                case "FrmCommodity":
                    formName = "دریافتی جدید";
                    break;
                case "FrmMeasurementUnit":
                    formName = "آحاد سنجش";
                    break;
                case "FrmMentalCondition":
                    formName = "شرایط روحی";
                    break;
                case "FrmPerson":
                    formName = "اشخاص";
                    break;
                case "FrmRole":
                    formName = "نقش ها";
                    break;
                case "FrmUser":
                    formName = "کاربران";
                    break;
                case "FrmWeatherCondition":
                    formName = "شرایط آب و هوا";
                    break;
                case "FrmExpenseReport":
                    formName = "گزارش هزینه ها";
                    break;
                case "FrmBackup":
                    formName = "پشتیبان از دیتابیس";
                    break;
            }

            return formName;
        }

        private void SeedPermissions()
        {
            var formType = typeof(Form);
            foreach (var form in Assembly.GetExecutingAssembly().GetTypes())
                if (formType.IsAssignableFrom(form))
                {
                    if (!form.Name.StartsWith("Frm")) continue;

                    if (form.Name == "FrmAbout"
                        || form.Name == "FrmFind"
                        || form.Name == "FrmReplace"
                        || form.Name == "FrmLogin"
                        || form.Name == "FrmLoading"
                        || form.Name == "FrmMain") continue;

                    // type is a Form

                    var systemName = form.Name;

                    var canForm = DefaultConstants.PrefixCanViewPermission + systemName.Remove(0, 3);

                    var permission = new Permission(canForm,
                        DefaultConstants.PermissionViewString /*+ NormalizeFormName(form.Name)*/, true,
                        DateTime.Now, null, null, DefaultConstants.ActiveOptionString, NormalizeFormName(form.Name));
                    _permissionService.CreateAsync(permission);

                    //Create a log
                    _loggerService.InformationAsync(string.Empty, string.Empty, $"Create a new permission with id {permission.Id} and name {permission.Name} " +
                                                            $"for form entity is {permission.FormEntities}");

                    canForm = DefaultConstants.PrefixCanAddPermission + systemName.Remove(0, 3);
                    permission = new Permission(canForm,
                        DefaultConstants.PermissionAddString /*+ NormalizeFormName(form.Name)*/, true,
                        DateTime.Now, null, null, DefaultConstants.ActiveOptionString, NormalizeFormName(form.Name));
                    _permissionService.CreateAsync(permission);

                    //Create a log
                    _loggerService.InformationAsync(string.Empty, string.Empty, $"Create a new permission with id {permission.Id} and name {permission.Name} " +
                                                            $"for form entity is {permission.FormEntities}");

                    canForm = DefaultConstants.PrefixCanEditPermission + systemName.Remove(0, 3);
                    permission = new Permission(canForm,
                        DefaultConstants.PermissionEditString /*+ NormalizeFormName(form.Name)*/, true,
                        DateTime.Now, null, null, DefaultConstants.ActiveOptionString, NormalizeFormName(form.Name));
                    _permissionService.CreateAsync(permission);

                    //Create a log
                    _loggerService.InformationAsync(string.Empty, string.Empty, $"Create a new permission with id {permission.Id} and name {permission.Name} " +
                                                            $"for form entity is {permission.FormEntities}");

                    canForm = DefaultConstants.PrefixCanDeletePermission + systemName.Remove(0, 3);
                    permission = new Permission(canForm,
                        DefaultConstants.PermissionDeleteString /*+ NormalizeFormName(form.Name)*/, true,
                        DateTime.Now, null, null, DefaultConstants.ActiveOptionString, NormalizeFormName(form.Name));
                    _permissionService.CreateAsync(permission);

                    //Create a log
                    _loggerService.InformationAsync(string.Empty, string.Empty, $"Create a new permission with id {permission.Id} and name {permission.Name} " +
                                                            $"for form entity is {permission.FormEntities}");
                }
        }

        private void SeedFormEntities()
        {
            var formType = typeof(Form);
            foreach (var form in Assembly.GetExecutingAssembly().GetTypes())
                if (formType.IsAssignableFrom(form))
                {
                    // type is a Form
                    if (!form.Name.StartsWith("Frm")) continue;

                    if (form.Name == "FrmAbout"
                        || form.Name == "FrmFind"
                        || form.Name == "FrmReplace"
                        || form.Name == "FrmLogin"
                        || form.Name == "FrmLoading"
                        || form.Name == "FrmMain") continue;

                    var systemName = form.Name;
                    var formName = NormalizeFormName(form.Name);

                    var entity = new FormEntity(formName, systemName, DateTime.Now, null,
                        InitialHelper.CurrentUser?.Id, DefaultConstants.ActiveOptionString, form.FullName);

                    if (_formEntityService.ExistAsync(entity).Result) continue;

                    _formEntityService.CreateAsync(entity);

                    //Create a log
                    _loggerService.InformationAsync(string.Empty, string.Empty, $"Create a new form entity with id {entity.Id} and name {entity.Name} ");

                    var formEntity = _formEntityService.GetByNameAsync(entity.Name).Result;

                    var adminRole = _roleService.GetByNameAsync(DefaultConstants.AdminRole).Result;

                    var canForm = DefaultConstants.PrefixCanViewPermission + systemName.Remove(0, 3);
                    var canPermission = _permissionService.GetByNameAsync(canForm).Result;

                    if (_permissionService.HasPermission(adminRole, canPermission.Name, systemName)) continue;

                    _permissionService.AddPermissionToRoleAsync(canPermission, adminRole, formEntity);

                    canForm = DefaultConstants.PrefixCanAddPermission + systemName.Remove(0, 3);
                    canPermission = _permissionService.GetByNameAsync(canForm).Result;

                    if (_permissionService.HasPermission(adminRole, canPermission.Name, systemName)) continue;

                    _permissionService.AddPermissionToRoleAsync(canPermission, adminRole, formEntity);

                    canForm = DefaultConstants.PrefixCanEditPermission + systemName.Remove(0, 3);
                    canPermission = _permissionService.GetByNameAsync(canForm).Result;

                    if (_permissionService.HasPermission(adminRole, canPermission.Name, systemName)) continue;

                    _permissionService.AddPermissionToRoleAsync(canPermission, adminRole, formEntity);

                    canForm = DefaultConstants.PrefixCanDeletePermission + systemName.Remove(0, 3);
                    canPermission = _permissionService.GetByNameAsync(canForm).Result;

                    if (_permissionService.HasPermission(adminRole, canPermission.Name, systemName)) continue;

                    _permissionService.AddPermissionToRoleAsync(canPermission, adminRole, formEntity);
                }
        }
    }
}