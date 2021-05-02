using System.IO;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Export;

namespace PersonalAccounting.CommonLibrary.Helper
{
    public static class ExcelHelper
    {
        public static void ExportToExcel(this RadGridView grid,
            string fileName, ref bool openExportFile, Control parentControl,
            SummariesOption summariesOption = SummariesOption.ExportAll,
            HiddenOption hiddenOption = HiddenOption.ExportAsHidden,
            bool ExportVisualSettings = true, bool ExportHierarchy = false)
        {
            var excelExporter = new ExportToExcelML(grid)
            {
                SummariesExportOption = summariesOption,
                ExportVisualSettings = ExportVisualSettings,
                ExportHierarchy = ExportHierarchy,
                HiddenColumnOption = hiddenOption
            };
            try
            {
                parentControl.Cursor = Cursors.WaitCursor;

                excelExporter.RunExport(fileName);

                RadMessageBox.SetThemeName(grid.ThemeName);
                var dr = RadMessageBox.Show(
                    "اطلاعات گرید با موفقیت به اکسل صادر شد،آیا می خواهید فایل باز شود؟",
                //"The data in the grid was exported successfully. Do you want to open the file?",
                    "ارسال به اکسل", MessageBoxButtons.YesNo, RadMessageIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    openExportFile = true;
                }
            }

            catch (IOException ex)
            {
                RadMessageBox.SetThemeName(grid.ThemeName);
                RadMessageBox.Show(parentControl, ex.Message, "I/O Error", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
            finally
            {
                parentControl.Cursor = Cursors.Default;
            }
        }

        //public static void ExportToPdf(this RadGridView grid)
        //{
        //    GridViewPdfExport pdfExporter = new GridViewPdfExport(grid);
        //    pdfExporter.FileExtension = "pdf";
        //    pdfExporter.SummariesExportOption = SummariesOption.ExportAll;
        //    string fileName = @"..\..\export" + DateTime.Now.ToLongTimeString().Replace(":", "_") + ".pdf";

        //    foreach (var row in grid.Rows)
        //    {
        //        if (row is GridViewDataRowInfo)
        //        {
        //            row.IsVisible = false;
        //        }
        //    }
        //    pdfExporter.HiddenRowOption = HiddenOption.DoNotExport;
        //    pdfExporter.RunExport(fileName, null);
        //    Process.Start(fileName);
        //}
    }
}
