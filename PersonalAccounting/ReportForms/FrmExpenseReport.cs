using PersonalAccounting.BLL.IService;
using PersonalAccounting.CommonLibrary.Helper;
using PersonalAccounting.UI.Infrastructure;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

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

            //// Group By
            //var descriptor = new GroupDescriptor();
            //descriptor.GroupNames.Add("Price", ListSortDirection.Ascending);
            //this.rgv_Expenses.GroupDescriptors.Add(descriptor);

            rgv_Expenses.MasterTemplate.ShowTotals = true;
            rgv_Expenses.EnableAlternatingRowColor = true;
            //rgv_Expenses.MasterTemplate.ShowSubTotals = true;
            //rgv_Expenses.MasterTemplate.ShowParentGroupSummaries = true;
            //rgv_Expenses.EnableGrouping = true;

            //rgv_Expenses.MasterTemplate.AutoExpandGroups = true;
            //rgv_Expenses.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;

            //rgv_Expenses.GroupDescriptors.Clear();
            //rgv_Expenses.GroupDescriptors.Add(new GridGroupByExpression("ArticleGroupId Group By ArticleGroupId"));

            var summaryFiItem = new GridViewSummaryItem("Fi", "{0:n0}" + DefaultConstants.MoneyUnit, GridAggregateFunction.Sum);
            var summaryCountItem = new GridViewSummaryItem("Count", "{0:n0}" + DefaultConstants.MoneyCount, GridAggregateFunction.Count);
            var summaryPriceItem = new GridViewSummaryItem("Price", "{0:n0}" + DefaultConstants.MoneyUnit, GridAggregateFunction.Sum);
            var summaryRowItem = new GridViewSummaryRowItem { summaryFiItem, summaryCountItem, summaryPriceItem };
            rgv_Expenses.SummaryRowsBottom.Add(summaryRowItem);
            rgv_Expenses.MasterView.SummaryRows[0].PinPosition = PinnedRowPosition.Bottom;
            rgv_Expenses.MasterTemplate.BottomPinnedRowsMode = GridViewBottomPinnedRowsMode.Float;

            BindGrid();
        }
        private void BindGrid()
        {
            //int? currentUserId = null;
            //if (!await InitialHelper.CurrentUser.IsAdmin())
            //int? currentUserId = InitialHelper.CurrentUser.Id;

            rgv_Expenses.BeginUpdate();
            rgv_Expenses.DataSource = _expenseService.LoadAllExpenses();
            rgv_Expenses.EndUpdate();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
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

        private void btn_Print_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;

            if (saveFileDialog1.FileName.Equals(string.Empty))
            {
                RadMessageBox.SetThemeName(this.rgv_Expenses.ThemeName);
                RadMessageBox.Show("لطفا نام فایل را وارد نمایید");
                return;
            }

            var fileName = saveFileDialog1.FileName;
            var openExportFile = false;

            rgv_Expenses.ExportToExcel(fileName, ref openExportFile, this);

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