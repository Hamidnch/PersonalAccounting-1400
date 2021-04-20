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
    public partial class FrmMentalCondition : BaseForm
    {
        private readonly
            IRepositoryService<MentalCondition, ViewModelLoadAllMentalCondition, ViewModelSimpleLoadMentalCondition> _mentalConditionService;

        private int _mentalConditionId;

        public static FrmMentalCondition AFrmMentalCondition = null;
        public static FrmMentalCondition Instance()
        {
            return AFrmMentalCondition ?? (AFrmMentalCondition = IocConfig.Container.GetInstance<FrmMentalCondition>());
        }
        public FrmMentalCondition(IRepositoryService<MentalCondition,
            ViewModelLoadAllMentalCondition, ViewModelSimpleLoadMentalCondition> mentalConditionService)
        {
            _mentalConditionService = mentalConditionService;
            InitializeComponent();
            CommonHelper.SetFont(CommonHelper.BaseFont, pnl_Data, rgv_MentalCondition);
            BindGrid();
        }

        private async void BindGrid()
        {
            rgv_MentalCondition.BeginUpdate();
            rgv_MentalCondition.DataSource = await _mentalConditionService.LoadAllViewModelAsync();
            rgv_MentalCondition.EndUpdate();
        }

        private void Pic_Picture_Click(object sender, EventArgs e)
        {
            txt_Extenstion.Text = CommonHelper.OpenDialogForSelectPicture(pic_Picture);
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if (!InitialHelper.HasPermissionFor(this.Name, PermissionMode.Add))
            {
                CommonHelper.ShowNotificationMessage(DefaultConstants.IllegalAccess,
                    DefaultConstants.CreateActionNotAllow);
                    
                return;
            }

            _mode = CommonHelper.Mode.Insert;
            CommonHelper.InsertAction(_mode, pnl_Data, rgv_MentalCondition, btnInsert, btnRegister, btnModify,
                btnDelete, btnCancel, btnClose, txt_Title);
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            if (!InitialHelper.HasPermissionFor(this.Name, PermissionMode.Edit))
            {
                CommonHelper.ShowNotificationMessage(DefaultConstants.IllegalAccess,
                    DefaultConstants.EditActionNotAllow);
                return;
            }

            _mode = CommonHelper.Mode.Update;
            CommonHelper.ModifyAction(_mode, pnl_Data, rgv_MentalCondition, btnInsert, btnRegister,
                btnModify, btnDelete, btnCancel, btnClose);
            _mode = CommonHelper.Mode.Update;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            _mode = CommonHelper.Mode.Cancel;
            CommonHelper.CancelAction(_mode, pnl_Data, rgv_MentalCondition, btnInsert, btnRegister, btnModify,
                btnDelete, btnCancel, btnClose);

            ReturnDetails();
        }

        private async void ReturnDetails()
        {
            try
            {
                if (!(rgv_MentalCondition.CurrentRow is GridViewDataRowInfo dataRow)) return;

                _mentalConditionId = int.Parse(dataRow.Cells["Id"].Value.ToString());
                txt_Title.Text = dataRow.Cells["Title"].Value?.ToString();
                ddl_Status.Text = dataRow.Cells["Status"].Value?.ToString();
                txt_Description.Text = dataRow.Cells["Description"].Value?.ToString();
                if (dataRow.Cells["Picture"].Value != null
                    && dataRow.Cells["Picture"].Value?.ToString() != string.Empty
                    && !(string.IsNullOrEmpty((dataRow.Cells["Picture"].Value?.ToString()))))
                {
                    pic_Picture.Image = CommonHelper.GetImageFromBytes(
                        (byte[])dataRow.Cells["Picture"].Value);
                }
                else
                {
                    pic_Picture.Image = null;
                    pic_Picture.InitialImage = null;
                }
            }
            catch (Exception exception)
            {
                await LoggerService.ErrorAsync(this.Name, "ReturnDetails", exception.Message,
                    exception.ToDetailedString());
            }
        }
        private bool ValidateAllControls()
        {
            return CommonHelper.ValidateControls(txt_Title, _errorProvider,
                       "عنوان را وارد نمایید")
                   || CommonHelper.ValidateControls(ddl_Status, _errorProvider,
                       "وضعیت را مشخص کنید");
        }

        private void Txt_Title_TextChanged(object sender, EventArgs e)
        {
            if (_mode == CommonHelper.Mode.Insert)
            {
                btnRegister.Enabled = (txt_Title.Text != string.Empty
                                       && ddl_Status.Text != string.Empty);
            }
        }

        private void Rgv_MentalCondition_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
        {
            ReturnDetails();
        }

        private async void BtnRegister_Click(object sender, EventArgs e)
        {
            if (ValidateAllControls()) return;

            var dlg = new CustomDialogs(400, 200);
            try
            {
                pic_Picture.Image = (pic_Picture.Image != null)
                    ? new Bitmap(pic_Picture.Image) : null;
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
            var mentalStatus = ddl_Status.SelectedItem.Text;
            var mentalTitle = txt_Title.Text;

            switch (_mode)
            {
                case CommonHelper.Mode.Insert:
                    if (!InitialHelper.HasPermissionFor(this.Name, PermissionMode.Add))
                    {
                        CommonHelper.ShowNotificationMessage(DefaultConstants.IllegalAccess,
                            DefaultConstants.CreateActionNotAllow);
                        return;
                    }

                    try
                    {
                        var newMentalCondition = new MentalCondition(mentalTitle,
                            CommonHelper.ConvertPicBoxImageToByte(pic_Picture, ImageFormat.Png),
                            currentDateTime, currentDateTime,
                            currentUser?.Id, mentalStatus, txt_Description.Text);

                        var status = await _mentalConditionService.CreateAsync(newMentalCondition);

                        switch (status)
                        {
                            case CreateStatus.Exist:
                                dlg.Invoke("خطای تکرار", "این عنوان تکراری می باشد",
                                    CustomDialogs.ImageType.itError3,
                                    CustomDialogs.ButtonType.Ok, InitialHelper.BackColorCustom);
                                txt_Title.Focus();
                                txt_Title.SelectAll();
                                return;
                            case CreateStatus.Failure:
                                dlg.Invoke("بروز خطا", PublicError.Error, CustomDialogs.ImageType.itError5,
                                    CustomDialogs.ButtonType.Ok);
                                return;
                            case CreateStatus.Successful:
                                //CommonHelper.ClearInputControls(pnl_Data);
                                BindGrid();
                                CommonHelper.ShowNotificationMessage("ایجاد شرایط روحی جدید",
                                    $"شرایط روحی جدید با نام {mentalTitle} توسط کاربری با نام" +
                                    $" {currentUser?.UserName} ایجاد گردید.");

                                await LoggerService.InformationAsync(this.Name,
                                    "BtnRegister_Click(Insert Mode)", $" شرایط روحی جدید با نام {mentalTitle} ",
                                    $" توسط کاربری با نام {currentUser?.UserName} ایجاد گردید.");

                                rgv_MentalCondition.Enabled = true;
                                txt_Title.Focus();
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

                        await LoggerService.ErrorAsync(this.Name, "BtnRegister_Click(Insert Mode)", exception.Message,
                            exception.ToDetailedString());
                        return;
                    }
                    break;

                case CommonHelper.Mode.Update:

                    if (!InitialHelper.HasPermissionFor(this.Name, PermissionMode.Edit))
                    {
                        CommonHelper.ShowNotificationMessage(DefaultConstants.IllegalAccess,
                            DefaultConstants.EditActionNotAllow);
                        return;
                    }
                    try
                    {
                        var currentWeatherCondition = await _mentalConditionService.GetByIdAsync(_mentalConditionId);

                        currentWeatherCondition.Title = txt_Title.Text;
                        currentWeatherCondition.UpdateBy = currentUser.Id;
                        currentWeatherCondition.LastUpdate = currentDateTime;
                        currentWeatherCondition.Status = mentalStatus;
                        currentWeatherCondition.Picture = CommonHelper.ConvertPicBoxImageToByte(pic_Picture, ImageFormat.Png);
                        currentWeatherCondition.Description = txt_Description.Text;

                        await _mentalConditionService.UpdateAsync(currentWeatherCondition);
                        BindGrid();

                        CommonHelper.ShowNotificationMessage("ویرایش شرایط روحی",
                            $"شرایط روحی با نام {mentalTitle} توسط کاربری با نام" +
                            $" {currentUser?.UserName} ویرایش  گردید.");

                        await LoggerService.InformationAsync(this.Name,
                            "BtnRegister_Click(Update Mode)", $" شرایط روحی با نام {mentalTitle} ",
                            $" توسط کاربری با نام {currentUser?.UserName} ویرایش گردید.");

                        //CommonHelper.ClearInputControls(pnl_Data);
                        rgv_MentalCondition.Enabled = true;
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
            rgv_MentalCondition.Enabled = true;
            btnRegister.Enabled = false;
            btnClose.Enabled = true;
            _mode = CommonHelper.Mode.None;
        }

        private void Rgv_MentalCondition_CellClick(object sender, GridViewCellEventArgs e)
        {
            if (rgv_MentalCondition.Enabled && rgv_MentalCondition.RowCount > 0)
            { btnModify.Enabled = true; }
            else { btnModify.Enabled = false; }
        }

        private void Txt_Title_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && btnRegister.Enabled)
            {
                BtnRegister_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (!InitialHelper.HasPermissionFor(this.Name, PermissionMode.Delete))
            {
                CommonHelper.ShowNotificationMessage(DefaultConstants.IllegalAccess,
                    DefaultConstants.DeleteActionNotAllow);
                return;
            }

            var dialog = new CustomDialogs(350, 200);
            dialog.Invoke("هشدار حذف", "آيا واقعا میخواهید این رکورد شرایط روحی را حذف کنید؟",
                CustomDialogs.ImageType.itQuestion2,
                CustomDialogs.ButtonType.YesNo, InitialHelper.BackColorCustom);

            if (!dialog.Yes) return;

            if (await _mentalConditionService.IsUsedAsync(_mentalConditionId))
            {
                CommonHelper.ShowNotificationMessage("خطا",
                    "این رکورد شرایط روحی در حال استفاده بوده و حذف نمیشود ");

                return;
            }

            await _mentalConditionService.RemoveAsync(_mentalConditionId);

            CommonHelper.ShowNotificationMessage("پیام", $"شرایط روحی با شناسه {_mentalConditionId} حذف گردید");
            await LoggerService.InsertLogAsync(this.Name, "btnDelete_Click", LogLevel.Information,
                $"شرایط روحی با نام {txt_Title.Text} ",
                $"و توسط کاربر  {InitialHelper.CurrentUser.UserName} حذف گردید.");

            _mode = CommonHelper.Mode.None;
            rgv_MentalCondition.Enabled = true;
            CommonHelper.EnableControls(pnl_Data, false);

            btnCancel.Enabled = false;
            btnInsert.Enabled = true;
            btnDelete.Enabled = true;

            BindGrid();
        }
    }
}
