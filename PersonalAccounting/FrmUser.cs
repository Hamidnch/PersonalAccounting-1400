using PersonalAccounting.BLL.Enum;
using PersonalAccounting.BLL.IService;
using PersonalAccounting.CommonLibrary.Helper;
using PersonalAccounting.Domain.Entity;
using PersonalAccounting.Domain.ViewModel;
using PersonalAccounting.UI.Helper;
using PersonalAccounting.UI.Infrastructure;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI;

namespace PersonalAccounting.UI
{
    public partial class FrmUser : BaseForm
    {
        private readonly IUserService _userService;
        private readonly IRoleService _roleService;
        private readonly IRepositoryService<Person, ViewModelLoadAllPerson, ViewModelSimpleLoadPerson> _personService;
        private string _currentEmail = string.Empty;

        private int _userId;
        private int _personId;

        public static FrmUser AFrmUser = null;
        public static FrmUser Instance()
        {
            return AFrmUser ?? (AFrmUser = IocConfig.Container.GetInstance<FrmUser>());
        }
        public FrmUser(IUserService userService,
            IRepositoryService<Person, ViewModelLoadAllPerson, ViewModelSimpleLoadPerson> personService,
            IRoleService roleService)
        {
            _userService = userService;
            _personService = personService;
            _roleService = roleService;
            InitializeComponent();
            //CommonHelper.SetFont(CommonHelper.BaseFont, pnl_Data, rgv_User);

            BindRoles();
            BindGrid();
            BindPersons(false);
            rddl_Status.SetEnableDisableDropdownList();
        }

        private async void BindGrid()
        {
            int? currentUserId = null;
            if (!await InitialHelper.CurrentUser.IsAdmin())
                currentUserId = InitialHelper.CurrentUser.Id;

            rgv_User.BeginUpdate();
            rgv_User.DataSource = await _userService.LoadAllViewModelAsync(currentUserId);
            rgv_User.EndUpdate();
        }
        private async void BindPersons(bool onlyNoneUser = false)
        {
            ddl_PersonName.ValueMember = "PersonId";
            ddl_PersonName.DisplayMember = "PersonName";

            IList<ViewModelSimpleLoadPerson> result;
            if (onlyNoneUser)
            {
                result = await _personService.SimpleLoadViewModelOnlyNoneUserAsync();
                result.Insert(0, null);
                ddl_PersonName.DataSource = result;
            }
            else
            {
                result = await _personService.SimpleLoadViewModelAsync();
                ddl_PersonName.DataSource = result;
            }
        }
        private async void BindRoles()
        {
            rclb_RoleNames.ValueMember = "RoleId";
            rclb_RoleNames.DisplayMember = "RoleName";
            rclb_RoleNames.DataSource = await _roleService.SimpleLoadViewModelAsync();
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if (!InitialHelper.HasPermissionFor(this.Name, PermissionMode.Add))
            {
                CommonHelper.ShowNotificationMessage(DefaultConstants.IllegalAccess, DefaultConstants.CreateActionNotAllow);
                return;
            }

            _mode = CommonHelper.Mode.Insert;
            CommonHelper.InsertAction(_mode, pnl_Data, rgv_User, btnInsert, btnRegister, btnModify,
                btnDelete, btnCancel, btnClose, txt_UserName);

            ddl_PersonName.Text = string.Empty;
            chk_EnablePassword.Checked = true;
            chk_EnablePassword.Visible = false;
            lbl_PasswordHeader.Visible = true;
            //gb_Password.HeaderText = "کلمه عبور و تکرار آن را وارد کنید";
            rddl_Status.SelectedValue = 0;
            foreach (var item in rclb_RoleNames.Items)
            {
                item.CheckState = ToggleState.Off;
            }

            ddl_PersonName.Enabled = true;
            BindPersons(true);
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            if (!InitialHelper.HasPermissionFor(this.Name, PermissionMode.Edit))
            {
                CommonHelper.ShowNotificationMessage(DefaultConstants.IllegalAccess, DefaultConstants.EditActionNotAllow);
                return;
            }

            _mode = CommonHelper.Mode.Update;
            CommonHelper.ModifyAction(_mode, pnl_Data, rgv_User, btnInsert, btnRegister,
                btnModify, btnDelete, btnCancel, btnClose);
            lbl_PasswordHeader.Visible = false;
            chk_EnablePassword.Visible = true;
            chk_EnablePassword.Checked = false;
            Chk_EnablePassword_CheckedChanged(sender, e);
            //gb_Password.HeaderText = "کلمه عبور نیاز به تغییر دارد؟";
            _mode = CommonHelper.Mode.Update;
            ddl_PersonName.Enabled = false;
            _currentEmail = txt_Email.Text;
            //BindPersons(false);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            _mode = CommonHelper.Mode.Cancel;
            CommonHelper.CancelAction(_mode, pnl_Data, rgv_User, btnInsert, btnRegister, btnModify,
                btnDelete, btnCancel, btnClose);
            lbl_PasswordHeader.Visible = true;
            chk_EnablePassword.Visible = false;
            ReturnPersonDetails();
        }
        private async void ReturnPersonDetails()
        {
            try
            {
                if (!(rgv_User.CurrentRow is GridViewDataRowInfo dataRow)) return;

                _userId = int.Parse(dataRow.Cells["UserId"].Value.ToString());
                _personId = int.Parse(dataRow.Cells["PersonId"].Value.ToString());
                ddl_PersonName.Text = dataRow.Cells["PersonName"].Value?.ToString();
                txt_UserName.Text = dataRow.Cells["UserName"].Value?.ToString();

                var userRoles = await _roleService.GetRolesForUserAsync(txt_UserName.Text);
                foreach (var item in rclb_RoleNames.Items)
                {
                    item.CheckState = ToggleState.Off;
                }
                foreach (var item in rclb_RoleNames.Items)
                {
                    foreach (var role in userRoles)
                    {
                        if (role.Name.Trim() == item.Text.Trim())
                        {
                            item.CheckState = ToggleState.On;
                        }
                    }
                }

                //var list = new List<string>();
                //list.Clear();

                //foreach (var role in userRoles)
                //{
                //    var roleName = role.Name.Trim();

                //    if (list.Contains(roleName)) continue;

                //    foreach (var item in rclb_RoleNames.Items)
                //    {
                //        if (item.Text.Equals(roleName))
                //        {
                //            item.CheckState = ToggleState.On;
                //            list.Add(item.Text);
                //        }
                //        else
                //        {
                //            item.CheckState = ToggleState.Off;
                //        }
                //    }
                //}

                //txt_Password.Text = dataRow.Cells["Password"].Value?.ToString();
                //txt_ConfirmPassword.Text = dataRow.Cells["Password"].Value?.ToString();
                txt_Email.Text = dataRow.Cells["Email"].Value?.ToString();
                chk_IsApproved.Checked = Convert.ToBoolean(dataRow.Cells["IsApproved"].Value);//.ToString() == "تایید";
                chk_IsLockout.Checked = Convert.ToBoolean(dataRow.Cells["IsLockout"].Value);//.ToString() == "محروم";
                rddl_Status.Text = dataRow.Cells["Status"].Value?.ToString();
                txt_Description.Text = dataRow.Cells["Description"].Value?.ToString();
            }
            catch (Exception exception)
            {
                await LoggerService.ErrorAsync(this.Name, "ReturnPersonDetails", exception.Message,
                    exception.ToDetailedString());
            }
        }

