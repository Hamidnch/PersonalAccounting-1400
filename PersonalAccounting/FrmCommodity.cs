using MessageBoxHamidNCH;
using PersonalAccounting.BLL.Enum;
using PersonalAccounting.BLL.IService;
using PersonalAccounting.CommonLibrary.Helper;
using PersonalAccounting.Domain.Entity;
using PersonalAccounting.Domain.ViewModel;
using PersonalAccounting.UI.Helper;
using PersonalAccounting.UI.Infrastructure;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace PersonalAccounting.UI
{
    public partial class FrmCommodity : BaseForm
    {
        private readonly IRepositoryService<Commodity, ViewModelLoadAllCommodity, Commodity> _commodityService;
        private readonly IRepositoryService<CommodityType, ViewModelLoadAllCommodityType, CommodityType> _commodityTypeService;
        private readonly IRepositoryService<Person, ViewModelLoadAllPerson, ViewModelSimpleLoadPerson> _personService;

        private int _commodityId;

        //private bool _done;

        public static FrmCommodity AFrmCommodity = null;
        public static FrmCommodity Instance()
        {
            return AFrmCommodity ?? (AFrmCommodity = IocConfig.Container.GetInstance<FrmCommodity>());
        }

        public FrmCommodity(IRepositoryService<Commodity, ViewModelLoadAllCommodity, Commodity> commodityService,
            IRepositoryService<CommodityType, ViewModelLoadAllCommodityType,
                CommodityType> commodityTypeService,
            IRepositoryService<Person, ViewModelLoadAllPerson, ViewModelSimpleLoadPerson> personService)
        {
            _commodityService = commodityService;
            _commodityTypeService = commodityTypeService;
            _personService = personService;

            InitializeComponent();

            BindGrid();
            FillDropdownList(rddl_CommodityTypes);
            FillDropdownList(rddl_Receiver);
            ReturnCommodityDetails();
        }

        private async void BindGrid()
        {
            //int? currentUserId = null;
            //if (!await InitialHelper.CurrentUser.IsAdmin())
            //    currentUserId = InitialHelper.CurrentUser.Id;

            rgv_Commodity.BeginUpdate();
            rgv_Commodity.DataSource = await _commodityService.LoadAllViewModelAsync();
            rgv_Commodity.EndUpdate();
            CommonHelper.SortOrderByColumn(rgv_Commodity, "CommodityId", ListSortDirection.Descending);
        }

        private async void FillDropdownList(RadDropDownList ddl)
        {
            switch (ddl.Name)
            {
                case "rddl_CommodityTypes":
                    {
                        ddl.DisplayMember = "CommodityTypeTitle";
                        ddl.ValueMember = "CommodityTypeId";

                        var defaultOption = new ViewModelLoadAllCommodityType()
                        {
                            CommodityTypeId = 0,
                            CommodityTypeTitle = "انتخاب کنید ..."
                        };

                        var commodityTypes = await _commodityTypeService.LoadAllViewModelAsync();
                        commodityTypes.Insert(0, defaultOption);
                        ddl.DataSource = commodityTypes;
                        break;
                    }

                case "rddl_Receiver":
                    {
                        ddl.DisplayMember = "PersonFullName";
                        ddl.ValueMember = "PersonId";

                        var defaultOption = new ViewModelLoadAllPerson()
                        {
                            PersonId = 0,
                            PersonFullName = "انتخاب کنید ..."
                        };

                        var persons = await _personService.LoadAllViewModelAsync();
                        persons.Insert(0, defaultOption);
                        ddl.DataSource = persons;
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
            CommonHelper.InsertAction(_mode, pnl_Data, rgv_Commodity, btnInsert, btnRegister, btnModify,
                btnDelete, btnCancel, btnClose, txt_CommodityDate);

            txt_CommodityDate.Enabled = true;
            var selectedDate = PersianHelper.GetPersiaDateSimple(DateTime.Now);
            txt_CommodityDate.Text = selectedDate;
            txt_CommodityDate.Select();
            txt_CommodityDate.SelectAll();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _mode = CommonHelper.Mode.Cancel;
            CommonHelper.CancelAction(_mode, pnl_Data, rgv_Commodity, btnInsert, btnRegister, btnModify,
                btnDelete, btnCancel, btnClose);

            ReturnCommodityDetails();
        }

        private async void ReturnCommodityDetails()
        {
            try
            {
                if (!(rgv_Commodity.CurrentRow is GridViewDataRowInfo dataRow)) return;

                _commodityId = int.Parse(dataRow.Cells["CommodityId"].Value.ToString());

                rddl_Receiver.SelectedValue = dataRow.Cells["ReceiverId"].Value;
                rddl_CommodityTypes.SelectedValue = dataRow.Cells["CommodityTypeId"].Value;
                txt_CommodityDate.Text = dataRow.Cells["CommodityPersianDate"].Value?.ToString();
                txt_ReceivedBy.Text = dataRow.Cells["ReceivedBy"].Value?.ToString();
                txt_CommodityDescription.Text = dataRow.Cells["Description"].Value?.ToString();
            }
            catch (Exception exception)
            {
                var dlg = new CustomDialogs(400, 200);
                dlg.Invoke("خطا در نمایش اطلاعات", "خطای زیر به وقوع پیوست \n" + exception.Message,
                    CustomDialogs.ImageType.itError2, CustomDialogs.ButtonType.Ok, InitialHelper.BackColorCustom);

                await LoggerService.ErrorAsync(this.Name, "ReturnCommodityDetails",
                    exception.Message, exception.ToDetailedString());
                return;
            }
        }
        private bool ValidateAllControls()
        {
            return CommonHelper.ValidateControls(txt_CommodityDate, _errorProvider,
                       "تاریخ درآمد را وارد نمایید")
                   ||
                   CommonHelper.ValidateControls(txt_ReceivedBy, _errorProvider,
                       "تحویل دهنده را مشخص نمایید")
                   ||
                   CommonHelper.ValidateControls(rddl_CommodityTypes, _errorProvider,
                       "نوع درآمد را مشخص نمایید") ||
                   CommonHelper.ValidateControls(rddl_Receiver, _errorProvider,
                       "تحویل گیرنده را مشخص نمایید");
        }
        private async void btnRegister_Click(object sender, EventArgs e)
        {
            if (ValidateAllControls()) return;

            var dlg = new CustomDialogs(400, 200);

            var commodityTypeId = int.Parse(rddl_CommodityTypes.SelectedItem["CommodityTypeId"].ToString());
            var commodityTypeTitle = rddl_CommodityTypes.Text; 
             var receiverId = int.Parse(rddl_Receiver.SelectedItem["PersonId"].ToString());
            var receivedBy = txt_ReceivedBy.Text;
            var commodityDate = PersianHelper.GetGregorianDate(txt_CommodityDate.Text);
            var description = txt_CommodityDescription.Text;
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

                        var newCommodity = new Commodity(commodityTypeId,
                            receiverId, receivedBy, commodityDate, currentUser.Id,
                            currentDateTime, currentDateTime, description);

                        var status = await _commodityService.CreateAsync(newCommodity);

                        switch (status)
                        {
                            case CreateStatus.Exist:
                                dlg.Invoke("خطای تکرار", "این مشخصات برای دریافتی موردنظر تکراری می باشد",
                                    CustomDialogs.ImageType.itError3,
                                    CustomDialogs.ButtonType.Ok, InitialHelper.BackColorCustom);
                                txt_CommodityDate.Focus();
                                return;
                            case CreateStatus.Failure:
                                dlg.Invoke("بروز خطا", "خطا در ایجاد دریافتی جدید", CustomDialogs.ImageType.itError5,
                                    CustomDialogs.ButtonType.Ok);
                                return;
                            case CreateStatus.Successful:
                                BindGrid();

                                CommonHelper.ShowNotificationMessage("ثبت دریافتی جدید",
                                    $"دریافتی جدیدی با عنوان {commodityTypeTitle} توسط کاربری با عنوان" +
                                    $" {currentUser.UserName} ایجاد گردید.");

                                await LoggerService.InformationAsync(this.Name, "btnRegister_Click(Insert Mode)", 
                                    $"ثبت دریافتی با عنوان {commodityTypeTitle} ",
                                    $" توسط کاربری با نام {currentUser.UserName} انجام گردید.");

                                //CommonHelper.ClearInputControls(this, false, false);
                                txt_CommodityDate.Focus();
                                rgv_Commodity.Enabled = true;
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
                            CommonHelper.ShowNotificationMessage(DefaultConstants.IllegalAccess, DefaultConstants.EditActionNotAllow);
                            return;
                        }
                        //Get Current commodity
                        var currentCommodity = await _commodityService.GetByIdAsync(_commodityId);

                        currentCommodity.CommodityTypeId = commodityTypeId;
                        currentCommodity.ReceivedBy = receivedBy;
                        currentCommodity.ReceiverId = receiverId;
                        currentCommodity.CommodityDate = commodityDate;
                        currentCommodity.UpdateBy = currentUser.Id;
                        currentCommodity.LastUpdate = currentDateTime;
                        currentCommodity.Description = txt_CommodityDescription.Text;

                        await _commodityService.UpdateAsync(currentCommodity);

                        CommonHelper.ShowNotificationMessage("ویرایش دریافتی",
                            $"دریافتی با عنوان {commodityTypeTitle} توسط کاربری با عنوان" +
                            $" {currentUser.UserName} ویرایش گردید.");

                        await LoggerService.InformationAsync(this.Name, "btnRegister_Click(Update mode)", 
                            $"ویرایش دریافتی با عنوان {commodityTypeTitle} ",
                            $"توسط کاربری با نام {currentUser.UserName} انجام گردید.");

                        BindGrid();
                        //CommonHelper.ClearInputControls(this, false, false);
                        txt_CommodityDate.Focus();
                        rgv_Commodity.Enabled = true;
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
            rgv_Commodity.Enabled = true;
            btnRegister.Enabled = false;
            btnClose.Enabled = true;
            _mode = CommonHelper.Mode.None;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (!InitialHelper.HasPermissionFor(this.Name, PermissionMode.Edit))
            {
                CommonHelper.ShowNotificationMessage(DefaultConstants.IllegalAccess, DefaultConstants.DeleteActionNotAllow);
                return;
            }
            _mode = CommonHelper.Mode.Update;
            CommonHelper.ModifyAction(_mode, pnl_Data, rgv_Commodity, btnInsert, btnRegister,
                btnModify, btnDelete, btnCancel, btnClose);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (rgv_Commodity.Rows.Count <= 0) return;

            if (!InitialHelper.HasPermissionFor(this.Name, PermissionMode.Delete))
            {
                CommonHelper.ShowNotificationMessage("عدم دسترسی مجاز",
                    "شما دسترسی لازم برای حذف را ندارید.");
                return;
            }

            var dialog = new CustomDialogs(350, 200);
            dialog.Invoke("هشدار حذف", "آيا واقعا میخواهید این درآمد غیرنقدی را حذف کنید؟",
                CustomDialogs.ImageType.itQuestion2,
                CustomDialogs.ButtonType.YesNo, InitialHelper.BackColorCustom);

            if (!dialog.Yes) return;

            await _commodityService.RemoveAsync(_commodityId);

            CommonHelper.ShowNotificationMessage("پیام",
                $"این دریافتی با شناسه {_commodityId} حذف گردید");

            await LoggerService.InformationAsync(this.Name, "BtnDelete_Click", $"حذف دریافتی با شماره {_commodityId}",
                $"این دریافتی توسط کاربری با نام {InitialHelper.CurrentUser.UserName} حذف گردید.");

            _mode = CommonHelper.Mode.None;
            rgv_Commodity.Enabled = true;
            CommonHelper.EnableControls(pnl_Data, false);

            btnCancel.Enabled = false;
            btnInsert.Enabled = true;
            btnDelete.Enabled = true;

            BindGrid();
        }

        private void rgv_Commodity_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
        {
            ReturnCommodityDetails();
        }

        private void rgv_Commodity_CellClick(object sender, GridViewCellEventArgs e)
        {
            if (rgv_Commodity.Enabled && rgv_Commodity.RowCount > 0)
            { btnModify.Enabled = true; }
            else { btnModify.Enabled = false; }
        }

        private void rgv_Commodity_Click(object sender, EventArgs e)
        {
            ReturnCommodityDetails();
        }

        private void txt_CommodityDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnRegister_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private void txt_CommodityDate_TextChanged(object sender, EventArgs e)
        {
            if (_mode == CommonHelper.Mode.Insert)
            {
                btnRegister.Enabled = (txt_CommodityDate.Text != string.Empty &&
                                       rddl_Receiver.Text != string.Empty && txt_ReceivedBy.Text != string.Empty &&
                                       rddl_CommodityTypes.Text != string.Empty);
            }
        }
    }
}
