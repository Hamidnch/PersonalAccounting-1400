using PersonalAccounting.CommonLibrary.Helper;
using PersonalAccounting.UI.Helper;
using PersonalAccounting.UI.Infrastructure;
using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls.UI.Localization;

namespace PersonalAccounting.UI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            var irCulture = CultureInfo.GetCultureInfo("fa-IR");
            CultureInfo.DefaultThreadCurrentCulture = irCulture;
            CultureInfo.DefaultThreadCurrentUICulture = irCulture;

            Thread.CurrentThread.CurrentCulture = irCulture;
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;

            //new Mutex(true, "PersonalAccounting", out var ok);
            //if (!ok)
            //{
            //    MessageBox.Show("يك نمونه از اين برنامه در حال حاضر در حال اجرا مي باشد", "خطا در اجرا",
            //        MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1,
            //        MessageBoxOptions.RightAlign);
            //    return;
            //}
            RadGridLocalizationProvider.CurrentProvider = new PersianRadHelper();
            RadGridLocalizationProvider.CurrentProvider.ApplyCorrectYeKe();

            //Installing TTahoma.ttf font
            InitialHelper.InstallFont();
            InitialHelper.SeedData();

            //var path = Path.GetDirectoryName(
            //    System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)?.Replace("file:\\", "");
            //var dbPath = path + "\\db\\PA.nch";
            //MessageBox.Show(dbPath);
            //if (!File.Exists(dbPath))
            //{

            // Initialize Seed Data
            //var dbInitializer = IocConfig.Container.GetInstance<InitializeData>();
            //dbInitializer.ExecuteSeedData();

            //}

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new FrmLogin());
            Application.Run(IocConfig.Container.GetInstance<FrmLogin>());
        }
    }
}
