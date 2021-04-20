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
using System.Windows.Forms;
using Telerik.WinControls.Data;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI;

namespace PersonalAccounting.UI
{
    public partial class FrmArticleGroup : BaseForm
    {
        private readonly IRepositoryService<ArticleGroup, ViewModelLoadAllArticleGroup,
            ViewModelSimpleLoadArticleGroup> _articleGroupService;

        private int _articleGroupId;
        private bool _updatingToggleState;
        private readonly Size _customItemSize = new Size(200, 100);

        public static FrmArticleGroup AFrmArticleGroup = null;
        public static FrmArticleGroup Instance()
        {
            return AFrmArticleGroup ?? (AFrmArticleGroup = IocConfig.Container.GetInstance<FrmArticleGroup>());
        }

        public FrmArticleGroup(IRepositoryService<ArticleGroup,
                ViewModelLoadAllArticleGroup, ViewModelSimpleLoadArticleGroup> articleGroupService)
        {
            this._articleGroupService = articleGroupService;

            InitializeComponent();

            //CommonHelper.SetFont(CommonHelper.BaseFont, pnl_Data, rlv_ArticleGroup);
            rddl_ArticleGroupStatus.SetEnableDisableDropdownList();

            SetupSimpleListView();
            rlv_ArticleGroup.ItemSize = _customItemSize;
            rlv_ArticleGroup.ListViewElement.Alignment = ContentAlignment.MiddleCenter;
            BindGrid();
            // RedrawListView();
        }

        private async void BindGrid()
        {
            rlv_ArticleGroup.BeginUpdate();
            //rgv_ArticleGroup.DataSource = _articleGroupService.CustomLoadAllArticleGroups();
            rlv_ArticleGroup.DisplayMember = "ArticleGroupName";
            rlv_ArticleGroup.ValueMember = "ArticleGroupId";
            // if(text == string.Empty)
            rlv_ArticleGroup.DataSource = await _articleGroupService.LoadAllViewModelAsync();
            // else
            //  {
            //     rlv_ArticleGroup.DataSource = _articleGroupService.SearchArticleGroup(text);    
            //  }
            rlv_ArticleGroup.EndUpdate();
        }

        //private void RedrawListView()
        //{
        //    rlv_ArticleGroup.ListViewElement.ViewElement.Alignment = ContentAlignment.MiddleCenter;
        //    rlv_ArticleGroup.ListViewElement.TextAlignment = ContentAlignment.MiddleCenter;
        //    rlv_ArticleGroup.ListViewElement.ViewElement.GradientStyle =
        //        rlv_ArticleGroup.ViewType == ListViewType.IconsView ? GradientStyles.Radial : GradientStyles.Solid;
        //}

        private void SetupDetailsView()
        {
            rlv_ArticleGroup.ItemSize = _customItemSize;
        }

        private void SetupIconsView()
        {
            rlv_ArticleGroup.ItemSize = _customItemSize;
        }

        private void SetupSimpleListView()
        {
            rlv_ArticleGroup.ItemSize = _customItemSize;
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!InitialHelper.HasPermissionFor(this.Name, PermissionMode.Add))
            {
                CommonHelper.ShowNotificationMessage(DefaultConstants.IllegalAccess, DefaultConstants.CreateActionNotAllow);
                return;
            }

            _mode = CommonHelper.Mode.Insert;
            CommonHelper.InsertAction(_mode, pnl_Data, rlv_ArticleGroup, btnInsert, btnRegister, btnModify,
                btnDelete, btnCancel, btnClose, txt_ArticleGroupName);

            rddl_ArticleGroupStatus.SelectedValue = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _mode = CommonHelper.Mode.Cancel;
            CommonHelper.CancelAction(_mode, pnl_Data, rlv_ArticleGroup, btnInsert, btnRegister, btnModify,
                btnDelete, btnCancel, btnClose);

            ReturnArticleGroupDetails();
        }

