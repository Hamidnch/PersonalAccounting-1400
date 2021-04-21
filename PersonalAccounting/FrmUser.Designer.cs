namespace PersonalAccounting.UI
{
    partial class FrmUser
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
            AFrmUser = null;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUser));
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn2 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn13 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.pnl_Data = new System.Windows.Forms.Panel();
            this.chk_IsLockout = new Telerik.WinControls.UI.RadCheckBox();
            this.chk_EnablePassword = new Telerik.WinControls.UI.RadCheckBox();
            this.chk_IsApproved = new Telerik.WinControls.UI.RadCheckBox();
            this.txt_Description = new Telerik.WinControls.UI.RadTextBoxControl();
            this.txt_Email = new Telerik.WinControls.UI.RadTextBox();
            this.txt_UserName = new Telerik.WinControls.UI.RadTextBox();
            this.rddl_Status = new Telerik.WinControls.UI.RadDropDownList();
            this.ddl_PersonName = new Telerik.WinControls.UI.RadDropDownList();
            this.gb_Password = new System.Windows.Forms.GroupBox();
            this.txt_ConfirmPassword = new Telerik.WinControls.UI.RadTextBox();
            this.txt_Password = new Telerik.WinControls.UI.RadTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rclb_RoleNames = new Telerik.WinControls.UI.RadCheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_PasswordHeader = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_Action = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.rgv_User = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).BeginInit();
            this.pnl_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chk_IsLockout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_EnablePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_IsApproved)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Description)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Email)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_UserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddl_Status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddl_PersonName)).BeginInit();
            this.gb_Password.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ConfirmPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rclb_RoleNames)).BeginInit();
            this.pnl_Action.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_User)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_User.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Data
            // 
            this.pnl_Data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.pnl_Data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Data.Controls.Add(this.chk_IsLockout);
            this.pnl_Data.Controls.Add(this.chk_EnablePassword);
            this.pnl_Data.Controls.Add(this.chk_IsApproved);
            this.pnl_Data.Controls.Add(this.txt_Description);
            this.pnl_Data.Controls.Add(this.txt_Email);
            this.pnl_Data.Controls.Add(this.txt_UserName);
            this.pnl_Data.Controls.Add(this.rddl_Status);
            this.pnl_Data.Controls.Add(this.ddl_PersonName);
            this.pnl_Data.Controls.Add(this.gb_Password);
            this.pnl_Data.Controls.Add(this.rclb_RoleNames);
            this.pnl_Data.Controls.Add(this.label7);
            this.pnl_Data.Controls.Add(this.lbl_PasswordHeader);
            this.pnl_Data.Controls.Add(this.label3);
            this.pnl_Data.Controls.Add(this.label6);
            this.pnl_Data.Controls.Add(this.label9);
            this.pnl_Data.Controls.Add(this.label5);
            this.pnl_Data.Controls.Add(this.label1);
            this.pnl_Data.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Data.Enabled = false;
            this.pnl_Data.Location = new System.Drawing.Point(0, 27);
            this.pnl_Data.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_Data.Name = "pnl_Data";
            this.pnl_Data.Size = new System.Drawing.Size(935, 188);
            this.pnl_Data.TabIndex = 2;
            // 
            // chk_IsLockout
            // 
            this.chk_IsLockout.Location = new System.Drawing.Point(37, 47);
            this.chk_IsLockout.Name = "chk_IsLockout";
            this.chk_IsLockout.Size = new System.Drawing.Size(100, 18);
            this.chk_IsLockout.TabIndex = 141;
            this.chk_IsLockout.Text = "کاربر محروم است";
            this.chk_IsLockout.CheckStateChanged += new System.EventHandler(this.Txt_UserName_TextChanged);
            this.chk_IsLockout.Click += new System.EventHandler(this.Txt_UserName_TextChanged);
            // 
            // chk_EnablePassword
            // 
            this.chk_EnablePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_EnablePassword.Location = new System.Drawing.Point(491, 8);
            this.chk_EnablePassword.Name = "chk_EnablePassword";
            this.chk_EnablePassword.Size = new System.Drawing.Size(149, 18);
            this.chk_EnablePassword.TabIndex = 141;
            this.chk_EnablePassword.Text = "کلمه عبور نیاز به تغییر دارد؟";
            this.chk_EnablePassword.Visible = false;
            this.chk_EnablePassword.CheckStateChanged += new System.EventHandler(this.Chk_EnablePassword_CheckedChanged);
            // 
            // chk_IsApproved
            // 
            this.chk_IsApproved.Location = new System.Drawing.Point(21, 24);
            this.chk_IsApproved.Name = "chk_IsApproved";
            this.chk_IsApproved.Size = new System.Drawing.Size(116, 18);
            this.chk_IsApproved.TabIndex = 141;
            this.chk_IsApproved.Text = "کاربر مورد تایید است";
            this.chk_IsApproved.CheckStateChanged += new System.EventHandler(this.Txt_UserName_TextChanged);
            this.chk_IsApproved.Click += new System.EventHandler(this.Txt_UserName_TextChanged);
            // 
            // txt_Description
            // 
            this.txt_Description.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Description.BackColor = System.Drawing.Color.FloralWhite;
            this.txt_Description.Location = new System.Drawing.Point(423, 129);
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(437, 49);
            this.txt_Description.TabIndex = 140;
            this.txt_Description.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Description.TextChanged += new System.EventHandler(this.Txt_UserName_TextChanged);
            // 
            // txt_Email
            // 
            this.txt_Email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Email.BackColor = System.Drawing.Color.FloralWhite;
            this.txt_Email.Font = new System.Drawing.Font("Tornado Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_Email.Location = new System.Drawing.Point(661, 70);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(199, 19);
            this.txt_Email.TabIndex = 139;
            this.txt_Email.TextChanged += new System.EventHandler(this.Txt_UserName_TextChanged);
            // 
            // txt_UserName
            // 
            this.txt_UserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_UserName.Font = new System.Drawing.Font("Tornado Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_UserName.Location = new System.Drawing.Point(661, 42);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(199, 19);
            this.txt_UserName.TabIndex = 139;
            this.txt_UserName.TextChanged += new System.EventHandler(this.Txt_UserName_TextChanged);
            // 
            // rddl_Status
            // 
            this.rddl_Status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rddl_Status.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.rddl_Status.Font = new System.Drawing.Font("Tornado Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rddl_Status.Location = new System.Drawing.Point(661, 99);
            this.rddl_Status.MaxDropDownItems = 10;
            this.rddl_Status.Name = "rddl_Status";
            this.rddl_Status.Size = new System.Drawing.Size(199, 19);
            this.rddl_Status.TabIndex = 138;
            this.rddl_Status.TextChanged += new System.EventHandler(this.Txt_UserName_TextChanged);
            // 
            // ddl_PersonName
            // 
            this.ddl_PersonName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ddl_PersonName.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ddl_PersonName.Font = new System.Drawing.Font("Tornado Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ddl_PersonName.Location = new System.Drawing.Point(661, 13);
            this.ddl_PersonName.MaxDropDownItems = 10;
            this.ddl_PersonName.Name = "ddl_PersonName";
            this.ddl_PersonName.Size = new System.Drawing.Size(199, 19);
            this.ddl_PersonName.TabIndex = 138;
            this.ddl_PersonName.TextChanged += new System.EventHandler(this.Txt_UserName_TextChanged);
            // 
            // gb_Password
            // 
            this.gb_Password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Password.Controls.Add(this.txt_ConfirmPassword);
            this.gb_Password.Controls.Add(this.txt_Password);
            this.gb_Password.Controls.Add(this.label4);
            this.gb_Password.Controls.Add(this.label2);
            this.gb_Password.Location = new System.Drawing.Point(423, 24);
            this.gb_Password.Name = "gb_Password";
            this.gb_Password.Size = new System.Drawing.Size(221, 98);
            this.gb_Password.TabIndex = 135;
            this.gb_Password.TabStop = false;
            // 
            // txt_ConfirmPassword
            // 
            this.txt_ConfirmPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ConfirmPassword.Font = new System.Drawing.Font("Tornado Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_ConfirmPassword.Location = new System.Drawing.Point(15, 73);
            this.txt_ConfirmPassword.Name = "txt_ConfirmPassword";
            this.txt_ConfirmPassword.PasswordChar = '*';
            this.txt_ConfirmPassword.Size = new System.Drawing.Size(164, 19);
            this.txt_ConfirmPassword.TabIndex = 140;
            this.txt_ConfirmPassword.TextChanged += new System.EventHandler(this.Txt_UserName_TextChanged);
            // 
            // txt_Password
            // 
            this.txt_Password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Password.Font = new System.Drawing.Font("Tornado Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_Password.Location = new System.Drawing.Point(15, 30);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(164, 19);
            this.txt_Password.TabIndex = 140;
            this.txt_Password.TextChanged += new System.EventHandler(this.Txt_UserName_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tornado Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(139, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 123;
            this.label4.Text = "تکرار کلمه عبور";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tornado Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(163, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 123;
            this.label2.Text = "کلمه عبور";
            // 
            // rclb_RoleNames
            // 
            this.rclb_RoleNames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rclb_RoleNames.CheckBoxesAlignment = Telerik.WinControls.UI.CheckBoxesAlignment.Far;
            this.rclb_RoleNames.CheckOnClickMode = Telerik.WinControls.UI.CheckOnClickMode.FirstClick;
            this.rclb_RoleNames.Location = new System.Drawing.Point(143, 21);
            this.rclb_RoleNames.MultiSelect = true;
            this.rclb_RoleNames.Name = "rclb_RoleNames";
            this.rclb_RoleNames.Padding = new System.Windows.Forms.Padding(5);
            this.rclb_RoleNames.Size = new System.Drawing.Size(272, 157);
            this.rclb_RoleNames.TabIndex = 134;
            this.rclb_RoleNames.SelectedItemChanged += new System.EventHandler(this.Txt_UserName_TextChanged);
            this.rclb_RoleNames.TextChanged += new System.EventHandler(this.Txt_UserName_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(309, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 14);
            this.label7.TabIndex = 131;
            this.label7.Text = "انتخاب نقش";
            // 
            // lbl_PasswordHeader
            // 
            this.lbl_PasswordHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_PasswordHeader.AutoSize = true;
            this.lbl_PasswordHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_PasswordHeader.Location = new System.Drawing.Point(484, 9);
            this.lbl_PasswordHeader.Name = "lbl_PasswordHeader";
            this.lbl_PasswordHeader.Size = new System.Drawing.Size(160, 13);
            this.lbl_PasswordHeader.TabIndex = 131;
            this.lbl_PasswordHeader.Text = "کلمه عبور و تکرار آن را وارد نمایید.";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(868, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 131;
            this.label3.Text = "نام شخص";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(880, 104);
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
            this.label9.Location = new System.Drawing.Point(875, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 125;
            this.label9.Text = "توضیحات";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(890, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 123;
            this.label5.Text = "ایمیل";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(869, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 123;
            this.label1.Text = "نام کاربری";
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
            this.pnl_Action.Location = new System.Drawing.Point(0, 215);
            this.pnl_Action.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_Action.Name = "pnl_Action";
            this.pnl_Action.Size = new System.Drawing.Size(935, 39);
            this.pnl_Action.TabIndex = 3;
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
            this.btnCancel.Location = new System.Drawing.Point(780, 2);
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
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(810, 2);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(31, 31);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnModify
            // 
            this.btnModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModify.BackColor = System.Drawing.Color.White;
            this.btnModify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnModify.Enabled = false;
            this.btnModify.Image = ((System.Drawing.Image)(resources.GetObject("btnModify.Image")));
            this.btnModify.Location = new System.Drawing.Point(840, 2);
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
            this.btnRegister.Location = new System.Drawing.Point(870, 2);
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
            this.btnInsert.Location = new System.Drawing.Point(900, 2);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(31, 31);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // rgv_User
            // 
            this.rgv_User.AutoScroll = true;
            this.rgv_User.BackColor = System.Drawing.SystemColors.Control;
            this.rgv_User.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_User.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rgv_User.EnableHotTracking = false;
            this.rgv_User.EnterKeyMode = Telerik.WinControls.UI.RadGridViewEnterKeyMode.EnterMovesToNextRow;
            this.rgv_User.Font = new System.Drawing.Font("Tornado Tahoma", 8.25F);
            this.rgv_User.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgv_User.GroupExpandAnimationType = Telerik.WinControls.UI.GridExpandAnimationType.Slide;
            this.rgv_User.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_User.Location = new System.Drawing.Point(0, 254);
            this.rgv_User.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // 
            // 
            this.rgv_User.MasterTemplate.AllowAddNewRow = false;
            this.rgv_User.MasterTemplate.AllowCellContextMenu = false;
            this.rgv_User.MasterTemplate.AllowDeleteRow = false;
            this.rgv_User.MasterTemplate.AllowEditRow = false;
            this.rgv_User.MasterTemplate.AllowRowResize = false;
            this.rgv_User.MasterTemplate.AutoExpandGroups = true;
            this.rgv_User.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "UserId";
            gridViewTextBoxColumn1.HeaderText = "شناسه";
            gridViewTextBoxColumn1.Name = "UserId";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn1.Width = 85;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "PersonId";
            gridViewTextBoxColumn2.HeaderText = "کد شخص";
            gridViewTextBoxColumn2.IsVisible = false;
            gridViewTextBoxColumn2.Name = "PersonId";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "PersonName";
            gridViewTextBoxColumn3.HeaderText = "نام شخص";
            gridViewTextBoxColumn3.Name = "PersonName";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn3.Width = 159;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "UserName";
            gridViewTextBoxColumn4.HeaderText = "نام کاربری";
            gridViewTextBoxColumn4.Name = "UserName";
            gridViewTextBoxColumn4.ReadOnly = true;
            gridViewTextBoxColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn4.Width = 120;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "Password";
            gridViewTextBoxColumn5.HeaderText = "کلمه عبور";
            gridViewTextBoxColumn5.IsVisible = false;
            gridViewTextBoxColumn5.Name = "Password";
            gridViewTextBoxColumn5.ReadOnly = true;
            gridViewTextBoxColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn5.Width = 132;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "Email";
            gridViewTextBoxColumn6.HeaderText = "ایمیل";
            gridViewTextBoxColumn6.Name = "Email";
            gridViewTextBoxColumn6.ReadOnly = true;
            gridViewTextBoxColumn6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn6.Width = 193;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "RoleNames";
            gridViewTextBoxColumn7.HeaderText = "نقش(های) کاربر";
            gridViewTextBoxColumn7.Name = "RoleNames";
            gridViewTextBoxColumn7.ReadOnly = true;
            gridViewTextBoxColumn7.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn7.Width = 110;
            gridViewCheckBoxColumn1.EnableExpressionEditor = false;
            gridViewCheckBoxColumn1.FieldName = "IsApproved";
            gridViewCheckBoxColumn1.HeaderText = "تایید شده";
            gridViewCheckBoxColumn1.MinWidth = 20;
            gridViewCheckBoxColumn1.Name = "IsApproved";
            gridViewCheckBoxColumn1.ReadOnly = true;
            gridViewCheckBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewCheckBoxColumn1.Width = 63;
            gridViewCheckBoxColumn2.EnableExpressionEditor = false;
            gridViewCheckBoxColumn2.FieldName = "IsLockout";
            gridViewCheckBoxColumn2.HeaderText = "محروم شده";
            gridViewCheckBoxColumn2.MinWidth = 20;
            gridViewCheckBoxColumn2.Name = "IsLockout";
            gridViewCheckBoxColumn2.ReadOnly = true;
            gridViewCheckBoxColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewCheckBoxColumn2.Width = 75;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "CreationDate";
            gridViewTextBoxColumn8.HeaderText = "تاریخ ثبت";
            gridViewTextBoxColumn8.Name = "CreationDate";
            gridViewTextBoxColumn8.ReadOnly = true;
            gridViewTextBoxColumn8.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn8.Width = 128;
            gridViewTextBoxColumn9.EnableExpressionEditor = false;
            gridViewTextBoxColumn9.FieldName = "RoleId";
            gridViewTextBoxColumn9.HeaderText = "کد نقش";
            gridViewTextBoxColumn9.IsVisible = false;
            gridViewTextBoxColumn9.Name = "RoleId";
            gridViewTextBoxColumn9.ReadOnly = true;
            gridViewTextBoxColumn9.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn10.EnableExpressionEditor = false;
            gridViewTextBoxColumn10.FieldName = "Status";
            gridViewTextBoxColumn10.HeaderText = "وضعیت";
            gridViewTextBoxColumn10.Name = "Status";
            gridViewTextBoxColumn10.ReadOnly = true;
            gridViewTextBoxColumn10.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn10.Width = 90;
            gridViewTextBoxColumn11.EnableExpressionEditor = false;
            gridViewTextBoxColumn11.FieldName = "LastUpdate";
            gridViewTextBoxColumn11.HeaderText = "تاریخ آخرین ویرایش";
            gridViewTextBoxColumn11.Name = "LastUpdate";
            gridViewTextBoxColumn11.ReadOnly = true;
            gridViewTextBoxColumn11.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn11.Width = 118;
            gridViewTextBoxColumn12.EnableExpressionEditor = false;
            gridViewTextBoxColumn12.FieldName = "CreationUser";
            gridViewTextBoxColumn12.HeaderText = "کاربر ثبت کننده";
            gridViewTextBoxColumn12.Name = "CreationUser";
            gridViewTextBoxColumn12.ReadOnly = true;
            gridViewTextBoxColumn12.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn12.Width = 105;
            gridViewTextBoxColumn13.EnableExpressionEditor = false;
            gridViewTextBoxColumn13.FieldName = "Description";
            gridViewTextBoxColumn13.HeaderText = "توضیحات";
            gridViewTextBoxColumn13.IsVisible = false;
            gridViewTextBoxColumn13.Name = "Description";
            gridViewTextBoxColumn13.ReadOnly = true;
            gridViewTextBoxColumn13.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn13.Width = 155;
            this.rgv_User.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewCheckBoxColumn1,
            gridViewCheckBoxColumn2,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11,
            gridViewTextBoxColumn12,
            gridViewTextBoxColumn13});
            this.rgv_User.MasterTemplate.EnableAlternatingRowColor = true;
            this.rgv_User.MasterTemplate.EnableFiltering = true;
            this.rgv_User.MasterTemplate.ReadOnly = true;
            this.rgv_User.MasterTemplate.ShowGroupedColumns = true;
            sortDescriptor1.PropertyName = "RoleName";
            this.rgv_User.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.rgv_User.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgv_User.Name = "rgv_User";
            this.rgv_User.ReadOnly = true;
            this.rgv_User.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rgv_User.Size = new System.Drawing.Size(935, 311);
            this.rgv_User.TabIndex = 4;
            this.rgv_User.CurrentRowChanged += new Telerik.WinControls.UI.CurrentRowChangedEventHandler(this.MasterTemplate_CurrentRowChanged);
            this.rgv_User.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.MasterTemplate_CellClick);
            this.rgv_User.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MasterTemplate_KeyDown);
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 565);
            this.Controls.Add(this.rgv_User);
            this.Controls.Add(this.pnl_Action);
            this.Controls.Add(this.pnl_Data);
            this.Font = new System.Drawing.Font("Tornado Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "FrmUser";
            this.Text = "تعریف کاربران";
            this.Controls.SetChildIndex(this.pnl_Data, 0);
            this.Controls.SetChildIndex(this.pnl_Action, 0);
            this.Controls.SetChildIndex(this.rgv_User, 0);
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).EndInit();
            this.pnl_Data.ResumeLayout(false);
            this.pnl_Data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chk_IsLockout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_EnablePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_IsApproved)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Description)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Email)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_UserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddl_Status)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddl_PersonName)).EndInit();
            this.gb_Password.ResumeLayout(false);
            this.gb_Password.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ConfirmPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rclb_RoleNames)).EndInit();
            this.pnl_Action.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgv_User.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_User)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Data;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_Action;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private Telerik.WinControls.UI.RadGridView rgv_User;
        private Telerik.WinControls.UI.RadCheckedListBox rclb_RoleNames;
        private System.Windows.Forms.GroupBox gb_Password;
        private System.Windows.Forms.Label lbl_PasswordHeader;
        private Telerik.WinControls.UI.RadDropDownList ddl_PersonName;
        private Telerik.WinControls.UI.RadDropDownList rddl_Status;
        private Telerik.WinControls.UI.RadCheckBox chk_IsLockout;
        private Telerik.WinControls.UI.RadCheckBox chk_EnablePassword;
        private Telerik.WinControls.UI.RadCheckBox chk_IsApproved;
        private Telerik.WinControls.UI.RadTextBoxControl txt_Description;
        private Telerik.WinControls.UI.RadTextBox txt_Email;
        private Telerik.WinControls.UI.RadTextBox txt_UserName;
        private Telerik.WinControls.UI.RadTextBox txt_ConfirmPassword;
        private Telerik.WinControls.UI.RadTextBox txt_Password;
    }
}