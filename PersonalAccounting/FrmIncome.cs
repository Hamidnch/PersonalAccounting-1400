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
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace PersonalAccounting.UI
{
    public partial class FrmIncome : BaseForm
    {
        private readonly IRepositoryService<Income, ViewModelLoadAllIncome, Income> _incomeService;
        private readonly IRepositoryService<IncomeType, ViewModelLoadAllIncomeType, IncomeType> _incomeTypeService;
        private readonly IFundService _fundService;

        private readonly HashSet<GridViewRowInfo> _rows = new HashSet<GridViewRowInfo>();

        private int _incomeId;
        private bool _done;

        public static FrmIncome AFrmIncome = null;
        public static FrmIncome Instance()
        {
            return AFrmIncome ?? (AFrmIncome = IocConfig.Container.GetInstance<FrmIncome>());
        }

        public FrmIncome(IRepositoryService<Income, ViewModelLoadAllIncome, Income> incomeService,
            IRepositoryService<IncomeType, ViewModelLoadAllIncomeType, IncomeType> incomeTypeService,
            IFundService fundService)
        {
            _incomeService = incomeService;
            _incomeTypeService = incomeTypeService;
            _fundService = fundService;

            InitializeComponent();

            //BindToCombo(ddl_IncomeTypes, await _incomeTypeService.LoadAllViewModelAsync(),
            //    "IncomeTypeTitle", "IncomeTypeId");
            //BindToCombo(ddl_FundTitles, await _fundService.LoadAllViewModelAsync(),
            //    "FundTitle", "FundId");

            //this.rgv_Income.Columns["IncomePrice"].FormatString = "{0:n0}";
            //this.rgv_Income.Columns["FundCurrentValue"].FormatString = "{0:n0}";
            //this.rgv_Income.Columns["FundOldValue"].FormatString = "{0:n0}";

            BindGrid();
            FillDropdownList(rddl_IncomeTypes);
            FillDropdownList(rddl_Funds);
            ReturnIncomeDetails();
        }

        //private static void BindToCombo(RadDropDownList combo, object dataSource,
        //                        string displayMember, string valueMember)
        //{
        //    combo.DisplayMember = displayMember;
        //    combo.ValueMember = valueMember;
        //    combo.DataSource = dataSource;
        //}

        private async void BindGrid()
        {
            int? currentUserId = null;
            if (!await InitialHelper.CurrentUser.IsAdmin())
                currentUserId = InitialHelper.CurrentUser.Id;

            rgv_Income.BeginUpdate();
            rgv_Income.DataSource = await _incomeService.LoadAllViewModelAsync(currentUserId);
            CommonHelper.SortOrderByColumn(rgv_Income, "IncomeId", ListSortDirection.Descending);
            rgv_Income.EndUpdate();
        }

        private async void FillDropdownList(RadDropDownList ddl)
        {
            switch (ddl.Name)
            {
                case "rddl_IncomeTypes":
                    {
                        ddl.DisplayMember = "IncomeTypeTitle";
                        ddl.ValueMember = "IncomeTypeId";

                        var defaultOption = new ViewModelLoadAllIncomeType()
                        {
                            IncomeTypeId = 0,
                            IncomeTypeTitle = "انتخاب کنید ..."
                        };

                        var incomeTypes = await _incomeTypeService.LoadAllViewModelAsync();
                        incomeTypes.Insert(0, defaultOption);
                        ddl.DataSource = incomeTypes;
                        break;
                    }

                case "rddl_Funds":
                    {
                        ddl.DisplayMember = "FundTitle";
                        ddl.ValueMember = "FundId";

                        var defaultOption = new ViewModelLoadAllFund()
                        {
                            FundId = 0,
                            FundTitle = "انتخاب کنید ..."
                        };

                        var funds = await
                            _fundService.LoadAllViewModelAsync();
                        funds.Insert(0, defaultOption);
                        ddl.DataSource = funds;
                        break;
                    }
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!InitialHelper.HasPermissionFor(this.Name, PermissionMode.Add))
            {
                CommonHelper.ShowNotificationMessage(DefaultConstants.IllegalAccess, DefaultConstants.CreateActionNotAllow);
                return;
            }

            _mode = CommonHelper.Mode.Insert;
            CommonHelper.InsertAction(_mode, pnl_Data, rgv_Income, btnInsert, btnRegister, btnModify,
                btnDelete, btnCancel, btnClose, txt_IncomeDate);

            //BindToCombo(rddl_IncomeTypes, await _incomeTypeService.LoadAllViewModelAsync(),
            //    "IncomeTypeTitle", "IncomeTypeId");
            //BindToCombo(ddl_FundTitles, await _fundService.LoadAllViewModelAsync(),
            //    "FundTitle", "FundId");

            txt_IncomeDate.SetPersianDateToTextBoxAndSelectAll();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _mode = CommonHelper.Mode.Cancel;
            CommonHelper.CancelAction(_mode, pnl_Data, rgv_Income, btnInsert, btnRegister, btnModify,
                btnDelete, btnCancel, btnClose);

            ReturnIncomeDetails();
        }

        private async void ReturnIncomeDetails()
        {
            try
            {
                if (!(rgv_Income.CurrentRow is GridViewDataRowInfo dataRow)) return;

                _incomeId = int.Parse(dataRow.Cells["IncomeId"].Value.ToString());
                //_fundId = int.Parse(dataRow.Cells["FundId"].Value.ToString());
                //_incomePrice = double.Parse(dataRow.Cells["IncomePrice"].Value.ToString());
                txt_ReceivedBy.Text = dataRow.Cells["ReceivedBy"].Value?.ToString();
                txt_IncomeDate.Text = dataRow.Cells["IncomePersianDate"].Value?.ToString();
                //txt_IncomePrice.Text = dataRow.Cells["IncomeSeparateDigitPrice"].Value?.ToString();
                txt_IncomePrice.Text = dataRow.Cells["IncomePrice"].Value?.ToString().AddSeparateEx();
                txt_IncomeDescription.Text = dataRow.Cells["Description"].Value?.ToString();

                rddl_IncomeTypes.SelectedValue = dataRow.Cells["IncomeTypeId"].Value;
                rddl_Funds.SelectedValue = dataRow.Cells["FundId"].Value;
            }
            catch (Exception exception)
            {
                await LoggerService.ErrorAsync(this.Name, "ReturnIncomeDetails", exception.Message,
                    exception.ToDetailedString());

            }
        }
        private bool ValidateAllControls()
        {
            return CommonHelper.ValidateControls(txt_IncomeDate, _errorProvider,
                       "تاریخ درآمد را وارد نمایید")
                   ||
                   CommonHelper.ValidateControls(txt_IncomePrice, _errorProvider,
                       "مبلغ درآمد را مشخص نمایید")
                   ||
                   CommonHelper.ValidateControls(rddl_IncomeTypes, _errorProvider,
                       "نوع درآمد را مشخص نمایید") ||
                   CommonHelper.ValidateControls(rddl_Funds, _errorProvider,
                       "صندوق را مشخص نمایید");
        }
        private async void btnRegister_Click(object sender, EventArgs e)
        {
            if (ValidateAllControls()) return;

            var dlg = new CustomDialogs(400, 200);
            var currentUser = InitialHelper.CurrentUser;
            var currentDateTime = InitialHelper.CurrentDateTime;

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

                        var incomeTypeId = int.Parse(rddl_IncomeTypes.SelectedItem["IncomeTypeId"].ToString());
                        var fundId = int.Parse(rddl_Funds.SelectedItem["FundId"].ToString());

                        var receivedBy = txt_ReceivedBy.Text;
                        var currentFundAmount = await _fundService.GetFundValueAsync(fundId);
                        var incomePrice = double.Parse(txt_IncomePrice.Text);
                        var fundOldValue = currentFundAmount;
                        var fundCurrentValue = currentFundAmount + incomePrice;

                        var incomeDate = PersianHelper.GetGregorianDate(txt_IncomeDate.Text);
                        var description = txt_IncomeDescription.Text;

                        var newIncome = new Income(incomeTypeId, receivedBy, fundId,
                            fundCurrentValue, fundOldValue, incomeDate, incomePrice, currentUser.Id,
                            currentDateTime, null, description);

                        var status = await _incomeService.CreateAsync(newIncome);

                        CommonHelper.ShowNotificationMessage("ثبت درآمد جدید",
                            $"درآمد جدید با مبلغ {incomePrice} ریال توسط کاربری با عنوان" +
                            $" {currentUser.UserName} انجام گردید.");

                        await LoggerService.InsertLogAsync(this.Name, "btnRegister_Click(Insert Mode)",
                            LogLevel.Information,
                            $"ثبت درآمد جدید با مبلغ {incomePrice} ریال ",
                            $" توسط کاربری با نام {currentUser.UserName} انجام گردید.");

                        switch (status)
                        {
                            case CreateStatus.Exist:
                                dlg.Invoke("خطای تکرار", "این مشخصات برای درآمد تکراری می باشد",
                                    CustomDialogs.ImageType.itError3,
                                    CustomDialogs.ButtonType.Ok, InitialHelper.BackColorCustom);
                                txt_IncomePrice.Focus();
                                return;
                            case CreateStatus.Failure:
                                dlg.Invoke("بروز خطا", "خطا در ایجاد درآمد جدید", CustomDialogs.ImageType.itError5,
                                    CustomDialogs.ButtonType.Ok);
                                return;
                            case CreateStatus.Successful:
                                await _fundService.AddValueToFundAsync(fundId, incomePrice);
                                BindGrid();

                                CommonHelper.ShowNotificationMessage("ثبت درآمد جدید",
                                    $"درآمد جدید با مبلغ {incomePrice} ریال توسط کاربری با عنوان" +
                                    $" {currentUser.UserName} انجام گردید.");

                                await LoggerService.InformationAsync(this.Name, "btnRegister_Click(Insert Mode)",
                                    $"ثبت درآمد جدید با مبلغ {incomePrice} ریال ",
                                    $" توسط کاربری با نام {currentUser.UserName} انجام گردید.");

                                //CommonHelper.ClearInputControls(this, false, false);
                                txt_IncomePrice.Focus();
                                rgv_Income.Enabled = true;
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

                        //Get Current Income
                        var currentIncome = await _incomeService.GetByIdAsync(_incomeId);
                        //Get income price
                        var incomePrice = currentIncome.Amount;
                        //sub amount from fund
                        var fundId = currentIncome.FundId;
                        var fundStatus = await _fundService.SubValueFromFundAsync(fundId, incomePrice);

                        var createdBy = currentIncome.CreatedBy;
                        var createdOn = currentIncome.CreatedOn;
                        var fundOldValue = currentIncome.FundCurrentValue;

                        if (fundStatus == FundStatus.Success)
                        {
                            //Eliminate income price
                            await _incomeService.RemoveAsync(currentIncome);

                            //Create new income price and add amount to fund
                            //var newFundId = int.Parse(ddl_FundTitles.SelectedItem.Value.ToString());
                            //var newIncomePrice = double.Parse(txt_IncomePrice.Text);
                            //currentIncome.IncomeDate = PersianHelper.GetGregorianDate(txt_IncomeDate.Text);
                            //currentIncome.TypeId = int.Parse(ddl_IncomeTypes.SelectedItem.Value.ToString());
                            //currentIncome.ReceivedBy = txt_ReceivedBy.Text;
                            //currentIncome.FundId = newFundId;
                            //currentIncome.Amount = newIncomePrice;
                            //currentIncome.CreatedBy = InitialHelper.CurrentUser.Id;
                            //currentIncome.LastUpdate = DateTime.Now;
                            //currentIncome.Description = txt_IncomeDescription.Text;

                            var incomeTypeId = int.Parse(rddl_IncomeTypes.SelectedItem.Value.ToString());
                            var receivedBy = txt_ReceivedBy.Text;
                            var newFundId = int.Parse(rddl_Funds.SelectedItem.Value.ToString());

                            var currentFundAmount = await _fundService.GetFundValueAsync(newFundId);
                            var newIncomePrice = double.Parse(txt_IncomePrice.Text);
                            var fundCurrentValue = currentFundAmount + newIncomePrice;

                            var incomeDate = PersianHelper.GetGregorianDate(txt_IncomeDate.Text);
                            var currentUserId = currentUser.Id;
                            var description = txt_IncomeDescription.Text;

                            //var newIncome = new Income(incomeTypeId, receivedBy, newFundId,
                            //    fundCurrentValue, incomeDate, newIncomePrice, currentUserId,
                            //    currentDateTime, currentDateTime, description);
                            var newIncome = new Income
                            {
                                TypeId = incomeTypeId,
                                ReceivedBy = receivedBy,
                                FundId = newFundId,
                                FundOldValue = fundOldValue,
                                FundCurrentValue = fundCurrentValue,
                                IncomeDate = incomeDate,
                                Amount = newIncomePrice,
                                CreatedBy = createdBy,
                                CreatedOn = createdOn,
                                UpdateBy = currentUserId,
                                LastUpdate = currentDateTime,
                                Description = description
                            };

                            var status = await _incomeService.CreateAsync(newIncome);

                            CommonHelper.ShowNotificationMessage("ثبت درآمد جدید",
                                $"درآمد جدید با مبلغ {newIncomePrice} ریال توسط کاربری با عنوان" +
                                $" {currentUser.UserName} انجام گردید.");

                            await LoggerService.InsertLogAsync(this.Name, "btnRegister_Click(Update Mode)",
                                LogLevel.Information,
                                $"ثبت درآمد جدید با مبلغ {newIncomePrice} ریال ",
                                $" توسط کاربری با نام {currentUser.UserName} انجام گردید.");

                            switch (status)
                            {
                                case CreateStatus.Exist:
                                    dlg.Invoke("خطای تکرار", "این مشخصات برای درآمد تکراری می باشد",
                                        CustomDialogs.ImageType.itError3,
                                        CustomDialogs.ButtonType.Ok, InitialHelper.BackColorCustom);
                                    txt_IncomePrice.Focus();
                                    return;
                                case CreateStatus.Failure:
                                    dlg.Invoke("بروز خطا", "خطا در ویرایش درآمد", CustomDialogs.ImageType.itError5,
                                        CustomDialogs.ButtonType.Ok);
                                    return;
                                case CreateStatus.Successful:
                                    await _fundService.AddValueToFundAsync(newFundId, newIncomePrice);
                                    BindGrid();
                                    CommonHelper.ShowNotificationMessage("افزودن درآمد به صندوق",
                                        $"مبلغ {newIncomePrice} ریال از محل درآمد در صندوق شماره {newFundId} " +
                                        $"توسط کاربری با نام {currentUser.UserName} " + " ذخیره شد.");

                                    await LoggerService.InformationAsync(this.Name, "btnRegister_Click(Update Mode)",
                                        $"مبلغ {newIncomePrice} ریال از محل درآمد در صندوق شماره {newFundId} " +
                                        $"توسط کاربری با نام {currentUser.UserName} " + " ذخیره شد.");

                                    //CommonHelper.ClearInputControls(this, false, false);
                                    txt_IncomePrice.Focus();
                                    rgv_Income.Enabled = true;
                                    CommonHelper.EnableControls(pnl_Data, false);
                                    btnCancel.Enabled = false;
                                    btnInsert.Enabled = true;
                                    btnDelete.Enabled = true;
                                    break;
                                default:
                                    throw new ArgumentOutOfRangeException();
                            }
                        }
                        //////eliminate income price from current fund
                        ////var currentFund = await _fundService.GetByIdAsync(fundId);
                        ////currentFund.CurrentValue -= incomePrice;
                        ////await _fundService.UpdateAsync(currentFund);

                        ////if (_incomeService.ExistIncome(currentIncome))
                        ////{
                        ////    dlg.Invoke("خطای تکرار", "خطای تکرار اطلاعات حساب",
                        ////        CustomDialogs.ImageType.itError3,
                        ////        CustomDialogs.ButtonType.Ok, InitialHelper.BackColorCustom);
                        ////    txt_IncomeDate.Focus();
                        ////    return;
                        ////}

                        //await _incomeService.UpdateAsync(currentIncome);

                        //CommonHelper.ClearInputControls(pnl_Data);
                        //rgv_Income.Enabled = true;
                        //CommonHelper.EnableControls(pnl_Data, false);
                        //btnCancel.Enabled = false;
                        //btnInsert.Enabled = true;
                        //btnDelete.Enabled = true;
                        //BindGrid();
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
            rgv_Income.Enabled = true;
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
            CommonHelper.ModifyAction(_mode, pnl_Data, rgv_Income, btnInsert, btnRegister,
                btnModify, btnDelete, btnCancel, btnClose);

            //BindToCombo(rddl_IncomeTypes, await _incomeTypeService.LoadAllViewModelAsync(),
            //    "IncomeTypeTitle", "IncomeTypeId");
            //BindToCombo(ddl_FundTitles, await _fundService.LoadAllViewModelAsync(),
            //    "FundTitle", "FundId");
        }

        private void txt_IncomeDate_TextChanged(object sender, EventArgs e)
        {
            if (_mode == CommonHelper.Mode.Insert)
            {
                btnRegister.Enabled = (txt_IncomeDate.Text != string.Empty &&
                    txt_IncomePrice.Text != string.Empty || rddl_Funds.Text != string.Empty
                    || rddl_IncomeTypes.Text != string.Empty);
            }
        }

        private void MasterTemplate_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
        {
            ReturnIncomeDetails();
        }

        private void MasterTemplate_CellClick(object sender, GridViewCellEventArgs e)
        {
            if (rgv_Income.Enabled && rgv_Income.RowCount > 0)
            { btnModify.Enabled = true; }
            else { btnModify.Enabled = false; }
        }

        private void txt_IncomePrice_KeyDown(object sender, KeyEventArgs e)
        {
            _done = false;
            if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) return;
            if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9) return;
            if (e.KeyCode == Keys.Back) return;
            if (e.KeyCode != Keys.Decimal)
                _done = true;
        }

        private void txt_IncomePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_done) e.Handled = true;
        }

        private void txt_IncomePrice_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_IncomePrice.Text != string.Empty)
            {
                var fi = txt_IncomePrice.Text.ClearSeparateEx();
                var temp = fi.ToString(CultureInfo.InvariantCulture).AddSeparateEx();
                txt_IncomePrice.Text = temp;
            }
            txt_IncomePrice.SelectionStart = txt_IncomePrice.Text.Length;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txt_IncomeDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnRegister_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (rgv_Income.Rows.Count <= 0) return;

            if (!InitialHelper.HasPermissionFor(this.Name, PermissionMode.Delete))
            {
                CommonHelper.ShowNotificationMessage(DefaultConstants.IllegalAccess, DefaultConstants.DeleteActionNotAllow);
                return;
            }

            var dialog = new CustomDialogs(350, 200);
            dialog.Invoke("هشدار حذف", "آيا واقعا میخواهید این درآمد را حذف کنید؟",
                CustomDialogs.ImageType.itQuestion2,
                CustomDialogs.ButtonType.YesNo, InitialHelper.BackColorCustom);

            if (!dialog.Yes) return;

            //if (await _incomeService.IsUsedAsync(_incomeId))
            //{
            //    CommonHelper.ShowNotificationMessage("خطا",
            //        "این درآمد در حال استفاده بوده و حذف نمیشود ");

            //    return;
            //}

            var income = await _incomeService.GetByIdAsync(_incomeId);
            var fundId = income.FundId;
            var incomePrice = income.Amount;

            //Sub income from fund
            var fundStatus = await _fundService.SubValueFromFundAsync(fundId, incomePrice);

            switch (fundStatus)
            {
                case FundStatus.FundValueIsLessThanCurrentValue:
                    CommonHelper.ShowNotificationMessage("هشدار",
                        "موجودی صندوق از  مقدار جاری درآمد کمتر است");
                    break;
                case FundStatus.Success:
                    await _incomeService.RemoveAsync(_incomeId);
                    CommonHelper.ShowNotificationMessage("پیام",
                        $"این رکورد درآمد با شناسه {_incomeId} حذف گردید");

                    await LoggerService.InformationAsync(this.Name, "btnDelete_Click", "کسر کردن درآمد از صندوق به جهت حذف درآمد",
                        $"مبلغ {incomePrice} ریال از محل درآمد از صندوق شماره {fundId} توسط کاربر {InitialHelper.CurrentUser.UserName} کسر گردید.");

                    _mode = CommonHelper.Mode.None;
                    rgv_Income.Enabled = true;
                    CommonHelper.EnableControls(pnl_Data, false);

                    btnCancel.Enabled = false;
                    btnInsert.Enabled = true;
                    btnDelete.Enabled = true;

                    BindGrid();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void rgv_Income_Click(object sender, EventArgs e)
        {
            ReturnIncomeDetails();
        }

        private void rgv_Income_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            e.CellElement.Font = CommonHelper.BaseFont;
        }

        private void rgv_Income_ViewCellFormatting(object sender, CellFormattingEventArgs e)
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
    }
}
