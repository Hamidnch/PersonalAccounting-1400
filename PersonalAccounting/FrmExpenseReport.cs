using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using PersonalAccounting.BLL.IService;
using PersonalAccounting.CommonLibrary.Helper;
using PersonalAccounting.UI.Infrastructure;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Export;

namespace PersonalAccounting.UI
{
    public partial class FrmExpenseReport : BaseForm
    {
        private readonly IExpenseService _expenseService;

        private readonly HashSet<GridViewRowInfo> _rows = new HashSet<GridViewRowInfo>();

        public static FrmExpenseReport AFrmExpenseReport = null;
        public static FrmExpenseReport Instance()
        {
            return AFrmExpenseReport ?? (AFrmExpenseReport = IocConfig.Container.GetInstance<FrmExpenseReport>());
        }
        public FrmExpenseReport(IExpenseService expenseService)
        {
            _expenseService = expenseService;
            InitializeComponent();
            saveFileDialog1.Filter = "Excel (*.xls)|*.xls";

            BindGrid();
        }

        private void RunExportToExcelML(string fileName, ref bool openExportFile)
        {
            var excelExporter = new ExportToExcelML(this.rgv_Expenses);

            //switch (this.radComboBoxSummaries.SelectedIndex)
            //{
            //    case 0:
            //        excelExporter.SummariesExportOption = SummariesOption.ExportAll;
            //        break;
            //    case 1:
            //        excelExporter.SummariesExportOption = SummariesOption.ExportOnlyTop;
            //        break;
            //    case 2:
            //        excelExporter.SummariesExportOption = SummariesOption.ExportOnlyBottom;
            //        break;
            //    case 3:
            //        excelExporter.SummariesExportOption = SummariesOption.DoNotExport;
            //        break;
            //}

            //set export settings 
            excelExporter.ExportVisualSettings = true;
            excelExporter.ExportHierarchy = false;
            excelExporter.HiddenColumnOption = HiddenOption.ExportAsHidden;

            try
            {
                this.Cursor = Cursors.WaitCursor;

                excelExporter.RunExport(fileName);

                RadMessageBox.SetThemeName(this.rgv_Expenses.ThemeName);
                var dr = RadMessageBox.Show("The data in the grid was exported successfully. Do you want to open the file?",
                    "Export to Excel", MessageBoxButtons.YesNo, RadMessageIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    openExportFile = true;
                }
            }
            catch (IOException ex)
            {
                RadMessageBox.SetThemeName(this.rgv_Expenses.ThemeName);
                RadMessageBox.Show(this, ex.Message, "I/O Error", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void BindGrid()
        {
            //int? currentUserId = null;
            //if (!await InitialHelper.CurrentUser.IsAdmin())
            //int? currentUserId = InitialHelper.CurrentUser.Id;

            rgv_Expenses.BeginUpdate();
            //// Group By
            //var descriptor = new GroupDescriptor();
            //descriptor.GroupNames.Add("Price", ListSortDirection.Ascending);
            //this.rgv_Expenses.GroupDescriptors.Add(descriptor);

            //rgv_Expenses.MasterView.SummaryRows[0].PinPosition = PinnedRowPosition.Bottom;
            //rgv_Expenses.MasterTemplate.BottomPinnedRowsMode = GridViewBottomPinnedRowsMode.Fixed;
            
            rgv_Expenses.MasterTemplate.ShowTotals = true;
            rgv_Expenses.MasterTemplate.ShowSubTotals = true;
            rgv_Expenses.MasterTemplate.ShowParentGroupSummaries = true;
            rgv_Expenses.EnableAlternatingRowColor = true;
            rgv_Expenses.EnableGrouping = false;

            //rgv_Expenses.MasterTemplate.AutoExpandGroups = true;
            //rgv_Expenses.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;

            //rgv_Expenses.GroupDescriptors.Clear();
            //rgv_Expenses.GroupDescriptors.Add(new GridGroupByExpression("ArticleGroupId Group By ArticleGroupId"));

            var summaryFiItem = new GridViewSummaryItem("Fi", "{0:n0}" + DefaultConstants.MoneyUnit, GridAggregateFunction.Sum);
            var summaryCountItem = new GridViewSummaryItem("Count", "{0:n0}" + DefaultConstants.MoneyCount, GridAggregateFunction.Sum);
            var summaryPriceItem = new GridViewSummaryItem("Price", "{0:n0}" + DefaultConstants.MoneyUnit, GridAggregateFunction.Sum);
            var summaryRowItem = new GridViewSummaryRowItem { summaryFiItem, summaryCountItem, summaryPriceItem };
            rgv_Expenses.SummaryRowsBottom.Add(summaryRowItem);
            rgv_Expenses.DataSource = _expenseService.LoadAllExpenses();
            rgv_Expenses.EndUpdate();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rgv_Expenses_GroupByChanged(object sender, GridViewCollectionChangedEventArgs e)
        {
            rgv_Expenses.MasterTemplate.Refresh();
        }

        private void rgv_Expenses_CreateCell(object sender, GridViewCreateCellEventArgs e)
        {
            if (e.CellType == typeof(GridGroupContentCellElement))
            {
                e.CellElement = new MyGridGroupContentCellElement(e.Column, e.Row);
            }
        }

        private void rgv_Expenses_ViewCellFormatting(object sender, CellFormattingEventArgs e)
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
                summaryCell.RowElement.Font = new Font(summaryCell.RowElement.Font, FontStyle.Bold);

                //summaryCell.RowElement.DrawBorder = true;
                //summaryCell.RowElement.BorderBoxStyle = BorderBoxStyle.FourBorders;
                //summaryCell.RowElement.BorderLeftWidth = 0;
                //summaryCell.RowElement.BorderRightWidth = 0;
                //summaryCell.RowElement.BorderBottomWidth = 0;
                //summaryCell.RowElement.BorderTopWidth = 1;
                //summaryCell.RowElement.BorderTopColor = Color.Black;
                //summaryCell.RowElement.TextAlignment = ContentAlignment.MiddleCenter;
            }
            else if (!_rows.Contains(summaryCell.RowInfo))
            {
                summaryCell.RowElement.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local);
                summaryCell.RowElement.ResetValue(LightVisualElement.GradientStyleProperty, ValueResetFlags.Local);
                summaryCell.RowElement.ResetValue(VisualElement.BackColorProperty, ValueResetFlags.Local);
            }
        }

        private void rgv_Expenses_GroupSummaryEvaluate(object sender, GroupSummaryEvaluationEventArgs e)
        {
            //if (e.Parent != rgv_Expenses.MasterTemplate)
            //{
            //    e.FormatString = string.Format("{0} - " + e.Group.ItemCount + " records found.", e.Value);
            //}
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            if (saveFileDialog1.FileName.Equals(string.Empty))
            {
                RadMessageBox.SetThemeName(this.rgv_Expenses.ThemeName);
                RadMessageBox.Show("Please enter a file name.");
                return;
            }

            var fileName = this.saveFileDialog1.FileName;
            var openExportFile = false;

            RunExportToExcelML(fileName, ref openExportFile);

            if (!openExportFile) return;

            try
            {
                Process.Start(fileName);
            }
            catch (Exception ex)
            {
                var message = $"The file cannot be opened on your system.\nError message: {ex.Message}";
                RadMessageBox.Show(message, "Open File", MessageBoxButtons.OK, RadMessageIcon.Error);
            }


            //Telerik.WinControls.Export.GridViewPdfExport pdfExporter = new Telerik.WinControls.Export.GridViewPdfExport(this.rgv_Expenses);
            //pdfExporter.FileExtension = "pdf";
            //pdfExporter.SummariesExportOption = Telerik.WinControls.UI.Export.SummariesOption.ExportAll;
            //string fileName = @"..\..\export" + DateTime.Now.ToLongTimeString().Replace(":", "_") + ".pdf";

            //foreach (var row in this.rgv_Expenses.Rows)
            //{
            //    if (row is GridViewDataRowInfo)
            //    {
            //        row.IsVisible = false;
            //    }
            //}
            //pdfExporter.HiddenRowOption = Telerik.WinControls.UI.Export.HiddenOption.DoNotExport;
            //pdfExporter.RunExport(fileName, new Telerik.WinControls.Export.PdfExportRenderer());
            //Process.Start(fileName);
        }

        //private void rgv_Expenses_GroupSummaryEvaluate(object sender, GroupSummaryEvaluationEventArgs e)
        //{

        //    //GridGroupByExpression groupExprCol1 = new GridGroupByExpression("col_1 Group By  col_1");
        //    //rgv_Expenses.GroupDescriptors.Add(groupExprCol1);
        //    //GridViewSummaryItem sumItemValue = new GridViewSummaryItem("Price", "{0,12:#,0;(#,0)}",
        //    //    GridAggregateFunction.Sum);
        //    //GridViewSummaryRowItem sumGroupCol1 = new GridViewSummaryRowItem();
        //    //sumGroupCol1.Add(sumItemValue);
        //    //rgv_Expenses.MasterTemplate.SummaryRowsBottom.Add(sumGroupCol1);

        //}

        //private void FrmExpenseReport_Load(object sender, EventArgs e)
        //{
        //    //this.rgv_Expenses.GroupDescriptors.Clear();
        //    ////this.rgv_Expenses.GroupDescriptors.Add(new GridGroupByExpression("DocumentId Group By DocumentId"));

        //    //var item1 = new GridViewSummaryRowItem();

        //    //item1.Add(new GridViewSummaryItem("Price", "Sum: {0:F2}; ", GridAggregateFunction.Sum));

        //    //this.rgv_Expenses.MasterTemplate.SummaryRowsBottom.Add(item1);

        //    ////GridViewSummaryRowItem item2 = new GridViewSummaryRowItem();

        //    ////item2.Add(new GridViewSummaryItem("Freight", "Min: {0:F2}", GridAggregateFunction.Min));
        //    ////this.rgv_Expenses.MasterTemplate.SummaryRowsTop.Add(item2);
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    //GridViewSummaryRowItem item = new GridViewSummaryRowItem();
        //    //var formatString = "Sum: {0:F2}; ";


        //    //item.Add(new GridViewSummaryItem(
        //    //    "Price",
        //    //    formatString,
        //    //    GridAggregateFunction.Sum));

        //    //this.rgv_Expenses.MasterTemplate.ShowParentGroupSummaries = true;
        //    //this.rgv_Expenses.MasterTemplate.SummaryRowsBottom.Add(item);
        //    //this.rgv_Expenses.MasterTemplate.ShowTotals = true;
        //    //this.rgv_Expenses.MasterTemplate.ShowTotals = true;
        //    //this.rgv_Expenses.MasterTemplate.ShowParentGroupSummaries = true;

        //}
    }
}


public class MyGridGroupContentCellElement : GridGroupContentCellElement
{
    private StackLayoutElement stack;
    private bool showSummaryCells_Renamed = true;

