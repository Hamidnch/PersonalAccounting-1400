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
    public partial class FrmBankAccount : BaseForm
    {
        private readonly IRepositoryService<BankAccount,
            ViewModelLoadAllBankAccount, ViewModelSimpleLoadBankAccount> _bankAccountService;
        private readonly IRepositoryService<Bank, ViewModelLoadAllBank, Bank> _bankService;
        private readonly IRepositoryService<Person, ViewModelLoadAllPerson, ViewModelSimpleLoadPerson> _personService;

        private int _bankAccountId;

        public static FrmBankAccount AFrmBankAccount = null;
        public static FrmBankAccount Instance()
        {
            return AFrmBankAccount ?? (AFrmBankAccount = IocConfig.Container.GetInstance<FrmBankAccount>());
        }

        public FrmBankAccount(IRepositoryService<BankAccount, ViewModelLoadAllBankAccount,
                ViewModelSimpleLoadBankAccount> bankAccountService,
            IRepositoryService<Bank, ViewModelLoadAllBank, Bank> bankService,
            IRepositoryService<Person, ViewModelLoadAllPerson, ViewModelSimpleLoadPerson> personService)
        {
            _bankAccountService = bankAccountService;
            _bankService = bankService;
            _personService = personService;

            InitializeComponent();

            //CommonHelper.SetFont(CommonHelper.BaseFont, pnl_Data, rgv_BankAccount);

            //ddl_BankAccountPerson.ValueMember = "Id";
            //ddl_BankAccountPerson.DisplayMember = "FullName";
            //ddl_BankAccountPerson.DataSource = await _personService.LoadAllAsync();

            //ddl_BankAccountBank.ValueMember = "Id";
            //ddl_BankAccountBank.DisplayMember = "Name";
            //ddl_BankAccountBank.DataSource = await _bankService.LoadAllAsync();

            FillDropdownList(rddl_BankAccountPerson);
            FillDropdownList(rddl_BankAccountBank);
            BindGrid();
            rddl_BankAccountStatus.SetEnableDisableStatusDropdownList();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!InitialHelper.HasPermissionFor(this.Name, PermissionMode.Add))
            {
                CommonHelper.ShowNotificationMessage(DefaultConstants.IllegalAccess, DefaultConstants.CreateActionNotAllow);
                return;
            }

            _mode = CommonHelper.Mode.Insert;
            CommonHelper.InsertAction(_mode, pnl_Data, rgv_BankAccount, btnInsert, btnRegister, btnModify,
                btnDelete, btnCancel, btnClose, txt_BankAccountSubject);

            rddl_BankAccountStatus.SelectedValue = 0;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (!InitialHelper.HasPermissionFor(this.Name, PermissionMode.Edit))
            {
                CommonHelper.ShowNotificationMessage(DefaultConstants.IllegalAccess, DefaultConstants.EditActionNotAllow);
                return;
            }

            _mode = CommonHelper.Mode.Update;
            CommonHelper.ModifyAction(_mode, pnl_Data, rgv_BankAccount, btnInsert, btnRegister,
                btnModify, btnDelete, btnCancel, btnClose);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _mode = CommonHelper.Mode.Cancel;
            CommonHelper.CancelAction(_mode, pnl_Data, rgv_BankAccount, btnInsert, btnRegister, btnModify,
                btnDelete, btnCancel, btnClose);

            ReturnBankAccountDetails();
        }

        private async void BindGrid()
        {
            //int? currentUserId = null;
            //if (!await InitialHelper.CurrentUser.IsAdmin())
            //    currentUserId = InitialHelper.CurrentUser.Id;

            rgv_BankAccount.BeginUpdate();
            rgv_BankAccount.DataSource = await _bankAccountService.LoadAllViewModelAsync();
            rgv_BankAccount.EndUpdate();
        }

        //private void Fill<T>(RadDropDownList ddl, string displayMember, string valueMember, IList<T> t, T defaultOption)
        //{
        //    ddl.DisplayMember = displayMember;
        //    ddl.ValueMember = valueMember;
        //    t.Insert(0, defaultOption);
        //    ddl.DataSource = t;
        //}
        private async void FillDropdownList(Control ddl)
        {
            switch (ddl.Name.Trim())
            {
                case "rddl_BankAccountPerson":
                    {
                        //var defaultOption = new ViewModelSimpleLoadPerson()
                        //{
                        //    PersonId = 0,
                        //    PersonName = "انتخاب کنید ..."
                        //};

                        var persons = await _personService.SimpleLoadViewModelAsync();
                        CommonHelper.Fill(rddl_BankAccountPerson, "PersonName", "PersonId", persons, null);
                        break;
                    }

                case "rddl_BankAccountBank":
                    {
                        //var defaultOption = new ViewModelLoadAllBank()
                        //{
                        //    BankId = 0,
                        //    BankName = "انتخاب کنید ..."
                        //};

                        var banks = await _bankService.LoadAllViewModelAsync();
                        CommonHelper.Fill(rddl_BankAccountBank, "BankName", "BankId", banks, null);
                        break;
                    }
            }
        }
        private async void ReturnBankAccountDetails()
        {
            try
            {
                if (!(rgv_BankAccount.CurrentRow is GridViewDataRowInfo dataRow)) return;

                _bankAccountId = int.Parse(dataRow.Cells["BankAccountId"].Value.ToString());
                txt_BankAccountSubject.Text = dataRow.Cells["BankAccountSubject"].Value?.ToString();
                txt_BankAccountNumber.Text = dataRow.Cells["BankAccountNumber"].Value?.ToString();

                //rddl_BankAccountBank.SelectedItem.Text = dataRow.Cells["BankName"].Value?.ToString();
                //rddl_BankAccountPerson.SelectedItem.Text = dataRow.Cells["BankAccountPersonName"].Value?.ToString();
                //rddl_BankAccountBank.SelectedItem.Value = dataRow.Cells["BankId"].Value?.ToString();
                //rddl_BankAccountPerson.SelectedItem.Value = dataRow.Cells["PersonId"].Value?.ToString();

                this.rddl_BankAccountBank.SelectedValue = dataRow.Cells["BankId"].Value;
                this.rddl_BankAccountPerson.SelectedValue = dataRow.Cells["PersonId"].Value;

                rddl_BankAccountStatus.Text = dataRow.Cells["BankAccountStatus"].Value?.ToString();
                txt_BankAccountDescription.Text = dataRow.Cells["BankAccountDescription"].Value?.ToString();
            }
            catch (Exception exception)
            {
                await LoggerService.ErrorAsync(this.Name, "ReturnBankAccountDetails",
                    exception.Message, exception.ToDetailedString());
            }
        }
        private bool ValidateAllControls()
        {
            return CommonHelper.ValidateControls(txt_BankAccountNumber, _errorProvider,
                       "شماره حساب بانکی را وارد نمایید") ||
                   CommonHelper.ValidateControls(rddl_BankAccountPerson, _errorProvider,
                       "صاحب حساب را مشخص نمایید") ||
                   CommonHelper.ValidateControls(rddl_BankAccountBank, _errorProvider,
                       "بانک مربوطه را مشخص نمایید");
        }
        private async void btnRegister_Click(object sender, EventArgs e)
        {
            if (ValidateAllControls()) return;

            var dlg = new CustomDialogs(400, 200);

            var personId = int.Parse(rddl_BankAccountPerson.SelectedItem["PersonId"].ToString());
            var bankId = int.Parse(rddl_BankAccountBank.SelectedItem["BankId"].ToString());
            var currentUser = InitialHelper.CurrentUser;
            var currentDateTime = InitialHelper.CurrentDateTime;
            var bankAccountStatus = rddl_BankAccountStatus.Text;
            var bankAccountSubject = txt_BankAccountSubject.Text;
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

                        var newBankAccount = new BankAccount(bankAccountSubject,
                            txt_BankAccountNumber.Text, bankId, personId, currentUser.Id,
                            currentDateTime, currentDateTime, bankAccountStatus,
                            txt_BankAccountDescription.Text);

                        var status = await _bankAccountService.CreateAsync(newBankAccount);
                        switch (status)
                        {
                            case CreateStatus.Exist:
                                dlg.Invoke("خطای تکرار", "عنوان یا شماره حساب تکراری می باشد",
                                    CustomDialogs.ImageType.itError3,
                                    CustomDialogs.ButtonType.Ok, InitialHelper.BackColorCustom);
                                txt_BankAccountNumber.Focus();
                                txt_BankAccountNumber.SelectAll();
                                return;
                            case CreateStatus.Failure:
                                dlg.Invoke("بروز خطا", " خطا در حین ایجاد حساب بانکی جدید",
                                    CustomDialogs.ImageType.itError5, CustomDialogs.ButtonType.Ok);
                                return;
                            case CreateStatus.Successful:
                                BindGrid();

                                CommonHelper.ShowNotificationMessage("ایجاد حساب بانکی جدید",
                                    $"حساب بانکی با عنوان {bankAccountSubject} توسط کاربری با عنوان" +
                                    $" {currentUser.UserName} ایجاد گردید.");

                                await LoggerService.InformationAsync(this.Name, "btnRegister_Click(Insert Mode)", 
                                    $"ایجاد حساب بانکی با عنوان {bankAccountSubject} ",
                                    $"توسط کاربری با نام {currentUser.UserName} انجام گردید.");

                                //CommonHelper.ClearInputControls(this, false, false);
                                txt_BankAccountSubject.Focus();
                                rgv_BankAccount.Enabled = true;
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
                            "خطای زیر به وقوع پیوست \n" + exception.ToDetailedString(),
                            CustomDialogs.ImageType.itError2, CustomDialogs.ButtonType.Ok,
                            InitialHelper.BackColorCustom);

                        await LoggerService.ErrorAsync(this.Name, "btnRegister_Click(Insert Mode)",
                            exception.Message, exception.ToDetailedString());

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
                        var currentBank = await _bankAccountService.GetByIdAsync(_bankAccountId);
                        currentBank.Name = bankAccountSubject;
                        currentBank.AccountNumber = txt_BankAccountNumber.Text;
                        currentBank.PersonId = personId;//int.Parse(rddl_BankAccountPerson.SelectedValue.ToString());
                        currentBank.BankId = bankId;//int.Parse(rddl_BankAccountBank.SelectedValue.ToString());
                        //currentBank.Id = int.Parse(ddl_BankAccountBank.SelectedValue.ToString());
                        currentBank.UpdateBy = currentUser.Id;
                        currentBank.LastUpdate = currentDateTime;
                        currentBank.Status = bankAccountStatus;
                        currentBank.Description = txt_BankAccountDescription.Text;
                        await _bankAccountService.UpdateAsync(currentBank);


                        CommonHelper.ShowNotificationMessage("ویرایش حساب بانکی",
                            $"حساب بانکی با عنوان {bankAccountSubject} توسط کاربری با عنوان" +
                            $" {currentUser.UserName} ویرایش گردید.");

                        await LoggerService.InsertLogAsync(this.Name, "btnRegister_Click(Update Mode)", LogLevel.Information,
                            $"ویرایش حساب بانکی با عنوان {bankAccountSubject} ",
                            $"و توسط کاربری با نام {currentUser.UserName} انجام گردید.");

                        //CommonHelper.ClearInputControls(pnl_Data);
                        BindGrid();
                        rgv_BankAccount.Enabled = true;
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

                        await LoggerService.ErrorAsync(this.Name, "btnRegister_Click(Update Mode)",
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
            rgv_BankAccount.Enabled = true;
            btnRegister.Enabled = false;
            btnClose.Enabled = true;
            _mode = CommonHelper.Mode.None;
        }

        private void txt_BankAccountNumber_TextChanged(object sender, EventArgs e)
        {
            if (_mode == CommonHelper.Mode.Insert)
            {
                btnRegister.Enabled = (txt_BankAccountNumber.Text != string.Empty &&
                    rddl_BankAccountPerson.Text != string.Empty && rddl_BankAccountBank.Text != string.Empty);
            }
        }

        private void rgv_BankAccount_CellClick(object sender, GridViewCellEventArgs e)
        {
            if (rgv_BankAccount.Enabled && rgv_BankAccount.RowCount > 0)
            {
                btnModify.Enabled = true;
                ReturnBankAccountDetails();
            }
            else
            {
                btnModify.Enabled = false;
            }

            //this.rddl_BankAccountBank.SelectedValue = this.rgv_BankAccount.Rows[e.RowIndex].Cells["BankId"].Value;
            //this.rddl_BankAccountPerson.SelectedValue = this.rgv_BankAccount.Rows[e.RowIndex].Cells["PersonId"].Value;
        }

        private void rgv_BankAccount_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
        {
            ReturnBankAccountDetails();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txt_BankAccountSubject_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnRegister_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (rgv_BankAccount.Rows.Count <= 0) return;

            if (!InitialHelper.HasPermissionFor(this.Name, PermissionMode.Delete))
            {
                CommonHelper.ShowNotificationMessage(DefaultConstants.IllegalAccess, DefaultConstants.DeleteActionNotAllow);
                return;
            }

            var dialog = new CustomDialogs(350, 200);
            dialog.Invoke("هشدار حذف", "آيا واقعا میخواهید این حساب بانکی را حذف کنید؟",
                CustomDialogs.ImageType.itQuestion2,
                CustomDialogs.ButtonType.YesNo, InitialHelper.BackColorCustom);

            if (!dialog.Yes) return;

            if (await _bankAccountService.IsUsedAsync(_bankAccountId))
            {
                CommonHelper.ShowNotificationMessage("خطا",
                    "حساب بانکی در حال استفاده بوده و حذف نمیشود ");

                return;
            }

            await _bankAccountService.RemoveAsync(_bankAccountId);

            CommonHelper.ShowNotificationMessage("پیام", $"حساب بانکی با شناسه {_bankAccountId} حذف گردید");
            await LoggerService.InformationAsync(this.Name, "BtnDelete_Click", $"حذف حساب بانکی با شماره {_bankAccountId}",
                $"این حساب بانکی توسط کاربری با نام {InitialHelper.CurrentUser.UserName} حذف گردید.");

            _mode = CommonHelper.Mode.None;
            rgv_BankAccount.Enabled = true;
            CommonHelper.EnableControls(pnl_Data, false);

            btnCancel.Enabled = false;
            btnInsert.Enabled = true;
            btnDelete.Enabled = true;

            BindGrid();
        }
    }
}
