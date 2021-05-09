
namespace PersonalAccounting.UI
{
    partial class FrmBackup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_Path = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rcb_IsCompressed = new Telerik.WinControls.UI.RadCheckBox();
            this.lbl_BackupFolderName = new System.Windows.Forms.Label();
            this.lbl_SelectPath = new System.Windows.Forms.Label();
            this.btn_SelectPath = new System.Windows.Forms.Button();
            this.txt_BackupFolderName = new System.Windows.Forms.TextBox();
            this.btn_Backup = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rcb_IsCompressed)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Path
            // 
            this.txt_Path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Path.Location = new System.Drawing.Point(41, 96);
            this.txt_Path.Name = "txt_Path";
            this.txt_Path.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Path.Size = new System.Drawing.Size(450, 20);
            this.txt_Path.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.rcb_IsCompressed);
            this.panel1.Controls.Add(this.lbl_BackupFolderName);
            this.panel1.Controls.Add(this.lbl_SelectPath);
            this.panel1.Controls.Add(this.btn_SelectPath);
            this.panel1.Controls.Add(this.txt_BackupFolderName);
            this.panel1.Controls.Add(this.txt_Path);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 177);
            this.panel1.TabIndex = 1;
            // 
            // rcb_IsCompressed
            // 
            this.rcb_IsCompressed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rcb_IsCompressed.Font = new System.Drawing.Font("Tornado Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rcb_IsCompressed.Location = new System.Drawing.Point(88, 21);
            this.rcb_IsCompressed.Name = "rcb_IsCompressed";
            this.rcb_IsCompressed.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rcb_IsCompressed.Size = new System.Drawing.Size(98, 20);
            this.rcb_IsCompressed.TabIndex = 3;
            this.rcb_IsCompressed.Text = "فشرده شود؟";
            this.rcb_IsCompressed.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.rcb_IsCompressed.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // lbl_BackupFolderName
            // 
            this.lbl_BackupFolderName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_BackupFolderName.AutoSize = true;
            this.lbl_BackupFolderName.Location = new System.Drawing.Point(412, 19);
            this.lbl_BackupFolderName.Name = "lbl_BackupFolderName";
            this.lbl_BackupFolderName.Size = new System.Drawing.Size(70, 13);
            this.lbl_BackupFolderName.TabIndex = 1;
            this.lbl_BackupFolderName.Text = "نام فولدر بکاپ";
            // 
            // lbl_SelectPath
            // 
            this.lbl_SelectPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_SelectPath.AutoSize = true;
            this.lbl_SelectPath.Location = new System.Drawing.Point(428, 71);
            this.lbl_SelectPath.Name = "lbl_SelectPath";
            this.lbl_SelectPath.Size = new System.Drawing.Size(66, 13);
            this.lbl_SelectPath.TabIndex = 1;
            this.lbl_SelectPath.Text = "انتخاب مسیر";
            // 
            // btn_SelectPath
            // 
            this.btn_SelectPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SelectPath.Location = new System.Drawing.Point(5, 92);
            this.btn_SelectPath.Name = "btn_SelectPath";
            this.btn_SelectPath.Size = new System.Drawing.Size(33, 31);
            this.btn_SelectPath.TabIndex = 2;
            this.btn_SelectPath.Text = "...";
            this.btn_SelectPath.UseVisualStyleBackColor = true;
            this.btn_SelectPath.Click += new System.EventHandler(this.btn_SelectPath_Click);
            // 
            // txt_BackupFolderName
            // 
            this.txt_BackupFolderName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_BackupFolderName.Location = new System.Drawing.Point(274, 19);
            this.txt_BackupFolderName.Name = "txt_BackupFolderName";
            this.txt_BackupFolderName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_BackupFolderName.Size = new System.Drawing.Size(132, 20);
            this.txt_BackupFolderName.TabIndex = 0;
            this.txt_BackupFolderName.Text = "BackupFolder";
            // 
            // btn_Backup
            // 
            this.btn_Backup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Backup.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Backup.FlatAppearance.BorderSize = 2;
            this.btn_Backup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Backup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btn_Backup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Backup.Font = new System.Drawing.Font("Tornado Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_Backup.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Backup.Location = new System.Drawing.Point(415, 203);
            this.btn_Backup.Name = "btn_Backup";
            this.btn_Backup.Size = new System.Drawing.Size(97, 37);
            this.btn_Backup.TabIndex = 2;
            this.btn_Backup.Text = "بکاپ";
            this.btn_Backup.UseVisualStyleBackColor = false;
            this.btn_Backup.Click += new System.EventHandler(this.btn_Backup_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Cancel.FlatAppearance.BorderSize = 2;
            this.btn_Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Tornado Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Cancel.Location = new System.Drawing.Point(312, 203);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(97, 37);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "بستن";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(13, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(499, 1);
            this.label3.TabIndex = 24;
            // 
            // FrmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 250);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Backup);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tornado Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBackup";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرم بکاپ گرفتن از دیتابیس";
            this.Load += new System.EventHandler(this.FrmBackup_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rcb_IsCompressed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Path;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_SelectPath;
        private System.Windows.Forms.Button btn_SelectPath;
        private System.Windows.Forms.Button btn_Backup;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_BackupFolderName;
        private System.Windows.Forms.TextBox txt_BackupFolderName;
        private Telerik.WinControls.UI.RadCheckBox rcb_IsCompressed;
    }
}