using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalAccounting.UI.UserControl
{
    public class RichTextBoxZ : RichTextBox
    {
        public RichTextBoxZ()
        {

        }

        protected override void OnSelectionChanged(EventArgs e)
        {
            base.OnSelectionChanged(e);
            this.Invalidate();
        }

        readonly int lineH = 15;
        const int WmPaint = 15;
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WmPaint)
            {
                var selectLength = this.SelectionLength;
                var selectstart = this.SelectionStart;
                this.Invalidate();
                base.WndProc(ref m);
                if (selectLength > 0)
                {
                    return;
                }
                using (var g = Graphics.FromHwnd(this.Handle))
                {
                    Brush b = new SolidBrush(Color.FromArgb(50, Color.FromArgb(140, 220, 160)));
                    var fontSize = (int)this.Font.Size;
                    var line = this.GetLineFromCharIndex(selectstart);
                    var loc = this.GetPositionFromCharIndex(this.GetFirstCharIndexFromLine(line));
                    g.FillRectangle(b, new Rectangle(loc, new Size(this.Width, lineH + fontSize - 3)));
                }
            }
            else
            {
                base.WndProc(ref m);
            }
        }
    }
}
