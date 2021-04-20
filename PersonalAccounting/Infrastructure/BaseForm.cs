using PersonalAccounting.BLL.IService;
using PersonalAccounting.CommonLibrary.Helper;
using System.Windows.Forms;

namespace PersonalAccounting.UI.Infrastructure
{
    public class BaseForm : Form
    {
        public readonly ILoggerService LoggerService;

        public CommonHelper.Mode _mode = CommonHelper.Mode.None;
        private Label lbl_FormCaption;
        public ErrorProvider _errorProvider;

        public BaseForm()
        {
            LoggerService = IocConfig.Container.GetInstance<ILoggerService>();
            _errorProvider = new ErrorProvider();

            InitializeComponent();
            //this.FormElement.TitleBar.TitlePrimitive.Alignment = ContentAlignment.MiddleRight;
            //this.FormElement.TitleBar.SystemButtons.RightToLeft = true;
            //Utility.InitFont(this);

            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);

            //this.FormElement.TitleBar.TitlePrimitive.StretchHorizontally = true;
            //this.FormElement.TitleBar.TitlePrimitive.TextAlignment = ContentAlignment.MiddleCenter;

            //CommonHelper.SetAllControlsFont(this.Controls);
            //var allControls = CommonHelper.GetAllControls(this);
            //allControls.ForEach(k => k.Font = new System.Drawing.Font("Arial", 18));

            //var controls = CommonHelper.FindControlByType<RadGridView>(this, true);
            //controls.ForEach(k => k.Font = new System.Drawing.Font("Arial", 18));

            //CommonHelper.SetAllControlsFont(this.Controls);
        }

        //public BaseForm()
        //{

        //}

        private void InitializeComponent()
        {
            this.lbl_FormCaption = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_FormCaption
            // 
            this.lbl_FormCaption.BackColor = System.Drawing.Color.Moccasin;
            this.lbl_FormCaption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_FormCaption.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_FormCaption.Font = new System.Drawing.Font("Tornado Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_FormCaption.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_FormCaption.Location = new System.Drawing.Point(0, 0);
            this.lbl_FormCaption.Name = "lbl_FormCaption";
            this.lbl_FormCaption.Size = new System.Drawing.Size(284, 27);
            this.lbl_FormCaption.TabIndex = 1;
            this.lbl_FormCaption.Text = "فرم";
            this.lbl_FormCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BaseForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbl_FormCaption);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BaseForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ResumeLayout(false);

        }

        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;

                // reduce flickering when switching mdi child forms (see also WndProc)
                cp.ExStyle |= 0x02000000; // Turn on WS_EX_COMPOSITED (which is essentially double buffered)

                return cp;
            }
        }

        protected override void WndProc(ref Message msg)
        {
            const int wmNcPaint = 0x85;
            const int wmSize = 0x05;

            switch (msg.Msg)
            {
                // reduce flickering when switching mdi child forms (see also CreateParams)
                case wmNcPaint when WindowState == FormWindowState.Maximized:
                // reduce flickering when switching mdi child forms (see also CreateParams)
                case wmSize when WindowState == FormWindowState.Maximized:
                    return;
                default:
                    base.WndProc(ref msg);
                    break;
            }
        }

        //private void BaseForm_Load(object sender, System.EventArgs e)
        //{
        //    //if (MdiParent.Controls["panel1"]?.Controls["lbl_FormCaption"] == null) return;

        //    //MdiParent.Controls["panel1"].Controls["lbl_FormCaption"].Text = string.Empty;
        //    //MdiParent.Controls["panel1"].Controls["lbl_FormCaption"].Text = Text;
        //}
    }
}
