using Janus.Windows.EditControls;
using Janus.Windows.GridEX.EditControls;
using Janus.Windows.UI.Dock;
using Klik.Windows.Forms.v1.EntryLib;
using MessageBoxHamidNCH;
using PersonalAccounting.CommonLibrary.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Tulpep.NotificationWindow;
using ContentAlignment = System.Drawing.ContentAlignment;

namespace PersonalAccounting.CommonLibrary.Helper
{
    public enum FormatDate
    {
        Fd2Year = 2,
        Fd4Year = 4
    }
    public static class CommonHelper
    {
        /*************************************************************/
        public const int WmNclButtonDown = 0xA1;
        public const int HtCaption = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        /*************************************************************/

        private const int OleHeaderSize = 78;

        public static Font SummaryFont { get; set; } =
            new Font("Tahoma", 10, FontStyle.Regular);

        public static Font BaseFont { get; set; } =
            new Font("Tornado Tahoma", 8, FontStyle.Regular); //Microsoft Sans Serif

        public static Font BaseBoldFont { get; set; } =
            new Font("Tornado Tahoma", 10, FontStyle.Bold);

        public enum Mode
        {
            None = -1,
            Insert = 0,
            Update = 1,
            Cancel = 2
        }
        public static void ShowForm(Form parentForm, Form childForm)
        {
            //form.MdiParent = parent;
            //form.WindowState = FormWindowState.Maximized;
            //form.Show();
            //form.Activate();

            childForm.MdiParent = parentForm;
            //form.BringToFront();
            childForm.WindowState = FormWindowState.Minimized;
            childForm.Show();
            childForm.Activate();
            childForm.WindowState = FormWindowState.Maximized;

            //if (parentForm.Controls["lbl_FormCaption"] == null) return;
            //parentForm.Controls["lbl_FormCaption"].Text = string.Empty;
            //parentForm.Controls["lbl_FormCaption"].Text = childForm.Text;
        }
        //public static void FullScreen(Form parent, bool isFullScreen)
        //{
        //    ((UIPanel)parent.Controls["MainPanel"]).Closed = isFullScreen;
        //    ((RadRibbonBar)parent.Controls["rrb_Main"]).Visible = !isFullScreen;
        //}
        public static void FullScreenEx(this Form childForm, bool isFullScreen = true)
        {
            if (childForm.MdiParent.Controls[DefaultConstants.FormCaptionLabel] != null)
                childForm.MdiParent.Controls[DefaultConstants.FormCaptionLabel].Visible = !isFullScreen;

            foreach (var control in childForm.MdiParent.Controls)
            {
                switch (control)
                {
                    case UIPanel pnl:
                        pnl.Closed = isFullScreen;
                        break;
                    case RadRibbonBar ribbonBar:
                        ribbonBar.Visible = !isFullScreen;
                        break;
                }
            }
        }

        //public static void FullScreen(Form parent, Form childForm, bool isFullScreen)
        //{
        //    void HideParentControls(bool isShow = false)
        //    {
        //        ((UIPanel)parent.Controls["MainPanel"]).Closed = !isShow;
        //        ((RadRibbonBar) parent.Controls["radRibbonBar1"]).Visible = isShow;
        //        foreach (var control in parent.Controls)
        //        {
        //            switch (control)
        //            {
        //                case UIPanel pnl:
        //                    pnl.Closed = !isShow;
        //                    break;
        //                case RadRibbonBar ribbonBar:
        //                    ribbonBar.Visible = isShow;
        //                    break;
        //            }
        //        }
        //    }
        //    if (isFullScreen)
        //    {
        //        HideParentControls();
        //    }
        //    else
        //    {
        //        HideParentControls(true);
        //    }
        //}
        //public static void FullScreen(Form parent, Form childForm, bool isFullScreen)
        //{
        //    void HideParentControls(bool isShow = false)
        //    {
        //        ((UIPanel) parent.Controls["MainPanel"]).Closed = !isShow;
        //        foreach (var control in parent.Controls)
        //        {
        //            switch (control)
        //            {
        //                case UIPanel pnl:
        //                    pnl.Closed = !isShow;
        //                    break;
        //                case RadRibbonBar ribbonBar:
        //                    ribbonBar.Visible = isShow;
        //                    break;
        //            }
        //        }
        //    }
        //    if (isFullScreen)
        //    {
        //        HideParentControls();
        //        parent.FormBorderStyle = FormBorderStyle.None;
        //    }
        //    else
        //    {
        //        HideParentControls(true);
        //        parent.FormBorderStyle = FormBorderStyle.Sizable;
        //    }

        //    //parent.WindowState = FormWindowState.Minimized;
        //    //parent.Visible = true;
        //    parent.WindowState = FormWindowState.Maximized;
        //    childForm.MdiParent = parent;
        //    childForm.WindowState = FormWindowState.Minimized;
        //    childForm.Activate();
        //    childForm.Show();
        //    childForm.WindowState = FormWindowState.Maximized;
        //}
        //public static void ShowFullScreenForm(Form parent, Form form)
        //{
        //    foreach (var control in parent.Controls)
        //    {
        //        switch (control)
        //        {
        //            case UIPanel pnl:
        //                pnl.Closed = true;
        //                break;
        //            case RadRibbonBar ribbonBar:
        //                ribbonBar.Visible = false;
        //                break;
        //        }
        //    }

        //    //parent.Visible = false;
        //    parent.FormBorderStyle = FormBorderStyle.None;
        //    parent.WindowState = FormWindowState.Maximized;
        //    parent.Visible = true;
        //    form.MdiParent = parent;
        //    form.WindowState = FormWindowState.Minimized;
        //    form.Activate();
        //    form.Show();
        //    form.WindowState = FormWindowState.Maximized;
        //}
        //public static void HideFullScreenForm(Form parent, Form form)
        //{
        //    foreach (var control in parent.Controls)
        //    {
        //        switch (control)
        //        {
        //            case UIPanel pnl:
        //                pnl.Closed = false;
        //                break;
        //            case RadRibbonBar ribbonBar:
        //                ribbonBar.Visible = true;
        //                break;
        //        }
        //    }
        //    //parent.Visible = false;
        //    parent.FormBorderStyle = FormBorderStyle.Sizable;
        //    parent.WindowState = FormWindowState.Maximized;
        //    parent.Visible = true;
        //    form.MdiParent = parent;
        //    form.WindowState = FormWindowState.Minimized;
        //    form.Activate();
        //    form.Show();
        //    form.WindowState = FormWindowState.Maximized;
        //}

        //public static void EnterFullScreenMode(Form targetForm)
        //{
        //    targetForm.MdiParent = null;
        //    targetForm.WindowState = FormWindowState.Normal;
        //    targetForm.FormBorderStyle = FormBorderStyle.None;
        //    targetForm.WindowState = FormWindowState.Maximized;
        //}

        //public static void LeaveFullScreenMode(Form targetForm, Form parentForm)
        //{
        //    parentForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
        //    parentForm.WindowState = FormWindowState.Maximized;
        //    parentForm.Visible = true;
        //    targetForm.MdiParent = parentForm;
        //    targetForm.WindowState = FormWindowState.Minimized;
        //    targetForm.Activate();
        //    targetForm.Show();
        //    targetForm.WindowState = FormWindowState.Maximized;
        //}
        //private static Mode mode = Mode.MNone;
        //public static void VisibleControls(Control control, bool isVisible)
        //{
        //    control.Visible = isVisible;
        //    foreach (Control ctl in control.Controls)
        //    {
        //        ctl.Visible = isVisible;
        //    }
        //}
        //public static void VisibleControls(bool isVisible, params Control[] control)
        //{
        //    foreach (var ctl in control)
        //    {
        //        ctl.Visible = isVisible;
        //        foreach (var c in control)
        //        {
        //            c.Visible = isVisible;
        //        }
        //    }
        //}
        public static void EnableControls(Control control, bool isActive)
        {
            control.Enabled = isActive;
            foreach (Control ctl in control.Controls)
            {
                //if (ctl is RadTreeView) continue;

                ctl.Enabled = isActive;
            }
        }
        //public static void EnableControls(bool isActive, params Control[] control)
        //{
        //    foreach (var ctl in control)
        //    {
        //        ctl.Enabled = isActive;
        //        foreach (var c in control)
        //        {
        //            c.Enabled = isActive;
        //        }
        //    }
        //}
        public static void SetFont(Control control, Font font)
        {
            control.Font = font;
            foreach (var ctl in control.Controls.Cast<Control>().Where(ctl => ctl.HasChildren))
            {
                SetFont(ctl, font);
            }
        }

