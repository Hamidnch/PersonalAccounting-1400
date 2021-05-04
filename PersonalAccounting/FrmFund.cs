using MessageBoxHamidNCH;
using PersonalAccounting.BLL.Enum;
using PersonalAccounting.BLL.IService;
using PersonalAccounting.CommonLibrary.Helper;
using PersonalAccounting.Domain.Entity;
using PersonalAccounting.Domain.ViewModel;
using PersonalAccounting.UI.Helper;
using PersonalAccounting.UI.Infrastructure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace PersonalAccounting.UI
{
    public partial class FrmFund : BaseForm
    {
        private readonly IFundService _fundService;
        private readonly IRepositoryService<BankAccount, ViewModelLoadAllBankAccount,
            ViewModelSimpleLoadBankAccount> _bankAccountService;

        private readonly HashSet<GridViewRowInfo> _rows = new HashSet<GridViewRowInfo>();

        private int _fundId;
        private bool _done;

        public static FrmFund AFrmFund = null;
        public static FrmFund Instance()
        {
            return AFrmFund ?? (AFrmFund = IocConfig.Container.GetInstance<FrmFund>());
        }
        public FrmFund(IFundService fundService, IRepositoryService<BankAccount,
            ViewModelLoadAllBankAccount, ViewModelSimpleLoadBankAccount> bankAccountService)
        {
            _done = false;
            _fundService = fundService;
            _bankAccountService = bankAccountService;

            InitializeComponent();

            //CommonHelper.SetFont(CommonHelper.BaseFont, pnl_Data, rgv_Fund);

            rgv_Fund.MasterTemplate.ShowTotals = true;
            rgv_Fund.EnableAlternatingRowColor = true;

            var summaryFiItem = new GridViewSummaryItem("FundCurrentValue", "{0:n0}" + DefaultConstants.MoneyUnit,
                GridAggregateFunction.Sum);

            var summaryRowItem = new GridViewSummaryRowItem { summaryFiItem };
            rgv_Fund.SummaryRowsBottom.Add(summaryRowItem);
            rgv_Fund.MasterView.SummaryRows[0].PinPosition = PinnedRowPosition.Bottom;
            rgv_Fund.MasterTemplate.BottomPinnedRowsMode = GridViewBottomPinnedRowsMode.Float;

            rddl_FundStatus.SetEnableDisableStatusDropdownList();
            BindGrid();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!InitialHelper.HasPermissionFor(this.Name, PermissionMode.Add))
            {
                CommonHelper.ShowNotificationMessage(DefaultConstants.IllegalAccess, DefaultConstants.CreateActionNotAllow);
                return;
            }

            _mode = CommonHelper.Mode.Insert;
            CommonHelper.InsertAction(_mode, pnl_Data, rgv_Fund, btnInsert, btnRegister, btnModify,
                btnDelete, btnCancel, btnClose, rddl_BankAccountSubject);

            rddl_FundType.SelectedIndex = 0;
            rddl_FundStatus.SelectedValue = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _mode = CommonHelper.Mode.Cancel;
            CommonHelper.CancelAction(_mode, pnl_Data, rgv_Fund, btnInsert, btnRegister, btnModify,
                btnDelete, btnCancel, btnClose);

            ReturnFundDetails();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (!InitialHelper.HasPermissionFor(this.Name, PermissionMode.Edit))
            {
                CommonHelper.ShowNotificationMessage(DefaultConstants.IllegalAccess, DefaultConstants.CreateActionNotAllow);
                return;
            }
            _mode = CommonHelper.Mode.Update;
            CommonHelper.ModifyAction(_mode, pnl_Data, rgv_Fund, btnInsert, btnRegister,
                btnModify, btnDelete, btnCancel, btnClose);
            _mode = CommonHelper.Mode.Update;

            rddl_BankAccountSubject_SelectedIndexChanged(sender, null);
        }

        private async void BindGrid()
        {
            int? currentUserId = null;
            if (!await InitialHelper.CurrentUser.IsAdmin())
                currentUserId = InitialHelper.CurrentUser.Id;

            rgv_Fund.BeginUpdate();
            rgv_Fund.DataSource = await _fundService.LoadAllViewModelAsync(currentUserId);
            rgv_Fund.EndUpdate();

            //GridViewSummaryItem summaryItem = new GridViewSummaryItem();
            //summaryItem.Name = "Freight";
            //summaryItem.AggregateExpression = "(Sum(FundCurrentValueSeparateDigit) - Max(Freight) - Min(Freight)) / Count(Freight)";
            //GridViewSummaryRowItem summaryRowItem = new GridViewSummaryRowItem();
            //summaryRowItem.Add(summaryItem);
            //this.rgv_Fund.SummaryRowsTop.Add(summaryRowItem);
        }

        private async void ReturnFundDetails()
        {
            try
            {
                if (!(rgv_Fund.CurrentRow is GridViewDataRowInfo dataRow)) return;

                _fundId = int.Parse(dataRow.Cells["FundId"].Value.ToString());

                //rddl_FundType.SelectedValue = dataRow.Cells["FundTypeName"].Value?.ToString();
                txt_FundCurrentValue.Text = dataRow.Cells["FundCurrentValue"].Value?.ToString().AddSeparateEx();
                rddl_FundStatus.Text = dataRow.Cells["FundStatus"].Value?.ToString();
                txt_FundDescription.Text = dataRow.Cells["FundDescription"].Value?.ToString();

                var fundTypeId = int.Parse(dataRow.Cells["FundTypeId"].Value.ToString()) - 1;
                rddl_FundType.SelectedIndex = fundTypeId;
                rddl_FundType.Text = dataRow.Cells["FundTypeName"].Value.ToString();
                rddl_FundType_SelectedIndexChanged(null, null);

                switch (rddl_BankAccountSubject.DropDownStyle)
                {
                    case RadDropDownStyle.DropDown:
                        rddl_BankAccountSubject.Text = dataRow.Cells["FundTitle"].Value?.ToString();
                        break;
                    case RadDropDownStyle.DropDownList:
                        {
                            var bankAccountId = dataRow.Cells["BankAccountId"].Value;
                            rddl_BankAccountSubject.SelectedValue = bankAccountId;
                            break;
                        }
                    default:
                        rddl_BankAccountSubject.Text = string.Empty;
                        break;
                }

                //var fundTypeId = dataRow.Cells["FundTypeName"].Value?.ToString() == "حساب بانکی" ? 0 : 1;
                //rddl_BankAccountSubject.SelectedValue = dataRow.Cells["BankAccountId"].Value?.ToString();
            }
            catch (Exception exception)
            {
                await LoggerService.ErrorAsync(this.Name, "ReturnFundDetails", exception.Message,
                    exception.ToDetailedString());
            }
        }

        private bool ValidateAllControls()
        {
            //if (ddl_BankAccountSubject.ComboStyle == ComboStyle.DropDownList)
            //{
            return CommonHelper.ValidateControls(rddl_BankAccountSubject, _errorProvider,
                       "عنوان صندوق  را انتخاب نمایید") ||
                   CommonHelper.ValidateControls(txt_FundCurrentValue, _errorProvider,
                       "موجودی اولیه صندوق را مشخص نمایید");
            //}
            //if (ddl_BankAccountSubject.ComboStyle == ComboStyle.DropDownList)
            //{
            //    return CommonHelper.ValidateControls(ddl_BankAccountSubject, _errorProvider,
            //               "عنوان صندوق  را وارد نمایید") ||
            //           CommonHelper.ValidateControls(txt_FundPrimaryValue, _errorProvider,
            //               "موجودی اولیه صندوق را مشخص نمایید");
            //}
            //return false;
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            if (ValidateAllControls()) return;

            var dlg = new CustomDialogs(400, 200);

            int? bankAccountId = null;
            if (rddl_BankAccountSubject.DropDownStyle == RadDropDownStyle.DropDownList)
                bankAccountId = int.Parse(rddl_BankAccountSubject.SelectedItem["BankAccountId"].ToString());

            var fundTitle = rddl_BankAccountSubject.Text;
            var fundType = rddl_FundType.SelectedIndex == 0
                ? Fund.FundTypes.Account : Fund.FundTypes.Other;
            var fundStatus = rddl_FundStatus.Text;
            var currentUser = InitialHelper.CurrentUser;
            var currentDateTime = InitialHelper.CurrentDateTime;
            var fundCurrentValue = double.Parse(txt_FundCurrentValue.Text);
            var fundTypeTitle = rddl_FundType.Text;
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

                        //if (rddl_BankAccountSubject.DropDownStyle == Telerik.WinControls.RadDropDownStyle.DropDownList)
                        //bankAccountId = int.Parse(rddl_BankAccountSubject.SelectedItem.Value.ToString());
                        //else bankAccountId = null;

                        var newFund = new Fund(fundType, fundTitle, bankAccountId,
                            fundCurrentValue, fundCurrentValue,
                            currentDateTime, currentDateTime,
                            currentUser.Id, fundStatus,
                            txt_FundDescription.Text);

                        var status = await _fundService.CreateAsync(newFund);

                        switch (status)
                        {
                            case CreateStatus.Exist:
                                dlg.Invoke("خطای تکرار", "این عنوان صندوق تکراری می باشد",
                                    CustomDialogs.ImageType.itError3,
                                    CustomDialogs.ButtonType.Ok, InitialHelper.BackColorCustom);
                                rddl_BankAccountSubject.Focus();
                                return;
                            case CreateStatus.Failure:
                                dlg.Invoke("بروز خطا", "خطا در ایجاد صندوق جدید",
                                    CustomDialogs.ImageType.itError5,
                                    CustomDialogs.ButtonType.Ok);
                                return;
                            case CreateStatus.Successful:
                                BindGrid();

                                CommonHelper.ShowNotificationMessage("ایجاد صندوق جدید",
                                    $"صندوق با نوع {fundTypeTitle} توسط کاربری با عنوان" +
                                    $" {currentUser.UserName} ایجاد گردید.");

                                await LoggerService.InformationAsync(this.Name,
                                    "btnRegister_Click(Insert Mode)", $"ایجاد صندوق با نوع {fundTypeTitle} ",
                                    $"این صندوق توسط کاربری با نام {currentUser.UserName} ایجاد گردید.");

                                //CommonHelper.ClearInputControls(this, false, false);
                                //rddl_BankAccountSubject.Focus();

                                rgv_Fund.Enabled = true;
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
                            CommonHelper.ShowNotificationMessage(DefaultConstants.IllegalAccess, DefaultConstants.EditActionNotAllow);
                            return;
                        }

                        var currentFund = await _fundService.GetByIdAsync(_fundId);

                        //if (await _fundService.IsUsedAsync(currentFund))
                        //{
                        //    dlg.Invoke("خطا", "از این صندوق استفاده شده و نمیتوان آن را ویرایش نمود.",
                        //        CustomDialogs.ImageType.itError3,
                        //        CustomDialogs.ButtonType.Ok, InitialHelper.BackColorCustom);
                        //    ddl_BankAccountSubject.Focus();
                        //    return;
                        //}

                        //fundType = rddl_FundType.SelectedItem.Value.ToString() == "1" ?
                        //    Fund.FundTypes.Account : Fund.FundTypes.Other;

                        currentFund.Type = fundType;
                        currentFund.Title = fundTitle;
                        currentFund.BankAccountId = bankAccountId;
                        currentFund.UpdateBy = currentUser.Id;
                        currentFund.LastUpdate = currentDateTime;
                        currentFund.Status = fundStatus;
                        currentFund.CurrentValue = fundCurrentValue;
                        currentFund.Description = txt_FundDescription.Text;

                        //if (await _fundService.ExistAsync(currentFund))
                        //{
                        //    dlg.Invoke("خطای تکرار", "خطای تکرار اطلاعات حساب",
                        //        CustomDialogs.ImageType.itError3,
                        //        CustomDialogs.ButtonType.Ok, InitialHelper.BackColorCustom);
                        //    ddl_FundTitle.Focus();
                        //    return;
                        //}

                        await _fundService.UpdateAsync(currentFund);

                        CommonHelper.ShowNotificationMessage("ویرایش صندوق",
                            $"صندوق با نوع {fundTypeTitle} توسط کاربری با عنوان" +
                            $" {currentUser.UserName} ویرایش گردید.");

                        await LoggerService.InformationAsync(this.Name,
                            "btnRegister_Click(Update Mode)", $"ویرایش صندوق با نوع {fundTypeTitle} ",
                            $"این صندوق توسط کاربری با نام {currentUser.UserName} ویرایش گردید.");

                        //CommonHelper.ClearInputControls(pnl_Data);

                        rgv_Fund.Enabled = true;
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
            rgv_Fund.Enabled = true;
            btnRegister.Enabled = false;
            btnClose.Enabled = true;
            _mode = CommonHelper.Mode.None;
        }

        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            if (rgv_Fund.Rows.Count <= 0) return;

            if (!InitialHelper.HasPermissionFor(this.Name, PermissionMode.Delete))
            {
                CommonHelper.ShowNotificationMessage(DefaultConstants.IllegalAccess, DefaultConstants.DeleteActionNotAllow);
                return;
            }

            var dialog = new CustomDialogs(350, 200);
            dialog.Invoke("هشدار حذف", "آيا واقعا میخواهید این صندوق را حذف کنید؟",
                CustomDialogs.ImageType.itQuestion2,
                CustomDialogs.ButtonType.YesNo, InitialHelper.BackColorCustom);

            if (!dialog.Yes) return;

            if (await _fundService.IsUsedAsync(_fundId))
            {
                CommonHelper.ShowNotificationMessage("خطا",
                    "این صندوق در حال استفاده بوده و حذف نمیشود ");
                return;
            }

            await _fundService.RemoveAsync(_fundId);

            //var dlg = new CustomDialogs(400, 200);
            //dlg.Invoke("حذف", "اطلاعات این صندوق حذف گردید.",
            //    CustomDialogs.ImageType.itError3,
            //    CustomDialogs.ButtonType.Ok, InitialHelper.BackColorCustom);

            CommonHelper.ShowNotificationMessage("حذف", $"صندوق با شناسه {_fundId} حذف گردید");

            await LoggerService.InformationAsync(this.Name, "BtnDelete_Click", $"حذف صندوق شماره {_fundId}",
                $"این صندوق توسط کاربری با نام {InitialHelper.CurrentUser.UserName} حذف گردید.");

            _mode = CommonHelper.Mode.None;
            rgv_Fund.Enabled = true;
            CommonHelper.EnableControls(pnl_Data, false);

            btnCancel.Enabled = false;
            btnInsert.Enabled = true;
            btnDelete.Enabled = true;

            BindGrid();
        }

        private void rgv_Fund_CellClick(object sender, GridViewCellEventArgs e)
        {
            if (rgv_Fund.Enabled && rgv_Fund.RowCount > 0)
            { btnModify.Enabled = true; }
            else { btnModify.Enabled = false; }
        }

        private void rgv_Fund_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
        {
            ReturnFundDetails();
        }

        private async void BindBankAccountNames()
        {
            var defaultOption = new ViewModelSimpleLoadBankAccount()
            {
                BankAccountId = 0,
                BankAccountSubject = "انتخاب کنید ..."
            };

            var bankAccounts = await _bankAccountService.SimpleLoadViewModelAsync();
            CommonHelper.Fill(rddl_BankAccountSubject, "BankAccountSubject", "BankAccountId", bankAccounts, defaultOption);

            //ddl_BankAccountSubject.DisplayMember = "BankAccountSubject";
            //ddl_BankAccountSubject.ValueMember = "BankAccountId";
            //ddl_BankAccountSubject.DataSource = await _bankAccountService.SimpleLoadViewModelAsync();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_FundPrimaryValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_done) e.Handled = true;
        }

        private void txt_FundPrimaryValue_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_FundCurrentValue.Text != string.Empty)
            {
                var fi = txt_FundCurrentValue.Text.ClearSeparateEx();
                var temp = fi.ToString(CultureInfo.InvariantCulture).AddSeparateEx();
                txt_FundCurrentValue.Text = temp;
            }
            txt_FundCurrentValue.SelectionStart = txt_FundCurrentValue.Text.Length;
        }

        private void Txt_FundPrimaryValue_KeyDown(object sender, KeyEventArgs e)
        {
            _done = false;
            if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) return;
            if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9) return;
            if (e.KeyCode == Keys.Back) return;
            if (e.KeyCode != Keys.Decimal)
                _done = true;
            e.SuppressKeyPress = true;
        }

        private void rddl_FundType_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (rddl_FundType.SelectedIndex <= -1) return;

            switch (rddl_FundType.SelectedIndex)
            {
                case 0:
                    rddl_BankAccountSubject.DataSource = null;
                    rddl_BankAccountSubject.DropDownSizingMode = SizingMode.UpDownAndRightBottom;
                    rddl_BankAccountSubject.DropDownStyle = RadDropDownStyle.DropDownList;
                    BindBankAccountNames();
                    break;
                case 1:
                    rddl_BankAccountSubject.DropDownStyle = RadDropDownStyle.DropDown;
                    rddl_BankAccountSubject.DataSource = null;
                    rddl_BankAccountSubject.Text = string.Empty;
                    break;

            }
        }

        private void rddl_FundType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnRegister_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private void rddl_BankAccountSubject_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            //if (_mode == CommonHelper.Mode.Insert)
            {
                btnRegister.Enabled = (rddl_BankAccountSubject.Text != string.Empty &&
                    //rddl_FundType.SelectedValue != null &&
                    txt_FundCurrentValue.Text != string.Empty);
            }
        }

        private void rddl_FundStatus_TextChanged(object sender, EventArgs e)
        {
            //if (_mode == CommonHelper.Mode.Insert)
            {
                btnRegister.Enabled = (rddl_BankAccountSubject.Text != string.Empty &&
                                       //rddl_FundType.SelectedValue != null &&
                                       txt_FundCurrentValue.Text != string.Empty);
            }
        }

        private void btn_FundReload_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void rgv_Fund_GroupSummaryEvaluate(object sender, GroupSummaryEvaluationEventArgs e)
        {
            //if (sender is MasterGridViewTemplate)
            //{
            //    decimal sum = 0;
            //    foreach (GridViewRowInfo masterRow in this.rgv_Fund.Rows)
            //    {
            //        GridViewHierarchyRowInfo hierarchyRow = masterRow as GridViewHierarchyRowInfo;
            //        if (hierarchyRow == null)
            //        {
            //            continue;
            //        }
            //        foreach (GridViewRowInfo childRow in masterRow.ChildRows)
            //        {
            //            sum += (decimal)childRow.Cells["FundCurrentValueSeparateDigit"].Value;
            //        }
            //    }
            //    e.FormatString = "Sum of all child rows: " + sum;
            //}
        }

        private void txt_FundCurrentValue_TextChanged(object sender, EventArgs e)
        {
            btnRegister.Enabled = (rddl_BankAccountSubject.Text != string.Empty &&
                                   //rddl_FundType.SelectedValue != null &&
                                   txt_FundCurrentValue.Text != string.Empty);
        }

        private void rgv_Fund_ViewCellFormatting(object sender, CellFormattingEventArgs e)
        {
            if (!(e.CellElement is GridSummaryCellElement summaryCell))
                return;

            if (!string.IsNullOrEmpty(summaryCell.Text))
            {
                _rows.Add(summaryCell.RowInfo);
                summaryCell.RowElement.DrawFill = true;
                summaryCell.RowElement.GradientStyle = GradientStyles.Solid;
                summaryCell.RowElement.BackColor = Color.LightBlue;
                summaryCell.RowElement.ForeColor = Color.Indigo;
                summaryCell.RowElement.Font = CommonHelper.BaseBoldFont;

            }
            else if (!_rows.Contains(summaryCell.RowInfo))
            {
                summaryCell.RowElement.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local);
                summaryCell.RowElement.ResetValue(LightVisualElement.GradientStyleProperty, ValueResetFlags.Local);
                summaryCell.RowElement.ResetValue(VisualElement.BackColorProperty, ValueResetFlags.Local);
            }
        }

        private void rgv_Fund_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            //if(e.CellElement.Name == "FundCurrentValue")
            {
                e.CellElement.Font = CommonHelper.BaseFont;
            }
        }
    }
}