        private bool ValidateAllControls()
        {
            var flag = CommonHelper.ValidateControls(txt_UserName, _errorProvider,
                       "نام کاربری  را وارد نمایید")
                   //|| CommonHelper.ValidateControls(txt_Password, _errorProvider,
                   //    "کلمه عبور  را تعیین نمایید")
                   //|| CommonHelper.ValidateControls(txt_ConfirmPassword, _errorProvider,
                   //    "تکرار کلمه عبور را تعیین نمایید")
                   || CommonHelper.ValidateControls(ddl_PersonName, _errorProvider,
                       "نام شخص  را تعیین نمایید")
                   || CommonHelper.ValidateControls(rclb_RoleNames, _errorProvider,
                       "نقش کاربر را مشخص کنید");
            if (chk_EnablePassword.Checked)
            {
                flag = CommonHelper.ValidateControls(txt_Password, _errorProvider,
                           "کلمه عبور  را تعیین نمایید")
                       || CommonHelper.ValidateControls(txt_ConfirmPassword, _errorProvider,
                           "تکرار کلمه عبور را تعیین نمایید");
            }
            return flag;
        }

        private void Txt_UserName_TextChanged(object sender, EventArgs e)
        {
            if (_mode != CommonHelper.Mode.Insert) return;

            var flag = true;
            if (chk_EnablePassword.Checked)
            {
                if (txt_Password.Text == string.Empty
                    || txt_ConfirmPassword.Text == string.Empty)
                //|| txt_Password.Text.Trim() != txt_ConfirmPassword.Text.Trim()
                {
                    flag = false;
                }

            }
            btnRegister.Enabled = txt_UserName.Text != string.Empty
                                  && rclb_RoleNames.SelectedItems.Count > 0
                                  && ddl_PersonName.Text != string.Empty && flag;
        }