        public static void SetAllControlsFont(Control.ControlCollection controls)
        {
            foreach (Control c in controls)
            {
                SetAllControlsFont(c.Controls);
                c.Font = BaseFont;
            }
        }


        public static List<Control> GetAllControls(Control container, List<Control> list)
        {
            foreach (Control c in container.Controls)
            {

                if (c.Controls.Count > 0)
                    list = GetAllControls(c, list);
                else
                    list.Add(c);
            }

            return list;
        }
        //public static List<Control> GetAllControls(Control container)
        //{
        //    return GetAllControls(container, new List<Control>());
        //}

        public static IList<T> GetAllControls<T>(Control control) where T : Control
        {
            var rtn = new List<T>();
            foreach (Control item in control.Controls)
            {
                if (item is T ctr)
                {
                    rtn.Add(ctr);
                }
                else
                {
                    rtn.AddRange(GetAllControls<T>(item));
                }

            }
            return rtn;
        }


        public static List<T> FindControlByType<T>(Control mainControl, bool getAllChild = false) where T : Control
        {
            var lt = new List<T>();
            for (var i = 0; i < mainControl.Controls.Count; i++)
            {
                if (mainControl.Controls[i] is T) lt.Add((T)mainControl.Controls[i]);
                if (getAllChild) lt.AddRange(FindControlByType<T>(mainControl.Controls[i], getAllChild));
            }
            return lt;
        }



        public static void SetFont(Font font, params Control[] controls)
        {
            foreach (var ctl in controls)
            {
                ctl.Font = font;
                foreach (var c in from Control c in ctl.Controls where c.HasChildren select c)
                {
                    SetFont(c, font);
                }
            }
        }

        //public static void CheckAllNodes(RadTreeNodeCollection nodes)
        //{
        //    foreach (var node in nodes)
        //    {
        //        node.Checked = true;
        //        CheckChildren(node, true);
        //    }
        //}

        //public static void UncheckAllNodes(RadTreeNodeCollection nodes)
        //{
        //    foreach (var node in nodes)
        //    {
        //        node.Checked = false;
        //        CheckChildren(node, false);
        //    }
        //}

        //private static void CheckChildren(RadTreeNode rootNode, bool isChecked)
        //{
        //    foreach (var node in rootNode.Nodes)
        //    {
        //        CheckChildren(node, isChecked);
        //        node.Checked = isChecked;
        //    }
        //}

        public static void CheckUncheckTreeNode(RadTreeNodeCollection trNodeCollection, bool isCheck)
        {
            foreach (var trNode in trNodeCollection)
            {
                trNode.Checked = isCheck;
                if (trNode.Nodes.Count > 0)
                    CheckUncheckTreeNode(trNode.Nodes, isCheck);
            }
        }

        public static void ClearInputControls(Control control, bool isComboBox = false, bool isGrid = true)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is TextBox box)
                {
                    box.Clear();
                }
                if (isComboBox)
                {
                    switch (ctrl)
                    {
                        case ComboBox comboBox:
                            comboBox.SelectedIndex = -1;
                            break;
                        case UIComboBox uiComboBox:
                            uiComboBox.SelectedIndex = -1;
                            break;
                        case RadDropDownList ddl:
                            ddl.SelectedIndex = 0;
                            ddl.SelectedValue = 0;
                            break;
                    }
                }
                switch (ctrl)
                {
                    case MaskedTextBox textBox:
                        textBox.Clear();
                        break;
                    case RadAutoCompleteBox completeBox:
                        completeBox.Clear();
                        break;
                    case RadTextBoxControl textBox:
                        textBox.Clear();
                        break;
                    case RadTextBox textBox:
                        textBox.Clear();
                        break;
                    case RadTreeView treeView:
                        //UncheckAllNodes(treeView.Nodes);
                        CheckUncheckTreeNode(treeView.Nodes, false);
                        break;
                    //case IntegerInput input:
                    //    input.Value = 0;
                    //    break;
                    case CheckBox checkBox:
                        checkBox.Checked = false;
                        break;
                    case RadioButton button:
                        button.Checked = false;
                        break;
                    case PictureBox pictureBox:
                        pictureBox.ImageLocation = Application.StartupPath + DefaultConstants.NoPersonImagePath;
                        break;
                }

                if (ctrl.HasChildren)
                {
                    ClearInputControls(ctrl);
                }

                if (!isGrid) continue;

