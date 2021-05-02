namespace PersonalAccounting.UI
{
    partial class FrmFund
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
            AFrmFund = null;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFund));
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn13 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_FundDescription = new Janus.Windows.GridEX.EditControls.EditBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txt_FundCurrentValue = new Janus.Windows.GridEX.EditControls.EditBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnl_Data = new System.Windows.Forms.Panel();
            this.rddl_FundStatus = new Telerik.WinControls.UI.RadDropDownList();
            this.rddl_FundType = new Telerik.WinControls.UI.RadDropDownList();
            this.rddl_BankAccountSubject = new Telerik.WinControls.UI.RadDropDownList();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_FundName = new System.Windows.Forms.Label();
            this.pnl_Action = new System.Windows.Forms.Panel();
            this.btn_FundReload = new System.Windows.Forms.Button();
            this.rgv_Fund = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).BeginInit();
            this.pnl_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rddl_FundStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddl_FundType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddl_BankAccountSubject)).BeginInit();
            this.pnl_Action.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_Fund)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_Fund.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegister.BackColor = System.Drawing.Color.White;
            this.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRegister.Enabled = false;
            this.btnRegister.Image = ((System.Drawing.Image)(resources.GetObject("btnRegister.Image")));
            this.btnRegister.Location = new System.Drawing.Point(802, 2);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(31, 31);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(176, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 14);
            this.label6.TabIndex = 131;
            this.label6.Text = "وضعیت";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(742, 2);
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
            this.btnModify.Location = new System.Drawing.Point(772, 2);
            this.btnModify.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(31, 31);
            this.btnModify.TabIndex = 2;
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(493, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 125;
            this.label9.Text = "توضیحات";
            // 
            // txt_FundDescription
            // 
            this.txt_FundDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_FundDescription.BackColor = System.Drawing.Color.FloralWhite;
            this.txt_FundDescription.BorderStyle = Janus.Windows.GridEX.BorderStyle.RaisedLight3D;
            this.txt_FundDescription.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_FundDescription.HideSelection = false;
            this.txt_FundDescription.HoverMode = Janus.Windows.GridEX.HoverMode.Highlight;
            this.txt_FundDescription.Location = new System.Drawing.Point(19, 41);
            this.txt_FundDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_FundDescription.Multiline = true;
            this.txt_FundDescription.Name = "txt_FundDescription";
            this.txt_FundDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_FundDescription.Size = new System.Drawing.Size(446, 45);
            this.txt_FundDescription.TabIndex = 4;
            this.txt_FundDescription.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
            this.txt_FundDescription.UseCompatibleTextRendering = true;
            this.txt_FundDescription.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            this.txt_FundDescription.TextChanged += new System.EventHandler(this.txt_FundCurrentValue_TextChanged);
            this.txt_FundDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rddl_FundType_KeyDown);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(471, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 123;
            this.label3.Text = "موجودی جاری";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancel.Enabled = false;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(712, 2);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(31, 31);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsert.BackColor = System.Drawing.Color.White;
            this.btnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInsert.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnInsert.Image = ((System.Drawing.Image)(resources.GetObject("btnInsert.Image")));
            this.btnInsert.Location = new System.Drawing.Point(832, 2);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(31, 31);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txt_FundCurrentValue
            // 
            this.txt_FundCurrentValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_FundCurrentValue.BackColor = System.Drawing.Color.FloralWhite;
            this.txt_FundCurrentValue.BorderStyle = Janus.Windows.GridEX.BorderStyle.RaisedLight3D;
            this.txt_FundCurrentValue.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_FundCurrentValue.HideSelection = false;
            this.txt_FundCurrentValue.HoverMode = Janus.Windows.GridEX.HoverMode.Highlight;
            this.txt_FundCurrentValue.Location = new System.Drawing.Point(273, 8);
            this.txt_FundCurrentValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_FundCurrentValue.Name = "txt_FundCurrentValue";
            this.txt_FundCurrentValue.Size = new System.Drawing.Size(192, 23);
            this.txt_FundCurrentValue.TabIndex = 2;
            this.txt_FundCurrentValue.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.txt_FundCurrentValue.UseCompatibleTextRendering = true;
            this.txt_FundCurrentValue.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            this.txt_FundCurrentValue.TextChanged += new System.EventHandler(this.txt_FundCurrentValue_TextChanged);
            this.txt_FundCurrentValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_FundPrimaryValue_KeyDown);
            this.txt_FundCurrentValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_FundPrimaryValue_KeyPress);
            this.txt_FundCurrentValue.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_FundPrimaryValue_KeyUp);
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
            // pnl_Data
            // 
            this.pnl_Data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.pnl_Data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Data.Controls.Add(this.rddl_FundStatus);
            this.pnl_Data.Controls.Add(this.rddl_FundType);
            this.pnl_Data.Controls.Add(this.rddl_BankAccountSubject);
            this.pnl_Data.Controls.Add(this.label2);
            this.pnl_Data.Controls.Add(this.label6);
            this.pnl_Data.Controls.Add(this.label9);
            this.pnl_Data.Controls.Add(this.txt_FundDescription);
            this.pnl_Data.Controls.Add(this.txt_FundCurrentValue);
            this.pnl_Data.Controls.Add(this.label3);
            this.pnl_Data.Controls.Add(this.label4);
            this.pnl_Data.Controls.Add(this.lbl_FundName);
            this.pnl_Data.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Data.Enabled = false;
            this.pnl_Data.Location = new System.Drawing.Point(0, 27);
            this.pnl_Data.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_Data.Name = "pnl_Data";
            this.pnl_Data.Size = new System.Drawing.Size(867, 95);
            this.pnl_Data.TabIndex = 0;
            // 
            // rddl_FundStatus
            // 
            this.rddl_FundStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rddl_FundStatus.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.rddl_FundStatus.Font = new System.Drawing.Font("Tornado Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rddl_FundStatus.Location = new System.Drawing.Point(19, 9);
            this.rddl_FundStatus.MaxDropDownItems = 10;
            this.rddl_FundStatus.Name = "rddl_FundStatus";
            this.rddl_FundStatus.Size = new System.Drawing.Size(151, 22);
            this.rddl_FundStatus.TabIndex = 3;
            this.rddl_FundStatus.TextChanged += new System.EventHandler(this.rddl_FundStatus_TextChanged);
            this.rddl_FundStatus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rddl_FundType_KeyDown);
            this.rddl_FundStatus.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.rddl_BankAccountSubject_SelectedIndexChanged);
            // 
            // rddl_FundType
            // 
            this.rddl_FundType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rddl_FundType.AutoSize = false;
            this.rddl_FundType.AutoSizeItems = true;
            this.rddl_FundType.BackColor = System.Drawing.Color.White;
            this.rddl_FundType.DropDownAnimationEasing = Telerik.WinControls.RadEasingType.InCubic;
            this.rddl_FundType.DropDownSizingMode = ((Telerik.WinControls.UI.SizingMode)((Telerik.WinControls.UI.SizingMode.RightBottom | Telerik.WinControls.UI.SizingMode.UpDown)));
            this.rddl_FundType.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.rddl_FundType.EnableAlternatingItemColor = true;
            this.rddl_FundType.Font = new System.Drawing.Font("Tornado Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            radListDataItem1.Font = new System.Drawing.Font("Tornado Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            radListDataItem1.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            radListDataItem1.Text = "حساب بانکی";
            radListDataItem1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            radListDataItem2.Font = new System.Drawing.Font("Tornado Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            radListDataItem2.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            radListDataItem2.Text = "سایر";
            radListDataItem2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.rddl_FundType.Items.Add(radListDataItem1);
            this.rddl_FundType.Items.Add(radListDataItem2);
            this.rddl_FundType.Location = new System.Drawing.Point(588, 6);
            this.rddl_FundType.Name = "rddl_FundType";
            this.rddl_FundType.Size = new System.Drawing.Size(185, 29);
            this.rddl_FundType.TabIndex = 0;
            this.rddl_FundType.TextChanged += new System.EventHandler(this.txt_FundCurrentValue_TextChanged);
            this.rddl_FundType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rddl_FundType_KeyDown);
            this.rddl_FundType.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.rddl_FundType_SelectedIndexChanged);
            // 
            // rddl_BankAccountSubject
            // 
            this.rddl_BankAccountSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rddl_BankAccountSubject.AutoSize = false;
            this.rddl_BankAccountSubject.AutoSizeItems = true;
            this.rddl_BankAccountSubject.BackColor = System.Drawing.Color.White;
            this.rddl_BankAccountSubject.DropDownAnimationEasing = Telerik.WinControls.RadEasingType.InCubic;
            this.rddl_BankAccountSubject.DropDownSizingMode = ((Telerik.WinControls.UI.SizingMode)((Telerik.WinControls.UI.SizingMode.RightBottom | Telerik.WinControls.UI.SizingMode.UpDown)));
            this.rddl_BankAccountSubject.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.rddl_BankAccountSubject.EnableAlternatingItemColor = true;
            this.rddl_BankAccountSubject.Font = new System.Drawing.Font("Tornado Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rddl_BankAccountSubject.Location = new System.Drawing.Point(588, 48);
            this.rddl_BankAccountSubject.Name = "rddl_BankAccountSubject";
            this.rddl_BankAccountSubject.Size = new System.Drawing.Size(185, 29);
            this.rddl_BankAccountSubject.TabIndex = 1;
            this.rddl_BankAccountSubject.TextChanged += new System.EventHandler(this.txt_FundCurrentValue_TextChanged);
            this.rddl_BankAccountSubject.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rddl_FundType_KeyDown);
            this.rddl_BankAccountSubject.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.rddl_BankAccountSubject_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(241, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 14);
            this.label2.TabIndex = 131;
            this.label2.Text = "ریال";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(796, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 123;
            this.label4.Text = "نوع صندوق";
            // 
            // lbl_FundName
            // 
            this.lbl_FundName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_FundName.AutoSize = true;
            this.lbl_FundName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FundName.Location = new System.Drawing.Point(790, 54);
            this.lbl_FundName.Name = "lbl_FundName";
            this.lbl_FundName.Size = new System.Drawing.Size(67, 13);
            this.lbl_FundName.TabIndex = 123;
            this.lbl_FundName.Text = "عنوان حساب";
            // 
            // pnl_Action
            // 
            this.pnl_Action.AutoSize = true;
            this.pnl_Action.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.pnl_Action.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Action.Controls.Add(this.btn_FundReload);
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
            this.pnl_Action.Size = new System.Drawing.Size(867, 39);
            this.pnl_Action.TabIndex = 0;
            // 
            // btn_FundReload
            // 
            this.btn_FundReload.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_FundReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.btn_FundReload.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btn_FundReload.FlatAppearance.BorderSize = 2;
            this.btn_FundReload.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_FundReload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.btn_FundReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FundReload.Font = new System.Drawing.Font("Tornado Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_FundReload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_FundReload.Location = new System.Drawing.Point(382, 4);
            this.btn_FundReload.Name = "btn_FundReload";
            this.btn_FundReload.Size = new System.Drawing.Size(100, 29);
            this.btn_FundReload.TabIndex = 6;
            this.btn_FundReload.Text = "بارگذاری مجدد";
            this.btn_FundReload.UseVisualStyleBackColor = false;
            this.btn_FundReload.Click += new System.EventHandler(this.btn_FundReload_Click);
            // 
            // rgv_Fund
            // 
            this.rgv_Fund.AutoScroll = true;
            this.rgv_Fund.BackColor = System.Drawing.SystemColors.Control;
            this.rgv_Fund.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_Fund.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rgv_Fund.EnterKeyMode = Telerik.WinControls.UI.RadGridViewEnterKeyMode.EnterMovesToNextRow;
            this.rgv_Fund.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rgv_Fund.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgv_Fund.GroupExpandAnimationType = Telerik.WinControls.UI.GridExpandAnimationType.Slide;
            this.rgv_Fund.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_Fund.Location = new System.Drawing.Point(0, 161);
            this.rgv_Fund.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // 
            // 
            this.rgv_Fund.MasterTemplate.AllowAddNewRow = false;
            this.rgv_Fund.MasterTemplate.AllowCellContextMenu = false;
            this.rgv_Fund.MasterTemplate.AllowDeleteRow = false;
            this.rgv_Fund.MasterTemplate.AllowEditRow = false;
            this.rgv_Fund.MasterTemplate.AllowRowResize = false;
            this.rgv_Fund.MasterTemplate.AutoExpandGroups = true;
            this.rgv_Fund.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "FundId";
            gridViewTextBoxColumn1.HeaderText = "شناسه";
            gridViewTextBoxColumn1.Name = "FundId";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn1.Width = 53;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "FundTypeName";
            gridViewTextBoxColumn2.HeaderText = "نوع صندوق";
            gridViewTextBoxColumn2.Name = "FundTypeName";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn2.Width = 121;
            gridViewTextBoxColumn3.FieldName = "FundTypeId";
            gridViewTextBoxColumn3.HeaderText = "کد نوع صندوق";
            gridViewTextBoxColumn3.IsVisible = false;
            gridViewTextBoxColumn3.Name = "FundTypeId";
            gridViewTextBoxColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn4.FieldName = "FundTitle";
            gridViewTextBoxColumn4.HeaderText = "نام صندوق";
            gridViewTextBoxColumn4.Name = "FundTitle";
            gridViewTextBoxColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn4.Width = 220;
            gridViewTextBoxColumn5.FieldName = "BankAccountId";
            gridViewTextBoxColumn5.HeaderText = "کد عنوان حساب";
            gridViewTextBoxColumn5.IsVisible = false;
            gridViewTextBoxColumn5.Name = "BankAccountId";
            gridViewTextBoxColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "BankAccountSubject";
            gridViewTextBoxColumn6.HeaderText = "عنوان حساب";
            gridViewTextBoxColumn6.Name = "BankAccountSubject";
            gridViewTextBoxColumn6.ReadOnly = true;
            gridViewTextBoxColumn6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn6.Width = 220;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "FundPrimaryValue";
            gridViewTextBoxColumn7.FormatString = "{0:n0}";
            gridViewTextBoxColumn7.HeaderText = "مانده اولیه";
            gridViewTextBoxColumn7.Name = "FundPrimaryValue";
            gridViewTextBoxColumn7.ReadOnly = true;
            gridViewTextBoxColumn7.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn7.Width = 137;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "FundCurrentValue";
            gridViewTextBoxColumn8.FormatString = "{0:n0}";
            gridViewTextBoxColumn8.HeaderText = "موجودی جاری";
            gridViewTextBoxColumn8.Name = "FundCurrentValue";
            gridViewTextBoxColumn8.ReadOnly = true;
            gridViewTextBoxColumn8.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn8.Width = 103;
            gridViewTextBoxColumn9.EnableExpressionEditor = false;
            gridViewTextBoxColumn9.FieldName = "FundPersianRegisterDate";
            gridViewTextBoxColumn9.HeaderText = "تاریخ ثبت";
            gridViewTextBoxColumn9.Name = "FundPersianRegisterDate";
            gridViewTextBoxColumn9.ReadOnly = true;
            gridViewTextBoxColumn9.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn9.Width = 121;
            gridViewTextBoxColumn10.EnableExpressionEditor = false;
            gridViewTextBoxColumn10.FieldName = "FundPersianLastUpdate";
            gridViewTextBoxColumn10.HeaderText = "تاریخ آخرین ویرایش";
            gridViewTextBoxColumn10.Name = "FundPersianLastUpdate";
            gridViewTextBoxColumn10.ReadOnly = true;
            gridViewTextBoxColumn10.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn10.Width = 126;
            gridViewTextBoxColumn11.EnableExpressionEditor = false;
            gridViewTextBoxColumn11.FieldName = "FundCreationUserName";
            gridViewTextBoxColumn11.HeaderText = "کاربر ثبت کننده";
            gridViewTextBoxColumn11.Name = "FundCreationUserName";
            gridViewTextBoxColumn11.ReadOnly = true;
            gridViewTextBoxColumn11.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn11.Width = 124;
            gridViewTextBoxColumn12.EnableExpressionEditor = false;
            gridViewTextBoxColumn12.FieldName = "FundStatus";
            gridViewTextBoxColumn12.HeaderText = "وضعیت";
            gridViewTextBoxColumn12.Name = "FundStatus";
            gridViewTextBoxColumn12.ReadOnly = true;
            gridViewTextBoxColumn12.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn12.Width = 88;
            gridViewTextBoxColumn13.EnableExpressionEditor = false;
            gridViewTextBoxColumn13.FieldName = "FundDescription";
            gridViewTextBoxColumn13.HeaderText = "توضیحات";
            gridViewTextBoxColumn13.Name = "FundDescription";
            gridViewTextBoxColumn13.ReadOnly = true;
            gridViewTextBoxColumn13.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn13.Width = 214;
            this.rgv_Fund.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
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
            gridViewTextBoxColumn12,
            gridViewTextBoxColumn13});
            this.rgv_Fund.MasterTemplate.EnableAlternatingRowColor = true;
            this.rgv_Fund.MasterTemplate.EnableFiltering = true;
            this.rgv_Fund.MasterTemplate.ReadOnly = true;
            this.rgv_Fund.MasterTemplate.ShowGroupedColumns = true;
            this.rgv_Fund.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgv_Fund.Name = "rgv_Fund";
            this.rgv_Fund.ReadOnly = true;
            this.rgv_Fund.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rgv_Fund.Size = new System.Drawing.Size(867, 441);
            this.rgv_Fund.TabIndex = 2;
            this.rgv_Fund.CurrentRowChanged += new Telerik.WinControls.UI.CurrentRowChangedEventHandler(this.rgv_Fund_CurrentRowChanged);
            this.rgv_Fund.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.rgv_Fund_CellClick);
            this.rgv_Fund.GroupSummaryEvaluate += new Telerik.WinControls.UI.GroupSummaryEvaluateEventHandler(this.rgv_Fund_GroupSummaryEvaluate);
            // 
            // FrmFund
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 602);
            this.Controls.Add(this.rgv_Fund);
            this.Controls.Add(this.pnl_Action);
            this.Controls.Add(this.pnl_Data);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmFund";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "صندوق";
            this.Controls.SetChildIndex(this.pnl_Data, 0);
            this.Controls.SetChildIndex(this.pnl_Action, 0);
            this.Controls.SetChildIndex(this.rgv_Fund, 0);
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).EndInit();
            this.pnl_Data.ResumeLayout(false);
            this.pnl_Data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rddl_FundStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddl_FundType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddl_BankAccountSubject)).EndInit();
            this.pnl_Action.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgv_Fund.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_Fund)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Label label9;
        private Janus.Windows.GridEX.EditControls.EditBox txt_FundDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnInsert;
        private Janus.Windows.GridEX.EditControls.EditBox txt_FundCurrentValue;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnl_Data;
        private System.Windows.Forms.Panel pnl_Action;
        private Telerik.WinControls.UI.RadGridView rgv_Fund;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_FundName;
        private Telerik.WinControls.UI.RadDropDownList rddl_BankAccountSubject;
        private Telerik.WinControls.UI.RadDropDownList rddl_FundType;
        private Telerik.WinControls.UI.RadDropDownList rddl_FundStatus;
        private System.Windows.Forms.Button btn_FundReload;
    }
}