using Janus.Windows.ExplorerBar;
using MessageBoxHamidNCH;
using PersonalAccounting.BLL.IService;
using PersonalAccounting.CommonLibrary.Helper;
using PersonalAccounting.Domain.Entity;
using PersonalAccounting.UI.Helper;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace PersonalAccounting.UI
{
    public partial class FrmMain : Form
    {
        private readonly IUserService _userService;
        //private readonly IRoleService _roleService;
        //private readonly IPermissionService _permissionService;

        private readonly User _currentUser = InitialHelper.CurrentUser;

        public FrmMain(IUserService userService
            //,IRoleService roleService, IPermissionService permissionService
            )
        {
            _userService = userService;
            //_roleService = roleService;
            //_permissionService = permissionService;
            InitializeComponent();

            if (_currentUser == null) return;

            //var permissions = _permissionService.GetAllPermissionsByUserRoles(_currentUser);
            //foreach (var permission in permissions)
            //{
            //    MessageBox.Show("Name: " + permission.Name + ", System Name:" + permission.SystemName);
            //}

            //try
            //{
            //    var res = string.Empty;
            //    var roles = _roleService.GetAllRolesForUserAsync(_currentUser.UserName).Result;
            //    foreach (var role in roles)
            //    {
            //        res += ", " + role.RoleName;
            //    }
            //    MessageBox.Show(res);
            //}
            //catch (Exception exception)
            //{
            //    MessageBox.Show(exception.InnerException.InnerException.Message);
            //    throw;
            //}

            //var users = _userService.GetUsersByRoleAsync("Admin").Result;
            //foreach (var user in users)
            //{
            //    MessageBox.Show(user.UserName);
            //}
            //var roles = _roleService.GetRolesForUserAsync(_currentUser.UserName).Result;
            //foreach (var role in roles)
            //{
            //    MessageBox.Show(role.Name);
            //}

            statusStrip1.Items[0].Text = "     کاربر " + _currentUser.UserName + " خوش آمدید ";

            //if (_currentUser.UserLastLoginDate.HasValue)
            //{
            //    TimeSpan? dateDiff = null;
            //    if (_currentUser.UserLastActivityDate.HasValue)
            //    {
            //         dateDiff = _currentUser.UserLastActivityDate.Value.Subtract(
            //            _currentUser.UserLastLoginDate.Value);
            //    }

            if (_currentUser.PreviousLastLoginDate != null)
                statusStrip1.Items[1].Text = "آخرین ورود شما در تاریخ " + PersianHelper.GetPersiaDate(
                                                 _currentUser.PreviousLastLoginDate.Value,
                                                 "D", true, "H") +
                                             " می باشد.";
            //  if (_currentUser.UserLastActiveDuration != null)
            var duration = _currentUser.LastActiveDuration;
            statusStrip1.Items[1].Text += @"  مدت زمان آخرین فعالیت شما: " +
                                         duration.Hours + ":" + duration.Minutes + ":" + duration.Seconds;
            //dateDiff.Value.Hours + ":" + dateDiff.Value.Minutes;

            //_currentUser.UserLastLoginDate = DateTime.Now;
            //_userService.UpdateCurrentUser(_currentUser);
        }

        private async Task<bool> CustomExit()
        {
            var dialog = new CustomDialogs(350, 200);
            dialog.Invoke("خروج از برنامه", "آيا قصد خروج از برنامه را داريد؟",
                  CustomDialogs.ImageType.itQuestion2,
                  CustomDialogs.ButtonType.YesNo, InitialHelper.BackColorCustom);

            if (!dialog.Yes) return false;

            var user = await _userService.GetByIdAsync(_currentUser.Id);
            if (user != null)
            {
                user.LastActivityDate = DateTime.Now;
                await _userService.UpdateAsync(user);
            }

            Application.ExitThread();
            return true;
        }
        private async void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!await (CustomExit()))
            {
                e.Cancel = true;
            }
        }
        private void explorerBar_RightPanel_ItemClick(object sender, ItemEventArgs e)
        {
            switch (e.Item.Key)
            {
                case "itmBanks":
                    InitialHelper.ShowFormWithAccessLevel(this, FrmBank.Instance());
                    break;
                case "itmBankAccounts":
                    InitialHelper.ShowFormWithAccessLevel(this, FrmBankAccount.Instance());
                    break;
                case "itmIncomeTypes":
                    InitialHelper.ShowFormWithAccessLevel(this, FrmIncomeType.Instance());
                    break;
                case "itmMeasurementUnits":
                    InitialHelper.ShowFormWithAccessLevel(this, FrmMeasurementUnit.Instance());
                    break;
                case "itmPersons":
                    InitialHelper.ShowFormWithAccessLevel(this, FrmPerson.Instance());
                    break;
                case "itmArticleGroups":
                    InitialHelper.ShowFormWithAccessLevel(this, FrmArticleGroup.Instance());
                    break;
                case "itmArticles":
                    InitialHelper.ShowFormWithAccessLevel(this, FrmArticle.Instance());
                    break;
            }
        }

        private async void ShowFormDetails(object sender, EventArgs e)
        {
            const string prefix = "rbe_";
            const string postfix = "Details";

            switch ((sender as RadButtonElement)?.Name)
            {
                case prefix + "Person" + postfix:
                    InitialHelper.ShowFormWithAccessLevel(this, FrmPerson.Instance());
                    break;
                case prefix + "User" + postfix:
                    InitialHelper.ShowFormWithAccessLevel(this, FrmUser.Instance());
                    break;
                case prefix + "Role" + postfix:
                    InitialHelper.ShowFormWithAccessLevel(this, FrmRole.Instance());
                    break;
                case prefix + "Bank" + postfix:
                    InitialHelper.ShowFormWithAccessLevel(this, FrmBank.Instance());
                    break;
                case prefix + "BankAccount" + postfix:
                    InitialHelper.ShowFormWithAccessLevel(this, FrmBankAccount.Instance());
                    break;
                case prefix + "IncomeType" + postfix:
                    InitialHelper.ShowFormWithAccessLevel(this, FrmIncomeType.Instance());
                    break;
                case prefix + "Income" + postfix:
                    InitialHelper.ShowFormWithAccessLevel(this, FrmIncome.Instance());
                    break;
                case prefix + "CommodityType" + postfix:
                    InitialHelper.ShowFormWithAccessLevel(this, FrmCommodityType.Instance());
                    break;
                case prefix + "Commodity" + postfix:
                    InitialHelper.ShowFormWithAccessLevel(this, FrmCommodity.Instance());
                    break;
                case prefix + "MeasurementUnit" + postfix:
                    InitialHelper.ShowFormWithAccessLevel(this, FrmMeasurementUnit.Instance());
                    break;
                case prefix + "ArticleGroup" + postfix:
                    InitialHelper.ShowFormWithAccessLevel(this, FrmArticleGroup.Instance());
                    break;
                case prefix + "Article" + postfix:
                    InitialHelper.ShowFormWithAccessLevel(this, FrmArticle.Instance());
                    break;
                case prefix + "Fund" + postfix:
                    InitialHelper.ShowFormWithAccessLevel(this, FrmFund.Instance());
                    break;
                case prefix + "TransferMoney" + postfix:
                    InitialHelper.ShowFormWithAccessLevel(this, FrmTransferMoney.Instance());
                    break;
                case prefix + "Expense" + postfix:
                    InitialHelper.ShowFormWithAccessLevel(this, FrmExpense.Instance());
                    break;
                case prefix + "DiaryNote" + postfix:
                    InitialHelper.ShowFormWithAccessLevel(this, FrmDiaryNote.Instance());
                    break;
                case prefix + "MentalCondition" + postfix:
                    InitialHelper.ShowFormWithAccessLevel(this, FrmMentalCondition.Instance());
                    break;
                case prefix + "WeatherCondition" + postfix:
                    InitialHelper.ShowFormWithAccessLevel(this, FrmWeatherCondition.Instance());
                    break;
                case prefix + "About" + postfix:
                    var frmAbout = new FrmAbout();
                    frmAbout.ShowDialog();
                    break;
                case prefix + "Backup" + postfix:
                    var frmBackup = new FrmBackup();
                    frmBackup.ShowDialog();
                    break;
                case prefix + "Quit" + postfix:
                    await CustomExit();
                    break;
            }
        }

        private async void rmi_Quit_Click(object sender, EventArgs e)
        {
            await CustomExit();
        }

        //private void btn_ShowIncomeTypeDetails_Click(object sender, EventArgs e)
        //{
        //    InitialHelper.ShowFormWithAccessLevel(this, FrmIncome.Instance());
        //}

        //private void btn_ShowExpenseDetails_Click(object sender, EventArgs e)
        //{
        //    InitialHelper.ShowFormWithAccessLevel(this, FrmExpense.Instance());
        //}

        //private void btn_ShowDairyNotes_Click(object sender, EventArgs e)
        //{
        //    var frmDairy = new FrmDiary();
        //    frmDairy.ShowDialog();
        //}
    }
}
