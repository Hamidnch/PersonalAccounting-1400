using System;
using System.Drawing;
using System.Windows.Forms;

namespace PersonalAccounting.UI.UserControl
{
    public partial class RichTextBoxAdv : System.Windows.Forms.UserControl
    {
        public RichTextBoxAdv()
        {
            InitializeComponent();
        }

        public int GetWidth()
        {
            var w = 25;
            // get total lines of richTextBox1
            var line = richTextBoxZ.Lines.Length;

            if (line <= 99)
            {
                w = 20 + (int)richTextBoxZ.Font.Size;
            }
            else if (line <= 999)
            {
                w = 30 + (int)richTextBoxZ.Font.Size;
            }
            else
            {
                w = 50 + (int)richTextBoxZ.Font.Size;
            }

            return w;
        }

        public void AddLineNumbers()
        {
            richTextBoxZ.Select();
            // create & set Point pt to (0,0)
            var pt = new Point(0, 0);
            // get First Index & First Line from richTextBox1
            var firstIndex = richTextBoxZ.GetCharIndexFromPosition(pt);
            var firstLine = richTextBoxZ.GetLineFromCharIndex(firstIndex);
            // set X & Y coordinates of Point pt to ClientRectangle Width & Height respectively
            pt.X = ClientRectangle.Width;
            pt.Y = ClientRectangle.Height;
            // get Last Index & Last Line from richTextBox1
            var lastIndex = richTextBoxZ.GetCharIndexFromPosition(pt);
            var lastLine = richTextBoxZ.GetLineFromCharIndex(lastIndex);
            // set Center alignment to LineNumberTextBox
            richTextBox.SelectionAlignment = HorizontalAlignment.Center;
            // set LineNumberTextBox text to null & width to getWidth() function value
            richTextBox.Text = "";
            richTextBox.Width = GetWidth();
            // now add each line number to LineNumberTextBox upto last line
            for (var i = firstLine; i <= lastLine + 1; i++)
            {
                richTextBox.Text += i + 1 + "\n";
            }
        }



        private void RichTextBoxAdv_Load(object sender, EventArgs e)
        {
            richTextBox.Font = richTextBoxZ.Font;
            AddLineNumbers();
        }

        private void RichTextBoxZ_SelectionChanged(object sender, EventArgs e)
        {
            this.Invalidate();
            var pt = richTextBoxZ.GetPositionFromCharIndex(richTextBoxZ.SelectionStart);
            if (pt.X == 1)
            {
                AddLineNumbers();
            }
        }

        private void RichTextBoxZ_VScroll(object sender, EventArgs e)
        {
            richTextBox.Text = "";
            AddLineNumbers();
            richTextBox.Invalidate();
        }

        private void RichTextBoxZ_TextChanged(object sender, EventArgs e)
        {
            if (richTextBoxZ.Text == "")
            {
                AddLineNumbers();
            }
        }

        private void RichTextBoxZ_FontChanged(object sender, EventArgs e)
        {
            richTextBox.Font = richTextBoxZ.Font;
            AddLineNumbers();
        }

        private void LineNumberTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            richTextBoxZ.Select();
            richTextBox.DeselectAll();
        }

        private void RichTextBoxAdv_Resize(object sender, EventArgs e)
        {
            AddLineNumbers();
        }
    }
}
