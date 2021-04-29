using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalAccounting.UI.UserControl
{
    public class RichTextBoxContainer : Panel
    {
        //public FrmDiaryNote mainform;
        public RichTextBoxAdv richTextBoxAdv = new RichTextBoxAdv();

        public RichTextBoxContainer() //(FrmDiaryNote mf)
        {
            //mainform = mf;

            this.richTextBoxAdv.Dock = DockStyle.Fill;
            this.richTextBoxAdv.RightToLeft = RightToLeft.Yes;
            this.richTextBoxAdv.richTextBoxZ.Text = "";
            richTextBoxAdv.richTextBoxZ.Font = new Font("Tahoma", 10, FontStyle.Regular);
            this.richTextBoxAdv.richTextBoxZ.Select();

            richTextBoxAdv.richTextBoxZ.TextChanged += new EventHandler(this.richTextBoxZ_TextChanged);
            richTextBoxAdv.richTextBoxZ.SelectionChanged += new EventHandler(this.richTextBoxZ_SelectionChanged);

            richTextBoxAdv.richTextBoxZ.LinkClicked += new LinkClickedEventHandler(this.richTextBoxZ_LinkClicked);

            this.Controls.Add(richTextBoxAdv);
        }



        private void richTextBoxZ_TextChanged(object sender, EventArgs e)
        {
            var str = this.Text;
            if (str.Contains("*"))
            {

            }
            else
            {
                this.Text = str + "*";
            }
        }

        private void richTextBoxZ_SelectionChanged(object sender, EventArgs e)
        {
            var sel = richTextBoxAdv.richTextBoxZ.SelectionStart;
            var line = richTextBoxAdv.richTextBoxZ.GetLineFromCharIndex(sel) + 1;
            var col = sel - richTextBoxAdv.richTextBoxZ.GetFirstCharIndexFromLine(line - 1) + 1;

            //mainform.LineToolStripLabel.Text = "Line : " + line.ToString();
            //mainform.ColumnToolStripLabel.Text = "Col : " + col.ToString();
        }



        private void richTextBoxZ_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }

    }
}
