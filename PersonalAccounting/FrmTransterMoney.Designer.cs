﻿
namespace PersonalAccounting.UI
{
    partial class FrmTransferMoney
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
            AFrmTransferMoney = null;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTransferMoney));
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn14 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.pnl_Data = new System.Windows.Forms.Panel();
            this.rddl_DestFund = new Telerik.WinControls.UI.RadDropDownList();
            this.rddl_OriginFund = new Telerik.WinControls.UI.RadDropDownList();
            this.txt_DestFundRemain = new System.Windows.Forms.TextBox();
            this.txt_OriginFundRemain = new System.Windows.Forms.TextBox();
            this.txt_BankCommission = new Janus.Windows.GridEX.EditControls.EditBox();
            this.lbl_BankCommission = new System.Windows.Forms.Label();
            this.txt_TransferValue = new Janus.Windows.GridEX.EditControls.EditBox();
            this.lbl_TransferValue = new System.Windows.Forms.Label();
            this.txt_TransferDescription = new Janus.Windows.GridEX.EditControls.EditBox();
            this.lbl_TransferDescription = new System.Windows.Forms.Label();
            this.lbl_SecondAccount = new System.Windows.Forms.Label();
            this.lbl_DestFundRemain = new System.Windows.Forms.Label();
            this.lbl_OriginFundRemain = new System.Windows.Forms.Label();
            this.lbl_FirstAccount = new System.Windows.Forms.Label();
            this.pnl_Action = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.rgv_TransferMoney = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).BeginInit();
            this.pnl_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rddl_DestFund)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddl_OriginFund)).BeginInit();
            this.pnl_Action.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_TransferMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_TransferMoney.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Data
            // 
            this.pnl_Data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.pnl_Data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Data.Controls.Add(this.rddl_DestFund);
            this.pnl_Data.Controls.Add(this.rddl_OriginFund);
            this.pnl_Data.Controls.Add(this.txt_DestFundRemain);
            this.pnl_Data.Controls.Add(this.txt_OriginFundRemain);
            this.pnl_Data.Controls.Add(this.txt_BankCommission);
            this.pnl_Data.Controls.Add(this.lbl_BankCommission);
            this.pnl_Data.Controls.Add(this.txt_TransferValue);
            this.pnl_Data.Controls.Add(this.lbl_TransferValue);
            this.pnl_Data.Controls.Add(this.txt_TransferDescription);
            this.pnl_Data.Controls.Add(this.lbl_TransferDescription);
            this.pnl_Data.Controls.Add(this.lbl_SecondAccount);
            this.pnl_Data.Controls.Add(this.lbl_DestFundRemain);
            this.pnl_Data.Controls.Add(this.lbl_OriginFundRemain);
            this.pnl_Data.Controls.Add(this.lbl_FirstAccount);
            this.pnl_Data.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Data.Enabled = false;
            this.pnl_Data.Location = new System.Drawing.Point(0, 27);
            this.pnl_Data.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_Data.Name = "pnl_Data";
            this.pnl_Data.Size = new System.Drawing.Size(813, 184);
            this.pnl_Data.TabIndex = 2;
            // 
            // rddl_DestFund
            // 
            this.rddl_DestFund.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rddl_DestFund.AutoSize = false;
            this.rddl_DestFund.AutoSizeItems = true;
            this.rddl_DestFund.BackColor = System.Drawing.Color.White;
            this.rddl_DestFund.DropDownAnimationEasing = Telerik.WinControls.RadEasingType.InCubic;
            this.rddl_DestFund.DropDownSizingMode = ((Telerik.WinControls.UI.SizingMode)((Telerik.WinControls.UI.SizingMode.RightBottom | Telerik.WinControls.UI.SizingMode.UpDown)));
            this.rddl_DestFund.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.rddl_DestFund.EnableAlternatingItemColor = true;
            this.rddl_DestFund.Font = new System.Drawing.Font("Tornado Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rddl_DestFund.Location = new System.Drawing.Point(46, 42);
            this.rddl_DestFund.Name = "rddl_DestFund";
            this.rddl_DestFund.Size = new System.Drawing.Size(241, 29);
            this.rddl_DestFund.TabIndex = 129;
            this.rddl_DestFund.TextChanged += new System.EventHandler(this.rddl_OriginAccount_TextChanged);
            this.rddl_DestFund.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.rddl_DestAccount_SelectedIndexChanged);
            // 
            // rddl_OriginFund
            // 
            this.rddl_OriginFund.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rddl_OriginFund.AutoSize = false;
            this.rddl_OriginFund.AutoSizeItems = true;
            this.rddl_OriginFund.BackColor = System.Drawing.Color.White;
            this.rddl_OriginFund.DropDownAnimationEasing = Telerik.WinControls.RadEasingType.InCubic;
            this.rddl_OriginFund.DropDownSizingMode = ((Telerik.WinControls.UI.SizingMode)((Telerik.WinControls.UI.SizingMode.RightBottom | Telerik.WinControls.UI.SizingMode.UpDown)));
            this.rddl_OriginFund.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.rddl_OriginFund.EnableAlternatingItemColor = true;
            this.rddl_OriginFund.Font = new System.Drawing.Font("Tornado Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rddl_OriginFund.Location = new System.Drawing.Point(435, 42);
            this.rddl_OriginFund.Name = "rddl_OriginFund";
            this.rddl_OriginFund.Size = new System.Drawing.Size(241, 29);
            this.rddl_OriginFund.TabIndex = 129;
            this.rddl_OriginFund.TextChanged += new System.EventHandler(this.rddl_OriginAccount_TextChanged);
            this.rddl_OriginFund.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.rddl_OriginAccount_SelectedIndexChanged);
            // 
            // txt_DestFundRemain
            // 
            this.txt_DestFundRemain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_DestFundRemain.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_DestFundRemain.ForeColor = System.Drawing.Color.Red;
            this.txt_DestFundRemain.Location = new System.Drawing.Point(88, 3);
            this.txt_DestFundRemain.Name = "txt_DestFundRemain";
            this.txt_DestFundRemain.ReadOnly = true;
            this.txt_DestFundRemain.Size = new System.Drawing.Size(168, 24);
            this.txt_DestFundRemain.TabIndex = 128;
            this.txt_DestFundRemain.Text = "0";
            this.txt_DestFundRemain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_OriginFundRemain
            // 
            this.txt_OriginFundRemain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_OriginFundRemain.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_OriginFundRemain.ForeColor = System.Drawing.Color.Red;
            this.txt_OriginFundRemain.Location = new System.Drawing.Point(466, 6);
            this.txt_OriginFundRemain.Name = "txt_OriginFundRemain";
            this.txt_OriginFundRemain.ReadOnly = true;
            this.txt_OriginFundRemain.Size = new System.Drawing.Size(168, 24);
            this.txt_OriginFundRemain.TabIndex = 128;
            this.txt_OriginFundRemain.Text = "0";
            this.txt_OriginFundRemain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_BankCommission
            // 
            this.txt_BankCommission.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_BankCommission.BackColor = System.Drawing.Color.FloralWhite;
            this.txt_BankCommission.BorderStyle = Janus.Windows.GridEX.BorderStyle.RaisedLight3D;
            this.txt_BankCommission.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_BankCommission.HideSelection = false;
            this.txt_BankCommission.HoverMode = Janus.Windows.GridEX.HoverMode.Highlight;
            this.txt_BankCommission.Location = new System.Drawing.Point(46, 81);
            this.txt_BankCommission.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_BankCommission.Name = "txt_BankCommission";
            this.txt_BankCommission.Size = new System.Drawing.Size(241, 23);
            this.txt_BankCommission.TabIndex = 126;
            this.txt_BankCommission.Text = "0";
            this.txt_BankCommission.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.txt_BankCommission.UseCompatibleTextRendering = true;
            this.txt_BankCommission.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            this.txt_BankCommission.TextChanged += new System.EventHandler(this.rddl_OriginAccount_TextChanged);
            this.txt_BankCommission.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_TransferValue_KeyDown);
            this.txt_BankCommission.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TransferValue_KeyPress);
            this.txt_BankCommission.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_BankCommission_KeyUp);
            // 
            // lbl_BankCommission
            // 
            this.lbl_BankCommission.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_BankCommission.AutoSize = true;
            this.lbl_BankCommission.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BankCommission.Location = new System.Drawing.Point(293, 90);
            this.lbl_BankCommission.Name = "lbl_BankCommission";
            this.lbl_BankCommission.Size = new System.Drawing.Size(90, 13);
            this.lbl_BankCommission.TabIndex = 127;
            this.lbl_BankCommission.Text = "کارمزد بانک به ریال";
            // 
            // txt_TransferValue
            // 
            this.txt_TransferValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_TransferValue.BackColor = System.Drawing.Color.FloralWhite;
            this.txt_TransferValue.BorderStyle = Janus.Windows.GridEX.BorderStyle.RaisedLight3D;
            this.txt_TransferValue.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_TransferValue.HideSelection = false;
            this.txt_TransferValue.HoverMode = Janus.Windows.GridEX.HoverMode.Highlight;
            this.txt_TransferValue.Location = new System.Drawing.Point(435, 81);
            this.txt_TransferValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_TransferValue.Name = "txt_TransferValue";
            this.txt_TransferValue.Size = new System.Drawing.Size(241, 23);
            this.txt_TransferValue.TabIndex = 126;
            this.txt_TransferValue.Text = "0";
            this.txt_TransferValue.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.txt_TransferValue.UseCompatibleTextRendering = true;
            this.txt_TransferValue.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            this.txt_TransferValue.TextChanged += new System.EventHandler(this.rddl_OriginAccount_TextChanged);
            this.txt_TransferValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_TransferValue_KeyDown);
            this.txt_TransferValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TransferValue_KeyPress);
            this.txt_TransferValue.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_TransferValue_KeyUp);
            // 
            // lbl_TransferValue
            // 
            this.lbl_TransferValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_TransferValue.AutoSize = true;
            this.lbl_TransferValue.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TransferValue.Location = new System.Drawing.Point(713, 90);
            this.lbl_TransferValue.Name = "lbl_TransferValue";
            this.lbl_TransferValue.Size = new System.Drawing.Size(59, 13);
            this.lbl_TransferValue.TabIndex = 127;
            this.lbl_TransferValue.Text = "مبلغ به ریال";
            // 
            // txt_TransferDescription
            // 
            this.txt_TransferDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_TransferDescription.BackColor = System.Drawing.Color.FloralWhite;
            this.txt_TransferDescription.BorderStyle = Janus.Windows.GridEX.BorderStyle.RaisedLight3D;
            this.txt_TransferDescription.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_TransferDescription.HideSelection = false;
            this.txt_TransferDescription.HoverMode = Janus.Windows.GridEX.HoverMode.Highlight;
            this.txt_TransferDescription.Location = new System.Drawing.Point(11, 117);
            this.txt_TransferDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_TransferDescription.Multiline = true;
            this.txt_TransferDescription.Name = "txt_TransferDescription";
            this.txt_TransferDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_TransferDescription.Size = new System.Drawing.Size(665, 56);
            this.txt_TransferDescription.TabIndex = 5;
            this.txt_TransferDescription.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
            this.txt_TransferDescription.UseCompatibleTextRendering = true;
            this.txt_TransferDescription.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            this.txt_TransferDescription.TextChanged += new System.EventHandler(this.rddl_OriginAccount_TextChanged);
            // 
            // lbl_TransferDescription
            // 
            this.lbl_TransferDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_TransferDescription.AutoSize = true;
            this.lbl_TransferDescription.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TransferDescription.Location = new System.Drawing.Point(729, 129);
            this.lbl_TransferDescription.Name = "lbl_TransferDescription";
            this.lbl_TransferDescription.Size = new System.Drawing.Size(47, 13);
            this.lbl_TransferDescription.TabIndex = 125;
            this.lbl_TransferDescription.Text = "توضیحات";
            // 
            // lbl_SecondAccount
            // 
            this.lbl_SecondAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_SecondAccount.AutoSize = true;
            this.lbl_SecondAccount.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SecondAccount.Location = new System.Drawing.Point(304, 44);
            this.lbl_SecondAccount.Name = "lbl_SecondAccount";
            this.lbl_SecondAccount.Size = new System.Drawing.Size(68, 13);
            this.lbl_SecondAccount.TabIndex = 123;
            this.lbl_SecondAccount.Text = "حساب مقصد";
            // 
            // lbl_DestFundRemain
            // 
            this.lbl_DestFundRemain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_DestFundRemain.AutoSize = true;
            this.lbl_DestFundRemain.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DestFundRemain.ForeColor = System.Drawing.Color.Navy;
            this.lbl_DestFundRemain.Location = new System.Drawing.Point(262, 12);
            this.lbl_DestFundRemain.Name = "lbl_DestFundRemain";
            this.lbl_DestFundRemain.Size = new System.Drawing.Size(102, 13);
            this.lbl_DestFundRemain.TabIndex = 123;
            this.lbl_DestFundRemain.Text = "مانده حساب مبدا: ";
            // 
            // lbl_OriginFundRemain
            // 
            this.lbl_OriginFundRemain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_OriginFundRemain.AutoSize = true;
            this.lbl_OriginFundRemain.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OriginFundRemain.ForeColor = System.Drawing.Color.Navy;
            this.lbl_OriginFundRemain.Location = new System.Drawing.Point(650, 12);
            this.lbl_OriginFundRemain.Name = "lbl_OriginFundRemain";
            this.lbl_OriginFundRemain.Size = new System.Drawing.Size(108, 13);
            this.lbl_OriginFundRemain.TabIndex = 123;
            this.lbl_OriginFundRemain.Text = "مانده حساب مقصد:";
            // 
            // lbl_FirstAccount
            // 
            this.lbl_FirstAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_FirstAccount.AutoSize = true;
            this.lbl_FirstAccount.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FirstAccount.Location = new System.Drawing.Point(716, 44);
            this.lbl_FirstAccount.Name = "lbl_FirstAccount";
            this.lbl_FirstAccount.Size = new System.Drawing.Size(60, 13);
            this.lbl_FirstAccount.TabIndex = 123;
            this.lbl_FirstAccount.Text = "حساب مبدا";
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
            this.pnl_Action.Location = new System.Drawing.Point(0, 211);
            this.pnl_Action.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_Action.Name = "pnl_Action";
            this.pnl_Action.Size = new System.Drawing.Size(813, 41);
            this.pnl_Action.TabIndex = 3;
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
            this.btnCancel.Location = new System.Drawing.Point(631, 2);
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
            this.btnDelete.Location = new System.Drawing.Point(666, 2);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(36, 33);
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
            this.btnModify.Location = new System.Drawing.Point(701, 2);
            this.btnModify.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(36, 33);
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
            this.btnRegister.Location = new System.Drawing.Point(736, 2);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(36, 33);
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
            this.btnInsert.Location = new System.Drawing.Point(771, 2);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(36, 33);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // rgv_TransferMoney
            // 
            this.rgv_TransferMoney.AutoScroll = true;
            this.rgv_TransferMoney.BackColor = System.Drawing.SystemColors.Control;
            this.rgv_TransferMoney.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_TransferMoney.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rgv_TransferMoney.EnableHotTracking = false;
            this.rgv_TransferMoney.EnterKeyMode = Telerik.WinControls.UI.RadGridViewEnterKeyMode.EnterMovesToNextRow;
            this.rgv_TransferMoney.Font = new System.Drawing.Font("Tornado Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rgv_TransferMoney.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgv_TransferMoney.GroupExpandAnimationType = Telerik.WinControls.UI.GridExpandAnimationType.Slide;
            this.rgv_TransferMoney.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_TransferMoney.Location = new System.Drawing.Point(0, 252);
            this.rgv_TransferMoney.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // 
            // 
            this.rgv_TransferMoney.MasterTemplate.AllowAddNewRow = false;
            this.rgv_TransferMoney.MasterTemplate.AllowCellContextMenu = false;
            this.rgv_TransferMoney.MasterTemplate.AllowDeleteRow = false;
            this.rgv_TransferMoney.MasterTemplate.AllowEditRow = false;
            this.rgv_TransferMoney.MasterTemplate.AllowRowResize = false;
            this.rgv_TransferMoney.MasterTemplate.AutoExpandGroups = true;
            this.rgv_TransferMoney.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "TransferMoneyId";
            gridViewTextBoxColumn1.HeaderText = "شناسه";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "TransferMoneyId";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn1.Width = 62;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "OriginFundId";
            gridViewTextBoxColumn2.HeaderText = "کد حساب مبدا";
            gridViewTextBoxColumn2.IsVisible = false;
            gridViewTextBoxColumn2.Name = "OriginFundId";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn2.Width = 84;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "OriginFundName";
            gridViewTextBoxColumn3.HeaderText = "حساب مبدا";
            gridViewTextBoxColumn3.Name = "OriginFundName";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn3.Width = 200;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "DestinationFundId";
            gridViewTextBoxColumn4.HeaderText = "کد حساب مقصد";
            gridViewTextBoxColumn4.IsVisible = false;
            gridViewTextBoxColumn4.Name = "DestinationFundId";
            gridViewTextBoxColumn4.ReadOnly = true;
            gridViewTextBoxColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn4.Width = 93;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "DestinationFundName";
            gridViewTextBoxColumn5.HeaderText = "حساب مقصد";
            gridViewTextBoxColumn5.Name = "DestinationFundName";
            gridViewTextBoxColumn5.ReadOnly = true;
            gridViewTextBoxColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn5.Width = 200;
            gridViewTextBoxColumn6.FieldName = "Amount";
            gridViewTextBoxColumn6.HeaderText = "مبلغ";
            gridViewTextBoxColumn6.IsVisible = false;
            gridViewTextBoxColumn6.Name = "Amount";
            gridViewTextBoxColumn6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn6.Width = 81;
            gridViewTextBoxColumn7.FieldName = "AmountSeparateDigit";
            gridViewTextBoxColumn7.HeaderText = "مبلغ";
            gridViewTextBoxColumn7.Name = "AmountSeparateDigit";
            gridViewTextBoxColumn7.ReadOnly = true;
            gridViewTextBoxColumn7.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn7.Width = 150;
            gridViewTextBoxColumn8.FieldName = "BankCommission";
            gridViewTextBoxColumn8.HeaderText = "کارمزد بانکی";
            gridViewTextBoxColumn8.IsVisible = false;
            gridViewTextBoxColumn8.Name = "BankCommission";
            gridViewTextBoxColumn8.ReadOnly = true;
            gridViewTextBoxColumn8.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn8.Width = 81;
            gridViewTextBoxColumn9.FieldName = "BankCommissionSeparateDigit";
            gridViewTextBoxColumn9.HeaderText = "کارمزد بانکی";
            gridViewTextBoxColumn9.Name = "BankCommissionSeparateDigit";
            gridViewTextBoxColumn9.ReadOnly = true;
            gridViewTextBoxColumn9.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn9.Width = 120;
            gridViewTextBoxColumn10.EnableExpressionEditor = false;
            gridViewTextBoxColumn10.FieldName = "TransferMoneyPersianRegisterDate";
            gridViewTextBoxColumn10.HeaderText = "تاریخ ثبت";
            gridViewTextBoxColumn10.Name = "TransferMoneyPersianRegisterDate";
            gridViewTextBoxColumn10.ReadOnly = true;
            gridViewTextBoxColumn10.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn10.Width = 120;
            gridViewTextBoxColumn11.EnableExpressionEditor = false;
            gridViewTextBoxColumn11.FieldName = "TransferMoneyPersianLastUpdate";
            gridViewTextBoxColumn11.HeaderText = "تاریخ آخرین ویرایش";
            gridViewTextBoxColumn11.Name = "TransferMoneyPersianLastUpdate";
            gridViewTextBoxColumn11.ReadOnly = true;
            gridViewTextBoxColumn11.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn11.Width = 120;
            gridViewTextBoxColumn12.EnableExpressionEditor = false;
            gridViewTextBoxColumn12.FieldName = "TransferMoneyCreationUserName";
            gridViewTextBoxColumn12.HeaderText = "کاربر ثبت کننده";
            gridViewTextBoxColumn12.Name = "TransferMoneyCreationUserName";
            gridViewTextBoxColumn12.ReadOnly = true;
            gridViewTextBoxColumn12.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn12.Width = 85;
            gridViewTextBoxColumn13.EnableExpressionEditor = false;
            gridViewTextBoxColumn13.FieldName = "TransferMoneyStatus";
            gridViewTextBoxColumn13.HeaderText = "وضعیت";
            gridViewTextBoxColumn13.Name = "TransferMoneyStatus";
            gridViewTextBoxColumn13.ReadOnly = true;
            gridViewTextBoxColumn13.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn13.Width = 81;
            gridViewTextBoxColumn14.FieldName = "TransferMoneyDescription";
            gridViewTextBoxColumn14.HeaderText = "توضیحات";
            gridViewTextBoxColumn14.Name = "TransferMoneyDescription";
            gridViewTextBoxColumn14.ReadOnly = true;
            gridViewTextBoxColumn14.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn14.Width = 120;
            this.rgv_TransferMoney.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
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
            gridViewTextBoxColumn13,
            gridViewTextBoxColumn14});
            this.rgv_TransferMoney.MasterTemplate.EnableAlternatingRowColor = true;
            this.rgv_TransferMoney.MasterTemplate.EnableFiltering = true;
            this.rgv_TransferMoney.MasterTemplate.ReadOnly = true;
            this.rgv_TransferMoney.MasterTemplate.ShowGroupedColumns = true;
            sortDescriptor1.Direction = System.ComponentModel.ListSortDirection.Descending;
            sortDescriptor1.PropertyName = "BankAccountSubject";
            this.rgv_TransferMoney.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.rgv_TransferMoney.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgv_TransferMoney.Name = "rgv_TransferMoney";
            this.rgv_TransferMoney.ReadOnly = true;
            this.rgv_TransferMoney.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rgv_TransferMoney.Size = new System.Drawing.Size(813, 349);
            this.rgv_TransferMoney.TabIndex = 4;
            this.rgv_TransferMoney.CurrentRowChanged += new Telerik.WinControls.UI.CurrentRowChangedEventHandler(this.rgv_TransferMoney_CurrentRowChanged);
            this.rgv_TransferMoney.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.rgv_TransferMoney_CellClick);
            this.rgv_TransferMoney.Click += new System.EventHandler(this.rgv_TransferMoney_Click);
            // 
            // FrmTransferMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 601);
            this.Controls.Add(this.rgv_TransferMoney);
            this.Controls.Add(this.pnl_Action);
            this.Controls.Add(this.pnl_Data);
            this.Font = new System.Drawing.Font("Tornado Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmTransferMoney";
            this.Text = "فرم انتقال بین حسابها";
            this.Load += new System.EventHandler(this.FrmTransferMoney_Load);
            this.Controls.SetChildIndex(this.pnl_Data, 0);
            this.Controls.SetChildIndex(this.pnl_Action, 0);
            this.Controls.SetChildIndex(this.rgv_TransferMoney, 0);
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).EndInit();
            this.pnl_Data.ResumeLayout(false);
            this.pnl_Data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rddl_DestFund)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddl_OriginFund)).EndInit();
            this.pnl_Action.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgv_TransferMoney.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_TransferMoney)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Data;
        private Janus.Windows.GridEX.EditControls.EditBox txt_TransferDescription;
        private System.Windows.Forms.Label lbl_TransferDescription;
        private System.Windows.Forms.Label lbl_SecondAccount;
        private System.Windows.Forms.Label lbl_FirstAccount;
        private Janus.Windows.GridEX.EditControls.EditBox txt_TransferValue;
        private System.Windows.Forms.Label lbl_TransferValue;
        private System.Windows.Forms.Panel pnl_Action;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnInsert;
        private Telerik.WinControls.UI.RadGridView rgv_TransferMoney;
        private Janus.Windows.GridEX.EditControls.EditBox txt_BankCommission;
        private System.Windows.Forms.Label lbl_BankCommission;
        private System.Windows.Forms.Label lbl_DestFundRemain;
        private System.Windows.Forms.Label lbl_OriginFundRemain;
        private System.Windows.Forms.TextBox txt_OriginFundRemain;
        private System.Windows.Forms.TextBox txt_DestFundRemain;
        private Telerik.WinControls.UI.RadDropDownList rddl_OriginFund;
        private Telerik.WinControls.UI.RadDropDownList rddl_DestFund;
    }
}