using PersonalAccounting.BLL.IService;
using PersonalAccounting.CommonLibrary.Helper;
using PersonalAccounting.Domain.Entity;
using PersonalAccounting.Domain.ViewModel;
using PersonalAccounting.UI.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace PersonalAccounting.UI.ReportForms
{
    public partial class FrmDiaryNoteReport : BaseForm
    {
        public static FrmDiaryNoteReport AFrmDiaryNoteReport = null;
        private readonly IDiaryNoteService _diaryNoteService;
        private readonly
            IRepositoryService<MentalCondition, ViewModelLoadAllMentalCondition, ViewModelSimpleLoadMentalCondition> _mentalConditionService;
        private readonly
            IRepositoryService<WeatherCondition, ViewModelLoadAllWeatherCondition, ViewModelSimpleLoadWeatherCondition> _weatherConditionService;

        private readonly IUserService _userService;

        private readonly BackgroundWorker _backgroundWorker;
        private readonly PictureBox _pictureBox;
        private string _selectedDate;
        private bool _success = false;

        public static FrmDiaryNoteReport Instance()
        {
            return AFrmDiaryNoteReport ?? (AFrmDiaryNoteReport = IocConfig.Container.GetInstance<FrmDiaryNoteReport>());
        }

        public FrmDiaryNoteReport(IDiaryNoteService diaryNoteService,
            IRepositoryService<MentalCondition, ViewModelLoadAllMentalCondition, ViewModelSimpleLoadMentalCondition> mentalConditionService,
            IRepositoryService<WeatherCondition, ViewModelLoadAllWeatherCondition, ViewModelSimpleLoadWeatherCondition> weatherConditionService,
            IUserService userService)
        {
            _diaryNoteService = diaryNoteService;
            _mentalConditionService = mentalConditionService;
            _weatherConditionService = weatherConditionService;
            _userService = userService;

            InitializeComponent();

            _backgroundWorker = new BackgroundWorker();
            _backgroundWorker.DoWork += _backgroundWorker_DoWork;
            _backgroundWorker.RunWorkerCompleted += _backgroundWorker_RunWorkerCompleted;
            ;

            _pictureBox = CommonHelper.CreateIndicatorLoading(this, new Size(500, 100),
                new Point((this.Width / 2) - 150, (this.Height / 2) - 200),
                CommonLibrary.Properties.Resources.LoadingNote, false,
                PictureBoxSizeMode.StretchImage, BorderStyle.None);

            _pictureBox.Click += _pictureBox_Click;

            FillDropdownList(rddl_Users);
            FillDropdownList(rddl_MentalConditions);
            FillDropdownList(rddl_WeatherConditions);

            _selectedDate = PersianHelper.GetPersiaDateSimple(DateTime.Now);
            txt_diaryNoteDate.Text = _selectedDate;

        }

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
        }

        private void _backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (_success)
            {
                try
                {
                    rgv_DiaryNotes.DataSource = e.Result as ViewModelLoadAllDiaryNoteReport;
                }
                catch (Exception exception)
                {
                    LoggerService.ErrorAsync(this.Name, "BackgroundWorker_RunWorkerCompleted", exception.Message,
                        exception.ToDetailedString());
                }
            }

            CommonHelper.IndicatorLoading(_pictureBox);

            _backgroundWorker.Dispose();
        }

        private static DateTime GetCurrentDate(string currentDate)
        {
            return PersianHelper.GetGregorianDateSimple(currentDate);
        }

        private IList<ViewModelLoadAllDiaryNoteReport> ReturnDiaryNotes()
        {
            try
            {
                var date = GetCurrentDate(txt_diaryNoteDate.Text);
                //var currentUser = InitialHelper.CurrentUser;

                var diaryNoteList = _diaryNoteService.GetAllDiaryNotes(date, 
                    int.Parse(rddl_MentalConditions.SelectedValue.ToString()),
                    int.Parse(rddl_WeatherConditions.SelectedValue.ToString()),
                    txt_Note.Text, int.Parse(rddl_Users.SelectedValue.ToString()));

                return diaryNoteList;
            }
            catch (Exception exception)
            {
                LoggerService.ErrorAsync(this.Name, "ReturnDiaryNoteByDate", exception.Message,
                    exception.ToDetailedString());
                return null;
            }
        }

        private void _backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (_backgroundWorker.CancellationPending)//checks for cancel request
                {
                    e.Cancel = true;
                }

                e.Result = ReturnDiaryNotes() as ViewModelLoadAllDiaryNoteReport;

                //SetText(_note);
                _success = true;
            }
            catch (Exception exception)
            {
                e.Cancel = true;

                _success = false;

                LoggerService.ErrorAsync(this.Name, "BackgroundWorker_DoWork", exception.Message,
                    exception.ToDetailedString());
            }
        }

        private void _pictureBox_Click(object sender, System.EventArgs e)
        {
            if (_backgroundWorker.WorkerSupportsCancellation)
                _backgroundWorker.CancelAsync();
        }

        private async void rb_Search_Click(object sender, System.EventArgs e)
        {
            //            _diaryNoteService.GetAllDiaryNotes()
            //CallDataForDiaryNote();
            try
            {
                _selectedDate = txt_diaryNoteDate.Text;
                // _radDateTimePicker.Text = _selectedDate;

                if (!_selectedDate.IsValidPersianDate()) return;
                if (_backgroundWorker.IsBusy) return;


                CommonHelper.IndicatorLoading(_pictureBox, true);
                _backgroundWorker.RunWorkerAsync();
            }
            catch (Exception exception)
            {
                await LoggerService.ErrorAsync(this.Name, "rb_Search_Click", exception.Message,
                    exception.ToDetailedString());
            }
        }
    }
}
