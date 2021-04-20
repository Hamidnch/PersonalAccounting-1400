using System;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PersonalAccounting.CommonLibrary.Helper
{
    public static class RichTextBoxExtensions
    {
        public static void Print(this RichTextBox control)
        {
            var pr = new PrintRichTextBox(control);
            pr.PrintRtf();
        }
    }

    public class PrintRichTextBox
    {
        readonly RichTextBox _control;
        public PrintRichTextBox(RichTextBox controlToPrint)
        {
            _control = controlToPrint;
        }

        public void PrintRtf()
        {
            PrintRtf(new PrintDocument());
        }
        public void PrintRtf(PrintDocument printDocument)
        {
            try
            {
                printDocument.BeginPrint += PrintDocument_BeginPrint;
                printDocument.EndPrint += PrintDocument_EndPrint;
                printDocument.PrintPage += PrintDocument_PrintPage;
                printDocument.Print();
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
            }
        }


        private int _mNFirstCharOnPage;

        private void PrintDocument_BeginPrint(object sender, PrintEventArgs e)
        {
            // Start at the beginning of the text
            _mNFirstCharOnPage = 0;
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // To print the boundaries of the current page margins
            // uncomment the next line:
            //e.Graphics.DrawRectangle(System.Drawing.Pens.Blue, e.MarginBounds);

            // make the RichTextBoxEx calculate and render as much text as will
            // fit on the page and remember the last character printed for the
            // beginning of the next page
            _mNFirstCharOnPage = FormatRange(false,
                e,
                _mNFirstCharOnPage,
                _control.TextLength);

            // check if there are more pages to print
            e.HasMorePages = _mNFirstCharOnPage < _control.TextLength;
        }

        private void PrintDocument_EndPrint(object sender, PrintEventArgs e)
        {
            // Clean up cached information
            FormatRangeDone();
        }


        [StructLayout(LayoutKind.Sequential)]
        private struct StructRect
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }
        [StructLayout(LayoutKind.Sequential)]
        private struct StructCharrange
        {
            public int cpMin;
            public int cpMax;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct StructFormatRange
        {
            public IntPtr hdc;
            public IntPtr hdcTarget;
            public StructRect rc;
            public StructRect rcPage;
            public StructCharrange chrg;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct CharFormatStruct
        {
            public int cbSize;
            public uint dwMask;
            public uint dwEffects;
            public int yHeight;
            private readonly int yOffset;
            private readonly int crTextColor;
            private readonly byte bCharSet;
            private readonly byte bPitchAndFamily;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public char[] szFaceName;
        }

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int msg,
            int wParam, IntPtr lParam);

        // Windows Messages defines
        private const int WmUser = 0x400;
        private const int EmFormatRange = WmUser + 57;
        private const int EmGetCharFormat = WmUser + 58;
        private const int EmSetCharFormat = WmUser + 68;

        // Defines for EM_SETCHARFORMAT/EM_GETCHARFORMAT
        private const int ScfSelection = 0x0001;
        private const int ScfWord = 0x0002;
        private const int ScfAll = 0x0004;

        // Defines for STRUCT_CHARFORMAT member dwMask
        private const uint CfmBold = 0x00000001;
        private const uint CfmItalic = 0x00000002;
        private const uint CfmUnderline = 0x00000004;
        private const uint CfmStrikeout = 0x00000008;
        private const uint CfmProtected = 0x00000010;
        private const uint CfmLink = 0x00000020;
        private const uint CfmSize = 0x80000000;
        private const uint CfmColor = 0x40000000;
        private const uint CfmFace = 0x20000000;
        private const uint CfmOffset = 0x10000000;
        private const uint CfmCharset = 0x08000000;

        // Defines for STRUCT_CHARFORMAT member dwEffects
        private const uint CfeBold = 0x00000001;
        private const uint CfeItalic = 0x00000002;
        private const uint CfeUnderline = 0x00000004;
        private const uint CfeStrikeout = 0x00000008;
        private const uint CfeProtected = 0x00000010;
        private const uint CfeLink = 0x00000020;
        private const uint CfeAutocolor = 0x40000000;

        /// <summary>
        /// Calculate or render the contents of our RichTextBox for printing
        /// </summary>
        /// <param name="measureOnly">If true, only the calculation is performed,
        /// otherwise the text is rendered as well</param>
        /// <param name="e">The PrintPageEventArgs object from the
        /// PrintPage event</param>
        /// <param name="charFrom">Index of first character to be printed</param>
        /// <param name="charTo">Index of last character to be printed</param>
        /// <returns>(Index of last character that fitted on the
        /// page) + 1</returns>
        public int FormatRange(bool measureOnly, PrintPageEventArgs e,
            int charFrom, int charTo)
        {
            // Specify which characters to print
            StructCharrange cr;
            cr.cpMin = charFrom;
            cr.cpMax = charTo;

            // Specify the area inside page margins
            StructRect rc;
            rc.top = HundredthInchToTwips(e.MarginBounds.Top);
            rc.bottom = HundredthInchToTwips(e.MarginBounds.Bottom);
            rc.left = HundredthInchToTwips(e.MarginBounds.Left);
            rc.right = HundredthInchToTwips(e.MarginBounds.Right);

            // Specify the page area
            StructRect rcPage;
            rcPage.top = HundredthInchToTwips(e.PageBounds.Top);
            rcPage.bottom = HundredthInchToTwips(e.PageBounds.Bottom);
            rcPage.left = HundredthInchToTwips(e.PageBounds.Left);
            rcPage.right = HundredthInchToTwips(e.PageBounds.Right);

            // Get device context of output device
            var hdc = e.Graphics.GetHdc();

            // Fill in the FORMATRANGE struct
            StructFormatRange fr;
            fr.chrg = cr;
            fr.hdc = hdc;
            fr.hdcTarget = hdc;
            fr.rc = rc;
            fr.rcPage = rcPage;

            // Non-Zero wParam means render, Zero means measure
            var wParam = (measureOnly ? 0 : 1);

            // Allocate memory for the FORMATRANGE struct and
            // copy the contents of our struct to this memory
            var lParam = Marshal.AllocCoTaskMem(Marshal.SizeOf(fr));
            Marshal.StructureToPtr(fr, lParam, false);

            // Send the actual Win32 message
            var res = SendMessage(_control.Handle, EmFormatRange, wParam, lParam);

            // Free allocated memory
            Marshal.FreeCoTaskMem(lParam);

            // and release the device context
            e.Graphics.ReleaseHdc(hdc);

            return res;
        }
        /// <summary>
        /// Convert between 1/100 inch (unit used by the .NET framework)
        /// and twips (1/1440 inch, used by Win32 API calls)
        /// </summary>
        /// <param name="n">Value in 1/100 inch</param>
        /// <returns>Value in twips</returns>
        private static int HundredthInchToTwips(int n)
        {
            return (int)(n * 14.4);
        }
        /// <summary>
        /// Free cached data from rich edit control after printing
        /// </summary>
        public void FormatRangeDone()
        {
            var lParam = new IntPtr(0);
            SendMessage(_control.Handle, EmFormatRange, 0, lParam);
        }

        /// <summary>
        /// Sets the font only for the selected part of the rich text box
        /// without modifying the other properties like size or style
        /// </summary>
        /// <param name="face">Name of the font to use</param>
        /// <returns>true on success, false on failure</returns>
        public static bool SetSelectionFont(RichTextBox control, string face)
        {
            var cf = new CharFormatStruct();
            cf.cbSize = Marshal.SizeOf(cf);
            cf.szFaceName = new char[32];
            cf.dwMask = CfmFace;
            face.CopyTo(0, cf.szFaceName, 0, Math.Min(31, face.Length));

            var lParam = Marshal.AllocCoTaskMem(Marshal.SizeOf(cf));
            Marshal.StructureToPtr(cf, lParam, false);

            var res = SendMessage(control.Handle, EmSetCharFormat, ScfSelection, lParam);
            return (res == 0);
        }

        /// <summary>
        /// Sets the font size only for the selected part of the rich text box
        /// without modifying the other properties like font or style
        /// </summary>
        /// <param name="size">new point size to use</param>
        /// <returns>true on success, false on failure</returns>
        public static bool SetSelectionSize(RichTextBox control, int size)
        {
            var cf = new CharFormatStruct();
            cf.cbSize = Marshal.SizeOf(cf);
            cf.dwMask = CfmSize;
            // yHeight is in 1/20 pt
            cf.yHeight = size * 20;

            var lParam = Marshal.AllocCoTaskMem(Marshal.SizeOf(cf));
            Marshal.StructureToPtr(cf, lParam, false);

            var res = SendMessage(control.Handle, EmSetCharFormat, ScfSelection, lParam);
            return (res == 0);
        }

        /// <summary>
        /// Sets the bold style only for the selected part of the rich text box
        /// without modifying the other properties like font or size
        /// </summary>
        /// <param name="bold">make selection bold (true) or regular (false)</param>
        /// <returns>true on success, false on failure</returns>
        public bool SetSelectionBold(bool bold)
        {
            return SetSelectionStyle(CfmBold, bold ? CfeBold : 0);
        }

        /// <summary>
        /// Sets the italic style only for the selected part of the rich text box
        /// without modifying the other properties like font or size
        /// </summary>
        /// <param name="italic">make selection italic (true) or regular (false)</param>
        /// <returns>true on success, false on failure</returns>
        public bool SetSelectionItalic(bool italic)
        {
            return SetSelectionStyle(CfmItalic, italic ? CfeItalic : 0);
        }

        /// <summary>
        /// Sets the underlined style only for the selected part of the rich text box
        /// without modifying the other properties like font or size
        /// </summary>
        /// <param name="underlined">make selection underlined (true) or regular (false)</param>
        /// <returns>true on success, false on failure</returns>
        public bool SetSelectionUnderlined(bool underlined)
        {
            return SetSelectionStyle(CfmUnderline, underlined ? CfeUnderline : 0);
        }

        /// <summary>
        /// Set the style only for the selected part of the rich text box
        /// with the possibility to mask out some styles that are not to be modified
        /// </summary>
        /// <param name="mask">modify which styles?</param>
        /// <param name="effect">new values for the styles</param>
        /// <returns>true on success, false on failure</returns>
        private bool SetSelectionStyle(uint mask, uint effect)
        {
            var cf = new CharFormatStruct();
            cf.cbSize = Marshal.SizeOf(cf);
            cf.dwMask = mask;
            cf.dwEffects = effect;

            var lParam = Marshal.AllocCoTaskMem(Marshal.SizeOf(cf));
            Marshal.StructureToPtr(cf, lParam, false);

            var res = SendMessage(_control.Handle, EmSetCharFormat, ScfSelection, lParam);
            return (res == 0);
        }
    }
}