//using System.Drawing;
//using System.Windows.Forms;

//namespace PersonalAccounting.CommonLibrary.Helper
//{
//    public static class RichTextBoxHelper
//    {
//        //Used for looping
//        private static readonly RichTextBox RtbTemp = new RichTextBox();
//        #region Change font style
//        /// <summary>
//        ///     Change the RichTextBox style for the current selection
//        /// </summary>
//        public static void ChangeFontStyle(this RichTextBox richTextBox, FontStyle style, bool add = true)
//        {
//            //This method should handle cases that occur when multiple fonts/styles are selected
//            // Parameters:-
//            //	style - eg FontStyle.Bold
//            //	add - IF true then add else remove

//            // throw error if style isn't: bold, italic, strikeout or underline
//            if (style != FontStyle.Bold
//                && style != FontStyle.Italic
//                && style != FontStyle.Strikeout
//                && style != FontStyle.Underline)
//                throw new System.InvalidProgramException("Invalid style parameter to ChangeFontStyle");

//            var richTextBoxStart = richTextBox.SelectionStart;
//            var len = richTextBox.SelectionLength;
//            const int rtbTempStart = 0;

//            //if len <= 1 and there is a selection font then just handle and return
//            if (len <= 1 && richTextBox.SelectionFont != null)
//            {
//                //add or remove style 
//                richTextBox.SelectionFont = add
//                    ? new Font(richTextBox.SelectionFont, richTextBox.SelectionFont.Style | style)
//                    : new Font(richTextBox.SelectionFont, richTextBox.SelectionFont.Style & ~style);

//                return;
//            }

//            // Step through the selected text one char at a time	
//            RtbTemp.Rtf = richTextBox.SelectedRtf;
//            for (var i = 0; i < len; ++i)
//            {
//                RtbTemp.Select(rtbTempStart + i, 1);

//                //add or remove style 
//                RtbTemp.SelectionFont = add
//                    ? new Font(RtbTemp.SelectionFont, RtbTemp.SelectionFont.Style | style)
//                    : new Font(RtbTemp.SelectionFont, RtbTemp.SelectionFont.Style & ~style);
//            }

//            // Replace & reselect
//            RtbTemp.Select(rtbTempStart, len);
//            richTextBox.SelectedRtf = RtbTemp.SelectedRtf;
//            richTextBox.Select(richTextBoxStart, len);
//            return;
//        }
//        #endregion

//    }
//}
