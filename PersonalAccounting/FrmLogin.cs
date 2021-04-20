using MessageBoxHamidNCH;
using PersonalAccounting.BLL.Enum;
using PersonalAccounting.BLL.IService;
using PersonalAccounting.CommonLibrary.Helper;
using PersonalAccounting.CommonLibrary.Properties;
using PersonalAccounting.UI.Helper;
using PersonalAccounting.UI.Infrastructure;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace PersonalAccounting.UI
{
    public partial class FrmLogin : Form
    {
        #region Variables

        //private readonly IRepositoryService<Person, ViewModelLoadAllPerson, ViewModelSimpleLoadPerson> _personService;

        private readonly IUserService _userService;
        //private readonly IRoleService _roleService;
        //private readonly IPermissionService _permissionService;

        private readonly BackgroundWorker _backgroundWorker;
        private readonly PictureBox _pictureBox;
        private CustomDialogs _dialog;
        private bool _success;
        #endregion

        public FrmLogin(
            //IRepositoryService<Person, ViewModelLoadAllPerson, ViewModelSimpleLoadPerson> personService,
            IUserService userService
            //,
            //IRoleService roleService,
            //IPermissionService permissionService
            )
        {
            //_personService = personService;
            _userService = userService;
            //_roleService = roleService;
            //_permissionService = permissionService;
            InitializeComponent();

            _backgroundWorker = new BackgroundWorker();
            _backgroundWorker.DoWork += _backgroundWorker_DoWork;
            _backgroundWorker.RunWorkerCompleted += _backgroundWorker_RunWorkerCompleted;
            _pictureBox = CommonHelper.CreateIndicatorLoading(
                this, new Size(356, 19), new Point(10, 101), Resources.Loadingvvv);

        }

        //private void CreateIndicatorLoading()
        //{
        //    _pictureBox = new PictureBox()
        //    {
        //        Parent = this,
        //        SizeMode = PictureBoxSizeMode.StretchImage,
        //        BorderStyle = BorderStyle.FixedSingle,
        //        Size = new Size(356, 19),
        //        Location = new Point(10, 101),//new Point(pnl_Data.Width / 25, pnl_Data.Height / 20),
        //        Image = Resources.Loadingvvv,
        //        Visible = true
        //    };
        //}
        //private void FrmLogin_Load(object sender, EventArgs e)
        //{
        //    //CreateIndicatorLoading();

        //    ////_roleService.CreateAsync("Admin", null);
        //    ////_roleService.CreateAsync("User", null);
        //    ////_roleService.CreateAsync("Public", null);

        //    //var person = new Person("حمید", "مذکر", DateTime.Now,
        //    //    DateTime.Now, null, null, "فعال", "");
        //    //var personStatus = _personService.CreateAsync(person);

        //    //if (personStatus.Result != CreateStatus.Successful) return;

        //    //var newUser = new User(person.Id, "Hamidnch",
        //    //    Utility.HashPassword("1231"), "Hamidnch2007@gmail.com",
        //    //    true, false, 0, DateTime.Now,
        //    //    DateTime.Now, null,
        //    //    null, null, null,
        //    //    null, "", "فعال", "", null);
        //    ////{ RoleId = adminRoleId };
        //    //var userStatus = _userService.CreateAsync(newUser);
        //    //var us = _userService.GetByUsernameAsync("Hamidnch").Result;
        //    //_roleService.AssignToUserAsync(us, "Admin");
        //    ////var role = _userService.AssignToUserAsync(us, "Admin");
        //    ////MessageBox.Show(userStatus.Result.ToString());
        //}

        private void ShowErrorDialog(string error, string title = "هشدار")
        {
            _dialog = new CustomDialogs(400, 200);
            _dialog.Invoke(title,
                CommonHelper.GetResourceValue(error),
                CustomDialogs.ImageType.itError3,
                CustomDialogs.ButtonType.Ok, InitialHelper.BackColorCustom);
        }
        private void _backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (_success)
            {
                Hide();

                var frmMain = IocConfig.Container.GetInstance<FrmMain>();
                frmMain.Show();
            }
            else
            {
                txt_UserName.Focus();
                btn_Enter.Enabled = true;
            }
            CommonHelper.IndicatorLoading(_pictureBox, false);
            _backgroundWorker.Dispose();
        }

        private async void _backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var status = await _userService.ValidateAsync(
                txt_UserName.Text.Trim(), txt_Password.Text.Trim());

            switch (status.ValidateUserStatus)
            {
                case ValidateUserStatus.Successful:
                    InitialHelper.CurrentUser = status.CurrentUser;
                    //await _userService.GetByUsernameAsync(txt_UserName.Text.Trim());
                    //btn_Enter.Enabled = false;
                    _success = true;

                    //var permissions = InitialHelper.CurrentPermission =
                    //    _permissionService.GetAllPermissionsByUserRoles(InitialHelper.CurrentUser);
                    //foreach (var permission in permissions)
                    //{
                    //    MessageBox.Show("Name: " + permission.Name + ", System Name:" + permission.SystemName);
                    //}
                    //InitialHelper.CurrentUser.LastActivityDate = DateTime.Now;
                    //InitialHelper.CurrentUser.Ip = "192.168.200.1";
                    //var res = _userService.UpdateAsync(InitialHelper.CurrentUser);

                    break;
                case ValidateUserStatus.Failure:
                    //CommonHelper.ShowNotificationMessage("پیام", CommonHelper.GetResourceValue("InvalidUserNameOrPassword"),
                    //    null, null, null, null, null, null, null, null,
                    //    null, null, null, null, null, Resources.Delete);
                    ShowErrorDialog("InvalidUserNameOrPassword", "پیام");
                    break;
                case ValidateUserStatus.IsLockout:
                    //CommonHelper.ShowNotificationMessage("پیام", CommonHelper.GetResourceValue("UserIsLockout"),
                    //    null, null, null, null, null, null, null, null,
                    //    null, null, null, null, null, Resources.Delete
                    ShowErrorDialog("UserIsLockout", "پیام");
                    break;
                case ValidateUserStatus.IsNotApproved:
                    //CommonHelper.ShowNotificationMessage("پیام", CommonHelper.GetResourceValue("IsNotApproved"),
                    //    null, null, null, null, null, null, null, null,
                    //    null, null, null, null, null, Resources.Delete);
                    ShowErrorDialog("IsNotApproved", "پیام");
                    break;
                case ValidateUserStatus.IsNotActive:
                    //CommonHelper.ShowNotificationMessage("پیام", CommonHelper.GetResourceValue("IsNotActive"),
                    //    null, null, null, null, null, null, null, null,
                    //    null, null, null, null, null, Resources.Delete);
                    ShowErrorDialog("IsNotActive", "پیام");
                    break;
                case ValidateUserStatus.UsernameIsEmpty:
                    ShowErrorDialog("EmptyUserName", "پیام");
                    break;
                case ValidateUserStatus.PasswordIsEmpty:
                    ShowErrorDialog("EmptyPassword", "پیام");
                    break;
                case ValidateUserStatus.UserIsNotExists:
                    ShowErrorDialog("UserIsNotExists", "پیام");
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            //_dialog = new CustomDialogs(400, 200);
            if ((txt_UserName.Text == string.Empty) && (txt_Password.Text == string.Empty))
            {
                ShowErrorDialog("EmptyUserNameAndPassword");
                txt_UserName.Focus();
                return;
            }
            if (txt_UserName.Text == string.Empty)
            {
                ShowErrorDialog("EmptyUserName");
                txt_UserName.Focus();
                return;
            }
            if (txt_Password.Text == string.Empty)
            {
                ShowErrorDialog("EmptyPassword");
                return;
            }

            btn_Enter.Enabled = false;
            CommonHelper.IndicatorLoading(_pictureBox, true);
            _backgroundWorker.RunWorkerAsync();

            //btn_Enter.Image = CommonLibrary.Properties.Resources.CloseIcon;

        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            e.SuppressKeyPress = true;
            btn_Enter_Click(sender, e);
            e.SuppressKeyPress = true;
            e.Handled = true;
        }
    }
}