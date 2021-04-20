namespace PersonalAccounting.UI
{
    partial class FrmPerson
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
            AFrmPerson = null;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPerson));
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.pnl_Action = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txt_PersonDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_Data = new System.Windows.Forms.Panel();
            this.ddl_PersonSex = new Telerik.WinControls.UI.RadDropDownList();
            this.ddl_PersonStatus = new Telerik.WinControls.UI.RadDropDownList();
            this.txt_PersonFullName = new Telerik.WinControls.UI.RadTextBox();
            this.pic_PersonPicture = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rgv_Person = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).BeginInit();
            this.pnl_Action.SuspendLayout();
            this.pnl_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddl_PersonSex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddl_PersonStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PersonFullName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_PersonPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_Person)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_Person.MasterTemplate)).BeginInit();
            this.SuspendLayout();
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
            this.pnl_Action.Location = new System.Drawing.Point(0, 122);
            this.pnl_Action.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_Action.Name = "pnl_Action";
            this.pnl_Action.Size = new System.Drawing.Size(886, 39);
            this.pnl_Action.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
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
            this.btnCancel.Location = new System.Drawing.Point(730, 2);
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
            this.btnDelete.Location = new System.Drawing.Point(760, 2);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(31, 31);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModify.BackColor = System.Drawing.Color.White;
            this.btnModify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnModify.Enabled = false;
            this.btnModify.Image = ((System.Drawing.Image)(resources.GetObject("btnModify.Image")));
            this.btnModify.Location = new System.Drawing.Point(790, 2);
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
            this.btnRegister.Location = new System.Drawing.Point(820, 2);
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
            this.btnInsert.Location = new System.Drawing.Point(850, 2);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(31, 31);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txt_PersonDescription
            // 
            this.txt_PersonDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_PersonDescription.Location = new System.Drawing.Point(99, 40);
            this.txt_PersonDescription.Multiline = true;
            this.txt_PersonDescription.Name = "txt_PersonDescription";
            this.txt_PersonDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_PersonDescription.Size = new System.Drawing.Size(503, 46);
            this.txt_PersonDescription.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(824, 40);
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
            this.label9.Location = new System.Drawing.Point(608, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 125;
            this.label9.Text = "توضیحات";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(812, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 123;
            this.label1.Text = "نام شخص";
            // 
            // pnl_Data
            // 
            this.pnl_Data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.pnl_Data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Data.Controls.Add(this.txt_PersonDescription);
            this.pnl_Data.Controls.Add(this.ddl_PersonSex);
            this.pnl_Data.Controls.Add(this.ddl_PersonStatus);
            this.pnl_Data.Controls.Add(this.txt_PersonFullName);
            this.pnl_Data.Controls.Add(this.pic_PersonPicture);
            this.pnl_Data.Controls.Add(this.label3);
            this.pnl_Data.Controls.Add(this.label6);
            this.pnl_Data.Controls.Add(this.label9);
            this.pnl_Data.Controls.Add(this.label1);
            this.pnl_Data.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Data.Enabled = false;
            this.pnl_Data.Location = new System.Drawing.Point(0, 27);
            this.pnl_Data.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_Data.Name = "pnl_Data";
            this.pnl_Data.Size = new System.Drawing.Size(886, 95);
            this.pnl_Data.TabIndex = 1;
            // 
            // ddl_PersonSex
            // 
            this.ddl_PersonSex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ddl_PersonSex.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ddl_PersonSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            radListDataItem1.Font = new System.Drawing.Font("Tornado Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            radListDataItem1.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            radListDataItem1.Text = "مذکر";
            radListDataItem1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            radListDataItem2.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            radListDataItem2.Text = "مونث";
            radListDataItem2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.ddl_PersonSex.Items.Add(radListDataItem1);
            this.ddl_PersonSex.Items.Add(radListDataItem2);
            this.ddl_PersonSex.Location = new System.Drawing.Point(99, 10);
            this.ddl_PersonSex.MaxDropDownItems = 10;
            this.ddl_PersonSex.Name = "ddl_PersonSex";
            this.ddl_PersonSex.Size = new System.Drawing.Size(131, 18);
            this.ddl_PersonSex.TabIndex = 213;
            this.ddl_PersonSex.TextChanged += new System.EventHandler(this.txt_PersonFullName_TextChanged);
            // 
            // ddl_PersonStatus
            // 
            this.ddl_PersonStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ddl_PersonStatus.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ddl_PersonStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ddl_PersonStatus.Location = new System.Drawing.Point(675, 40);
            this.ddl_PersonStatus.MaxDropDownItems = 10;
            this.ddl_PersonStatus.Name = "ddl_PersonStatus";
            this.ddl_PersonStatus.Size = new System.Drawing.Size(131, 18);
            this.ddl_PersonStatus.TabIndex = 212;
            this.ddl_PersonStatus.TextChanged += new System.EventHandler(this.txt_PersonFullName_TextChanged);
            // 
            // txt_PersonFullName
            // 
            this.txt_PersonFullName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_PersonFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_PersonFullName.Location = new System.Drawing.Point(291, 10);
            this.txt_PersonFullName.Name = "txt_PersonFullName";
            this.txt_PersonFullName.Size = new System.Drawing.Size(515, 18);
            this.txt_PersonFullName.TabIndex = 210;
            this.txt_PersonFullName.TextChanged += new System.EventHandler(this.txt_PersonFullName_TextChanged);
            this.txt_PersonFullName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_PersonFullName_KeyDown);
            // 
            // pic_PersonPicture
            // 
            this.pic_PersonPicture.BackColor = System.Drawing.Color.Transparent;
            this.pic_PersonPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_PersonPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_PersonPicture.ErrorImage = null;
            this.pic_PersonPicture.Image = global::PersonalAccounting.UI.Properties.Resources.logo;
            this.pic_PersonPicture.ImageLocation = "";
            this.pic_PersonPicture.Location = new System.Drawing.Point(13, 8);
            this.pic_PersonPicture.Name = "pic_PersonPicture";
            this.pic_PersonPicture.Size = new System.Drawing.Size(80, 75);
            this.pic_PersonPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_PersonPicture.TabIndex = 208;
            this.pic_PersonPicture.TabStop = false;
            this.pic_PersonPicture.Click += new System.EventHandler(this.pic_Person_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(238, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 14);
            this.label3.TabIndex = 131;
            this.label3.Text = "جنسیت";
            // 
            // rgv_Person
            // 
            this.rgv_Person.AutoScroll = true;
            this.rgv_Person.BackColor = System.Drawing.SystemColors.Control;
            this.rgv_Person.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_Person.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rgv_Person.EnableHotTracking = false;
            this.rgv_Person.EnterKeyMode = Telerik.WinControls.UI.RadGridViewEnterKeyMode.EnterMovesToNextRow;
            this.rgv_Person.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rgv_Person.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgv_Person.GroupExpandAnimationType = Telerik.WinControls.UI.GridExpandAnimationType.Slide;
            this.rgv_Person.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_Person.Location = new System.Drawing.Point(0, 161);
            this.rgv_Person.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // 
            // 
            this.rgv_Person.MasterTemplate.AllowAddNewRow = false;
            this.rgv_Person.MasterTemplate.AllowCellContextMenu = false;
            this.rgv_Person.MasterTemplate.AllowDeleteRow = false;
            this.rgv_Person.MasterTemplate.AllowEditRow = false;
            this.rgv_Person.MasterTemplate.AllowRowResize = false;
            this.rgv_Person.MasterTemplate.AutoExpandGroups = true;
            this.rgv_Person.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "PersonId";
            gridViewTextBoxColumn1.HeaderText = "شناسه";
            gridViewTextBoxColumn1.Name = "PersonId";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn1.Width = 85;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "PersonFullName";
            gridViewTextBoxColumn2.HeaderText = "نام شخص";
            gridViewTextBoxColumn2.Name = "PersonFullName";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn2.Width = 159;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "PersonSex";
            gridViewTextBoxColumn3.HeaderText = "جنسیت";
            gridViewTextBoxColumn3.Name = "PersonSex";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn3.Width = 94;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "PersonPersianCreationDate";
            gridViewTextBoxColumn4.HeaderText = "تاریخ ثبت";
            gridViewTextBoxColumn4.Name = "PersonPersianCreationDate";
            gridViewTextBoxColumn4.ReadOnly = true;
            gridViewTextBoxColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn4.Width = 128;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "PersonPersianLastUpdate";
            gridViewTextBoxColumn5.HeaderText = "تاریخ آخرین ویرایش";
            gridViewTextBoxColumn5.Name = "PersonPersianLastUpdate";
            gridViewTextBoxColumn5.ReadOnly = true;
            gridViewTextBoxColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn5.Width = 118;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "PersonCreationUser";
            gridViewTextBoxColumn6.HeaderText = "کاربر ثبت کننده";
            gridViewTextBoxColumn6.Name = "PersonCreationUser";
            gridViewTextBoxColumn6.ReadOnly = true;
            gridViewTextBoxColumn6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn6.Width = 105;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "PersonStatus";
            gridViewTextBoxColumn7.HeaderText = "وضعیت";
            gridViewTextBoxColumn7.Name = "PersonStatus";
            gridViewTextBoxColumn7.ReadOnly = true;
            gridViewTextBoxColumn7.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn7.Width = 90;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "PersonDescription";
            gridViewTextBoxColumn8.HeaderText = "توضیحات";
            gridViewTextBoxColumn8.Name = "PersonDescription";
            gridViewTextBoxColumn8.ReadOnly = true;
            gridViewTextBoxColumn8.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn8.Width = 155;
            gridViewTextBoxColumn9.EnableExpressionEditor = false;
            gridViewTextBoxColumn9.FieldName = "PersonPicture";
            gridViewTextBoxColumn9.HeaderText = "تصویر شخص";
            gridViewTextBoxColumn9.IsVisible = false;
            gridViewTextBoxColumn9.Name = "PersonPicture";
            gridViewTextBoxColumn9.ReadOnly = true;
            gridViewTextBoxColumn9.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.rgv_Person.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9});
            this.rgv_Person.MasterTemplate.EnableAlternatingRowColor = true;
            this.rgv_Person.MasterTemplate.EnableFiltering = true;
            this.rgv_Person.MasterTemplate.ReadOnly = true;
            this.rgv_Person.MasterTemplate.ShowGroupedColumns = true;
            this.rgv_Person.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgv_Person.Name = "rgv_Person";
            this.rgv_Person.ReadOnly = true;
            this.rgv_Person.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rgv_Person.Size = new System.Drawing.Size(886, 499);
            this.rgv_Person.TabIndex = 2;
            this.rgv_Person.CurrentRowChanged += new Telerik.WinControls.UI.CurrentRowChangedEventHandler(this.rgv_Person_CurrentRowChanged);
            this.rgv_Person.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.rgv_Person_CellClick);
            // 
            // FrmPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 660);
            this.Controls.Add(this.rgv_Person);
            this.Controls.Add(this.pnl_Action);
            this.Controls.Add(this.pnl_Data);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmPerson";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "فرم جزئیات اشخاص";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPerson_KeyDown);
            this.Controls.SetChildIndex(this.pnl_Data, 0);
            this.Controls.SetChildIndex(this.pnl_Action, 0);
            this.Controls.SetChildIndex(this.rgv_Person, 0);
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).EndInit();
            this.pnl_Action.ResumeLayout(false);
            this.pnl_Data.ResumeLayout(false);
            this.pnl_Data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddl_PersonSex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddl_PersonStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PersonFullName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_PersonPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_Person.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_Person)).EndInit();
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_Data;
        private Telerik.WinControls.UI.RadGridView rgv_Person;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pic_PersonPicture;
        private System.Windows.Forms.TextBox txt_PersonDescription;
        private Telerik.WinControls.UI.RadTextBox txt_PersonFullName;
        private Telerik.WinControls.UI.RadDropDownList ddl_PersonStatus;
        private Telerik.WinControls.UI.RadDropDownList ddl_PersonSex;
    }
}