        private async void ReturnArticleGroupDetails(int agId = 0)
        {
            if (agId <= 0) return;
            try
            {
                _articleGroupId = agId;
                var articleGroup = await _articleGroupService.GetByIdAsync(agId);
                txt_ArticleGroupName.Text = articleGroup.Name;
                txt_ArticleGroupLatinName.Text = articleGroup.LatinName;
                rddl_ArticleGroupStatus.Text = articleGroup.Status;
                txt_ArticleGroupDescription.Text = articleGroup.Description;
            }
            catch (Exception exception)
            {
                await LoggerService.ErrorAsync(this.Name, "ReturnArticleGroupDetails",
                    exception.Message, exception.ToDetailedString());
            }

            // txt_ArticleGroupDescription.Text = rlv_ArticleGroup.Items[1].Value.ToString();
            //var dataRow = rlv_ArticleGroup.CurrentRow as GridViewDataRowInfo;
            //if (dataRow == null) return;
            //_articleGroupId = int.Parse(dataRow.Cells["ArticleGroupId"].Value.ToString());
            //txt_ArticleGroupName.Text = dataRow.Cells["ArticleGroupName"].Value.ToString();
            //txt_ArticleGroupLatinName.Text = dataRow.Cells["ArticleGroupLatinName"].Value.ToString();
            //ddl_ArticleGroupStatus.Text = dataRow.Cells["ArticleGroupStatus"].Value.ToString();
            //txt_ArticleGroupDescription.Text = dataRow.Cells["ArticleGroupDescription"].Value.ToString();
        }
        private bool ValidateAllControls()
        {
            return CommonHelper.ValidateControls(txt_ArticleGroupName, _errorProvider, "عنوان گروه را مشخص نمایید")
                   || CommonHelper.ValidateControls(rddl_ArticleGroupStatus, _errorProvider, "وضعیت گروه را مشخص نمایید");
        }
        private async void btnRegister_Click(object sender, EventArgs e)
        {
            if (ValidateAllControls()) return;

            var dlg = new CustomDialogs(400, 200);

            var articleGroupStatus = rddl_ArticleGroupStatus.Text;
            var currentUser = InitialHelper.CurrentUser;
            var currentDateTime = InitialHelper.CurrentDateTime;
            var articleGroupName = txt_ArticleGroupName.Text;

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

                        var newArticleGroup =
                            new ArticleGroup(articleGroupName, txt_ArticleGroupLatinName.Text,
                           currentUser.Id, currentDateTime, currentDateTime,
                           txt_ArticleGroupDescription.Text, articleGroupStatus);

                        var status = await _articleGroupService.CreateAsync(newArticleGroup);

                        switch (status)
                        {
                            case CreateStatus.Exist:
                                dlg.Invoke("خطای تکرار", "این عنوان گروه تکراری می باشد",
                                    CustomDialogs.ImageType.itError3,
                                    CustomDialogs.ButtonType.Ok, InitialHelper.BackColorCustom);
                                txt_ArticleGroupName.Focus();
                                txt_ArticleGroupName.SelectAll();
                                return;
                            case CreateStatus.Failure:
                                dlg.Invoke("بروز خطا", "خطا در ایجاد دسته جدید", CustomDialogs.ImageType.itError5,
                                    CustomDialogs.ButtonType.Ok);
                                return;
                            case CreateStatus.Successful:
                                BindGrid();

                                CommonHelper.ShowNotificationMessage("ایجاد دسته جدید",
                                    $"دسته کالا با نام {articleGroupName} توسط کاربری با عنوان" +
                                    $" {currentUser.UserName} ایجاد گردید.");

                                await LoggerService.InformationAsync(this.Name, "btnRegister_Click(Insert Mode)",
                                    $"ایجاد دسته کالا با نام {articleGroupName} ",
                                    $"این دسته کالا توسط کاربری با نام {currentUser.UserName} ایجاد گردید.");

                                //CommonHelper.ClearInputControls(this);
                                txt_ArticleGroupName.Focus();
                                rlv_ArticleGroup.Enabled = true;
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

                        var currentArticleGroup = await _articleGroupService.GetByIdAsync(_articleGroupId);

                        currentArticleGroup.Name = articleGroupName;
                        currentArticleGroup.LatinName = txt_ArticleGroupLatinName.Text;
                        currentArticleGroup.UpdateBy = currentUser.Id;
                        currentArticleGroup.LastUpdate = currentDateTime;
                        currentArticleGroup.Status = articleGroupStatus;
                        currentArticleGroup.Description = txt_ArticleGroupDescription.Text;

                        await _articleGroupService.UpdateAsync(currentArticleGroup);

                        CommonHelper.ShowNotificationMessage("ویرایش دسته کالا",
                            $"دسته کالا با نام {articleGroupName} توسط کاربری با عنوان" +
                            $" {currentUser.UserName} ویرایش گردید.");

                        await LoggerService.InformationAsync(this.Name, "btnRegister_Click(Update Mode)",
                            $"ویرایش دسته کالا با نام {articleGroupName} ",
                            $"این دسته کالا توسط کاربری با نام {currentUser.UserName} ویرایش گردید.");

                        //CommonHelper.ClearInputControls(pnl_Data);
                        rlv_ArticleGroup.Enabled = true;
                        CommonHelper.EnableControls(pnl_Data, false);
                        btnCancel.Enabled = false;
                        btnInsert.Enabled = true;
                        btnDelete.Enabled = true;
                        BindGrid();
                    }
                    catch (Exception exception)
                    {
                        dlg.Invoke("خطا در ثبت اطلاعات",
                            "خطای زیر به وقوع پیوست \n" + exception.ToDetailedString(),
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
            rlv_ArticleGroup.Enabled = true;
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
            CommonHelper.ModifyAction(_mode, pnl_Data, rlv_ArticleGroup, btnInsert, btnRegister,
                btnModify, btnDelete, btnCancel, btnClose);
            _mode = CommonHelper.Mode.Update;
        }

        private void txt_ArticleGroupName_TextChanged(object sender, EventArgs e)
        {
            if (_mode == CommonHelper.Mode.Insert)
            {
                btnRegister.Enabled = (txt_ArticleGroupName.Text != String.Empty);
            }
        }

        //private void rgv_ArticleGroup_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
        //{
        //    ReturnArticleGroupDetails();
        //}

        //private void rgv_ArticleGroup_CellClick(object sender, GridViewCellEventArgs e)
        //{
        //    if (rlv_ArticleGroup.Enabled && rlv_ArticleGroup.Items.Count > 0)
        //    { btnModify.Enabled = true; }
        //    else { btnModify.Enabled = false; }
        //}

        private void rlv_ArticleGroup_ViewTypeChanged(object sender, EventArgs e)
        {
            switch (rlv_ArticleGroup.ViewType)
            {
                case ListViewType.ListView:
                    SetupSimpleListView();
                    break;
                case ListViewType.IconsView:
                    SetupIconsView();
                    break;
                case ListViewType.DetailsView:
                    SetupDetailsView();
                    break;
            }
        }
        private void ViewToggleButton_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            //RedrawListView();
            if (_updatingToggleState)
            {
                return;
            }
            this._updatingToggleState = true;

            if (this.cbtb_DetailsView != sender)
            {
                this.cbtb_DetailsView.ToggleState = ToggleState.Off;
            }
            if (this.cbtb_ListView != sender)
            {
                this.cbtb_ListView.ToggleState = ToggleState.Off;
            }
            if (this.cbtb_IconsView != sender)
            {
                this.cbtb_IconsView.ToggleState = ToggleState.Off;
            }
            this._updatingToggleState = false;

            if (this.cbtb_DetailsView.ToggleState == ToggleState.On)
            {
                this.rlv_ArticleGroup.ViewType = ListViewType.DetailsView;
            }
            if (this.cbtb_ListView.ToggleState == ToggleState.On)
            {
                this.rlv_ArticleGroup.ViewType = ListViewType.ListView;
            }
            if (this.cbtb_IconsView.ToggleState == ToggleState.On)
            {
                this.rlv_ArticleGroup.ViewType = ListViewType.IconsView;
            }
        }

        private void ViewToggleButton_ToggleStateChanging(object sender, StateChangingEventArgs args)
        {
            if (!_updatingToggleState && args.OldValue == ToggleState.On)
            {
                args.Cancel = true;
            }
        }

        private void ctb_Search_TextChanged(object sender, EventArgs e)
        {
            //rlv_ArticleGroup.DataSource = _articleGroupService.SearchArticleGroup(ctb_Search.Text);
            //BindGrid(ctb_Search.Text);
            this.rlv_ArticleGroup.FilterDescriptors.Clear();

            if (string.IsNullOrEmpty(ctb_Search.Text))
            {
                this.rlv_ArticleGroup.EnableFiltering = false;
            }
            else
            {
                rlv_ArticleGroup.FilterDescriptors.LogicalOperator = FilterLogicalOperator.Or;
                //                rlv_ArticleGroup.FilterDescriptors.Add("ArticleGroupId", FilterOperator.Contains, ctb_Search.Text);
                rlv_ArticleGroup.FilterDescriptors.Add("ArticleGroupName", FilterOperator.Contains, ctb_Search.Text);
                rlv_ArticleGroup.FilterDescriptors.Add("ArticleGroupLatinName", FilterOperator.Contains, ctb_Search.Text);
                rlv_ArticleGroup.FilterDescriptors.Add("ArticleGroupCreationUserName", FilterOperator.Contains, ctb_Search.Text);
                rlv_ArticleGroup.FilterDescriptors.Add("ArticleGroupStatus", FilterOperator.Contains, ctb_Search.Text);
                rlv_ArticleGroup.FilterDescriptors.Add("ArticleGroupPersianRegisterDate", FilterOperator.Contains, ctb_Search.Text);
                rlv_ArticleGroup.FilterDescriptors.Add("ArticleGroupDescription", FilterOperator.Contains, ctb_Search.Text);
                rlv_ArticleGroup.EnableFiltering = true;
            }
        }

        private void rlv_ArticleGroup_CurrentItemChanged(object sender, ListViewItemEventArgs e)
        {
            ReturnArticleGroupDetails(int.Parse(e.Item.Value.ToString()));
        }

        private void rlv_ArticleGroup_Click(object sender, EventArgs e)
        {
            if (rlv_ArticleGroup.Enabled && rlv_ArticleGroup.Items.Count > 0)
            { btnModify.Enabled = true; }
            else { btnModify.Enabled = false; }
        }

        private void rlv_ArticleGroup_ItemMouseClick(object sender, ListViewItemEventArgs e)
        {
            ReturnArticleGroupDetails(int.Parse(e.Item.Value.ToString()));
        }

        private void rlv_ArticleGroup_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            e.Item.ImageIndex = 0;
            e.Item.TextAlignment = ContentAlignment.MiddleCenter;
            e.Item.ImageAlignment = ContentAlignment.MiddleLeft;
            //if (e.ListViewElement.ViewType == ListViewType.IconsView) 
            //    e.Item.GradientStyle = GradientStyles.Solid;
            // e.Item.Font = new Font("Tahoma", 10, FontStyle.Regular);
        }

