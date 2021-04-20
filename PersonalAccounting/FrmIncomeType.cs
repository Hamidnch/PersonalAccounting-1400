using MessageBoxHamidNCH;
using PersonalAccounting.BLL.Enum;
using PersonalAccounting.BLL.IService;
using PersonalAccounting.CommonLibrary.Helper;
using PersonalAccounting.Domain.Entity;
using PersonalAccounting.Domain.ViewModel;
using PersonalAccounting.UI.Helper;
using PersonalAccounting.UI.Infrastructure;
using System;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace PersonalAccounting.UI
{
    public partial class FrmIncomeType : BaseForm
    {
        private readonly IRepositoryService<IncomeType,
            ViewModelLoadAllIncomeType, IncomeType> _incomeTypeService;

        private int _incomeTypeId;

        public static FrmIncomeType AFrmIncomeType = null;
        public static FrmIncomeType Instance()
        {
            return AFrmIncomeType ?? (AFrmIncomeType = IocConfig.Container.GetInstance<FrmIncomeType>());
        }
        public FrmIncomeType(
            IRepositoryService<IncomeType, ViewModelLoadAllIncomeType, IncomeType> incomeTypeService)
        {
            _incomeTypeService = incomeTypeService;
            InitializeComponent();
            BindGrid();
        }

        private async void BindGrid()
        {
            rgv_IncomeType.BeginUpdate();
            rgv_IncomeType.DataSource = await _incomeTypeService.LoadAllViewModelAsync();
            rgv_IncomeType.EndUpdate();
        }
        private bool ValidateAllControls()
        {
            return CommonHelper.ValidateControls(txt_IncomeTypeTitle, _errorProvider,
                " عنوان درآمد  را وارد نمایید");
        }
        private async void ReturnIncomeTypeDetails()
        {
            try
            {
                if (!(rgv_IncomeType.CurrentRow is GridViewDataRowInfo dataRow)) return;

                _incomeTypeId = int.Parse(dataRow.Cells["IncomeTypeId"].Value.ToString());
                txt_IncomeTypeTitle.Text = dataRow.Cells["IncomeTypeTitle"].Value.ToString();
            }
            catch (Exception exception)
            {
                await LoggerService.ErrorAsync(this.Name, "ReturnIncomeTypeDetails",
                    exception.Message, exception.ToDetailedString());
            }
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!InitialHelper.HasPermissionFor(this.Name, PermissionMode.Add))
            {
                CommonHelper.ShowNotificationMessage(DefaultConstants.IllegalAccess, 
                    DefaultConstants.CreateActionNotAllow);

                return;
            }

            _mode = CommonHelper.Mode.Insert;
            CommonHelper.InsertAction(_mode, pnl_Data, rgv_IncomeType, btnInsert, btnRegister, btnModify,
                btnDelete, btnCancel, btnClose, txt_IncomeTypeTitle);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (!InitialHelper.HasPermissionFor(this.Name, PermissionMode.Edit))
            {
                CommonHelper.ShowNotificationMessage(DefaultConstants.IllegalAccess,
                    DefaultConstants.EditActionNotAllow);
                return;
            }

            _mode = CommonHelper.Mode.Update;
            CommonHelper.ModifyAction(_mode, pnl_Data, rgv_IncomeType, btnInsert, btnRegister,
                btnModify, btnDelete, btnCancel, btnClose);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _mode = CommonHelper.Mode.Cancel;
            CommonHelper.CancelAction(_mode, pnl_Data, rgv_IncomeType, btnInsert, btnRegister, btnModify,
                btnDelete, btnCancel, btnClose);

            ReturnIncomeTypeDetails();
        }

        private void txt_IncomeTypeTitle_TextChanged(object sender, EventArgs e)
        {
            if (_mode == CommonHelper.Mode.Insert)
            {
                btnRegister.Enabled = (txt_IncomeTypeTitle.Text != string.Empty);
            }
        }

        private void rgv_IncomeType_CellClick(object sender, GridViewCellEventArgs e)
        {
            if (rgv_IncomeType.Enabled && rgv_IncomeType.RowCount > 0)
            { btnModify.Enabled = true; }
            else { btnModify.Enabled = false; }
        }

        private void rgv_IncomeType_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
        {
            ReturnIncomeTypeDetails();
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            if (ValidateAllControls()) return;

            var dlg = new CustomDialogs(400, 200);
            var currentUser = InitialHelper.CurrentUser;
            var currentDateTime = InitialHelper.CurrentDateTime;
            var incomeTypeTitle = txt_IncomeTypeTitle.Text;
            switch (_mode)
            {
                case CommonHelper.Mode.Insert:

                    if (!InitialHelper.HasPermissionFor(this.Name, PermissionMode.Add))
                    {
                        CommonHelper.ShowNotificationMessage(DefaultConstants.IllegalAccess,
                            DefaultConstants.CreateActionNotAllow);
                        return;
                    }

                    var newIncomeType = new IncomeType(incomeTypeTitle, currentUser.Id,
                        currentDateTime, null);

                    if (await _incomeTypeService.ExistAsync(newIncomeType))
                    {
                        dlg.Invoke("خطای تکرار", "این عنوان درآمد تکراری می باشد",
                            CustomDialogs.ImageType.itError3,
                            CustomDialogs.ButtonType.Ok, InitialHelper.BackColorCustom);
                        txt_IncomeTypeTitle.Focus();
                        txt_IncomeTypeTitle.SelectAll();
                        return;
                    }
                    try
                    {
                        await _incomeTypeService.CreateAsync(newIncomeType);
                        txt_IncomeTypeTitle.Focus();
                        rgv_IncomeType.Enabled = true;
                        CommonHelper.EnableControls(pnl_Data, false);
                        btnCancel.Enabled = false;
                        btnInsert.Enabled = true;
                        btnDelete.Enabled = true;
                        BindGrid();

                        CommonHelper.ShowNotificationMessage("ایجاد نوع درآمد جدید",
                            $"نوع درآمد جدید با نام {incomeTypeTitle} ایجاد گردید.");

                        await LoggerService.InformationAsync(this.Name, "btnRegister_Click(Insert Mode)",
                            $" نوع درآمد جدید با نام {incomeTypeTitle} ",
                            $" توسط کاربر {currentUser.UserName} ایجاد گردید.");

                        //CommonHelper.ClearInputControls(this, false, false);
                    }
                    catch (Exception exception)
                    {
                        dlg.Invoke("خطا در ثبت اطلاعات",
                            "خطای زیر به وقوع پیوست \n" + exception.ToDetailedString(),
                            CustomDialogs.ImageType.itError2, CustomDialogs.ButtonType.Ok,
                            InitialHelper.BackColorCustom);

                        await LoggerService.ErrorAsync(this.Name, "btnRegister_Click(Insert mode)", exception.Message,
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

                        var currentIncomeType = await _incomeTypeService.GetByIdAsync(_incomeTypeId);

                        currentIncomeType.Title = incomeTypeTitle;
                        currentIncomeType.UpdateBy = currentUser.Id;
                        currentIncomeType.LastUpdate = currentDateTime;

                        await _incomeTypeService.UpdateAsync(currentIncomeType);

                        CommonHelper.ShowNotificationMessage("ویرایش نوع درآمد",
                            $" نوع درآمد با نام {incomeTypeTitle} ویرایش گردید.");

                        await LoggerService.InformationAsync(this.Name, "btnRegister_Click(Update Mode)",
                            $" نوع درآمد با نام {incomeTypeTitle} ",
                            $"توسط کاربر  {currentUser.UserName} ویرایش گردید.");

                        //CommonHelper.ClearInputControls(pnl_Data);
                        rgv_IncomeType.Enabled = true;
                        CommonHelper.EnableControls(pnl_Data, false);
                        btnCancel.Enabled = false;
                        btnInsert.Enabled = true;
                        btnDelete.Enabled = true;
                        BindGrid();
                    }
                    catch (Exception exception)
                    {
                        dlg.Invoke("خطا در ثبت اطلاعات",
                            "خطای زیر به وقوع پیوست \n" + exception.Message,
                            CustomDialogs.ImageType.itError2, CustomDialogs.ButtonType.Ok,
                            InitialHelper.BackColorCustom);

                        await LoggerService.ErrorAsync(this.Name, "btnRegister_Click(Update mode)", exception.Message,
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
            rgv_IncomeType.Enabled = true;
            btnRegister.Enabled = false;
            btnClose.Enabled = true;
            _mode = CommonHelper.Mode.None;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void txt_IncomeTypeTitle_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    //if (e.KeyChar == (char)Keys.Enter && btnRegister.Enabled)
        //    //{
        //    //    btnRegister_Click(sender, e);
        //    //}
        //}

        private void Txt_IncomeTypeTitle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && btnRegister.Enabled)
            {
                btnRegister_Click(sender, e);
                e.SuppressKeyPress = true;
            }
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
            dialog.Invoke("هشدار حذف", "آيا واقعا میخواهید این نوع درآمد را حذف کنید؟",
                CustomDialogs.ImageType.itQuestion2,
                CustomDialogs.ButtonType.YesNo, InitialHelper.BackColorCustom);

            if (!dialog.Yes) return;

            if (await _incomeTypeService.IsUsedAsync(_incomeTypeId))
            {
                CommonHelper.ShowNotificationMessage("خطا",
                    "نوع درآمد در حال استفاده بوده و حذف نمیشود ");

                return;
            }

            await _incomeTypeService.RemoveAsync(_incomeTypeId);

            CommonHelper.ShowNotificationMessage("پیام", $"نوع درآمد با شناسه {_incomeTypeId} حذف گردید");

            await LoggerService.InformationAsync(this.Name, "BtnDelete_Click", $"حذف نوع درآمد با شماره {_incomeTypeId}",
                $"این نوع درآمد توسط کاربری با نام {InitialHelper.CurrentUser.UserName} حذف گردید.");

            _mode = CommonHelper.Mode.None;
            rgv_IncomeType.Enabled = true;
            CommonHelper.EnableControls(pnl_Data, false);
            btnCancel.Enabled = false;
            btnInsert.Enabled = true;
            btnDelete.Enabled = true;
            BindGrid();
        }
    }
}