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
    public partial class FrmWeatherCondition : BaseForm
    {
        private readonly
            IRepositoryService<WeatherCondition, ViewModelLoadAllWeatherCondition, ViewModelSimpleLoadWeatherCondition> _weatherConditionService;

        private int _weatherConditionId;

        public static FrmWeatherCondition AFrmWeatherCondition = null;
        public static FrmWeatherCondition Instance()
        {
            return AFrmWeatherCondition ??
                   (AFrmWeatherCondition = IocConfig.Container.GetInstance<FrmWeatherCondition>());
        }
        public FrmWeatherCondition(
            IRepositoryService<WeatherCondition, ViewModelLoadAllWeatherCondition, ViewModelSimpleLoadWeatherCondition> weatherConditionService)
        {
            _weatherConditionService = weatherConditionService;
            InitializeComponent();
            CommonHelper.SetFont(CommonHelper.BaseFont, pnl_Data, rgv_WeatherCondition);
            rddl_Status.SetEnableDisableStatusDropdownList();
            BindGrid();
        }
        private async void BindGrid()
        {
            rgv_WeatherCondition.BeginUpdate();
            rgv_WeatherCondition.DataSource = await _weatherConditionService.LoadAllViewModelAsync();
            rgv_WeatherCondition.EndUpdate();
        }

        private void Pic_Picture_Click(object sender, System.EventArgs e)
        {
            txt_Extenstion.Text = CommonHelper.OpenDialogForSelectPicture(pic_Picture);
        }

        private void BtnInsert_Click(object sender, System.EventArgs e)
        {
            if (!InitialHelper.HasPermissionFor(this.Name, PermissionMode.Add))
            {
                CommonHelper.ShowNotificationMessage(DefaultConstants.IllegalAccess,
                    DefaultConstants.CreateActionNotAllow);
                return;
            }

            _mode = CommonHelper.Mode.Insert;
            CommonHelper.InsertAction(_mode, pnl_Data, rgv_WeatherCondition, btnInsert, btnRegister, btnModify,
                btnDelete, btnCancel, btnClose, txt_Title);

            rddl_Status.SelectedValue = 0;
        }

        private void BtnModify_Click(object sender, System.EventArgs e)
        {
            if (!InitialHelper.HasPermissionFor(this.Name, PermissionMode.Edit))
            {
                CommonHelper.ShowNotificationMessage(DefaultConstants.IllegalAccess,
                    DefaultConstants.EditActionNotAllow);
                return;
            }

            _mode = CommonHelper.Mode.Update;
            CommonHelper.ModifyAction(_mode, pnl_Data, rgv_WeatherCondition, btnInsert, btnRegister,
                btnModify, btnDelete, btnCancel, btnClose);
            _mode = CommonHelper.Mode.Update;
        }

        private void BtnCancel_Click(object sender, System.EventArgs e)
        {
            _mode = CommonHelper.Mode.Cancel;
            CommonHelper.CancelAction(_mode, pnl_Data, rgv_WeatherCondition, btnInsert, btnRegister, btnModify,
                btnDelete, btnCancel, btnClose);

            ReturnDetails();
        }
        private async void ReturnDetails()
        {
            try
            {
                if (!(rgv_WeatherCondition.CurrentRow is GridViewDataRowInfo dataRow)) return;

                _weatherConditionId = int.Parse(dataRow.Cells["Id"].Value.ToString());
                txt_Title.Text = dataRow.Cells["Title"].Value?.ToString();
                rddl_Status.Text = dataRow.Cells["Status"].Value?.ToString();
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
                       "عنوان  را وارد نمایید")
                   || CommonHelper.ValidateControls(rddl_Status, _errorProvider,
                       "وضعیت را مشخص کنید");
        }

        private void Txt_Title_TextChanged(object sender, EventArgs e)
        {
            if (_mode == CommonHelper.Mode.Insert)
            {
                btnRegister.Enabled = (txt_Title.Text != string.Empty
                                       && rddl_Status.Text != string.Empty);
            }
        }

        private void Rgv_WeatherCondition_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
        {
            ReturnDetails();
        }

        private async void BtnRegister_Click(object sender, System.EventArgs e)
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
            var weatherConditionTitle = txt_Title.Text;
            var weatherConditionStatus = rddl_Status.Text;

            switch (_mode)
            {
                case CommonHelper.Mode.Insert:
                    try
                    {
                        if (!InitialHelper.HasPermissionFor(this.Name, PermissionMode.Add))
                        {
                            CommonHelper.ShowNotificationMessage(DefaultConstants.IllegalAccess,
                                DefaultConstants.CreateActionNotAllow);
                            return;
                        }

                        var newMentalCondition = new WeatherCondition(weatherConditionTitle,
                            CommonHelper.ConvertPicBoxImageToByte(pic_Picture, ImageFormat.Png),
                            currentDateTime, currentDateTime, currentUser?.Id,
                            weatherConditionStatus, txt_Description.Text);

                        var status = await _weatherConditionService.CreateAsync(newMentalCondition);

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
                                BindGrid();
                                CommonHelper.ShowNotificationMessage("ایجاد شرایط آب و هوایی جدید",
                                    $"شرایط آب و هوای جدید با نام {weatherConditionTitle} ایجاد گردید.");

                                await LoggerService.InformationAsync(this.Name, "btnRegister_Click(Insert Mode)",
                                    $"شرایط آب و هوای جدید با نام {weatherConditionTitle} ",
                                    $" توسط کاربر  {currentUser?.UserName} ایجاد گردید.");
                                
                                //CommonHelper.ClearInputControls(pnl_Data);
                                rgv_WeatherCondition.Enabled = true;
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
                        await LoggerService.ErrorAsync(this.Name, "btnRegister_Click(Insert Mode)", exception.Message,
                            exception.ToDetailedString());
                        return;
                    }
                    break;

                case CommonHelper.Mode.Update:
                    try
                    {
                        if (!InitialHelper.HasPermissionFor(this.Name, PermissionMode.Edit))
                        {
                            CommonHelper.ShowNotificationMessage(DefaultConstants.IllegalAccess,
                                DefaultConstants.EditActionNotAllow);
                            return;
                        }

                        var currentWeatherCondition = await _weatherConditionService.GetByIdAsync(_weatherConditionId);
                        currentWeatherCondition.Title = weatherConditionTitle;
                        currentWeatherCondition.UpdateBy = currentUser.Id;
                        currentWeatherCondition.LastUpdate = currentDateTime;
                        currentWeatherCondition.Status = rddl_Status.Text;
                        currentWeatherCondition.Picture = CommonHelper.ConvertPicBoxImageToByte(pic_Picture, ImageFormat.Png);
                        currentWeatherCondition.Description = txt_Description.Text;

                        await _weatherConditionService.UpdateAsync(currentWeatherCondition);
                        BindGrid();
                        CommonHelper.ShowNotificationMessage("ویرایش شرایط آب و هوایی",
                            $"شرایط آب و هوایی با نام {weatherConditionTitle} ویرایش گردید.");

                        await LoggerService.InformationAsync(this.Name, "btnRegister_Click(Update Mode)",
                            $"شرایط آب و هوای با نام {weatherConditionTitle} ",
                            $" توسط کاربر  {currentUser.UserName} ویرایش گردید.");

                        //CommonHelper.ClearInputControls(pnl_Data);
                        rgv_WeatherCondition.Enabled = true;
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
            rgv_WeatherCondition.Enabled = true;
            btnRegister.Enabled = false;
            btnClose.Enabled = true;
            _mode = CommonHelper.Mode.None;
        }

        private void Rgv_WeatherCondition_CellClick(object sender, GridViewCellEventArgs e)
        {
            if (rgv_WeatherCondition.Enabled && rgv_WeatherCondition.RowCount > 0)
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
            if (rgv_WeatherCondition.Rows.Count <= 0) return;

            if (!InitialHelper.HasPermissionFor(this.Name, PermissionMode.Delete))
            {
                CommonHelper.ShowNotificationMessage(DefaultConstants.IllegalAccess,
                    DefaultConstants.DeleteActionNotAllow);
                return;
            }

            var dialog = new CustomDialogs(350, 200);
            dialog.Invoke("هشدار حذف", "آيا واقعا میخواهید این نوع وضعیت آب و هوا را حذف کنید؟",
                CustomDialogs.ImageType.itQuestion2,
                CustomDialogs.ButtonType.YesNo, InitialHelper.BackColorCustom);

            if (!dialog.Yes) return;

            if (await _weatherConditionService.IsUsedAsync(_weatherConditionId))
            {
                CommonHelper.ShowNotificationMessage("خطا",
                    "نوع وضعیت آب و هوا در حال استفاده بوده و حذف نمیشود ");

                return;
            }

            await _weatherConditionService.RemoveAsync(_weatherConditionId);

            CommonHelper.ShowNotificationMessage("پیام", $"نوع وضعیت آب و هوا با شناسه {_weatherConditionId} حذف گردید");

            await LoggerService.InformationAsync(this.Name, "BtnDelete_Click", $"حذف شرایط آب و هوا با شماره {_weatherConditionId}",
                $"این وضعیت آب و هوا توسط کاربری با نام {InitialHelper.CurrentUser.UserName} حذف گردید.");
            _mode = CommonHelper.Mode.None;
            rgv_WeatherCondition.Enabled = true;
            CommonHelper.EnableControls(pnl_Data, false);

            btnCancel.Enabled = false;
            btnInsert.Enabled = true;
            btnDelete.Enabled = true;

            BindGrid();
        }
    }
}
