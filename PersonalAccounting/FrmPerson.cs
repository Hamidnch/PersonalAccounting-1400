using MessageBoxHamidNCH;
using PersonalAccounting.BLL.Enum;
using PersonalAccounting.BLL.IService;
using PersonalAccounting.CommonLibrary.Helper;
using PersonalAccounting.Domain.Entity;
using PersonalAccounting.Domain.ViewModel;
using PersonalAccounting.UI.Helper;
using PersonalAccounting.UI.Infrastructure;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace PersonalAccounting.UI
{
    public partial class FrmPerson : BaseForm
    {
        private readonly IRepositoryService<Person, ViewModelLoadAllPerson, ViewModelSimpleLoadPerson> _personService;

        private int _personId;

        public static FrmPerson AFrmPerson = null;
        public static FrmPerson Instance()
        {
            return AFrmPerson ?? (AFrmPerson = IocConfig.Container.GetInstance<FrmPerson>());
        }
        public FrmPerson(IRepositoryService<Person, ViewModelLoadAllPerson, ViewModelSimpleLoadPerson> personService)
        {
            _personService = personService;
            InitializeComponent();
            CommonHelper.SetFont(CommonHelper.BaseFont, pnl_Data, rgv_Person);
            rddl_PersonStatus.SetEnableDisableStatusDropdownList();
            rddl_PersonSex.SetMaleAndFemaleOptionsDropdownList();
            BindGrid();
        }

        private async void BindGrid()
        {
            rgv_Person.BeginUpdate();
            rgv_Person.DataSource = await _personService.LoadAllViewModelAsync();
            rgv_Person.EndUpdate();
        }

        private void pic_Person_Click(object sender, EventArgs e)
        {
            txt_PersonDescription.Text = CommonHelper.OpenDialogForSelectPicture(pic_PersonPicture);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!InitialHelper.HasPermissionFor(this.Name, PermissionMode.Add))
            {
                CommonHelper.ShowNotificationMessage(DefaultConstants.IllegalAccess, DefaultConstants.CreateActionNotAllow);
                return;
            }

            _mode = CommonHelper.Mode.Insert;
            CommonHelper.InsertAction(_mode, pnl_Data, rgv_Person, btnInsert, btnRegister, btnModify,
                btnDelete, btnCancel, btnClose, txt_PersonFullName);

            rddl_PersonStatus.SelectedValue = 0;
            rddl_PersonSex.SelectedValue = 0;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (!InitialHelper.HasPermissionFor(this.Name, PermissionMode.Edit))
            {
                CommonHelper.ShowNotificationMessage(DefaultConstants.IllegalAccess, DefaultConstants.EditActionNotAllow);
                return;
            }

            _mode = CommonHelper.Mode.Update;
            CommonHelper.ModifyAction(_mode, pnl_Data, rgv_Person, btnInsert, btnRegister,
                btnModify, btnDelete, btnCancel, btnClose);
            _mode = CommonHelper.Mode.Update;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _mode = CommonHelper.Mode.Cancel;
            CommonHelper.CancelAction(_mode, pnl_Data, rgv_Person, btnInsert, btnRegister, btnModify,
                btnDelete, btnCancel, btnClose);

            ReturnPersonDetails();
        }

        private async void ReturnPersonDetails()
        {
            try
            {
                if (!(rgv_Person.CurrentRow is GridViewDataRowInfo dataRow)) return;

                _personId = int.Parse(dataRow.Cells["PersonId"].Value.ToString());
                txt_PersonFullName.Text = dataRow.Cells["PersonFullName"].Value?.ToString();
                rddl_PersonSex.Text = dataRow.Cells["PersonSex"].Value?.ToString();
                rddl_PersonStatus.Text = dataRow.Cells["PersonStatus"].Value?.ToString();
                txt_PersonDescription.Text = dataRow.Cells["PersonDescription"].Value?.ToString();
                if (dataRow.Cells["PersonPicture"].Value != null
                    && dataRow.Cells["PersonPicture"].Value?.ToString() != string.Empty
                    && !(string.IsNullOrEmpty((dataRow.Cells["PersonPicture"].Value?.ToString()))))
                {
                    pic_PersonPicture.Image = CommonHelper.GetImageFromBytes(
                        (byte[])dataRow.Cells["PersonPicture"].Value);
                }
                else
                {
                    pic_PersonPicture.Image = null;
                    pic_PersonPicture.InitialImage = null;
                }
            }
            catch (Exception exception)
            {
                await LoggerService.ErrorAsync(this.Name, "ReturnPersonDetails", exception.Message,
                    exception.ToDetailedString());
            }

        }
        private bool ValidateAllControls()
        {
            return CommonHelper.ValidateControls(txt_PersonFullName, _errorProvider,
                       "نام شخص  را وارد نمایید")
                   || CommonHelper.ValidateControls(rddl_PersonSex, _errorProvider,
                       "جنسیت شخص  را تعیین نمایید")
                   || CommonHelper.ValidateControls(rddl_PersonStatus, _errorProvider,
                       "وضعیت شخص  را مشخص کنید");
        }

        private void txt_PersonFullName_TextChanged(object sender, EventArgs e)
        {
            if (_mode == CommonHelper.Mode.Insert)
            {
                btnRegister.Enabled = (txt_PersonFullName.Text != string.Empty
                                       && rddl_PersonSex.Text != string.Empty
                    && rddl_PersonStatus.Text != string.Empty);
            }
        }

        private void rgv_Person_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
        {
            ReturnPersonDetails();
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            if (ValidateAllControls()) return;

            var dlg = new CustomDialogs(400, 200);
            try
            {
                pic_PersonPicture.Image = (pic_PersonPicture.Image != null)
                    ? new Bitmap(pic_PersonPicture.Image) : null;
            }
            catch (Exception ex)
            {
                dlg.Invoke("بروز خطا", ex.ToDetailedString(),
                    CustomDialogs.ImageType.itError3,
                    CustomDialogs.ButtonType.Ok, InitialHelper.BackColorCustom);
            }

            //var imageFormat = CommonHelper.GetImageFormatByExtenstion(txt_Extenstion.Text);

            var currentUser = InitialHelper.CurrentUser;
            var currentDateTime = InitialHelper.CurrentDateTime;
            var personFullName = txt_PersonFullName.Text;
            var personSex = rddl_PersonSex.SelectedItem.Text;
            var personStatus = rddl_PersonStatus.Text;
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

                        var newPerson = new Person(personFullName, personSex,
                            currentDateTime, currentDateTime,
                            CommonHelper.ConvertPicBoxImageToByte(pic_PersonPicture, ImageFormat.Png),
                            currentUser?.Id, personStatus,
                            txt_PersonDescription.Text);

                        var status = await _personService.CreateAsync(newPerson);

                        switch (status)
                        {
                            case CreateStatus.Exist:
                                dlg.Invoke("خطای تکرار", "این نام شخص تکراری می باشد",
                                    CustomDialogs.ImageType.itError3,
                                    CustomDialogs.ButtonType.Ok, InitialHelper.BackColorCustom);
                                txt_PersonFullName.Focus();
                                txt_PersonFullName.SelectAll();
                                return;
                            case CreateStatus.Failure:
                                dlg.Invoke("بروز خطا", "خطا در ایجاد شخص جدید", CustomDialogs.ImageType.itError5,
                                    CustomDialogs.ButtonType.Ok);
                                return;
                            case CreateStatus.Successful:
                                //CommonHelper.ClearInputControls(pnl_Data);
                                BindGrid();

                                CommonHelper.ShowNotificationMessage("ایجاد شخص جدید",
                                    $"شخص جدید با نام {personFullName} ایجاد گردید.");

                                await LoggerService.InformationAsync(this.Name, "btnRegister_Click(Insert Mode)",
                                    $"ایجاد شخص جدید با نام {personFullName} ",
                                    $"و توسط کاربر  {currentUser?.UserName} ایجاد گردید.");

                                rgv_Person.Enabled = true;
                                txt_PersonFullName.Focus();
                                CommonHelper.EnableControls(pnl_Data, false);
                                btnCancel.Enabled = false;
                                btnInsert.Enabled = true;
                                btnDelete.Enabled = true;
                                break;
                            default:
                                throw new ArgumentOutOfRangeException();
                        }

                    }
                    catch (Exception exception)
                    {
                        dlg.Invoke("خطا در ثبت اطلاعات",
                            "خطای زیر به وقوع پیوست \n" + exception.Message,
                            CustomDialogs.ImageType.itError2, CustomDialogs.ButtonType.Ok,
                            InitialHelper.BackColorCustom);

                        await LoggerService.ErrorAsync(this.Name, "btnRegister_Click(Insert Mode)", exception.Message,
                            exception.ToDetailedString());

                        return;
                    }
                    break;

                case CommonHelper.Mode.Update:
                    try
                    {
                        var currentPerson = await _personService.GetByIdAsync(_personId);

                        currentPerson.FullName = personFullName;
                        currentPerson.UpdateBy = currentUser.Id;
                        currentPerson.Gender = personSex;//ddl_PersonSex.SelectedItem.Text;
                        currentPerson.LastUpdate = currentDateTime;
                        currentPerson.Status = personStatus;
                        currentPerson.Picture = CommonHelper.ConvertPicBoxImageToByte(pic_PersonPicture, ImageFormat.Png);
                        currentPerson.Description = txt_PersonDescription.Text;

                        await _personService.UpdateAsync(currentPerson);
                        BindGrid();

                        CommonHelper.ShowNotificationMessage("ویرایش شخص",
                            $"شخص با نام {txt_PersonFullName.Text} ویرایش گردید.");

                        await LoggerService.InformationAsync(this.Name, "btnRegister_Click(Update Mode)",
                            $"ویرایش شخص با نام {personFullName} ",
                            $"و توسط کاربر  {currentUser.UserName} انجام گردید.");

                        //CommonHelper.ClearInputControls(pnl_Data);
                        rgv_Person.Enabled = true;
                        CommonHelper.EnableControls(pnl_Data, false);
                        btnCancel.Enabled = false;
                        btnInsert.Enabled = true;
                        btnDelete.Enabled = true;
                    }
                    catch (Exception exception)
                    {
                        dlg.Invoke("خطا در ثبت اطلاعات",
                            "خطای زیر به وقوع پیوست \n" + exception.Message,
                            CustomDialogs.ImageType.itError2, CustomDialogs.ButtonType.Ok,
                            InitialHelper.BackColorCustom);

                        await LoggerService.ErrorAsync(this.Name, "btnRegister_Click(Update Mode)", exception.Message,
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
            rgv_Person.Enabled = true;
            btnRegister.Enabled = false;
            btnClose.Enabled = true;
            _mode = CommonHelper.Mode.None;
        }

        private void rgv_Person_CellClick(object sender, GridViewCellEventArgs e)
        {
            if (rgv_Person.Enabled && rgv_Person.RowCount > 0)
            { btnModify.Enabled = true; }
            else { btnModify.Enabled = false; }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Txt_PersonFullName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && btnRegister.Enabled)
            {
                btnRegister_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private void FrmPerson_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(e.KeyCode.ToString());
            //switch (e.KeyCode)
            //{
            //    case Keys.Insert:
            //        btnInsert_Click(sender, e);
            //        break;
            //    case Keys.F2:
            //        btnModify_Click(sender, e);
            //        break;
            //    case Keys.Escape:
            //        btnCancel_Click(sender, e);
            //        break;
            //}

            //if ((e.Control) && (e.KeyCode == Keys.S))
            //{
            //    btnRegister_Click(sender, e);
            //}
        }

        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            if (rgv_Person.Rows.Count <= 0) return;

            if (!InitialHelper.HasPermissionFor(this.Name, PermissionMode.Delete))
            {
                CommonHelper.ShowNotificationMessage(DefaultConstants.IllegalAccess, DefaultConstants.DeleteActionNotAllow);
                return;
            }


            var dialog = new CustomDialogs(350, 200);
            dialog.Invoke("هشدار حذف", "آيا واقعا میخواهید این شخص را حذف کنید؟",
                CustomDialogs.ImageType.itQuestion2,
                CustomDialogs.ButtonType.YesNo, InitialHelper.BackColorCustom);

            if (!dialog.Yes) return;

            if (await _personService.IsUsedAsync(_personId))
            {
                CommonHelper.ShowNotificationMessage("خطا",
                    "شخص در حال استفاده بوده و حذف نمیشود ");

                return;
            }

            await _personService.RemoveAsync(_personId);

            CommonHelper.ShowNotificationMessage("پیام", $"شخص با شناسه {_personId} حذف گردید");
            await LoggerService.InsertLogAsync(this.Name, "BtnDelete_Click", LogLevel.Information,
                $"شخص با نام {txt_PersonFullName.Text} ",
                $"توسط کاربر  {InitialHelper.CurrentUser.UserName} حذف گردید.");

            _mode = CommonHelper.Mode.None;
            rgv_Person.Enabled = true;
            CommonHelper.EnableControls(pnl_Data, false);

            btnCancel.Enabled = false;
            btnInsert.Enabled = true;
            btnDelete.Enabled = true;

            BindGrid();
        }
    }
}
