using MessageBoxHamidNCH;
using PersonalAccounting.BLL.Enum;
using PersonalAccounting.BLL.IService;
using PersonalAccounting.CommonLibrary.Helper;
using PersonalAccounting.Domain.Entity;
using PersonalAccounting.Domain.ViewModel;
using PersonalAccounting.UI.Helper;
using PersonalAccounting.UI.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace PersonalAccounting.UI
{
    public partial class FrmDiaryNote : BaseForm
    {
        public static FrmDiaryNote AFrmDiaryNote = null;
        private readonly IDiaryNoteService _diaryNoteService;
        private readonly
            IRepositoryService<MentalCondition, ViewModelLoadAllMentalCondition, ViewModelSimpleLoadMentalCondition> _mentalConditionService;
        private readonly
            IRepositoryService<WeatherCondition, ViewModelLoadAllWeatherCondition, ViewModelSimpleLoadWeatherCondition> _weatherConditionService;

        private readonly IUserService _userService;

        private readonly BackgroundWorker _backgroundWorker;
        private readonly PictureBox _pictureBox;
        //private Cryption _cryption;
        //private PictureBox _pictureBox;
        //private RadDateTimePicker _radDateTimePicker = null;

        //private delegate void SafeCallDelegate(string text);

        //public FrmLoading LoadingForm;

        //private string _note = string.Empty;

        private bool _success = false;
        private string _selectedDate;
        private bool _isModify = false;
        private const int Indent = 20;

        public static FrmDiaryNote Instance()
        {
            return AFrmDiaryNote ?? (AFrmDiaryNote = IocConfig.Container.GetInstance<FrmDiaryNote>());
        }

        public FrmDiaryNote(IDiaryNoteService diaryNoteService,
            IRepositoryService<MentalCondition, ViewModelLoadAllMentalCondition, ViewModelSimpleLoadMentalCondition> mentalConditionService,
            IRepositoryService<WeatherCondition, ViewModelLoadAllWeatherCondition, ViewModelSimpleLoadWeatherCondition> weatherConditionService,
            IUserService userService)
        {
            _diaryNoteService = diaryNoteService;
            _mentalConditionService = mentalConditionService;
            _weatherConditionService = weatherConditionService;
            _userService = userService;

            _backgroundWorker = new BackgroundWorker();
            _backgroundWorker.DoWork += BackgroundWorker_DoWork;
            _backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;

            InitializeComponent();

            rtb_Note.AllowDrop = true;
            rtb_Note.DragEnter += Rtb_Note_DragEnter;
            rtb_Note.DragDrop += Rtb_Note_DragDrop;

            _pictureBox = CommonHelper.CreateIndicatorLoading(rtb_Note, new Size(500, 100),
                new Point((rtb_Note.Width / 2) - 150, (rtb_Note.Height / 2) - 200),
                CommonLibrary.Properties.Resources.LoadingNote, false,
                PictureBoxSizeMode.StretchImage, BorderStyle.None);

            _pictureBox.Click += _pictureBox_Click;

            //numberLabel.Font = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size + 1.019f);
            //numberLabel.Font = new Font(rtb_Note.Font.FontFamily, rtb_Note.Font.Size);

            // Load system fonts
            foreach (var family in FontFamily.Families)
            {
                tsc_FontName.Items.Add(family.Name);
            }

            tsc_FontName.SelectedItem = "Tahoma";
            tsc_FontSize.SelectedItem = "10";

            tst_ZoomFactor.Text = Convert.ToString(rtb_Note.ZoomFactor * 100,
                CultureInfo.InvariantCulture);
            tsb_WordWrap.Checked = rtb_Note.WordWrap;

            FillDropdownList(rddl_Users);
            FillDropdownList(rddl_MentalConditions);
            FillDropdownList(rddl_WeatherConditions);

            _selectedDate = PersianHelper.GetPersiaDateSimple(DateTime.Now);
            txt_diaryNoteDate.Text = _selectedDate;

            _isModify = false;
        }

        private void Rtb_Note_DragDrop(object sender, DragEventArgs e)
        {
            _isModify = true;
            var arrayFileName = (Array)e.Data.GetData(DataFormats.FileDrop);

            var strFileName = arrayFileName.GetValue(0).ToString();

            var sr = new StreamReader(strFileName, System.Text.Encoding.Default);
            rtb_Note.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void Rtb_Note_DragEnter(object sender, DragEventArgs e)
        {
            //if (e.Data.GetDataPresent(DataFormats.Text))
            //{
            //    e.Effect = DragDropEffects.Copy;
            //}
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void _pictureBox_Click(object sender, EventArgs e)
        {
            if (_backgroundWorker.WorkerSupportsCancellation)
                _backgroundWorker.CancelAsync();
        }

        private async Task<int> GetSelectedUserId()
        {
            var currentUser = InitialHelper.CurrentUser;
            if (!await currentUser.IsAdmin())
            {
                return currentUser.Id;
            }

            try
            {
                return int.Parse(rddl_Users.SelectedValue.ToString());
            }
            catch (Exception exception)
            {
                await LoggerService.ErrorAsync(this.Name, "GetSelectedUserId", exception.Message,
                    exception.ToDetailedString());
                return currentUser.Id;
            }
        }

        private async void FrmDiaryNote_Load(object sender, EventArgs e)
        {
            //rtb_Note.SelectionParagraphSpacingBefore = 150;
            //rtb_Note.SelectionParagraphSpacingAfter = 150;

            var isAdmin = await InitialHelper.CurrentUser.IsAdmin();

            if (!isAdmin) return;

            rddl_Users.Visible = true;
            lbl_Users.Visible = true;

            //rddl_Users.SelectedItem = rddl_Users.FindItemExact(InitialHelper.CurrentUser.UserName, false);
            //await ReturnDiaryNoteByDate(_selectedDate);
        }

        //private void FrmDiaryNote_Load(object sender, EventArgs e)
        //{
        //    //_cryption = new Cryption("1^Gandom&~", "1231");
        //    //CreateDynamicRadDateTime(pnl_TopData);

        //    //_backgroundWorker.ProgressChanged += _backgroundWorker_ProgressChanged;
        //    //_backgroundWorker.WorkerReportsProgress = true;
        //    //_backgroundWorker.WorkerSupportsCancellation = true;

        //    //_pictureBox = new PictureBox()
        //    //{
        //    //    Parent = this,
        //    //    SizeMode = PictureBoxSizeMode.AutoSize,
        //    //    BorderStyle = BorderStyle.FixedSingle,
        //    //    Size = new Size(356, 19),
        //    //    Location = new Point(20, 60),//new Point(pnl_Data.Width / 25, pnl_Data.Height / 20),
        //    //    Image = Resources.Loading,
        //    //    Visible = true
        //    //};



        //    //var mentalConditionDefault = new ViewModelSimpleLoadMentalCondition
        //    //{
        //    //    Id = 0,
        //    //    Title = "هیچکدام"
        //    //};

        //    //rddl_MentalConditions.DisplayMember = "Title";
        //    //rddl_MentalConditions.ValueMember = "Id";
        //    //var mentalConditions = _mentalConditionService.SimpleLoadViewModelAsync().Result;
        //    //mentalConditions.Insert(0, mentalConditionDefault);
        //    //rddl_MentalConditions.DataSource = mentalConditions;


        //    //var weatherConditionDefault = new ViewModelSimpleLoadWeatherCondition
        //    //{
        //    //    Id = 0,
        //    //    Title = "هیچکدام"
        //    //};
        //    //rddl_WeatherConditions.DisplayMember = "Title";
        //    //rddl_WeatherConditions.ValueMember = "Id";
        //    //var weatherConditions = _weatherConditionService.SimpleLoadViewModelAsync().Result;
        //    //weatherConditions.Insert(0, weatherConditionDefault);
        //    //rddl_WeatherConditions.DataSource = weatherConditions;

        //    //_radDateTimePicker.Text = _selectedDate;

        //    //Txt_diaryNoteDate_TextChanged(sender, e);
        //}

        private async void FillDropdownList(RadDropDownList ddl)
        {
            ddl.DisplayMember = "Title";
            ddl.ValueMember = "Id";
            //var which = (ddl.Name == "rddl_MentalConditions")
            //    ? "mental" : (ddl.Name == "rddl_WeatherConditions")
            //    ? "weather" : "";

            switch (ddl.Name)
            {
                case "rddl_MentalConditions":
                    {
                        var mentalConditionDefault = new ViewModelSimpleLoadMentalCondition
                        {
                            Id = 0,
                            Title = "هیچکدام"
                        };

                        var mentalConditions = await
                            _mentalConditionService.SimpleLoadViewModelAsync();
                        mentalConditions.Insert(0, mentalConditionDefault);
                        ddl.DataSource = mentalConditions;
                        break;
                    }

                case "rddl_WeatherConditions":
                    {
                        var weatherConditionDefault = new ViewModelSimpleLoadWeatherCondition()
                        {
                            Id = 0,
                            Title = "هیچکدام"
                        };

                        var weatherConditions = await
                            _weatherConditionService.SimpleLoadViewModelAsync();
                        weatherConditions.Insert(0, weatherConditionDefault);
                        ddl.DataSource = weatherConditions;
                        break;
                    }
                case "rddl_Users":
                    {
                        ddl.DisplayMember = "UserName";
                        ddl.ValueMember = "UserId";

                        var defaultOption = new ViewModelLoadAllUser()
                        {
                            UserId = 0,
                            UserName = "انتخاب کنید ..."
                        };

                        var users = await _userService.LoadAllViewModelAsync();
                        users.Insert(0, defaultOption);
                        ddl.DataSource = users;
                        break;
                    }
            }

            _isModify = false;
        }
        //private void rtb_Note_KeyUp(object sender, KeyEventArgs e)
        //{
        //    //if (e.KeyCode == Keys.Return)
        //    //{
        //    //    richTextBox1.AppendText("_______________");
        //    //    richTextBox1.AppendText(Environment.NewLine);
        //    //}
        //}

        //private void CreateDynamicRadDateTime(Control parent)
        //{
        //    _radDateTimePicker = new RadDateTimePicker
        //    {
        //        Anchor = ((AnchorStyles)((AnchorStyles.Top |
        //                                                        AnchorStyles.Right))),
        //        Font = new Font("Tornado Tahoma", 9F, FontStyle.Regular,
        //            GraphicsUnit.Point, ((byte)(178))),
        //        Format = DateTimePickerFormat.Short,
        //        Location = new Point(747, 27),
        //        MinDate = new DateTime(622, 3, 22, 0, 0, 0, 0),
        //        Name = "radDateTimePicker1",
        //        RightToLeft = RightToLeft.Yes,
        //        Size = new Size(108, 20),
        //        TabIndex = 1,
        //        TabStop = false,
        //        Culture = new CultureInfo("fa-IR"),
        //        Text = "1398/03/26",
        //        Value = new DateTime(2019, 6, 16, 22, 27, 13, 236)
        //    };


        //    _radDateTimePicker.ValueChanged += _radDateTimePicker_ValueChanged;
        //    parent.Controls.Add(_radDateTimePicker);
        //}

        //private void _radDateTimePicker_ValueChanged(object sender, EventArgs e)
        //{
        //    //try
        //    //{
        //    //    _selectedDate = _radDateTimePicker.Text;
        //    //    txt_diaryNoteDate.Text = _selectedDate;

        //    //    if (!_backgroundWorker.IsBusy)
        //    //    {
        //    //        LoadingForm = new FrmLoading();
        //    //        LoadingForm.ShowDialog();

        //    //        _backgroundWorker.RunWorkerAsync();
        //    //    }

        //    //    //CommonHelper.IndicatorLoading(this, _pictureBox, true);

        //    //    //InitializeToday(txt_diaryNoteDate.Text);
        //    //    //rtb_Note.Rtf = ReturnDiaryNotesByDate(txt_diaryNoteDate.Text);
        //    //}
        //    //catch
        //    //{
        //    //    return;
        //    //}
        //}

        private void rtb_Note_Click(object sender, EventArgs e)
        {
            GetLineAndColumn(rtb_Note);
        }
        private void rtb_Note_KeyPress(object sender, KeyPressEventArgs e)
        {
            GetLineAndColumn(rtb_Note);
            if ((int)e.KeyChar == 9)
                e.Handled = true; // Stops Ctrl+I from inserting a tab (char HT) into the RichTextBox
        }

        //private void _backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        //{
        //    if (!_backgroundWorker.CancellationPending)
        //    {
        //        //MessageBox.Show("Percentage: " + e.ProgressPercentage);
        //        progressBar1.Value = e.ProgressPercentage;
        //    }

        //}
        //public delegate void InvokeDelegate();
        //public void InvokeMethod()
        //{
        //    _pictureBox.Visible = true;
        //    _pictureBox.BringToFront();
        //    _pictureBox.Update();
        //}

        private async void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                //var worker = (BackgroundWorker)sender;

                //int total = 3; //some number (this is your variable to change)!!

                //for (int i = 0; i <= total; i++) //some number (total)
                //{
                //    //System.Threading.Thread.Sleep(100);
                //    int percents = (i * 100) / total;
                //    _backgroundWorker.ReportProgress(percents, i);
                //    //2 arguments:
                //    //1. procenteges (from 0 t0 100) - i do a calcumation 
                //    //2. some current value!
                //}
                //_backgroundWorker.ReportProgress();
                //var currentDate = PersianHelper.GetPersiaDateSimple(DateTime.Now);
                //_note = ReturnDiaryNotesByDate(_selectedDate);

                if (_backgroundWorker.CancellationPending)//checks for cancel request
                {
                    e.Cancel = true;
                }

                //var keepRunning = true;
                //var n = 0;
                //while (keepRunning)
                //{
                //    n++;
                //    worker.ReportProgress(n);

                //    keepRunning = false;
                //}
                //for (var i = 0; i < 100; ++i)
                //{
                //    worker.ReportProgress(i);

                //    //System.Threading.Thread.Sleep(100);
                //}

                //_pictureBox.Invoke(new Action(() => _pictureBox.Image = Resources.Loading));

                //_pictureBox.BeginInvoke(new InvokeDelegate(InvokeMethod));

                //CommonHelper.IndicatorLoading(this, _pictureBox, true);

                e.Result = await ReturnDiaryNoteByDate(_selectedDate) as DiaryNote;

                //SetText(_note);
                _success = true;
            }
            catch (Exception exception)
            {
                e.Cancel = true;

                _success = false;

                await LoggerService.ErrorAsync(this.Name, "BackgroundWorker_DoWork", exception.Message,
                    exception.ToDetailedString());
            }
        }

        //public void SetLoading(PictureBox pictureBox)
        //{
        //    if (rtb_Note.InvokeRequired)
        //    {
        //        Invoke((MethodInvoker)delegate () { SetLoading(pictureBox); });
        //        return;
        //    }

        //    pictureBox.Visible = false;
        //}

        //public void SetTextBox(string text)
        //{
        //    if (rtb_Note.InvokeRequired)
        //    {
        //        Invoke((MethodInvoker)delegate () { SetTextBox(text); });
        //        return;
        //    }
        //    rtb_Note.Rtf = text;
        //}

        //private void WriteTextSafe(string text)
        //{
        //    if (rtb_Note.InvokeRequired)
        //    {
        //        var d = new SafeCallDelegate(WriteTextSafe);
        //        Invoke(d, new object[] { text });
        //    }
        //    else
        //    {
        //        rtb_Note.Rtf = text;
        //    }
        //}

        //private void SetText(string text)
        //{
        //    WriteTextSafe(text);
        //}

        private async void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (_success)
            {
                //if (e.Cancelled)
                //{
                //    progressBar1.Invoke((Action)(() =>
                //    {
                //        progressBar1.MarqueeAnimationSpeed = 0;
                //        progressBar1.Style = ProgressBarStyle.Continuous;
                //    }));
                //    MessageBox.Show("عملیات لغو گردید...");
                //}
                //else
                //{

                try
                {
                    InitializeToday(_selectedDate);
                    //rtb_Note.Rtf = _note;
                    var diaryNote = (e.Result as DiaryNote);
                    rtb_Note.Rtf = diaryNote?.Note;

                    rddl_MentalConditions.SelectedValue = diaryNote?.MentalConditionId ?? 0;
                    rddl_WeatherConditions.SelectedValue = diaryNote?.WeatherConditionId ?? 0;
                    //if (LoadingForm != null && LoadingForm.Visible)
                    //    LoadingForm.Dispose();
                    //}
                    _isModify = false;
                }
                catch (Exception exception)
                {
                    _isModify = false;
                    await LoggerService.ErrorAsync(this.Name, "BackgroundWorker_RunWorkerCompleted", exception.Message,
                        exception.ToDetailedString());
                }
            }

            //Invoke(new MethodInvoker(() =>
            //{
            //CommonHelper.IndicatorLoading(this, _pictureBox);
            //}));

            //progressBar1.Value = 0;

            //lbl_Loading.Visible = false;
            CommonHelper.IndicatorLoading(_pictureBox);
            rtb_Note.ReadOnly = false;
            rtb_Note.BackColor = SystemColors.Window;


            _backgroundWorker.Dispose();
        }

        private async void Btn_IncDate_Click(object sender, EventArgs e)
        {
            try
            {
                if (rtb_Note.TextLength > 0)
                {
                    //var dialog = new CustomDialogs(350, 200);
                    //dialog.Invoke("هشدار", "یادداشت نوشته شده را ذخیره نمی کنید؟",
                    //    CustomDialogs.ImageType.itQuestion2,
                    //    CustomDialogs.ButtonType.YesNo, InitialHelper.BackColorCustom);
                    //if (dialog.Yes)
                    //{
                    DiaryNotesSaveOrUpdate();
                    //}
                }

                txt_diaryNoteDate.Text =
                    CommonHelper.IncDayOfDate(txt_diaryNoteDate.Text, 1, FormatDate.Fd4Year);

                InitializeToday(txt_diaryNoteDate.Text);
            }
            catch (Exception exception)
            {
                var dlg = new CustomDialogs(320, 200);
                dlg.Invoke("تاریخ درست وارد نشده است", exception.Message,
                    CustomDialogs.ImageType.itError5,
                    CustomDialogs.ButtonType.Ok, InitialHelper.BackColorCustom);

                await LoggerService.ErrorAsync(this.Name, "Btn_IncDate_Click", exception.Message,
                    exception.ToDetailedString());
            }

            //rtb_Note.Rtf = ReturnDiaryNotesByDate(txt_diaryNoteDate.Text).Result;
            Txt_diaryNoteDate_TextChanged(sender, e);
        }

        private async void Btn_DecDate_Click(object sender, EventArgs e)
        {
            try
            {
                if (rtb_Note.TextLength > 0)
                {
                    DiaryNotesSaveOrUpdate();
                }
                txt_diaryNoteDate.Text = CommonHelper.DecDayOfDate(txt_diaryNoteDate.Text, 1, FormatDate.Fd4Year);
                InitializeToday(txt_diaryNoteDate.Text);
            }
            catch (Exception exception)
            {
                var dlg = new CustomDialogs(320, 200);
                dlg.Invoke("تاریخ درست وارد نشده است", exception.Message,
                    CustomDialogs.ImageType.itError5,
                    CustomDialogs.ButtonType.Ok, InitialHelper.BackColorCustom);


                await LoggerService.ErrorAsync(this.Name, "Btn_DecDate_Click", exception.Message,
                    exception.ToDetailedString());
            }

            //rtb_Note.Rtf = ReturnDiaryNotesByDate(txt_diaryNoteDate.Text).Result;
            Txt_diaryNoteDate_TextChanged(sender, e);
        }

        //private void CallDataForDiaryNote()
        //{
        //    progressBar1.Visible = true;
        //    progressBar1.Style = ProgressBarStyle.Marquee;
        //    var thread = new System.Threading.Thread(LoadData);
        //    thread.Start();
        //}

        //private void LoadData()
        //{
        //    // Load your Table...
        //    _selectedDate = txt_diaryNoteDate.Text;
        //    _note = ReturnDiaryNotesByDate(_selectedDate);
        //    SetDataSource(_note);
        //}

        //internal delegate void SetDelegate(string text);
        //private void SetDataSource(string text)
        //{
        //    // Invoke method if required:
        //    if (InvokeRequired)
        //    {
        //        Invoke(new SetDelegate(SetDataSource), text);
        //    }
        //    else
        //    {
        //        rtb_Note.Rtf = text;
        //        progressBar1.Visible = false;
        //    }
        //}

        private async void Txt_diaryNoteDate_TextChanged(object sender, EventArgs e)
        {
            //CallDataForDiaryNote();
            try
            {
                _selectedDate = txt_diaryNoteDate.Text;
                // _radDateTimePicker.Text = _selectedDate;

                if (!_selectedDate.IsValidPersianDate()) return;
                if (_backgroundWorker.IsBusy) return;

                rtb_Note.Clear();
                //lbl_Loading.Visible = true;
                CommonHelper.IndicatorLoading(_pictureBox, true);
                rtb_Note.ReadOnly = true;
                rtb_Note.BackColor = SystemColors.Menu;

                _isModify = false;
                _backgroundWorker.RunWorkerAsync();

                //Task.Factory.StartNew(() =>
                //{
                //CommonHelper.IndicatorLoading(this, _pictureBox, true);
                //});


                //LoadingForm = new FrmLoading();
                //LoadingForm.ShowDialog();

                //InitializeToday(txt_diaryNoteDate.Text);
                //rtb_Note.Rtf = ReturnDiaryNotesByDate(txt_diaryNoteDate.Text);
            }
            catch (Exception exception)
            {
                _isModify = false;
                await LoggerService.ErrorAsync(this.Name, "Txt_diaryNoteDate_TextChanged", exception.Message,
                    exception.ToDetailedString());
            }
        }

        private void rtb_Note_VScroll(object sender, EventArgs e)
        {
            //move location of numberLabel for amount of pixels caused by scrollbar
            var d = rtb_Note.GetPositionFromCharIndex(0).Y % (rtb_Note.Font.Height + 1);
            numberLabel.Location = new Point(0, d);

            UpdateNumberLabel();
            numberLabel.Invalidate();
        }

        private void rtb_Note_Resize(object sender, EventArgs e)
        {
            rtb_Note_VScroll(null, null);
            GetLineAndColumn(rtb_Note);
        }

        private void rtb_Note_FontChanged(object sender, EventArgs e)
        {
            rtb_Note_VScroll(null, null);
            //UpdateNumberLabel();
            GetLineAndColumn(rtb_Note);
        }

        //private void Lbl_Loading_Click(object sender, EventArgs e)
        //{
        //    if (_backgroundWorker.WorkerSupportsCancellation)
        //        _backgroundWorker.CancelAsync();
        //}

        private void Ts_DiaryNote_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                if (rtb_Note.SelectionFont == null) return;

                //var currentFont = rtb_Note.SelectionFont;
                //var newFontStyle = rtb_Note.SelectionFont.Style;

                switch (e.ClickedItem.Name)
                {
                    case "tsb_Bold":
                        StyleAction(FontStyle.Bold);
                        //newFontStyle = rtb_Note.SelectionFont.Style ^ FontStyle.Bold;
                        break;
                    case "tsb_Italic":
                        StyleAction(FontStyle.Italic);
                        //newFontStyle = rtb_Note.SelectionFont.Style ^ FontStyle.Italic;
                        break;
                    case "tsb_Underline":
                        StyleAction(FontStyle.Underline);
                        //newFontStyle = rtb_Note.SelectionFont.Style ^ FontStyle.Underline;
                        break;
                    case "tsb_Strikeout":
                        //newFontStyle = rtb_Note.SelectionFont.Style ^ FontStyle.Strikeout;
                        StyleAction(FontStyle.Strikeout);
                        break;
                    case "tsb_AlignLeft":
                        AlignLeftAction();
                        break;
                    case "tsb_AlignCenter":
                        AlignCenterAction();
                        break;
                    case "tsb_AlignRight":
                        AlignRightAction();
                        break;
                    //case "tsb_FontColor":
                    //    ShowFontColorDialog();
                    //    break;
                    //case "tsb_BackColor":
                    //    ShowFontBackColorDialog();
                    //    break;
                    //case "tsb_FillColor":
                    //    ShowBackgroundColorDialog();
                    //    break;
                    case "tsb_Bullet":
                        BulletAction();
                        break;
                    case "tsb_IndentIncrease":
                        TextIndentIncreaseAction();
                        break;
                    case "tsb_IndentDecrease":
                        TextIndentDecreaseAction();
                        break;
                    //case "tsb_ZoomIn":
                    //    ZoomInAction();
                    //    break;
                    //case "tsb_ZoomOut":
                    //    ZoomOutAction();
                    //    break;
                    case "tsc_FontSize":
                        ChangeFontSizeAction();
                        break;
                    case "tsc_FontName":
                        ChangeFontNameAction();
                        break;
                    case "tsb_FontDialog":
                        ShowFontDialog();
                        break;
                    //case "tsb_WordWrap":
                    //    WordWrapAction();
                    //    break;
                    case "tsb_Undo":
                        UndoAction();
                        break;
                    case "tsb_Redo":
                        RedoAction();
                        break;
                    case "tsb_Cut":
                        CutAction();
                        break;
                    case "tsb_Copy":
                        CopyAction();
                        break;
                    case "tsb_Paste":
                        PasteAction();
                        break;
                    case "tsb_SelectAll":
                        SelectAllAction();
                        break;
                    //case "tsb_Find":
                    //    ShowFindDialog();
                    //    break;
                    //case "tsb_Replace":
                    //    ShowReplaceDialog();
                    //    break;
                    case "tsb_Save":
                        DiaryNotesSaveOrUpdate();
                        break;
                    //case "tsb_InsertPicture":
                    //    InsertPictureAction();
                    //    break;
                    //case "tsb_Stamp":
                    //    StampAction = StampActions.DateTime;
                    //    OnStamp(new EventArgs()); //send stamp event
                    //    break;
                    case "tsb_Print":
                        rtb_Note.Print();
                        break;
                    case "tsb_PrintPreview":
                        ppd_DiaryNote.Document = pd_DiaryNote;
                        ppd_DiaryNote.ShowDialog(this);
                        break;
                    case "tsb_FullScreen":
                        this.FullScreenEx(tsb_FullScreen.Checked == false);
                        break;

                        //case "tsb_Exit":
                        //    DiaryNotesSaveOrUpdate();
                        //    rtb_Note.Dispose();
                        //    Close();
                        //    //SaveOrUpdateBeforeExit();
                        //    break;
                }

                //rtb_Note.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }
        private void rtb_Note_TextChanged(object sender, EventArgs e)
        {
            UpdateNumberLabel();
            GetLineAndColumn(rtb_Note);

            tsb_Undo.Enabled = rtb_Note.CanUndo;
            tsb_Redo.Enabled = rtb_Note.CanRedo;
            tsb_SelectAll.Enabled = rtb_Note.CanSelect;

            tsm_Undo.Enabled = rtb_Note.CanUndo;
            tsm_Redo.Enabled = rtb_Note.CanRedo;
            tsm_SelectAll.Enabled = rtb_Note.CanSelect;

            //tsmi_Bold.Checked = tsb_Bold.Checked = rtb_Note.SelectionFont.Bold;
            //tsmi_Italic.Checked = tsb_Italic.Checked = rtb_Note.SelectionFont.Italic;
            //tsmi_Underline.Checked = tsb_Underline.Checked = rtb_Note.SelectionFont.Underline;
            //tsmi_Strikeout.Checked = tsb_Strikeout.Checked = rtb_Note.SelectionFont.Strikeout;        
        }

        //public Font GetFontDetails()
        //{
        //    //This method should handle cases that occur when multiple fonts/styles are selected
        //    var rtbTemp = new RichTextBox();
        //    var rtb_Notestart = rtb_Note.SelectionStart;
        //    var len = rtb_Note.SelectionLength;
        //    var rtbTempStart = 0;

        //    if (len <= 1)
        //    {
        //        // Return the selection or default font
        //        if (rtb_Note.SelectionFont != null)
        //            return rtb_Note.SelectionFont;
        //        else
        //            return rtb_Note.Font;
        //    }

        //    // Step through the selected text one char at a time	
        //    // after setting defaults from first char
        //    rtbTemp.Rtf = rtb_Note.SelectedRtf;

        //    //Turn everything on so we can turn it off one by one
        //    var replystyle =
        //        FontStyle.Bold | FontStyle.Italic | FontStyle.Strikeout | FontStyle.Underline;

        //    // Set reply font, size and style to that of first char in selection.
        //    rtbTemp.Select(rtbTempStart, 1);
        //    var replyfont = rtbTemp.SelectionFont.Name;
        //    var replyfontsize = rtbTemp.SelectionFont.Size;
        //    replystyle = replystyle & rtbTemp.SelectionFont.Style;

        //    // Search the rest of the selection
        //    for (var i = 1; i < len; ++i)
        //    {
        //        rtbTemp.Select(rtbTempStart + i, 1);

        //        // Check reply for different style
        //        replystyle = replystyle & rtbTemp.SelectionFont.Style;

        //        // Check font
        //        if (replyfont != rtbTemp.SelectionFont.FontFamily.Name)
        //            replyfont = "";

        //        // Check font size
        //        if (replyfontsize != rtbTemp.SelectionFont.Size)
        //            replyfontsize = (float)0.0;
        //    }

        //    // Now set font and size if more than one font or font size was selected
        //    if (replyfont == "")
        //        replyfont = rtbTemp.Font.FontFamily.Name;

        //    if (replyfontsize == 0.0)
        //        replyfontsize = rtbTemp.Font.Size;

        //    // generate reply font
        //    var reply
        //        = new Font(replyfont, replyfontsize, replystyle);

        //    return reply;
        //}
        private void Rtb_Note_SelectionChanged(object sender, EventArgs e)
        {
            //var font = GetFontDetails();
            //if (font == null) return;
            if (rtb_Note.SelectionFont != null)
            {
                //CharOffset
                if (rtb_Note.SelectionCharOffset > 0)
                {
                    tsb_Superscript.Checked = true;
                }
                else if (rtb_Note.SelectionCharOffset < 0)
                {
                    tsb_Subscript.Checked = true;
                }
                else
                {
                    tsb_Subscript.Checked = false;
                    tsb_Superscript.Checked = false;
                }

                //Bullet
                if (rtb_Note.SelectionBullet)
                {
                    tsb_Bullet.Checked = true;
                    tsmi_Bullets.Checked = true;
                }
                else
                {
                    tsb_Bullet.Checked = false;
                    tsmi_Bullets.Checked = false;
                }

                //tsb_Bullet.Checked = rtb_Note.SelectionBullet;
                //tsmi_Bullets.Checked = rtb_Note.SelectionBullet;

                tsb_Bold.Checked = tsmi_Bold.Checked = rtb_Note.SelectionFont.Bold;
                tsb_Italic.Checked = tsmi_Italic.Checked = rtb_Note.SelectionFont.Italic;
                tsb_Underline.Checked = tsmi_Underline.Checked = rtb_Note.SelectionFont.Underline;
                tsb_Strikeout.Checked = tsmi_Strikeout.Checked = rtb_Note.SelectionFont.Strikeout;

                //tsmi_Bold.Checked = font.Bold;
                //tsmi_Italic.Checked = font.Italic;
                //tsmi_Underline.Checked = font.Underline;
                //tsmi_Strikeout.Checked = font.Strikeout;

                tsb_AlignLeft.Checked = tsmi_AlignLeft.Checked = rtb_Note.SelectionAlignment == HorizontalAlignment.Left;
                tsb_AlignCenter.Checked = tsmi_AlignCenter.Checked = rtb_Note.SelectionAlignment == HorizontalAlignment.Center;
                tsb_AlignRight.Checked = tsmi_AlignRight.Checked = rtb_Note.SelectionAlignment == HorizontalAlignment.Right;

                //switch (rtb_Note.SelectionAlignment)
                //{
                //    case HorizontalAlignment.Left:
                //        tsb_AlignLeft.Checked = true;
                //        tsb_AlignCenter.Checked = false;
                //        tsb_AlignRight.Checked = false;

                //        tsmi_AlignLeft.Checked = true;
                //        tsmi_AlignCenter.Checked = false;
                //        tsmi_AlignRight.Checked = false;
                //        break;

                //    case HorizontalAlignment.Center:
                //        tsb_AlignLeft.Checked = false;
                //        tsb_AlignCenter.Checked = true;
                //        tsb_AlignRight.Checked = false;

                //        tsmi_AlignLeft.Checked = false;
                //        tsmi_AlignCenter.Checked = true;
                //        tsmi_AlignRight.Checked = false;
                //        break;

                //    case HorizontalAlignment.Right:
                //        tsb_AlignLeft.Checked = false;
                //        tsb_AlignCenter.Checked = false;
                //        tsb_AlignRight.Checked = true;

                //        tsmi_AlignLeft.Checked = false;
                //        tsmi_AlignCenter.Checked = false;
                //        tsmi_AlignRight.Checked = true;
                //        break;
                //    default:
                //        throw new ArgumentOutOfRangeException();
                //}

                //Font name
                if (rtb_Note.SelectionFont.Name != tsc_FontName.SelectedText)
                {
                    tsc_FontName.SelectedIndex = tsc_FontName.FindStringExact(rtb_Note.SelectionFont.Name);
                }

                //tsc_FontName.SelectedItem = rtb_Note.SelectionFont.FontFamily.Name;
                tsc_FontSize.SelectedItem = rtb_Note.SelectionFont.Size.ToString(CultureInfo.InvariantCulture);
            }
            else
            {
                tsc_FontName.SelectedIndex = -1;
            }

            var pt = rtb_Note.GetPositionFromCharIndex(rtb_Note.SelectionStart);
            if (pt.X == 1)
            {
                UpdateNumberLabel();
            }
            GetLineAndColumn(rtb_Note);
        }
        private void Tsc_FontSize_TextChanged(object sender, EventArgs e)
        {
            ChangeFontSizeAction();
        }
        private void Tsc_FontName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFontNameAction();
        }
        private void Tst_ZoomFactor_Leave(object sender, EventArgs e)
        {
            try
            {
                rtb_Note.ZoomFactor = Convert.ToSingle(tst_ZoomFactor.Text) / 100;
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter valid number", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                tst_ZoomFactor.Focus();
                tst_ZoomFactor.SelectAll();
            }
            catch (OverflowException)
            {
                MessageBox.Show("Enter valid number", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                tst_ZoomFactor.Focus();
                tst_ZoomFactor.SelectAll();
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Zoom factor should be between 20% and 6400%", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                tst_ZoomFactor.Focus();
                tst_ZoomFactor.SelectAll();
            }
        }
        private void Cms_DiaryNote_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //var currentFont = rtb_Note.SelectionFont;
            //FontStyle newFontStyle;
            //MessageBox.Show(e.ClickedItem.Name);

            switch (e.ClickedItem.Name)
            {
                case "tsm_Cut":
                    CutAction();
                    break;
                case "tsm_Copy":
                    CopyAction();
                    break;
                case "tsm_Paste":
                    PasteAction();
                    break;
                case "tsm_Delete":
                    DeleteAction();
                    break;
                case "tsm_SelectAll":
                    SelectAllAction();
                    break;
                case "tsm_Undo":
                    UndoAction();
                    break;
                case "tsm_Redo":
                    RedoAction();
                    break;
                //case "tsmi_AlignLeft":
                //    MessageBox.Show(e.ClickedItem.Name);
                //    tsmi_AlignLeft.PerformClick();
                //    tsmi_AlignLeft.Checked = true;
                //    tsmi_AlignCenter.Checked = false;
                //    tsmi_AlignRight.Checked = false;
                //    //AlignLeftAction();
                //    break;
                //case "tsmi_AlignCenter":
                //    tsmi_AlignCenter.PerformClick();
                //    tsmi_AlignLeft.Checked = false;
                //    tsmi_AlignCenter.Checked = true;
                //    tsmi_AlignRight.Checked = false;
                //    //AlignCenterAction();
                //    break;
                //case "tsmi_AlignRight":
                //    tsmi_AlignRight.PerformClick();
                //    tsmi_AlignLeft.Checked = false;
                //    tsmi_AlignCenter.Checked = false;
                //    tsmi_AlignRight.Checked = true;
                //    //AlignRightAction();
                //    break;
                //case "tsmi_Bold":
                //    newFontStyle = rtb_Note.SelectionFont.Style ^ FontStyle.Bold;
                //    rtb_Note.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
                //    break;
                //case "tsmi_Italic":
                //    newFontStyle = rtb_Note.SelectionFont.Style ^ FontStyle.Italic;
                //    rtb_Note.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
                //    break;
                //case "tsmi_Underline":
                //    newFontStyle = rtb_Note.SelectionFont.Style ^ FontStyle.Underline;
                //    rtb_Note.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
                //    break;
                //case "tsmi_Strikeout":
                //    newFontStyle = rtb_Note.SelectionFont.Style ^ FontStyle.Strikeout;
                //    rtb_Note.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
                //    break;
                //case "tsmi_Increase":
                //    TextIndentAction();
                //    break;
                //case "tsmi_Decrease":
                //    TextOutdentAction();
                //    break;
                //case "tsmi_Bullets":
                //    BulletAction();
                //    break;
                case "tsm_InsertPicture":
                    InsertPictureAction();
                    break;
                case "tsm_ZoomIn":
                    ZoomInAction();
                    break;
                case "tsm_ZoomOut":
                    ZoomOutAction();
                    break;
            }
            Rtb_Note_SelectionChanged(sender, e);
        }
        private void Tsmi_AlignLeft_Click(object sender, EventArgs e)
        {
            AlignLeftAction();
        }
        private void Tsmi_AlignCenter_Click(object sender, EventArgs e)
        {
            AlignCenterAction();
        }
        private void Tsmi_AlignRight_Click(object sender, EventArgs e)
        {
            AlignRightAction();
        }
        private void Tsmi_Bold_Click(object sender, EventArgs e)
        {
            StyleAction(FontStyle.Bold);
            tsb_Bold.Checked = tsmi_Bold.Checked;
        }
        private void Tsmi_Italic_Click(object sender, EventArgs e)
        {
            StyleAction(FontStyle.Italic);
            tsb_Italic.Checked = tsmi_Italic.Checked;
        }
        private void Tsmi_Underline_Click(object sender, EventArgs e)
        {
            StyleAction(FontStyle.Underline);
            tsb_Underline.Checked = tsmi_Underline.Checked;
        }
        private void Tsmi_Strikeout_Click(object sender, EventArgs e)
        {
            StyleAction(FontStyle.Strikeout);
            tsb_Strikeout.Checked = tsmi_Strikeout.Checked;
        }
        private void tsmi_Bullets_Click(object sender, EventArgs e)
        {
            BulletAction();
            Rtb_Note_SelectionChanged(sender, e);
        }

        #region Private Functions

        private void ShowFontDialog()
        {
            using (var dlg = new FontDialog())
            {
                if (rtb_Note.SelectionFont != null) dlg.Font = rtb_Note.SelectionFont;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    rtb_Note.SelectionFont = dlg.Font;
                }
            }
        }
        private void ShowFontColorDialog()
        {
            try
            {
                using (var dlg = new ColorDialog())
                {
                    dlg.Color = rtb_Note.SelectionColor;
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        rtb_Note.SelectionColor = dlg.Color;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }
        private void ShowFontBackColorDialog()
        {
            try
            {
                using (var dlg = new ColorDialog())
                {
                    dlg.Color = rtb_Note.SelectionBackColor;
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        rtb_Note.SelectionBackColor = dlg.Color;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }
        private void ShowBackgroundColorDialog()
        {
            try
            {
                using (var dlg = new ColorDialog())
                {
                    dlg.Color = rtb_Note.BackColor;
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        rtb_Note.BackColor = dlg.Color;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }
        private void ShowFindDialog()
        {
            var findForm = new FrmFind
            {
                RtbInstance = rtb_Note,
                InitialText = rtb_Note.SelectedText
            };
            findForm.Show();
        }
        private void ShowReplaceDialog()
        {
            var replaceForm = new FrmReplace
            {
                RtbInstance = rtb_Note,
                InitialText = rtb_Note.SelectedText
            };
            replaceForm.Show();
        }
        private void StyleAction(FontStyle style)
        {
            var currentFont = rtb_Note.SelectionFont;
            var newFontStyle = rtb_Note.SelectionFont.Style ^ style;
            rtb_Note.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);

            //Rtb_Note_SelectionChanged(sender, e);
        }
        private void AlignLeftAction()
        {
            rtb_Note.SelectionAlignment = HorizontalAlignment.Left;
            tsb_AlignLeft.Checked = tsmi_AlignLeft.Checked = true;
            tsb_AlignCenter.Checked = tsmi_AlignCenter.Checked = false;
            tsb_AlignRight.Checked = tsmi_AlignRight.Checked = false;
        }
        private void AlignRightAction()
        {
            rtb_Note.SelectionAlignment = HorizontalAlignment.Right;
            tsb_AlignLeft.Checked = tsmi_AlignLeft.Checked = false;
            tsb_AlignCenter.Checked = tsmi_AlignCenter.Checked = false;
            tsb_AlignRight.Checked = tsmi_AlignRight.Checked = true;
        }
        private void AlignCenterAction()
        {
            rtb_Note.SelectionAlignment = HorizontalAlignment.Center;
            tsb_AlignLeft.Checked = tsmi_AlignLeft.Checked = false;
            tsb_AlignCenter.Checked = tsmi_AlignCenter.Checked = true;
            tsb_AlignRight.Checked = tsmi_AlignRight.Checked = false;
        }
        private void BulletAction()
        {
            if (!tsb_Bullet.Checked)
            {
                rtb_Note.BulletIndent = 20;
                rtb_Note.SelectionBullet = true;
            }
            else
            {
                rtb_Note.SelectionBullet = false;
            }
            rtb_Note.Focus();
        }
        private void TextIndentDecreaseAction()
        {
            rtb_Note.SelectionIndent -= Indent;
        }
        private void TextIndentIncreaseAction()
        {
            rtb_Note.SelectionIndent += Indent;
        }
        private void WordWrapAction()
        {
            rtb_Note.WordWrap = !tsb_WordWrap.Checked;
        }
        private void ZoomOutAction()
        {
            if (!(rtb_Note.ZoomFactor > 0.16f + 0.20f)) return;

            rtb_Note.ZoomFactor -= 0.20f;
            tst_ZoomFactor.Text = $@"{rtb_Note.ZoomFactor * 100:F0}";
        }
        private void ZoomInAction()
        {
            if (!(rtb_Note.ZoomFactor < 64.0f - 0.20f)) return;

            rtb_Note.ZoomFactor += 0.20f;
            tst_ZoomFactor.Text = $@"{rtb_Note.ZoomFactor * 100:F0}";
        }
        private void UndoAction()
        {
            //if (rtb_Note.CanUndo)
            {
                rtb_Note.Undo();
            }
        }
        private void RedoAction()
        {
            //if (rtb_Note.CanRedo)
            {
                rtb_Note.Redo();
            }
        }
        private void CutAction()
        {
            if (rtb_Note.SelectedText == "" || rtb_Note.SelectedText == null) return;

            if (Clipboard.ContainsText())
            {
                Clipboard.Clear();

            }

            Clipboard.SetText(rtb_Note.SelectedText);
            rtb_Note.Text = rtb_Note.Text.Remove(rtb_Note.SelectionStart, rtb_Note.SelectionLength);
            rtb_Note.Focus();

        }
        private void CopyAction()
        {
            if (rtb_Note.SelectedText == "" || rtb_Note.SelectedText == null) return;

            if (Clipboard.ContainsText())
            {
                Clipboard.Clear();
            }

            Clipboard.SetText(rtb_Note.SelectedText);
            rtb_Note.Focus();

        }
        private void PasteAction()
        {
            if (Clipboard.ContainsText())
            {
                rtb_Note.Paste();
                rtb_Note.Focus();
            }
        }
        private void DeleteAction()
        {
            rtb_Note.Clear();
        }
        private void SelectAllAction()
        {
            rtb_Note.SelectAll();
        }
        private void ChangeFontSizeAction()
        {
            try
            {
                if (rtb_Note.SelectionFont == null) return;

                var currentFont = rtb_Note.SelectionFont;
                var newSize = Convert.ToSingle(tsc_FontSize.Text);
                rtb_Note.SelectionFont = new Font(currentFont.FontFamily, newSize, currentFont.Style);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }
        private void ChangeFont(string fontName)
        {
            try
            {
                if (rtb_Note.SelectionLength > 0)
                {
                    rtb_Note.SelectionChanged -=
                                    Rtb_Note_SelectionChanged;

                    var start = rtb_Note.SelectionStart;
                    var len = rtb_Note.SelectionLength;

                    //for (int i = 0; i < len; i++)
                    //{
                    //    rtb_Note.Select(start + i, 1);
                    //}

                    //change font
                    var fSize = rtb_Note.SelectionFont.Size;
                    rtb_Note.SelectionFont =
                        new Font(fontName, fSize);

                    rtb_Note.Select(start, len);

                    rtb_Note.SelectionChanged +=
                        new EventHandler(Rtb_Note_SelectionChanged);
                }
                else
                {
                    var fSize = rtb_Note.SelectionFont.Size;

                    //change font
                    rtb_Note.SelectionFont =
                        new Font(fontName, fSize);
                }
            }
            catch (ArgumentException e)
            {
                MessageBox.Show(e.Message, "ArgumentException",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ChangeFontNameAction()
        {
            try
            {
                //if (rtb_Note.SelectionFont == null) return;

                //var currentFont = rtb_Note.SelectionFont;
                //var newFamily = new FontFamily(tsc_FontName.SelectedItem.ToString());
                //rtb_Note.SelectionFont = new Font(newFamily, currentFont.Size, currentFont.Style);


                if (tsc_FontName.SelectedIndex >= 0)
                {
                    ChangeFont(tsc_FontName.SelectedItem.ToString());
                }

                rtb_Note.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }
        private async void InsertPictureAction()
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.Title = "افزودن عکس";
                dlg.DefaultExt = "jpg";
                dlg.Filter = "Bitmap Files|*.bmp|JPEG Files|*.jpg|GIF Files|*.gif|PNG Files|*.png|All files|*.*";
                dlg.FilterIndex = 1;
                if (dlg.ShowDialog() != DialogResult.OK) return;
                try
                {
                    var strImagePath = dlg.FileName;
                    var img = Image.FromFile(strImagePath);
                    Clipboard.SetDataObject(img);
                    var df = DataFormats.GetFormat(DataFormats.Bitmap);
                    if (rtb_Note.CanPaste(df))
                    {
                        rtb_Note.Paste(df);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Unable to insert image.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    await LoggerService.ErrorAsync(this.Name, "InsertPictureAction", exception.Message,
                        exception.ToDetailedString());
                }
            }
        }
        private async void DiaryNotesSaveOrUpdate()
        {
            var selectedUser = await GetSelectedUserId();
            if (selectedUser <= 0) return;

            try
            {
                var currentDate = PersianHelper.GetGregorianDateSimple(txt_diaryNoteDate.Text);

                int? mcId = int.Parse(rddl_MentalConditions.SelectedItem["Id"].ToString());
                int? wcId = int.Parse(rddl_WeatherConditions.SelectedItem["Id"].ToString());
                var currentUser = InitialHelper.CurrentUser;
                var currentDateTime = InitialHelper.CurrentDateTime;

                //if (await currentUser.IsAdmin() ?
                //    await _diaryNoteService.ExistAsync(currentDate, await GetSelectedUserId()):
                //    await _diaryNoteService.ExistAsync(currentDate, currentUser.Id))
                if (await _diaryNoteService.ExistAsync(currentDate, selectedUser))
                {
                    //var encryptNote = _cryption.Encrypt(rtb_Note.Rtf);
                    //var encryptNote = CryptoHelper.Encrypt(rtb_Note.Rtf, true, "1^Gandom&~");
                    //var encryptNote = CryptoHelper.EncryptDecrypt(rtb_Note.Rtf, 1231);
                    //var encryptNote = CryptoHelper.EncryptData(rtb_Note.Rtf, "1231");

                    var diaryNote = await _diaryNoteService.LoadByDateAsync(currentDate, selectedUser);
                    //await currentUser.IsAdmin() ?
                    //await _diaryNoteService.LoadByDateAsync(currentDate) :
                    //await _diaryNoteService.LoadByDateAsync(currentDate, currentUser.Id);

                    var encryptNote = CryptoHelper.EncryptNew(rtb_Note.Rtf);
                    diaryNote.Note = Utility.CompressString(encryptNote, Encoding.UTF8);
                    diaryNote.WeatherConditionId = wcId == 0 ? null : wcId;
                    diaryNote.MentalConditionId = mcId == 0 ? null : mcId;
                    diaryNote.UserId = selectedUser;
                    diaryNote.UpdateBy = currentUser.Id;
                    diaryNote.LastUpdate = currentDateTime;

                    await _diaryNoteService.UpdateAsync(diaryNote);

                    if (!_isModify) return;

                    _isModify = false;
                    rtb_Note.Focus();
                    rtb_Note.Select(rtb_Note.Text.Length - 1, 0);
                    rtb_Note.ScrollToCaret();
                    CommonHelper.ShowNotificationMessage("یادداشت روزانه", "اطلاعات یادداشت روزانه بروز رسانی شد");

                    //dlg.Invoke("پیام", "تغییرات بروزرسانی شد.", CustomDialogs.ImageType.itEdit,
                    //    CustomDialogs.ButtonType.Ok, InitialHelper.BackColorCustom);
                }
                else
                {
                    //var encryptNote = _cryption.Encrypt(rtb_Note.Rtf);
                    //var encryptNote = CryptoHelper.Encrypt(rtb_Note.Rtf, true, "1^Gandom&~");
                    //var encryptNote = CryptoHelper.EncryptDecrypt(rtb_Note.Rtf, 1231);
                    //var encryptNote = CryptoHelper.EncryptData(rtb_Note.Rtf, "1231");

                    //if (onlyLoad) return;

                    var encryptNote = CryptoHelper.EncryptNew(rtb_Note.Rtf);
                    var diaryNote = new DiaryNote
                    {
                        Date = currentDate,
                        Note = Utility.CompressString(encryptNote, Encoding.UTF8),
                        WeatherConditionId = wcId == 0 ? null : wcId,
                        MentalConditionId = mcId == 0 ? null : mcId,
                        UserId = selectedUser,
                        CreatedBy = currentUser.Id,
                        UpdateBy = null,
                        CreatedOn = currentDateTime,
                        LastUpdate = null,
                    };

                    var result = await _diaryNoteService.CreateAsync(diaryNote);

                    switch (result)
                    {
                        case CreateStatus.Successful:
                            {
                                if (_isModify)
                                {
                                    _isModify = false;
                                    rtb_Note.Focus();
                                    rtb_Note.Select(rtb_Note.Text.Length - 1, 0);
                                    rtb_Note.ScrollToCaret();
                                }

                                CommonHelper.ShowNotificationMessage("یادداشت روزانه", "یادداشت های امروز با موفقیت ذخیره شدند.");
                                break;
                            }
                        case CreateStatus.Failure:
                            {
                                var dlg = new CustomDialogs(320, 200);
                                dlg.Invoke("هشدار", "خطا در اجرای عملیات.", CustomDialogs.ImageType.itError6,
                                    CustomDialogs.ButtonType.Ok, InitialHelper.BackColorCustom);

                                await LoggerService.ErrorAsync(this.Name, "DiaryNotesSaveOrUpdate", "Failure",
                                    "خطا در هنگام ذخیره یادداشت روزانه");
                                break;
                            }
                        case CreateStatus.Exist:
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }
            }
            catch (Exception exception)
            {
                await LoggerService.ErrorAsync(this.Name, "DiaryNotesSaveOrUpdate", exception.Message,
                    exception.ToDetailedString());
            }
        }

        public int GetWidth()
        {
            var w = 25;
            // get total lines of richTextBox1    
            var line = rtb_Note.Lines.Length;

            if (line <= 99)
            {
                w = 20 + (int)rtb_Note.Font.Size;
            }
            else if (line <= 999)
            {
                w = 30 + (int)rtb_Note.Font.Size;
            }
            else
            {
                w = 50 + (int)rtb_Note.Font.Size;
            }

            return w;
        }
        private void UpdateNumberLabel()
        {
            //we get index of first visible char and number of first visible line
            var pos = new Point(0, 0);
            var firstIndex = rtb_Note.GetCharIndexFromPosition(pos);
            var firstLine = rtb_Note.GetLineFromCharIndex(firstIndex);

            //now we get index of last visible char and number of last visible line
            pos.X = ClientRectangle.Width;
            pos.Y = ClientRectangle.Height;
            var lastIndex = rtb_Note.GetCharIndexFromPosition(pos);
            var lastLine = rtb_Note.GetLineFromCharIndex(lastIndex);

            //this is point position of last visible char, we'll use its Y value for calculating numberLabel size
            //pos = rtb_Note.GetPositionFromCharIndex(lastIndex);


            //finally, renumber label
            numberLabel.Width = GetWidth();
            numberLabel.Text = string.Empty;
            for (var i = firstLine; i <= lastLine + 1; i++)
            {
                numberLabel.Text += i + 1 + "\n";
            }
        }
        private void GetLineAndColumn(RichTextBox richTextBox)
        {
            var line = richTextBox.GetLineFromCharIndex(richTextBox.SelectionStart) + 1;
            var charIndexOfLine = richTextBox.GetFirstCharIndexOfCurrentLine();
            var charIndex = richTextBox.SelectionStart;
            var column = Math.Abs(charIndexOfLine - charIndex) <= 0 ? 1 : Math.Abs(charIndexOfLine - charIndex);

            tssl_Row.Text = "سطر: " + line;
            tssl_Column.Text = "ستون: " + column;
        }
        private static DateTime GetCurrentDate(string currentDate)
        {
            return PersianHelper.GetGregorianDateSimple(currentDate);
        }
        //private async Task<string> ReturnDiaryNotesByDate(string currentDate)
        //{
        //    var date = GetCurrentDate(currentDate);
        //    var diaryNote = await _diaryNoteService.LoadByDateAsync(date);
        //    return !string.IsNullOrEmpty(diaryNote?.Note)
        //        ? Utility.DecompressString(diaryNote.Note, Encoding.UTF8) : string.Empty;
        //}
        private async Task<DiaryNote> ReturnDiaryNoteByDate(string currentDate)
        {
            try
            {
                var date = GetCurrentDate(currentDate);
                //var currentUser = InitialHelper.CurrentUser;

                var diaryNote = await _diaryNoteService.LoadByDateAsync(date, await GetSelectedUserId());
                //await currentUser.IsAdmin() ?
                //: await _diaryNoteService.LoadByDateAsync(date, user.Id);

                if (diaryNote == null) return null;
                if (string.IsNullOrEmpty(diaryNote.Note)) return diaryNote;

                //var decryptNote = _cryption.Decrypt(decompressNote);
                //var decryptNote = CryptoHelper.Decrypt(decompressNote, true, "1^Gandom&~");
                //var decryptNote = CryptoHelper.EncryptDecrypt(decompressNote, 1231);
                //var decryptNote = CryptoHelper.EncryptData(decompressNote, "1231");
                //var note = !string.IsNullOrEmpty(diaryNote?.Note)
                //    ? Utility.DecompressString(diaryNote.Note, Encoding.UTF8) : string.Empty;

                var decompressNote = Utility.DecompressString(diaryNote.Note, Encoding.UTF8);
                var decryptNote = CryptoHelper.DecryptNew(decompressNote);
                var note = decryptNote;
                diaryNote.Note = note;
                if (diaryNote.MentalConditionId == null) diaryNote.MentalConditionId = 0;
                if (diaryNote.WeatherConditionId == null) diaryNote.WeatherConditionId = 0;

                _isModify = false;

                return diaryNote;
            }
            catch (Exception exception)
            {
                await LoggerService.ErrorAsync(this.Name, "ReturnDiaryNoteByDate", exception.Message,
                    exception.ToDetailedString());
                _isModify = false;
                return null;
            }
        }
        private void InitializeToday(string date)
        {
            //var newDate = GetCurrentDate(date);
            var newDate = PersianHelper.GetGregorianDate(date);
            lbl_MonthYear.Text = PersianHelper.GetLongPersianDate(newDate, out var color);
            //    PersianHelper.GetPersianDayName(newDate);
            ////lbl_DayOfWeek.Text = currentDayOfWeek;
            ////lbl_DayOfMonth.Text = PersianHelper.GetPersianDayOfMonth(newDate);

            //var monthStr = PersianHelper.GetPersianMonth(newDate);
            //var yearStr = PersianHelper.GetPersianYear(newDate);

            //lbl_MonthYear.Text = currentDayOfWeek + Resources.TwoSpace +
            //                     PersianHelper.GetPersianDayOfMonth(newDate) +
            //                     Resources.TwoSpace + monthStr + Resources.TwoSpace + yearStr;

            lbl_MonthYear.ForeColor = color;
        }

        private void tsmi_IndentDecrease_Click(object sender, EventArgs e)
        {
            TextIndentDecreaseAction();
        }

        private void tsmi_IndentIncrease_Click(object sender, EventArgs e)
        {
            TextIndentIncreaseAction();
        }

        private void Rtb_Note_KeyDown(object sender, KeyEventArgs e)
        {
            _isModify = true;

            if (e.Modifiers == Keys.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.B:
                        StyleAction(FontStyle.Bold);
                        break;
                    case Keys.I:
                        StyleAction(FontStyle.Italic);
                        break;
                    case Keys.S:
                        _isModify = false;
                        break;
                    case Keys.U:
                        StyleAction(FontStyle.Underline);
                        break;
                    case Keys.OemMinus:
                        StyleAction(FontStyle.Bold);
                        break;
                }
            }

            //Insert a tab if the tab key was pressed.
            /* NOTE: This was needed because in Rtb_Note_KeyPress I tell the RichTextBox not
			 * to handle tab events.  I do that because CTRL+I inserts a tab for some
			 */
            if (e.KeyCode == Keys.Tab)
                rtb_Note.SelectedText = "\t";
        }

        #endregion Private Functions


        #region Stamp Event Stuff

        [Description("Occurs when the stamp button is clicked"),
         Category("Behavior")]
        public static event EventHandler Stamp;

        /// <summary>
        /// OnStamp event
        /// </summary>
        protected virtual async void OnStamp(EventArgs e)
        {
            try
            {
                Stamp?.Invoke(this, e);

                switch (InitialHelper.StampAction)
                {
                    case StampActions.EditedBy:
                        {
                            var stamp = new StringBuilder(string.Empty); //holds our stamp text
                            if (rtb_Note.Text.Length > 0) stamp.Append("\r\n"); //add two lines for space
                            stamp.Append("نوشته شده توسط کاربر ");
                            //use the CurrentPrincipal name if one exist else use windows logon username
                            //if (Thread.CurrentPrincipal == null || Thread.CurrentPrincipal.Identity == null
                            //                                    || Thread.CurrentPrincipal.Identity.Name.Length <= 0)
                            //stamp.Append(Environment.UserName);
                            stamp.Append(InitialHelper.CurrentUser.UserName);
                            //else
                            //stamp.Append(Thread.CurrentPrincipal.Identity.Name);
                            //stamp.Append(" on " + DateTime.Now.ToLongDateString() + "\r\n");
                            var currentDate = PersianHelper.GetGregorianDate(txt_diaryNoteDate.Text);
                            stamp.Append(" در تاریخ: " +
                                         PersianHelper.GetLongPersianDate(currentDate, out var color));

                            rtb_Note.SelectionLength = 0; //unselect everything Basically
                            rtb_Note.SelectionStart = rtb_Note.Text.Length; //start new selection at the end of the text
                            rtb_Note.SelectionColor = InitialHelper.StampColor; //make the selection blue
                            rtb_Note.SelectionFont = new Font(rtb_Note.SelectionFont, FontStyle.Bold); //set the selection font and style
                            rtb_Note.AppendText(stamp.ToString()); //add the stamp to the RichTextBox
                            rtb_Note.Focus(); //set focus back on the RichTextBox
                        }
                        break; //end edited by stamp
                    case StampActions.DateTime:
                        {
                            var stamp = new StringBuilder(string.Empty); //holds our stamp text
                            if (rtb_Note.Text.Length > 0) stamp.Append("\r\n"); //add two lines for space
                            stamp.Append(PersianHelper.CreatePersianDate(DateTime.Now) + "\r\n");
                            rtb_Note.SelectionLength = 0; //unselect everything Basically
                            rtb_Note.SelectionStart = rtb_Note.Text.Length; //start new selection at the end of the text
                            rtb_Note.SelectionColor = InitialHelper.StampColor; //make the selection blue
                            rtb_Note.SelectionFont = new Font(rtb_Note.SelectionFont, FontStyle.Bold); //set the selection font and style
                            rtb_Note.AppendText(stamp.ToString()); //add the stamp to the RichTextBox
                            rtb_Note.Focus(); //set focus back on the RichTextBox
                        }
                        break;
                    case StampActions.Custom:
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                } //end select
            }
            catch (Exception exception)
            {

                await LoggerService.ErrorAsync(this.Name, "OnStamp", exception.Message,
                    exception.ToDetailedString());
            }
        }

        private void Pd_DiaryNote_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rtb_Note.Rtf, rtb_Note.Font,
                Brushes.Black, e.MarginBounds.Left, 0, new StringFormat());
            e.Graphics.PageUnit = GraphicsUnit.Inch;
        }

        private void Ts_DiaryNote2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                if (rtb_Note.SelectionFont == null) return;

                switch (e.ClickedItem.Name)
                {

                    case "tsb_GrowFont":
                        //GrowFontAction(sender, e);
                        IncreaseOrDecreaseFontSize();
                        break;
                    case "tsb_ShrinkFont":
                        //ShrinkFontAction(sender, e);
                        IncreaseOrDecreaseFontSize(false);
                        break;
                    case "tsb_Superscript":
                        SuperscriptAction();
                        break;
                    case "tsb_Subscript":
                        SubscriptAction();
                        break;
                    case "tsb_FontColor":
                        ShowFontColorDialog();
                        break;
                    case "tsb_BackColor":
                        ShowFontBackColorDialog();
                        break;
                    case "tsb_FillColor":
                        ShowBackgroundColorDialog();
                        break;
                    case "tsb_ZoomIn":
                        ZoomInAction();
                        break;
                    case "tsb_ZoomOut":
                        ZoomOutAction();
                        break;

                    case "tsb_InsertPicture":
                        InsertPictureAction();
                        break;
                    case "tsb_Stamp":
                        InitialHelper.StampAction = StampActions.EditedBy;
                        OnStamp(new EventArgs());
                        _isModify = true;
                        //StampAction = StampActions.DateTime;
                        //OnStamp(new EventArgs());
                        break;
                    case "tsb_WordWrap":
                        WordWrapAction();
                        break;
                    case "tsb_Find":
                        ShowFindDialog();
                        break;
                    case "tsb_Replace":
                        ShowReplaceDialog();
                        break;
                    case "tsb_SearchHighlight":
                        SearchHighlightAction(rtb_Note, txt_SearchHighlight.Text);
                        break;
                    case "tsb_SearchClear":
                        //Clear
                        SearchClearAction(rtb_Note);
                        break;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void SubscriptAction()
        {
            rtb_Note.SelectionCharOffset = tsb_Subscript.Checked ? 0 : -5;
            rtb_Note.Focus();
        }

        private void SuperscriptAction()
        {
            rtb_Note.SelectionCharOffset = tsb_Superscript.Checked ? 0 : 5;
        }

        private void IncreaseOrDecreaseFontSize(bool increase = true)
        {
            if (rtb_Note.SelectionFont == null) return;
            var currentFont = rtb_Note.SelectionFont;

            if (increase)
            {
                if (currentFont.Size < 100)
                {
                    var index = tsc_FontSize.SelectedIndex + 1;

                    if (index < 0) index = 0;
                    if (index >= tsc_FontSize.Items.Count) index = tsc_FontSize.Items.Count - 1;

                    tsc_FontSize.Text = tsc_FontSize.Items[index].ToString();
                }
                else
                {
                    var x = currentFont.Size + 1f;
                    rtb_Note.SelectionFont = new Font(currentFont.FontFamily, x, currentFont.Style);
                }
            }
            else
            {
                if (currentFont.Size < 100)
                {
                    var index = tsc_FontSize.SelectedIndex - 1;

                    if (index < 0) index = 0;
                    if (index >= tsc_FontSize.Items.Count) index = tsc_FontSize.Items.Count - 1;

                    tsc_FontSize.Text = tsc_FontSize.Items[index].ToString();
                }
                else
                {
                    var x = currentFont.Size - 1f;
                    rtb_Note.SelectionFont = new Font(currentFont.FontFamily, x, currentFont.Style);
                }
            }
            tsc_FontSize.Text = rtb_Note.SelectionFont.Size.ToString(CultureInfo.InvariantCulture);
            rtb_Note.Focus();
        }

        private static void SearchClearAction(RichTextBox richTextBox)
        {
            richTextBox.SelectionStart = 0;
            richTextBox.SelectAll();
            richTextBox.SelectionBackColor = Color.White;
        }

        private static void SearchHighlightAction(RichTextBox richTextBox, string txtSearch)
        {
            //Split a string to arrays
            var words = txtSearch.Split(',');
            foreach (var word in words)
            {
                var startIndex = 0;
                while (startIndex < richTextBox.TextLength)
                {
                    //Find word & return index
                    var wordStartIndex = richTextBox.Find(word, startIndex, RichTextBoxFinds.None);
                    if (wordStartIndex != -1)
                    {
                        //Highlight text in a RichTextBox
                        richTextBox.SelectionStart = wordStartIndex;
                        richTextBox.SelectionLength = word.Length;
                        richTextBox.SelectionBackColor = Color.Yellow;
                    }
                    else
                        break;
                    startIndex += wordStartIndex + word.Length;
                }
            }
        }

        private void Rddl_MentalConditions_ItemDataBound(object sender, ListItemDataBoundEventArgs args)
        {
            var item = args.NewItem;
            var row = item.DataBoundItem as ViewModelSimpleLoadMentalCondition;
            //item.Text += " " + row.Title;
            var pic = row?.Picture;
            item.TextImageRelation = TextImageRelation.ImageBeforeText;
            item.Image = GetImageFromData(pic);
        }

        private Image GetImageFromData(byte[] imageData)
        {
            if (imageData == null) return null;

            const int oleHeaderLength = 78;
            var memoryStream = new MemoryStream();
            if (HasOleContainerHeader(imageData))
            {
                memoryStream.Write(imageData, oleHeaderLength, imageData.Length - oleHeaderLength);
            }
            else
            {
                memoryStream.Write(imageData, 0, imageData.Length);
            }
            var bitmap = new Bitmap(memoryStream);
            return bitmap.GetThumbnailImage(55, 65, null, new IntPtr());
        }

        private void Rddl_WeatherConditions_ItemDataBound(object sender, ListItemDataBoundEventArgs args)
        {
            var item = args.NewItem;
            var row = item.DataBoundItem as ViewModelSimpleLoadWeatherCondition;
            //item.Text += " " + row.Title;
            var pic = row?.Picture;
            item.TextImageRelation = TextImageRelation.ImageBeforeText;
            item.Image = GetImageFromData(pic);
        }
        private bool HasOleContainerHeader(IReadOnlyList<byte> imageByteArray)
        {
            const byte oleByte0 = 21;
            const byte oleByte1 = 28;
            return (imageByteArray[0] == oleByte0) && (imageByteArray[1] == oleByte1);
        }

        //private void Rddl_MentalConditions_VisualListItemFormatting(object sender, VisualItemFormattingEventArgs args)
        //{
        //    //if (args.VisualItem.Selected && rddl_MentalConditions.ThemeName == "VisualStudio2012Dark")
        //    //{
        //    //    args.VisualItem.BackColor = Color.DarkBlue;
        //    //}
        //    //else
        //    //{
        //    //    args.VisualItem.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local);
        //    //    args.VisualItem.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local);
        //    //    args.VisualItem.ResetValue(LightVisualElement.GradientStyleProperty, ValueResetFlags.Local);
        //    //}

        //    //DescriptionTextListVisualItem descriptionItem = args.VisualItem as DescriptionTextListVisualItem;
        //    //if (descriptionItem != null)
        //    //{
        //    //    descriptionItem.ForeColor = Color.Blue;
        //    //    descriptionItem.DescriptionContent.ForeColor = Color.Red;
        //    //}

        //    //DescriptionTextListDataItem data = args.VisualItem.Data as DescriptionTextListDataItem;
        //    //if (data != null)
        //    //{
        //    //    args.VisualItem.BackColor = (Color)data.Tag;
        //    //}
        //}

        private void Rb_Save_Click(object sender, EventArgs e)
        {
            DiaryNotesSaveOrUpdate();
        }

        private void Rb_Exit_Click(object sender, EventArgs e)
        {
            if (rtb_Note.TextLength > 0 && _isModify)
            {
                var dialog = new CustomDialogs(350, 200);
                dialog.Invoke("هشدار", "یادداشت نوشته شده را ذخیره نمی کنید؟",
                    CustomDialogs.ImageType.itQuestion2,
                    CustomDialogs.ButtonType.YesNo, InitialHelper.BackColorCustom);
                if (dialog.Yes)
                {
                    DiaryNotesSaveOrUpdate();
                    //_isModify = false;                    
                }
            }

            this.FullScreenEx(false);
            rtb_Note.Dispose();
            Close();
        }

        //private void Rtb_Note_MouseDown(object sender, MouseEventArgs e)
        //{
        //    //rtb_Note.Select();
        //}

        private void rtb_Note_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            _isModify = true;

            if (e.Modifiers == Keys.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.S:
                        //if (_isModify)
                        {
                            DiaryNotesSaveOrUpdate();
                            _isModify = false;
                        }
                        break;
                }
            }
        }

        private async void rddl_Users_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (!txt_diaryNoteDate.Text.IsValidPersianDate()) return;

            //DiaryNotesSaveOrUpdate(true);
            await ReturnDiaryNoteByDate(_selectedDate);
            Txt_diaryNoteDate_TextChanged(sender, e);

            //MessageBox.Show((await GetSelectedUserId()).ToString());
        }

        private void rddl_MentalConditions_SelectedValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(rddl_MentalConditions.SelectedIndex.ToString());

            _isModify = true;
        }

        private void FrmDiaryNote_Shown(object sender, EventArgs e)
        {
            rddl_Users.SelectedItem = rddl_Users.FindItemExact(InitialHelper.CurrentUser.UserName, false);
            rddl_MentalConditions_SelectedValueChanged(sender, e);
        }


        #endregion
        //private void RadDateTimePicker1_ValueChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        _selectedDate = radDateTimePicker1.Text;
        //        txt_diaryNoteDate.Text = _selectedDate;
        //        _backgroundWorker.RunWorkerAsync();
        //        CommonHelper.IndicatorLoading(this, _pictureBox, true);
        //        //InitializeToday(txt_diaryNoteDate.Text);
        //        //rtb_Note.Rtf = ReturnDiaryNotesByDate(txt_diaryNoteDate.Text);
        //    }
        //    catch
        //    {
        //        return;
        //    }
        //}


        //private void SaveOrUpdateBeforeExit()
        //{
        //    var dialog = new CustomDialogs(350, 200);
        //    dialog.Invoke("خروج از یادداشت روزانه", "اطلاعات یادداشت روزانه ذخیره شود؟",
        //        CustomDialogs.ImageType.itQuestion2,
        //        CustomDialogs.ButtonType.YesNo, InitialHelper.BackColorCustom);

        //    if (dialog.Yes)
        //    {
        //        DiaryNotesSaveOrUpdate();
        //        rtb_Note.Dispose();
        //        Close();
        //    }
        //    else
        //    {
        //        rtb_Note.Dispose();
        //        Close();
        //    }
        //}
    }
}