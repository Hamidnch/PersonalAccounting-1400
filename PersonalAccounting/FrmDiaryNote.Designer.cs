namespace PersonalAccounting.UI
{
    partial class FrmDiaryNote
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
            AFrmDiaryNote = null;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDiaryNote));
            this.pnl_TopData = new Telerik.WinControls.UI.RadPanel();
            this.rddl_Users = new Telerik.WinControls.UI.RadDropDownList();
            this.rb_Save = new Telerik.WinControls.UI.RadButton();
            this.rb_Exit = new Telerik.WinControls.UI.RadButton();
            this.btn_IncDate = new System.Windows.Forms.Button();
            this.btn_DecDate = new System.Windows.Forms.Button();
            this.txt_diaryNoteDate = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rddl_WeatherConditions = new Telerik.WinControls.UI.RadDropDownList();
            this.rddl_MentalConditions = new Telerik.WinControls.UI.RadDropDownList();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ts_DiaryNote = new System.Windows.Forms.ToolStrip();
            this.tsb_IndentIncrease = new System.Windows.Forms.ToolStripButton();
            this.tsb_IndentDecrease = new System.Windows.Forms.ToolStripButton();
            this.tsb_Bullet = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_AlignRight = new System.Windows.Forms.ToolStripButton();
            this.tsb_AlignCenter = new System.Windows.Forms.ToolStripButton();
            this.tsb_AlignLeft = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_Bold = new System.Windows.Forms.ToolStripButton();
            this.tsb_Italic = new System.Windows.Forms.ToolStripButton();
            this.tsb_Underline = new System.Windows.Forms.ToolStripButton();
            this.tsb_Strikeout = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_SelectAll = new System.Windows.Forms.ToolStripButton();
            this.tsb_Paste = new System.Windows.Forms.ToolStripButton();
            this.tsb_Copy = new System.Windows.Forms.ToolStripButton();
            this.tsb_Cut = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_Redo = new System.Windows.Forms.ToolStripButton();
            this.tsb_Undo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_PrintPreview = new System.Windows.Forms.ToolStripButton();
            this.tsb_Print = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_FontDialog = new System.Windows.Forms.ToolStripButton();
            this.tsc_FontSize = new System.Windows.Forms.ToolStripComboBox();
            this.tsc_FontName = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_FullScreen = new System.Windows.Forms.ToolStripButton();
            this.ts_DiaryNote2 = new System.Windows.Forms.ToolStrip();
            this.tsb_ZoomOut = new System.Windows.Forms.ToolStripButton();
            this.tsb_ZoomIn = new System.Windows.Forms.ToolStripButton();
            this.tst_ZoomFactor = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_InsertPicture = new System.Windows.Forms.ToolStripButton();
            this.tsb_Stamp = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_Replace = new System.Windows.Forms.ToolStripButton();
            this.tsb_Find = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_Subscript = new System.Windows.Forms.ToolStripButton();
            this.tsb_Superscript = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_ShrinkFont = new System.Windows.Forms.ToolStripButton();
            this.tsb_GrowFont = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_FontColor = new System.Windows.Forms.ToolStripButton();
            this.tsb_BackColor = new System.Windows.Forms.ToolStripButton();
            this.tsb_FillColor = new System.Windows.Forms.ToolStripButton();
            this.tsb_WordWrap = new System.Windows.Forms.ToolStripButton();
            this.toolstripseprator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_SearchClear = new System.Windows.Forms.ToolStripButton();
            this.tsb_SearchHighlight = new System.Windows.Forms.ToolStripButton();
            this.txt_SearchHighlight = new System.Windows.Forms.ToolStripTextBox();
            this.lbl_MonthYear = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.rtb_Note = new System.Windows.Forms.RichTextBox();
            this.cms_DiaryNote = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsm_Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_SelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.tsm_Undo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Redo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsm_Alignment = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_AlignLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_AlignCenter = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_AlignRight = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Style = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Bold = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Italic = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Underline = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Strikeout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Indentation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_IndentIncrease = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_IndentDecrease = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Bullets = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsm_InsertPicture = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsm_ZoomIn = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_ZoomOut = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ss_RowColumn = new System.Windows.Forms.StatusStrip();
            this.tssl_Row = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_Column = new System.Windows.Forms.ToolStripStatusLabel();
            this.pd_DiaryNote = new System.Drawing.Printing.PrintDocument();
            this.ppd_DiaryNote = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_TopData)).BeginInit();
            this.pnl_TopData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rddl_Users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rb_Save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rb_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddl_WeatherConditions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddl_MentalConditions)).BeginInit();
            this.ts_DiaryNote.SuspendLayout();
            this.ts_DiaryNote2.SuspendLayout();
            this.cms_DiaryNote.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.ss_RowColumn.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_TopData
            // 
            this.pnl_TopData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.pnl_TopData.Controls.Add(this.rddl_Users);
            this.pnl_TopData.Controls.Add(this.rb_Save);
            this.pnl_TopData.Controls.Add(this.rb_Exit);
            this.pnl_TopData.Controls.Add(this.btn_IncDate);
            this.pnl_TopData.Controls.Add(this.btn_DecDate);
            this.pnl_TopData.Controls.Add(this.txt_diaryNoteDate);
            this.pnl_TopData.Controls.Add(this.label3);
            this.pnl_TopData.Controls.Add(this.label4);
            this.pnl_TopData.Controls.Add(this.rddl_WeatherConditions);
            this.pnl_TopData.Controls.Add(this.rddl_MentalConditions);
            this.pnl_TopData.Controls.Add(this.label2);
            this.pnl_TopData.Controls.Add(this.label1);
            this.pnl_TopData.Controls.Add(this.ts_DiaryNote);
            this.pnl_TopData.Controls.Add(this.ts_DiaryNote2);
            this.pnl_TopData.Controls.Add(this.lbl_MonthYear);
            this.pnl_TopData.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_TopData.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_TopData.Location = new System.Drawing.Point(0, 27);
            this.pnl_TopData.Name = "pnl_TopData";
            this.pnl_TopData.Size = new System.Drawing.Size(1076, 133);
            this.pnl_TopData.TabIndex = 11;
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
            this.rddl_Users.Location = new System.Drawing.Point(608, 6);
            this.rddl_Users.Name = "rddl_Users";
            this.rddl_Users.Size = new System.Drawing.Size(228, 29);
            this.rddl_Users.TabIndex = 199;
            this.rddl_Users.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.rddl_Users_SelectedIndexChanged);
            // 
            // rb_Save
            // 
            this.rb_Save.Font = new System.Drawing.Font("Tornado Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rb_Save.Image = ((System.Drawing.Image)(resources.GetObject("rb_Save.Image")));
            this.rb_Save.Location = new System.Drawing.Point(174, 76);
            this.rb_Save.Name = "rb_Save";
            this.rb_Save.Padding = new System.Windows.Forms.Padding(5);
            this.rb_Save.Size = new System.Drawing.Size(79, 26);
            this.rb_Save.TabIndex = 3;
            this.rb_Save.Text = "ذخیره";
            this.rb_Save.Click += new System.EventHandler(this.Rb_Save_Click);
            // 
            // rb_Exit
            // 
            this.rb_Exit.Font = new System.Drawing.Font("Tornado Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rb_Exit.Image = ((System.Drawing.Image)(resources.GetObject("rb_Exit.Image")));
            this.rb_Exit.Location = new System.Drawing.Point(92, 76);
            this.rb_Exit.Name = "rb_Exit";
            this.rb_Exit.Padding = new System.Windows.Forms.Padding(5);
            this.rb_Exit.Size = new System.Drawing.Size(79, 26);
            this.rb_Exit.TabIndex = 4;
            this.rb_Exit.Text = "خروج";
            this.rb_Exit.Click += new System.EventHandler(this.Rb_Exit_Click);
            // 
            // btn_IncDate
            // 
            this.btn_IncDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_IncDate.BackColor = System.Drawing.Color.Transparent;
            this.btn_IncDate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_IncDate.FlatAppearance.BorderSize = 2;
            this.btn_IncDate.Image = ((System.Drawing.Image)(resources.GetObject("btn_IncDate.Image")));
            this.btn_IncDate.Location = new System.Drawing.Point(1009, 9);
            this.btn_IncDate.Name = "btn_IncDate";
            this.btn_IncDate.Size = new System.Drawing.Size(23, 25);
            this.btn_IncDate.TabIndex = 5;
            this.btn_IncDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_IncDate.UseVisualStyleBackColor = false;
            this.btn_IncDate.Click += new System.EventHandler(this.Btn_IncDate_Click);
            // 
            // btn_DecDate
            // 
            this.btn_DecDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DecDate.BackColor = System.Drawing.Color.Transparent;
            this.btn_DecDate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_DecDate.FlatAppearance.BorderSize = 2;
            this.btn_DecDate.Image = ((System.Drawing.Image)(resources.GetObject("btn_DecDate.Image")));
            this.btn_DecDate.Location = new System.Drawing.Point(906, 9);
            this.btn_DecDate.Name = "btn_DecDate";
            this.btn_DecDate.Size = new System.Drawing.Size(23, 25);
            this.btn_DecDate.TabIndex = 6;
            this.btn_DecDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_DecDate.UseVisualStyleBackColor = false;
            this.btn_DecDate.Click += new System.EventHandler(this.Btn_DecDate_Click);
            // 
            // txt_diaryNoteDate
            // 
            this.txt_diaryNoteDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_diaryNoteDate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_diaryNoteDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_diaryNoteDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_diaryNoteDate.HideSelection = false;
            this.txt_diaryNoteDate.Location = new System.Drawing.Point(929, 10);
            this.txt_diaryNoteDate.Mask = "1000/00/00";
            this.txt_diaryNoteDate.Name = "txt_diaryNoteDate";
            this.txt_diaryNoteDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_diaryNoteDate.Size = new System.Drawing.Size(80, 23);
            this.txt_diaryNoteDate.TabIndex = 0;
            this.txt_diaryNoteDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_diaryNoteDate.TextChanged += new System.EventHandler(this.Txt_diaryNoteDate_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tornado Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(842, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 14);
            this.label3.TabIndex = 198;
            this.label3.Text = "نام کاربر";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tornado Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(1035, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 14);
            this.label4.TabIndex = 198;
            this.label4.Text = "تاريخ";
            // 
            // rddl_WeatherConditions
            // 
            this.rddl_WeatherConditions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rddl_WeatherConditions.AutoSize = false;
            this.rddl_WeatherConditions.AutoSizeItems = true;
            this.rddl_WeatherConditions.BackColor = System.Drawing.Color.White;
            this.rddl_WeatherConditions.DropDownAnimationEasing = Telerik.WinControls.RadEasingType.InCubic;
            this.rddl_WeatherConditions.DropDownSizingMode = ((Telerik.WinControls.UI.SizingMode)((Telerik.WinControls.UI.SizingMode.RightBottom | Telerik.WinControls.UI.SizingMode.UpDown)));
            this.rddl_WeatherConditions.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.rddl_WeatherConditions.EnableAlternatingItemColor = true;
            this.rddl_WeatherConditions.Font = new System.Drawing.Font("Tornado Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rddl_WeatherConditions.Location = new System.Drawing.Point(12, 6);
            this.rddl_WeatherConditions.Name = "rddl_WeatherConditions";
            this.rddl_WeatherConditions.Size = new System.Drawing.Size(241, 66);
            this.rddl_WeatherConditions.TabIndex = 2;
            this.rddl_WeatherConditions.ItemDataBound += new Telerik.WinControls.UI.ListItemDataBoundEventHandler(this.Rddl_WeatherConditions_ItemDataBound);
            // 
            // rddl_MentalConditions
            // 
            this.rddl_MentalConditions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rddl_MentalConditions.AutoSize = false;
            this.rddl_MentalConditions.AutoSizeItems = true;
            this.rddl_MentalConditions.BackColor = System.Drawing.Color.White;
            this.rddl_MentalConditions.DropDownAnimationEasing = Telerik.WinControls.RadEasingType.OutQuart;
            this.rddl_MentalConditions.DropDownSizingMode = ((Telerik.WinControls.UI.SizingMode)((Telerik.WinControls.UI.SizingMode.RightBottom | Telerik.WinControls.UI.SizingMode.UpDown)));
            this.rddl_MentalConditions.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.rddl_MentalConditions.EnableAlternatingItemColor = true;
            this.rddl_MentalConditions.Font = new System.Drawing.Font("Tornado Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rddl_MentalConditions.Location = new System.Drawing.Point(351, 6);
            this.rddl_MentalConditions.Name = "rddl_MentalConditions";
            this.rddl_MentalConditions.NullText = "موردی یافت نشد";
            this.rddl_MentalConditions.Size = new System.Drawing.Size(241, 66);
            this.rddl_MentalConditions.TabIndex = 1;
            this.rddl_MentalConditions.ItemDataBound += new Telerik.WinControls.UI.ListItemDataBoundEventHandler(this.Rddl_MentalConditions_ItemDataBound);
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.rddl_MentalConditions.GetChildAt(0))).RightToLeft = true;
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.rddl_MentalConditions.GetChildAt(0))).DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.rddl_MentalConditions.GetChildAt(0))).BackColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.rddl_MentalConditions.GetChildAt(0))).ClipDrawing = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tornado Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(257, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 14);
            this.label2.TabIndex = 194;
            this.label2.Text = "وضعیت آب و هوا";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tornado Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(596, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 14);
            this.label1.TabIndex = 195;
            this.label1.Text = "شرایط روحی";
            // 
            // ts_DiaryNote
            // 
            this.ts_DiaryNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.ts_DiaryNote.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ts_DiaryNote.Font = new System.Drawing.Font("Tornado Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ts_DiaryNote.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ts_DiaryNote.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_IndentIncrease,
            this.tsb_IndentDecrease,
            this.tsb_Bullet,
            this.toolStripSeparator6,
            this.tsb_AlignRight,
            this.tsb_AlignCenter,
            this.tsb_AlignLeft,
            this.toolStripSeparator10,
            this.tsb_Bold,
            this.tsb_Italic,
            this.tsb_Underline,
            this.tsb_Strikeout,
            this.toolStripSeparator1,
            this.tsb_SelectAll,
            this.tsb_Paste,
            this.tsb_Copy,
            this.tsb_Cut,
            this.toolStripSeparator9,
            this.tsb_Redo,
            this.tsb_Undo,
            this.toolStripSeparator4,
            this.tsb_PrintPreview,
            this.tsb_Print,
            this.toolStripSeparator5,
            this.tsb_FontDialog,
            this.tsc_FontSize,
            this.tsc_FontName,
            this.toolStripSeparator2,
            this.tsb_FullScreen});
            this.ts_DiaryNote.Location = new System.Drawing.Point(0, 79);
            this.ts_DiaryNote.Name = "ts_DiaryNote";
            this.ts_DiaryNote.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ts_DiaryNote.Size = new System.Drawing.Size(1076, 27);
            this.ts_DiaryNote.TabIndex = 182;
            this.ts_DiaryNote.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Ts_DiaryNote_ItemClicked);
            // 
            // tsb_IndentIncrease
            // 
            this.tsb_IndentIncrease.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_IndentIncrease.Image = ((System.Drawing.Image)(resources.GetObject("tsb_IndentIncrease.Image")));
            this.tsb_IndentIncrease.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_IndentIncrease.Name = "tsb_IndentIncrease";
            this.tsb_IndentIncrease.Size = new System.Drawing.Size(24, 24);
            this.tsb_IndentIncrease.Text = "کاهش تورفتگی متن";
            this.tsb_IndentIncrease.ToolTipText = "کاهش تورفتگی متن";
            // 
            // tsb_IndentDecrease
            // 
            this.tsb_IndentDecrease.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_IndentDecrease.Image = ((System.Drawing.Image)(resources.GetObject("tsb_IndentDecrease.Image")));
            this.tsb_IndentDecrease.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_IndentDecrease.Name = "tsb_IndentDecrease";
            this.tsb_IndentDecrease.Size = new System.Drawing.Size(24, 24);
            this.tsb_IndentDecrease.Text = "افزایش تورفتگی متن";
            this.tsb_IndentDecrease.ToolTipText = "افزایش تورفتگی متن";
            // 
            // tsb_Bullet
            // 
            this.tsb_Bullet.CheckOnClick = true;
            this.tsb_Bullet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Bullet.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Bullet.Image")));
            this.tsb_Bullet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Bullet.Name = "tsb_Bullet";
            this.tsb_Bullet.Size = new System.Drawing.Size(24, 24);
            this.tsb_Bullet.Text = "Bullet";
            this.tsb_Bullet.ToolTipText = "Bullet";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // tsb_AlignRight
            // 
            this.tsb_AlignRight.CheckOnClick = true;
            this.tsb_AlignRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_AlignRight.Image = ((System.Drawing.Image)(resources.GetObject("tsb_AlignRight.Image")));
            this.tsb_AlignRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_AlignRight.Name = "tsb_AlignRight";
            this.tsb_AlignRight.Size = new System.Drawing.Size(24, 24);
            this.tsb_AlignRight.Text = "ترازبندی راست";
            this.tsb_AlignRight.ToolTipText = "ترازبندی راست";
            // 
            // tsb_AlignCenter
            // 
            this.tsb_AlignCenter.CheckOnClick = true;
            this.tsb_AlignCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_AlignCenter.Image = ((System.Drawing.Image)(resources.GetObject("tsb_AlignCenter.Image")));
            this.tsb_AlignCenter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_AlignCenter.Name = "tsb_AlignCenter";
            this.tsb_AlignCenter.Size = new System.Drawing.Size(24, 24);
            this.tsb_AlignCenter.Text = "ترازبندی وسط";
            this.tsb_AlignCenter.ToolTipText = "ترازبندی وسط";
            // 
            // tsb_AlignLeft
            // 
            this.tsb_AlignLeft.CheckOnClick = true;
            this.tsb_AlignLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_AlignLeft.Image = ((System.Drawing.Image)(resources.GetObject("tsb_AlignLeft.Image")));
            this.tsb_AlignLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_AlignLeft.Name = "tsb_AlignLeft";
            this.tsb_AlignLeft.Size = new System.Drawing.Size(24, 24);
            this.tsb_AlignLeft.Text = "ترازبندی چپ";
            this.tsb_AlignLeft.ToolTipText = "ترازبندی چپ";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 27);
            // 
            // tsb_Bold
            // 
            this.tsb_Bold.CheckOnClick = true;
            this.tsb_Bold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Bold.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Bold.Image")));
            this.tsb_Bold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Bold.Name = "tsb_Bold";
            this.tsb_Bold.Size = new System.Drawing.Size(24, 24);
            this.tsb_Bold.Text = "ضخیم کردن متن انتخابی";
            this.tsb_Bold.ToolTipText = "ضخیم کردن متن انتخابی";
            // 
            // tsb_Italic
            // 
            this.tsb_Italic.CheckOnClick = true;
            this.tsb_Italic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Italic.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Italic.Image")));
            this.tsb_Italic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Italic.Name = "tsb_Italic";
            this.tsb_Italic.Size = new System.Drawing.Size(24, 24);
            this.tsb_Italic.Text = "مورب کردن متن انتخابی";
            // 
            // tsb_Underline
            // 
            this.tsb_Underline.CheckOnClick = true;
            this.tsb_Underline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Underline.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Underline.Image")));
            this.tsb_Underline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Underline.Name = "tsb_Underline";
            this.tsb_Underline.Size = new System.Drawing.Size(24, 24);
            this.tsb_Underline.Text = "زیرخط دار کردن متن انتخابی";
            // 
            // tsb_Strikeout
            // 
            this.tsb_Strikeout.CheckOnClick = true;
            this.tsb_Strikeout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Strikeout.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Strikeout.Image")));
            this.tsb_Strikeout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Strikeout.Name = "tsb_Strikeout";
            this.tsb_Strikeout.Size = new System.Drawing.Size(24, 24);
            this.tsb_Strikeout.Text = "خط زدن متن انتخابی";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tsb_SelectAll
            // 
            this.tsb_SelectAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_SelectAll.Image = ((System.Drawing.Image)(resources.GetObject("tsb_SelectAll.Image")));
            this.tsb_SelectAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_SelectAll.Name = "tsb_SelectAll";
            this.tsb_SelectAll.Size = new System.Drawing.Size(24, 24);
            this.tsb_SelectAll.Text = "انتخاب همه";
            // 
            // tsb_Paste
            // 
            this.tsb_Paste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Paste.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Paste.Image")));
            this.tsb_Paste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Paste.Name = "tsb_Paste";
            this.tsb_Paste.Size = new System.Drawing.Size(24, 24);
            this.tsb_Paste.Text = "الصاق";
            // 
            // tsb_Copy
            // 
            this.tsb_Copy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Copy.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Copy.Image")));
            this.tsb_Copy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Copy.Name = "tsb_Copy";
            this.tsb_Copy.Size = new System.Drawing.Size(24, 24);
            this.tsb_Copy.Text = "کپی";
            // 
            // tsb_Cut
            // 
            this.tsb_Cut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Cut.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Cut.Image")));
            this.tsb_Cut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Cut.Name = "tsb_Cut";
            this.tsb_Cut.Size = new System.Drawing.Size(24, 24);
            this.tsb_Cut.ToolTipText = "برش";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 27);
            // 
            // tsb_Redo
            // 
            this.tsb_Redo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Redo.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Redo.Image")));
            this.tsb_Redo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Redo.Name = "tsb_Redo";
            this.tsb_Redo.Size = new System.Drawing.Size(24, 24);
            this.tsb_Redo.ToolTipText = "Redo";
            // 
            // tsb_Undo
            // 
            this.tsb_Undo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Undo.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Undo.Image")));
            this.tsb_Undo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Undo.Name = "tsb_Undo";
            this.tsb_Undo.Size = new System.Drawing.Size(24, 24);
            this.tsb_Undo.ToolTipText = "Undo";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // tsb_PrintPreview
            // 
            this.tsb_PrintPreview.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_PrintPreview.Image = ((System.Drawing.Image)(resources.GetObject("tsb_PrintPreview.Image")));
            this.tsb_PrintPreview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_PrintPreview.Name = "tsb_PrintPreview";
            this.tsb_PrintPreview.Size = new System.Drawing.Size(24, 24);
            this.tsb_PrintPreview.Text = "پیش نمایش چاپ";
            // 
            // tsb_Print
            // 
            this.tsb_Print.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Print.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Print.Image")));
            this.tsb_Print.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Print.Name = "tsb_Print";
            this.tsb_Print.Size = new System.Drawing.Size(24, 24);
            this.tsb_Print.Text = "چاپ یادداشت";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // tsb_FontDialog
            // 
            this.tsb_FontDialog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_FontDialog.Image = ((System.Drawing.Image)(resources.GetObject("tsb_FontDialog.Image")));
            this.tsb_FontDialog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_FontDialog.Name = "tsb_FontDialog";
            this.tsb_FontDialog.Size = new System.Drawing.Size(24, 24);
            this.tsb_FontDialog.ToolTipText = "انتخاب فونت";
            // 
            // tsc_FontSize
            // 
            this.tsc_FontSize.DropDownWidth = 121;
            this.tsc_FontSize.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tsc_FontSize.Font = new System.Drawing.Font("Tornado Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tsc_FontSize.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "30",
            "32",
            "34",
            "36",
            "38",
            "40",
            "42",
            "44",
            "46",
            "48",
            "50",
            "52",
            "54",
            "56",
            "58",
            "60",
            "62",
            "64",
            "66",
            "68",
            "70",
            "72",
            "74",
            "76",
            "78",
            "80",
            "82",
            "84",
            "86",
            "88",
            "90",
            "92",
            "94",
            "96",
            "98",
            "100"});
            this.tsc_FontSize.Name = "tsc_FontSize";
            this.tsc_FontSize.Size = new System.Drawing.Size(75, 27);
            this.tsc_FontSize.Text = "10";
            this.tsc_FontSize.ToolTipText = "اندازه متن";
            this.tsc_FontSize.TextChanged += new System.EventHandler(this.Tsc_FontSize_TextChanged);
            // 
            // tsc_FontName
            // 
            this.tsc_FontName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tsc_FontName.Name = "tsc_FontName";
            this.tsc_FontName.Size = new System.Drawing.Size(150, 27);
            this.tsc_FontName.SelectedIndexChanged += new System.EventHandler(this.Tsc_FontName_SelectedIndexChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tsb_FullScreen
            // 
            this.tsb_FullScreen.CheckOnClick = true;
            this.tsb_FullScreen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_FullScreen.Image = ((System.Drawing.Image)(resources.GetObject("tsb_FullScreen.Image")));
            this.tsb_FullScreen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_FullScreen.Name = "tsb_FullScreen";
            this.tsb_FullScreen.Size = new System.Drawing.Size(24, 24);
            this.tsb_FullScreen.Text = "تمام صفحه";
            // 
            // ts_DiaryNote2
            // 
            this.ts_DiaryNote2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.ts_DiaryNote2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ts_DiaryNote2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts_DiaryNote2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ts_DiaryNote2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_ZoomOut,
            this.tsb_ZoomIn,
            this.tst_ZoomFactor,
            this.toolStripSeparator11,
            this.tsb_InsertPicture,
            this.tsb_Stamp,
            this.toolStripSeparator13,
            this.tsb_Replace,
            this.tsb_Find,
            this.toolStripSeparator15,
            this.tsb_Subscript,
            this.tsb_Superscript,
            this.toolStripSeparator16,
            this.tsb_ShrinkFont,
            this.tsb_GrowFont,
            this.toolStripSeparator14,
            this.tsb_FontColor,
            this.tsb_BackColor,
            this.tsb_FillColor,
            this.tsb_WordWrap,
            this.toolstripseprator1,
            this.tsb_SearchClear,
            this.tsb_SearchHighlight,
            this.txt_SearchHighlight});
            this.ts_DiaryNote2.Location = new System.Drawing.Point(0, 106);
            this.ts_DiaryNote2.Name = "ts_DiaryNote2";
            this.ts_DiaryNote2.Size = new System.Drawing.Size(1076, 27);
            this.ts_DiaryNote2.TabIndex = 183;
            this.ts_DiaryNote2.Text = "toolStrip1";
            this.ts_DiaryNote2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Ts_DiaryNote2_ItemClicked);
            // 
            // tsb_ZoomOut
            // 
            this.tsb_ZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_ZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("tsb_ZoomOut.Image")));
            this.tsb_ZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_ZoomOut.Name = "tsb_ZoomOut";
            this.tsb_ZoomOut.RightToLeftAutoMirrorImage = true;
            this.tsb_ZoomOut.Size = new System.Drawing.Size(24, 24);
            this.tsb_ZoomOut.Text = "کم کردن زوم";
            this.tsb_ZoomOut.ToolTipText = "کم کردن زوم";
            // 
            // tsb_ZoomIn
            // 
            this.tsb_ZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_ZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("tsb_ZoomIn.Image")));
            this.tsb_ZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_ZoomIn.Name = "tsb_ZoomIn";
            this.tsb_ZoomIn.RightToLeftAutoMirrorImage = true;
            this.tsb_ZoomIn.Size = new System.Drawing.Size(24, 24);
            this.tsb_ZoomIn.Text = "زیاد کردن زوم";
            this.tsb_ZoomIn.ToolTipText = "زیاد کردن زوم";
            // 
            // tst_ZoomFactor
            // 
            this.tst_ZoomFactor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tst_ZoomFactor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tst_ZoomFactor.Name = "tst_ZoomFactor";
            this.tst_ZoomFactor.Size = new System.Drawing.Size(45, 27);
            this.tst_ZoomFactor.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tst_ZoomFactor.Leave += new System.EventHandler(this.Tst_ZoomFactor_Leave);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 27);
            // 
            // tsb_InsertPicture
            // 
            this.tsb_InsertPicture.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_InsertPicture.Image = ((System.Drawing.Image)(resources.GetObject("tsb_InsertPicture.Image")));
            this.tsb_InsertPicture.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_InsertPicture.Name = "tsb_InsertPicture";
            this.tsb_InsertPicture.Size = new System.Drawing.Size(24, 24);
            this.tsb_InsertPicture.Text = "افزودن عکس";
            this.tsb_InsertPicture.ToolTipText = "افزودن عکس";
            // 
            // tsb_Stamp
            // 
            this.tsb_Stamp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Stamp.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Stamp.Image")));
            this.tsb_Stamp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Stamp.Name = "tsb_Stamp";
            this.tsb_Stamp.RightToLeftAutoMirrorImage = true;
            this.tsb_Stamp.Size = new System.Drawing.Size(24, 24);
            this.tsb_Stamp.Text = "چاپ اتوماتیک تاریخ جاری";
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(6, 27);
            // 
            // tsb_Replace
            // 
            this.tsb_Replace.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Replace.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Replace.Image")));
            this.tsb_Replace.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Replace.Name = "tsb_Replace";
            this.tsb_Replace.Size = new System.Drawing.Size(24, 24);
            this.tsb_Replace.Text = "جستجو و جایگزین";
            this.tsb_Replace.ToolTipText = "جستجو و جایگزین";
            // 
            // tsb_Find
            // 
            this.tsb_Find.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Find.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Find.Image")));
            this.tsb_Find.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Find.Name = "tsb_Find";
            this.tsb_Find.Size = new System.Drawing.Size(24, 24);
            this.tsb_Find.Text = "جستجو";
            this.tsb_Find.ToolTipText = "جستجو";
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(6, 27);
            // 
            // tsb_Subscript
            // 
            this.tsb_Subscript.CheckOnClick = true;
            this.tsb_Subscript.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Subscript.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Subscript.Image")));
            this.tsb_Subscript.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Subscript.Name = "tsb_Subscript";
            this.tsb_Subscript.Size = new System.Drawing.Size(24, 24);
            this.tsb_Subscript.Text = "پایین انداختن متن";
            // 
            // tsb_Superscript
            // 
            this.tsb_Superscript.CheckOnClick = true;
            this.tsb_Superscript.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Superscript.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Superscript.Image")));
            this.tsb_Superscript.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Superscript.Name = "tsb_Superscript";
            this.tsb_Superscript.Size = new System.Drawing.Size(24, 24);
            this.tsb_Superscript.Text = "بالا بردن متن";
            // 
            // toolStripSeparator16
            // 
            this.toolStripSeparator16.Name = "toolStripSeparator16";
            this.toolStripSeparator16.Size = new System.Drawing.Size(6, 27);
            // 
            // tsb_ShrinkFont
            // 
            this.tsb_ShrinkFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_ShrinkFont.Image = ((System.Drawing.Image)(resources.GetObject("tsb_ShrinkFont.Image")));
            this.tsb_ShrinkFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_ShrinkFont.Name = "tsb_ShrinkFont";
            this.tsb_ShrinkFont.Size = new System.Drawing.Size(24, 24);
            this.tsb_ShrinkFont.Text = "کوچک کردن فونت";
            // 
            // tsb_GrowFont
            // 
            this.tsb_GrowFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_GrowFont.Image = ((System.Drawing.Image)(resources.GetObject("tsb_GrowFont.Image")));
            this.tsb_GrowFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_GrowFont.Name = "tsb_GrowFont";
            this.tsb_GrowFont.Size = new System.Drawing.Size(24, 24);
            this.tsb_GrowFont.Text = "بزرگ کردن فونت";
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(6, 27);
            // 
            // tsb_FontColor
            // 
            this.tsb_FontColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_FontColor.Image = ((System.Drawing.Image)(resources.GetObject("tsb_FontColor.Image")));
            this.tsb_FontColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_FontColor.Name = "tsb_FontColor";
            this.tsb_FontColor.Size = new System.Drawing.Size(24, 24);
            this.tsb_FontColor.Text = "تغییر رنگ متن انتخابی";
            this.tsb_FontColor.ToolTipText = "تغییر رنگ متن انتخابی";
            // 
            // tsb_BackColor
            // 
            this.tsb_BackColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_BackColor.Image = ((System.Drawing.Image)(resources.GetObject("tsb_BackColor.Image")));
            this.tsb_BackColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_BackColor.Name = "tsb_BackColor";
            this.tsb_BackColor.Size = new System.Drawing.Size(24, 24);
            this.tsb_BackColor.Text = "تغییر پس زمینه متن انتخابی";
            this.tsb_BackColor.ToolTipText = "تغییر پس زمینه متن انتخابی";
            // 
            // tsb_FillColor
            // 
            this.tsb_FillColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_FillColor.Image = ((System.Drawing.Image)(resources.GetObject("tsb_FillColor.Image")));
            this.tsb_FillColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_FillColor.Name = "tsb_FillColor";
            this.tsb_FillColor.Size = new System.Drawing.Size(24, 24);
            this.tsb_FillColor.Text = "تغییر رنگ پس زمینه";
            // 
            // tsb_WordWrap
            // 
            this.tsb_WordWrap.CheckOnClick = true;
            this.tsb_WordWrap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_WordWrap.Image = ((System.Drawing.Image)(resources.GetObject("tsb_WordWrap.Image")));
            this.tsb_WordWrap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_WordWrap.Name = "tsb_WordWrap";
            this.tsb_WordWrap.Size = new System.Drawing.Size(24, 24);
            this.tsb_WordWrap.Text = "شکستن خط";
            this.tsb_WordWrap.ToolTipText = "با رسیدن نوشته به انتهای یک خط، مکان نما به طور خودکار به خط بعدی پرش می کند";
            // 
            // toolstripseprator1
            // 
            this.toolstripseprator1.Name = "toolstripseprator1";
            this.toolstripseprator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tsb_SearchClear
            // 
            this.tsb_SearchClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_SearchClear.Image = ((System.Drawing.Image)(resources.GetObject("tsb_SearchClear.Image")));
            this.tsb_SearchClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_SearchClear.Name = "tsb_SearchClear";
            this.tsb_SearchClear.Size = new System.Drawing.Size(24, 24);
            this.tsb_SearchClear.Text = "حذف جستجوی برجسته شده";
            // 
            // tsb_SearchHighlight
            // 
            this.tsb_SearchHighlight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_SearchHighlight.Image = ((System.Drawing.Image)(resources.GetObject("tsb_SearchHighlight.Image")));
            this.tsb_SearchHighlight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_SearchHighlight.Name = "tsb_SearchHighlight";
            this.tsb_SearchHighlight.Size = new System.Drawing.Size(24, 24);
            this.tsb_SearchHighlight.Text = "برجسته کردن جستجو";
            this.tsb_SearchHighlight.ToolTipText = "برجسته کردن جستجو";
            // 
            // txt_SearchHighlight
            // 
            this.txt_SearchHighlight.AutoToolTip = true;
            this.txt_SearchHighlight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SearchHighlight.Font = new System.Drawing.Font("Tornado Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_SearchHighlight.Name = "txt_SearchHighlight";
            this.txt_SearchHighlight.Size = new System.Drawing.Size(310, 27);
            this.txt_SearchHighlight.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_SearchHighlight.ToolTipText = "جستجو در متن";
            // 
            // lbl_MonthYear
            // 
            this.lbl_MonthYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_MonthYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.lbl_MonthYear.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_MonthYear.ForeColor = System.Drawing.Color.Brown;
            this.lbl_MonthYear.Location = new System.Drawing.Point(682, 42);
            this.lbl_MonthYear.Name = "lbl_MonthYear";
            this.lbl_MonthYear.Size = new System.Drawing.Size(380, 26);
            this.lbl_MonthYear.TabIndex = 176;
            this.lbl_MonthYear.Text = "مهر 1387";
            this.lbl_MonthYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.numberLabel.Font = new System.Drawing.Font("Tornado Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.numberLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.numberLabel.Location = new System.Drawing.Point(9, 4);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(15, 16);
            this.numberLabel.TabIndex = 14;
            this.numberLabel.Text = "1";
            this.numberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtb_Note
            // 
            this.rtb_Note.BackColor = System.Drawing.SystemColors.Window;
            this.rtb_Note.ContextMenuStrip = this.cms_DiaryNote;
            this.rtb_Note.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_Note.Font = new System.Drawing.Font("Tornado Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rtb_Note.HideSelection = false;
            this.rtb_Note.Location = new System.Drawing.Point(0, 0);
            this.rtb_Note.Name = "rtb_Note";
            this.rtb_Note.Size = new System.Drawing.Size(1038, 502);
            this.rtb_Note.TabIndex = 0;
            this.rtb_Note.Text = "";
            this.rtb_Note.HScroll += new System.EventHandler(this.rtb_Note_Click);
            this.rtb_Note.SelectionChanged += new System.EventHandler(this.Rtb_Note_SelectionChanged);
            this.rtb_Note.VScroll += new System.EventHandler(this.rtb_Note_VScroll);
            this.rtb_Note.Click += new System.EventHandler(this.rtb_Note_Click);
            this.rtb_Note.CursorChanged += new System.EventHandler(this.rtb_Note_Click);
            this.rtb_Note.EnabledChanged += new System.EventHandler(this.rtb_Note_Click);
            this.rtb_Note.FontChanged += new System.EventHandler(this.rtb_Note_FontChanged);
            this.rtb_Note.ForeColorChanged += new System.EventHandler(this.rtb_Note_Click);
            this.rtb_Note.RightToLeftChanged += new System.EventHandler(this.rtb_Note_Click);
            this.rtb_Note.SizeChanged += new System.EventHandler(this.rtb_Note_Click);
            this.rtb_Note.TabIndexChanged += new System.EventHandler(this.rtb_Note_Click);
            this.rtb_Note.TabStopChanged += new System.EventHandler(this.rtb_Note_Click);
            this.rtb_Note.TextChanged += new System.EventHandler(this.rtb_Note_TextChanged);
            this.rtb_Note.VisibleChanged += new System.EventHandler(this.rtb_Note_Click);
            this.rtb_Note.DoubleClick += new System.EventHandler(this.rtb_Note_Click);
            this.rtb_Note.Enter += new System.EventHandler(this.rtb_Note_Click);
            this.rtb_Note.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Rtb_Note_KeyDown);
            this.rtb_Note.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtb_Note_KeyPress);
            this.rtb_Note.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.rtb_Note_PreviewKeyDown);
            this.rtb_Note.Resize += new System.EventHandler(this.rtb_Note_Resize);
            this.rtb_Note.StyleChanged += new System.EventHandler(this.rtb_Note_Click);
            this.rtb_Note.Validated += new System.EventHandler(this.rtb_Note_Click);
            // 
            // cms_DiaryNote
            // 
            this.cms_DiaryNote.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms_DiaryNote.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_Cut,
            this.tsm_Copy,
            this.tsm_Paste,
            this.tsm_Delete,
            this.tsm_SelectAll,
            this.toolStripSeparator12,
            this.tsm_Undo,
            this.tsm_Redo,
            this.toolStripMenuItem2,
            this.tsm_Alignment,
            this.tsm_Style,
            this.tsm_Indentation,
            this.toolStripMenuItem3,
            this.tsm_InsertPicture,
            this.toolStripMenuItem4,
            this.tsm_ZoomIn,
            this.tsm_ZoomOut});
            this.cms_DiaryNote.Name = "contextMenu";
            this.cms_DiaryNote.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cms_DiaryNote.Size = new System.Drawing.Size(147, 366);
            this.cms_DiaryNote.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Cms_DiaryNote_ItemClicked);
            // 
            // tsm_Cut
            // 
            this.tsm_Cut.Image = ((System.Drawing.Image)(resources.GetObject("tsm_Cut.Image")));
            this.tsm_Cut.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsm_Cut.Name = "tsm_Cut";
            this.tsm_Cut.Size = new System.Drawing.Size(146, 26);
            this.tsm_Cut.Text = "برش";
            // 
            // tsm_Copy
            // 
            this.tsm_Copy.Image = ((System.Drawing.Image)(resources.GetObject("tsm_Copy.Image")));
            this.tsm_Copy.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsm_Copy.Name = "tsm_Copy";
            this.tsm_Copy.Size = new System.Drawing.Size(146, 26);
            this.tsm_Copy.Text = "کپی";
            // 
            // tsm_Paste
            // 
            this.tsm_Paste.Image = ((System.Drawing.Image)(resources.GetObject("tsm_Paste.Image")));
            this.tsm_Paste.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsm_Paste.Name = "tsm_Paste";
            this.tsm_Paste.Size = new System.Drawing.Size(146, 26);
            this.tsm_Paste.Text = "الصاق";
            // 
            // tsm_Delete
            // 
            this.tsm_Delete.Image = ((System.Drawing.Image)(resources.GetObject("tsm_Delete.Image")));
            this.tsm_Delete.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsm_Delete.Name = "tsm_Delete";
            this.tsm_Delete.Size = new System.Drawing.Size(146, 26);
            this.tsm_Delete.Text = "پاک کردن";
            // 
            // tsm_SelectAll
            // 
            this.tsm_SelectAll.Image = ((System.Drawing.Image)(resources.GetObject("tsm_SelectAll.Image")));
            this.tsm_SelectAll.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsm_SelectAll.Name = "tsm_SelectAll";
            this.tsm_SelectAll.Size = new System.Drawing.Size(146, 26);
            this.tsm_SelectAll.Text = "انتخاب همه";
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(143, 6);
            // 
            // tsm_Undo
            // 
            this.tsm_Undo.Image = ((System.Drawing.Image)(resources.GetObject("tsm_Undo.Image")));
            this.tsm_Undo.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsm_Undo.Name = "tsm_Undo";
            this.tsm_Undo.Size = new System.Drawing.Size(146, 26);
            this.tsm_Undo.Text = "Undo";
            // 
            // tsm_Redo
            // 
            this.tsm_Redo.Image = ((System.Drawing.Image)(resources.GetObject("tsm_Redo.Image")));
            this.tsm_Redo.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsm_Redo.Name = "tsm_Redo";
            this.tsm_Redo.Size = new System.Drawing.Size(146, 26);
            this.tsm_Redo.Text = "Redo";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(143, 6);
            // 
            // tsm_Alignment
            // 
            this.tsm_Alignment.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_AlignLeft,
            this.tsmi_AlignCenter,
            this.tsmi_AlignRight});
            this.tsm_Alignment.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsm_Alignment.Name = "tsm_Alignment";
            this.tsm_Alignment.Size = new System.Drawing.Size(146, 26);
            this.tsm_Alignment.Text = "ترازبندی";
            // 
            // tsmi_AlignLeft
            // 
            this.tsmi_AlignLeft.CheckOnClick = true;
            this.tsmi_AlignLeft.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_AlignLeft.Image")));
            this.tsmi_AlignLeft.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsmi_AlignLeft.Name = "tsmi_AlignLeft";
            this.tsmi_AlignLeft.Size = new System.Drawing.Size(144, 22);
            this.tsmi_AlignLeft.Text = "ترازبندی چپ";
            this.tsmi_AlignLeft.Click += new System.EventHandler(this.Tsmi_AlignLeft_Click);
            // 
            // tsmi_AlignCenter
            // 
            this.tsmi_AlignCenter.CheckOnClick = true;
            this.tsmi_AlignCenter.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_AlignCenter.Image")));
            this.tsmi_AlignCenter.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsmi_AlignCenter.Name = "tsmi_AlignCenter";
            this.tsmi_AlignCenter.Size = new System.Drawing.Size(144, 22);
            this.tsmi_AlignCenter.Text = "ترازبندی راست";
            this.tsmi_AlignCenter.Click += new System.EventHandler(this.Tsmi_AlignCenter_Click);
            // 
            // tsmi_AlignRight
            // 
            this.tsmi_AlignRight.CheckOnClick = true;
            this.tsmi_AlignRight.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_AlignRight.Image")));
            this.tsmi_AlignRight.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsmi_AlignRight.Name = "tsmi_AlignRight";
            this.tsmi_AlignRight.Size = new System.Drawing.Size(144, 22);
            this.tsmi_AlignRight.Text = "ترازبندی راست";
            this.tsmi_AlignRight.Click += new System.EventHandler(this.Tsmi_AlignRight_Click);
            // 
            // tsm_Style
            // 
            this.tsm_Style.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Bold,
            this.tsmi_Italic,
            this.tsmi_Underline,
            this.tsmi_Strikeout});
            this.tsm_Style.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsm_Style.Name = "tsm_Style";
            this.tsm_Style.Size = new System.Drawing.Size(146, 26);
            this.tsm_Style.Text = "سبک متن";
            // 
            // tsmi_Bold
            // 
            this.tsmi_Bold.CheckOnClick = true;
            this.tsmi_Bold.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_Bold.Image")));
            this.tsmi_Bold.Name = "tsmi_Bold";
            this.tsmi_Bold.Size = new System.Drawing.Size(126, 22);
            this.tsmi_Bold.Text = "ضخیم";
            this.tsmi_Bold.Click += new System.EventHandler(this.Tsmi_Bold_Click);
            // 
            // tsmi_Italic
            // 
            this.tsmi_Italic.CheckOnClick = true;
            this.tsmi_Italic.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_Italic.Image")));
            this.tsmi_Italic.Name = "tsmi_Italic";
            this.tsmi_Italic.Size = new System.Drawing.Size(126, 22);
            this.tsmi_Italic.Text = "مورب";
            this.tsmi_Italic.Click += new System.EventHandler(this.Tsmi_Italic_Click);
            // 
            // tsmi_Underline
            // 
            this.tsmi_Underline.CheckOnClick = true;
            this.tsmi_Underline.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_Underline.Image")));
            this.tsmi_Underline.Name = "tsmi_Underline";
            this.tsmi_Underline.Size = new System.Drawing.Size(126, 22);
            this.tsmi_Underline.Text = "زیر خط دار";
            this.tsmi_Underline.Click += new System.EventHandler(this.Tsmi_Underline_Click);
            // 
            // tsmi_Strikeout
            // 
            this.tsmi_Strikeout.CheckOnClick = true;
            this.tsmi_Strikeout.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_Strikeout.Image")));
            this.tsmi_Strikeout.Name = "tsmi_Strikeout";
            this.tsmi_Strikeout.Size = new System.Drawing.Size(126, 22);
            this.tsmi_Strikeout.Text = "خط خورده";
            this.tsmi_Strikeout.Click += new System.EventHandler(this.Tsmi_Strikeout_Click);
            // 
            // tsm_Indentation
            // 
            this.tsm_Indentation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_IndentIncrease,
            this.tsmi_IndentDecrease,
            this.tsmi_Bullets});
            this.tsm_Indentation.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsm_Indentation.Name = "tsm_Indentation";
            this.tsm_Indentation.Size = new System.Drawing.Size(146, 26);
            this.tsm_Indentation.Text = "تو رفتگی";
            // 
            // tsmi_IndentIncrease
            // 
            this.tsmi_IndentIncrease.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_IndentIncrease.Image")));
            this.tsmi_IndentIncrease.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsmi_IndentIncrease.Name = "tsmi_IndentIncrease";
            this.tsmi_IndentIncrease.Size = new System.Drawing.Size(154, 22);
            this.tsmi_IndentIncrease.Text = "افزایش تو رفتگی";
            this.tsmi_IndentIncrease.Click += new System.EventHandler(this.tsmi_IndentIncrease_Click);
            // 
            // tsmi_IndentDecrease
            // 
            this.tsmi_IndentDecrease.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_IndentDecrease.Image")));
            this.tsmi_IndentDecrease.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsmi_IndentDecrease.Name = "tsmi_IndentDecrease";
            this.tsmi_IndentDecrease.Size = new System.Drawing.Size(154, 22);
            this.tsmi_IndentDecrease.Text = "کاهش تو رفتگی";
            this.tsmi_IndentDecrease.Click += new System.EventHandler(this.tsmi_IndentDecrease_Click);
            // 
            // tsmi_Bullets
            // 
            this.tsmi_Bullets.CheckOnClick = true;
            this.tsmi_Bullets.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_Bullets.Image")));
            this.tsmi_Bullets.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsmi_Bullets.Name = "tsmi_Bullets";
            this.tsmi_Bullets.Size = new System.Drawing.Size(154, 22);
            this.tsmi_Bullets.Text = "Bullets";
            this.tsmi_Bullets.Click += new System.EventHandler(this.tsmi_Bullets_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(143, 6);
            // 
            // tsm_InsertPicture
            // 
            this.tsm_InsertPicture.Image = ((System.Drawing.Image)(resources.GetObject("tsm_InsertPicture.Image")));
            this.tsm_InsertPicture.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsm_InsertPicture.Name = "tsm_InsertPicture";
            this.tsm_InsertPicture.Size = new System.Drawing.Size(146, 26);
            this.tsm_InsertPicture.Text = "افزودن تصویر";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(143, 6);
            // 
            // tsm_ZoomIn
            // 
            this.tsm_ZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("tsm_ZoomIn.Image")));
            this.tsm_ZoomIn.ImageTransparentColor = System.Drawing.Color.White;
            this.tsm_ZoomIn.Name = "tsm_ZoomIn";
            this.tsm_ZoomIn.Size = new System.Drawing.Size(146, 26);
            this.tsm_ZoomIn.Text = "افزایش زوم";
            // 
            // tsm_ZoomOut
            // 
            this.tsm_ZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("tsm_ZoomOut.Image")));
            this.tsm_ZoomOut.ImageTransparentColor = System.Drawing.Color.White;
            this.tsm_ZoomOut.Name = "tsm_ZoomOut";
            this.tsm_ZoomOut.Size = new System.Drawing.Size(146, 26);
            this.tsm_ZoomOut.Text = "کاهش زوم";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 160);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.splitContainer1.Panel1.Controls.Add(this.numberLabel);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Tornado Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.splitContainer1.Panel1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.splitContainer1.Panel2.Controls.Add(this.rtb_Note);
            this.splitContainer1.Panel2.Controls.Add(this.ss_RowColumn);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(1076, 524);
            this.splitContainer1.SplitterDistance = 34;
            this.splitContainer1.TabIndex = 15;
            // 
            // ss_RowColumn
            // 
            this.ss_RowColumn.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ss_RowColumn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssl_Row,
            this.tssl_Column});
            this.ss_RowColumn.Location = new System.Drawing.Point(0, 502);
            this.ss_RowColumn.Name = "ss_RowColumn";
            this.ss_RowColumn.Size = new System.Drawing.Size(1038, 22);
            this.ss_RowColumn.TabIndex = 180;
            this.ss_RowColumn.Text = "statusStrip1";
            // 
            // tssl_Row
            // 
            this.tssl_Row.Name = "tssl_Row";
            this.tssl_Row.Size = new System.Drawing.Size(22, 17);
            this.tssl_Row.Text = "---";
            // 
            // tssl_Column
            // 
            this.tssl_Column.Name = "tssl_Column";
            this.tssl_Column.Size = new System.Drawing.Size(22, 17);
            this.tssl_Column.Text = "---";
            // 
            // pd_DiaryNote
            // 
            this.pd_DiaryNote.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.Pd_DiaryNote_PrintPage);
            // 
            // ppd_DiaryNote
            // 
            this.ppd_DiaryNote.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppd_DiaryNote.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppd_DiaryNote.ClientSize = new System.Drawing.Size(400, 300);
            this.ppd_DiaryNote.Enabled = true;
            this.ppd_DiaryNote.Icon = ((System.Drawing.Icon)(resources.GetObject("ppd_DiaryNote.Icon")));
            this.ppd_DiaryNote.Name = "ppd_DiaryNote";
            this.ppd_DiaryNote.Visible = false;
            // 
            // FrmDiaryNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 684);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pnl_TopData);
            this.Font = new System.Drawing.Font("Tornado Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "FrmDiaryNote";
            this.ShowInTaskbar = false;
            this.Text = "یادداشت های روزانه";
            this.Load += new System.EventHandler(this.FrmDiaryNote_Load);
            this.Controls.SetChildIndex(this.pnl_TopData, 0);
            this.Controls.SetChildIndex(this.splitContainer1, 0);
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_TopData)).EndInit();
            this.pnl_TopData.ResumeLayout(false);
            this.pnl_TopData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rddl_Users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rb_Save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rb_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddl_WeatherConditions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddl_MentalConditions)).EndInit();
            this.ts_DiaryNote.ResumeLayout(false);
            this.ts_DiaryNote.PerformLayout();
            this.ts_DiaryNote2.ResumeLayout(false);
            this.ts_DiaryNote2.PerformLayout();
            this.cms_DiaryNote.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ss_RowColumn.ResumeLayout(false);
            this.ss_RowColumn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadPanel pnl_TopData;
        private System.Windows.Forms.Label lbl_MonthYear;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.RichTextBox rtb_Note;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ContextMenuStrip cms_DiaryNote;
        private System.Windows.Forms.ToolStripMenuItem tsm_Cut;
        private System.Windows.Forms.ToolStripMenuItem tsm_Copy;
        private System.Windows.Forms.ToolStripMenuItem tsm_Paste;
        private System.Windows.Forms.ToolStripMenuItem tsm_Delete;
        private System.Windows.Forms.ToolStripMenuItem tsm_SelectAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripMenuItem tsm_Undo;
        private System.Windows.Forms.ToolStripMenuItem tsm_Redo;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsm_Alignment;
        private System.Windows.Forms.ToolStripMenuItem tsmi_AlignLeft;
        private System.Windows.Forms.ToolStripMenuItem tsmi_AlignCenter;
        private System.Windows.Forms.ToolStripMenuItem tsmi_AlignRight;
        private System.Windows.Forms.ToolStripMenuItem tsm_Style;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Bold;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Italic;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Underline;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Strikeout;
        private System.Windows.Forms.ToolStripMenuItem tsm_Indentation;
        private System.Windows.Forms.ToolStripMenuItem tsmi_IndentIncrease;
        private System.Windows.Forms.ToolStripMenuItem tsmi_IndentDecrease;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Bullets;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem tsm_InsertPicture;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem tsm_ZoomIn;
        private System.Windows.Forms.ToolStripMenuItem tsm_ZoomOut;
        private System.Drawing.Printing.PrintDocument pd_DiaryNote;
        private System.Windows.Forms.PrintPreviewDialog ppd_DiaryNote;
        private System.Windows.Forms.StatusStrip ss_RowColumn;
        private System.Windows.Forms.ToolStripStatusLabel tssl_Row;
        private System.Windows.Forms.ToolStripStatusLabel tssl_Column;
        private System.Windows.Forms.ToolStrip ts_DiaryNote;
        private System.Windows.Forms.ToolStripButton tsb_IndentIncrease;
        private System.Windows.Forms.ToolStripButton tsb_IndentDecrease;
        private System.Windows.Forms.ToolStripButton tsb_Bullet;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tsb_AlignRight;
        private System.Windows.Forms.ToolStripButton tsb_AlignCenter;
        private System.Windows.Forms.ToolStripButton tsb_AlignLeft;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripButton tsb_Bold;
        private System.Windows.Forms.ToolStripButton tsb_Italic;
        private System.Windows.Forms.ToolStripButton tsb_Underline;
        private System.Windows.Forms.ToolStripButton tsb_Strikeout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsb_SelectAll;
        private System.Windows.Forms.ToolStripButton tsb_Paste;
        private System.Windows.Forms.ToolStripButton tsb_Copy;
        private System.Windows.Forms.ToolStripButton tsb_Cut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsb_Undo;
        private System.Windows.Forms.ToolStripButton tsb_Redo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsb_FontDialog;
        private System.Windows.Forms.ToolStripComboBox tsc_FontSize;
        private System.Windows.Forms.ToolStripComboBox tsc_FontName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton tsb_FullScreen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsb_PrintPreview;
        private System.Windows.Forms.ToolStripButton tsb_Print;
        private System.Windows.Forms.ToolStrip ts_DiaryNote2;
        private System.Windows.Forms.ToolStripButton tsb_ZoomIn;
        private System.Windows.Forms.ToolStripButton tsb_ZoomOut;
        private System.Windows.Forms.ToolStripTextBox tst_ZoomFactor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripButton tsb_InsertPicture;
        private System.Windows.Forms.ToolStripButton tsb_Stamp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripButton tsb_Replace;
        private System.Windows.Forms.ToolStripButton tsb_Find;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator15;
        private System.Windows.Forms.ToolStripButton tsb_Subscript;
        private System.Windows.Forms.ToolStripButton tsb_Superscript;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator16;
        private System.Windows.Forms.ToolStripButton tsb_ShrinkFont;
        private System.Windows.Forms.ToolStripButton tsb_GrowFont;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripButton tsb_FontColor;
        private System.Windows.Forms.ToolStripButton tsb_BackColor;
        private System.Windows.Forms.ToolStripButton tsb_FillColor;
        private System.Windows.Forms.ToolStripButton tsb_WordWrap;
        private System.Windows.Forms.ToolStripSeparator toolstripseprator1;
        private System.Windows.Forms.ToolStripButton tsb_SearchClear;
        private System.Windows.Forms.ToolStripButton tsb_SearchHighlight;
        private System.Windows.Forms.ToolStripTextBox txt_SearchHighlight;
        private Telerik.WinControls.UI.RadButton rb_Exit;
        private Telerik.WinControls.UI.RadButton rb_Save;
        private System.Windows.Forms.Button btn_IncDate;
        private System.Windows.Forms.Button btn_DecDate;
        private System.Windows.Forms.MaskedTextBox txt_diaryNoteDate;
        private System.Windows.Forms.Label label4;
        private Telerik.WinControls.UI.RadDropDownList rddl_WeatherConditions;
        private Telerik.WinControls.UI.RadDropDownList rddl_MentalConditions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Telerik.WinControls.UI.RadDropDownList rddl_Users;
        //private Telerik.WinControls.UI.RadDateTimePicker radDateTimePicker1;
    }
}