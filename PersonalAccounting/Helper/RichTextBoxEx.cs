//using System;
//using System.Drawing;
//using System.Runtime.InteropServices;
//using System.Windows.Forms;

//namespace PersonalAccounting.UI.Helper
//{
//    public class RichTextBoxEx : RichTextBox
//    {
//        private const int PfmSpaceBefore = 64;
//        private const int PfmSpaceAfter = 128;
//        private const int EmSetParaFormat = 1095;
//        private const int ScfSelection = 1;

//        public int SelectionParagraphSpacingAfter
//        {
//            set
//            {
//                var fmt = new ParaFormat();
//                fmt.cbSize = Marshal.SizeOf(fmt);
//                fmt.dwMask = PfmSpaceAfter;
//                fmt.dySpaceAfter = value;
//                SendMessage(new HandleRef(this, this.Handle),
//                             EmSetParaFormat,
//                             ScfSelection,
//                             ref fmt
//                           );
//            }
//        }

//        public int SelectionParagraphSpacingBefore
//        {
//            set
//            {
//                var fmt = new ParaFormat();
//                fmt.cbSize = Marshal.SizeOf(fmt);
//                fmt.dwMask = PfmSpaceBefore;
//                fmt.dySpaceBefore = value;
//                SendMessage(new HandleRef(this, this.Handle),
//                             EmSetParaFormat,
//                             ScfSelection,
//                             ref fmt
//                           );
//            }
//        }

//        [StructLayout(LayoutKind.Sequential)]
//        private struct ParaFormat
//        {
//            public int cbSize;
//            public uint dwMask;
//            private readonly short wNumbering;
//            private readonly short wReserved;
//            private readonly int dxStartIndent;
//            private readonly int dxRightIndent;
//            private readonly int dxOffset;
//            private readonly short wAlignment;
//            private readonly short cTabCount;
//            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
//            private readonly int[] rgxTabs;

//            // ParaFormat2 from here onwards.
//            public int dySpaceBefore;
//            public int dySpaceAfter;
//            private readonly int dyLineSpacing;
//            private readonly short sStyle;
//            private readonly byte bLineSpacingRule;
//            private readonly byte bOutlineLevel;
//            private readonly short wShadingWeight;
//            private readonly short wShadingStyle;
//            private readonly short wNumberingStart;
//            private readonly short wNumberingStyle;
//            private readonly short wNumberingTab;
//            private readonly short wBorderSpace;
//            private readonly short wBorderWidth;
//            private readonly short wBorders;
//        }

//        [DllImport("user32", CharSet = CharSet.Auto)]
//        private static extern int SendMessage(HandleRef hWnd,
//                                               int msg,
//                                               int wParam,
//                                               ref ParaFormat lp);


//        //private const int LineH = 15;
//        //private const int WmPaint = 15;
//        //protected override void WndProc(ref Message m)
//        //{
//        //    if (m.Msg == WmPaint)
//        //    {
//        //        var selectLength = this.SelectionLength;
//        //        var selectStart = this.SelectionStart;
//        //        this.Invalidate();

//        //        base.WndProc(ref m);

//        //        if (selectLength > 0)
//        //        {
//        //            return;
//        //        }
//        //        using (var g = Graphics.FromHwnd(this.Handle))
//        //        {
//        //            Brush b = new SolidBrush(Color.FromArgb(50, Color.FromArgb(140, 220, 160)));
//        //            var fontSize = (int)this.Font.Size;
//        //            var line = this.GetLineFromCharIndex(selectStart);
//        //            var loc = this.GetPositionFromCharIndex(this.GetFirstCharIndexFromLine(line));
//        //            g.FillRectangle(b, new Rectangle(loc, new Size(this.Width, LineH + fontSize - 3)));
//        //        }
//        //    }
//        //    else
//        //    {
//        //        base.WndProc(ref m);
//        //    }
//        //}

//        //protected override void OnSelectionChanged(EventArgs e)
//        //{
//        //    base.OnSelectionChanged(e);
//        //    this.Invalidate();
//        //}
//    }
//}