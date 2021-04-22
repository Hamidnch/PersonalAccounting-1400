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
    public partial class FrmBank : BaseForm
    {
        private readonly IRepositoryService<Bank, ViewModelLoadAllBank, Bank> _bankService;

        private int _bankId;
        public static FrmBank AFrmBank = null;
        public static FrmBank Instance()
        {
            return AFrmBank ?? (AFrmBank = IocConfig.Container.GetInstance<FrmBank>());
        }

        public FrmBank(IRepositoryService<Bank, ViewModelLoadAllBank, Bank> bankService)
        {
            this._bankService = bankService;
            InitializeComponent();

            //CommonHelper.SetFont(CommonHelper.BaseFont, pnl_Data, rgv_Bank);
            BindGrid();
            rddl_BankStatus.SetEnableDisableStatusDropdownList();
        }

        private async void BindGrid()
        {
            //int? currentUserId = null;
            //if (!await InitialHelper.CurrentUser.IsAdmin())
            //int? currentUserId = InitialHelper.CurrentUser.Id;

            rgv_Bank.BeginUpdate();
            rgv_Bank.DataSource = await _bankService.LoadAllViewModelAsync();
            rgv_Bank.EndUpdate();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!InitialHelper.HasPermissionFor(this.Name, PermissionMode.Add))
            {
                CommonHelper.ShowNotificationMessage(DefaultConstants.IllegalAccess, DefaultConstants.CreateActionNotAllow);
                return;
            }

            _mode = CommonHelper.Mode.Insert;
            CommonHelper.InsertAction(_mode, pnl_Data, rgv_Bank, btnInsert, btnRegister, btnModify,
                btnDelete, btnCancel, btnClose, txt_BankName);

            rddl_BankStatus.SelectedValue = 0;
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            if (ValidateAllControls()) return;

            var bankStatus = rddl_BankStatus.SelectedItem.Text;
            var currentUser = InitialHelper.CurrentUser;
            var currentDateTime = InitialHelper.CurrentDateTime;
            var bankName = txt_BankName.Text;

            switch (_mode)
            {
                case CommonHelper.Mode.Insert:
                    if (!InitialHelper.HasPermissionFor(this.Name, PermissionMode.Add))
                    {
                        CommonHelper.ShowNotificationMessage(DefaultConstants.IllegalAccess, DefaultConstants.EditActionNotAllow);
                        return;
                    }

                    var newBank = new Bank(bankName, txt_BankDepartment.Text,
                        currentUser.Id, currentDateTime, currentDateTime,
                        bankStatus, txt_BankDescription.Text);

                    if (await _bankService.ExistAsync(newBank))
                    {
                        var dlg = new CustomDialogs(400, 200);
                        dlg.Invoke("خطای تکرار", "این نام بانک تکراری می باشد",
                            CustomDialogs.ImageType.itError3,
                            CustomDialogs.ButtonType.Ok, InitialHelper.BackColorCustom);
                        txt_BankName.Focus();
                        txt_BankName.SelectAll();
                        return;
                    }
                    try
                    {
                        await _bankService.CreateAsync(newBank);
                        CommonHelper.ShowNotificationMessage("ایجاد بانک جدید",
                            $"بانک جدید با نام {bankName} ایجاد گردید.");

                        await LoggerService.InformationAsync(this.Name, "btnRegister_Click(Insert Mode)", 
                            $"ایجاد بانک جدید با نام {bankName} ",
                            $"و توسط کاربر  {currentUser.UserName} ایجاد گردید.");
                        BindGrid();

                        //CommonHelper.ClearInputControls(this, false, false);
                        txt_BankName.Focus();
                        rgv_Bank.Enabled = true;
                        CommonHelper.EnableControls(pnl_Data, false);
                        btnCancel.Enabled = false;
                        btnInsert.Enabled = true;
                        btnDelete.Enabled = true;
                    }
                    catch (Exception exception)
                    {
                        var dlg = new CustomDialogs(400, 200);
                        dlg.Invoke("خطا در ثبت اطلاعات",
                            "خطای زیر به وقوع پیوست \n" + exception.Message,
                            CustomDialogs.ImageType.itError2, CustomDialogs.ButtonType.Ok,
                            InitialHelper.BackColorCustom);

                        await LoggerService.ErrorAsync(this.Name, "btnRegister_Click(Insert mode)", exception.Message,
                            exception.ToDetailedString());
                        return;
                    }
                    break;

                case CommonHelper.Mode.Update:
                    if (!InitialHelper.HasPermissionFor(this.Name, PermissionMode.Edit))
                    {
                        CommonHelper.ShowNotificationMessage(DefaultConstants.IllegalAccess, DefaultConstants.EditActionNotAllow);
                        return;
                    }
                    try
                    {
                        var currentBank = await _bankService.GetByIdAsync(_bankId);

                        currentBank.Name = bankName;
                        currentBank.Department = txt_BankDepartment.Text;
                        currentBank.UpdateBy = currentUser.Id;
                        currentBank.LastUpdate = currentDateTime;
                        currentBank.Status = bankStatus;
                        currentBank.Description = txt_BankDescription.Text;

                        await _bankService.UpdateAsync(currentBank);

                        CommonHelper.ShowNotificationMessage("ویرایش بانک",
                            $"بانک با نام {bankName} ویرایش گردید.");

                        await LoggerService.InformationAsync(this.Name, "btnRegister_Click(Update Mode)", 
                            $"ویرایش بانک با نام {bankName} ",
                            $"و توسط کاربر  {currentUser.UserName} انجام گردید.");

                        //CommonHelper.ClearInputControls(pnl_Data);
                        rgv_Bank.Enabled = true;
                        CommonHelper.EnableControls(pnl_Data, false);
                        btnCancel.Enabled = false;
                        btnInsert.Enabled = true;
                        btnDelete.Enabled = true;
                        BindGrid();
                    }
                    catch (Exception exception)
                    {
                        var dlg = new CustomDialogs(400, 200);
                        dlg.Invoke("خطا در ثبت اطلاعات",
                            "خطای زیر به وقوع پیوست \n" + exception.Message,
                            CustomDialogs.ImageType.itError2, CustomDialogs.ButtonType.Ok,
                            InitialHelper.BackColorCustom);

                        await LoggerService.ErrorAsync(this.Name, "btnRegister_Click(Update mode)",
                            exception.Message, exception.ToDetailedString());

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
            rgv_Bank.Enabled = true;
            btnRegister.Enabled = false;
            btnClose.Enabled = true;
            _mode = CommonHelper.Mode.None;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (!InitialHelper.HasPermissionFor(this.Name, PermissionMode.Edit))
            {
                CommonHelper.ShowNotificationMessage(DefaultConstants.IllegalAccess, DefaultConstants.EditActionNotAllow);
                return;
            }

            _mode = CommonHelper.Mode.Update;
            CommonHelper.ModifyAction(_mode, pnl_Data, rgv_Bank, btnInsert, btnRegister,
                btnModify, btnDelete, btnCancel, btnClose);
            _mode = CommonHelper.Mode.Update;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _mode = CommonHelper.Mode.Cancel;
            CommonHelper.CancelAction(_mode, pnl_Data, rgv_Bank, btnInsert, btnRegister, btnModify,
                btnDelete, btnCancel, btnClose);

            ReturnBankDetails();
        }

        private async void ReturnBankDetails()
        {
            try
            {
                if (!(rgv_Bank.CurrentRow is GridViewDataRowInfo dataRow)) return;

                _bankId = int.Parse(dataRow.Cells["BankId"].Value.ToString());
                txt_BankName.Text = dataRow.Cells["BankName"].Value.ToString();
                txt_BankDepartment.Text = dataRow.Cells["BankDepartment"].Value.ToString();
                rddl_BankStatus.Text = dataRow.Cells["BankStatus"].Value.ToString();
                txt_BankDescription.Text = dataRow.Cells["BankDescription"].Value.ToString();
            }
            catch (Exception exception)
            {
                await LoggerService.ErrorAsync(this.Name, "ReturnBankDetails",
                    exception.Message, exception.ToDetailedString());
            }
        }
        private bool ValidateAllControls()
        {
            return CommonHelper.ValidateControls(txt_BankName, _errorProvider,
                       "نام بانک  را وارد نمایید") ||
                   CommonHelper.ValidateControls(txt_BankDepartment,
                       _errorProvider, "شعبه بانک را مشخص نمایید");
        }

        private void txt_BankName_TextChanged(object sender, EventArgs e)
        {
            if (_mode == CommonHelper.Mode.Insert)
            {
                btnRegister.Enabled = (txt_BankName.Text != string.Empty
                                       && txt_BankDepartment.Text != string.Empty);
            }
        }

        private void rgv_Bank_CellClick(object sender, GridViewCellEventArgs e)
        {
            if (rgv_Bank.Enabled && rgv_Bank.RowCount > 0)
            { btnModify.Enabled = true; }
            else { btnModify.Enabled = false; }
        }

        private void rgv_Bank_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
        {
            ReturnBankDetails();
        }

        private void Txt_BankName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnRegister_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (rgv_Bank.Rows.Count <= 0) return;

            if (!InitialHelper.HasPermissionFor(this.Name, PermissionMode.Delete))
            {
                CommonHelper.ShowNotificationMessage(DefaultConstants.IllegalAccess, DefaultConstants.DeleteActionNotAllow);
                return;
            }

            var dialog = new CustomDialogs(350, 200);
            dialog.Invoke("هشدار حذف", "آيا واقعا میخواهید این بانک را حذف کنید؟",
                CustomDialogs.ImageType.itQuestion2,
                CustomDialogs.ButtonType.YesNo, InitialHelper.BackColorCustom);

            if (!dialog.Yes) return;

            if (await _bankService.IsUsedAsync(_bankId))
            {
                CommonHelper.ShowNotificationMessage("خطا",
                    "این بانک در حال استفاده بوده و حذف نمیشود ");

                return;
            }

            await _bankService.RemoveAsync(_bankId);

            CommonHelper.ShowNotificationMessage("پیام", $"بانک با شناسه {_bankId} حذف گردید");

            await LoggerService.InformationAsync(this.Name, "BtnDelete_Click", $"حذف بانک شماره {_bankId}",
                $"این بانک توسط کاربری با نام {InitialHelper.CurrentUser.UserName} حذف گردید.");

            _mode = CommonHelper.Mode.None;
            rgv_Bank.Enabled = true;
            CommonHelper.EnableControls(pnl_Data, false);

            btnCancel.Enabled = false;
            btnInsert.Enabled = true;
            btnDelete.Enabled = true;

            BindGrid();
        }
    }
}
