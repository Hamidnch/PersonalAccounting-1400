
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn33 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn34 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn35 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn36 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn37 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn38 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn39 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn40 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn41 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn42 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn43 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn44 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn45 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn46 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn47 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn48 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor3 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition3 = new Telerik.WinControls.UI.TableViewDefinition();
            this.pnl_Data = new System.Windows.Forms.Panel();
            this.txt_TransferMoneyDate = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.pnl_Data.Controls.Add(this.label4);
            this.pnl_Data.Controls.Add(this.label2);
            this.pnl_Data.Controls.Add(this.txt_TransferMoneyDate);
            this.pnl_Data.Controls.Add(this.label1);
            this.pnl_Data.Controls.Add(this.label3);
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
            this.pnl_Data.Size = new System.Drawing.Size(813, 199);
            this.pnl_Data.TabIndex = 2;
            // 
            // txt_TransferMoneyDate
            // 
            this.txt_TransferMoneyDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_TransferMoneyDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TransferMoneyDate.Enabled = false;
            this.txt_TransferMoneyDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_TransferMoneyDate.Location = new System.Drawing.Point(608, 50);
            this.txt_TransferMoneyDate.Mask = "1000/00/00";
            this.txt_TransferMoneyDate.Name = "txt_TransferMoneyDate";
            this.txt_TransferMoneyDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_TransferMoneyDate.Size = new System.Drawing.Size(83, 20);
            this.txt_TransferMoneyDate.TabIndex = 131;
            this.txt_TransferMoneyDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_TransferMoneyDate.TextChanged += new System.EventHandler(this.rddl_OriginAccount_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(709, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 132;
            this.label1.Text = "تاریخ انتقال";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(9, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(792, 2);
            this.label3.TabIndex = 130;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.rddl_DestFund.Location = new System.Drawing.Point(39, 77);
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
            this.rddl_OriginFund.Location = new System.Drawing.Point(450, 77);
            this.rddl_OriginFund.Name = "rddl_OriginFund";
            this.rddl_OriginFund.Size = new System.Drawing.Size(241, 29);
            this.rddl_OriginFund.TabIndex = 129;
            this.rddl_OriginFund.TextChanged += new System.EventHandler(this.rddl_OriginAccount_TextChanged);
            this.rddl_OriginFund.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.rddl_OriginAccount_SelectedIndexChanged);
            // 
            // txt_DestFundRemain
            // 
            this.txt_DestFundRemain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_DestFundRemain.BackColor = System.Drawing.SystemColors.GrayText;
            this.txt_DestFundRemain.ForeColor = System.Drawing.Color.Gold;
            this.txt_DestFundRemain.Location = new System.Drawing.Point(83, 6);
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
            this.txt_OriginFundRemain.BackColor = System.Drawing.SystemColors.GrayText;
            this.txt_OriginFundRemain.ForeColor = System.Drawing.Color.Gold;
            this.txt_OriginFundRemain.Location = new System.Drawing.Point(488, 6);
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
            this.txt_BankCommission.Location = new System.Drawing.Point(39, 114);
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
            this.lbl_BankCommission.Location = new System.Drawing.Point(286, 119);
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
            this.txt_TransferValue.Location = new System.Drawing.Point(450, 114);
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
            this.lbl_TransferValue.Location = new System.Drawing.Point(712, 119);
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
            this.txt_TransferDescription.Location = new System.Drawing.Point(39, 145);
            this.txt_TransferDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_TransferDescription.Multiline = true;
            this.txt_TransferDescription.Name = "txt_TransferDescription";
            this.txt_TransferDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_TransferDescription.Size = new System.Drawing.Size(652, 42);
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
            this.lbl_TransferDescription.Location = new System.Drawing.Point(721, 157);
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
            this.lbl_SecondAccount.Location = new System.Drawing.Point(308, 84);
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
            this.lbl_DestFundRemain.Location = new System.Drawing.Point(281, 12);
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
            this.lbl_OriginFundRemain.Location = new System.Drawing.Point(671, 12);
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
            this.lbl_FirstAccount.Location = new System.Drawing.Point(711, 84);
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
            this.pnl_Action.Location = new System.Drawing.Point(0, 226);
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
            this.rgv_TransferMoney.Location = new System.Drawing.Point(0, 267);
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
            gridViewTextBoxColumn33.EnableExpressionEditor = false;
            gridViewTextBoxColumn33.FieldName = "TransferMoneyId";
            gridViewTextBoxColumn33.HeaderText = "شناسه";
            gridViewTextBoxColumn33.IsVisible = false;
            gridViewTextBoxColumn33.Name = "TransferMoneyId";
            gridViewTextBoxColumn33.ReadOnly = true;
            gridViewTextBoxColumn33.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn33.Width = 62;
            gridViewTextBoxColumn34.FieldName = "TransferMoneyPersianDate";
            gridViewTextBoxColumn34.HeaderText = "تاریخ  انتقال";
            gridViewTextBoxColumn34.Name = "TransferMoneyPersianDate";
            gridViewTextBoxColumn34.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn34.Width = 150;
            gridViewTextBoxColumn35.EnableExpressionEditor = false;
            gridViewTextBoxColumn35.FieldName = "OriginFundId";
            gridViewTextBoxColumn35.HeaderText = "کد حساب مبدا";
            gridViewTextBoxColumn35.IsVisible = false;
            gridViewTextBoxColumn35.Name = "OriginFundId";
            gridViewTextBoxColumn35.ReadOnly = true;
            gridViewTextBoxColumn35.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn35.Width = 84;
            gridViewTextBoxColumn36.EnableExpressionEditor = false;
            gridViewTextBoxColumn36.FieldName = "OriginFundName";
            gridViewTextBoxColumn36.HeaderText = "حساب مبدا";
            gridViewTextBoxColumn36.Name = "OriginFundName";
            gridViewTextBoxColumn36.ReadOnly = true;
            gridViewTextBoxColumn36.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn36.Width = 200;
            gridViewTextBoxColumn37.EnableExpressionEditor = false;
            gridViewTextBoxColumn37.FieldName = "DestinationFundId";
            gridViewTextBoxColumn37.HeaderText = "کد حساب مقصد";
            gridViewTextBoxColumn37.IsVisible = false;
            gridViewTextBoxColumn37.Name = "DestinationFundId";
            gridViewTextBoxColumn37.ReadOnly = true;
            gridViewTextBoxColumn37.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn37.Width = 93;
            gridViewTextBoxColumn38.EnableExpressionEditor = false;
            gridViewTextBoxColumn38.FieldName = "DestinationFundName";
            gridViewTextBoxColumn38.HeaderText = "حساب مقصد";
            gridViewTextBoxColumn38.Name = "DestinationFundName";
            gridViewTextBoxColumn38.ReadOnly = true;
            gridViewTextBoxColumn38.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn38.Width = 200;
            gridViewTextBoxColumn39.FieldName = "Amount";
            gridViewTextBoxColumn39.HeaderText = "مبلغ";
            gridViewTextBoxColumn39.IsVisible = false;
            gridViewTextBoxColumn39.Name = "Amount";
            gridViewTextBoxColumn39.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn39.Width = 81;
            gridViewTextBoxColumn40.FieldName = "AmountSeparateDigit";
            gridViewTextBoxColumn40.HeaderText = "مبلغ";
            gridViewTextBoxColumn40.Name = "AmountSeparateDigit";
            gridViewTextBoxColumn40.ReadOnly = true;
            gridViewTextBoxColumn40.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn40.Width = 150;
            gridViewTextBoxColumn41.FieldName = "BankCommission";
            gridViewTextBoxColumn41.HeaderText = "کارمزد بانکی";
            gridViewTextBoxColumn41.IsVisible = false;
            gridViewTextBoxColumn41.Name = "BankCommission";
            gridViewTextBoxColumn41.ReadOnly = true;
            gridViewTextBoxColumn41.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn41.Width = 81;
            gridViewTextBoxColumn42.FieldName = "BankCommissionSeparateDigit";
            gridViewTextBoxColumn42.HeaderText = "کارمزد بانکی";
            gridViewTextBoxColumn42.Name = "BankCommissionSeparateDigit";
            gridViewTextBoxColumn42.ReadOnly = true;
            gridViewTextBoxColumn42.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn42.Width = 120;
            gridViewTextBoxColumn43.FieldName = "TransferMoneyPersianRegisterDate";
            gridViewTextBoxColumn43.HeaderText = "تاریخ ثبت";
            gridViewTextBoxColumn43.Name = "TransferMoneyPersianRegisterDate";
            gridViewTextBoxColumn43.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn43.Width = 150;
            gridViewTextBoxColumn44.EnableExpressionEditor = false;
            gridViewTextBoxColumn44.FieldName = "TransferMoneyCreationUserName";
            gridViewTextBoxColumn44.HeaderText = "کاربر ثبت کننده";
            gridViewTextBoxColumn44.Name = "TransferMoneyCreationUserName";
            gridViewTextBoxColumn44.ReadOnly = true;
            gridViewTextBoxColumn44.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn44.Width = 85;
            gridViewTextBoxColumn45.EnableExpressionEditor = false;
            gridViewTextBoxColumn45.FieldName = "TransferMoneyPersianLastUpdate";
            gridViewTextBoxColumn45.HeaderText = "تاریخ آخرین ویرایش";
            gridViewTextBoxColumn45.Name = "TransferMoneyPersianLastUpdate";
            gridViewTextBoxColumn45.ReadOnly = true;
            gridViewTextBoxColumn45.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn45.Width = 120;
            gridViewTextBoxColumn46.FieldName = "TransferMoneyUpdateByUserName";
            gridViewTextBoxColumn46.HeaderText = "کاربر ویرایش کننده";
            gridViewTextBoxColumn46.Name = "TransferMoneyUpdateByUserName";
            gridViewTextBoxColumn46.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn47.EnableExpressionEditor = false;
            gridViewTextBoxColumn47.FieldName = "TransferMoneyStatus";
            gridViewTextBoxColumn47.HeaderText = "وضعیت";
            gridViewTextBoxColumn47.Name = "TransferMoneyStatus";
            gridViewTextBoxColumn47.ReadOnly = true;
            gridViewTextBoxColumn47.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn47.Width = 81;
            gridViewTextBoxColumn48.FieldName = "TransferMoneyDescription";
            gridViewTextBoxColumn48.HeaderText = "توضیحات";
            gridViewTextBoxColumn48.Name = "TransferMoneyDescription";
            gridViewTextBoxColumn48.ReadOnly = true;
            gridViewTextBoxColumn48.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn48.Width = 120;
            this.rgv_TransferMoney.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn33,
            gridViewTextBoxColumn34,
            gridViewTextBoxColumn35,
            gridViewTextBoxColumn36,
            gridViewTextBoxColumn37,
            gridViewTextBoxColumn38,
            gridViewTextBoxColumn39,
            gridViewTextBoxColumn40,
            gridViewTextBoxColumn41,
            gridViewTextBoxColumn42,
            gridViewTextBoxColumn43,
            gridViewTextBoxColumn44,
            gridViewTextBoxColumn45,
            gridViewTextBoxColumn46,
            gridViewTextBoxColumn47,
            gridViewTextBoxColumn48});
            this.rgv_TransferMoney.MasterTemplate.EnableAlternatingRowColor = true;
            this.rgv_TransferMoney.MasterTemplate.EnableFiltering = true;
            this.rgv_TransferMoney.MasterTemplate.ReadOnly = true;
            this.rgv_TransferMoney.MasterTemplate.ShowGroupedColumns = true;
            sortDescriptor3.Direction = System.ComponentModel.ListSortDirection.Descending;
            sortDescriptor3.PropertyName = "BankAccountSubject";
            this.rgv_TransferMoney.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor3});
            this.rgv_TransferMoney.MasterTemplate.ViewDefinition = tableViewDefinition3;
            this.rgv_TransferMoney.Name = "rgv_TransferMoney";
            this.rgv_TransferMoney.ReadOnly = true;
            this.rgv_TransferMoney.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rgv_TransferMoney.Size = new System.Drawing.Size(813, 365);
            this.rgv_TransferMoney.TabIndex = 4;
            this.rgv_TransferMoney.CurrentRowChanged += new Telerik.WinControls.UI.CurrentRowChangedEventHandler(this.rgv_TransferMoney_CurrentRowChanged);
            this.rgv_TransferMoney.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.rgv_TransferMoney_CellClick);
            this.rgv_TransferMoney.Click += new System.EventHandler(this.rgv_TransferMoney_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(461, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 134;
            this.label2.Text = "ریال";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 135;
            this.label4.Text = "ریال";
            // 
            // FrmTransferMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 632);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txt_TransferMoneyDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}