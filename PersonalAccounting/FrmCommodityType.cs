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
    public partial class FrmCommodityType : BaseForm
    {
        private readonly IRepositoryService<CommodityType,
            ViewModelLoadAllCommodityType, CommodityType> _commodityTypeService;

        private int _commodityTypeId;

        public static FrmCommodityType AFrmCommodityType = null;
        public static FrmCommodityType Instance()
        {
            return AFrmCommodityType ?? (AFrmCommodityType = IocConfig.Container.GetInstance<FrmCommodityType>());
        }
        public FrmCommodityType(
            IRepositoryService<CommodityType, ViewModelLoadAllCommodityType, CommodityType> commodityTypeService)
        {
            _commodityTypeService = commodityTypeService;

            InitializeComponent();

            BindGrid();
        }

        private async void BindGrid()
        {
            rgv_CommodityType.BeginUpdate();
            rgv_CommodityType.DataSource = await _commodityTypeService.LoadAllViewModelAsync();
            rgv_CommodityType.EndUpdate();
        }
        private bool ValidateAllControls()
        {
            return CommonHelper.ValidateControls(txt_CommodityTypeTitle, _errorProvider,
                " عنوان درآمد  را وارد نمایید");
        }
        private async void ReturnCommodityTypeDetails()
        {
            try
            {
                if (!(rgv_CommodityType.CurrentRow is GridViewDataRowInfo dataRow)) return;

                _commodityTypeId = int.Parse(dataRow.Cells["CommodityTypeId"].Value.ToString());
                txt_CommodityTypeTitle.Text = dataRow.Cells["CommodityTypeTitle"].Value.ToString();
            }
            catch (Exception exception)
            {

                await LoggerService.ErrorAsync(this.Name, "ReturnCommodityTypeDetails", exception.Message,
                    exception.ToDetailedString());
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
            CommonHelper.InsertAction(_mode, pnl_Data, rgv_CommodityType, btnInsert, btnRegister, btnModify,
                btnDelete, btnCancel, btnClose, txt_CommodityTypeTitle);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (!InitialHelper.HasPermissionFor(this.Name, PermissionMode.Edit))
            {
                CommonHelper.ShowNotificationMessage(DefaultConstants.IllegalAccess, DefaultConstants.EditActionNotAllow);
                return;
            }

            _mode = CommonHelper.Mode.Update;
            CommonHelper.ModifyAction(_mode, pnl_Data, rgv_CommodityType, btnInsert, btnRegister,
                btnModify, btnDelete, btnCancel, btnClose);
            _mode = CommonHelper.Mode.Update;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _mode = CommonHelper.Mode.Cancel;
            CommonHelper.CancelAction(_mode, pnl_Data, rgv_CommodityType, btnInsert, btnRegister, btnModify,
                btnDelete, btnCancel, btnClose);

            ReturnCommodityTypeDetails();
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            if (ValidateAllControls()) return;

            var dlg = new CustomDialogs(400, 200);

            var currentUser = InitialHelper.CurrentUser;
            var currentDateTime = InitialHelper.CurrentDateTime;
            var commodityTypeTitle = txt_CommodityTypeTitle.Text;

            switch (_mode)
            {
                case CommonHelper.Mode.Insert:
                    if (!InitialHelper.HasPermissionFor(this.Name, PermissionMode.Add))
                    {
                        CommonHelper.ShowNotificationMessage(DefaultConstants.IllegalAccess, DefaultConstants.CreateActionNotAllow);
                        return;
                    }

                    var newCommodityType = new CommodityType(commodityTypeTitle, currentUser.Id,
                        currentDateTime, currentDateTime);

                    if (await _commodityTypeService.ExistAsync(newCommodityType))
                    {
                        dlg.Invoke("خطای تکرار", "این عنوان کالا تکراری می باشد",
                            CustomDialogs.ImageType.itError3,
                            CustomDialogs.ButtonType.Ok, InitialHelper.BackColorCustom);
                        txt_CommodityTypeTitle.Focus();
                        txt_CommodityTypeTitle.SelectAll();
                        return;
                    }
                    try
                    {
                        await _commodityTypeService.CreateAsync(newCommodityType);
                        BindGrid();

                        CommonHelper.ShowNotificationMessage("ایجاد نوع دریافتی جدید",
                            $"نوع دریافتی با نام {commodityTypeTitle} توسط کاربری با عنوان" +
                            $" {currentUser.UserName} ایجاد گردید.");

                        await LoggerService.InformationAsync(this.Name, "btnRegister_Click(Insert Mode)", 
                            $"ایجاد نوع دریافتی با نام {commodityTypeTitle} ",
                            $"این نوع دریافتی توسط کاربری با نام {currentUser.UserName} ایجاد گردید.");

                        //CommonHelper.ClearInputControls(this, false, false);
                        txt_CommodityTypeTitle.Focus();
                        rgv_CommodityType.Enabled = true;
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


                        await LoggerService.ErrorAsync(this.Name,
                            "btnRegister_Click(Insert mode)", exception.Message,
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

                        var currentCommodityType = await _commodityTypeService.GetByIdAsync(_commodityTypeId);
                        currentCommodityType.Title = commodityTypeTitle;
                        currentCommodityType.UpdateBy = currentUser.Id;
                        currentCommodityType.LastUpdate = currentDateTime;

                        await _commodityTypeService.UpdateAsync(currentCommodityType);


                        CommonHelper.ShowNotificationMessage("ویرایش نوع دریافتی",
                            $"نوع دریافتی با نام {commodityTypeTitle} توسط کاربری با عنوان" +
                            $" {currentUser.UserName} ویرایش گردید.");

                        await LoggerService.InformationAsync(this.Name, "btnRegister_Click(Update Mode)", 
                            $"ویرایش نوع دریافتی با نام {commodityTypeTitle} ",
                            $"این نوع دریافتی توسط کاربری با نام {currentUser.UserName} ویرایش گردید.");

                        //CommonHelper.ClearInputControls(pnl_Data);
                        rgv_CommodityType.Enabled = true;
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
            rgv_CommodityType.Enabled = true;
            btnRegister.Enabled = false;
            btnClose.Enabled = true;
            _mode = CommonHelper.Mode.None;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (!InitialHelper.HasPermissionFor(this.Name, PermissionMode.Delete))
            {
                CommonHelper.ShowNotificationMessage(DefaultConstants.IllegalAccess, DefaultConstants.DeleteActionNotAllow);
                return;
            }

            var dialog = new CustomDialogs(350, 200);
            dialog.Invoke("هشدار حذف", "آيا واقعا میخواهید این نوع درآمد را حذف کنید؟",
                CustomDialogs.ImageType.itQuestion2,
                CustomDialogs.ButtonType.YesNo, InitialHelper.BackColorCustom);

            if (!dialog.Yes) return;

            if (await _commodityTypeService.IsUsedAsync(_commodityTypeId))
            {
                CommonHelper.ShowNotificationMessage("خطا",
                    "نوع درآمد در حال استفاده بوده و حذف نمیشود ");

                return;
            }

            await _commodityTypeService.RemoveAsync(_commodityTypeId);

            CommonHelper.ShowNotificationMessage("پیام", $"نوع دریافتی با شناسه {_commodityTypeId} حذف گردید");
            await LoggerService.InformationAsync(this.Name, "BtnDelete_Click", $"حذف نوع دریافتی ا شماره {_commodityTypeId}",
                $"این نوع دریافتی توسط کاربری با نام {InitialHelper.CurrentUser.UserName} حذف گردید.");

            _mode = CommonHelper.Mode.None;
            rgv_CommodityType.Enabled = true;
            CommonHelper.EnableControls(pnl_Data, false);

            btnCancel.Enabled = false;
            btnInsert.Enabled = true;
            btnDelete.Enabled = true;

            BindGrid();
        }

        private void rgv_CommodityType_CellClick(object sender, GridViewCellEventArgs e)
        {
            if (rgv_CommodityType.Enabled && rgv_CommodityType.RowCount > 0)
            { btnModify.Enabled = true; }
            else { btnModify.Enabled = false; }
        }

        private void rgv_CommodityType_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
        {
            ReturnCommodityTypeDetails();
        }

        private void txt_CommodityTypeTitle_TextChanged(object sender, EventArgs e)
        {
            if (_mode == CommonHelper.Mode.Insert)
            {
                btnRegister.Enabled = (txt_CommodityTypeTitle.Text != string.Empty);
            }
        }

        private void txt_CommodityTypeTitle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && btnRegister.Enabled)
            {
                btnRegister_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private void txt_CommodityTypeTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == (char)Keys.Enter && btnRegister.Enabled)
            //{
            //    btnRegister_Click(sender, e);
            //}
        }
    }
}
