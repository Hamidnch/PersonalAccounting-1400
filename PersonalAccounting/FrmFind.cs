using System;
using System.Windows.Forms;

namespace PersonalAccounting.UI
{
    public partial class FrmFind : Form
    {
        private int _lastFound = 0;
        public RichTextBox RtbInstance { set; get; } = null;

        public string InitialText
        {
            set => txtSearchText.Text = value;
            get => txtSearchText.Text;
        }
        public FrmFind()
        {
            InitializeComponent();
        }
        private void FrmFind_Load(object sender, EventArgs e)
        {
            if (RtbInstance != null)
                this.RtbInstance.SelectionChanged += rtbInstance_SelectionChanged;
        }

        private void rtbInstance_SelectionChanged(object sender, EventArgs e)
        {
            _lastFound = RtbInstance.SelectionStart;
        }


        private void BtnFindNext_Click(object sender, EventArgs e)
        {
            var options = RichTextBoxFinds.None;
            if (chkMatchCase.Checked) options |= RichTextBoxFinds.MatchCase;
            if (chkWholeWord.Checked) options |= RichTextBoxFinds.WholeWord;

            var index = RtbInstance.Find(txtSearchText.Text, _lastFound, options);
            _lastFound += txtSearchText.Text.Length;
            if (index >= 0)
            {
                RtbInstance.Parent.Focus();
            }
            else
            {
                MessageBox.Show("متن موردنظر یافت نشد", "جستجو",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                _lastFound = 0;
            }
        }
        private void BtnDone_Click(object sender, EventArgs e)
        {
            this.RtbInstance.SelectionChanged -= rtbInstance_SelectionChanged;
            this.Close();
        }

    }
}
