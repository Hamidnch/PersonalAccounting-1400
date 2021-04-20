using MessageBoxHamidNCH;
using PersonalAccounting.BLL.Enum;
using PersonalAccounting.BLL.IService;
using PersonalAccounting.CommonLibrary.Helper;
using PersonalAccounting.Domain.Entity;
using PersonalAccounting.Domain.ViewModel;
using PersonalAccounting.UI.Helper;
using PersonalAccounting.UI.Infrastructure;
using System;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace PersonalAccounting.UI
{

    public partial class FrmTransferMoney : BaseForm
    {
        private readonly IFundService _fundService;
        private readonly ITransferMoneyService _transferMoneyService;

        private int _transferMoneyId;
        private bool _done;

        public static FrmTransferMoney AFrmTransferMoney = null;
        public static FrmTransferMoney Instance()
        {
            return AFrmTransferMoney ?? (AFrmTransferMoney = IocConfig.Container.GetInstance<FrmTransferMoney>());
        }
        public FrmTransferMoney(ITransferMoneyService transferMoneyService, IFundService fundService)
        {
            _transferMoneyService = transferMoneyService;
            _fundService = fundService;
            InitializeComponent();
        }
        private void FrmTransferMoney_Load(object sender, EventArgs e)
        {
            BindGrid();
            BindFundNames(rddl_OriginFund);
            BindFundNames(rddl_DestFund);
            //ReturnTransferMoniesDetails();
        }

        private async void BindGrid()
        {
            int? currentUserId = null;
            if (!await InitialHelper.CurrentUser.IsAdmin())
                currentUserId = InitialHelper.CurrentUser.Id;

            rgv_TransferMoney.BeginUpdate();
            rgv_TransferMoney.DataSource = await _transferMoneyService.LoadAllViewModelAsync(currentUserId);
            rgv_TransferMoney.EndUpdate();
        }

        private async void BindFundNames(RadDropDownList ddlFund)
        {
            var defaultOption = new ViewModelSimpleLoadFund()
            {
                FundId = 0,
                FundTitle = "انتخاب کنید ..."
            };

            var bankAccounts = await _fundService.SimpleLoadViewModelAsync();
            CommonHelper.Fill(ddlFund, "FundTitle", "FundId", bankAccounts, defaultOption);
        }

        //private async void BindFundNames(UIComboBox ddlFund)
        //{
        //    ddlFund.DisplayMember = "FundTitle";
        //    ddlFund.ValueMember = "FundId";
        //    ddlFund.DataSource = await _fundService.SimpleLoadViewModelAsync();
        //    //ddlFund.Items.Insert(0, new UIComboBoxItem("انتخاب کنید ...", "-1"));
        //    //ddlFund.SelectedIndex = 0;
        //}

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!InitialHelper.HasPermissionFor(this.Name, PermissionMode.Add))
            {
                CommonHelper.ShowNotificationMessage(DefaultConstants.IllegalAccess, DefaultConstants.CreateActionNotAllow);
                return;
            }

            _mode = CommonHelper.Mode.Insert;

            CommonHelper.InsertAction(_mode, pnl_Data, rgv_TransferMoney, btnInsert, btnRegister, btnModify,
                btnDelete, btnCancel, btnClose, rddl_OriginFund);

            txt_TransferMoneyDate.SetPersianDateToTextBoxAndSelectAll();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _mode = CommonHelper.Mode.Cancel;
            CommonHelper.CancelAction(_mode, pnl_Data, rgv_TransferMoney, btnInsert, btnRegister, btnModify,
                btnDelete, btnCancel, btnClose);

            ReturnTransferMoniesDetails();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (!InitialHelper.HasPermissionFor(this.Name, PermissionMode.Edit))
            {
                CommonHelper.ShowNotificationMessage(DefaultConstants.IllegalAccess, DefaultConstants.EditActionNotAllow);
                return;
            }

            _mode = CommonHelper.Mode.Update;
            CommonHelper.ModifyAction(_mode, pnl_Data, rgv_TransferMoney, btnInsert, btnRegister,
                btnModify, btnDelete, btnCancel, btnClose);
            _mode = CommonHelper.Mode.Update;
        }

        private async Task<string> GetFundRemain(int fundId)
        {
            try
            {
                var originFundRemain = await _fundService.GetFundValueAsync(fundId);
                return originFundRemain.ToString(CultureInfo.InvariantCulture).AddSeparateEx();
            }
            catch (Exception exception)
            {
                await LoggerService.ErrorAsync(this.Name, "GetFundRemain", exception.Message,
                    exception.ToDetailedString());
                return null;
            }
        }

        private async void ReturnTransferMoniesDetails()
        {
            try
            {
                if (!(rgv_TransferMoney.CurrentRow is GridViewDataRowInfo dataRow)) return;

                _transferMoneyId = int.Parse(dataRow.Cells["TransferMoneyId"].Value.ToString());
                var transferMoneyPersianDate = dataRow.Cells["TransferMoneyPersianDate"].Value.ToString();
                txt_TransferMoneyDate.Text = transferMoneyPersianDate;
                txt_TransferValue.Text = dataRow.Cells["AmountSeparateDigit"].Value?.ToString();
                txt_BankCommission.Text = dataRow.Cells["BankCommissionSeparateDigit"].Value?.ToString();
                //ddl_FundStatus.Text = dataRow.Cells["TransferMoneyStatus"].Value.ToString();
                txt_TransferDescription.Text = dataRow.Cells["TransferMoneyDescription"].Value?.ToString();

                rddl_OriginFund.SelectedValue = dataRow.Cells["OriginFundId"].Value;
                rddl_DestFund.SelectedValue = dataRow.Cells["DestinationFundId"].Value;

                var originFundId = int.Parse(dataRow.Cells["OriginFundId"].Value.ToString());
                txt_OriginFundRemain.Text = await GetFundRemain(originFundId);

                var destFundId = int.Parse(dataRow.Cells["DestinationFundId"].Value.ToString());
                txt_DestFundRemain.Text = await GetFundRemain(destFundId);
            }
            catch (Exception exception)
            {
                await LoggerService.ErrorAsync(this.Name, "ReturnTransferMoniesDetails", exception.Message,
                    exception.ToDetailedString());
            }
        }

        private bool ValidateAllControls()
        {
            return CommonHelper.ValidateControls(rddl_OriginFund, _errorProvider,
                       "صندوق مبدا را مشخص نمایید") ||
                   CommonHelper.ValidateControls(rddl_DestFund, _errorProvider,
                       "صندوق مقصد را مشخص نمایید"
                       );
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            if (ValidateAllControls()) return;

            var currentUser = InitialHelper.CurrentUser;
            var currentDateTime = InitialHelper.CurrentDateTime;
            var firstFundId = int.Parse(rddl_OriginFund.SelectedItem.Value.ToString());
            var secondFundId = int.Parse(rddl_DestFund.SelectedItem.Value.ToString());
            var amount = double.Parse(txt_TransferValue.Text);
            var bankCommission = double.Parse(txt_BankCommission.Text);
            var transferDate = PersianHelper.GetGregorianDate(txt_TransferMoneyDate.Text);
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

                        var transferStatus = await _transferMoneyService.TransferAmountAsync(
                            firstFundId, secondFundId, amount,
                            bankCommission, TransferType.Commit);

                        switch (transferStatus)
                        {
                            case TransferStatus.Failure:
                                break;
                            case TransferStatus.Success:
                                var newTransferMoney = new TransferMoney(
                                    transferDate,
                                    amount,
                                    firstFundId,
                                    secondFundId,
                                    bankCommission,
                                    currentDateTime,
                                    currentDateTime,
                                    currentUser.Id,
                                    txt_TransferDescription.Text);

                                var status = await _transferMoneyService.CreateAsync(newTransferMoney);

                                switch (status)
                                {
                                    case CreateStatus.Exist:
                                        return;
                                    case CreateStatus.Failure:
                                        var dlg = new CustomDialogs(400, 200);
                                        dlg.Invoke("بروز خطا", PublicError.Error,
                                            CustomDialogs.ImageType.itError5,
                                            CustomDialogs.ButtonType.Ok);
                                        return;
                                    case CreateStatus.Successful:
                                        BindGrid();
                                        var msg = $"انتقال مبلغ {amount} ریال بین صندوق مبدا با شناسه {firstFundId}" +
                                                  $" و صندوق مقصد با شناسه" +
                                                  $" {secondFundId} " +
                                                  $"توسط کاربری با نام {currentUser.UserName} " +
                                                  " با موفقیت انجام پذیرفت";

                                        CommonHelper.ShowNotificationMessage("انتقال مبلغ بین دو صندوق", msg);

                                        await LoggerService.InformationAsync(this.Name, "btnRegister_Click(Insert Mode)", msg);

                                        //CommonHelper.ClearInputControls(this, false, false);
                                        rddl_OriginFund.Focus();
                                        rgv_TransferMoney.Enabled = true;
                                        CommonHelper.EnableControls(pnl_Data, false);
                                        btnCancel.Enabled = false;
                                        btnInsert.Enabled = true;
                                        btnDelete.Enabled = true;
                                        break;
                                    default:
                                        throw new ArgumentOutOfRangeException();
                                }
                                break;
                            case TransferStatus.OriginFundIsNull:
                                CommonHelper.ShowNotificationMessage("خطا", "حساب مبدا را مشخص کنید");
                                await LoggerService.WarningAsync(this.Name, "خطا", "حساب مبدا را مشخص کنید");
                                //break;
                                return;

                            case TransferStatus.DestinationFundIsNull:
                                CommonHelper.ShowNotificationMessage("خطا", "حساب مقصد را مشخص کنید");
                                await LoggerService.WarningAsync(this.Name, "خطا", "حساب مقصد را مشخص کنید");
                                //break;
                                return;
                            case TransferStatus.OriginalAndDestinationIsTheSame:
                                CommonHelper.ShowNotificationMessage("خطا",
                                    "حساب مبدا و حساب مقصد نباید یکسان باشند");
                                await LoggerService.WarningAsync(this.Name, "خطا", "حساب مبدا و حساب مقصد نباید یکسان باشند");
                                //break;
                                return;
                            case TransferStatus.AmountValueIsZeroOrLessThanZero:
                                CommonHelper.ShowNotificationMessage("خطا", "مبلغ قابل انتقال باید بزرگتر از صفر باشد");
                                await LoggerService.WarningAsync(this.Name, "خطا", "مبلغ قابل انتقال باید بزرگتر از صفر باشد");
                                //break;
                                return;
                            case TransferStatus.CommissionIsZeroOrLessThanZero:
                                CommonHelper.ShowNotificationMessage("خطا", "کارمزد باکی باید بزرگتر یا مساوی صفر باشد");
                                await LoggerService.WarningAsync(this.Name, "خطا", "کارمزد باکی باید بزرگتر یا مساوی صفر باشد");
                                //break;
                                return;
                            case TransferStatus.OriginFundValueIsLessThanAmountPlusCommission:
                                CommonHelper.ShowNotificationMessage("خطا", "موجودی حساب مبدا کافی نیست");
                                await LoggerService.WarningAsync(this.Name, "خطا", "موجودی حساب مبدا کافی نیست");
                                //break;
                                return;
                            default:
                                throw new ArgumentOutOfRangeException();
                        }
                    }

                    catch (Exception exception)
                    {
                        var dlg = new CustomDialogs(400, 200);
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

                        var currentTransferMoney = await _transferMoneyService.GetByIdAsync(_transferMoneyId);

                        currentTransferMoney.TransferDate = transferDate;
                        currentTransferMoney.OriginFundId = firstFundId;
                        currentTransferMoney.DestinationFundId = secondFundId;
                        currentTransferMoney.Amount = amount;
                        currentTransferMoney.BankCommission = bankCommission;
                        currentTransferMoney.UpdateBy = currentUser.Id;
                        currentTransferMoney.LastUpdate = currentDateTime;
                        currentTransferMoney.Description = txt_TransferDescription.Text;

                        await _transferMoneyService.UpdateAsync(currentTransferMoney);

                        var msg = $"انتقال مبلغ {amount} ریال بین صندوق مبدا با شناسه {firstFundId}" +
                                  $" و صندوق مقصد با شناسه" +
                                  $" {secondFundId} " +
                                  $"توسط کاربری با نام {currentUser.UserName} " +
                                  " با موفقیت انجام پذیرفت";

                        CommonHelper.ShowNotificationMessage("انتقال مبلغ بین دو صندوق", msg);

                        await LoggerService.InformationAsync(this.Name, "btnRegister_Click(Update Mode)", msg);

                        //CommonHelper.ClearInputControls(pnl_Data);

                        rgv_TransferMoney.Enabled = true;
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

            rgv_TransferMoney.Enabled = true;
            btnRegister.Enabled = false;
            btnClose.Enabled = true;
            _mode = CommonHelper.Mode.None;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_TransferValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_done) e.Handled = true;
        }
        private void txt_TransferValue_KeyDown(object sender, KeyEventArgs e)
        {
            _done = false;
            if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) return;
            if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9) return;
            if (e.KeyCode == Keys.Back) return;
            if (e.KeyCode != Keys.Decimal)
                _done = true;
            e.SuppressKeyPress = true;
        }

        private void txt_TransferValue_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_TransferValue.Text != string.Empty)
            {
                var fi = txt_TransferValue.Text.ClearSeparateEx();
                var temp = fi.ToString(CultureInfo.InvariantCulture).AddSeparateEx();
                txt_TransferValue.Text = temp;
            }
            txt_TransferValue.SelectionStart = txt_TransferValue.Text.Length;
        }

        private void txt_BankCommission_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_BankCommission.Text != string.Empty)
            {
                var fi = txt_BankCommission.Text.ClearSeparateEx();
                var temp = fi.ToString(CultureInfo.InvariantCulture).AddSeparateEx();
                txt_BankCommission.Text = temp;
            }
            txt_BankCommission.SelectionStart = txt_BankCommission.Text.Length;
        }


        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (!InitialHelper.HasPermissionFor(this.Name, PermissionMode.Delete))
            {
                CommonHelper.ShowNotificationMessage(DefaultConstants.IllegalAccess, DefaultConstants.DeleteActionNotAllow);
                return;
            }

            var dialog = new CustomDialogs(350, 200);

            dialog.Invoke("هشدار حذف", "آيا واقعا میخواهید این انتقال را حذف کنید؟",
                CustomDialogs.ImageType.itQuestion2,
                CustomDialogs.ButtonType.YesNo, InitialHelper.BackColorCustom);

            if (!dialog.Yes) return;

            try
            {
                var currentTransferMoney = await _transferMoneyService.GetByIdAsync(_transferMoneyId);
                var originId = currentTransferMoney.OriginFundId;
                var destId = currentTransferMoney.DestinationFundId;
                var amount = currentTransferMoney.Amount;
                var commission = currentTransferMoney.BankCommission;

                var transferStatus = await _transferMoneyService.TransferAmountAsync(
                    originId, destId, amount, commission, TransferType.RollBack);

                if (transferStatus == TransferStatus.Success)
                {
                    await _transferMoneyService.RemoveAsync(_transferMoneyId);

                    //dlg.Invoke("حذف", "اطلاعات این انتقال حذف گردید.",
                    //    CustomDialogs.ImageType.itInfo2,
                    //    CustomDialogs.ButtonType.Ok, InitialHelper.BackColorCustom);

                    CommonHelper.ShowNotificationMessage("پیام",
                        $"اطلاعات این انتقال حساب با شناسه {_transferMoneyId} حذف گردید");

                    await LoggerService.InformationAsync(this.Name, "btnDelete_Click", "حذف انتقال حساب",
                        $"اطلاعات این انتقال حساب با شناسه {_transferMoneyId} " +
                        "توسط کاربری با نام " +
                        $" {InitialHelper.CurrentUser.UserName} حذف گردید.");

                    _mode = CommonHelper.Mode.None;
                    rgv_TransferMoney.Enabled = true;
                    CommonHelper.EnableControls(pnl_Data, false);

                    btnCancel.Enabled = false;
                    btnInsert.Enabled = true;
                    btnDelete.Enabled = true;

                    BindGrid();
                }
            }
            catch (Exception exception)
            {
                //var dlg = new CustomDialogs(400, 200);
                //dlg.Invoke("خطا", exception.Message,
                //    CustomDialogs.ImageType.itError3,
                //    CustomDialogs.ButtonType.Ok, InitialHelper.BackColorCustom);

                CommonHelper.ShowNotificationMessage("خطا در حذف اطلاعات انتقال حساب", exception.Message);

                await LoggerService.ErrorAsync(this.Name, "btnDelete_Click", exception.Message,
                    exception.ToDetailedString());
            }
        }

        private void rgv_TransferMoney_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
        {
            ReturnTransferMoniesDetails();
        }

        private void rgv_TransferMoney_CellClick(object sender, GridViewCellEventArgs e)
        {
            if (rgv_TransferMoney.Enabled && rgv_TransferMoney.RowCount > 0)
            { btnModify.Enabled = true; }
            else { btnModify.Enabled = false; }
        }

        private void rddl_OriginAccount_TextChanged(object sender, EventArgs e)
        {
            //if (_mode == CommonHelper.Mode.Insert)
            //{
            btnRegister.Enabled = (
                rddl_OriginFund.SelectedIndex != 0 &&
                rddl_DestFund.SelectedIndex != 0 &&
                txt_TransferValue.Text != string.Empty &&
                txt_TransferValue.Text != "0" &&
                txt_BankCommission.Text != string.Empty);
            //}
        }

        private async void rddl_OriginAccount_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            try
            {
                //MessageBox.Show(ddl_FirstAccount.SelectedItem.Value.ToString());
                var fundId = int.TryParse(rddl_OriginFund.SelectedItem.Value.ToString(), out var id);
                txt_OriginFundRemain.Text = await GetFundRemain(id);
            }

            catch (Exception exception)
            {
                await LoggerService.ErrorAsync(this.Name, "rddl_OriginAccount_SelectedIndexChanged", exception.Message,
                    exception.ToDetailedString());
            }
        }

        private async void rddl_DestAccount_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            try
            {
                var fundId = int.TryParse(rddl_DestFund.SelectedItem.Value.ToString(), out var id);
                txt_DestFundRemain.Text = await GetFundRemain(id);
            }
            catch
            {

            }
        }

        private void rgv_TransferMoney_Click(object sender, EventArgs e)
        {
            ReturnTransferMoniesDetails();
        }
    }
}