        private void MasterTemplate_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
        {
            ReturnPersonDetails();
        }

        private async void BtnRegister_Click(object sender, EventArgs e)
        {
            if (ValidateAllControls()) return;
            //var dlg = new CustomDialogs(400, 200);

            if (txt_Password.Text != txt_ConfirmPassword.Text)
            {
                CommonHelper.ShowNotificationMessage("خطا",
                    "کلمه عبور و تکرار آن یکسان نیست");
                //dlg.Invoke("خطا", "کلمه عبور و تکرار آن یکسان نیست",
                //    CustomDialogs.ImageType.itError4, CustomDialogs.ButtonType.Ok);
                return;
            }

            var userStatus = rddl_Status.Text;

            switch (_mode)
            {
                case CommonHelper.Mode.Insert:
                    try
                    {
                        if (!InitialHelper.HasPermissionFor(this.Name, PermissionMode.Add))
                        {
                            CommonHelper.ShowNotificationMessage(DefaultConstants.IllegalAccess, DefaultConstants.CreateActionNotAllow);
                            return;
                        }

                        var hashedPassword = Utility.HashPassword(txt_Password.Text);
                        var newUser = new User(txt_UserName.Text,
                            hashedPassword, txt_Email.Text, chk_IsApproved.Checked,
                            chk_IsLockout.Checked, 0, CommonHelper.GetLocalIPv4(),
                            int.Parse(ddl_PersonName.SelectedItem.Value.ToString()),
                            InitialHelper.CurrentUser.Id, userStatus, txt_Description.Text);

                        var status = await _userService.CreateAsync(newUser);

                        switch (status)
                        {
                            case UserRegisterStatus.UserNameExist:
                                //dlg.Invoke("خطای تکرار", "این نام کاربری تکراری می باشد",
                                //    CustomDialogs.ImageType.itError3,
                                //    CustomDialogs.ButtonType.Ok, InitialHelper.BackColorCustom);
                                CommonHelper.ShowNotificationMessage("خطای تکرار", "این نام کاربری تکراری می باشد");
                                txt_UserName.Focus();
                                txt_UserName.SelectAll();
                                return;
                            case UserRegisterStatus.EmailExist:
                                //dlg.Invoke("خطای تکرار", "این ایمیل تکراری می باشد",
                                //    CustomDialogs.ImageType.itError3,
                                //    CustomDialogs.ButtonType.Ok, InitialHelper.BackColorCustom);
                                CommonHelper.ShowNotificationMessage("خطای تکرار", "این ایمیل تکراری می باشد");
                                txt_Email.Focus();
                                txt_Email.SelectAll();
                                return;
                            case UserRegisterStatus.Failure:
                                //dlg.Invoke("بروز خطا", PublicError.Error, CustomDialogs.ImageType.itError5,
                                //    CustomDialogs.ButtonType.Ok);
                                CommonHelper.ShowNotificationMessage("بروز خطا", PublicError.Error);
                                return;
                            case UserRegisterStatus.Successful:
                                foreach (var role in rclb_RoleNames.Items)
                                {
                                    if (role.CheckState == ToggleState.On)
                                    {
                                        await _roleService.AssignRoleToUserAsync(newUser.UserName, role.Text);
                                    }
                                }

                                //CommonHelper.ClearInputControls(pnl_Data);
                                txt_UserName.Focus();
                                CommonHelper.EnableControls(pnl_Data, false);
                                btnCancel.Enabled = false;
                                btnInsert.Enabled = true;
                                btnDelete.Enabled = true;
                                BindPersons();
                                BindRoles();
                                rgv_User.Enabled = true;
                                BindGrid();
                                break;
                            default:
                                throw new ArgumentOutOfRangeException();
                        }

                    }
                    catch (Exception exception)
                    {
                        //dlg.Invoke("خطا در ثبت اطلاعات",
                        //    "خطای زیر به وقوع پیوست \n" + ex.ToDetailedString(),
                        //    CustomDialogs.ImageType.itError2, CustomDialogs.ButtonType.Ok,
                        //    InitialHelper.BackColorCustom);
                        CommonHelper.ShowNotificationMessage("خطا در ثبت اطلاعات",
                            "خطای زیر به وقوع پیوست \n" + exception.Message);
                        await LoggerService.ErrorAsync(this.Name, "BtnRegister_Click(Insert Mode)", exception.Message,
                            exception.ToDetailedString());

                        return;
                    }
                    break;

                case CommonHelper.Mode.Update:
                    try
                    {
                        if (!InitialHelper.HasPermissionFor(this.Name, PermissionMode.Edit))
                        {
                            CommonHelper.ShowNotificationMessage(DefaultConstants.IllegalAccess, DefaultConstants.EditActionNotAllow);
                            return;
                        }

                        var currentUser = await _userService.GetByIdAsync(_userId);
                        currentUser.UserName = txt_UserName.Text;
                        if (txt_Email.Text != _currentEmail)
                        {
                            var emailExist = await _userService.ExistAsync(txt_Email.Text);
                            if (emailExist)
                            {
                                CommonHelper.ShowNotificationMessage("خطای تکرار", "این ایمیل تکراری می باشد");
                                txt_Email.Focus();
                                txt_Email.SelectAll();
                                return;
                            }
                        }
                        currentUser.Email = txt_Email.Text;

                        if (chk_EnablePassword.Checked)
                        {
                            var hashedPassword = Utility.HashPassword(txt_Password.Text);
                            currentUser.Password = hashedPassword;
                        }

                        currentUser.PersonId = _personId;//int.Parse(ddl_PersonName.SelectedItem.Value.ToString());
                        currentUser.IsApproved = chk_IsApproved.Checked;
                        currentUser.IsLockout = chk_IsLockout.Checked;
                        currentUser.UpdateBy = InitialHelper.CurrentUser.Id;
                        currentUser.LastUpdate = DateTime.Now;
                        currentUser.Status = userStatus;
                        currentUser.Description = txt_Description.Text;

                        var status = await _userService.UpdateAsync(currentUser);
                        switch (status)
                        {
                            //case UserRegisterStatus.UserNameExist:
                            //    CommonHelper.ShowNotificationMessage("خطای تکرار", "این نام کاربری تکراری می باشد");
                            //    txt_UserName.Focus();
                            //    txt_UserName.SelectAll();
                            //    return;
                            case UserRegisterStatus.EmailExist:
                                CommonHelper.ShowNotificationMessage("خطای تکرار", "این ایمیل تکراری می باشد");
                                txt_Email.Focus();
                                txt_Email.SelectAll();
                                return;
                            case UserRegisterStatus.Failure:
                                CommonHelper.ShowNotificationMessage("بروز خطا", PublicError.Error);
                                return;
                            case UserRegisterStatus.Successful:
                                //await _roleService.RemoveAllRolesForUserAsync(currentUser.UserName);
                                foreach (var role in rclb_RoleNames.Items)
                                {
                                    if (role.CheckState == ToggleState.On)
                                    {
                                        await _roleService.AssignRoleToUserAsync(currentUser.UserName, role.Text);
                                    }
                                    else
                                    {
                                        await _roleService.RemoveRoleForUserAsync(currentUser.UserName, role.Text);
                                    }
                                }

                                //CommonHelper.ClearInputControls(pnl_Data, false, false);
                                rgv_User.Enabled = true;
                                CommonHelper.EnableControls(pnl_Data, false);
                                btnCancel.Enabled = false;
                                btnInsert.Enabled = true;
                                btnDelete.Enabled = true;
                                BindPersons();
                                BindRoles();
                                BindGrid();
                                break;
                        }
                    }
                    catch (Exception exception)
                    {
                        //dlg.Invoke("خطا در ثبت اطلاعات",
                        //    "خطای زیر به وقوع پیوست \n" + ex.ToDetailedString(),
                        //    CustomDialogs.ImageType.itError2, CustomDialogs.ButtonType.Ok,
                        //    InitialHelper.BackColorCustom);
                        CommonHelper.ShowNotificationMessage("خطا در ثبت اطلاعات",
                            "خطای زیر به وقوع پیوست \n" + exception.Message);
                        await LoggerService.ErrorAsync(this.Name, "BtnRegister_Click(Update Mode)", exception.Message,
                            exception.ToDetailedString());
                        return;
                    }

                    break;
                case CommonHelper.Mode.None:
                    break;
                case CommonHelper.Mode.Cancel:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            //rgv_User.Enabled = true;
            btnRegister.Enabled = false;
            txt_Password.Text = string.Empty;
            txt_ConfirmPassword.Text = string.Empty;
            btnClose.Enabled = true;
            _mode = CommonHelper.Mode.None;
        }

        private void MasterTemplate_CellClick(object sender, GridViewCellEventArgs e)
        {
            if (rgv_User.Enabled && rgv_User.RowCount > 0)
            { btnModify.Enabled = true; }
            else { btnModify.Enabled = false; }
        }

        private void MasterTemplate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && btnRegister.Enabled)
            {
                BtnRegister_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private void Chk_EnablePassword_CheckedChanged(object sender, EventArgs e)
        {
            gb_Password.Enabled = chk_EnablePassword.Checked;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