    public MyGridGroupContentCellElement(GridViewColumn column, GridRowElement row) : base(column, row)
    {
        // creating the elements here in order to have a valid insance of a row
        if (stack == null)
            CreateStackElement(row);

        ClipDrawing = true;
        row.GridControl.TableElement.HScrollBar.Scroll += HScrollBar_Scroll;
        row.GridControl.ColumnWidthChanged += GridControl_ColumnWidthChanged;
        row.GridControl.GroupDescriptors.CollectionChanged += GroupDescriptors_CollectionChanged;
    }

    private void GroupDescriptors_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
    {
        if (RowInfo.Parent is GridViewGroupRowInfo && ((GridViewGroupRowInfo)RowInfo.Parent).IsExpanded)
            InvalidateArrange();
    }

    private void HScrollBar_Scroll(object sender, ScrollEventArgs e)
    {
        if (e.NewValue != e.OldValue)
            stack.PositionOffset = new SizeF(0 - e.NewValue, 0);
    }

    private void CreateStackElement(GridRowElement row)
    {
        stack = new StackLayoutElement();
        stack.AutoSizeMode = RadAutoSizeMode.FitToAvailableSize;
        stack.AutoSize = true;
        stack.StretchHorizontally = true;
        stack.Alignment = ContentAlignment.BottomCenter;
        stack.DrawFill = true;
        stack.BackColor = Color.White;
        int i = 0;
        while (i < row.RowInfo.Cells.Count)
        {
            SummaryCellElement element = new SummaryCellElement();
            element.ColumnName = row.RowInfo.Cells[i].ColumnInfo.Name;
            element.StretchHorizontally = false;
            element.StretchVertically = true;
            element.DrawBorder = true;
            element.BorderGradientStyle = GradientStyles.Solid;
            element.BorderColor = Color.LightBlue;
            element.ForeColor = Color.Black;
            element.GradientStyle = GradientStyles.Solid;
            stack.Children.Add(element);
            i += 1;
        }

        Children.Add(stack);
    }

