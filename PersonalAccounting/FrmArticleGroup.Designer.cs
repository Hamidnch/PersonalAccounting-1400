namespace PersonalAccounting.UI
{
    partial class FrmArticleGroup
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
            AFrmArticleGroup = null;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArticleGroup));
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem3 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem4 = new Telerik.WinControls.UI.RadListDataItem();
            this.pnl_Data = new System.Windows.Forms.Panel();
            this.rddl_ArticleGroupStatus = new Telerik.WinControls.UI.RadDropDownList();
            this.txt_ArticleGroupDescription = new System.Windows.Forms.TextBox();
            this.txt_ArticleGroupLatinName = new System.Windows.Forms.TextBox();
            this.txt_ArticleGroupName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_Action = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.rcb_Search = new Telerik.WinControls.UI.RadCommandBar();
            this.commandBarRowElement1 = new Telerik.WinControls.UI.CommandBarRowElement();
            this.commandBarStripElement2 = new Telerik.WinControls.UI.CommandBarStripElement();
            this.commandBarLabel2 = new Telerik.WinControls.UI.CommandBarLabel();
            this.ctb_Search = new Telerik.WinControls.UI.CommandBarTextBox();
            this.cbtb_ListView = new Telerik.WinControls.UI.CommandBarToggleButton();
            this.cbtb_IconsView = new Telerik.WinControls.UI.CommandBarToggleButton();
            this.cbtb_DetailsView = new Telerik.WinControls.UI.CommandBarToggleButton();
            this.commandBarRowElement2 = new Telerik.WinControls.UI.CommandBarRowElement();
            this.commandBarStripElement4 = new Telerik.WinControls.UI.CommandBarStripElement();
            this.commandBarLabel4 = new Telerik.WinControls.UI.CommandBarLabel();
            this.commandBarDropDownSort = new Telerik.WinControls.UI.CommandBarDropDownList();
            this.commandBarSeparator1 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.commandBarDropDownGroup = new Telerik.WinControls.UI.CommandBarDropDownList();
            this.commandBarSeparator2 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.commandBarToggleList = new Telerik.WinControls.UI.CommandBarToggleButton();
            this.commandBarToggleTiles = new Telerik.WinControls.UI.CommandBarToggleButton();
            this.commandBarToggleDetails = new Telerik.WinControls.UI.CommandBarToggleButton();
            this.commandBarSeparator3 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.commandBarLabel1 = new Telerik.WinControls.UI.CommandBarLabel();
            this.commandBarTextBoxFilter = new Telerik.WinControls.UI.CommandBarTextBox();
            this.commandBarRowElement3 = new Telerik.WinControls.UI.CommandBarRowElement();
            this.rlv_ArticleGroup = new Telerik.WinControls.UI.RadListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).BeginInit();
            this.pnl_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rddl_ArticleGroupStatus)).BeginInit();
            this.pnl_Action.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rcb_Search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlv_ArticleGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Data
            // 
            this.pnl_Data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.pnl_Data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Data.Controls.Add(this.rddl_ArticleGroupStatus);
            this.pnl_Data.Controls.Add(this.txt_ArticleGroupDescription);
            this.pnl_Data.Controls.Add(this.txt_ArticleGroupLatinName);
            this.pnl_Data.Controls.Add(this.txt_ArticleGroupName);
            this.pnl_Data.Controls.Add(this.label6);
            this.pnl_Data.Controls.Add(this.label9);
            this.pnl_Data.Controls.Add(this.label3);
            this.pnl_Data.Controls.Add(this.label1);
            this.pnl_Data.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Data.Enabled = false;
            this.pnl_Data.Location = new System.Drawing.Point(0, 0);
            this.pnl_Data.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_Data.Name = "pnl_Data";
            this.pnl_Data.Size = new System.Drawing.Size(1025, 102);
            this.pnl_Data.TabIndex = 1;
            // 
            // rddl_ArticleGroupStatus
            // 
            this.rddl_ArticleGroupStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rddl_ArticleGroupStatus.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.rddl_ArticleGroupStatus.Font = new System.Drawing.Font("Tornado Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rddl_ArticleGroupStatus.Location = new System.Drawing.Point(807, 51);
            this.rddl_ArticleGroupStatus.MaxDropDownItems = 10;
            this.rddl_ArticleGroupStatus.Name = "rddl_ArticleGroupStatus";
            this.rddl_ArticleGroupStatus.Size = new System.Drawing.Size(131, 22);
            this.rddl_ArticleGroupStatus.TabIndex = 214;
            this.rddl_ArticleGroupStatus.TextChanged += new System.EventHandler(this.txt_ArticleGroupName_TextChanged);
            this.rddl_ArticleGroupStatus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_ArticleGroupName_KeyDown);
            // 
            // txt_ArticleGroupDescription
            // 
            this.txt_ArticleGroupDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ArticleGroupDescription.BackColor = System.Drawing.Color.FloralWhite;
            this.txt_ArticleGroupDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ArticleGroupDescription.Location = new System.Drawing.Point(14, 40);
            this.txt_ArticleGroupDescription.Multiline = true;
            this.txt_ArticleGroupDescription.Name = "txt_ArticleGroupDescription";
            this.txt_ArticleGroupDescription.Size = new System.Drawing.Size(712, 54);
            this.txt_ArticleGroupDescription.TabIndex = 3;
            this.txt_ArticleGroupDescription.TextChanged += new System.EventHandler(this.txt_ArticleGroupName_TextChanged);
            this.txt_ArticleGroupDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_ArticleGroupName_KeyDown);
            // 
            // txt_ArticleGroupLatinName
            // 
            this.txt_ArticleGroupLatinName.BackColor = System.Drawing.Color.FloralWhite;
            this.txt_ArticleGroupLatinName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ArticleGroupLatinName.Location = new System.Drawing.Point(14, 8);
            this.txt_ArticleGroupLatinName.Name = "txt_ArticleGroupLatinName";
            this.txt_ArticleGroupLatinName.Size = new System.Drawing.Size(250, 22);
            this.txt_ArticleGroupLatinName.TabIndex = 1;
            this.txt_ArticleGroupLatinName.TextChanged += new System.EventHandler(this.txt_ArticleGroupName_TextChanged);
            this.txt_ArticleGroupLatinName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_ArticleGroupName_KeyDown);
            // 
            // txt_ArticleGroupName
            // 
            this.txt_ArticleGroupName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ArticleGroupName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ArticleGroupName.Location = new System.Drawing.Point(331, 8);
            this.txt_ArticleGroupName.Name = "txt_ArticleGroupName";
            this.txt_ArticleGroupName.Size = new System.Drawing.Size(607, 22);
            this.txt_ArticleGroupName.TabIndex = 0;
            this.txt_ArticleGroupName.TextChanged += new System.EventHandler(this.txt_ArticleGroupName_TextChanged);
            this.txt_ArticleGroupName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_ArticleGroupName_KeyDown);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(960, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 14);
            this.label6.TabIndex = 131;
            this.label6.Text = "وضعیت";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(731, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 125;
            this.label9.Text = "توضیحات";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(272, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 123;
            this.label3.Text = "نام لاتین";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(946, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 123;
            this.label1.Text = "عنوان گروه";
            // 
            // pnl_Action
            // 
            this.pnl_Action.AutoSize = true;
            this.pnl_Action.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.pnl_Action.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Action.Controls.Add(this.btnClose);
            this.pnl_Action.Controls.Add(this.btnCancel);
            this.pnl_Action.Controls.Add(this.btnDelete);
            this.pnl_Action.Controls.Add(this.btnModify);
            this.pnl_Action.Controls.Add(this.btnRegister);
            this.pnl_Action.Controls.Add(this.btnInsert);
            this.pnl_Action.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Action.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.pnl_Action.Location = new System.Drawing.Point(0, 102);
            this.pnl_Action.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_Action.Name = "pnl_Action";
            this.pnl_Action.Size = new System.Drawing.Size(1025, 39);
            this.pnl_Action.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point(6, 4);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(76, 29);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "بستن";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancel.Enabled = false;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(870, 2);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(31, 31);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(900, 2);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(31, 31);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModify.BackColor = System.Drawing.Color.White;
            this.btnModify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnModify.Enabled = false;
            this.btnModify.Image = ((System.Drawing.Image)(resources.GetObject("btnModify.Image")));
            this.btnModify.Location = new System.Drawing.Point(930, 2);
            this.btnModify.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(31, 31);
            this.btnModify.TabIndex = 2;
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegister.BackColor = System.Drawing.Color.White;
            this.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRegister.Enabled = false;
            this.btnRegister.Image = ((System.Drawing.Image)(resources.GetObject("btnRegister.Image")));
            this.btnRegister.Location = new System.Drawing.Point(960, 2);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(31, 31);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsert.BackColor = System.Drawing.Color.White;
            this.btnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInsert.Image = ((System.Drawing.Image)(resources.GetObject("btnInsert.Image")));
            this.btnInsert.Location = new System.Drawing.Point(990, 2);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(31, 31);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // rcb_Search
            // 
            this.rcb_Search.Dock = System.Windows.Forms.DockStyle.Top;
            this.rcb_Search.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rcb_Search.Location = new System.Drawing.Point(0, 141);
            this.rcb_Search.Name = "rcb_Search";
            this.rcb_Search.Rows.AddRange(new Telerik.WinControls.UI.CommandBarRowElement[] {
            this.commandBarRowElement1});
            this.rcb_Search.Size = new System.Drawing.Size(1025, 30);
            this.rcb_Search.TabIndex = 1;
            // 
            // commandBarRowElement1
            // 
            this.commandBarRowElement1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.commandBarRowElement1.MinSize = new System.Drawing.Size(29, 27);
            this.commandBarRowElement1.Name = "commandBarRowElement1";
            this.commandBarRowElement1.Strips.AddRange(new Telerik.WinControls.UI.CommandBarStripElement[] {
            this.commandBarStripElement2});
            this.commandBarRowElement1.Text = "";
            // 
            // commandBarStripElement2
            // 
            this.commandBarStripElement2.DisplayName = "commandBarStripElement2";
            this.commandBarStripElement2.DrawBorder = true;
            this.commandBarStripElement2.DrawText = true;
            this.commandBarStripElement2.EnableImageTransparency = true;
            this.commandBarStripElement2.FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent;
            this.commandBarStripElement2.FlipText = false;
            this.commandBarStripElement2.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.commandBarLabel2,
            this.ctb_Search,
            this.cbtb_ListView,
            this.cbtb_IconsView,
            this.cbtb_DetailsView});
            this.commandBarStripElement2.Name = "commandBarStripElement2";
            this.commandBarStripElement2.OverflowMenuMaxSize = new System.Drawing.Size(315, 0);
            this.commandBarStripElement2.OverflowMenuMinSize = new System.Drawing.Size(58, 27);
            this.commandBarStripElement2.ShowHorizontalLine = false;
            this.commandBarStripElement2.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.commandBarStripElement2.StretchHorizontally = false;
            this.commandBarStripElement2.StretchVertically = true;
            this.commandBarStripElement2.TextOrientation = System.Windows.Forms.Orientation.Horizontal;
            this.commandBarStripElement2.TextWrap = false;
            // 
            // commandBarLabel2
            // 
            this.commandBarLabel2.DisplayName = "commandBarLabel2";
            this.commandBarLabel2.Name = "commandBarLabel2";
            this.commandBarLabel2.Text = "جستجو";
            // 
            // ctb_Search
            // 
            this.ctb_Search.AutoSize = false;
            this.ctb_Search.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.Auto;
            this.ctb_Search.Bounds = new System.Drawing.Rectangle(0, 0, 300, 22);
            this.ctb_Search.DisplayName = "commandBarTextBox2";
            this.ctb_Search.Name = "ctb_Search";
            this.ctb_Search.StretchHorizontally = true;
            this.ctb_Search.StretchVertically = true;
            this.ctb_Search.Text = "";
            this.ctb_Search.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.ctb_Search.TextChanged += new System.EventHandler(this.ctb_Search_TextChanged);
            // 
            // cbtb_ListView
            // 
            this.cbtb_ListView.AccessibleDescription = "commandBarToggleButton4";
            this.cbtb_ListView.AccessibleName = "commandBarToggleButton4";
            this.cbtb_ListView.Image = ((System.Drawing.Image)(resources.GetObject("cbtb_ListView.Image")));
            this.cbtb_ListView.Name = "cbtb_ListView";
            this.cbtb_ListView.Text = "";
            this.cbtb_ListView.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.cbtb_ListView.ToolTipText = "ListView";
            this.cbtb_ListView.ToggleStateChanging += new Telerik.WinControls.UI.StateChangingEventHandler(this.ViewToggleButton_ToggleStateChanging);
            this.cbtb_ListView.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.ViewToggleButton_ToggleStateChanged);
            // 
            // cbtb_IconsView
            // 
            this.cbtb_IconsView.AccessibleDescription = "commandBarToggleButton5";
            this.cbtb_IconsView.AccessibleName = "commandBarToggleButton5";
            this.cbtb_IconsView.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbtb_IconsView.DisplayName = "commandBarToggleButton5";
            this.cbtb_IconsView.Image = ((System.Drawing.Image)(resources.GetObject("cbtb_IconsView.Image")));
            this.cbtb_IconsView.Name = "cbtb_IconsView";
            this.cbtb_IconsView.Text = "";
            this.cbtb_IconsView.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.cbtb_IconsView.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.cbtb_IconsView.ToolTipText = "IconsView";
            this.cbtb_IconsView.ToggleStateChanging += new Telerik.WinControls.UI.StateChangingEventHandler(this.ViewToggleButton_ToggleStateChanging);
            this.cbtb_IconsView.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.ViewToggleButton_ToggleStateChanged);
            // 
            // cbtb_DetailsView
            // 
            this.cbtb_DetailsView.AccessibleDescription = "commandBarToggleButton6";
            this.cbtb_DetailsView.AccessibleName = "commandBarToggleButton6";
            this.cbtb_DetailsView.DisplayName = "commandBarToggleButton6";
            this.cbtb_DetailsView.Image = ((System.Drawing.Image)(resources.GetObject("cbtb_DetailsView.Image")));
            this.cbtb_DetailsView.Name = "cbtb_DetailsView";
            this.cbtb_DetailsView.Text = "";
            this.cbtb_DetailsView.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.cbtb_DetailsView.ToolTipText = "DetailsView";
            this.cbtb_DetailsView.ToggleStateChanging += new Telerik.WinControls.UI.StateChangingEventHandler(this.ViewToggleButton_ToggleStateChanging);
            this.cbtb_DetailsView.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.ViewToggleButton_ToggleStateChanged);
            // 
            // commandBarRowElement2
            // 
            this.commandBarRowElement2.MinSize = new System.Drawing.Size(25, 25);
            this.commandBarRowElement2.Name = "commandBarRowElement2";
            // 
            // commandBarStripElement4
            // 
            this.commandBarStripElement4.DisplayName = "commandBarStripElement1";
            this.commandBarStripElement4.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.commandBarLabel4,
            this.commandBarDropDownSort,
            this.commandBarSeparator1,
            this.commandBarDropDownGroup,
            this.commandBarSeparator2,
            this.commandBarToggleList,
            this.commandBarToggleTiles,
            this.commandBarToggleDetails,
            this.commandBarSeparator3,
            this.commandBarLabel1,
            this.commandBarTextBoxFilter});
            this.commandBarStripElement4.Name = "commandBarStripElement1";
            this.commandBarStripElement4.Text = "";
            // 
            // commandBarLabel4
            // 
            this.commandBarLabel4.DisplayName = "commandBarLabel1";
            this.commandBarLabel4.Name = "commandBarLabel4";
            this.commandBarLabel4.Text = "مرتب سازی براساس";
            // 
            // commandBarDropDownSort
            // 
            this.commandBarDropDownSort.DropDownAnimationEnabled = true;
            radListDataItem1.Text = "نام محصول";
            radListDataItem2.Text = "طبقه محصول";
            this.commandBarDropDownSort.Items.Add(radListDataItem1);
            this.commandBarDropDownSort.Items.Add(radListDataItem2);
            this.commandBarDropDownSort.MaxDropDownItems = 0;
            this.commandBarDropDownSort.Name = "commandBarDropDownSort";
            this.commandBarDropDownSort.ShowHorizontalLine = false;
            this.commandBarDropDownSort.Text = "";
            // 
            // commandBarSeparator1
            // 
            this.commandBarSeparator1.AccessibleDescription = "commandBarSeparator1";
            this.commandBarSeparator1.AccessibleName = "commandBarSeparator1";
            this.commandBarSeparator1.DisplayName = "commandBarSeparator1";
            this.commandBarSeparator1.Name = "commandBarSeparator1";
            this.commandBarSeparator1.VisibleInOverflowMenu = false;
            // 
            // commandBarDropDownGroup
            // 
            this.commandBarDropDownGroup.DropDownAnimationEnabled = true;
            radListDataItem3.Text = "None";
            radListDataItem4.Text = "طبقه محصول";
            this.commandBarDropDownGroup.Items.Add(radListDataItem3);
            this.commandBarDropDownGroup.Items.Add(radListDataItem4);
            this.commandBarDropDownGroup.MaxDropDownItems = 0;
            this.commandBarDropDownGroup.Name = "commandBarDropDownGroup";
            this.commandBarDropDownGroup.Text = "";
            // 
            // commandBarSeparator2
            // 
            this.commandBarSeparator2.AccessibleDescription = "commandBarSeparator2";
            this.commandBarSeparator2.AccessibleName = "commandBarSeparator2";
            this.commandBarSeparator2.DisplayName = "commandBarSeparator2";
            this.commandBarSeparator2.Name = "commandBarSeparator2";
            this.commandBarSeparator2.VisibleInOverflowMenu = false;
            // 
            // commandBarToggleList
            // 
            this.commandBarToggleList.AccessibleDescription = "commandBarToggleButton1";
            this.commandBarToggleList.AccessibleName = "commandBarToggleButton1";
            this.commandBarToggleList.AutoSize = true;
            this.commandBarToggleList.Image = ((System.Drawing.Image)(resources.GetObject("commandBarToggleList.Image")));
            this.commandBarToggleList.Name = "commandBarToggleList";
            this.commandBarToggleList.Text = "";
            this.commandBarToggleList.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.commandBarToggleList.ToolTipText = "ListView";
            // 
            // commandBarToggleTiles
            // 
            this.commandBarToggleTiles.CanFocus = true;
            this.commandBarToggleTiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.commandBarToggleTiles.DrawText = false;
            this.commandBarToggleTiles.Image = ((System.Drawing.Image)(resources.GetObject("commandBarToggleTiles.Image")));
            this.commandBarToggleTiles.Name = "commandBarToggleTiles";
            this.commandBarToggleTiles.ShouldPaint = true;
            this.commandBarToggleTiles.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.commandBarToggleTiles.Text = "";
            this.commandBarToggleTiles.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.commandBarToggleTiles.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.commandBarToggleTiles.ToolTipText = "IconsView";
            // 
            // commandBarToggleDetails
            // 
            this.commandBarToggleDetails.Image = ((System.Drawing.Image)(resources.GetObject("commandBarToggleDetails.Image")));
            this.commandBarToggleDetails.Name = "commandBarToggleDetails";
            this.commandBarToggleDetails.Text = "";
            this.commandBarToggleDetails.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.commandBarToggleDetails.ToolTipText = "DetailsView";
            // 
            // commandBarSeparator3
            // 
            this.commandBarSeparator3.AccessibleDescription = "commandBarSeparator3";
            this.commandBarSeparator3.AccessibleName = "commandBarSeparator3";
            this.commandBarSeparator3.DisplayName = "commandBarSeparator3";
            this.commandBarSeparator3.Name = "commandBarSeparator3";
            this.commandBarSeparator3.VisibleInOverflowMenu = false;
            // 
            // commandBarLabel1
            // 
            this.commandBarLabel1.DisplayName = "commandBarLabel1";
            this.commandBarLabel1.Name = "commandBarLabel1";
            this.commandBarLabel1.Text = "جستجو";
            // 
            // commandBarTextBoxFilter
            // 
            this.commandBarTextBoxFilter.AutoSize = false;
            this.commandBarTextBoxFilter.Bounds = new System.Drawing.Rectangle(0, 0, 200, 23);
            this.commandBarTextBoxFilter.DisplayName = "commandBarTextBox1";
            this.commandBarTextBoxFilter.Name = "commandBarTextBoxFilter";
            this.commandBarTextBoxFilter.Text = "";
            // 
            // commandBarRowElement3
            // 
            this.commandBarRowElement3.MinSize = new System.Drawing.Size(25, 25);
            this.commandBarRowElement3.Name = "commandBarRowElement3";
            this.commandBarRowElement3.Text = "";
            // 
            // rlv_ArticleGroup
            // 
            this.rlv_ArticleGroup.AllowEdit = false;
            this.rlv_ArticleGroup.AllowRemove = false;
            this.rlv_ArticleGroup.AutoScroll = true;
            this.rlv_ArticleGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rlv_ArticleGroup.EnableColumnSort = true;
            this.rlv_ArticleGroup.EnableLassoSelection = true;
            this.rlv_ArticleGroup.EnableSorting = true;
            this.rlv_ArticleGroup.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rlv_ArticleGroup.FullRowSelect = false;
            this.rlv_ArticleGroup.GroupIndent = 29;
            this.rlv_ArticleGroup.GroupItemSize = new System.Drawing.Size(233, 22);
            this.rlv_ArticleGroup.HeaderHeight = 37.69231F;
            this.rlv_ArticleGroup.ImageList = this.imageList1;
            this.rlv_ArticleGroup.ItemSize = new System.Drawing.Size(75, 69);
            this.rlv_ArticleGroup.Location = new System.Drawing.Point(0, 198);
            this.rlv_ArticleGroup.Name = "rlv_ArticleGroup";
            this.rlv_ArticleGroup.ShowGridLines = true;
            this.rlv_ArticleGroup.Size = new System.Drawing.Size(1025, 560);
            this.rlv_ArticleGroup.TabIndex = 2;
            this.rlv_ArticleGroup.ViewType = Telerik.WinControls.UI.ListViewType.IconsView;
            this.rlv_ArticleGroup.ViewTypeChanged += new System.EventHandler(this.rlv_ArticleGroup_ViewTypeChanged);
            this.rlv_ArticleGroup.ItemMouseClick += new Telerik.WinControls.UI.ListViewItemEventHandler(this.rlv_ArticleGroup_ItemMouseClick);
            this.rlv_ArticleGroup.ItemDataBound += new Telerik.WinControls.UI.ListViewItemEventHandler(this.rlv_ArticleGroup_ItemDataBound);
            this.rlv_ArticleGroup.CurrentItemChanged += new Telerik.WinControls.UI.ListViewItemEventHandler(this.rlv_ArticleGroup_CurrentItemChanged);
            this.rlv_ArticleGroup.ColumnCreating += new Telerik.WinControls.UI.ListViewColumnCreatingEventHandler(this.rlv_ArticleGroup_ColumnCreating);
            this.rlv_ArticleGroup.Click += new System.EventHandler(this.rlv_ArticleGroup_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ArticleGroup.png");
            // 
            // FrmArticleGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 758);
            this.Controls.Add(this.rlv_ArticleGroup);
            this.Controls.Add(this.rcb_Search);
            this.Controls.Add(this.pnl_Action);
            this.Controls.Add(this.pnl_Data);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "FrmArticleGroup";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "فرم جزئیات گروه کالا";
            this.Controls.SetChildIndex(this.pnl_Data, 0);
            this.Controls.SetChildIndex(this.pnl_Action, 0);
            this.Controls.SetChildIndex(this.rcb_Search, 0);
            this.Controls.SetChildIndex(this.rlv_ArticleGroup, 0);
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).EndInit();
            this.pnl_Data.ResumeLayout(false);
            this.pnl_Data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rddl_ArticleGroupStatus)).EndInit();
            this.pnl_Action.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rcb_Search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlv_ArticleGroup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Data;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_Action;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txt_ArticleGroupName;
        private System.Windows.Forms.TextBox txt_ArticleGroupDescription;
        private System.Windows.Forms.TextBox txt_ArticleGroupLatinName;
        private Telerik.WinControls.UI.RadCommandBar rcb_Search;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement1;
        private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement2;
        private Telerik.WinControls.UI.CommandBarLabel commandBarLabel2;
        private Telerik.WinControls.UI.CommandBarTextBox ctb_Search;
        private Telerik.WinControls.UI.CommandBarToggleButton cbtb_ListView;
        private Telerik.WinControls.UI.CommandBarToggleButton cbtb_IconsView;
        private Telerik.WinControls.UI.CommandBarToggleButton cbtb_DetailsView;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement2;
        private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement4;
        private Telerik.WinControls.UI.CommandBarLabel commandBarLabel4;
        private Telerik.WinControls.UI.CommandBarDropDownList commandBarDropDownSort;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator1;
        private Telerik.WinControls.UI.CommandBarDropDownList commandBarDropDownGroup;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator2;
        private Telerik.WinControls.UI.CommandBarToggleButton commandBarToggleList;
        private Telerik.WinControls.UI.CommandBarToggleButton commandBarToggleTiles;
        private Telerik.WinControls.UI.CommandBarToggleButton commandBarToggleDetails;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator3;
        private Telerik.WinControls.UI.CommandBarLabel commandBarLabel1;
        private Telerik.WinControls.UI.CommandBarTextBox commandBarTextBoxFilter;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement3;
        private Telerik.WinControls.UI.RadListView rlv_ArticleGroup;
        private System.Windows.Forms.ImageList imageList1;
        private Telerik.WinControls.UI.RadDropDownList rddl_ArticleGroupStatus;
    }
}