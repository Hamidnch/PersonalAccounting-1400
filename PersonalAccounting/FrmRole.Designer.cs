namespace PersonalAccounting.UI
{
    partial class FrmRole
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
            AFrmRole = null;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRole));
            this.rgv_Role = new Telerik.WinControls.UI.RadGridView();
            this.pnl_Action = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.pnl_Data = new System.Windows.Forms.Panel();
            this.rddl_Status = new Telerik.WinControls.UI.RadDropDownList();
            this.txt_Description = new Telerik.WinControls.UI.RadTextBoxControl();
            this.txt_RoleName = new Telerik.WinControls.UI.RadTextBox();
            this.btn_Collapse = new System.Windows.Forms.Button();
            this.btn_UncheckAll = new System.Windows.Forms.Button();
            this.btn_CheckAll = new System.Windows.Forms.Button();
            this.btn_Expand = new System.Windows.Forms.Button();
            this.rtv_Permissions = new Telerik.WinControls.UI.RadTreeView();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_Role)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_Role.MasterTemplate)).BeginInit();
            this.pnl_Action.SuspendLayout();
            this.pnl_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rddl_Status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Description)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_RoleName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtv_Permissions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rgv_Role
            // 
            this.rgv_Role.AutoScroll = true;
            this.rgv_Role.BackColor = System.Drawing.SystemColors.Control;
            this.rgv_Role.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_Role.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rgv_Role.EnableHotTracking = false;
            this.rgv_Role.EnterKeyMode = Telerik.WinControls.UI.RadGridViewEnterKeyMode.EnterMovesToNextRow;
            this.rgv_Role.Font = new System.Drawing.Font("Tornado Tahoma", 8.25F);
            this.rgv_Role.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgv_Role.GroupExpandAnimationType = Telerik.WinControls.UI.GridExpandAnimationType.Slide;
            this.rgv_Role.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_Role.Location = new System.Drawing.Point(0, 0);
            this.rgv_Role.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // 
            // 
            this.rgv_Role.MasterTemplate.AllowAddNewRow = false;
            this.rgv_Role.MasterTemplate.AllowCellContextMenu = false;
            this.rgv_Role.MasterTemplate.AllowDeleteRow = false;
            this.rgv_Role.MasterTemplate.AllowEditRow = false;
            this.rgv_Role.MasterTemplate.AllowRowResize = false;
            this.rgv_Role.MasterTemplate.AutoExpandGroups = true;
            this.rgv_Role.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "RoleId";
            gridViewTextBoxColumn1.HeaderText = "شناسه";
            gridViewTextBoxColumn1.Name = "RoleId";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "RoleName";
            gridViewTextBoxColumn2.HeaderText = "نام نقش";
            gridViewTextBoxColumn2.Name = "RoleName";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn2.Width = 172;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "UserCreationId";
            gridViewTextBoxColumn3.HeaderText = "کد کاربری ایجاد کننده";
            gridViewTextBoxColumn3.IsVisible = false;
            gridViewTextBoxColumn3.Name = "UserCreationId";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn3.Width = 79;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "UserCreationName";
            gridViewTextBoxColumn4.HeaderText = "نام کاربر ایجاد کننده";
            gridViewTextBoxColumn4.Name = "UserCreationName";
            gridViewTextBoxColumn4.ReadOnly = true;
            gridViewTextBoxColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn4.Width = 129;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "RoleStatus";
            gridViewTextBoxColumn5.HeaderText = "وضعیت";
            gridViewTextBoxColumn5.Name = "RoleStatus";
            gridViewTextBoxColumn5.ReadOnly = true;
            gridViewTextBoxColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn5.Width = 81;
            gridViewTextBoxColumn6.FieldName = "UserUpdateByName";
            gridViewTextBoxColumn6.HeaderText = "کاربر ویرایش کننده";
            gridViewTextBoxColumn6.Name = "UserUpdateByName";
            gridViewTextBoxColumn6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn6.Width = 129;
            gridViewTextBoxColumn7.FieldName = "RolePersianRegisterDate";
            gridViewTextBoxColumn7.HeaderText = "تاریخ ایجاد";
            gridViewTextBoxColumn7.Name = "RolePersianRegisterDate";
            gridViewTextBoxColumn7.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn7.Width = 120;
            gridViewTextBoxColumn8.FieldName = "RolePersianLastUpdate";
            gridViewTextBoxColumn8.HeaderText = "تاریخ ویرایش";
            gridViewTextBoxColumn8.Name = "RolePersianLastUpdate";
            gridViewTextBoxColumn8.Width = 120;
            gridViewTextBoxColumn9.EnableExpressionEditor = false;
            gridViewTextBoxColumn9.FieldName = "RoleDescription";
            gridViewTextBoxColumn9.HeaderText = "توضیحات";
            gridViewTextBoxColumn9.IsVisible = false;
            gridViewTextBoxColumn9.Name = "RoleDescription";
            gridViewTextBoxColumn9.ReadOnly = true;
            gridViewTextBoxColumn9.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn9.Width = 221;
            this.rgv_Role.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9});
            this.rgv_Role.MasterTemplate.EnableAlternatingRowColor = true;
            this.rgv_Role.MasterTemplate.EnableFiltering = true;
            this.rgv_Role.MasterTemplate.ReadOnly = true;
            this.rgv_Role.MasterTemplate.ShowGroupedColumns = true;
            this.rgv_Role.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgv_Role.Name = "rgv_Role";
            this.rgv_Role.ReadOnly = true;
            this.rgv_Role.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rgv_Role.Size = new System.Drawing.Size(480, 630);
            this.rgv_Role.TabIndex = 7;
            this.rgv_Role.CurrentRowChanged += new Telerik.WinControls.UI.CurrentRowChangedEventHandler(this.Rgv_Role_CurrentRowChanged);
            this.rgv_Role.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.Rgv_Role_CellClick);
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
            this.pnl_Action.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Action.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.pnl_Action.Location = new System.Drawing.Point(0, 591);
            this.pnl_Action.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_Action.Name = "pnl_Action";
            this.pnl_Action.Size = new System.Drawing.Size(470, 39);
            this.pnl_Action.TabIndex = 6;
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
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancel.Enabled = false;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(317, 2);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(31, 31);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete.Enabled = false;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(347, 2);
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
            this.btnModify.Location = new System.Drawing.Point(377, 2);
            this.btnModify.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(31, 31);
            this.btnModify.TabIndex = 2;
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.BtnModify_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegister.BackColor = System.Drawing.Color.White;
            this.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRegister.Enabled = false;
            this.btnRegister.Image = ((System.Drawing.Image)(resources.GetObject("btnRegister.Image")));
            this.btnRegister.Location = new System.Drawing.Point(407, 2);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(31, 31);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsert.BackColor = System.Drawing.Color.White;
            this.btnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInsert.Image = ((System.Drawing.Image)(resources.GetObject("btnInsert.Image")));
            this.btnInsert.Location = new System.Drawing.Point(437, 2);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(31, 31);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // pnl_Data
            // 
            this.pnl_Data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.pnl_Data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Data.Controls.Add(this.rddl_Status);
            this.pnl_Data.Controls.Add(this.txt_Description);
            this.pnl_Data.Controls.Add(this.txt_RoleName);
            this.pnl_Data.Controls.Add(this.btn_Collapse);
            this.pnl_Data.Controls.Add(this.btn_UncheckAll);
            this.pnl_Data.Controls.Add(this.btn_CheckAll);
            this.pnl_Data.Controls.Add(this.btn_Expand);
            this.pnl_Data.Controls.Add(this.rtv_Permissions);
            this.pnl_Data.Controls.Add(this.label6);
            this.pnl_Data.Controls.Add(this.label9);
            this.pnl_Data.Controls.Add(this.label2);
            this.pnl_Data.Controls.Add(this.label1);
            this.pnl_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Data.Enabled = false;
            this.pnl_Data.Location = new System.Drawing.Point(0, 0);
            this.pnl_Data.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_Data.Name = "pnl_Data";
            this.pnl_Data.Size = new System.Drawing.Size(470, 591);
            this.pnl_Data.TabIndex = 5;
            // 
            // rddl_Status
            // 
            this.rddl_Status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rddl_Status.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.rddl_Status.Font = new System.Drawing.Font("Tornado Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rddl_Status.Location = new System.Drawing.Point(11, 14);
            this.rddl_Status.MaxDropDownItems = 10;
            this.rddl_Status.Name = "rddl_Status";
            this.rddl_Status.Size = new System.Drawing.Size(130, 19);
            this.rddl_Status.TabIndex = 212;
            this.rddl_Status.TextChanged += new System.EventHandler(this.Txt_RoleName_TextChanged);
            this.rddl_Status.SelectedValueChanged += new System.EventHandler(this.Txt_RoleName_TextChanged);
            // 
            // txt_Description
            // 
            this.txt_Description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Description.BackColor = System.Drawing.Color.FloralWhite;
            this.txt_Description.Location = new System.Drawing.Point(11, 547);
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(365, 35);
            this.txt_Description.TabIndex = 211;
            this.txt_Description.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Description.TextChanged += new System.EventHandler(this.Txt_RoleName_TextChanged);
            // 
            // txt_RoleName
            // 
            this.txt_RoleName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_RoleName.Font = new System.Drawing.Font("Tornado Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_RoleName.Location = new System.Drawing.Point(195, 14);
            this.txt_RoleName.Name = "txt_RoleName";
            this.txt_RoleName.Size = new System.Drawing.Size(181, 19);
            this.txt_RoleName.TabIndex = 210;
            this.txt_RoleName.TextChanged += new System.EventHandler(this.Txt_RoleName_TextChanged);
            // 
            // btn_Collapse
            // 
            this.btn_Collapse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Collapse.Image = ((System.Drawing.Image)(resources.GetObject("btn_Collapse.Image")));
            this.btn_Collapse.Location = new System.Drawing.Point(406, 287);
            this.btn_Collapse.Name = "btn_Collapse";
            this.btn_Collapse.Size = new System.Drawing.Size(30, 27);
            this.btn_Collapse.TabIndex = 137;
            this.btn_Collapse.UseVisualStyleBackColor = true;
            this.btn_Collapse.Click += new System.EventHandler(this.Btn_Collapse_Click);
            // 
            // btn_UncheckAll
            // 
            this.btn_UncheckAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_UncheckAll.Image = ((System.Drawing.Image)(resources.GetObject("btn_UncheckAll.Image")));
            this.btn_UncheckAll.Location = new System.Drawing.Point(407, 235);
            this.btn_UncheckAll.Name = "btn_UncheckAll";
            this.btn_UncheckAll.Size = new System.Drawing.Size(30, 27);
            this.btn_UncheckAll.TabIndex = 137;
            this.btn_UncheckAll.UseVisualStyleBackColor = true;
            this.btn_UncheckAll.Click += new System.EventHandler(this.Btn_UncheckAll_Click);
            // 
            // btn_CheckAll
            // 
            this.btn_CheckAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CheckAll.Image = ((System.Drawing.Image)(resources.GetObject("btn_CheckAll.Image")));
            this.btn_CheckAll.Location = new System.Drawing.Point(407, 208);
            this.btn_CheckAll.Name = "btn_CheckAll";
            this.btn_CheckAll.Size = new System.Drawing.Size(30, 27);
            this.btn_CheckAll.TabIndex = 137;
            this.btn_CheckAll.UseVisualStyleBackColor = true;
            this.btn_CheckAll.Click += new System.EventHandler(this.Btn_CheckAll_Click);
            // 
            // btn_Expand
            // 
            this.btn_Expand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Expand.Image = ((System.Drawing.Image)(resources.GetObject("btn_Expand.Image")));
            this.btn_Expand.Location = new System.Drawing.Point(406, 314);
            this.btn_Expand.Name = "btn_Expand";
            this.btn_Expand.Size = new System.Drawing.Size(30, 27);
            this.btn_Expand.TabIndex = 137;
            this.btn_Expand.UseVisualStyleBackColor = true;
            this.btn_Expand.Click += new System.EventHandler(this.Btn_Expand_Click);
            // 
            // rtv_Permissions
            // 
            this.rtv_Permissions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtv_Permissions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.rtv_Permissions.CheckBoxes = true;
            this.rtv_Permissions.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtv_Permissions.Font = new System.Drawing.Font("Tornado Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rtv_Permissions.ForeColor = System.Drawing.Color.Black;
            this.rtv_Permissions.Location = new System.Drawing.Point(11, 39);
            this.rtv_Permissions.Name = "rtv_Permissions";
            this.rtv_Permissions.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rtv_Permissions.Size = new System.Drawing.Size(365, 503);
            this.rtv_Permissions.SpacingBetweenNodes = -1;
            this.rtv_Permissions.TabIndex = 136;
            this.rtv_Permissions.TriStateMode = true;
            this.rtv_Permissions.SelectedNodeChanged += new Telerik.WinControls.UI.RadTreeView.RadTreeViewEventHandler(this.Rtv_Permissions_SelectedNodeChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(144, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 14);
            this.label6.TabIndex = 135;
            this.label6.Text = "وضعیت";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(405, 557);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 134;
            this.label9.Text = "توضیحات";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(385, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 125;
            this.label2.Text = "تعیین مجوزها";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(407, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 125;
            this.label1.Text = "نام نقش";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pnl_Data);
            this.splitContainer1.Panel1.Controls.Add(this.pnl_Action);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rgv_Role);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(954, 630);
            this.splitContainer1.SplitterDistance = 470;
            this.splitContainer1.TabIndex = 8;
            // 
            // FrmRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 630);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Tornado Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "FrmRole";
            this.Text = "مدیریت نقش های کاربران ";
            this.Controls.SetChildIndex(this.splitContainer1, 0);
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_Role.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_Role)).EndInit();
            this.pnl_Action.ResumeLayout(false);
            this.pnl_Data.ResumeLayout(false);
            this.pnl_Data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rddl_Status)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Description)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_RoleName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtv_Permissions)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView rgv_Role;
        private System.Windows.Forms.Panel pnl_Action;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Panel pnl_Data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private Telerik.WinControls.UI.RadTreeView rtv_Permissions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Collapse;
        private System.Windows.Forms.Button btn_Expand;
        private System.Windows.Forms.Button btn_UncheckAll;
        private System.Windows.Forms.Button btn_CheckAll;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Telerik.WinControls.UI.RadTextBox txt_RoleName;
        private Telerik.WinControls.UI.RadTextBoxControl txt_Description;
        private Telerik.WinControls.UI.RadDropDownList rddl_Status;
    }
}