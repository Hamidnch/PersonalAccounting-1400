
namespace PersonalAccounting.UI.ReportForms
{
    partial class FrmDiaryNoteReport
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
            AFrmDiaryNoteReport = null;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDiaryNoteReport));
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.pnl_TopData = new Telerik.WinControls.UI.RadPanel();
            this.rb_Search = new Telerik.WinControls.UI.RadButton();
            this.rb_Exit = new Telerik.WinControls.UI.RadButton();
            this.txt_Note = new System.Windows.Forms.TextBox();
            this.rddl_Users = new Telerik.WinControls.UI.RadDropDownList();
            this.btn_IncDate = new System.Windows.Forms.Button();
            this.btn_DecDate = new System.Windows.Forms.Button();
            this.txt_diaryNoteDate = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Users = new System.Windows.Forms.Label();
            this.lbl_NoteSummary = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rddl_WeatherConditions = new Telerik.WinControls.UI.RadDropDownList();
            this.rddl_MentalConditions = new Telerik.WinControls.UI.RadDropDownList();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rgv_DiaryNotes = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_TopData)).BeginInit();
            this.pnl_TopData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rb_Search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rb_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddl_Users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddl_WeatherConditions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddl_MentalConditions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_DiaryNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_DiaryNotes.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_TopData
            // 
            this.pnl_TopData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.pnl_TopData.Controls.Add(this.rb_Search);
            this.pnl_TopData.Controls.Add(this.rb_Exit);
            this.pnl_TopData.Controls.Add(this.txt_Note);
            this.pnl_TopData.Controls.Add(this.rddl_Users);
            this.pnl_TopData.Controls.Add(this.btn_IncDate);
            this.pnl_TopData.Controls.Add(this.btn_DecDate);
            this.pnl_TopData.Controls.Add(this.txt_diaryNoteDate);
            this.pnl_TopData.Controls.Add(this.lbl_Users);
            this.pnl_TopData.Controls.Add(this.lbl_NoteSummary);
            this.pnl_TopData.Controls.Add(this.label4);
            this.pnl_TopData.Controls.Add(this.rddl_WeatherConditions);
            this.pnl_TopData.Controls.Add(this.rddl_MentalConditions);
            this.pnl_TopData.Controls.Add(this.label2);
            this.pnl_TopData.Controls.Add(this.label1);
            this.pnl_TopData.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_TopData.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_TopData.Location = new System.Drawing.Point(0, 27);
            this.pnl_TopData.Name = "pnl_TopData";
            this.pnl_TopData.Size = new System.Drawing.Size(1342, 155);
            this.pnl_TopData.TabIndex = 12;
            // 
            // rb_Search
            // 
            this.rb_Search.Font = new System.Drawing.Font("Tornado Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rb_Search.Location = new System.Drawing.Point(185, 107);
            this.rb_Search.Name = "rb_Search";
            this.rb_Search.Padding = new System.Windows.Forms.Padding(5);
            this.rb_Search.Size = new System.Drawing.Size(79, 26);
            this.rb_Search.TabIndex = 201;
            this.rb_Search.Text = "جستجو";
            this.rb_Search.Click += new System.EventHandler(this.rb_Search_Click);
            // 
            // rb_Exit
            // 
            this.rb_Exit.Font = new System.Drawing.Font("Tornado Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rb_Exit.Image = ((System.Drawing.Image)(resources.GetObject("rb_Exit.Image")));
            this.rb_Exit.Location = new System.Drawing.Point(103, 107);
            this.rb_Exit.Name = "rb_Exit";
            this.rb_Exit.Padding = new System.Windows.Forms.Padding(5);
            this.rb_Exit.Size = new System.Drawing.Size(79, 26);
            this.rb_Exit.TabIndex = 202;
            this.rb_Exit.Text = "خروج";
            // 
            // txt_Note
            // 
            this.txt_Note.Location = new System.Drawing.Point(834, 51);
            this.txt_Note.Multiline = true;
            this.txt_Note.Name = "txt_Note";
            this.txt_Note.Size = new System.Drawing.Size(461, 93);
            this.txt_Note.TabIndex = 200;
            // 
            // rddl_Users
            // 
            this.rddl_Users.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rddl_Users.AutoSize = false;
            this.rddl_Users.AutoSizeItems = true;
            this.rddl_Users.BackColor = System.Drawing.Color.White;
            this.rddl_Users.DropDownAnimationEasing = Telerik.WinControls.RadEasingType.InCubic;
            this.rddl_Users.DropDownSizingMode = ((Telerik.WinControls.UI.SizingMode)((Telerik.WinControls.UI.SizingMode.RightBottom | Telerik.WinControls.UI.SizingMode.UpDown)));
            this.rddl_Users.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.rddl_Users.EnableAlternatingItemColor = true;
            this.rddl_Users.Font = new System.Drawing.Font("Tornado Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rddl_Users.Location = new System.Drawing.Point(834, 10);
            this.rddl_Users.Name = "rddl_Users";
            this.rddl_Users.Size = new System.Drawing.Size(250, 29);
            this.rddl_Users.TabIndex = 199;
            this.rddl_Users.Visible = false;
            // 
            // btn_IncDate
            // 
            this.btn_IncDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_IncDate.BackColor = System.Drawing.Color.Transparent;
            this.btn_IncDate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_IncDate.FlatAppearance.BorderSize = 2;
            this.btn_IncDate.Image = ((System.Drawing.Image)(resources.GetObject("btn_IncDate.Image")));
            this.btn_IncDate.Location = new System.Drawing.Point(1275, 11);
            this.btn_IncDate.Name = "btn_IncDate";
            this.btn_IncDate.Size = new System.Drawing.Size(23, 25);
            this.btn_IncDate.TabIndex = 5;
            this.btn_IncDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_IncDate.UseVisualStyleBackColor = false;
            // 
            // btn_DecDate
            // 
            this.btn_DecDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DecDate.BackColor = System.Drawing.Color.Transparent;
            this.btn_DecDate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_DecDate.FlatAppearance.BorderSize = 2;
            this.btn_DecDate.Image = ((System.Drawing.Image)(resources.GetObject("btn_DecDate.Image")));
            this.btn_DecDate.Location = new System.Drawing.Point(1172, 11);
            this.btn_DecDate.Name = "btn_DecDate";
            this.btn_DecDate.Size = new System.Drawing.Size(23, 25);
            this.btn_DecDate.TabIndex = 6;
            this.btn_DecDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_DecDate.UseVisualStyleBackColor = false;
            // 
            // txt_diaryNoteDate
            // 
            this.txt_diaryNoteDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_diaryNoteDate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_diaryNoteDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_diaryNoteDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_diaryNoteDate.HideSelection = false;
            this.txt_diaryNoteDate.Location = new System.Drawing.Point(1195, 10);
            this.txt_diaryNoteDate.Mask = "1000/00/00";
            this.txt_diaryNoteDate.Name = "txt_diaryNoteDate";
            this.txt_diaryNoteDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_diaryNoteDate.Size = new System.Drawing.Size(80, 27);
            this.txt_diaryNoteDate.TabIndex = 0;
            this.txt_diaryNoteDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Users
            // 
            this.lbl_Users.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Users.AutoSize = true;
            this.lbl_Users.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Users.Font = new System.Drawing.Font("Tornado Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_Users.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_Users.Location = new System.Drawing.Point(1090, 13);
            this.lbl_Users.Name = "lbl_Users";
            this.lbl_Users.Size = new System.Drawing.Size(56, 18);
            this.lbl_Users.TabIndex = 198;
            this.lbl_Users.Text = "نام کاربر";
            this.lbl_Users.Visible = false;
            // 
            // lbl_NoteSummary
            // 
            this.lbl_NoteSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_NoteSummary.AutoSize = true;
            this.lbl_NoteSummary.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NoteSummary.Font = new System.Drawing.Font("Tornado Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_NoteSummary.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_NoteSummary.Location = new System.Drawing.Point(1301, 79);
            this.lbl_NoteSummary.Name = "lbl_NoteSummary";
            this.lbl_NoteSummary.Size = new System.Drawing.Size(32, 18);
            this.lbl_NoteSummary.TabIndex = 198;
            this.lbl_NoteSummary.Text = "متن";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tornado Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(1301, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 18);
            this.label4.TabIndex = 198;
            this.label4.Text = "تاريخ";
            // 
            // rddl_WeatherConditions
            // 
            this.rddl_WeatherConditions.AutoSize = false;
            this.rddl_WeatherConditions.AutoSizeItems = true;
            this.rddl_WeatherConditions.BackColor = System.Drawing.Color.White;
            this.rddl_WeatherConditions.DropDownAnimationEasing = Telerik.WinControls.RadEasingType.InCubic;
            this.rddl_WeatherConditions.DropDownSizingMode = ((Telerik.WinControls.UI.SizingMode)((Telerik.WinControls.UI.SizingMode.RightBottom | Telerik.WinControls.UI.SizingMode.UpDown)));
            this.rddl_WeatherConditions.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.rddl_WeatherConditions.EnableAlternatingItemColor = true;
            this.rddl_WeatherConditions.Font = new System.Drawing.Font("Tornado Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rddl_WeatherConditions.Location = new System.Drawing.Point(103, 12);
            this.rddl_WeatherConditions.Name = "rddl_WeatherConditions";
            this.rddl_WeatherConditions.Size = new System.Drawing.Size(197, 66);
            this.rddl_WeatherConditions.TabIndex = 2;
            // 
            // rddl_MentalConditions
            // 
            this.rddl_MentalConditions.AutoSize = false;
            this.rddl_MentalConditions.AutoSizeItems = true;
            this.rddl_MentalConditions.BackColor = System.Drawing.Color.White;
            this.rddl_MentalConditions.DropDownAnimationEasing = Telerik.WinControls.RadEasingType.OutQuart;
            this.rddl_MentalConditions.DropDownSizingMode = ((Telerik.WinControls.UI.SizingMode)((Telerik.WinControls.UI.SizingMode.RightBottom | Telerik.WinControls.UI.SizingMode.UpDown)));
            this.rddl_MentalConditions.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.rddl_MentalConditions.EnableAlternatingItemColor = true;
            this.rddl_MentalConditions.Font = new System.Drawing.Font("Tornado Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rddl_MentalConditions.Location = new System.Drawing.Point(520, 12);
            this.rddl_MentalConditions.Name = "rddl_MentalConditions";
            this.rddl_MentalConditions.NullText = "موردی یافت نشد";
            this.rddl_MentalConditions.Size = new System.Drawing.Size(197, 66);
            this.rddl_MentalConditions.TabIndex = 1;
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.rddl_MentalConditions.GetChildAt(0))).RightToLeft = true;
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.rddl_MentalConditions.GetChildAt(0))).DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.rddl_MentalConditions.GetChildAt(0))).BackColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.rddl_MentalConditions.GetChildAt(0))).ClipDrawing = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tornado Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(333, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 18);
            this.label2.TabIndex = 194;
            this.label2.Text = "وضعیت آب و هوا";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tornado Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(721, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 195;
            this.label1.Text = "شرایط روحی";
            // 
            // rgv_DiaryNotes
            // 
            this.rgv_DiaryNotes.AutoScroll = true;
            this.rgv_DiaryNotes.BackColor = System.Drawing.SystemColors.Control;
            this.rgv_DiaryNotes.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_DiaryNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rgv_DiaryNotes.EnableHotTracking = false;
            this.rgv_DiaryNotes.EnterKeyMode = Telerik.WinControls.UI.RadGridViewEnterKeyMode.EnterMovesToNextRow;
            this.rgv_DiaryNotes.Font = new System.Drawing.Font("Tornado Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rgv_DiaryNotes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgv_DiaryNotes.GroupExpandAnimationType = Telerik.WinControls.UI.GridExpandAnimationType.Slide;
            this.rgv_DiaryNotes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_DiaryNotes.Location = new System.Drawing.Point(0, 182);
            this.rgv_DiaryNotes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // 
            // 
            this.rgv_DiaryNotes.MasterTemplate.AllowAddNewRow = false;
            this.rgv_DiaryNotes.MasterTemplate.AllowCellContextMenu = false;
            this.rgv_DiaryNotes.MasterTemplate.AllowDeleteRow = false;
            this.rgv_DiaryNotes.MasterTemplate.AllowEditRow = false;
            this.rgv_DiaryNotes.MasterTemplate.AllowRowResize = false;
            this.rgv_DiaryNotes.MasterTemplate.AutoExpandGroups = true;
            this.rgv_DiaryNotes.MasterTemplate.EnableAlternatingRowColor = true;
            this.rgv_DiaryNotes.MasterTemplate.EnableFiltering = true;
            this.rgv_DiaryNotes.MasterTemplate.ReadOnly = true;
            this.rgv_DiaryNotes.MasterTemplate.ShowGroupedColumns = true;
            this.rgv_DiaryNotes.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.rgv_DiaryNotes.Name = "rgv_DiaryNotes";
            this.rgv_DiaryNotes.ReadOnly = true;
            this.rgv_DiaryNotes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rgv_DiaryNotes.Size = new System.Drawing.Size(1342, 546);
            this.rgv_DiaryNotes.TabIndex = 13;
            // 
            // FrmDiaryNoteReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 728);
            this.Controls.Add(this.rgv_DiaryNotes);
            this.Controls.Add(this.pnl_TopData);
            this.Name = "FrmDiaryNoteReport";
            this.Text = "فرم گزارش از یادداشتهای روزانه";
            this.Controls.SetChildIndex(this.pnl_TopData, 0);
            this.Controls.SetChildIndex(this.rgv_DiaryNotes, 0);
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_TopData)).EndInit();
            this.pnl_TopData.ResumeLayout(false);
            this.pnl_TopData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rb_Search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rb_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddl_Users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddl_WeatherConditions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddl_MentalConditions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_DiaryNotes.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_DiaryNotes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel pnl_TopData;
        private System.Windows.Forms.TextBox txt_Note;
        private Telerik.WinControls.UI.RadDropDownList rddl_Users;
        private System.Windows.Forms.Button btn_IncDate;
        private System.Windows.Forms.Button btn_DecDate;
        private System.Windows.Forms.MaskedTextBox txt_diaryNoteDate;
        private System.Windows.Forms.Label lbl_Users;
        private System.Windows.Forms.Label lbl_NoteSummary;
        private System.Windows.Forms.Label label4;
        private Telerik.WinControls.UI.RadDropDownList rddl_WeatherConditions;
        private Telerik.WinControls.UI.RadDropDownList rddl_MentalConditions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadButton rb_Search;
        private Telerik.WinControls.UI.RadButton rb_Exit;
        private Telerik.WinControls.UI.RadGridView rgv_DiaryNotes;
    }
}