    public override void Initialize(GridViewColumn column, GridRowElement row)
    {
        base.Initialize(column, row);
        ShowSummaryCells = (!row.Data.IsExpanded) || row.Data.Group.Groups.Count > 0;
    }

    protected override void DisposeManagedResources()
    {
        if (GridControl != null)
        {
            GridControl.ColumnWidthChanged -= GridControl_ColumnWidthChanged;
            GridControl.GroupDescriptors.CollectionChanged -= GroupDescriptors_CollectionChanged;
        }

        base.DisposeManagedResources();
    }

    public bool ShowSummaryCells
    {
        get
        {
            return showSummaryCells_Renamed;
        }
        set
        {
            if (showSummaryCells_Renamed != value)
            {
                showSummaryCells_Renamed = value;

                if (stack == null)
                    CreateStackElement(RowElement);

                if (showSummaryCells_Renamed)
                    stack.Visibility = ElementVisibility.Visible;
                else
                    stack.Visibility = ElementVisibility.Hidden;
            }
        }
    }

    private void GridControl_ColumnWidthChanged(object sender, ColumnWidthChangedEventArgs e)
    {
        InvalidateArrange();
    }

    protected override SizeF ArrangeOverride(SizeF finalSize)
    {
        SizeF size = base.ArrangeOverride(finalSize);

        float x = GridControl.TableElement.GroupIndent * (GridControl.GroupDescriptors.Count - RowInfo.Group.Level - 1);
        float y = size.Height - stack.DesiredSize.Height - 2.0F;
        float width = size.Width - x;
        float height = stack.DesiredSize.Height;

        stack.Arrange(new RectangleF(x, y, width, height));

        foreach (SummaryCellElement element in stack.Children)
        {
            Size elementSize = new Size(RowInfo.Cells[element.ColumnName].ColumnInfo.Width + GridControl.TableElement.CellSpacing, 30);
            Console.WriteLine(RowInfo.Cells[element.ColumnName].ColumnInfo.Width + " " + RowInfo.Cells[element.ColumnName].ColumnInfo.Name);
            element.MinSize = elementSize;
            element.MaxSize = elementSize;
        }

        return size;
    }

