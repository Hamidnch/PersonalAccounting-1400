using MessageBoxHamidNCH;
using PersonalAccounting.BLL.Enum;
using PersonalAccounting.BLL.IService;
using PersonalAccounting.CommonLibrary.Helper;
using PersonalAccounting.Domain.Entity;
using PersonalAccounting.UI.Helper;
using PersonalAccounting.UI.Infrastructure;
using System;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace PersonalAccounting.UI
{
    public partial class FrmMeasurementUnit : BaseForm
    {
        private readonly IMeasurementUnitService _measurementUnitService;

        private int _measurementUnitId;

        public static FrmMeasurementUnit AFrmMeasurementUnit = null;
        public static FrmMeasurementUnit Instance()
        {
            return AFrmMeasurementUnit ?? (AFrmMeasurementUnit =
                IocConfig.Container.GetInstance<FrmMeasurementUnit>());
        }

        public FrmMeasurementUnit(IMeasurementUnitService measurementUnitService)
        {
            _measurementUnitService = measurementUnitService;
            InitializeComponent();
            BindGrid();
        }

        private async void BindGrid()
        {
            rlv_MeasurementUnit.BeginUpdate();
            rlv_MeasurementUnit.DataSource = await _measurementUnitService.LoadAllViewModelAsync();
            rlv_MeasurementUnit.EndUpdate();
        }

        private async void ReturnMeasurementUnitDetails()
        {
            try
            {
                if (rlv_MeasurementUnit.SelectedIndex < 0) return;

                _measurementUnitId = int.Parse(rlv_MeasurementUnit.SelectedItem.Value.ToString());
                txt_MeasurementUnitName.Text = rlv_MeasurementUnit.SelectedItem.Text;
                //foreach (var t in rlv_MeasurementUnit.Items.Where(t => t.Selected))
                //{
                //    txt_MeasurementUnitName.Text = t.Text;
                //    break;
                //}
            }
            catch (Exception exception)
            {
                await LoggerService.ErrorAsync(this.Name, "ReturnMeasurementUnitDetails", exception.Message,
                    exception.ToDetailedString());
            }
        }

        private bool ValidateAllControls()
        {
            return CommonHelper.ValidateControls(txt_MeasurementUnitName, _errorProvider,
                "عنوان آحاد سنجش  را وارد نمایید");
        }

        private void GetMeasurementUnitSelectedItem()
        {
            ReturnMeasurementUnitDetails();
            btnRegister.Enabled = false;
            if (rlv_MeasurementUnit.Enabled && txt_MeasurementUnitName.Text != string.Empty)
            {
                btnModify.Enabled = true;
            }
            else
            {
                btnModify.Enabled = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!InitialHelper.HasPermissionFor(this.Name, PermissionMode.Add))
            {
                CommonHelper.ShowNotificationMessage(DefaultConstants.IllegalAccess,DefaultConstants.CreateActionNotAllow);
                return;
            }

            _mode = CommonHelper.Mode.Insert;
            CommonHelper.InsertAction(_mode, pnl_Data, rlv_MeasurementUnit,
                btnInsert, btnRegister, btnModify, btnDelete, btnCancel,
                btnClose, txt_MeasurementUnitName);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (!InitialHelper.HasPermissionFor(this.Name, PermissionMode.Edit))
            {
                CommonHelper.ShowNotificationMessage(DefaultConstants.IllegalAccess, DefaultConstants.EditActionNotAllow);
                return;
            }
            _mode = CommonHelper.Mode.Update;
            CommonHelper.ModifyAction(_mode, pnl_Data, rlv_MeasurementUnit, btnInsert, btnRegister,
                btnModify, btnDelete, btnCancel, btnClose);
            _mode = CommonHelper.Mode.Update;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _mode = CommonHelper.Mode.Cancel;
            CommonHelper.CancelAction(_mode, pnl_Data, rlv_MeasurementUnit,
                btnInsert, btnRegister, btnModify, btnDelete, btnCancel, btnClose);

            ReturnMeasurementUnitDetails();
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            if (ValidateAllControls()) return;

            var currentUser = InitialHelper.CurrentUser;
            var currentDateTime = InitialHelper.CurrentDateTime;
            var measurementUnitName = txt_MeasurementUnitName.Text;

            var dlg = new CustomDialogs(400, 200);

            switch (_mode)
            {
                case CommonHelper.Mode.Insert:
                    if (!InitialHelper.HasPermissionFor(this.Name, PermissionMode.Add))
                    {
                        CommonHelper.ShowNotificationMessage(DefaultConstants.IllegalAccess, DefaultConstants.CreateActionNotAllow);
                        return;
                    }
                    var newMeasurementUnit = new MeasurementUnit(measurementUnitName,
                        currentDateTime, null, currentUser.Id);

                    if (await _measurementUnitService.ExistAsync(newMeasurementUnit))
                    {
                        dlg.Invoke("خطای تکرار", "این عنوان سنجش تکراری می باشد",
                            CustomDialogs.ImageType.itError3,
                            CustomDialogs.ButtonType.Ok, InitialHelper.BackColorCustom);
                        txt_MeasurementUnitName.Focus();
                        txt_MeasurementUnitName.SelectAll();
                        return;
                    }
                    try
                    {
                        await _measurementUnitService.CreateAsync(newMeasurementUnit);
                        BindGrid();

                        CommonHelper.ShowNotificationMessage("ایجاد واحد سنجش جدید",
                            $"واحد سنجش جدید با نام {measurementUnitName} ایجاد گردید.");

                        await LoggerService.InformationAsync(this.Name, "btnRegister_Click(Insert Mode)", 
                            $"ایجاد واحد سنجش جدید با نام {measurementUnitName} ",
                            $"توسط کاربر  {currentUser.UserName} ایجاد گردید.");

                        //CommonHelper.ClearInputControls(this);
                        txt_MeasurementUnitName.Focus();
                        rlv_MeasurementUnit.Enabled = true;
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
                            CommonHelper.ShowNotificationMessage(DefaultConstants.IllegalAccess, DefaultConstants.EditActionNotAllow);
                            return;
                        }

                        var currentMeasurementUnit =
                            await _measurementUnitService.GetByIdAsync(_measurementUnitId);

                        currentMeasurementUnit.Name = measurementUnitName;
                        currentMeasurementUnit.UpdateBy = currentUser.Id;
                        currentMeasurementUnit.LastUpdate = currentDateTime;

                        await _measurementUnitService.UpdateAsync(currentMeasurementUnit);

                        BindGrid();

                        CommonHelper.ShowNotificationMessage("ویرایش واحد سنجش",
                            $"واحد سنجش با نام {measurementUnitName} ویرایش گردید.");

                        await LoggerService.InsertLogAsync(this.Name, "btnRegister_Click(Update Mode)", LogLevel.Information,
                            $"واحد سنجش با نام {measurementUnitName} ",
                            $"و توسط کاربر  {currentUser.UserName} ویرایش گردید.");

                        //CommonHelper.ClearInputControls(pnl_Data);
                        rlv_MeasurementUnit.Enabled = true;
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
            rlv_MeasurementUnit.Enabled = true;
            btnRegister.Enabled = false;
            btnClose.Enabled = true;
            _mode = CommonHelper.Mode.None;
        }

        private async void txt_MeasurementUnitName_TextChanged(object sender, EventArgs e)
        {
            btnRegister.Enabled = (txt_MeasurementUnitName.Text != string.Empty) &&
                (!await _measurementUnitService.ExistAsync(txt_MeasurementUnitName.Text));
        }

        private void rlv_MeasurementUnit_ItemMouseClick(object sender, ListViewItemEventArgs e)
        {
            GetMeasurementUnitSelectedItem();
        }

        private void rlv_MeasurementUnit_KeyDown(object sender, KeyEventArgs e)
        {
            GetMeasurementUnitSelectedItem();
        }

        private void rlv_MeasurementUnit_ColumnCreating(object sender, ListViewColumnCreatingEventArgs e)
        {
            switch (e.Column.FieldName)
            {
                case "MeasurementUnitId":
                    e.Column.HeaderText = "کد";
                    e.Column.Visible = true;
                    break;
                case "MeasurementUnitName":
                    e.Column.HeaderText = "عنوان";
                    break;
                case "MeasurementUnitCreationUserName":
                    e.Column.HeaderText = "کاربر ثبت کننده";
                    break;
                case "MeasurementUnitCreationDate":
                    e.Column.Visible = false;
                    break;
                case "MeasurementUnitPersianRegisterDate":
                    e.Column.HeaderText = "تاریخ ثبت";
                    break;
                case "MeasurementUnitLastUpdate":
                    e.Column.Visible = false;
                    break;
                case "MeasurementUnitPersianLastUpdate":
                    e.Column.HeaderText = "تاریخ آخرین ویرایش";
                    break;
                case "MeasurementUnitUpdateByUserName":
                    e.Column.HeaderText = "کاربر ویرایش کننده";
                    break;
                    //case "MeasurementUnitUpdateByUser":
                    //    e.Column.HeaderText = "کاربر ویرایش کننده";
                    //    e.Column.Visible = true;
                    //    break;
            }
        }

        private void Txt_MeasurementUnitName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && btnRegister.Enabled)
            {
                btnRegister_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (rlv_MeasurementUnit.Items.Count <= 0) return;

            if (!InitialHelper.HasPermissionFor(this.Name, PermissionMode.Delete))
            {
                CommonHelper.ShowNotificationMessage(DefaultConstants.IllegalAccess, DefaultConstants.DeleteActionNotAllow);
                return;
            }

            if (rlv_MeasurementUnit.SelectedIndex < 0) return;

            var dialog = new CustomDialogs(350, 200);
            dialog.Invoke("هشدار حذف", "آيا واقعا میخواهید این واحد سنجش را حذف کنید؟",
                CustomDialogs.ImageType.itQuestion2,
                CustomDialogs.ButtonType.YesNo, InitialHelper.BackColorCustom);

            if (!dialog.Yes) return;

            var measurementUnitId = int.Parse(rlv_MeasurementUnit.SelectedItem.Value.ToString());

            if (await _measurementUnitService.IsUsedAsync(measurementUnitId))
            {
                CommonHelper.ShowNotificationMessage(DefaultConstants.IllegalAccess, DefaultConstants.DeleteActionNotAllow);

                return;
            }

            await _measurementUnitService.RemoveAsync(measurementUnitId);

            CommonHelper.ShowNotificationMessage("پیام", $"واحد سنجش با شناسه {measurementUnitId} حذف گردید");
            
            await LoggerService.InformationAsync(this.Name, "BtnDelete_Click", $"حذف واحد سنجش با شماره {measurementUnitId}",
                $"این واحد سنجش توسط کاربری با نام {InitialHelper.CurrentUser.UserName} حذف گردید.");

            _mode = CommonHelper.Mode.None;
            rlv_MeasurementUnit.Enabled = true;
            CommonHelper.EnableControls(pnl_Data, false);

            btnCancel.Enabled = false;
            btnInsert.Enabled = true;
            btnDelete.Enabled = true;

            BindGrid();
        }
    }
}