                if (ctrl is RadGridView gridView)
                {
                    gridView.Rows.Clear();
                    //((RadGridView) c).Rows.AddNew();
                }
            }
        }

        public static bool ValidateControls(Control control, ErrorProvider errorProvider, string errorText)
        {
            switch (control)
            {
                case TextBox _ when control.Text == string.Empty:
                    errorProvider.SetError(control, errorText);
                    control.Focus();
                    return true;
                case TextBox _:
                    errorProvider.SetError(control, string.Empty);
                    return false;
                case ComboBox box when box.SelectedIndex == -1:
                    errorProvider.SetError(box, errorText);
                    box.Focus();
                    return true;
                case RadDropDownList box when box.SelectedIndex == 0 &&
                                              box.Text == DefaultConstants.SelectOptionString:
                    errorProvider.SetError(box, errorText);
                    box.Focus();
                    return true;
                case RadCheckedListBox box when box.CheckedItems.Count <= 0:
                    errorProvider.SetError(box, errorText);
                    box.Focus();
                    return true;
                case RadTreeView tree when tree.CheckedNodes.Count <= 0:
                    errorProvider.SetError(tree, errorText);
                    tree.Focus();
                    return true;
                case ComboBox _:
                    errorProvider.SetError(control, string.Empty);
                    return false;
                case MaskedTextBox box when box.Text == Resources.FarsiDateFormat ||
                                          box.Text == Resources.NullDatelFormat:
                    errorProvider.SetError(box, errorText);
                    box.Focus();
                    box.SelectAll();
                    return true;
                case MaskedTextBox _:
                    errorProvider.SetError(control, string.Empty);
                    return false;
                case UIComboBox box when box.Text == string.Empty ||
                                       box.SelectedIndex == -1:
                    errorProvider.SetError(box, errorText);
                    control.Focus();
                    box.Select();
                    return true;
                case UIComboBox _:
                    errorProvider.SetError(control, string.Empty);
                    return false;
                case EditBox _ when control.Text == string.Empty:
                    errorProvider.SetError(control, errorText);
                    control.Focus();
                    return true;
                case EditBox _:
                    errorProvider.SetError(control, string.Empty);
                    return false;
                case ELEntryBox box:
                    {
                        var x = box;
                        if (x.Value.ToString() == string.Empty)
                        {
                            errorProvider.SetError(box, errorText);
                            box.Focus();
                            return true;
                        }
                        errorProvider.SetError(box, string.Empty);
                        return false;
                    }
                default:
                    return false;
                    //else
                    //    errorProvider.SetError((ComboBox)control,string.Empty);
            }
        }

        //public static bool NationalCodeCheck(string nationalCode)
        //{
        //    if (nationalCode.Length != 10) return (false);
        //    var tmp = 0;
        //    for (var i = 0; i < 8; i++) //check for 5555555555
        //        if (nationalCode[i] != nationalCode[i + 1])
        //            tmp = 1;
        //    if (tmp == 0) return (false);

        //    var a = nationalCode[9] - 48;
        //    var b = 0;
        //    for (var i = 0; i <= 8; i++)
        //        b += (nationalCode[i] - 48) * (10 - i);
        //    var c = b - (b / 11) * 11;
        //    if ((c == 0 || c == 1) && (a == c))
        //        return (true);
        //    return (c > 1) && (a == (11 - c));
        //}
        //public static bool MobileNumberCheck(string mobileNumber)
        //{
        //    const string pattern = @"(\+989|9|09)(12|19|35|36|37|38|39|32)\d{7}";
        //    return Regex.IsMatch(mobileNumber, pattern);
        //}

        //public static string GetIpAddress()
        //{
        //    var host = Dns.GetHostEntry(Dns.GetHostName());
        //    foreach (var ip in host.AddressList)
        //    {
        //        if (ip.AddressFamily == AddressFamily.InterNetwork)
        //        {
        //            return ip.ToString();
        //        }
        //    }

        //    throw new Exception("No network adapters with an IPv4 address in the system!");
        //}

        /// <summary>
        /// GetLocalIPv4(NetworkInterfaceType.Ethernet);
        /// GetLocalIPv4(NetworkInterfaceType.Wireless80211);
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static string GetLocalIPv4(NetworkInterfaceType? type = null)
        {
            type = type ?? NetworkInterfaceType.Ethernet;
            var output = string.Empty;
            foreach (var item in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (item.NetworkInterfaceType != type || item.OperationalStatus != OperationalStatus.Up) continue;

                foreach (var ip in item.GetIPProperties().UnicastAddresses)
                {
                    if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                    {
                        output = ip.Address.ToString();
                    }
                }
            }
            return output;
        }
        //public static string[] GetAllLocalIPv4(NetworkInterfaceType _type)
        //{
        //    return (
        //        from item in NetworkInterface.GetAllNetworkInterfaces()
        //        where item.NetworkInterfaceType == _type
        //              && item.OperationalStatus == OperationalStatus.Up
        //        from ip in item.GetIPProperties().UnicastAddresses
        //        where ip.Address.AddressFamily == AddressFamily.InterNetwork
        //        select ip.Address.ToString()).ToArray();
        //}
        /*************Image***********/

        //public static double ToFileSize(this int source)
        //{
        //    return ToFileSize(Convert.ToInt64(source));
        //}

        public static double ToFileSize(this long source)
        {
            const int byteConversion = 1024;
            var bytes = Convert.ToDouble(source);

            if (bytes >= Math.Pow(byteConversion, 3)) //GB Range
            {
                //return string.Concat(Math.Round(bytes / Math.Pow(byteConversion, 3), 2), " GB");
                return Math.Round(bytes / Math.Pow(byteConversion, 3), 2);
            }
            if (bytes >= Math.Pow(byteConversion, 2)) //MB Range
            {
                //return string.Concat(Math.Round(bytes / Math.Pow(byteConversion, 2), 2), " MB");
                return Math.Round(bytes / Math.Pow(byteConversion, 2), 2);
            }
            return bytes >= byteConversion ? Math.Round(bytes / byteConversion, 2) : bytes;
            //return string.Concat(bytes, " Bytes");
        }

        public static byte[] ConvertPicBoxImageToByte(Bitmap image, ImageFormat imageFormat)
        {
            try
            {
                if (image == null || Convert.IsDBNull(image))
                    return null;

                using (var ms = new MemoryStream())
                {
                    image.Save(ms, imageFormat);
                    return ms.ToArray(); //ms.GetBuffer();
                }
            }
            catch (Exception ex)
            {
                var dlg = new CustomDialogs(400, 200);
                dlg.Invoke("بروز خطا", ex.ToDetailedString(), CustomDialogs.ImageType.itError5,
                    CustomDialogs.ButtonType.Ok);
                return null;
            }
        }

        public static byte[] ConvertPicBoxImageToByte(PictureBox pbImage, ImageFormat imageFormat)
        {
            try
            {
                if (pbImage.Image == null || Convert.IsDBNull(pbImage.Image))
                    return null;

                using (var ms = new MemoryStream())
                {
                    pbImage.Image.Save(ms, imageFormat);
                    return ms.ToArray(); //ms.GetBuffer();
                }
            }
            catch (Exception ex)
            {
                var dlg = new CustomDialogs(400, 200);
                dlg.Invoke("بروز خطا", ex.ToDetailedString(), CustomDialogs.ImageType.itError5,
                    CustomDialogs.ButtonType.Ok);
                return null;
            }
        }

        //public static Image ConvertByteArrayToImage(byte[] myByteArray)
        //{
        //    try
        //    {
        //        var ms = new MemoryStream(myByteArray, 0, myByteArray.Length);
        //        ms.Write(myByteArray, 0, myByteArray.Length);
        //        return Image.FromStream(ms, true);
        //    }
        //    catch (Exception ex)
        //    {
        //        var dlg = new CustomDialogs(400, 200);
        //        dlg.Invoke("بروز خطا", ex.ExceptionToString(), CustomDialogs.ImageType.itError5,
        //            CustomDialogs.ButtonType.Ok);
        //        return null;
        //    }
        //}

        //public static byte[] ReadFile(string sPath)
        //{
        //    var fInfo = new FileInfo(sPath);
        //    var numOfBytes = fInfo.Length;
        //    var fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);
        //    var br = new BinaryReader(fStream);
        //    return br.ReadBytes((int)numOfBytes);
        //}

        public static Image GetImageFromBytes(byte[] bytes)
        {
            if (bytes == null || bytes.Length == 0)
            {
                return null;
            }

            Image result;
            MemoryStream stream = null;

            try
            {
                int count;
                int start;

                if (IsOleContainer(bytes))
                {
                    count = bytes.Length - OleHeaderSize;
                    start = OleHeaderSize;
                }
                else
                {
                    count = bytes.Length;
                    start = 0;
                }

                stream = new MemoryStream(bytes, start, count);
                result = Image.FromStream(stream);
            }
            catch
            {
                result = null;
            }
            finally
            {
                stream?.Close();
            }
            return result;
        }

        private static bool IsOleContainer(byte[] imageData)
        {
            return (imageData != null
                    && imageData[0] == 0x15
                    && imageData[1] == 0x1C);
        }

        /*********************************/

        //public static string AddSeparate(string number)
        //{
        //    try
        //    {

        //        int I;
        //        var floatPoint = string.Empty;
        //        var n = 0;
        //        var s = number;
        //        var len = s.Length;
        //        if (s.Contains("."))
        //        {
        //            var pos = s.LastIndexOf(".", StringComparison.Ordinal);
        //            floatPoint = s.Substring(pos, len - pos);
        //            s = s.Remove(pos);
        //            len = s.Length;
        //        }
        //        if (len < 4) return s + floatPoint;
        //        for (I = len - 1; I >= 1; I--)
        //        {
        //            n += 1;
        //            if (n != 3) continue;
        //            s = s.Insert(I, ",");
        //            n = 0;
        //        }
        //        return s + floatPoint;
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e);
        //        return "0";
        //    }
        //}

        //public static decimal ClearSeparate(string number)
        //{
        //    try
        //    {

        //        var sign = number.Contains("-");
        //        var s = string.Empty;
        //        var floatPoint = string.Empty;

        //        var len = number.Length;
        //        if (number.Contains("."))
        //        {
        //            var pos = number.LastIndexOf(".", StringComparison.Ordinal);
        //            floatPoint = number.Substring(pos, len - pos);
        //            number = number.Remove(pos);
        //            len = number.Length;
        //        }

        //        for (var I = 0; I < len; I++)
        //        {
        //            if (char.IsDigit(number[I]))
        //                s += number[I];
        //        }
        //        s = s + floatPoint;
        //        if (!sign) return Convert.ToDecimal(s);
        //        if (!s.Contains("-"))
        //            return -Convert.ToDecimal(s);
        //        return Convert.ToDecimal(s);
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e);
        //        return 0;
        //    }
        //}

        /*************************** Extensions ******************************/
        public static string AddSeparateEx(this string number)
        {
            if (string.IsNullOrWhiteSpace(number) || string.IsNullOrEmpty(number)) return "0";
            try
            {
                int I;
                var floatPoint = string.Empty;
                var n = 0;
                var s = number;
                var len = s.Length;
                if (s.Contains("."))
                {
                    var pos = s.LastIndexOf(".", StringComparison.Ordinal);
                    floatPoint = s.Substring(pos, len - pos);
                    s = s.Remove(pos);
                    len = s.Length;
                }
                if (len < 4) return s + floatPoint;
                for (I = len - 1; I >= 1; I--)
                {
                    n += 1;
                    if (n != 3) continue;
                    s = s.Insert(I, ",");
                    n = 0;
                }
                return s + floatPoint;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return "0";
            }
        }
        public static decimal ClearSeparateEx(this string number)
        {
            if (string.IsNullOrWhiteSpace(number) || string.IsNullOrEmpty(number)) return 0;

            try
            {
                var sign = number.Contains("-");
                var s = string.Empty;
                var floatPoint = string.Empty;

                var len = number.Length;
                if (number.Contains("."))
                {
                    var pos = number.LastIndexOf(".", StringComparison.Ordinal);
                    floatPoint = number.Substring(pos, len - pos);
                    number = number.Remove(pos);
                    len = number.Length;
                }

                for (var I = 0; I < len; I++)
                {
                    if (char.IsDigit(number[I]))
                        s += number[I];
                }
                s = s + floatPoint;
                if (!sign) return Convert.ToDecimal(s);
                if (!s.Contains("-"))
                    return -Convert.ToDecimal(s);
                return Convert.ToDecimal(s);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return 0;
            }
        }
        //public static string ConvertNumberOfLatin2Persian(string num)
        //{
        //    var result = string.Empty;
        //    foreach (var c in num.ToCharArray())
        //    {
        //        switch (c)
        //        {
        //            case '0':
        //                result += "٠";
        //                break;
        //            case '1':
        //                result += "١";
        //                break;
        //            case '2':
        //                result += "٢";
        //                break;
        //            case '3':
        //                result += "٣";
        //                break;
        //            case '4':
        //                result += "۴";
        //                break;
        //            case '5':
        //                result += "۵";
        //                break;
        //            case '6':
        //                result += "۶";
        //                break;
        //            case '7':
        //                result += "٧";
        //                break;
        //            case '8':
        //                result += "٨";
        //                break;
        //            case '9':
        //                result += "٩";
        //                break;
        //            default:
        //                result += c;
        //                break;

        //        }
        //    }
        //    return result;
        //}
        //public static string ToFarsi(string str)
        //{
        //    const string vInt = "1234567890";
        //    var myString = str.ToCharArray(0, str.Length);
        //    var newStr = string.Empty;
        //    for (var i = 0; i <= (myString.Length - 1); i++)
        //        if (vInt.IndexOf(myString[i]) == -1)
        //            newStr += myString[i];
        //        else
        //            newStr += ((char)((int)myString[i] + 1728));
        //    return newStr;
        //}

        /*************************Actions**************************************************************/

        //public static void InsertAction(Mode mode, Panel pnlData, RadGridView rgv, Control btnInsert,
        //    Control btnRegister, Control btnModify, Control btnDelete, Control btnCancel, Control btnClose,
        //    TextBox defaultTextBox, Timer tmrRegActive)
        //{
        //    //mode = TMode.mInsert;
        //    ClearInputControls(pnlData);
        //    rgv.Enabled = false;
        //    btnInsert.Enabled = false;
        //    btnRegister.Enabled = false;
        //    btnModify.Enabled = false;
        //    btnDelete.Enabled = false;
        //    btnCancel.Enabled = true;
        //    btnClose.Enabled = false;
        //    pnlData.Enabled = true;
        //    EnableControls(pnlData, true);
        //    defaultTextBox.Focus();
        //    tmrRegActive.Enabled = true;
        //}

        //public static void InsertAction(Mode mode, Panel pnlData, RadGridView rgv, Button btnInsert,
        //    Button btnRegister, Button btnModify, Button btnDelete, Button btnCancel, Button btnClose,
        //    TextBox defaultTextBox, Timer tmrRegActive)
        //{
        //    ClearInputControls(pnlData);
        //    rgv.Enabled = false;
        //    btnInsert.Enabled = false;
        //    btnRegister.Enabled = false;
        //    btnModify.Enabled = false;
        //    btnDelete.Enabled = false;
        //    btnCancel.Enabled = true;
        //    btnClose.Enabled = false;
        //    pnlData.Enabled = true;
        //    EnableControls(pnlData, true);
        //    defaultTextBox.Focus();
        //    tmrRegActive.Enabled = true;
        //}
        public static void InsertAction(Mode mode, Panel pnlData, RadGridView rgv, Button btnInsert,
            Button btnRegister, Button btnModify, Button btnDelete, Button btnCancel, Button btnClose,
            TextBox defaultTextBox)
        {
            ClearInputControls(pnlData, true);
            rgv.Enabled = false;
            btnInsert.Enabled = false;
            btnRegister.Enabled = false;
            btnModify.Enabled = false;
            btnDelete.Enabled = false;
            btnCancel.Enabled = true;
            btnClose.Enabled = false;
            pnlData.Enabled = true;
            EnableControls(pnlData, true);
            defaultTextBox.Focus();
        }
        public static void InsertAction(Mode mode, Panel pnlData, RadGridView rgv, Button btnInsert,
            Button btnRegister, Button btnModify, Button btnDelete, Button btnCancel, Button btnClose,
            RadDropDownList defaultTextBox)
        {
            ClearInputControls(pnlData);
            rgv.Enabled = false;
            btnInsert.Enabled = false;
            btnRegister.Enabled = false;
            btnModify.Enabled = false;
            btnDelete.Enabled = false;
            btnCancel.Enabled = true;
            btnClose.Enabled = false;
            pnlData.Enabled = true;
            EnableControls(pnlData, true);
            defaultTextBox.Focus();
        }
        public static void InsertAction(Mode mode, Panel pnlData, RadGridView rgv, Button btnInsert,
            Button btnRegister, Button btnModify, Button btnDelete, Button btnCancel, Button btnClose,
            EditBox defaultTextBox)
        {
            ClearInputControls(pnlData);
            rgv.Enabled = false;
            btnInsert.Enabled = false;
            btnRegister.Enabled = false;
            btnModify.Enabled = false;
            btnDelete.Enabled = false;
            btnCancel.Enabled = true;
            btnClose.Enabled = false;
            pnlData.Enabled = true;
            EnableControls(pnlData, true);
            defaultTextBox.Focus();
        }

        public static void InsertAction(Mode mode, Panel pnlData, RadGridView rgv, Button btnInsert,
            Button btnRegister, Button btnModify, Button btnDelete, Button btnCancel, Button btnClose,
            RadTextBox defaultTextBox)
        {
            ClearInputControls(pnlData);
            rgv.Enabled = false;
            btnInsert.Enabled = false;
            btnRegister.Enabled = false;
            btnModify.Enabled = false;
            btnDelete.Enabled = false;
            btnCancel.Enabled = true;
            btnClose.Enabled = false;
            pnlData.Enabled = true;
            EnableControls(pnlData, true);
            defaultTextBox.Focus();
        }

        //public static void InsertAction(Mode mode, Panel pnlData, RadGridView rgv, Button btnInsert,
        //    Button btnRegister, Button btnModify, Button btnDelete, Button btnCancel, Button btnClose,
        //    ELEntryBox defaultTextBox)
        //{
        //    ClearInputControls(pnlData);
        //    rgv.Enabled = false;
        //    btnInsert.Enabled = false;
        //    btnRegister.Enabled = false;
        //    btnModify.Enabled = false;
        //    btnDelete.Enabled = false;
        //    btnCancel.Enabled = true;
        //    btnClose.Enabled = false;
        //    pnlData.Enabled = true;
        //    EnableControls(pnlData, true);
        //    defaultTextBox.Focus();
        //}
        //public static void InsertAction(Mode mode, UIPanelInnerContainer pnlData, RadGridView rgv,
        //    Button btnInsert, Button btnRegister, Button btnModify, Button btnDelete, Button btnCancel,
        //    RadButton btnClose, TextBox defaultTextBox)
        //{
        //    ClearInputControls(pnlData);
        //    rgv.Enabled = false;
        //    btnInsert.Enabled = false;
        //    btnRegister.Enabled = false;
        //    btnModify.Enabled = false;
        //    btnDelete.Enabled = false;
        //    btnCancel.Enabled = true;
        //    btnClose.Enabled = false;
        //    pnlData.Enabled = true;
        //    EnableControls(pnlData, true);
        //    defaultTextBox.Focus();
        //}
        //public static void InsertAction(Mode mode, Panel pnlData, RadGridView rgv,
        //    Button btnInsert, Button btnRegister, Button btnModify, Button btnDelete, Button btnCancel,
        //    RadButton btnClose, EditBox defaultTextBox)
        //{
        //    ClearInputControls(pnlData);
        //    rgv.Enabled = false;
        //    btnInsert.Enabled = false;
        //    btnRegister.Enabled = false;
        //    btnModify.Enabled = false;
        //    btnDelete.Enabled = false;
        //    btnCancel.Enabled = true;
        //    btnClose.Enabled = false;
        //    pnlData.Enabled = true;
        //    EnableControls(pnlData, true);
        //    defaultTextBox.Focus();
        //}

        public static void InsertAction(Mode mode, Panel pnlData, RadListView rlv, Button btnInsert, Button btnRegister,
            Button btnModify, Button btnDelete, Button btnCancel, Button btnClose, TextBox defaultTextBox)
        {
            ClearInputControls(pnlData);
            rlv.Enabled = false;
            btnInsert.Enabled = false;
            btnRegister.Enabled = false;
            btnModify.Enabled = false;
            btnDelete.Enabled = false;
            btnCancel.Enabled = true;
            btnClose.Enabled = false;
            pnlData.Enabled = true;
            EnableControls(pnlData, true);
            defaultTextBox?.Focus();
        }

        public static void InsertAction(Mode mode, Panel pnlData, RadGridView rgv, Button btnInsert,
            Button btnRegister, Button btnModify, Button btnDelete, Button btnCancel, Button btnClose,
            UIComboBox defaultComboBox)
        {
            ClearInputControls(pnlData);
            rgv.Enabled = false;
            btnInsert.Enabled = false;
            btnRegister.Enabled = false;
            btnModify.Enabled = false;
            btnDelete.Enabled = false;
            btnCancel.Enabled = true;
            btnClose.Enabled = false;
            pnlData.Enabled = true;
            EnableControls(pnlData, true);
            defaultComboBox.Focus();
        }
        public static void InsertAction(Mode mode, Panel pnlData, RadGridView rgv, Button btnInsert,
        Button btnRegister, Button btnModify, Button btnDelete, Button btnCancel, Button btnClose,
        MaskedTextBox defaultTextBox)
        {
            ClearInputControls(pnlData);
            rgv.Enabled = false;
            btnInsert.Enabled = false;
            btnRegister.Enabled = false;
            btnModify.Enabled = false;
            btnDelete.Enabled = false;
            btnCancel.Enabled = true;
            btnClose.Enabled = false;
            pnlData.Enabled = true;
            EnableControls(pnlData, true);
            defaultTextBox.Focus();
            defaultTextBox.SelectAll();
        }

        public static void InsertActionExpense(Panel pnlData, RadGridView rgv, Button btnInsert,
            Button btnRegister, Button btnModify, Button btnDelete, Button btnCancel,
            Button btnClose, Button btnExportToExcel,
            MaskedTextBox defaultTextBox)
        {
            rgv.Enabled = false;
            btnInsert.Enabled = false;
            btnRegister.Enabled = false;
            btnModify.Enabled = false;
            btnDelete.Enabled = false;
            btnCancel.Enabled = true;
            btnClose.Enabled = false;
            btnExportToExcel.Enabled = false;
            ClearInputControls(pnlData);
            defaultTextBox.Focus();
            defaultTextBox.SelectAll();
        }

        //public static void CancelAction(Mode mode, ELGroupBox pnlData, RadGridView rgv, Button btnInsert,
        //    Button btnRegister, Button btnModify, Button btnDelete, Button btnCancel, Button btnClose)
        //{
        //    btnCancel.Enabled = false;
        //    btnInsert.Enabled = true;
        //    btnRegister.Enabled = false;
        //    btnDelete.Enabled = true;
        //    btnClose.Enabled = true;
        //    rgv.Enabled = true;
        //    EnableControls(pnlData, false);
        //}
        public static void CancelAction(Mode mode, Panel pnlData, RadGridView rgv, Button btnInsert,
            Button btnRegister, Button btnModify, Button btnDelete, Button btnCancel, Button btnClose)
        {
            //mode = TMode.mCancel;
            btnCancel.Enabled = false;
            btnInsert.Enabled = true;
            btnRegister.Enabled = false;
            btnDelete.Enabled = true;
            btnClose.Enabled = true;
            ////btnModify.Enabled     = true;
            rgv.Enabled = true;
            EnableControls(pnlData, false);
            //txt_PersonCode.ReadOnly = true;
            //txt_PersonCode.BackColor = Color.FromArgb(229, 237, 251);
            //txt_PersonCode.ForeColor = Color.White;
        }
        public static void CancelActionExpense(RadGridView rgv, Button btnInsert,
            Button btnRegister, Button btnDelete, Button btnCancel, Button btnClose,
            Button btnExportToExcel)
        {
            rgv.Enabled = true;
            btnCancel.Enabled = false;
            btnInsert.Enabled = true;
            btnRegister.Enabled = false;
            btnDelete.Enabled = true;
            btnClose.Enabled = true;
            btnExportToExcel.Enabled = true;
        }
        //public static void CancelAction(Mode mode, UIPanelInnerContainer pnlData, RadGridView rgv,
        //    Button btnInsert, Button btnRegister, Button btnModify, Button btnDelete, Button btnCancel,
        //    Button btnClose)
        //{
        //    btnCancel.Enabled = false;
        //    btnInsert.Enabled = true;
        //    btnRegister.Enabled = false;
        //    btnDelete.Enabled = true;
        //    btnClose.Enabled = true;
        //    rgv.Enabled = true;
        //    EnableControls(pnlData, false);
        //}
        public static void CancelAction(Mode mode, Panel pnlData, RadListView rgv, Button btnInsert,
            Button btnRegister, Button btnModify, Control btnDelete, Button btnCancel, Button btnClose)
        {
            btnCancel.Enabled = false;
            btnInsert.Enabled = true;
            btnRegister.Enabled = false;
            btnDelete.Enabled = true;
            btnClose.Enabled = true;
            rgv.Enabled = true;
            EnableControls(pnlData, false);
        }
        //public static void ModifyAction(Mode mode, ELGroupBox pnlData, RadGridView rgv,
        //    Button btnInsert, Button btnRegister, Button btnModify, Button btnDelete,
        //    Button btnCancel, Button btnClose)
        //{
        //    EnableControls(pnlData, true);
        //    btnRegister.Enabled = true;
        //    btnCancel.Enabled = true;
        //    btnInsert.Enabled = false;
        //    btnModify.Enabled = false;
        //    btnDelete.Enabled = false;
        //    btnClose.Enabled = false;
        //    rgv.Enabled = false;
        //}

        public static void ModifyAction(Mode mode, Panel pnlData, RadGridView rgv, Button btnInsert,
            Button btnRegister, Button btnModify, Button btnDelete, Button btnCancel, Button btnClose)
        {
            //mode = TMode.mUpdate;
            EnableControls(pnlData, true);
            btnRegister.Enabled = true;
            btnCancel.Enabled = true;
            btnInsert.Enabled = false;
            btnModify.Enabled = false;
            btnDelete.Enabled = false;
            btnClose.Enabled = false;
            rgv.Enabled = false;
        }
        public static void ModifyActionExpense(RadGridView rgv, Button btnInsert,
            Button btnRegister, Button btnModify, Button btnDelete, Button btnCancel,
            Button btnClose, Button btnExportToExcel)
        {
            //mode = TMode.mUpdate;
            rgv.Enabled = false;
            btnRegister.Enabled = true;
            btnCancel.Enabled = true;
            btnInsert.Enabled = false;
            btnModify.Enabled = false;
            btnDelete.Enabled = false;
            btnClose.Enabled = false;
            btnExportToExcel.Enabled = false;
        }
        //public static void ModifyAction(Mode mode, UIPanelInnerContainer pnlData, RadGridView rgv,
        //    Button btnInsert, Button btnRegister, Button btnModify, Button btnDelete,
        //    Button btnCancel, Button btnClose)
        //{
        //    EnableControls(pnlData, true);
        //    btnRegister.Enabled = true;
        //    btnCancel.Enabled = true;
        //    btnInsert.Enabled = false;
        //    btnModify.Enabled = false;
        //    btnDelete.Enabled = false;
        //    btnClose.Enabled = false;
        //    rgv.Enabled = false;
        //}
        public static void ModifyAction(Mode mode, Panel pnlData, RadListView rgv,
            Button btnInsert, Button btnRegister, Button btnModify, Button btnDelete,
            Button btnCancel, Button btnClose)
        {
            EnableControls(pnlData, true);
            btnRegister.Enabled = true;
            btnCancel.Enabled = true;
            btnInsert.Enabled = false;
            btnModify.Enabled = false;
            btnDelete.Enabled = false;
            btnClose.Enabled = false;
            rgv.Enabled = false;
        }

        public static void SortOrderByColumn(RadGridView radGrid, string columnName, ListSortDirection sortOrder)
        {
            radGrid.MasterTemplate.SortDescriptors.Clear();
            radGrid.MasterTemplate.SortDescriptors.Add(columnName, sortOrder);
        }
        /********************************************************************************************/

        //public static string Encrypt(string cleanString)
        //{
        //    var clearBytes = new UnicodeEncoding().GetBytes(cleanString);
        //    var hashedBytes = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(clearBytes);
        //    return BitConverter.ToString(hashedBytes);
        //}

        public static string Encode(string str)
        {
            var encBuff = Encoding.UTF8.GetBytes(str);
            return Convert.ToBase64String(encBuff);
        }

        public static string Decode(string str)
        {
            var decBuff = Convert.FromBase64String(str);
            return Encoding.UTF8.GetString(decBuff);
        }

        public static string GetResourceValue(string resourceName)
        {
            return Resources.ResourceManager.GetString(resourceName);
        }

        //public static PictureBox CreatePictureLoading(Control parent, Size size, Point location, Image image, BorderStyle style)
        //{
        //    var pictureBox = new PictureBox
        //    {
        //        Parent = parent,
        //        Size = size,
        //        Location = location,
        //        Image = image,
        //        BackColor = Color.Transparent,
        //        BorderStyle = style,
        //        SizeMode = PictureBoxSizeMode.StretchImage,
        //        TabStop = false,
        //        Visible = false
        //    };
        //    return pictureBox;
        //}

        public static PictureBox CreateIndicatorLoading(Control form, Size size, Point location, Image image,
            bool visible = true, PictureBoxSizeMode mode = PictureBoxSizeMode.StretchImage,
            BorderStyle style = BorderStyle.FixedSingle)
        {
            var pictureBox = new PictureBox()
            {
                Parent = form,
                SizeMode = mode, //PictureBoxSizeMode.StretchImage,
                BorderStyle = style, //BorderStyle.FixedSingle,
                Size = size, //new Size(356, 19),
                Location = location, //new Point(10, 101),//new Point(pnl_Data.Width / 25, pnl_Data.Height / 20),
                Image = image, //Resources.Loadingvvv,
                Visible = visible
            };

            return pictureBox;
        }

        public static void IndicatorLoading(PictureBox picLoading, bool visibility = false)
        {
            switch (visibility)
            {
                case true:
                    //picLoading.Location = location;//new Point(parent.Width / 2, parent.Height / 4);

                    picLoading.BringToFront();
                    picLoading.Visible = true;

                    //pnl_Data.BackColor = System.Drawing.Color.CornflowerBlue;
                    break;
                case false:
                    picLoading.Visible = false;

                    //pnl_Data.BackColor = System.Drawing.Color.FromArgb(214, 228, 245);
                    break;
            }
        }

        //public static void IndicatorLoading(Form parent, PictureBox picLoading, bool visibility = false)
        //{
        //    switch (visibility)
        //    {
        //        case true:
        //            parent.Invoke((MethodInvoker)delegate
        //            {
        //                picLoading.BringToFront();
        //                picLoading.Visible = true;
        //                //picLoading.Show();
        //                //picLoading.Update();
        //                parent.Cursor = Cursors.WaitCursor;
        //            });
        //            //picLoading.Location = location;//new Point(parent.Width / 2, parent.Height / 4);

        //            //picLoading.BringToFront();
        //            //picLoading.Visible = true;

        //            //pnl_Data.BackColor = System.Drawing.Color.CornflowerBlue;
        //            break;
        //        case false:
        //            parent.Invoke((MethodInvoker)delegate
        //            {
        //                picLoading.Visible = false;
        //                parent.Cursor = Cursors.Default;
        //            });

        //            //picLoading.Visible = false;

        //            //pnl_Data.BackColor = System.Drawing.Color.FromArgb(214, 228, 245);
        //            break;
        //    }
        //}
        //public static string ExceptionToString(this Exception ex)
        //{
        //    var errorMsg = new StringBuilder();
        //    for (var current = ex; current != null; current = current.InnerException)
        //    {
        //        if (errorMsg.Length > 0)
        //            errorMsg.Append("\n");
        //        errorMsg.Append(current.Message.
        //        Replace("See the inner exception for details.", string.Empty));
        //    }
        //    return errorMsg.ToString();
        //}

        public static Panel GenerateParentPanel(Panel pnlFloating, BorderStyle style,
                                                        int width, int height, Control parent)
        {
            pnlFloating.BorderStyle = style;
            pnlFloating.Height = height;
            pnlFloating.Width = width;
            pnlFloating.Visible = false;
            parent.Controls.Add(pnlFloating);
            return pnlFloating;
        }
        public static Panel GenerateParentPanel(Panel pnlFloating, RadGridView rgv, string headerText,
                            BorderStyle style, int width, int height, Control parent)
        {
            pnlFloating.Controls.Clear();
            pnlFloating.BorderStyle = style;
            pnlFloating.Height = height;
            pnlFloating.Width = width;
            pnlFloating.Visible = false;
            parent.Controls.Add(pnlFloating);

            var header = new Label()
            {
                Dock = DockStyle.Top,
                Height = 29,
                BackColor = Color.FromArgb(255, 64, 64, 64),
                ForeColor = Color.White,
                Text = headerText,
                TextAlign = ContentAlignment.MiddleCenter,
                Cursor = Cursors.Hand
            };
            var closeButton = new Button
            {
                // Text = "X",
                Width = 29,
                Height = 29,
                BackColor = Color.White,
                ForeColor = Color.Gray,
                Dock = DockStyle.Right,
                Cursor = Cursors.Hand,
                Image = Resources.CloseIcon,
                ImageAlign = ContentAlignment.MiddleCenter
            };
            closeButton.Click += delegate
            {
                pnlFloating.Visible = false;
            };
            header.MouseDown += delegate (object o, MouseEventArgs args)
            {
                if (args.Button != MouseButtons.Left) return;
                ReleaseCapture();
                SendMessage(pnlFloating.Handle, WmNclButtonDown, HtCaption, 0);
            };
            header.SendToBack();
            header.Controls.Add(closeButton);
            pnlFloating.Controls.Add(header);
            pnlFloating.Controls.Add(rgv);
            return pnlFloating;
        }

        //public static RadGridView GenerateGridView(RadGridView rgv, Control parent, Size size,
        //    DockStyle dock, List<string> fileNames, List<string> headerTexts, List<int> columnWidths,
        //    List<bool> visibleFields)
        //{
        //    rgv.Columns.Clear();
        //    rgv.AllowAddNewRow = false;
        //    rgv.AllowColumnChooser = true;
        //    rgv.AllowDeleteRow = false;
        //    rgv.AllowColumnReorder = true;
        //    rgv.AllowRowResize = false;
        //    rgv.EnableAlternatingRowColor = true;
        //    rgv.EnableFiltering = true;
        //    rgv.EnableGrouping = false;
        //    rgv.SelectionMode = GridViewSelectionMode.FullRowSelect;
        //    rgv.ShowFilteringRow = true;
        //    rgv.ReadOnly = true;
        //    rgv.AutoGenerateColumns = false;
        //    parent.Controls.Add(rgv);
        //    rgv.Size = size;//new Size(370, 365);
        //    rgv.BringToFront();
        //    rgv.Dock = dock;//DockStyle.None;
        //    //SetFont(rgv, BaseFont);
        //    int[] n = { 0 };
        //    foreach (var textBoxColumn in fileNames.Select(fileName => new GridViewTextBoxColumn(fileName)
        //    {
        //        HeaderText = headerTexts[n[0]],
        //        Width = columnWidths[n[0]],
        //        IsVisible = visibleFields[n[0]]
        //    }))
        //    {
        //        n[0] += 1;
        //        rgv.Columns.Add(textBoxColumn);
        //    }
        //    return rgv;
        //}
        public static RadGridView GenerateGridView(RadGridView rgv, List<string> fileNames,
                List<string> headerTexts, List<int> columnWidths, List<bool> visibleFields)
        {
            rgv.Columns.Clear();
            rgv.CellFormatting += rgv_CellFormatting;
            rgv.AllowAddNewRow = false;
            rgv.AllowColumnChooser = true;
            rgv.AllowDeleteRow = false;
            rgv.AllowColumnReorder = true;
            rgv.AllowRowResize = false;
            rgv.EnableAlternatingRowColor = true;
            rgv.EnableFiltering = true;
            rgv.EnableGrouping = false;
            rgv.SelectionMode = GridViewSelectionMode.FullRowSelect;
            rgv.ShowFilteringRow = true;
            //rgv.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            rgv.Dock = DockStyle.Fill;
            rgv.ReadOnly = true;
            rgv.AutoGenerateColumns = false;
            rgv.BringToFront();
            //SetFont(rgv, BaseFont);
            // rgv.AutoSize = true;
            var n = 0;
            foreach (var fileName in fileNames)
            {
                var textBoxColumn = new GridViewTextBoxColumn(fileName)
                {
                    HeaderText = headerTexts[n],
                    Width = columnWidths[n],
                    IsVisible = visibleFields[n]
                };
                n += 1;
                rgv.Columns.Add(textBoxColumn);
            }
            return rgv;
        }

        static void rgv_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            e.CellElement.TextAlignment = ContentAlignment.MiddleCenter;
        }
        //public static void InvalidateFloatingGrid(RadGridView rgv)
        //{
        //    if (rgv != null && rgv.Visible)
        //    {
        //        rgv.Visible = false;
        //    }
        //}
        //public static string SetAccessLevel(RadTreeView rtvView)
        //{
        //    var result = (from item in rtvView.Nodes
        //                  from item2 in item.Nodes
        //                  where item2.Checked
        //                  select item2).Aggregate(string.Empty, (current, item2) =>
        //                    current + (Encode(item2.Name) + ";"));

        //    if (result != string.Empty)
        //        result = result.Substring(0, result.Length - 1);
        //    return result;
        //}
        //public static bool GetAccessLevel(string[] accessLevel, string levelName)
        //{
        //    var accessLevelDecode = string.Empty;
        //    var result = false;
        //    foreach (var t in accessLevel)
        //    {
        //        accessLevelDecode += Decode(t) + ";";
        //    }

        //    if (accessLevelDecode.Length <= 1) return false;

        //    accessLevelDecode = accessLevelDecode.Substring(0, accessLevelDecode.Length - 1);
        //    if ((accessLevelDecode.Contains(levelName)))
        //    {
        //        result = true;
        //    }
        //    return result;
        //}
        //public static void ClearTreeViewCheckBoxes(RadTreeView rtvView)
        //{
        //    foreach (var item in rtvView.Nodes)
        //    {
        //        item.Checked = false;
        //        foreach (var item2 in item.Nodes)
        //        {
        //            item2.Checked = false;
        //        }
        //    }
        //}

        //public static ImageFormat GetImageFormatByExtenstion(string extension)
        //{
        //    var imageFormat = ImageFormat.Png;
        //    switch (extension)
        //    {
        //        //case ".ico":
        //        //    imageFormat = ImageFormat.Icon;
        //        //    break;
        //        case ".bmp":
        //            imageFormat = ImageFormat.Bmp;
        //            break;
        //        case ".png":
        //        case ".ico":
        //            imageFormat = ImageFormat.Png;
        //            break;
        //        case ".jpg":
        //        case ".jpeg":
        //            imageFormat = ImageFormat.Jpeg;
        //            break;
        //        case ".gif":
        //            imageFormat = ImageFormat.Gif;
        //            break;
        //        case ".tiff":
        //            imageFormat = ImageFormat.Tiff;
        //            break;
        //        case ".wmf":
        //            imageFormat = ImageFormat.Wmf;
        //            break;
        //        case ".exif":
        //            imageFormat = ImageFormat.Exif;
        //            break;
        //        case ".emf":
        //            imageFormat = ImageFormat.Emf;
        //            break;
        //        default:
        //            imageFormat = ImageFormat.Png;
        //            break;
        //    }
        //    return imageFormat;
        //}

        public static string OpenDialogForSelectPicture(PictureBox picBox)
        {
            try
            {
                var openDialog = new OpenFileDialog
                {
                    Title = DefaultConstants.SelectOptionString,
                    FileName = string.Empty,
                    InitialDirectory = Application.StartupPath + "Images",
                    Filter = Resources.ImageTypes,
                    FilterIndex = 1
                };
                if (openDialog.ShowDialog() != DialogResult.OK) return string.Empty;
                var file = new FileInfo(openDialog.FileName);
                var size = file.Length;
                var extension = file.Extension;
                if (size.ToFileSize() <= 500)
                {
                    picBox.Image = new Bitmap(openDialog.FileName);
                    //  lbl_PicSize.Text = CommonHelper.ToFileSize(size) + " kb";
                }
                else
                {
                    var dlg = new CustomDialogs(400, 200);
                    dlg.Invoke(DefaultConstants.ImageSizeWarningTitle, DefaultConstants.ImageSizeWarningMessage,
                        CustomDialogs.ImageType.itError5, CustomDialogs.ButtonType.Ok, Color.Bisque);
                    extension = OpenDialogForSelectPicture(picBox);
                }
                return extension;
            }
            catch (Exception ex)
            {
                var dlg = new CustomDialogs(200, 400);
                dlg.Invoke("بروز خطا", ex.ToDetailedString(), CustomDialogs.ImageType.itError6, CustomDialogs.ButtonType.Ok);
                return string.Empty;
            }
        }

        public static string IncDayOfDate(string date, int n, FormatDate formatDate)
        {
            var y = 0;
            var m = 0;
            var d = 0;
            switch (formatDate)
            {
                case FormatDate.Fd2Year:

                    y = int.Parse(date[0] + date[1].ToString());
                    m = int.Parse(date[3] + date[4].ToString());
                    d = int.Parse(date[6] + date[7].ToString());
                    break;
                case FormatDate.Fd4Year:
                    y = int.Parse(date[0] + date[1].ToString() +
                                  date[2] + date[3]);
                    m = int.Parse(date[5] + date[6].ToString());
                    d = int.Parse(date[8] + date[9].ToString());
                    break;
            }

            d += n;

            switch (m)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    if (d > 31)
                    {
                        m += 1;
                        d = 1;
                    }
                    break;
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                    if (d > 30)
                    {
                        m += 1;
                        d = 1;
                    }
                    break;
                case 12:
                    var dd = PersianHelper.IsLeapPersianYear(y) ? 30 : 29;
                    if (d > dd)
                    {
                        y += 1;
                        m = 1;
                        d = 1;
                    }

                    break;
            }

            var year = Convert.ToString(y);
            var month = Convert.ToString(m);
            var day = Convert.ToString(d);

            if (m <= 9)
                month = "0" + m;
            if (d <= 9)
                day = "0" + d;

            var tempDate = year + '/' + month + '/' + day;

            return tempDate;
        }

        public static string DecDayOfDate(string date, int n, FormatDate formatDate)
        {
            var y = 0;
            var m = 0;
            var d = 0;
            switch (formatDate)
            {
                case FormatDate.Fd2Year:

                    y = int.Parse(date[0] + date[1].ToString());
                    m = int.Parse(date[3] + date[4].ToString());
                    d = int.Parse(date[6] + date[7].ToString());
                    break;
                case FormatDate.Fd4Year:
                    y = int.Parse(date[0] + date[1].ToString() +
                                  date[2] + date[3]);
                    m = int.Parse(date[5] + date[6].ToString());
                    d = int.Parse(date[8] + date[9].ToString());
                    break;
            }

            d -= n;
            if (d <= 0)
            {
                switch (m - 1)
                {
                    case 0:
                        m = 13;
                        y -= 1;
                        d = PersianHelper.IsLeapPersianYear(y) ? 30 : 29;
                        break;
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                        d += 31;
                        break;
                    case 7:
                    case 8:
                    case 9:
                    case 10:
                    case 11:
                        d += 30;
                        break;
                    case 12:
                        var dd = PersianHelper.IsLeapPersianYear(y) ? 30 : 29;
                        d += dd;
                        break;
                }
                m -= 1;
            }

            var year = Convert.ToString(y);
            var month = Convert.ToString(m);
            var day = Convert.ToString(d);

            if (m < 1 && d < 1)
            {
                year = Convert.ToString(y - 1);
                m = 12;
                d = 29;
            }

            if (m <= 9)
                month = "0" + m;
            if (d <= 9)
                day = "0" + Convert.ToString(d);

            var tempDate = year + '/' + month + '/' + day;

            return tempDate;
        }
        public static void ShowNotificationMessage(string title, string contentText,
            Size? popUpSize = null, Size? imageSize = null,
            Padding? contentPadding = null, Padding? titlePadding = null, Padding? imagePadding = null,
            Font titleFont = null, Font contentFont = null,
            Color? bodyColor = null, Color? borderColor = null, Color? buttonBorderColor = null,
            Color? contentColor = null, Color? headerColor = null, Color? titleColor = null, Image popupImage = null,
            int delay = 1000, int animInterval = 5, int animDuration = 1000, int headerHeight = 15,
            bool isRightToLeft = true, bool showCloseButton = true, bool scroll = true,
            bool showGrip = false, bool showOptionsButton = false)
        {
            var popup = new PopupNotifier
            {
                IsRightToLeft = isRightToLeft,
                ImageSize = imageSize ?? new Size(48, 48),
                Image = popupImage,
                ImagePadding = imagePadding ?? new Padding(2),
                TitleFont = titleFont ?? new Font(new FontFamily("Tornado Tahoma"), 12.0F, FontStyle.Bold),
                AnimationDuration = animDuration,
                BodyColor = bodyColor ?? ColorTranslator.FromHtml("#1E1E1E"),//Color.Snow,
                BorderColor = borderColor ?? ColorTranslator.FromHtml("#767D8D"), //Color.Yellow,
                ContentFont = contentFont ?? new Font(new FontFamily("Tornado Tahoma"), 12.0F),
                AnimationInterval = animInterval,
                ButtonBorderColor = buttonBorderColor ?? Color.Yellow,
                ContentColor = contentColor ?? Color.White,//Color.Red,
                Delay = delay,
                Scroll = scroll,
                ContentPadding = contentPadding ?? new Padding(10),
                HeaderColor = headerColor ?? Color.DimGray,
                HeaderHeight = headerHeight,
                Size = popUpSize ?? new Size(400, 150),
                TitleColor = titleColor ?? Color.BurlyWood,
                ShowCloseButton = showCloseButton,
                ShowOptionsButton = showOptionsButton,
                ShowGrip = showGrip,
                TitlePadding = titlePadding ?? new Padding(5),
                TitleText = title,
                ContentText = contentText,
            };
            popup.Popup();

            //var popupNotifier1 = new PopupNotifier();
            //popupNotifier1.TitleText = title;
            //popupNotifier1.ContentText = contentText;
            //popupNotifier1.ShowCloseButton = showCloseButton;
            ////popupNotifier1.ShowOptionsButton = chkMenu.Checked;
            ////popupNotifier1.ShowGrip = chkGrip.Checked;
            //popupNotifier1.Delay = delay;
            //popupNotifier1.AnimationInterval = animInterval;
            //popupNotifier1.AnimationDuration = animDuration;

            ////popupNotifier1.TitlePadding = new Padding(int.Parse(txtPaddingTitle.Text));
            ////popupNotifier1.ContentPadding = new Padding(int.Parse(txtPaddingContent.Text));
            ////popupNotifier1.ImagePadding = new Padding(int.Parse(txtPaddingIcon.Text));
            ////popupNotifier1.Scroll = chkScroll.Checked;

            ////if (chkIcon.Checked)
            ////{
            ////    popupNotifier1.Image = Properties.Resources._157_GetPermission_48x48_72;
            ////}
            ////else
            ////{
            ////    popupNotifier1.Image = null;
            ////}

            //popupNotifier1.Popup();
        }
        //public static Image DrawReflection(Image img, Color toBG) // img is the original image.
        //{
        //    //This is the static function that generates the reflection...
        //    int height = img.Height + 100; //Added height from the original height of the image.
        //    Bitmap bmp = new Bitmap(img.Width, height, PixelFormat.Format64bppPArgb); //A new bitmap.
        //    Brush brsh = new LinearGradientBrush(new Rectangle(0, 0, img.Width + 10, height), Color.Transparent, toBG, LinearGradientMode.Vertical);//The Brush that generates the fading effect to a specific color of your background.
        //    bmp.SetResolution(img.HorizontalResolution, img.VerticalResolution); //Sets the new bitmap's resolution.
        //    using (Graphics grfx = Graphics.FromImage(bmp)) //A graphics to be generated from an image (here, the new Bitmap we've created (bmp)).
        //    {
        //        Bitmap bm = (Bitmap)img; //Generates a bitmap from the original image (img).
        //        grfx.DrawImage(bm, 0, 0, img.Width, img.Height); //Draws the generated bitmap (bm) to the new bitmap (bmp).
        //        Bitmap bm1 = (Bitmap)img; //Generates a bitmap again from the original image (img).
        //        bm1.RotateFlip(RotateFlipType.Rotate180FlipX); //Flips and rotates the image (bm1).
        //        grfx.DrawImage(bm1, 0, (img.Height / 2) + 40); //Draws (bm1) below (bm) so it serves as the reflection image.
        //        Rectangle rt = new Rectangle(0, img.Height, img.Width, 40); //A new rectangle to paint our gradient effect.
        //        grfx.FillRectangle(brsh, rt); //Brushes the gradient on (rt).
        //    }
        //    return bmp; //Returns the (bmp) with the generated image.
        //}

        public static void Fill<T>(RadDropDownList ddl, string displayMember, string valueMember, IList<T> t, T defaultOption)
        {
            ddl.DisplayMember = displayMember;
            ddl.ValueMember = valueMember;
            t.Insert(0, defaultOption);
            ddl.DataSource = t;
        }

        public static void SetEnableDisableStatusDropdownList(this RadDropDownList ddl)
        {
            ddl.Items.Add(new RadListDataItem(DefaultConstants.ActiveOptionString, 0));
            ddl.Items.Add(new RadListDataItem(DefaultConstants.NonActiveOptionString, 1));
            //ddl.SelectedValue = 0;
        }
        public static void SetMaleAndFemaleOptionsDropdownList(this RadDropDownList ddl)
        {
            ddl.Items.Add(new RadListDataItem(DefaultConstants.GenderMaleOptionString, 0));
            ddl.Items.Add(new RadListDataItem(DefaultConstants.GenderFemaleOptionString, 1));
            //ddl.SelectedValue = 0;
        }
    }
}
