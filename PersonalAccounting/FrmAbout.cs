using System;
using System.Reflection;
using System.Windows.Forms;

namespace PersonalAccounting.UI
{
    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();
            this.Text = $@"About {AssemblyTitle}";
            this.lbl_ProductName.Text = AssemblyProduct;
            this.lbl_Version.Text = $@"نسخه {AssemblyVersion}";
            //this.lbl_Copyright.Text = AssemblyCopyright;
            this.lbl_Email.Text = @" Hamidnch2007@Gamil.com ";
            this.lbl_CompanyName.Text = AssemblyCompany;
            this.lbl_Description.Text = AssemblyDescription;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                var attributes = Assembly.GetExecutingAssembly()
                    .GetCustomAttributes(typeof(AssemblyTitleAttribute), false);

                if (attributes.Length <= 0)
                    return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);

                var titleAttribute = (AssemblyTitleAttribute)attributes[0];
                return titleAttribute.Title != "" ? titleAttribute.Title
                    : System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion => Assembly.GetExecutingAssembly().GetName().Version.ToString();

        public string AssemblyDescription
        {
            get
            {
                var attributes = Assembly.GetExecutingAssembly()
                    .GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);

                return attributes.Length == 0 ? "" : ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                var attributes = Assembly.GetExecutingAssembly()
                    .GetCustomAttributes(typeof(AssemblyProductAttribute), false);

                return attributes.Length == 0 ? "" : ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        //public string AssemblyCopyright
        //{
        //    get
        //    {
        //        var attributes = Assembly.GetExecutingAssembly()
        //            .GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);

        //        return attributes.Length == 0 ? "" : ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
        //    }
        //}

        public string AssemblyCompany
        {
            get
            {
                var attributes = Assembly.GetExecutingAssembly()
                    .GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);

                return attributes.Length == 0 ? "" : ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion
    }
}
