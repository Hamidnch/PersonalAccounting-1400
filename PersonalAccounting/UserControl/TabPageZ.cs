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
    public class TabPageZ : TabPage
    {
        //public FrmDiaryNote mainform;
        public RichTextBoxAdv myRichTextBox = new RichTextBoxAdv();

        public TabPageZ() //(FrmDiaryNote mf)
        {
            //mainform = mf;

            this.myRichTextBox.Dock = DockStyle.Fill;
            this.myRichTextBox.richTextBoxZ.Text = "";
            myRichTextBox.richTextBoxZ.Font = new System.Drawing.Font("Monospaced", 11, FontStyle.Regular);
            this.myRichTextBox.richTextBoxZ.Select();

            myRichTextBox.richTextBoxZ.TextChanged += new EventHandler(this.richTextBox1_TextChanged);
            myRichTextBox.richTextBoxZ.SelectionChanged += new EventHandler(this.richTextBox1_SelectionChanged);

            myRichTextBox.richTextBoxZ.LinkClicked += new LinkClickedEventHandler(this.richTextBox1_LinkClicked);

            this.Controls.Add(myRichTextBox);
        }



        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            String str = this.Text;
            if (str.Contains("*"))
            {

            }
            else
            {
                this.Text = str + "*";
            }
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            int sel = myRichTextBox.richTextBoxZ.SelectionStart;
            int line = myRichTextBox.richTextBoxZ.GetLineFromCharIndex(sel) + 1;
            int col = sel - myRichTextBox.richTextBoxZ.GetFirstCharIndexFromLine(line - 1) + 1;

            //mainform.LineToolStripLabel.Text = "Line : " + line.ToString();
            //mainform.ColumnToolStripLabel.Text = "Col : " + col.ToString();
        }



        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }

    }
}