    public override void SetContent()
    {
        base.SetContent();
        TextAlignment = ContentAlignment.TopLeft;
        ShowSummaryCells = (!RowInfo.Group.IsExpanded) || RowInfo.Group.Groups.Count > 0;

        GridViewGroupRowInfo rowInfo = (GridViewGroupRowInfo)RowInfo;

        if (rowInfo.Parent is GridViewGroupRowInfo && !((GridViewGroupRowInfo)rowInfo.Parent).IsExpanded)
            return;

        Dictionary<string, string> values = GetSummaryValues();
        int index = 0;

        foreach (KeyValuePair<string, string> column in values)
        {
            SummaryCellElement element = ((SummaryCellElement)stack.Children[index]);
            index += 1;

            if (ViewTemplate.Columns[column.Key].IsGrouped && ViewTemplate.ShowGroupedColumns == false)
                element.Visibility = ElementVisibility.Collapsed;
            else
            {
                element.Visibility = ElementVisibility.Visible;
                element.Text = column.Value;
            }
        }
    }

    public virtual Dictionary<string, string> GetSummaryValues()
    {
        if (ElementTree == null)
            return new Dictionary<string, string>();

        Dictionary<string, string> result = new Dictionary<string, string>();
        if (GridControl.SummaryRowsTop.Count > 0)
        {
            foreach (SummaryCellElement cell in stack.Children)
            {
                if (GridControl.SummaryRowsTop[0][cell.ColumnName] == null)
                    result.Add(cell.ColumnName, string.Empty);
                else
                {
                    GridViewSummaryItem summaryItem = GridControl.SummaryRowsTop[0][cell.ColumnName][0];
                    object value = ViewTemplate.DataView.Evaluate(summaryItem.GetSummaryExpression(), GetDataRows());
                    string text = string.Format(summaryItem.FormatString, value);
                    result.Add(summaryItem.Name, text);
                }
            }
        }
        return result;
    }

    private IEnumerable<GridViewRowInfo> GetDataRows()
    {
        Queue<GridViewRowInfo> queue = new Queue<GridViewRowInfo>();
        queue.Enqueue(RowInfo);

        List<GridViewRowInfo> list = new List<GridViewRowInfo>();

        while (queue.Count != 0)
        {
            GridViewRowInfo currentRow = queue.Dequeue();

            if (currentRow is GridViewDataRowInfo)
                list.Add(currentRow);

            foreach (GridViewRowInfo row in currentRow.ChildRows)
                queue.Enqueue(row);
        }

        return list;
    }

    protected override Type ThemeEffectiveType
    {
        get
        {
            return typeof(GridGroupContentCellElement);
        }
    }
}

public class SummaryCellElement : LightVisualElement
{
    private string columnName_Renamed;

    public string ColumnName
    {
        get
        {
            return columnName_Renamed;
        }
        set
        {
            columnName_Renamed = value;
        }
    }
}
