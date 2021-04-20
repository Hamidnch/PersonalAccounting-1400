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
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI;

namespace PersonalAccounting.UI
{
    public partial class FrmArticle : BaseForm
    {
        private readonly IRepositoryService<ArticleGroup, ViewModelLoadAllArticleGroup,
            ViewModelSimpleLoadArticleGroup> _articleGroupService;
        private readonly IRepositoryService<Article, ViewModelLoadAllArticle,
            ViewModelSimpleLoadArticle> _articleService;
        private readonly IMeasurementUnitService _measurementUnitService;

        private readonly BackgroundWorker _backgroundWorker;

        private bool _updatingToggleState;
        private readonly Size _customItemSize = new Size(200, 100);

        private object _ds;
        private readonly RadGridView _rgv;
        private readonly Button _btn;
        private List<string> _fileNames;
        private List<string> _headerTexts;
        private List<int> _columnWidths;
        private List<bool> _visibleFields;
        private readonly Panel _pnlFloating;

        public static FrmArticle AFrmArticle = null;
        public static FrmArticle Instance()
        {
            return AFrmArticle ?? (AFrmArticle = IocConfig.Container.GetInstance<FrmArticle>());
        }

        public FrmArticle(IRepositoryService<ArticleGroup, ViewModelLoadAllArticleGroup,
                ViewModelSimpleLoadArticleGroup> articleGroupService,
            IRepositoryService<Article, ViewModelLoadAllArticle, ViewModelSimpleLoadArticle> articleService,
            IMeasurementUnitService measurementUnitService)
        {
            _articleGroupService = articleGroupService;
            _articleService = articleService;
            _measurementUnitService = measurementUnitService;

            InitializeComponent();

            //CommonHelper.SetFont(CommonHelper.BaseFont, pnl_Data, rgv_ArticleGroup,
            //    rlv_Article, expandPanel, radCommandBar1);
            _backgroundWorker = new BackgroundWorker();
            _backgroundWorker.DoWork += _backgroundWorker_DoWork;
            _backgroundWorker.RunWorkerCompleted += _backgroundWorker_RunWorkerCompleted;

            _rgv = new RadGridView();
            _btn = new Button();
            _pnlFloating = new Panel();
            _btn.Click += btn_Click;

            BindGrid();
            //BindListViewArticleByArticleGroupId(GetSelectedArticleGroupId());

            SetupSimpleListView();
            rlv_Article.ItemSize = _customItemSize;
            rlv_Article.ListViewElement.Alignment = ContentAlignment.MiddleCenter;
            rlv_Article.ListViewElement.TextAlignment = ContentAlignment.MiddleCenter;

            rddl_ArticleStatus.SetEnableDisableStatusDropdownList();
            //multiColumnCombo1.DisplayMember = "MeasurementUnitName";
            //multiColumnCombo1.ValueMember = "MeasurementUnitId";
            //multiColumnCombo1.DataSource = _measurementUnitService.GetMeasurementUnitNames();
        }

        private void FrmArticle_Load(object sender, EventArgs e)
        {
            BindAndReturnArticleValues();
        }

        private void _backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            _rgv.BeginUpdate();

            CommonHelper.GenerateParentPanel(_pnlFloating, BorderStyle.FixedSingle, 450, 280, this);
            CommonHelper.GenerateGridView(_rgv, _fileNames, _headerTexts, _columnWidths, _visibleFields);

            _rgv.ReadOnly = false;
            _rgv.Columns[0].ReadOnly = true;
            //_rgv.Columns[1].ReadOnly = true;
            GridViewDataColumn cell = new GridViewCheckBoxColumn("Select");
            cell.HeaderText = "--";
            cell.TextAlignment = ContentAlignment.MiddleCenter;
            _rgv.Columns.Add(cell);
            //_rgv.MultiSelect = true;
            _pnlFloating.Controls.Add(_rgv);
            _btn.Text = "انتخاب";
            _btn.Dock = DockStyle.Bottom;
            _pnlFloating.Controls.Add(_btn);
            _pnlFloating.Location = new Point(pnl_Data.Width / 2, pnl_Data.Height / 2);
            //new Point(rlv_Article.Width / 2, rlv_Article.Height / 2);//new Point((racb_MeasurementUnits.Width / 2) - (_pnlFloating.Width / 2), ((racb_MeasurementUnits.Height / 2) - (_pnlFloating.Width / 5)));
            _pnlFloating.Visible = true;//!_pnlFloating.Visible;
            _rgv.DataSource = _ds;

