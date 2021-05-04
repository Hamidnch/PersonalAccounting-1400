namespace PersonalAccounting.UI
{
    partial class FrmArticle
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
            AFrmArticle = null;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArticle));
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor2 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.pnl_Action = new System.Windows.Forms.Panel();
            this._picLoading = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.pnl_Data = new System.Windows.Forms.Panel();
            this.rddl_ArticleStatus = new Telerik.WinControls.UI.RadDropDownList();
            this.rb_MeasurementUnitAdd = new Telerik.WinControls.UI.RadButton();
            this.racb_MeasurementUnits = new Telerik.WinControls.UI.RadAutoCompleteBox();
            this.lbl_TitleID = new System.Windows.Forms.Label();
            this.txt_ArticleId = new System.Windows.Forms.TextBox();
            this.txt_ArticleDescription = new System.Windows.Forms.TextBox();
            this.txt_ArticleLatinName = new System.Windows.Forms.TextBox();
            this.txt_ArticleName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radSplitContainer1 = new Telerik.WinControls.UI.RadSplitContainer();
            this.splitPanel1 = new Telerik.WinControls.UI.SplitPanel();
            this.rlv_Article = new Telerik.WinControls.UI.RadListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.radCommandBar1 = new Telerik.WinControls.UI.RadCommandBar();
            this.commandBarRowElement1 = new Telerik.WinControls.UI.CommandBarRowElement();
            this.commandBarStripElement1 = new Telerik.WinControls.UI.CommandBarStripElement();
            this.commandBarLabel1 = new Telerik.WinControls.UI.CommandBarLabel();
            this.cbtb_Search = new Telerik.WinControls.UI.CommandBarTextBox();
            this.cbtb_ListView = new Telerik.WinControls.UI.CommandBarToggleButton();
            this.cbtb_IconsView = new Telerik.WinControls.UI.CommandBarToggleButton();
            this.cbtb_DetailsView = new Telerik.WinControls.UI.CommandBarToggleButton();
            this.splitPanel2 = new Telerik.WinControls.UI.SplitPanel();
            this.rgv_ArticleGroup = new Telerik.WinControls.UI.RadGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ArticleGroupReload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).BeginInit();
            this.pnl_Action.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._picLoading)).BeginInit();
            this.pnl_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rddl_ArticleStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rb_MeasurementUnitAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racb_MeasurementUnits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).BeginInit();
            this.radSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).BeginInit();
            this.splitPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rlv_Article)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).BeginInit();
            this.splitPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_ArticleGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_ArticleGroup.MasterTemplate)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Action
            // 
            this.pnl_Action.AutoSize = true;
            this.pnl_Action.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.pnl_Action.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Action.Controls.Add(this._picLoading);
            this.pnl_Action.Controls.Add(this.btnClose);
            this.pnl_Action.Controls.Add(this.btnCancel);
            this.pnl_Action.Controls.Add(this.btnDelete);
            this.pnl_Action.Controls.Add(this.btnModify);
            this.pnl_Action.Controls.Add(this.btnRegister);
            this.pnl_Action.Controls.Add(this.btnInsert);
            this.pnl_Action.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Action.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.pnl_Action.Location = new System.Drawing.Point(0, 122);
            this.pnl_Action.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_Action.Name = "pnl_Action";
            this.pnl_Action.Size = new System.Drawing.Size(907, 39);
            this.pnl_Action.TabIndex = 28;
            // 
            // _picLoading
            // 
            this._picLoading.Image = ((System.Drawing.Image)(resources.GetObject("_picLoading.Image")));
            this._picLoading.Location = new System.Drawing.Point(598, 11);
            this._picLoading.Name = "_picLoading";
            this._picLoading.Size = new System.Drawing.Size(106, 17);
            this._picLoading.TabIndex = 176;
            this._picLoading.TabStop = false;
            this._picLoading.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point(5, 4);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(76, 29);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "بستن";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancel.Enabled = false;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(753, 2);
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
            this.btnDelete.Location = new System.Drawing.Point(783, 2);
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
            this.btnModify.Location = new System.Drawing.Point(813, 2);
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
            this.btnRegister.Location = new System.Drawing.Point(843, 2);
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
            this.btnInsert.Location = new System.Drawing.Point(873, 2);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(31, 31);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // pnl_Data
            // 
            this.pnl_Data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.pnl_Data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Data.Controls.Add(this.rddl_ArticleStatus);
            this.pnl_Data.Controls.Add(this.rb_MeasurementUnitAdd);
            this.pnl_Data.Controls.Add(this.racb_MeasurementUnits);
            this.pnl_Data.Controls.Add(this.lbl_TitleID);
            this.pnl_Data.Controls.Add(this.txt_ArticleId);
            this.pnl_Data.Controls.Add(this.txt_ArticleDescription);
            this.pnl_Data.Controls.Add(this.txt_ArticleLatinName);
            this.pnl_Data.Controls.Add(this.txt_ArticleName);
            this.pnl_Data.Controls.Add(this.label6);
            this.pnl_Data.Controls.Add(this.label9);
            this.pnl_Data.Controls.Add(this.label3);
            this.pnl_Data.Controls.Add(this.label5);
            this.pnl_Data.Controls.Add(this.label1);
            this.pnl_Data.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Data.Enabled = false;
            this.pnl_Data.Location = new System.Drawing.Point(0, 27);
            this.pnl_Data.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_Data.Name = "pnl_Data";
            this.pnl_Data.Size = new System.Drawing.Size(907, 95);
            this.pnl_Data.TabIndex = 27;
            // 
            // rddl_ArticleStatus
            // 
            this.rddl_ArticleStatus.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.rddl_ArticleStatus.Font = new System.Drawing.Font("Tornado Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rddl_ArticleStatus.Location = new System.Drawing.Point(8, 5);
            this.rddl_ArticleStatus.MaxDropDownItems = 10;
            this.rddl_ArticleStatus.Name = "rddl_ArticleStatus";
            this.rddl_ArticleStatus.Size = new System.Drawing.Size(131, 26);
            this.rddl_ArticleStatus.TabIndex = 2;
            this.rddl_ArticleStatus.TextChanged += new System.EventHandler(this.txt_ArticleName_TextChanged);
            // 
            // rb_MeasurementUnitAdd
            // 
            this.rb_MeasurementUnitAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rb_MeasurementUnitAdd.Location = new System.Drawing.Point(425, 34);
            this.rb_MeasurementUnitAdd.Name = "rb_MeasurementUnitAdd";
            this.rb_MeasurementUnitAdd.Size = new System.Drawing.Size(35, 54);
            this.rb_MeasurementUnitAdd.TabIndex = 3;
            this.rb_MeasurementUnitAdd.Text = "...";
            this.rb_MeasurementUnitAdd.Click += new System.EventHandler(this.rb_MeasurementUnitAdd_Click);
            // 
            // racb_MeasurementUnits
            // 
            this.racb_MeasurementUnits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.racb_MeasurementUnits.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.racb_MeasurementUnits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.racb_MeasurementUnits.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.racb_MeasurementUnits.ForeColor = System.Drawing.Color.Blue;
            this.racb_MeasurementUnits.IsReadOnly = true;
            this.racb_MeasurementUnits.IsReadOnlyCaretVisible = true;
            this.racb_MeasurementUnits.Location = new System.Drawing.Point(461, 34);
            this.racb_MeasurementUnits.Multiline = true;
            this.racb_MeasurementUnits.Name = "racb_MeasurementUnits";
            this.racb_MeasurementUnits.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.racb_MeasurementUnits.Size = new System.Drawing.Size(372, 54);
            this.racb_MeasurementUnits.TabIndex = 137;
            this.racb_MeasurementUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.racb_MeasurementUnits.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_ArticleName_KeyDown);
            // 
            // lbl_TitleID
            // 
            this.lbl_TitleID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_TitleID.AutoSize = true;
            this.lbl_TitleID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_TitleID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_TitleID.Location = new System.Drawing.Point(836, 10);
            this.lbl_TitleID.Name = "lbl_TitleID";
            this.lbl_TitleID.Size = new System.Drawing.Size(84, 17);
            this.lbl_TitleID.TabIndex = 136;
            this.lbl_TitleID.Text = "شناسه كالا";
            // 
            // txt_ArticleId
            // 
            this.txt_ArticleId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ArticleId.Location = new System.Drawing.Point(767, 6);
            this.txt_ArticleId.Name = "txt_ArticleId";
            this.txt_ArticleId.ReadOnly = true;
            this.txt_ArticleId.Size = new System.Drawing.Size(66, 24);
            this.txt_ArticleId.TabIndex = 135;
            this.txt_ArticleId.TabStop = false;
            // 
            // txt_ArticleDescription
            // 
            this.txt_ArticleDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ArticleDescription.BackColor = System.Drawing.Color.FloralWhite;
            this.txt_ArticleDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ArticleDescription.Location = new System.Drawing.Point(8, 34);
            this.txt_ArticleDescription.Multiline = true;
            this.txt_ArticleDescription.Name = "txt_ArticleDescription";
            this.txt_ArticleDescription.Size = new System.Drawing.Size(360, 53);
            this.txt_ArticleDescription.TabIndex = 4;
            this.txt_ArticleDescription.TextChanged += new System.EventHandler(this.txt_ArticleName_TextChanged);
            this.txt_ArticleDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_ArticleName_KeyDown);
            // 
            // txt_ArticleLatinName
            // 
            this.txt_ArticleLatinName.BackColor = System.Drawing.Color.FloralWhite;
            this.txt_ArticleLatinName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ArticleLatinName.Location = new System.Drawing.Point(203, 6);
            this.txt_ArticleLatinName.Name = "txt_ArticleLatinName";
            this.txt_ArticleLatinName.Size = new System.Drawing.Size(189, 24);
            this.txt_ArticleLatinName.TabIndex = 1;
            this.txt_ArticleLatinName.TextChanged += new System.EventHandler(this.txt_ArticleName_TextChanged);
            this.txt_ArticleLatinName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_ArticleName_KeyDown);
            // 
            // txt_ArticleName
            // 
            this.txt_ArticleName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ArticleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ArticleName.Location = new System.Drawing.Point(461, 6);
            this.txt_ArticleName.Name = "txt_ArticleName";
            this.txt_ArticleName.Size = new System.Drawing.Size(256, 24);
            this.txt_ArticleName.TabIndex = 0;
            this.txt_ArticleName.TextChanged += new System.EventHandler(this.txt_ArticleName_TextChanged);
            this.txt_ArticleName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_ArticleName_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(145, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 18);
            this.label6.TabIndex = 131;
            this.label6.Text = "وضعیت";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(372, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 17);
            this.label9.TabIndex = 125;
            this.label9.Text = "توضیحات";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(398, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 123;
            this.label3.Text = "نام لاتین";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(838, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 123;
            this.label5.Text = "واحد سنجش";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(721, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 123;
            this.label1.Text = "نام کالا";
            // 
            // radSplitContainer1
            // 
            this.radSplitContainer1.Controls.Add(this.splitPanel1);
            this.radSplitContainer1.Controls.Add(this.splitPanel2);
            this.radSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radSplitContainer1.Location = new System.Drawing.Point(0, 161);
            this.radSplitContainer1.Name = "radSplitContainer1";
            // 
            // 
            // 
            this.radSplitContainer1.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.radSplitContainer1.Size = new System.Drawing.Size(907, 492);
            this.radSplitContainer1.TabIndex = 29;
            this.radSplitContainer1.TabStop = false;
            // 
            // splitPanel1
            // 
            this.splitPanel1.Controls.Add(this.rlv_Article);
            this.splitPanel1.Controls.Add(this.radCommandBar1);
            this.splitPanel1.Location = new System.Drawing.Point(0, 0);
            this.splitPanel1.Name = "splitPanel1";
            // 
            // 
            // 
            this.splitPanel1.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.splitPanel1.Size = new System.Drawing.Size(614, 492);
            this.splitPanel1.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0.1799557F, 0F);
            this.splitPanel1.SizeInfo.SplitterCorrection = new System.Drawing.Size(160, 0);
            this.splitPanel1.TabIndex = 0;
            this.splitPanel1.TabStop = false;
            // 
            // rlv_Article
            // 
            this.rlv_Article.AllowEdit = false;
            this.rlv_Article.AllowRemove = false;
            this.rlv_Article.AutoScroll = true;
            this.rlv_Article.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rlv_Article.EnableColumnSort = true;
            this.rlv_Article.EnableKeyMap = true;
            this.rlv_Article.EnableLassoSelection = true;
            this.rlv_Article.EnableSorting = true;
            this.rlv_Article.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rlv_Article.FullRowSelect = false;
            this.rlv_Article.ImageList = this.imageList1;
            this.rlv_Article.ItemSize = new System.Drawing.Size(64, 64);
            this.rlv_Article.Location = new System.Drawing.Point(0, 30);
            this.rlv_Article.Name = "rlv_Article";
            this.rlv_Article.Padding = new System.Windows.Forms.Padding(10);
            this.rlv_Article.ShowGridLines = true;
            this.rlv_Article.Size = new System.Drawing.Size(614, 462);
            this.rlv_Article.TabIndex = 30;
            this.rlv_Article.ViewType = Telerik.WinControls.UI.ListViewType.IconsView;
            this.rlv_Article.ViewTypeChanged += new System.EventHandler(this.rlv_Article_ViewTypeChanged);
            this.rlv_Article.ItemMouseClick += new Telerik.WinControls.UI.ListViewItemEventHandler(this.rlv_Article_ItemMouseClick);
            this.rlv_Article.VisualItemFormatting += new Telerik.WinControls.UI.ListViewVisualItemEventHandler(this.rlv_Article_VisualItemFormatting);
            this.rlv_Article.CellFormatting += new Telerik.WinControls.UI.ListViewCellFormattingEventHandler(this.rlv_Article_CellFormatting);
            this.rlv_Article.ItemDataBound += new Telerik.WinControls.UI.ListViewItemEventHandler(this.rlv_Article_ItemDataBound);
            this.rlv_Article.CurrentItemChanged += new Telerik.WinControls.UI.ListViewItemEventHandler(this.rlv_Article_CurrentItemChanged);
            this.rlv_Article.ColumnCreating += new Telerik.WinControls.UI.ListViewColumnCreatingEventHandler(this.rlv_Article_ColumnCreating);
            this.rlv_Article.Click += new System.EventHandler(this.rlv_Article_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "32.png");
            // 
            // radCommandBar1
            // 
            this.radCommandBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radCommandBar1.Location = new System.Drawing.Point(0, 0);
            this.radCommandBar1.Name = "radCommandBar1";
            this.radCommandBar1.Rows.AddRange(new Telerik.WinControls.UI.CommandBarRowElement[] {
            this.commandBarRowElement1});
            this.radCommandBar1.Size = new System.Drawing.Size(614, 30);
            this.radCommandBar1.TabIndex = 31;
            // 
            // commandBarRowElement1
            // 
            this.commandBarRowElement1.MinSize = new System.Drawing.Size(25, 25);
            this.commandBarRowElement1.Name = "commandBarRowElement1";
            this.commandBarRowElement1.Strips.AddRange(new Telerik.WinControls.UI.CommandBarStripElement[] {
            this.commandBarStripElement1});
            // 
            // commandBarStripElement1
            // 
            this.commandBarStripElement1.DisplayName = "commandBarStripElement1";
            this.commandBarStripElement1.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.commandBarLabel1,
            this.cbtb_Search,
            this.cbtb_ListView,
            this.cbtb_IconsView,
            this.cbtb_DetailsView});
            this.commandBarStripElement1.Name = "commandBarStripElement1";
            // 
            // commandBarLabel1
            // 
            this.commandBarLabel1.DisplayName = "commandBarLabel1";
            this.commandBarLabel1.Name = "commandBarLabel1";
            this.commandBarLabel1.Text = "جستجو";
            // 
            // cbtb_Search
            // 
            this.cbtb_Search.AutoSize = false;
            this.cbtb_Search.Bounds = new System.Drawing.Rectangle(0, 0, 250, 22);
            this.cbtb_Search.DisplayName = "commandBarTextBox1";
            this.cbtb_Search.Name = "cbtb_Search";
            this.cbtb_Search.Text = "";
            this.cbtb_Search.TextChanged += new System.EventHandler(this.cbtb_Search_TextChanged);
            // 
            // cbtb_ListView
            // 
            this.cbtb_ListView.AccessibleDescription = "commandBarToggleButton1";
            this.cbtb_ListView.AccessibleName = "commandBarToggleButton1";
            this.cbtb_ListView.DisplayName = "commandBarToggleButton1";
            this.cbtb_ListView.Image = ((System.Drawing.Image)(resources.GetObject("cbtb_ListView.Image")));
            this.cbtb_ListView.Name = "cbtb_ListView";
            this.cbtb_ListView.Text = "";
            this.cbtb_ListView.ToggleStateChanging += new Telerik.WinControls.UI.StateChangingEventHandler(this.commandBarToggleButton1_ToggleStateChanging);
            this.cbtb_ListView.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.ViewToggleButton_ToggleStateChanged);
            // 
            // cbtb_IconsView
            // 
            this.cbtb_IconsView.AccessibleDescription = "commandBarToggleButton2";
            this.cbtb_IconsView.AccessibleName = "commandBarToggleButton2";
            this.cbtb_IconsView.DisplayName = "commandBarToggleButton2";
            this.cbtb_IconsView.Image = ((System.Drawing.Image)(resources.GetObject("cbtb_IconsView.Image")));
            this.cbtb_IconsView.Name = "cbtb_IconsView";
            this.cbtb_IconsView.Text = "";
            this.cbtb_IconsView.ToggleStateChanging += new Telerik.WinControls.UI.StateChangingEventHandler(this.commandBarToggleButton1_ToggleStateChanging);
            this.cbtb_IconsView.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.ViewToggleButton_ToggleStateChanged);
            // 
            // cbtb_DetailsView
            // 
            this.cbtb_DetailsView.AccessibleDescription = "commandBarToggleButton3";
            this.cbtb_DetailsView.AccessibleName = "commandBarToggleButton3";
            this.cbtb_DetailsView.DisplayName = "commandBarToggleButton3";
            this.cbtb_DetailsView.Image = ((System.Drawing.Image)(resources.GetObject("cbtb_DetailsView.Image")));
            this.cbtb_DetailsView.Name = "cbtb_DetailsView";
            this.cbtb_DetailsView.Text = "";
            this.cbtb_DetailsView.ToggleStateChanging += new Telerik.WinControls.UI.StateChangingEventHandler(this.commandBarToggleButton1_ToggleStateChanging);
            this.cbtb_DetailsView.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.ViewToggleButton_ToggleStateChanged);
            // 
            // splitPanel2
            // 
            this.splitPanel2.Controls.Add(this.rgv_ArticleGroup);
            this.splitPanel2.Controls.Add(this.panel1);
            this.splitPanel2.Location = new System.Drawing.Point(618, 0);
            this.splitPanel2.Name = "splitPanel2";
            // 
            // 
            // 
            this.splitPanel2.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.splitPanel2.Size = new System.Drawing.Size(289, 492);
            this.splitPanel2.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(-0.1799557F, 0F);
            this.splitPanel2.SizeInfo.SplitterCorrection = new System.Drawing.Size(-160, 0);
            this.splitPanel2.TabIndex = 1;
            this.splitPanel2.TabStop = false;
            // 
            // rgv_ArticleGroup
            // 
            this.rgv_ArticleGroup.AutoScroll = true;
            this.rgv_ArticleGroup.BackColor = System.Drawing.SystemColors.Control;
            this.rgv_ArticleGroup.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_ArticleGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rgv_ArticleGroup.EnableHotTracking = false;
            this.rgv_ArticleGroup.EnterKeyMode = Telerik.WinControls.UI.RadGridViewEnterKeyMode.EnterMovesToNextRow;
            this.rgv_ArticleGroup.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.rgv_ArticleGroup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgv_ArticleGroup.GroupExpandAnimationType = Telerik.WinControls.UI.GridExpandAnimationType.Slide;
            this.rgv_ArticleGroup.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_ArticleGroup.Location = new System.Drawing.Point(0, 38);
            this.rgv_ArticleGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // 
            // 
            this.rgv_ArticleGroup.MasterTemplate.AllowAddNewRow = false;
            this.rgv_ArticleGroup.MasterTemplate.AllowCellContextMenu = false;
            this.rgv_ArticleGroup.MasterTemplate.AllowDeleteRow = false;
            this.rgv_ArticleGroup.MasterTemplate.AllowEditRow = false;
            this.rgv_ArticleGroup.MasterTemplate.AllowRowResize = false;
            this.rgv_ArticleGroup.MasterTemplate.AutoExpandGroups = true;
            this.rgv_ArticleGroup.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "ArticleGroupId";
            gridViewTextBoxColumn3.HeaderText = "شناسه";
            gridViewTextBoxColumn3.Name = "ArticleGroupId";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn3.Width = 70;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "ArticleGroupName";
            gridViewTextBoxColumn4.HeaderText = "نام گروه";
            gridViewTextBoxColumn4.Name = "ArticleGroupName";
            gridViewTextBoxColumn4.ReadOnly = true;
            gridViewTextBoxColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn4.Width = 198;
            this.rgv_ArticleGroup.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.rgv_ArticleGroup.MasterTemplate.EnableAlternatingRowColor = true;
            this.rgv_ArticleGroup.MasterTemplate.EnableFiltering = true;
            this.rgv_ArticleGroup.MasterTemplate.EnableGrouping = false;
            this.rgv_ArticleGroup.MasterTemplate.ReadOnly = true;
            this.rgv_ArticleGroup.MasterTemplate.ShowGroupedColumns = true;
            sortDescriptor2.PropertyName = "column1";
            this.rgv_ArticleGroup.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor2});
            this.rgv_ArticleGroup.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.rgv_ArticleGroup.Name = "rgv_ArticleGroup";
            this.rgv_ArticleGroup.ReadOnly = true;
            this.rgv_ArticleGroup.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rgv_ArticleGroup.Size = new System.Drawing.Size(289, 454);
            this.rgv_ArticleGroup.TabIndex = 1;
            this.rgv_ArticleGroup.CurrentRowChanged += new Telerik.WinControls.UI.CurrentRowChangedEventHandler(this.rgv_ArticleGroup_CurrentRowChanged);
            this.rgv_ArticleGroup.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.rgv_ArticleGroup_CellClick);
            this.rgv_ArticleGroup.TextChanged += new System.EventHandler(this.txt_ArticleName_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.panel1.Controls.Add(this.btn_ArticleGroupReload);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 38);
            this.panel1.TabIndex = 2;
            // 
            // btn_ArticleGroupReload
            // 
            this.btn_ArticleGroupReload.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ArticleGroupReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.btn_ArticleGroupReload.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btn_ArticleGroupReload.FlatAppearance.BorderSize = 2;
            this.btn_ArticleGroupReload.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ArticleGroupReload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.btn_ArticleGroupReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ArticleGroupReload.Font = new System.Drawing.Font("Tornado Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_ArticleGroupReload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ArticleGroupReload.Location = new System.Drawing.Point(99, 4);
            this.btn_ArticleGroupReload.Name = "btn_ArticleGroupReload";
            this.btn_ArticleGroupReload.Size = new System.Drawing.Size(100, 29);
            this.btn_ArticleGroupReload.TabIndex = 1;
            this.btn_ArticleGroupReload.Text = "بارگذاری مجدد";
            this.btn_ArticleGroupReload.UseVisualStyleBackColor = false;
            this.btn_ArticleGroupReload.Click += new System.EventHandler(this.Btn_ArticleGroupReload_Click);
            // 
            // FrmArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 653);
            this.Controls.Add(this.radSplitContainer1);
            this.Controls.Add(this.pnl_Action);
            this.Controls.Add(this.pnl_Data);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.KeyPreview = true;
            this.Name = "FrmArticle";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "فرم جزئیات کالا";
            this.Load += new System.EventHandler(this.FrmArticle_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmArticle_KeyDown);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.FrmArticle_PreviewKeyDown);
            this.Controls.SetChildIndex(this.pnl_Data, 0);
            this.Controls.SetChildIndex(this.pnl_Action, 0);
            this.Controls.SetChildIndex(this.radSplitContainer1, 0);
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).EndInit();
            this.pnl_Action.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._picLoading)).EndInit();
            this.pnl_Data.ResumeLayout(false);
            this.pnl_Data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rddl_ArticleStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rb_MeasurementUnitAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racb_MeasurementUnits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).EndInit();
            this.radSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).EndInit();
            this.splitPanel1.ResumeLayout(false);
            this.splitPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rlv_Article)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).EndInit();
            this.splitPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgv_ArticleGroup.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_ArticleGroup)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Action;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Panel pnl_Data;
        private System.Windows.Forms.TextBox txt_ArticleDescription;
        private System.Windows.Forms.TextBox txt_ArticleLatinName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private Telerik.WinControls.UI.RadSplitContainer radSplitContainer1;
        private Telerik.WinControls.UI.SplitPanel splitPanel1;
        private Telerik.WinControls.UI.SplitPanel splitPanel2;
        private Telerik.WinControls.UI.RadListView rlv_Article;
        private Telerik.WinControls.UI.RadCommandBar radCommandBar1;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement1;
        private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement1;
        private Telerik.WinControls.UI.CommandBarLabel commandBarLabel1;
        private Telerik.WinControls.UI.CommandBarTextBox cbtb_Search;
        private Telerik.WinControls.UI.CommandBarToggleButton cbtb_ListView;
        private Telerik.WinControls.UI.CommandBarToggleButton cbtb_IconsView;
        private Telerik.WinControls.UI.CommandBarToggleButton cbtb_DetailsView;
        private System.Windows.Forms.Label lbl_TitleID;
        private System.Windows.Forms.TextBox txt_ArticleId;
        private System.Windows.Forms.ImageList imageList1;
        private Telerik.WinControls.UI.RadAutoCompleteBox racb_MeasurementUnits;
        private System.Windows.Forms.Label label5;
        private Telerik.WinControls.UI.RadButton rb_MeasurementUnitAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ArticleName;
        private System.Windows.Forms.PictureBox _picLoading;
        private Telerik.WinControls.UI.RadGridView rgv_ArticleGroup;
        private System.Windows.Forms.Button btn_ArticleGroupReload;
        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.RadDropDownList rddl_ArticleStatus;
    }
}