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
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace PersonalAccounting.UI
{
    public partial class FrmExpense : BaseForm
    {
        private enum CurrentSelected
        {
            None = 0,
            Article = 1,
            Fund = 2,
            MeasurementUnit = 3,
            ByPerson = 4,
            ForPerson = 5
        }
        private readonly IRepositoryService<Person, ViewModelLoadAllPerson, ViewModelSimpleLoadPerson> _personService;
        private readonly
            IRepositoryService<Article, ViewModelLoadAllArticle, ViewModelSimpleLoadArticle> _articleService;
        private readonly IMeasurementUnitService _measurementUnitService;
        private readonly IFundService _fundService;
        private readonly IExpenseDocumentService _expenseDocumentService;
        private readonly IExpenseService _expenseService;
        //private readonly IUserService _userService;
        //private int _articleId;
        private CurrentSelected _currentSelected = CurrentSelected.None;
        private int _documentId;
        private string _expenseDocumentDate;
        private IList<ViewModelLoadAllExpense> _expenses;
        private decimal _sumPrice;
        private bool _lock;
        private object _ds;
        private readonly RadGridView _rgv;
        private List<string> _fileNames;
        private List<string> _headerTexts;
        private List<int> _columnWidths;
        private List<bool> _visibleFields;
        private readonly Panel _pnlFloating;
        private readonly BackgroundWorker _backgroundWorker;
        private readonly PictureBox _pictureBox;
        //public string CurrentValue { get; set; }
        private static bool _error;
        private const decimal Value = 500;
        //public bool PriceOverflow = false;

        private static FrmExpense _aFrmExpense;
        public static FrmExpense Instance()
        {
            return _aFrmExpense ?? (_aFrmExpense = IocConfig.Container.GetInstance<FrmExpense>());
        }

        public FrmExpense(
            IRepositoryService<Person, ViewModelLoadAllPerson, ViewModelSimpleLoadPerson> personService, IFundService fundService,
            IRepositoryService<Article, ViewModelLoadAllArticle, ViewModelSimpleLoadArticle> articleService,
            IMeasurementUnitService measurementUnitService, IExpenseDocumentService expenseDocumentService,
            IExpenseService expenseService
            //, IUserService userService
            )
        {
            _personService = personService;
            _fundService = fundService;
            _articleService = articleService;
            _measurementUnitService = measurementUnitService;
            _expenseDocumentService = expenseDocumentService;
            _expenseService = expenseService;
            //_userService = userService;

            InitializeComponent();

            _backgroundWorker = new BackgroundWorker();
            _backgroundWorker.DoWork += _backgroundWorker_DoWork;
            _backgroundWorker.RunWorkerCompleted += _backgroundWorker_RunWorkerCompleted;

            //_pictureBox = new PictureBox()
            //{
            //    Parent = pnl_Action,
            //    SizeMode = PictureBoxSizeMode.StretchImage,
            //    BorderStyle = BorderStyle.None,
            //    Size = new Size(356, 19),
            //    Location = new Point((pnl_Action.Width / 2) - 200, 8),
            //    //new Point(13, 101),//new Point(pnl_Data.Width / 25, pnl_Data.Height / 20),
            //    Image = CommonLibrary.Properties.Resources.Loadingvvv,
            //    Visible = false
            //};

            _pictureBox = CommonHelper.CreateIndicatorLoading(pnl_Action, new Size(356, 19),
                new Point((pnl_Action.Width / 2) - 200, 8),
                CommonLibrary.Properties.Resources.Loadingvvv, false,
                PictureBoxSizeMode.StretchImage, BorderStyle.None);

            _rgv = new RadGridView();
            _pnlFloating = new Panel();
            _rgv.KeyDown += _rgv_KeyDown;
            _rgv.CellDoubleClick += _rgv_CellDoubleClick;
            // _rgv.CellFormatting += _rgv_CellFormatting;
            _rgv.RowFormatting += _rgv_RowFormatting;

            BindGrid();
        }

        //private async void FillDropdownList(RadDropDownList ddl)
        //{
        //    ddl.DisplayMember = "Title";
        //    ddl.ValueMember = "Id";
        //    //var which = (ddl.Name == "rddl_MentalConditions")
        //    //    ? "mental" : (ddl.Name == "rddl_WeatherConditions")
        //    //    ? "weather" : "";

        //    switch (ddl.Name)
        //    {
        //        case "rddl_Users":
        //            {
        //                ddl.DisplayMember = "UserName";
        //                ddl.ValueMember = "UserId";

        //                var defaultOption = new ViewModelLoadAllUser()
        //                {
        //                    UserId = 0,
        //                    UserName = "انتخاب کنید ..."
        //                };

        //                var users = await _userService.LoadAllViewModelAsync();
        //                users.Insert(0, defaultOption);
        //                ddl.DataSource = users;
        //                break;
        //            }
        //    }
        //}

        private async void _rgv_RowFormatting(object sender, RowFormattingEventArgs e)
        {
            try
            {
                if (_currentSelected != CurrentSelected.Fund) return;

                if (e.RowElement.RowInfo.Cells["FundCurrentValueSeparateDigit"] == null) return;

                if (e.RowElement.RowInfo.Cells["FundCurrentValueSeparateDigit"].Value.ToString().ClearSeparateEx() < Value)
                {
                    e.RowElement.Enabled = false;
                    e.RowElement.BackColor = Color.Gray;
                    e.RowElement.GradientStyle = GradientStyles.Solid;
                    e.RowElement.DrawFill = true;
                }
                else
                {
                    e.RowElement.ResetValue(VisualElement.BackColorProperty, ValueResetFlags.Local);
                    e.RowElement.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local);
                    e.RowElement.ResetValue(LightVisualElement.GradientStyleProperty, ValueResetFlags.Local);
                }
            }
            catch (Exception exception)
            {
                await LoggerService.ErrorAsync(this.Name, "_rgv_RowFormatting", exception.Message,
                    exception.ToDetailedString());
            }
        }

        //void _rgv_CellFormatting(object sender, CellFormattingEventArgs e)
        //{
        //    if (e.CellElement.ColumnInfo.Name == "FundCurrentValueSeparateDigit")
        //    {
        //        var value = CommonHelper.ClearSeparate(e.CellElement.Value.ToString());
        //        if (value < 550000)
        //        {
        //            e.CellElement.ForeColor = Color.Red;
        //            e.CellElement.Enabled = false;
        //        }
        //    }
        //    else
        //    {
        //        e.CellElement.ResetValue(VisualElement.ForeColorProperty, ValueResetFlags.Local);
        //    }
        //    //if (e.CellElement.RowElement.IsCurrent || e.CellElement.RowElement.IsSelected)
        //    //{
        //    //    e.CellElement.DrawFill = false;
        //    //    e.CellElement.DrawBorder = false;
        //    //}
        //    //else
        //    //{
        //    //    e.CellElement.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local);
        //    //    e.CellElement.ResetValue(LightVisualElement.DrawBorderProperty, ValueResetFlags.Local);
        //    //}
        //}

        private void _rgv_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            SubmitSelectedValue();
        }

        private async void SubmitSelectedValue()
        {
            if (_rgv.CurrentRow is GridViewDataRowInfo currentRow)
            {
                try
                {
                    switch (_currentSelected)
                    {
                        case CurrentSelected.Article:
                            rgv_BuyList.BeginUpdate();
                            //_articleId = int.Parse(_rgv.CurrentRow.Cells[0].Value.ToString());
                            rgv_BuyList.CurrentRow.Cells[2].Value = _rgv.CurrentRow.Cells[0].Value.ToString();
                            rgv_BuyList.CurrentRow.Cells[3].Value = _rgv.CurrentRow.Cells[1].Value.ToString();
                            rgv_BuyList.CurrentRow.Cells[10].Value = null;
                            rgv_BuyList.CurrentRow.Cells[11].Value = null;
                            _currentSelected = CurrentSelected.Fund;
                            rgv_BuyList.EndUpdate();
                            //CommonHelper.IndicatorLoading(_picLoading, true);
                            //_backgroundWorker.RunWorkerAsync();
                            SendKeys.Send("{left}");
                            //SendKeys.Send("{left}");
                            break;
                        case CurrentSelected.Fund:
                            if (currentRow.Cells["FundCurrentValueSeparateDigit"].Value.ToString().ClearSeparateEx() > Value)
                            {
                                rgv_BuyList.BeginUpdate();
                                rgv_BuyList.CurrentRow.Cells[4].Value = _rgv.CurrentRow.Cells[0].Value.ToString();
                                rgv_BuyList.CurrentRow.Cells[5].Value = _rgv.CurrentRow.Cells[2].Value.ToString();
                                rgv_BuyList.CurrentRow.Cells[16].Value = _rgv.CurrentRow.Cells[3].Value.ToString();
                                _currentSelected = CurrentSelected.ByPerson;
                                rgv_BuyList.EndUpdate();
                                //CommonHelper.IndicatorLoading(_picLoading, true);
                                //_backgroundWorker.RunWorkerAsync();
                                SendKeys.Send("{left}");
                                //SendKeys.Send("{left}");
                            }
                            else return;
                            break;
                        case CurrentSelected.ByPerson:
                            rgv_BuyList.BeginUpdate();
                            rgv_BuyList.CurrentRow.Cells[6].Value = _rgv.CurrentRow.Cells[0].Value.ToString();
                            rgv_BuyList.CurrentRow.Cells[7].Value = _rgv.CurrentRow.Cells[1].Value.ToString();
                            rgv_BuyList.EndUpdate();
                            _currentSelected = CurrentSelected.ForPerson;
                            //CommonHelper.IndicatorLoading(_picLoading, true);
                            //_backgroundWorker.RunWorkerAsync();
                            SendKeys.Send("{left}");
                            //SendKeys.Send("{left}");
                            break;
                        case CurrentSelected.ForPerson:
                            rgv_BuyList.BeginUpdate();
                            rgv_BuyList.CurrentRow.Cells[8].Value = _rgv.CurrentRow.Cells[0].Value.ToString();
                            rgv_BuyList.CurrentRow.Cells[9].Value = _rgv.CurrentRow.Cells[1].Value.ToString();
                            rgv_BuyList.EndUpdate();
                            _currentSelected = CurrentSelected.MeasurementUnit;
                            SendKeys.Send("{left}");
                            break;
                        case CurrentSelected.MeasurementUnit:
                            rgv_BuyList.BeginUpdate();
                            rgv_BuyList.CurrentRow.Cells[10].Value = _rgv.CurrentRow.Cells[0].Value.ToString();
                            rgv_BuyList.CurrentRow.Cells[11].Value = _rgv.CurrentRow.Cells[1].Value.ToString();
                            rgv_BuyList.EndUpdate();
                            //SendKeys.Send("{left}");
                            //rgv_BuyList.CurrentRow.IsSelected = true;
                            rgv_BuyList.Columns[12].IsCurrent = true;

                            //rgv_BuyList.CurrentRow.IsCurrent = true;
                            //rgv_BuyList.Columns["Fi"].IsCurrent = true;
                            //rgv_BuyList.BeginEdit();
                            //rgv_BuyList.Focus();
                            SendKeys.Send("{F2}");
                            //rgv_BuyList.CurrentRow.Cells["Fi"].IsSelected = true;
                            //rgv_BuyList.CurrentRow.Cells[12].BeginEdit();

                            //SendKeys.Send("\u002C");
                            //SendKeys.Send("{left}");
                            break;

                        case CurrentSelected.None:
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }
                catch (Exception exception)
                {
                    var dlg = new CustomDialogs(320, 200);
                    dlg.Invoke("خطا", exception.ToDetailedString(), CustomDialogs.ImageType.itError5,
                        CustomDialogs.ButtonType.Ok, InitialHelper.BackColorCustom);

                    await LoggerService.ErrorAsync(this.Name, "SubmitSelectedValue", exception.Message,
                        exception.ToDetailedString());
                }
            }

            _pnlFloating.Visible = false;
            _rgv.DataSource = null;
            rgv_BuyList.Focus();
        }

        private void _rgv_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Escape:
                    _pnlFloating.Visible = false;
                    rgv_BuyList.Focus();
                    break;
                case Keys.Enter:
                    SubmitSelectedValue();
                    _pnlFloating.Visible = false;
                    _rgv.DataSource = null;
                    // _pnlFloating = null;
                    rgv_BuyList.Focus();
                    //SendKeys.Send("{left}"); SendKeys.Send("{left}");
                    break;
            }
        }

        //protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        //{
        //    if (keyData == Keys.Down)
        //    {
        //        rgv_BuyList.Rows.AddNew();
        //    }
        //    return base.ProcessCmdKey(ref msg, keyData);
        //}
        private async void _backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _fileNames = new List<string>();
                _headerTexts = new List<string>();
                _columnWidths = new List<int>();
                _visibleFields = new List<bool>();

                switch (_currentSelected)
                {
                    case CurrentSelected.Article:
                        _fileNames.AddRange(new[] { "ArticleId", "ArticleName", "ArticleGroupName", "ArticleGroupId" });
                        _headerTexts.AddRange(new[] { "شناسه", "نام کالا", "عنوان دسته", "شناسه گروه" });
                        _columnWidths.AddRange(new[] { 84, 167, 180, 84 });
                        _visibleFields.AddRange(new[] { false, true, true, false });
                        _ds = await _articleService.LoadAllViewModelAsync();
                        break;
                    case CurrentSelected.Fund:
                        _fileNames.AddRange(new[] { "FundId", "FundTypeName", "FundTitle", "FundCurrentValueSeparateDigit" });
                        _headerTexts.AddRange(new[] { "شناسه صندوق", "نوع صندوق", "عنوان صندوق", "مانده جاری" });
                        _columnWidths.AddRange(new[] { 84, 100, 157, 136 });
                        _visibleFields.AddRange(new[] { false, true, true, true });
                        _ds = await _fundService.LoadAllViewModelAsync();
                        //var _ds2 = (IList<ViewModelFundLoadAll>)_ds;
                        // _ds2[1].
                        break;
                    case CurrentSelected.MeasurementUnit:
                        _fileNames.AddRange(new[] { "MeasurementUnitId", "MeasurementUnitName" });
                        _headerTexts.AddRange(new[] { "شناسه سنجش", "واحد سنجش" });
                        _columnWidths.AddRange(new[] { 84, 157 });
                        _visibleFields.AddRange(new[] { false, true });
                        if (!(rgv_BuyList.CurrentRow is GridViewDataRowInfo dataRow)) return;
                        var articleId = int.Parse(dataRow.Cells["ArticleId"].Value.ToString());
                        _ds = await _measurementUnitService.GetByArticleAsync(articleId);
                        break;
                    case CurrentSelected.ByPerson:
                        _fileNames.AddRange(new[] { "PersonId", "PersonFullName" });
                        _headerTexts.AddRange(new[] { "شناسه شخص", "هزینه کننده" });
                        _columnWidths.AddRange(new[] { 84, 180 });
                        _visibleFields.AddRange(new[] { false, true });
                        _ds = await _personService.LoadAllViewModelAsync();
                        break;
                    case CurrentSelected.ForPerson:
                        _fileNames.AddRange(new[] { "PersonId", "PersonFullName" });
                        _headerTexts.AddRange(new[] { "شناسه شخص", "هزینه شده برای" });
                        _columnWidths.AddRange(new[] { 84, 180 });
                        _visibleFields.AddRange(new[] { false, true });
                        _ds = await _personService.LoadAllViewModelAsync();
                        break;
                    case CurrentSelected.None:
                        _ds = null;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            catch (Exception exception)
            {
                await LoggerService.ErrorAsync(this.Name, "_backgroundWorker_DoWork", exception.Message,
                    exception.ToDetailedString());
            }
        }

        private async void _backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                var headerTitle = string.Empty;
                switch (_currentSelected)
                {
                    case CurrentSelected.Article:
                        headerTitle = "مورد هزینه شده را انتخاب نمایید.";
                        break;
                    case CurrentSelected.Fund:
                        headerTitle = "صندوق محل هزینه را مشخص نمایید.";
                        break;
                    case CurrentSelected.MeasurementUnit:
                        headerTitle = "واحد سنجش را تعیین کنید.";
                        break;
                    case CurrentSelected.ByPerson:
                        headerTitle = "هزینه کننده را انتخاب نمایید.";
                        break;
                    case CurrentSelected.ForPerson:
                        headerTitle = "شخصی که برایش هزینه شده را انتخاب نمایید.";
                        break;
                    case CurrentSelected.None:
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                //CommonHelper.EnableControls(false, pnl_Data, pnl_Action, uiPanel0);

                CommonHelper.GenerateParentPanel(_pnlFloating, _rgv, headerTitle,
                    BorderStyle.FixedSingle, 450, 280, this);
                CommonHelper.GenerateGridView(_rgv, _fileNames, _headerTexts, _columnWidths, _visibleFields);

                _pnlFloating.Location = new Point((rgv_BuyList.Width / 2) - (_pnlFloating.Width / 2),
                    ((rgv_BuyList.Height / 2) - (_pnlFloating.Width / 5)));
                _pnlFloating.Visible = true;
                _rgv.DataSource = _ds;
                _pnlFloating.BringToFront();
                _rgv.Focus();
                if (_mode != CommonHelper.Mode.Cancel)
                    _rgv.TableElement.ViewInfo.TableFilteringRow.Cells[0].BeginEdit();

                _backgroundWorker.Dispose();
                CommonHelper.IndicatorLoading(_pictureBox);
            }
            catch (Exception exception)
            {
                await LoggerService.ErrorAsync(this.Name, "_backgroundWorker_RunWorkerCompleted", exception.Message,
                    exception.ToDetailedString());
            }
        }

        private async void BindGrid()
        {
            int? currentUserId = null;
            if (!await InitialHelper.CurrentUser.IsAdmin())
                currentUserId = InitialHelper.CurrentUser.Id;

            rgv_Expenses.BeginUpdate();
            rgv_Expenses.DataSource =
                await _expenseDocumentService.LoadAllViewModelAsync(currentUserId);
            rgv_Expenses.EndUpdate();
        }
        private async void rgv_BuyList_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Insert:
                    {
                        if (!IsNotReadyForAddNewRow())
                            rgv_BuyList.Rows.AddNew();
                        break;
                    }
                case Keys.Enter:
                    try
                    {
                        var cell = (RadGridView)sender;
                        if (cell == null) return;

                        switch (cell.GridViewElement.CurrentCell.ColumnInfo.FieldName)
                        {
                            case "ArticleName":
                                _currentSelected = CurrentSelected.Article;
                                break;
                            case "FundName":
                                _currentSelected = CurrentSelected.Fund;
                                break;
                            case "MeasurementUnitName":
                                _currentSelected = CurrentSelected.MeasurementUnit;
                                break;
                            case "ByPersonName":
                                _currentSelected = CurrentSelected.ByPerson;
                                break;
                            case "ForPersonName":
                                _currentSelected = CurrentSelected.ForPerson;
                                break;
                            case "Fi":
                                _currentSelected = CurrentSelected.None;
                                //SendKeys.Send("{left}");
                                break;
                            //case "Comment":

                            //    if (!IsNotReadyForAddNewRow())
                            //    {
                            //        var index = cell.CurrentRow.Index;
                            //        rgv_BuyList.Rows.AddNew();
                            //        //rgv_BuyList.Rows[index + 1].IsCurrent = true;
                            //        rgv_BuyList.Rows[index + 1].Cells["ArticleName"].IsSelected = true;
                            //    }
                            //    break;
                            //case "Comment":
                            //    if (IsNotReadyForAddNewRow())
                            //        return;
                            //    rgv_BuyList.Rows.AddNew();
                            //    //rgv_BuyList.CurrentRow.Cells["ArticleName"].IsSelected = true;
                            //    SendKeys.Send("{right}");SendKeys.Send("{right}");SendKeys.Send("{right}");SendKeys.Send("{right}");SendKeys.Send("{right}");SendKeys.Send("{right}");SendKeys.Send("{right}");SendKeys.Send("{right}");SendKeys.Send("{right}");SendKeys.Send("{right}");SendKeys.Send("{right}");SendKeys.Send("{right}");SendKeys.Send("{right}");
                            //    _currentSelected = CurrentSelected.Article;
                            //    break;
                            //case "Count":
                            //  _currentSelected = CurrentSelected.MeasurementUnit;
                            //  SendKeys.Send("{left}");
                            //CommonHelper.IndicatorLoading(_picLoading, true);
                            //_backgroundWorker.RunWorkerAsync();
                            //  break;
                            default:
                                break;
                        }

                        if (_currentSelected == CurrentSelected.None)
                            return;

                        CommonHelper.IndicatorLoading(_pictureBox, true);
                        _backgroundWorker.RunWorkerAsync();

                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);

                        await LoggerService.ErrorAsync(this.Name, "rgv_BuyList_KeyDown", exception.Message,
                            exception.ToDetailedString());
                    }

                    break;
            }
            e.SuppressKeyPress = true;
        }

        private void rgv_BuyList_CellClick(object sender, GridViewCellEventArgs e)
        {
            if (sender is GridHeaderCellElement) return;
            if (!(sender is GridDataCellElement cell)) return;

            if (cell.ColumnInfo.FieldName == "DeleteRow" && rgv_BuyList.Rows.Count > 1)
            {
                //  if (e.RowIndex > 0)
                e.Row.Delete();
            }

            //try
            //{
            //    var cell = (GridDataCellElement)sender;

            //    //if (cell == null) return;
            //    //_currentSelected = (cell.ColumnInfo.FieldName == "ArticleName")? 
            //    //    CurrentSelected.Article : CurrentSelected.Fund;

            //    switch (cell.ColumnInfo.FieldName)
            //    {
            //        case "ArticleName":
            //            _currentSelected = CurrentSelected.Article;
            //            break;
            //        case "FundName":
            //            _currentSelected = CurrentSelected.Fund;
            //            break;
            //        default:
            //            return;
            //    }
            //    CommonHelper.IndicatorLoading(_picLoading, true);
            //    _backgroundWorker.RunWorkerAsync();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    this.rgv_BuyList.TableElement.Update(GridUINotifyAction.StateChanged);
        //}

        private void rgv_BuyList_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            switch (e.CellElement.ColumnInfo.Name)
            {
                case "RowNumber" when e.CellElement.Value == null:
                    e.CellElement.Text = (e.CellElement.RowIndex + 1).ToString(CultureInfo.InvariantCulture);
                    break;
                case "DeleteRow":
                    {
                        var cell = (GridDataCellElement)e.CellElement;
                        cell.Image = CommonLibrary.Properties.Resources.Delete;
                        break;
                    }
            }

            //if (e.CellElement.ColumnInfo.Name == "Comment"&& !(IsNotReadyForAddNewRow()))
            //{
            //    rgv_BuyList.Rows.AddNew();
            //    SendKeys.Send("{home}"); SendKeys.Send("{left}"); SendKeys.Send("{left}");
            //}
            //decimal fi = 0;
            //decimal count = 0;

            //if (e.CellElement.ColumnInfo.Name == "Fi")
            //{
            //    fi = decimal.Parse(e.CellElement.Text);
            //}
            //if (e.CellElement.ColumnInfo.Name == "Count")
            //{
            //    count = decimal.Parse(e.CellElement.Text);
            //}
            //if (e.CellElement.ColumnInfo.Name == "Price")
            //{
            //    e.CellElement.ColumnInfo.Expression = "Fi * Count";

            //    //e.CellElement.Text = (fi * count).ToString();
            //}
            // radGridView2.Columns["Fi"].FormatInfo.NumberFormat.NumberDecimalSeparator = "3";

            //radGridView2.Columns["Fi"].FormatString = "{0:#,###}";

            if (e.CellElement.ColumnInfo is GridViewDecimalColumn)
            {
                if (e.CellElement.ColumnInfo.Name != "Count")
                    e.CellElement.Text = $@"{((GridDataCellElement)e.CellElement).Value:#,###}";
            }

            if (e.CellElement.ColumnInfo.ReadOnly)
            {
                if (e.CellElement.ColumnInfo is GridViewDecimalColumn)
                    return;
                if (e.CellElement.Value != null)
                    e.CellElement.Text = e.CellElement.Value.ToString();
                var s = e.CellElement.Text;
                s = "<html><color=purple><b>" + s + "</b></html>";
                e.CellElement.Text = s;
            }
            //if (e.CellElement.ColumnInfo.Name == "Fi" && e.CellElement.Value != null)
            //{
            //    e.CellElement.Text = e.CellElement.Value.ToString();
            //    string s = e.CellElement.Text;
            //    s = "<html><color=Blue>" + s + "</html>";
            //    e.CellElement.Text = s;
            //}

            //if (e.CellElement.ColumnInfo.Name == "Fi")
            //{
            //    e.CellElement.Text = String.Format("{0:#,###}", (e.CellElement).Value);
            //}

            //if (e.CellElement.Text == this.textBox1.Text && textBox1.Text != string.Empty)
            //{
            //    e.CellElement.DrawFill = true;
            //    e.CellElement.BackColor = Color.Yellow;
            //    e.CellElement.GradientStyle = GradientStyles.Solid;
            //}
            //else
            //{
            //    e.CellElement.ResetValue(LightVisualElement.DrawFillProperty, Telerik.WinControls.ValueResetFlags.Local);
            //    e.CellElement.ResetValue(VisualElement.BackColorProperty, ValueResetFlags.Local);
            //    e.CellElement.ResetValue(LightVisualElement.GradientStyleProperty, ValueResetFlags.Local);
            //}
        }

        private async void rgv_BuyList_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                if (sender is GridHeaderCellElement) return;

                var cell = (GridDataCellElement)sender;

                //if (cell == null) return;
                //_currentSelected = (cell.ColumnInfo.FieldName == "ArticleName")? 
                //    CurrentSelected.Article : CurrentSelected.Fund;

                switch (cell.ColumnInfo.FieldName)
                {
                    case "ArticleName":
                        _currentSelected = CurrentSelected.Article;
                        break;
                    case "FundName":
                        _currentSelected = CurrentSelected.Fund;
                        break;
                    case "MeasurementUnitName":
                        _currentSelected = CurrentSelected.MeasurementUnit;
                        break;
                    case "ByPersonName":
                        _currentSelected = CurrentSelected.ByPerson;
                        break;
                    case "ForPersonName":
                        _currentSelected = CurrentSelected.ForPerson;
                        break;
                    default:
                        _currentSelected = CurrentSelected.None;
                        return;
                }
                CommonHelper.IndicatorLoading(_pictureBox, true);
                _backgroundWorker.RunWorkerAsync();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);

                await LoggerService.ErrorAsync(this.Name, "rgv_BuyList_CellDoubleClick", exception.Message,
                    exception.ToDetailedString());
            }
        }

        private void rgv_BuyList_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData != Keys.Down) return;

            if (IsNotReadyForAddNewRow()) return;

            rgv_BuyList.Rows.AddNew();
            SendKeys.Send("{home}"); SendKeys.Send("{left}"); SendKeys.Send("{left}");
        }

        private bool IsNotReadyForAddNewRow()
        {
            if (_error) return true;

            return (
                (rgv_BuyList.CurrentRow.Index + 1 != rgv_BuyList.RowCount) ||
                    rgv_BuyList.CurrentRow.Cells[2].Value == null || rgv_BuyList.CurrentRow.Cells[3].Value == null ||
                    rgv_BuyList.CurrentRow.Cells[4].Value == null || rgv_BuyList.CurrentRow.Cells[5].Value == null ||
                    rgv_BuyList.CurrentRow.Cells[6].Value == null || rgv_BuyList.CurrentRow.Cells[7].Value == null ||
                    rgv_BuyList.CurrentRow.Cells[8].Value == null || rgv_BuyList.CurrentRow.Cells[9].Value == null ||
                    rgv_BuyList.CurrentRow.Cells[9].Value == null || rgv_BuyList.CurrentRow.Cells[10].Value == null ||
                    rgv_BuyList.CurrentRow.Cells[11].Value == null ||
                    rgv_BuyList.CurrentRow.Cells[12].Value == null || rgv_BuyList.CurrentRow.Cells[12].Value.ToString() == "0" ||
                    rgv_BuyList.CurrentRow.Cells[13].Value == null || rgv_BuyList.CurrentRow.Cells[13].Value.ToString() == "0" ||
                    rgv_BuyList.CurrentRow.Cells[14].Value == null || rgv_BuyList.CurrentRow.Cells[14].Value.ToString() == "0");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!InitialHelper.HasPermissionFor(this.Name, PermissionMode.Add))
            {
                CommonHelper.ShowNotificationMessage(DefaultConstants.IllegalAccess, DefaultConstants.CreateActionNotAllow);
                return;
            }

            _mode = CommonHelper.Mode.Insert;

            CommonHelper.InsertAction(_mode, pnl_Data, rgv_Expenses, btnInsert, btnRegister,
                btnModify, btnDelete, btnCancel, btnClose, txt_ExpenseDocumentDate);

            lbl_DocumentId.Text = string.Empty;
            lbl_SumPrice.Text = string.Empty;

            //rgv_BuyList.BeginUpdate();
            //rgv_BuyList.DataSource = null;
            rgv_BuyList.Rows.AddNew();
            //rgv_BuyList.EndUpdate();

            //rgv_BuyList.MasterView.TableAddNewRow.IsCurrent = true;
            //rgv_BuyList.BeginEdit();

            //rgv_BuyList.Select();
            //rgv_BuyList.Rows[0].IsSelected = true;
            //rgv_BuyList.Rows[0].IsCurrent = true;
            //rgv_BuyList.Rows[0].Cells[2].IsSelected = true;

            //txt_IncomeDate.Enabled = true;
            //var selectedDate = PersianHelper.GetPersiaDateSimple(DateTime.Now);
            //txt_IncomeDate.Text = selectedDate;
            //txt_IncomeDate.Select();
            //txt_IncomeDate.SelectAll();

            txt_ExpenseDocumentDate.SetPersianDateToTextBoxAndSelectAll();
        }

        private void rgv_BuyList_UserDeletingRow(object sender, GridViewRowCancelEventArgs e)
        {
            if (rgv_BuyList.Rows.Count <= 1)
                e.Cancel = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CommonHelper.CancelAction(_mode, pnl_Data, rgv_Expenses, btnInsert,
                btnRegister, btnModify, btnDelete, btnCancel, btnClose);
            _mode = CommonHelper.Mode.Cancel;

            //ReturnExpenseDocumentDetailsById();
            //CommonHelper.IndicatorLoading(_pictureBox, true);
            //_backgroundWorker.RunWorkerAsync();
            backgroundWorker1.RunWorkerAsync();
            CommonHelper.IndicatorLoading(_pictureBox, true);

            _pnlFloating.Visible = false;
            //rgv_BuyList.DataSource = null;
            //txt_IncomeDate.Text = CommonLibrary.Properties.Resources.NullDatelFormat;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (!InitialHelper.HasPermissionFor(this.Name, PermissionMode.Edit))
            {
                CommonHelper.ShowNotificationMessage(DefaultConstants.IllegalAccess, DefaultConstants.EditActionNotAllow);
                return;
            }

            _mode = CommonHelper.Mode.Update;

            CommonHelper.ModifyAction(_mode, pnl_Data, rgv_Expenses, btnInsert,
                btnRegister, btnModify, btnDelete, btnCancel, btnClose);

            txt_ExpenseDocumentDate.Enabled = true;

        }

        private async void rgv_BuyList_CellValueChanged(object sender, GridViewCellEventArgs e)
        {
            if (e.Column.Name != "Fi" && e.Column.Name != "Count") return;

            if (e.Row.Cells["Fi"].Value == null || e.Row.Cells["Count"].Value == null) return;

            try
            {
                var fi = decimal.Parse(e.Row.Cells["Fi"].Value.ToString());
                var count = decimal.Parse(e.Row.Cells["Count"].Value.ToString());
                var price = fi * count;
                e.Row.Cells["Price"].Value = $"{price:N0}";

                lbl_SumPrice.Text = "هزینه کل: " + GetSumPrice().Result.ToString("N0") + " ریال";
            }
            catch (Exception exception)
            {
                await LoggerService.ErrorAsync(this.Name, "rgv_BuyList_CellValueChanged", exception.Message,
                    exception.ToDetailedString());
            }
            // lbl_sum.Text = price.ToString();
            //e.Row.Cells["Price"].Value= CommonHelper.AddSeparate(price.ToString(CultureInfo.InvariantCulture));
            //foreach (var row in rgv_BuyList.Rows)
            //{
            //    var val = int.Parse((row.Cells["TempPrice"].ToString()));
            //    lbl_sum.Text = CommonHelper.ClearSeparate(lbl_sum.Text).ToString() + val;

            //}
        }

        private void rgv_BuyList_CellEndEdit(object sender, GridViewCellEventArgs e)
        {
            switch (e.Column.FieldName)
            {
                //case "Comment" when !(IsNotReadyForAddNewRow()):
                //    // var index = rgv_BuyList.CurrentRow.Index;

                //    //rgv_BuyList.Rows.AddNew();
                //    //SendKeys.Send("{home}"); SendKeys.Send("{left}");
                //    break;
                case "Fi":
                    SendKeys.Send("{left}");
                    SendKeys.Send("{F2}");
                    break;
                case "Count":
                    SendKeys.Send("{left}");
                    SendKeys.Send("{left}");
                    SendKeys.Send("{F2}");
                    break;
            }

            //SendKeys.Send("{left}");
        }

        private void pnl_Data_MouseClick(object sender, MouseEventArgs e)
        {
            if (_pnlFloating.Visible)
            {
                _pnlFloating.Visible = false;
            }
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            //if (PriceOverflow)
            //{
            //    dlg.Invoke("خطا در مبلغ هزینه نسبت به مانده",
            //        "مبلغ هزینه یک یا چندتا از سطرها از مانده صندوق آن بیشتر است.",
            //        CustomDialogs.ImageType.itError2, CustomDialogs.ButtonType.Ok,
            //        InitialHelper.BackColorCustom);
            //    return;
            //}

            var persianRegisterDate = PersianHelper.GetGregorianDate(txt_ExpenseDocumentDate.Text);
            var currentUser = InitialHelper.CurrentUser;
            var currentDateTime = InitialHelper.CurrentDateTime;
            //var selectedUser = await GetSelectedUserId();

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

                        if (await IsNotValidExpenseList()) return;

                        //var lastRow = rgv_BuyList.Rows[rgv_BuyList.Rows.Count - 1];
                        //if (string.IsNullOrEmpty(lastRow.Cells[3].Value.ToString()))
                        //{
                        //    lastRow.Delete();
                        //}

                        var document = new ExpenseDocument(persianRegisterDate,
                            currentUser.Id, currentDateTime, null, string.Empty);

                        var createstatus = await _expenseDocumentService.CreateAsync(document);

                        switch (createstatus)
                        {
                            case CreateStatus.Exist:
                                break;
                            case CreateStatus.Failure:
                                break;
                            case CreateStatus.Successful:
                                try
                                {
                                    var n = 0;
                                    foreach (var row in rgv_BuyList.Rows)
                                    {
                                        n += 1;
                                        var rowNumber = n;
                                        int? articleId = int.Parse(row.Cells[2].Value.ToString());
                                        int? fundId = int.Parse(row.Cells[4].Value.ToString());
                                        int? byPersonId = int.Parse(row.Cells[6].Value.ToString());
                                        int? forPersonId = int.Parse(row.Cells[8].Value.ToString());
                                        int? measurementUnitId = int.Parse(row.Cells[10].Value.ToString());
                                        var fi = double.Parse(row.Cells[12].Value.ToString());
                                        var count = double.Parse(row.Cells[13].Value.ToString());
                                        var price = double.Parse(row.Cells[14].Value.ToString());
                                        var comment = (row.Cells[15].Value == null) ? string.Empty : row.Cells[15].Value.ToString();

                                        var expense = new Expense(rowNumber, articleId, fundId, byPersonId, forPersonId,
                                            measurementUnitId, fi, count, price, comment, currentDateTime, currentUser.Id)
                                        { DocumentId = document.Id };

                                        await _expenseService.InsertExpenseInToDocumentAsync(expense);

                                        await LoggerService.InformationAsync(this.Name, "btnRegister_Click(Insert Mode)",
                                            $"این قلم هزینه با شماره {rowNumber} " +
                                            " و شماره سند " + document.Id + " توسط کاربری با نام " +
                                            currentUser.UserName + " ایجاد گردید.");

                                        //var sumPrice = 0d;
                                        //sumPrice += price;
                                        var currentFundId = fundId.Value;
                                        var fundStatus = await
                                            _fundService.SubValueFromFundAsync(currentFundId, price);

                                        await LoggerService.InformationAsync(this.Name, "btnRegister_Click(Insert Mode)",
                                            $"مبلغ " + price + " ریال از صندوق شماره " + currentFundId +
                                            " جهت قلم هزینه شماره " + rowNumber +
                                            " با شماره سند " + document.Id + " کسر گردید. ");
                                    }
                                }
                                catch (Exception exception)
                                {
                                    await _expenseDocumentService.RemoveAsync(document);
                                    
                                    var dlg = new CustomDialogs(320, 200);
                                    dlg.Invoke("خطا در ثبت اطلاعات",
                                        "خطای زیر به وقوع پیوست \n" + exception.Message,
                                        CustomDialogs.ImageType.itError2, CustomDialogs.ButtonType.Ok,
                                        InitialHelper.BackColorCustom);

                                    await LoggerService.ErrorAsync(this.Name, "btnRegister_Click(Insert Mode)", exception.Message,
                                        exception.ToDetailedString());
                                    return;
                                }

                                CommonHelper.ShowNotificationMessage("ثبت سند هزینه", "این لیست هزینه با شماره سند "
                                                                                      + document.Id + " ثبت گردید.");

                                //dlg.Invoke("ثبت سند هزینه", "این لیست هزینه با شماره سند "
                                //            + document.Id + " ثبت گردید.",
                                //    CustomDialogs.ImageType.itInfo2, CustomDialogs.ButtonType.Ok,
                                //    InitialHelper.BackColorCustom);


                                //CommonHelper.ClearInputControls(pnl_Data);
                                rgv_Expenses.Enabled = true;
                                CommonHelper.EnableControls(pnl_Data, false);
                                btnCancel.Enabled = false;
                                btnInsert.Enabled = true;
                                btnDelete.Enabled = true;
                                break;
                        }
                    }

                    catch (Exception exception)
                    {
                        var dlg = new CustomDialogs(320, 200);
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

                        if (await IsNotValidExpenseList()) return;

                        int? currentUserId = null;
                        if (!await InitialHelper.CurrentUser.IsAdmin())
                            currentUserId = InitialHelper.CurrentUser.Id;

                        var currentDocument =
                            //await currentUser.IsAdmin()
                            //? await _expenseDocumentService.GetByIdAsync(int.Parse(lbl_DocumentId.Text)) :
                            await _expenseDocumentService.GetByIdAsync(int.Parse(lbl_DocumentId.Text), currentUserId);

                        //_expenseService.DeleteExpensesFromDocumentAsync(currentDocument);

                        //_expenseService.RemoveExpenseAsync(7);

                        //var expenses = currentDocument.Expenses;
                        //_expenseService.RemoveExpensesAsync(expenses);

                        //Delete Previous Expense of list
                        var expenses = currentDocument.Expenses.ToList();
                        foreach (var expense in expenses)
                        {
                            // Return amount to fund
                            if (expense.FundId != null)
                                await _fundService.AddValueToFundAsync(expense.FundId.Value, expense.Price);
                            //Delete expense
                            await _expenseService.RemoveExpenseAsync(expense.Id);
                        }
                        currentDocument.Expenses.Clear();

                        currentDocument.RegisterDate = persianRegisterDate;
                        currentDocument.Description = string.Empty; //Replace With EditBox
                        currentDocument.UpdateBy = currentUser.Id;
                        currentDocument.LastUpdate = currentDateTime;

                        await _expenseDocumentService.UpdateAsync(currentDocument);

                        //foreach (var expense in currentDocument.Expenses)
                        //{
                        //    _expenseService.RemoveExpenseAsync(expense.Id);
                        //}

                        //_expenseService.RemoveFromDocumentAsync(currentDocument);

                        try
                        {
                            var n = 0;
                            foreach (var row in rgv_BuyList.Rows)
                            {
                                n += 1;
                                var rowNumber = n;
                                int? articleId = int.Parse(row.Cells[2].Value.ToString());
                                int? fundId = int.Parse(row.Cells[4].Value.ToString());
                                int? byPersonId = int.Parse(row.Cells[6].Value.ToString());
                                int? forPersonId = int.Parse(row.Cells[8].Value.ToString());
                                int? measurementUnitId = int.Parse(row.Cells[10].Value.ToString());
                                var fi = double.Parse(row.Cells[12].Value.ToString());
                                var count = double.Parse(row.Cells[13].Value.ToString());
                                var price = double.Parse(row.Cells[14].Value.ToString());
                                var comment = (row.Cells[15].Value == null) ? string.Empty :
                                    row.Cells[15].Value.ToString();
                                var currentDocumentId = currentDocument.Id;

                                var expense = new Expense(rowNumber, articleId, fundId, byPersonId, forPersonId,
                                    measurementUnitId, fi, count, price, comment, currentDateTime, currentUser.Id)
                                { DocumentId = currentDocumentId };

                                await _expenseService.InsertExpenseInToDocumentAsync(expense);
                                await LoggerService.InformationAsync(this.Name, "btnRegister_Click(Update Mode)",
                                    $"این قلم هزینه با شماره {rowNumber} " +
                                    " و شماره سند " + currentDocumentId +
                                    " توسط کاربری با نام " +
                                    currentUser.UserName + " ایجاد گردید.");

                                //var sumPrice = 0d;
                                //sumPrice += price;
                                var currentFundId = fundId.Value;
                                var fundStatus = await _fundService.SubValueFromFundAsync(currentFundId, price);

                                await LoggerService.InformationAsync(this.Name, "btnRegister_Click(Update Mode)",
                                    $"مبلغ " + price + " ریال از صندوق شماره " + currentFundId +
                                    " جهت قلم هزینه شماره " + rowNumber +
                                    " با شماره سند " + currentDocumentId +
                                    " توسط کاربری با نام " +
                                    currentUser.UserName + " کسر گردید. ");
                            }
                        }
                        catch (Exception exception)
                        {
                            var dlg = new CustomDialogs(320, 200);
                            dlg.Invoke("خطا در ثبت اطلاعات",
                                "خطای زیر به وقوع پیوست \n" + exception.Message,
                                CustomDialogs.ImageType.itError2, CustomDialogs.ButtonType.Ok,
                                InitialHelper.BackColorCustom);

                            await LoggerService.ErrorAsync(this.Name, "btnRegister_Click(Update Mode)", exception.Message,
                                exception.ToDetailedString());
                            return;
                        }

                        //CommonHelper.ClearInputControls(pnl_Data, false, false);
                        CommonHelper.EnableControls(pnl_Data, false);
                        btnCancel.Enabled = false;
                        btnInsert.Enabled = true;
                        btnDelete.Enabled = true;

                        CommonHelper.ShowNotificationMessage("ویرایش سند هزینه", "این لیست هزینه با شماره سند "
                            + currentDocument.Id + " ویرایش گردید.");
                    }
                    catch (Exception exception)
                    {
                        var dlg = new CustomDialogs(320, 200);
                        dlg.Invoke("خطا در ثبت اطلاعات",
                            "خطای زیر به وقوع پیوست \n" + exception.Message,
                            CustomDialogs.ImageType.itError2, CustomDialogs.ButtonType.Ok,
                            InitialHelper.BackColorCustom);

                        await LoggerService.ErrorAsync(this.Name, "btnRegister_Click(Update Mode)", exception.Message,
                            exception.ToDetailedString());

                        return;
                    }
                    break;
                case CommonHelper.Mode.Cancel:
                    break;
                case CommonHelper.Mode.None:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            rgv_Expenses.Enabled = true;
            btnRegister.Enabled = false;
            btnClose.Enabled = true;
            BindGrid();
            _mode = CommonHelper.Mode.None;
        }

        private async Task<bool> IsNotValidExpenseList()
        {
            try
            {
                foreach (var row in rgv_BuyList.Rows)
                {
                    for (var j = 0; j < row.Cells.Count; j++)
                    {
                        if (row.Cells[j].ColumnInfo.FieldName == "DeleteRow" ||
                            row.Cells[j].ColumnInfo.FieldName == "RowNumber" ||
                            row.Cells[j].ColumnInfo.FieldName == "FundCurrentValue" ||
                            row.Cells[j].ColumnInfo.FieldName == "Comment")
                            continue;

                        if (row.Cells[j].Value != null &&
                        !string.IsNullOrEmpty(row.Cells[j].Value.ToString()) &&
                        !string.IsNullOrWhiteSpace(row.Cells[j].Value.ToString()) &&
                        row.Cells[j].Value.ToString() != "0") continue;

                        var dlg = new CustomDialogs(320, 200);
                        dlg.Invoke("خطا",
                            "خطا در " + "سطر: " + row.Index + " ستون: " +
                            row.Cells[j].ColumnInfo.FieldName,
                            CustomDialogs.ImageType.itError5, CustomDialogs.ButtonType.Ok,
                            InitialHelper.BackColorCustom);
                        return true;
                    }
                }
            }
            catch (Exception exception)
            {
                var dlg = new CustomDialogs(320, 200);
                dlg.Invoke("خطا", exception.Message,
                    CustomDialogs.ImageType.itError5, CustomDialogs.ButtonType.Ok,
                    InitialHelper.BackColorCustom);

                await LoggerService.ErrorAsync(this.Name, "IsNotValidExpenseList", exception.Message,
                    exception.ToDetailedString());
                return true;
            }

            return _error;
        }

        private async void rgv_BuyList_CellValidating(object sender, CellValidatingEventArgs e)
        {
            decimal fundCurrentValue = 0, price = 0;

            var fundCurrentValueCellValue = e.Row?.Cells["FundCurrentValue"]?.Value;
            var priceCell = e.Row?.Cells["Price"];
            var priceCellValue = priceCell?.Value;

            if (priceCell == null) return;

            if (fundCurrentValueCellValue != null)
            {
                fundCurrentValue = fundCurrentValueCellValue.ToString().ClearSeparateEx();
            }
            if (priceCellValue != null)
            {
                price = priceCellValue.ToString().ClearSeparateEx();
            }

            if (price != 0 && fundCurrentValue != 0 && price > fundCurrentValue) //&& _mode != CommonHelper.Mode.Update)
            {
                priceCell.ErrorText = "موجودی صندوق کافی نیست";
                priceCell.Style.ForeColor = Color.Red;
                //priceCell.Style.BackColor = Color.Black;

                e.Row.ErrorText = "قیمت بیشتر از موجودی صندوق می باشد.";
                _error = true;

                await LoggerService.WarningAsync(this.Name, "rgv_BuyList_CellValidating", "موجودی صندوق کافی نیست",
                    $" قیمت:{price}" + $", موجودی جاری صندوق: {fundCurrentValue}");
            }
            else
            {
                priceCell.ErrorText = string.Empty;
                priceCell.Style.ForeColor = Color.Black;
                _error = false;
            }
            // e.Cancel = true;
            //var column = e.Column as GridViewDataColumn;
            //if (e.Row is GridViewDataRowInfo && column != null)
            //{
            //    if (string.IsNullOrEmpty((string)e.Value) || ((string)e.Value).Trim() == string.Empty)
            //    {
            //        e.Cancel = true;

            //        ((GridViewDataRowInfo)e.Row).ErrorText = "Validation error!";
            //    }
            //    else
            //    {
            //        ((GridViewDataRowInfo)e.Row).ErrorText = string.Empty;
            //    }
            //}
            //if (e.Value == null)
            //    e.Cancel = true;

            //if (e.Cancel)
            //    _hasValidationError = true;
        }

        private void txt_ExpenseDocumentDate_TextChanged(object sender, EventArgs e)
        {
            if (_mode == CommonHelper.Mode.Insert)
            {
                btnRegister.Enabled = (txt_ExpenseDocumentDate.Text != string.Empty &&
                                       !_error &&
                                       txt_ExpenseDocumentDate.Text != CommonLibrary.Properties.Resources.DateMaskFormat);
            }
        }

        private async Task<decimal> GetSumPrice()
        {
            var sumPrice = 0.0m;
            try
            {
                foreach (var row in rgv_BuyList.Rows)
                {
                    if (row.Cells["Price"].Value == null) continue;
                    var sum = sumPrice;
                    var currentPrice = row.Cells["Price"].Value.ToString().ClearSeparateEx();
                    sum += currentPrice;
                    sumPrice = sum;
                }
            }
            catch (Exception exception)
            {
                await LoggerService.ErrorAsync(this.Name, "GetSumPrice", exception.Message,
                    exception.ToDetailedString());
            }
            return sumPrice;
        }

        private static decimal GetSumPrice(IEnumerable<ViewModelLoadAllExpense> list)
        {
            try
            {
                var sumPrice = 0.0m;
                foreach (var field in list)
                {
                    var sum = sumPrice;
                    var currentPrice = Convert.ToString(field.Price, CultureInfo.InvariantCulture).ClearSeparateEx();
                    sum += currentPrice;
                    sumPrice = sum;
                }
                return sumPrice;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return 0;
            }
        }
        private async void ReturnExpenseDocumentDetailsById()
        {
            try
            {
                if (!(rgv_Expenses.CurrentRow is GridViewDataRowInfo dataRow)) return;

                _documentId = int.Parse(dataRow.Cells["ExpenseDocumentId"].Value.ToString());
                _expenseDocumentDate = dataRow.Cells["ExpenseDocumentPersianDate"].Value.ToString();

                //int? currentUserId = null;
                //if (!await InitialHelper.CurrentUser.IsAdmin())
                //    currentUserId = InitialHelper.CurrentUser.Id;

                _expenses = await _expenseDocumentService.GetExpensesByDocumentIdAsync(_documentId);
                _sumPrice = GetSumPrice(_expenses);
            }
            catch (Exception exception)
            {
                await LoggerService.ErrorAsync(this.Name, "ReturnExpenseDocumentDetailsById", exception.Message,
                    exception.ToDetailedString());
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            _lock = true;
            ReturnExpenseDocumentDetailsById();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lbl_DocumentId.Text = Convert.ToString(_documentId);
            txt_ExpenseDocumentDate.Text = _expenseDocumentDate;
            rgv_BuyList.DataSource = _expenses;
            lbl_SumPrice.Text = "هزینه کل: " + _sumPrice.ToString("N0") + " ریال";
            CommonHelper.IndicatorLoading(_pictureBox, false);
            _backgroundWorker.Dispose();
            _lock = false;
        }
        private void rgvExpenses_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
        {
            if (_lock) return;
            //if(backgroundWorker1.IsBusy)
            backgroundWorker1.RunWorkerAsync();
            CommonHelper.IndicatorLoading(_pictureBox, true);
        }
        private void rgv_BuyList_ViewCellFormatting(object sender, CellFormattingEventArgs e)
        {
            if (e.CellElement.RowInfo.Group != null || !(e.CellElement is GridSummaryCellElement)) return;

            //if (e.CellElement.ColumnInfo.FieldName == "CurrentFundValue")
            //{
            //    e.CellElement.ForeColor = Color.Purple;
            //    e.CellElement.TextAlignment = ContentAlignment.MiddleCenter;
            //    e.CellElement.Font = CommonHelper.SummaryFont;
            //    e.CellElement.DrawBorder = true;
            //    e.CellElement.DrawFill = true;
            //    e.CellElement.NumberOfColors = 1;
            //    e.CellElement.BackColor = Color.BurlyWood;
            //}
            //else
            {
                e.CellElement.ForeColor = Color.White;
                e.CellElement.TextAlignment = ContentAlignment.MiddleCenter;
                e.CellElement.Font = CommonHelper.SummaryFont;
                e.CellElement.DrawBorder = true;
                e.CellElement.DrawFill = true;
                e.CellElement.NumberOfColors = 1;
                e.CellElement.BackColor = Color.DimGray;
            }
            //lbl_sum.Text = e.CellElement.Text;

            //    e.CellElement.Text = CommonHelper.AddSeparate(e.CellElement.Text) + " ریال";
            //string.Format("{0:N0}", e.CellElement.Text);
            //else
            //{
            //    e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local);
            //    e.CellElement.ResetValue(LightVisualElement.TextAlignmentProperty, ValueResetFlags.Local);
            //    e.CellElement.ResetValue(LightVisualElement.FontProperty, ValueResetFlags.Local);
            //}
        }

        //private void rgv_BuyList_Initialized(object sender, EventArgs e)
        //{
        //    //// var summaryItem = new GridViewSummaryItem {Name = "Price", AggregateExpression = "Sum(Price)"};
        //    //var summaryRowItem = new GridViewSummaryRowItem
        //    //{
        //    //    new GridViewSummaryItem("TempPrice", "جمع هزینه: " + "{0:N0}" + " ریال", GridAggregateFunction.Sum)
        //    //};
        //    ////lbl_sum.Text = summaryRowItem.Fields.GetValue(14).ToString();
        //    //rgv_BuyList.SummaryRowsTop.Add(summaryRowItem);
        //    ////rgv_BuyList.SummaryRowsBottom.Add(summaryRowItem);

        //    //var subtotalPriceItem = new GridViewSummaryItem("TempPrice", "جمع هزینه: " + "{0:N0}" + " ریال", GridAggregateFunction.Sum);
        //    //var subtotalRow = new GridViewSummaryRowItem(new GridViewSummaryItem[] { subtotalPriceItem });
        //    ////rgv_BuyList.SummaryRowsTop.Add(subtotalRow);
        //    //rgv_BuyList.MasterTemplate.SummaryRowGroupHeaders.Add(subtotalRow);


        //    var summary = new GridViewSummaryItem("TempPrice", " Sum: {0} ", GridAggregateFunction.Sum);
        //    rgv_BuyList.MasterTemplate.SummaryRowGroupHeaders.Add(
        //        new GridViewSummaryRowItem(new GridViewSummaryItem[] { summary }));


        //}

        //private void rgv_BuyList_GroupSummaryEvaluate(object sender, GroupSummaryEvaluationEventArgs e)
        //{
        //    //MessageBox.Show(e.Value.ToString());
        //}

        //private void rgv_BuyList_ValueChanging(object sender, ValueChangingEventArgs e)
        //{
        //    //  if (sender is GridHeaderCellElement)
        //    //      return;

        //    //  var cell1 = sender as GridDataCellElement;
        //    //  if (cell1 == null)
        //    //      return;
        //    ////  if ( cell1.ColumnInfo.FieldName == "TempPrice")
        //    //  {
        //    //         // var cell = (GridSpinEditor) sender;
        //    //          SumOfAmountColumn += Convert.ToDecimal(e.NewValue) - Convert.ToDecimal(cell1.Value);

        //    //  }
        //    //else
        //    //{
        //    //    var cell = (GridDataCellElement)sender;
        //    //    SumOfAmountColumn += Convert.ToDecimal(e.NewValue) - Convert.ToDecimal(cell.Value);
        //    //}  
        //}

        private void rgv_BuyList_UserDeletedRow(object sender, GridViewRowEventArgs e)
        {
            var val = GetSumPrice();
            lbl_SumPrice.Text = "هزینه کل: " + val.Result.ToString("N0") + " ریال";
            //+ "   معادل: " + NumToStr.ToString(Convert.ToString(val)) + " ریال";
        }

        private void rgv_Expenses_CellClick(object sender, GridViewCellEventArgs e)
        {
            if (rgv_Expenses.Enabled && rgv_Expenses.Rows.Count > 0)
                btnModify.Enabled = true;
            else btnModify.Enabled = false;
        }

        //private void rgv_BuyList_RowValidating(object sender, RowValidatingEventArgs e)
        //{
        //    //if (e.Row == null) { return; }

        //    //decimal fundCurrentValue = 0, price = 0;


        //    //if (e.Row.Cells["FundCurrentValue"]?.Value != null)
        //    //{
        //    //    fundCurrentValue = e.Row.Cells["FundCurrentValue"].Value.ToString().ClearSeparateEx();
        //    //}
        //    //if (e.Row.Cells["Price"]?.Value != null)
        //    //{
        //    //    price = e.Row.Cells["Price"].Value.ToString().ClearSeparateEx();
        //    //}

        //    //if (price <= fundCurrentValue) return;

        //    ////e.Row.Cells["Price"].Style.ForeColor = Color.Red;

        //    ////PriceOverflow = true;

        //    ////MessageBox.Show("Invalid data");
        //    //e.Cancel = true;
        //}

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rgv_BuyList_UserAddingRow(object sender, GridViewRowCancelEventArgs e)
        {
            rgv_BuyList.MasterView.TableAddNewRow.Cells[2].BeginEdit();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (rgv_Expenses.Rows.Count <= 0) return;

            if (!InitialHelper.HasPermissionFor(this.Name, PermissionMode.Delete))
            {
                CommonHelper.ShowNotificationMessage(DefaultConstants.IllegalAccess, DefaultConstants.DeleteActionNotAllow);
                return;
            }

            var dialog = new CustomDialogs(350, 200);
            dialog.Invoke("هشدار حذف", "آيا میخواهید این سند هزینه را حذف کنید؟",
                CustomDialogs.ImageType.itQuestion2,
                CustomDialogs.ButtonType.YesNo, InitialHelper.BackColorCustom);

            if (!dialog.Yes) return;

            await _expenseDocumentService.RemoveAsync(_documentId);

            CommonHelper.ShowNotificationMessage("حذف سند هزینه",
                $"سند هزینه با شماره {_documentId} به همراه کلیه اقلامش حذف گردید");

            await LoggerService.InformationAsync(this.Name, "BtnDelete_Click", $"حذف سند هزینه شماره {_documentId}",
                $"این سند هزینه توسط کاربری با نام {InitialHelper.CurrentUser.UserName} حذف گردید.");

            btnRegister.Enabled = false;
            btnClose.Enabled = true;
            BindGrid();
            _mode = CommonHelper.Mode.None;

            BindGrid();
        }

        private void rddl_Users_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (!txt_ExpenseDocumentDate.Text.IsValidPersianDate()) return;

            ReturnExpenseDocumentDetailsById();
            txt_ExpenseDocumentDate_TextChanged(sender, e);
        }
    }
}

//GridViewRowInfo lastRow = radGridView1.Rows[radGridView1.Rows.Count - 1];