        private void rlv_ArticleGroup_ColumnCreating(object sender, ListViewColumnCreatingEventArgs e)
        {
            if (e.Column.FieldName == "ArticleGroupName") { e.Column.HeaderText = "عنوان گروه"; }
            if (e.Column.FieldName == "ArticleGroupLatinName") { e.Column.HeaderText = "نام لاتین"; }
            if (e.Column.FieldName == "ArticleGroupCreationUserName") { e.Column.HeaderText = "کاربر ثبت کننده"; }
            if (e.Column.FieldName == "ArticleGroupStatus") { e.Column.HeaderText = "وضعیت"; }
            if (e.Column.FieldName == "ArticleGroupPersianRegisterDate") { e.Column.HeaderText = "تاریخ ثبت"; }
            if (e.Column.FieldName == "ArticleGroupPersianLastUpdate") { e.Column.HeaderText = "تاریخ ویرایش"; }
            if (e.Column.FieldName == "ArticleGroupDescription") { e.Column.HeaderText = "توضیحات"; }
            if (e.Column.FieldName == "ArticleGroupId"
                || e.Column.FieldName == "ArticleGroupCreationDate"
                || e.Column.FieldName == "ArticleGroupLastUpdate")
                e.Column.Visible = false;
        }

        private void Txt_ArticleGroupName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnRegister_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
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
            dialog.Invoke("هشدار حذف", "آيا واقعا میخواهید این کالا را حذف کنید؟",
                CustomDialogs.ImageType.itQuestion2,
                CustomDialogs.ButtonType.YesNo, InitialHelper.BackColorCustom);

            if (!dialog.Yes) return;

            var articleGroupId = int.Parse(rlv_ArticleGroup.SelectedItem.Value.ToString());

            if (await _articleGroupService.IsUsedAsync(articleGroupId))
            {
                CommonHelper.ShowNotificationMessage("خطا",
                    "گروه کالا در حال استفاده بوده و حذف نمیشود ");

                return;
            }

            await _articleGroupService.RemoveAsync(articleGroupId);

            CommonHelper.ShowNotificationMessage("پیام", $"دسته کالا با شناسه {articleGroupId} حذف گردید");

            await LoggerService.InformationAsync(this.Name, "BtnDelete_Click", $"حذف دسته کالا شماره {articleGroupId}",
                $"این دسته کالا توسط کاربری با نام {InitialHelper.CurrentUser.UserName} حذف گردید.");

            _mode = CommonHelper.Mode.None;
            rlv_ArticleGroup.Enabled = true;
            CommonHelper.EnableControls(pnl_Data, false);

            btnCancel.Enabled = false;
            btnInsert.Enabled = true;
            btnDelete.Enabled = true;

            BindGrid();
        }
    }
}