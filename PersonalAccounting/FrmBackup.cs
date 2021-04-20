using PersonalAccounting.CommonLibrary.Helper;
using PersonalAccounting.CommonLibrary.Properties;
using PersonalAccounting.UI.Helper;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PersonalAccounting.UI
{
    public partial class FrmBackup : Form
    {
        public enum JobStatus
        {
            Success,
            Invalid,
            Fail
        }
    
        private BackgroundWorker _backgroundWorker;
        private PictureBox _pictureBox;
        private JobStatus jobStatus;
        public FrmBackup()
        {
            InitializeComponent();
        }

        private void FrmBackup_Load(object sender, EventArgs e)
        {
            _backgroundWorker = new BackgroundWorker();
            _backgroundWorker.DoWork += _backgroundWorker_DoWork;
            _backgroundWorker.RunWorkerCompleted += _backgroundWorker_RunWorkerCompleted;

            var backupFolderPath = Utility.GetBinFolderPath() + "\\" + txt_BackupFolderName.Text;
            if (!Directory.Exists(backupFolderPath))
            {
                Directory.CreateDirectory(backupFolderPath);
            }

            txt_Path.Text = backupFolderPath;

            _pictureBox = CommonHelper.CreateIndicatorLoading(this, new Size(475, 19), 
                new Point(25, 140), Resources.Loadingvvv, false);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_SelectPath_Click(object sender, EventArgs e)
        {
            if (!ValidateBackupFolder(txt_BackupFolderName.Text))
            {
                txt_BackupFolderName.SelectAll();
                txt_BackupFolderName.Focus();
                return;
            }

            var folderDlg = new FolderBrowserDialog { ShowNewFolderButton = true };

            var result = folderDlg.ShowDialog();

            if (result != DialogResult.OK) return;

            txt_Path.Text = folderDlg.SelectedPath + "\\" + txt_BackupFolderName.Text;
            var root = folderDlg.RootFolder;
        }

        private static bool ValidateBackupFolder(string backupFolder)
        {
            var startWithNumber = backupFolder.Length > 0 && char.IsDigit(backupFolder[0]);
            var result = (!string.IsNullOrEmpty(backupFolder)) &&
                         backupFolder.All(c => char.IsLetterOrDigit(c) || c == '_') && !startWithNumber;

            if (result) return true;

            MessageBox.Show("نام فولدر را مناسب انتخاب کنید.");
            return false;

        }
        private void btn_Backup_Click(object sender, EventArgs e)
        {
            CommonHelper.IndicatorLoading(_pictureBox, true);
            btn_Backup.Enabled = false;
            _backgroundWorker.RunWorkerAsync();
        }
        private void _backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (!ValidateBackupFolder(txt_BackupFolderName.Text))
            {
                jobStatus = JobStatus.Invalid;
            }
            try
            {
                InitialHelper.Backup(txt_Path.Text);
                jobStatus = JobStatus.Success;
            }
            catch (Exception exception)
            {
                jobStatus = JobStatus.Fail;
                MessageBox.Show(exception.Message);
            }
        }
        private void _backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(jobStatus == JobStatus.Invalid)
            {
                txt_BackupFolderName.SelectAll();
                txt_BackupFolderName.Focus();
                return;
            }
            if(jobStatus == JobStatus.Success)
            {
                CommonHelper.ShowNotificationMessage("پیام", "بکاپ با موفقیت انجام شد.");
            }
            
            CommonHelper.IndicatorLoading(_pictureBox, false);
            btn_Backup.Enabled = true;
            _backgroundWorker.Dispose();
        }
    }
}