            var selectedMeasurementUnits = racb_MeasurementUnits.Items.Select(item => item.Text).ToList();
            if (selectedMeasurementUnits.Count > 0)
            {
                foreach (var currentRow in from currentRow in _rgv.Rows
                                           from item in selectedMeasurementUnits
                                           where currentRow.Cells[0].Value.ToString() == item
                                           select currentRow)
                {
                    currentRow.Cells[1].Value = "True";
                }
            }
            _pnlFloating.BringToFront();
            _rgv.Focus();
            _rgv.TableElement.ViewInfo.TableFilteringRow.Cells[0].BeginEdit();

            _rgv.EndUpdate();
            _backgroundWorker.Dispose();
            CommonHelper.IndicatorLoading(_picLoading);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            racb_MeasurementUnits.Clear();
            foreach (var currentRow in _rgv.Rows.Where(
                currentRow => currentRow.Cells[1].Value != null && currentRow.Cells[1].Value.ToString() == "True"))
            {
                racb_MeasurementUnits.AppendText(currentRow.Cells[0].Value + ";");
            }
            _rgv.DataSource = null;
            _pnlFloating.Visible = false;
        }

        private async void _backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            _fileNames = new List<string>();
            _headerTexts = new List<string>();
            _columnWidths = new List<int>();
            _visibleFields = new List<bool>();
            _fileNames.AddRange(new string[] { "MeasurementUnitName" }); //"MeasurementUnitId",
            _headerTexts.AddRange(new string[] { "واحد سنجش" }); //"شناسه",
            _columnWidths.AddRange(new int[] { 167 }); //84, 
            _visibleFields.AddRange(new bool[] { true }); //true,
            _ds = await _measurementUnitService.SimpleLoadViewModelAsync();
        }

        private async void BindGrid()
        {
            rgv_ArticleGroup.BeginUpdate();
            rgv_ArticleGroup.DataSource = await _articleGroupService.SimpleLoadViewModelAsync();
            rgv_ArticleGroup.EndUpdate();
        }

        private int GetSelectedArticleGroupId()
        {
            if (rgv_ArticleGroup.CurrentRow is GridViewDataRowInfo dataRow)
                return int.Parse(dataRow.Cells["ArticleGroupId"].Value.ToString());
            return -1;
        }

        private async void GetListViewArticleByArticleGroupId(int articleGroupId = -1)
        {
            rlv_Article.BeginUpdate();

            rlv_Article.DisplayMember = "ArticleName";
            rlv_Article.ValueMember = "ArticleId";
            rlv_Article.DataSource = articleGroupId == -1 ?
               await _articleService.LoadAllViewModelAsync() :
                await _articleService.GetByGroupIdAsync(articleGroupId);

            rlv_Article.EndUpdate();
            //rlv_Article.Focus();
        }

        private void BindAndReturnArticleValues(int articleGroupId = -1)
        {
            if (_mode == CommonHelper.Mode.Update) return;

            if (articleGroupId == -1) articleGroupId = GetSelectedArticleGroupId();

            GetListViewArticleByArticleGroupId(articleGroupId);

            if (rlv_Article.Items.Count > 0)
            {
                rlv_Article.SelectedIndex = 0;
                ReturnArticleDetails(int.Parse(rlv_Article.SelectedItem.Value.ToString()));
            }
            else
            {
                //ReturnArticleDetails();
                CommonHelper.ClearInputControls(pnl_Data);
            }
            //_articleId = -1;

            btnModify.Enabled = false;
            btnDelete.Enabled = false;
        }
        private void rgv_ArticleGroup_CellClick(object sender, GridViewCellEventArgs e)
        {
            BindAndReturnArticleValues();
        }
        private void rgv_ArticleGroup_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
        {
            BindAndReturnArticleValues();
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!InitialHelper.HasPermissionFor(this.Name, PermissionMode.Add))
            {
                CommonHelper.ShowNotificationMessage(DefaultConstants.IllegalAccess, DefaultConstants.CreateActionNotAllow);
                return;
            }

            _mode = CommonHelper.Mode.Insert;
            CommonHelper.InsertAction(_mode, pnl_Data, rlv_Article, btnInsert, btnRegister, btnModify,
                btnDelete, btnCancel, btnClose, null);

            rddl_ArticleStatus.SelectedValue = 0;
            txt_ArticleName.Focus();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (!InitialHelper.HasPermissionFor(this.Name, PermissionMode.Edit))
            {
                CommonHelper.ShowNotificationMessage(DefaultConstants.IllegalAccess, DefaultConstants.EditActionNotAllow);
                return;
            }

            CommonHelper.ModifyAction(_mode, pnl_Data, rlv_Article, btnInsert, btnRegister,
                btnModify, btnDelete, btnCancel, btnClose);
            _mode = CommonHelper.Mode.Update;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _mode = CommonHelper.Mode.Cancel;
            CommonHelper.CancelAction(_mode, pnl_Data, rlv_Article, btnInsert, btnRegister, btnModify,
                btnDelete, btnCancel, btnClose);

            ReturnArticleDetails();
        }

        private async void ReturnArticleDetails(int articleId = 0)
        {
            if (_mode == CommonHelper.Mode.Insert) return;
            try
            {
                //_articleId = articleId;
                var article = await _articleService.GetByIdAsync(articleId);

                if (article == null) return;

                txt_ArticleName.Text = article.Name;
                txt_ArticleLatinName.Text = article.LatinName;
                txt_ArticleId.Text = articleId.ToString(CultureInfo.InvariantCulture);
                rddl_ArticleStatus.Text = article.Status;
                txt_ArticleDescription.Text = article.Description;

                var mus = await _measurementUnitService.GetByArticleAsync(article.Name);

                racb_MeasurementUnits.Clear();
                foreach (var item in mus)
                {
                    racb_MeasurementUnits.Insert(item + ";");
                }
            }
            catch (Exception exception)
            {
                var dlg = new CustomDialogs(400, 200);
                dlg.Invoke("خطا در نمایش اطلاعات", "خطای زیر به وقوع پیوست \n" + exception.Message,
                    CustomDialogs.ImageType.itError2, CustomDialogs.ButtonType.Ok, InitialHelper.BackColorCustom);

                await LoggerService.ErrorAsync(this.Name, "ReturnArticleDetails",
                    exception.Message, exception.ToDetailedString());
            }
        }


        private bool ValidateAllControls()
        {
            return CommonHelper.ValidateControls(txt_ArticleName, _errorProvider, "نام کالا را وارد نمایید")
                   || CommonHelper.ValidateControls(rddl_ArticleStatus, _errorProvider, "وضعیت کالا را مشخص کنید");
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            if (ValidateAllControls()) return;

            var dlg = new CustomDialogs(400, 200);

            var articleGroupId = GetSelectedArticleGroupId();
            var articleStatus = rddl_ArticleStatus.Text;
            var currentUser = InitialHelper.CurrentUser;
            var currentDateTime = InitialHelper.CurrentDateTime;
            var articleName = txt_ArticleName.Text;

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

                        var newArticle = new Article(articleName, txt_ArticleLatinName.Text, articleGroupId,
                            currentUser.Id, articleStatus, currentDateTime, currentDateTime,
                            txt_ArticleDescription.Text, null);

                        var status = await _articleService.CreateAsync(newArticle);

                        //if (newArticle.MeasurementUnits == null)
                        //    newArticle.MeasurementUnits = new Collection<MeasurementUnit>();

                        switch (status)
                        {
                            case CreateStatus.Exist:
                                dlg.Invoke("خطای تکرار", "این نام کالا تکراری می باشد", CustomDialogs.ImageType.itError3,
                                    CustomDialogs.ButtonType.Ok, InitialHelper.BackColorCustom);
                                txt_ArticleName.Focus();
                                txt_ArticleName.Select();
                                return;
                            case CreateStatus.Failure:
                                dlg.Invoke("بروز خطا", "خطا در ایجاد کالای جدید", CustomDialogs.ImageType.itError5,
                                    CustomDialogs.ButtonType.Ok);
                                return;
                            case CreateStatus.Successful:
                                //articleGroupId = GetSelectedArticleGroupId();
                                //GetListViewArticleByArticleGroupId(articleGroupId);
                                BindAndReturnArticleValues();
                                //Start AddSelectedMeasurementUnitToNewArticle
                                var selectedMeasurementUnits =
                                    racb_MeasurementUnits.Items.Select(item => item.Text).ToList();
                                if (selectedMeasurementUnits.Count > 0)
                                    await _measurementUnitService.AssignToArticleAsync(
                                        newArticle.Id, selectedMeasurementUnits);
                                //End AddSelectedMeasurementUnitToNewArticle

                                CommonHelper.ShowNotificationMessage("ایجاد کالای جدید",
                                    $"کالا با نام {articleName} توسط کاربری با عنوان" +
                                    $" {currentUser.UserName} ایجاد گردید.");

                                await LoggerService.InformationAsync(this.Name, "btnRegister_Click(Insert Mode)",
                                    $"ایجاد کالا با نام {articleName} ",
                                    $"توسط کاربری با نام {InitialHelper.CurrentUser.UserName} انجام گردید.");

                                //CommonHelper.ClearInputControls(this);
                                txt_ArticleName.Focus();
                                rlv_Article.Enabled = true;
                                CommonHelper.EnableControls(pnl_Data, false);
                                btnCancel.Enabled = false;
                                btnInsert.Enabled = true;
                                btnDelete.Enabled = true;
                                BindGrid();
                                //ReturnArticleDetails(newArticle.Id);

                                break;
                            default:
                                throw new ArgumentOutOfRangeException();
                        }

                    }
                    catch (Exception exception)
                    {
                        dlg.Invoke("خطا در ثبت اطلاعات", "خطای زیر به وقوع پیوست \n" + exception.Message,
                            CustomDialogs.ImageType.itError2, CustomDialogs.ButtonType.Ok, InitialHelper.BackColorCustom);

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

                        var currentArticle = await _articleService.GetByIdAsync(int.Parse(txt_ArticleId.Text));

                        currentArticle.Name = txt_ArticleName.Text;
                        currentArticle.LatinName = txt_ArticleLatinName.Text;
                        currentArticle.GroupId = articleGroupId;
                        currentArticle.UpdateBy = currentUser.Id;
                        currentArticle.LastUpdate = currentDateTime;
                        currentArticle.Status = articleStatus;
                        currentArticle.Description = txt_ArticleDescription.Text;

                        await _articleService.UpdateAsync(currentArticle);

                        //Start UpdateSelectedMeasurementUnitToNewArticle
                        await _measurementUnitService.RemoveFromArticleAsync(currentArticle.Name);
                        var selectedMeasurementUnits = racb_MeasurementUnits.Items.Select(item => item.Text).ToList();
                        if (selectedMeasurementUnits.Count > 0)
                            await _measurementUnitService.AssignToArticleAsync(currentArticle.Id,
                                selectedMeasurementUnits);
                        //End UpdateSelectedMeasurementUnitToNewArticle

                        CommonHelper.ShowNotificationMessage("ویرایش کالا",
                            $"کالا با نام {articleName} توسط کاربری با عنوان" +
                            $" {currentUser.UserName} ویرایش گردید.");

                        await LoggerService.InformationAsync(this.Name, "btnRegister_Click(Update Mode)",
                            $"ویرایش کالا با نام {articleName} ",
                            $"این کالا توسط کاربری با نام {currentUser.UserName} ویرایش گردید.");

                        //CommonHelper.ClearInputControls(pnl_Data);
                        //GetListViewArticleByArticleGroupId(articleGroupId);
                        BindAndReturnArticleValues();

                        rlv_Article.Enabled = true;
                        CommonHelper.EnableControls(pnl_Data, false);
                        btnCancel.Enabled = false;
                        btnInsert.Enabled = true;
                        btnDelete.Enabled = true;

                        //ReturnArticleDetails(currentArticle.Id);
                    }
                    catch (Exception exception)
                    {
                        dlg.Invoke("خطا در ثبت اطلاعات", "خطای زیر به وقوع پیوست \n" + exception.Message,
                            CustomDialogs.ImageType.itError2, CustomDialogs.ButtonType.Ok, InitialHelper.BackColorCustom);

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
            rlv_Article.Enabled = true;
            btnRegister.Enabled = false;
            btnClose.Enabled = true;

            _mode = CommonHelper.Mode.None;
        }

        private void rlv_Article_Click(object sender, EventArgs e)
        {
            if (rlv_Article.Enabled && rlv_Article.Items.Count > 0)
            {
                if (rlv_Article.SelectedItem?.Value == null) return;

                ReturnArticleDetails(int.Parse(rlv_Article.SelectedItem.Value.ToString()));

                btnModify.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
            {
                btnModify.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void rlv_Article_ItemMouseClick(object sender, ListViewItemEventArgs e)
        {
            ReturnArticleDetails(int.Parse(e.Item.Value.ToString()));
            btnModify.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void txt_ArticleName_TextChanged(object sender, EventArgs e)
        {
            if (_mode == CommonHelper.Mode.Insert)
            {
                btnRegister.Enabled = (txt_ArticleName.Text != string.Empty);
            }
        }

        private void rlv_Article_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            e.Item.ImageIndex = 0;
            e.Item.TextAlignment = ContentAlignment.MiddleCenter;
            e.Item.TextImageRelation = TextImageRelation.ImageBeforeText;

            if (rlv_Article.ViewType == ListViewType.IconsView) return;
            e.Item.GradientStyle = GradientStyles.Solid;

        }

        private void SetupDetailsView()
        {
            rlv_Article.ItemSize = _customItemSize;
        }

        private void SetupIconsView()
        {
            rlv_Article.ItemSize = _customItemSize;
        }

        private void SetupSimpleListView()
        {
            rlv_Article.ItemSize = _customItemSize;
        }

        private void rlv_Article_ViewTypeChanged(object sender, EventArgs e)
        {
            switch (rlv_Article.ViewType)
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
                default:
                    SetupSimpleListView();
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
                this.rlv_Article.ViewType = ListViewType.DetailsView;
            }
            if (this.cbtb_ListView.ToggleState == ToggleState.On)
            {
                this.rlv_Article.ViewType = ListViewType.ListView;
            }
            if (this.cbtb_IconsView.ToggleState == ToggleState.On)
            {
                this.rlv_Article.ViewType = ListViewType.IconsView;
            }
        }

        private void commandBarToggleButton1_ToggleStateChanging(object sender, StateChangingEventArgs args)
        {
            if (!_updatingToggleState && args.OldValue == ToggleState.On)
            {
                args.Cancel = true;
            }
        }

        private void rlv_Article_ColumnCreating(object sender, ListViewColumnCreatingEventArgs e)
        {
            switch (e.Column.FieldName)
            {
                case "ArticleName":
                    e.Column.HeaderText = "نام کالا";
                    break;
                case "ArticleLatinName":
                    e.Column.HeaderText = "نام لاتین";
                    break;
                case "ArticleCreationUserName":
                    e.Column.HeaderText = "کاربر ثبت کننده";
                    break;
                case "ArticleStatus":
                    e.Column.HeaderText = "وضعیت";
                    break;
                case "ArticlePersianRegisterDate":
                    e.Column.HeaderText = "تاریخ ثبت";
                    break;
                case "ArticlePersianLastUpdate":
                    e.Column.HeaderText = "تاریخ ویرایش";
                    break;
                case "ArticleDescription":
                    e.Column.HeaderText = "توضیحات";
                    break;
                case "ArticleId":
                case "ArticleGroupName":
                case "ArticleCreationDate":
                case "ArticleLastUpdate":
                    e.Column.Visible = false;
                    break;
            }
        }

        private void cbtb_Search_TextChanged(object sender, EventArgs e)
        {
            rgv_ArticleGroup.CurrentRow = rgv_ArticleGroup.Rows[0];
            rlv_Article.FilterDescriptors.Clear();

            if (string.IsNullOrEmpty(cbtb_Search.Text))
            {
                this.rlv_Article.EnableFiltering = false;
            }
            else
            {
                //GetListViewArticleByArticleGroupId();
                BindAndReturnArticleValues();

                rlv_Article.FilterDescriptors.LogicalOperator = FilterLogicalOperator.Or;
                rlv_Article.FilterDescriptors.Add("ArticleName", FilterOperator.Contains, cbtb_Search.Text);
                rlv_Article.FilterDescriptors.Add("ArticleLatinName", FilterOperator.Contains, cbtb_Search.Text);
                rlv_Article.FilterDescriptors.Add("ArticleCreationUserName", FilterOperator.Contains, cbtb_Search.Text);
                rlv_Article.FilterDescriptors.Add("ArticleStatus", FilterOperator.Contains, cbtb_Search.Text);
                rlv_Article.FilterDescriptors.Add("ArticlePersianRegisterDate", FilterOperator.Contains, cbtb_Search.Text);
                rlv_Article.FilterDescriptors.Add("ArticleDescription", FilterOperator.Contains, cbtb_Search.Text);
                rlv_Article.EnableFiltering = true;
            }
        }

        private void rlv_Article_CellFormatting(object sender, ListViewCellFormattingEventArgs e)
        {
            //if (e.CellElement is DetailListViewHeaderCellElement)
            //{
            //    return;
            //}
            //if (e.CellElement.Data.HeaderText == "ArticleName")
            //{
            //    //e.CellElement.Text = "";
            //    e.CellElement.ImageAlignment = ContentAlignment.MiddleCenter;
            //    e.CellElement.TextImageRelation = TextImageRelation.Overlay;
            //}
            //else
            //{
            //    e.CellElement.Image = null;
            //}
            //if (e.CellElement.Data.HeaderText == "ArticleCreationUserNme" || e.CellElement.Data.HeaderText == "Model")
            //{
            //}
            //if (this.rlv_Article.ThemeName == "HighContrastBlack" ||
            //    this.rlv_Article.ThemeName == "VisualStudio2012Dark")
            //{
            //    e.CellElement.Text = "" + e.CellElement.Text + "";
            //}
            //else
            //{
            //    e.CellElement.Text = "" + e.CellElement.Text + "";
            //}
        }

        private void rlv_Article_VisualItemFormatting(object sender, ListViewVisualItemEventArgs e)
        {
            if (e.VisualItem is BaseListViewGroupVisualItem) { return; }

            e.VisualItem.Alignment = ContentAlignment.MiddleCenter;
            e.VisualItem.TextAlignment = ContentAlignment.MiddleCenter;

            //if (this.rlv_Article.ViewType == ListViewType.IconsView)
            //{
            //    e.VisualItem.GradientStyle = GradientStyles.Solid;
            //    //e.VisualItem.ImageLayout = ImageLayout.Center;
            //    //e.VisualItem.ImageAlignment = ContentAlignment.MiddleCenter;
            //}
            //if (this.rlv_Article.ViewType == ListViewType.ListView)
            //{
            //    e.VisualItem.GradientStyle = GradientStyles.Solid;
            //}
            //if (this.rlv_Article.ViewType == ListViewType.DetailsView)
            //{
            //    e.VisualItem.GradientStyle = GradientStyles.Solid;
            //    //e.VisualItem.Padding = new Padding(5, 5, 0, 5);
            //   // e.VisualItem.Layout.LeftPart.Margin = new Padding(0, 0, 5, 0);
            //}
        }

        private void rlv_Article_CurrentItemChanged(object sender, ListViewItemEventArgs e)
        {
            //try
            //{
            //    ReturnArticleDetails(int.Parse(e.Item.Value.ToString()));
            //}
            //catch
            //{ }
        }
        //private bool ValidateArticleGroupControls()
        //{
        //    return CommonHelper.ValidateControls(txt_ArticleGroupName, _errorProvider, " گروه کالا را وارد نمایید")
        //           || CommonHelper.ValidateControls(ddl_ArticleGroupStatus, _errorProvider, "وضعیت گروه را تعیین کنید");
        //}
        //private async void btnSave_Click(object sender, EventArgs e)
        //{
        //    if (ValidateArticleGroupControls()) return;

        //    var dlg = new CustomDialogs(400, 200);

        //    try
        //    {
        //        var newArticleGroup = new ArticleGroup(txt_ArticleGroupName.Text, "",
        //            InitialHelper.CurrentUser.Id, DateTime.Now, DateTime.Now, "",
        //            ddl_ArticleGroupStatus.SelectedItem.Text);

        //        var status = await _articleGroupService.CreateAsync(newArticleGroup);

        //        switch (status)
        //        {
        //            case CreateStatus.Exist:
        //                dlg.Invoke("خطای تکرار", "این عنوان گروه تکراری می باشد",
        //                    CustomDialogs.ImageType.itError3,
        //                    CustomDialogs.ButtonType.Ok, InitialHelper.BackColorCustom);
        //                txt_ArticleGroupName.Focus();
        //                txt_ArticleGroupName.SelectAll();
        //                break;
        //            case CreateStatus.Failure:
        //                dlg.Invoke("بروز خطا", PublicError.Error, CustomDialogs.ImageType.itError5,
        //                    CustomDialogs.ButtonType.Ok);
        //                break;
        //            case CreateStatus.Successful:
        //                BindGrid();
        //                txt_ArticleGroupName.Clear();
        //                txt_ArticleGroupName.Focus();
        //                break;
        //            default:
        //                throw new ArgumentOutOfRangeException();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        dlg.Invoke("خطا در ثبت اطلاعات",
        //            "خطای زیر به وقوع پیوست \n" + ex.ToDetailedString(),
        //            CustomDialogs.ImageType.itError2, CustomDialogs.ButtonType.Ok,
        //            InitialHelper.BackColorCustom);
        //    }
        //}

        //private void txt_ArticleGroupName_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyData == Keys.Enter)
        //    {
        //        btnSave_Click(sender, e);
        //    }
        //}

        private void rb_MeasurementUnitAdd_Click(object sender, EventArgs e)
        {
            //racb_MeasurementUnits.Insert("کیلوگرم" + "(1)" + ";");

            CommonHelper.IndicatorLoading(_picLoading, true);
            _backgroundWorker.RunWorkerAsync();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txt_ArticleName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnRegister_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        //private void ExtendedPanel1_Click(object sender, EventArgs e)
        //{
        //    //if (extendedPanel1.u)
        //    //{
        //    //    pnl_Data.Enabled = false;
        //    //    pnl_Action.Enabled = false;
        //    //    txt_ArticleGroupName.Focus();
        //    //    rgv_ArticleGroup.Enabled = false;
        //    //    rgv_ArticleGroup.BackColor = Color.Gray;
        //    //    rlv_Article.Enabled = false;
        //    //    rlv_Article.BackColor = Color.Gray;
        //    //    radCommandBar1.Enabled = false;
        //    //    radCommandBar1.BackColor = Color.Gray;
        //    //}
        //    //else
        //    //{
        //    //    pnl_Action.Enabled = true;

        //    //    rgv_ArticleGroup.Enabled = true;
        //    //    rgv_ArticleGroup.BackColor = SystemColors.Control;
        //    //    rlv_Article.Enabled = true;
        //    //    rlv_Article.BackColor = SystemColors.Control;
        //    //    radCommandBar1.Enabled = true;
        //    //    radCommandBar1.BackColor = SystemColors.Control;
        //    //}
        //}

        private void Btn_ArticleGroupReload_Click(object sender, EventArgs e)
        {
            BindGrid();
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

            var articleId = int.Parse(rlv_Article.SelectedItem.Value.ToString());

            if (await _articleService.IsUsedAsync(articleId))
            {
                CommonHelper.ShowNotificationMessage("خطا",
                    "کالا در حال استفاده بوده و حذف نمیشود ");

                return;
            }

            await _articleService.RemoveAsync(articleId);

            CommonHelper.ShowNotificationMessage("حذف", $"کالا با شناسه {articleId} حذف گردید");

            await LoggerService.InformationAsync(this.Name, "BtnDelete_Click", $"حذف کالای شماره {articleId}",
                $"این کالا توسط کاربری با نام {InitialHelper.CurrentUser.UserName} حذف گردید.");

            _mode = CommonHelper.Mode.None;
            rgv_ArticleGroup.Enabled = true;
            CommonHelper.EnableControls(pnl_Data, false);

            btnCancel.Enabled = false;
            btnInsert.Enabled = true;
            btnDelete.Enabled = true;

            BindGrid();
        }
    }
}