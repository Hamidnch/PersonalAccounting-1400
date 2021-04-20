using System.Windows.Forms;

namespace PersonalAccounting.UI
{
    public partial class FrmReplace : FrmFind
    {
        public new RichTextBox RtbInstance
        {
            set => base.RtbInstance = value;
            get => base.RtbInstance;
        }

        public new string InitialText
        {
            set => base.InitialText = value;
        }

        public FrmReplace()
        {
            InitializeComponent();
        }

        private void BtnReplace_Click(object sender, System.EventArgs e)
        {
            if (RtbInstance.SelectionLength <= 0) return;

            var start = RtbInstance.SelectionStart;
            var len = RtbInstance.SelectionLength;
            RtbInstance.Text = RtbInstance.Text.Remove(start, len);
            RtbInstance.Text = RtbInstance.Text.Insert(start, txtReplace.Text);
            RtbInstance.Focus();
        }
    }
}