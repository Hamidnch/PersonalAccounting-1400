namespace PersonalAccounting.UI
{
    partial class FrmBankAccount
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
            AFrmBankAccount = null;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBankAccount));
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnl_Action = new System.Windows.Forms.Panel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnl_Data = new System.Windows.Forms.Panel();
            this.txt_BankAccountNumber = new System.Windows.Forms.TextBox();
            this.txt_BankAccountSubject = new System.Windows.Forms.TextBox();
            this.txt_BankAccountDescription = new System.Windows.Forms.TextBox();
            this.rddl_BankAccountBank = new Telerik.WinControls.UI.RadDropDownList();
            this.rddl_BankAccountPerson = new Telerik.WinControls.UI.RadDropDownList();
            this.rddl_BankAccountStatus = new Telerik.WinControls.UI.RadDropDownList();
            this.label1 = new System.Windows.Forms.Label();
            this.rgv_BankAccount = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).BeginInit();
            this.pnl_Action.SuspendLayout();
            this.pnl_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rddl_BankAccountBank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddl_BankAccountPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddl_BankAccountStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_BankAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_BankAccount.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModify
            // 
            this.btnModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModify.BackColor = System.Drawing.Color.White;
            this.btnModify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnModify.Enabled = false;
            this.btnModify.Image = ((System.Drawing.Image)(resources.GetObject("btnModify.Image")));
            this.btnModify.Location = new System.Drawing.Point(911, 2);
            this.btnModify.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(36, 33);
            this.btnModify.TabIndex = 2;
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsert.BackColor = System.Drawing.Color.White;
            this.btnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInsert.Image = ((System.Drawing.Image)(resources.GetObject("btnInsert.Image")));
            this.btnInsert.Location = new System.Drawing.Point(981, 2);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(36, 33);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(961, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 14);
            this.label6.TabIndex = 133;
            this.label6.Text = "وضعیت";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(619, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 125;
            this.label9.Text = "توضیحات";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point(6, 4);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(89, 31);
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
            this.btnCancel.Location = new System.Drawing.Point(841, 2);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(36, 33);
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
            this.btnDelete.Location = new System.Drawing.Point(876, 2);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(36, 33);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.pnl_Action.Location = new System.Drawing.Point(0, 113);
            this.pnl_Action.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_Action.Name = "pnl_Action";
            this.pnl_Action.Size = new System.Drawing.Size(1023, 41);
            this.pnl_Action.TabIndex = 0;
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegister.BackColor = System.Drawing.Color.White;
            this.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRegister.Enabled = false;
            this.btnRegister.Image = ((System.Drawing.Image)(resources.GetObject("btnRegister.Image")));
            this.btnRegister.Location = new System.Drawing.Point(946, 2);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(36, 33);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 123;
            this.label2.Text = "نام بانک";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(937, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 123;
            this.label4.Text = "عنوان حساب";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(931, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 123;
            this.label3.Text = "شماره حساب";
            // 
            // pnl_Data
            // 
            this.pnl_Data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.pnl_Data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Data.Controls.Add(this.txt_BankAccountNumber);
            this.pnl_Data.Controls.Add(this.txt_BankAccountSubject);
            this.pnl_Data.Controls.Add(this.txt_BankAccountDescription);
            this.pnl_Data.Controls.Add(this.rddl_BankAccountBank);
            this.pnl_Data.Controls.Add(this.rddl_BankAccountPerson);
            this.pnl_Data.Controls.Add(this.rddl_BankAccountStatus);
            this.pnl_Data.Controls.Add(this.label6);
            this.pnl_Data.Controls.Add(this.label9);
            this.pnl_Data.Controls.Add(this.label2);
            this.pnl_Data.Controls.Add(this.label4);
            this.pnl_Data.Controls.Add(this.label3);
            this.pnl_Data.Controls.Add(this.label1);
            this.pnl_Data.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Data.Enabled = false;
            this.pnl_Data.Location = new System.Drawing.Point(0, 0);
            this.pnl_Data.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_Data.Name = "pnl_Data";
            this.pnl_Data.Size = new System.Drawing.Size(1023, 113);
            this.pnl_Data.TabIndex = 1;
            // 
            // txt_BankAccountNumber
            // 
            this.txt_BankAccountNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_BankAccountNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_BankAccountNumber.Location = new System.Drawing.Point(686, 43);
            this.txt_BankAccountNumber.Name = "txt_BankAccountNumber";
            this.txt_BankAccountNumber.Size = new System.Drawing.Size(239, 22);
            this.txt_BankAccountNumber.TabIndex = 3;
            this.txt_BankAccountNumber.TextChanged += new System.EventHandler(this.txt_BankAccountNumber_TextChanged);
            this.txt_BankAccountNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_BankAccountSubject_KeyDown);
            // 
            // txt_BankAccountSubject
            // 
            this.txt_BankAccountSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_BankAccountSubject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_BankAccountSubject.Location = new System.Drawing.Point(686, 11);
            this.txt_BankAccountSubject.Name = "txt_BankAccountSubject";
            this.txt_BankAccountSubject.Size = new System.Drawing.Size(239, 22);
            this.txt_BankAccountSubject.TabIndex = 0;
            this.txt_BankAccountSubject.TextChanged += new System.EventHandler(this.txt_BankAccountNumber_TextChanged);
            this.txt_BankAccountSubject.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_BankAccountSubject_KeyDown);
            // 
            // txt_BankAccountDescription
            // 
            this.txt_BankAccountDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_BankAccountDescription.BackColor = System.Drawing.Color.FloralWhite;
            this.txt_BankAccountDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_BankAccountDescription.Location = new System.Drawing.Point(13, 47);
            this.txt_BankAccountDescription.Multiline = true;
            this.txt_BankAccountDescription.Name = "txt_BankAccountDescription";
            this.txt_BankAccountDescription.Size = new System.Drawing.Size(554, 53);
            this.txt_BankAccountDescription.TabIndex = 5;
            this.txt_BankAccountDescription.TextChanged += new System.EventHandler(this.txt_BankAccountNumber_TextChanged);
            this.txt_BankAccountDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_BankAccountSubject_KeyDown);
            // 
            // rddl_BankAccountBank
            // 
            this.rddl_BankAccountBank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rddl_BankAccountBank.BackColor = System.Drawing.Color.White;
            this.rddl_BankAccountBank.DropDownAnimationEasing = Telerik.WinControls.RadEasingType.InCubic;
            this.rddl_BankAccountBank.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.rddl_BankAccountBank.EnableAlternatingItemColor = true;
            this.rddl_BankAccountBank.EnableGestures = false;
            this.rddl_BankAccountBank.Font = new System.Drawing.Font("Tornado Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rddl_BankAccountBank.Location = new System.Drawing.Point(13, 12);
            this.rddl_BankAccountBank.Name = "rddl_BankAccountBank";
            this.rddl_BankAccountBank.Size = new System.Drawing.Size(241, 20);
            this.rddl_BankAccountBank.TabIndex = 2;
            this.rddl_BankAccountBank.TextChanged += new System.EventHandler(this.txt_BankAccountNumber_TextChanged);
            this.rddl_BankAccountBank.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_BankAccountSubject_KeyDown);
            // 
            // rddl_BankAccountPerson
            // 
            this.rddl_BankAccountPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rddl_BankAccountPerson.BackColor = System.Drawing.Color.White;
            this.rddl_BankAccountPerson.DropDownAnimationEasing = Telerik.WinControls.RadEasingType.InCubic;
            this.rddl_BankAccountPerson.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.rddl_BankAccountPerson.EnableAlternatingItemColor = true;
            this.rddl_BankAccountPerson.EnableGestures = false;
            this.rddl_BankAccountPerson.Font = new System.Drawing.Font("Tornado Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rddl_BankAccountPerson.Location = new System.Drawing.Point(326, 10);
            this.rddl_BankAccountPerson.Name = "rddl_BankAccountPerson";
            this.rddl_BankAccountPerson.Size = new System.Drawing.Size(241, 20);
            this.rddl_BankAccountPerson.TabIndex = 1;
            this.rddl_BankAccountPerson.TextChanged += new System.EventHandler(this.txt_BankAccountNumber_TextChanged);
            this.rddl_BankAccountPerson.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_BankAccountSubject_KeyDown);
            // 
            // rddl_BankAccountStatus
            // 
            this.rddl_BankAccountStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rddl_BankAccountStatus.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.rddl_BankAccountStatus.EnableAlternatingItemColor = true;
            this.rddl_BankAccountStatus.Font = new System.Drawing.Font("Tornado Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rddl_BankAccountStatus.Location = new System.Drawing.Point(794, 75);
            this.rddl_BankAccountStatus.MaxDropDownItems = 10;
            this.rddl_BankAccountStatus.Name = "rddl_BankAccountStatus";
            this.rddl_BankAccountStatus.Size = new System.Drawing.Size(131, 22);
            this.rddl_BankAccountStatus.TabIndex = 4;
            this.rddl_BankAccountStatus.TextChanged += new System.EventHandler(this.txt_BankAccountNumber_TextChanged);
            this.rddl_BankAccountStatus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_BankAccountSubject_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(571, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 123;
            this.label1.Text = "نام صاحب حساب";
            // 
            // rgv_BankAccount
            // 
            this.rgv_BankAccount.AutoScroll = true;
            this.rgv_BankAccount.BackColor = System.Drawing.SystemColors.Control;
            this.rgv_BankAccount.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_BankAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rgv_BankAccount.EnableHotTracking = false;
            this.rgv_BankAccount.EnterKeyMode = Telerik.WinControls.UI.RadGridViewEnterKeyMode.EnterMovesToNextRow;
            this.rgv_BankAccount.Font = new System.Drawing.Font("Tornado Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rgv_BankAccount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgv_BankAccount.GroupExpandAnimationType = Telerik.WinControls.UI.GridExpandAnimationType.Slide;
            this.rgv_BankAccount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_BankAccount.Location = new System.Drawing.Point(0, 181);
            this.rgv_BankAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // 
            // 
            this.rgv_BankAccount.MasterTemplate.AllowAddNewRow = false;
            this.rgv_BankAccount.MasterTemplate.AllowCellContextMenu = false;
            this.rgv_BankAccount.MasterTemplate.AllowDeleteRow = false;
            this.rgv_BankAccount.MasterTemplate.AllowEditRow = false;
            this.rgv_BankAccount.MasterTemplate.AllowRowResize = false;
            this.rgv_BankAccount.MasterTemplate.AutoExpandGroups = true;
            this.rgv_BankAccount.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "BankAccountId";
            gridViewTextBoxColumn1.HeaderText = "شناسه";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "BankAccountId";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn1.Width = 62;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "BankAccountPersonName";
            gridViewTextBoxColumn2.HeaderText = "نام صاحب حساب";
            gridViewTextBoxColumn2.Name = "BankAccountPersonName";
            gridViewTextBoxColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn2.Width = 219;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "BankAccountSubject";
            gridViewTextBoxColumn3.HeaderText = "عنوان حساب";
            gridViewTextBoxColumn3.Name = "BankAccountSubject";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.SortOrder = Telerik.WinControls.UI.RadSortOrder.Descending;
            gridViewTextBoxColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn3.Width = 191;
            gridViewTextBoxColumn4.FieldName = "PersonId";
            gridViewTextBoxColumn4.HeaderText = "کد صاحب حساب";
            gridViewTextBoxColumn4.IsVisible = false;
            gridViewTextBoxColumn4.Name = "PersonId";
            gridViewTextBoxColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "BankAccountNumber";
            gridViewTextBoxColumn5.HeaderText = "شماره حساب";
            gridViewTextBoxColumn5.Name = "BankAccountNumber";
            gridViewTextBoxColumn5.ReadOnly = true;
            gridViewTextBoxColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn5.Width = 252;
            gridViewTextBoxColumn6.FieldName = "BankId";
            gridViewTextBoxColumn6.HeaderText = "کد بانک";
            gridViewTextBoxColumn6.IsVisible = false;
            gridViewTextBoxColumn6.Name = "BankId";
            gridViewTextBoxColumn6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "BankName";
            gridViewTextBoxColumn7.HeaderText = "بانک";
            gridViewTextBoxColumn7.Name = "BankName";
            gridViewTextBoxColumn7.ReadOnly = true;
            gridViewTextBoxColumn7.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn7.Width = 182;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "BankAccountPersianCreationDate";
            gridViewTextBoxColumn8.HeaderText = "تاریخ ثبت";
            gridViewTextBoxColumn8.Name = "BankAccountPersianCreationDate";
            gridViewTextBoxColumn8.ReadOnly = true;
            gridViewTextBoxColumn8.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn8.Width = 141;
            gridViewTextBoxColumn9.EnableExpressionEditor = false;
            gridViewTextBoxColumn9.FieldName = "BankAccountPersianLastUpdate";
            gridViewTextBoxColumn9.HeaderText = "تاریخ آخرین ویرایش";
            gridViewTextBoxColumn9.Name = "BankAccountPersianLastUpdate";
            gridViewTextBoxColumn9.ReadOnly = true;
            gridViewTextBoxColumn9.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn9.Width = 147;
            gridViewTextBoxColumn10.EnableExpressionEditor = false;
            gridViewTextBoxColumn10.FieldName = "BankAccountCreationUserName";
            gridViewTextBoxColumn10.HeaderText = "کاربر ثبت کننده";
            gridViewTextBoxColumn10.Name = "BankAccountCreationUserName";
            gridViewTextBoxColumn10.ReadOnly = true;
            gridViewTextBoxColumn10.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn10.Width = 145;
            gridViewTextBoxColumn11.EnableExpressionEditor = false;
            gridViewTextBoxColumn11.FieldName = "BankAccountStatus";
            gridViewTextBoxColumn11.HeaderText = "وضعیت";
            gridViewTextBoxColumn11.Name = "BankAccountStatus";
            gridViewTextBoxColumn11.ReadOnly = true;
            gridViewTextBoxColumn11.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn11.Width = 122;
            gridViewTextBoxColumn12.EnableExpressionEditor = false;
            gridViewTextBoxColumn12.FieldName = "BankAccountDescription";
            gridViewTextBoxColumn12.HeaderText = "توضیحات";
            gridViewTextBoxColumn12.Name = "BankAccountDescription";
            gridViewTextBoxColumn12.ReadOnly = true;
            gridViewTextBoxColumn12.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn12.Width = 493;
            this.rgv_BankAccount.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11,
            gridViewTextBoxColumn12});
            this.rgv_BankAccount.MasterTemplate.EnableAlternatingRowColor = true;
            this.rgv_BankAccount.MasterTemplate.EnableFiltering = true;
            this.rgv_BankAccount.MasterTemplate.ReadOnly = true;
            this.rgv_BankAccount.MasterTemplate.ShowGroupedColumns = true;
            sortDescriptor1.Direction = System.ComponentModel.ListSortDirection.Descending;
            sortDescriptor1.PropertyName = "BankAccountSubject";
            this.rgv_BankAccount.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.rgv_BankAccount.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgv_BankAccount.Name = "rgv_BankAccount";
            this.rgv_BankAccount.ReadOnly = true;
            this.rgv_BankAccount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rgv_BankAccount.Size = new System.Drawing.Size(1023, 499);
            this.rgv_BankAccount.TabIndex = 2;
            this.rgv_BankAccount.CurrentRowChanged += new Telerik.WinControls.UI.CurrentRowChangedEventHandler(this.rgv_BankAccount_CurrentRowChanged);
            this.rgv_BankAccount.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.rgv_BankAccount_CellClick);
            // 
            // FrmBankAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 680);
            this.Controls.Add(this.rgv_BankAccount);
            this.Controls.Add(this.pnl_Action);
            this.Controls.Add(this.pnl_Data);
            this.Font = new System.Drawing.Font("Tornado Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "FrmBankAccount";
            this.Text = "فرم جزئیات حسابهای بانکی";
            this.Controls.SetChildIndex(this.pnl_Data, 0);
            this.Controls.SetChildIndex(this.pnl_Action, 0);
            this.Controls.SetChildIndex(this.rgv_BankAccount, 0);
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).EndInit();
            this.pnl_Action.ResumeLayout(false);
            this.pnl_Data.ResumeLayout(false);
            this.pnl_Data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rddl_BankAccountBank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddl_BankAccountPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddl_BankAccountStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_BankAccount.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_BankAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel pnl_Action;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnl_Data;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadGridView rgv_BankAccount;
        private Telerik.WinControls.UI.RadDropDownList rddl_BankAccountStatus;
        private Telerik.WinControls.UI.RadDropDownList rddl_BankAccountPerson;
        private Telerik.WinControls.UI.RadDropDownList rddl_BankAccountBank;
        private System.Windows.Forms.TextBox txt_BankAccountDescription;
        private System.Windows.Forms.TextBox txt_BankAccountNumber;
        private System.Windows.Forms.TextBox txt_BankAccountSubject;
    }
}