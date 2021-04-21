namespace PersonalAccounting.UI
{
    partial class FrmIncome
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
            AFrmIncome = null;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIncome));
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn76 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn77 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn78 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn79 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn80 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn81 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn82 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn83 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn84 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn85 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn86 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn87 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn88 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn89 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn90 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor6 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition6 = new Telerik.WinControls.UI.TableViewDefinition();
            this.pnl_Action = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.pnl_Data = new System.Windows.Forms.Panel();
            this.rddl_Funds = new Telerik.WinControls.UI.RadDropDownList();
            this.rddl_IncomeTypes = new Telerik.WinControls.UI.RadDropDownList();
            this.txt_IncomeDescription = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_IncomeDate = new System.Windows.Forms.MaskedTextBox();
            this.txt_ReceivedBy = new System.Windows.Forms.TextBox();
            this.txt_IncomePrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rgv_Income = new Telerik.WinControls.UI.RadGridView();
            this.circleShape1 = new Telerik.WinControls.CircleShape();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).BeginInit();
            this.pnl_Action.SuspendLayout();
            this.pnl_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rddl_Funds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddl_IncomeTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_Income)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_Income.MasterTemplate)).BeginInit();
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
            this.pnl_Action.Location = new System.Drawing.Point(0, 170);
            this.pnl_Action.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_Action.Name = "pnl_Action";
            this.pnl_Action.Size = new System.Drawing.Size(855, 39);
            this.pnl_Action.TabIndex = 0;
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
            this.btnCancel.Location = new System.Drawing.Point(699, 2);
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
            this.btnDelete.Location = new System.Drawing.Point(729, 2);
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
            this.btnModify.Location = new System.Drawing.Point(759, 2);
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
            this.btnRegister.Location = new System.Drawing.Point(789, 2);
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
            this.btnInsert.Location = new System.Drawing.Point(819, 2);
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
            this.pnl_Data.Controls.Add(this.rddl_Funds);
            this.pnl_Data.Controls.Add(this.rddl_IncomeTypes);
            this.pnl_Data.Controls.Add(this.txt_IncomeDescription);
            this.pnl_Data.Controls.Add(this.label9);
            this.pnl_Data.Controls.Add(this.txt_IncomeDate);
            this.pnl_Data.Controls.Add(this.txt_ReceivedBy);
            this.pnl_Data.Controls.Add(this.txt_IncomePrice);
            this.pnl_Data.Controls.Add(this.label4);
            this.pnl_Data.Controls.Add(this.label3);
            this.pnl_Data.Controls.Add(this.label5);
            this.pnl_Data.Controls.Add(this.label2);
            this.pnl_Data.Controls.Add(this.label6);
            this.pnl_Data.Controls.Add(this.label1);
            this.pnl_Data.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Data.Enabled = false;
            this.pnl_Data.Location = new System.Drawing.Point(0, 27);
            this.pnl_Data.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_Data.Name = "pnl_Data";
            this.pnl_Data.Size = new System.Drawing.Size(855, 143);
            this.pnl_Data.TabIndex = 1;
            // 
            // rddl_Funds
            // 
            this.rddl_Funds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rddl_Funds.AutoSize = false;
            this.rddl_Funds.AutoSizeItems = true;
            this.rddl_Funds.BackColor = System.Drawing.Color.White;
            this.rddl_Funds.DefaultItemsCountInDropDown = 10;
            this.rddl_Funds.DropDownAnimationEasing = Telerik.WinControls.RadEasingType.InOutExponential;
            this.rddl_Funds.DropDownSizingMode = ((Telerik.WinControls.UI.SizingMode)((Telerik.WinControls.UI.SizingMode.RightBottom | Telerik.WinControls.UI.SizingMode.UpDown)));
            this.rddl_Funds.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.rddl_Funds.EnableAlternatingItemColor = true;
            this.rddl_Funds.Font = new System.Drawing.Font("Tornado Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rddl_Funds.Location = new System.Drawing.Point(59, 39);
            this.rddl_Funds.Name = "rddl_Funds";
            this.rddl_Funds.Size = new System.Drawing.Size(241, 29);
            this.rddl_Funds.TabIndex = 4;
            this.rddl_Funds.TextChanged += new System.EventHandler(this.txt_IncomeDate_TextChanged);
            this.rddl_Funds.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_IncomeDate_KeyDown);
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.rddl_Funds.GetChildAt(0))).RightToLeft = true;
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.rddl_Funds.GetChildAt(0))).DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            // 
            // rddl_IncomeTypes
            // 
            this.rddl_IncomeTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rddl_IncomeTypes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.rddl_IncomeTypes.AutoSize = false;
            this.rddl_IncomeTypes.AutoSizeItems = true;
            this.rddl_IncomeTypes.BackColor = System.Drawing.Color.White;
            this.rddl_IncomeTypes.DefaultItemsCountInDropDown = 10;
            this.rddl_IncomeTypes.DropDownAnimationEasing = Telerik.WinControls.RadEasingType.InBounce;
            this.rddl_IncomeTypes.DropDownSizingMode = ((Telerik.WinControls.UI.SizingMode)((Telerik.WinControls.UI.SizingMode.RightBottom | Telerik.WinControls.UI.SizingMode.UpDown)));
            this.rddl_IncomeTypes.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.rddl_IncomeTypes.EnableAlternatingItemColor = true;
            this.rddl_IncomeTypes.EnableAnalytics = false;
            this.rddl_IncomeTypes.Font = new System.Drawing.Font("Tornado Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rddl_IncomeTypes.Location = new System.Drawing.Point(373, 7);
            this.rddl_IncomeTypes.Name = "rddl_IncomeTypes";
            this.rddl_IncomeTypes.Size = new System.Drawing.Size(241, 29);
            this.rddl_IncomeTypes.TabIndex = 1;
            this.rddl_IncomeTypes.TextChanged += new System.EventHandler(this.txt_IncomeDate_TextChanged);
            this.rddl_IncomeTypes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_IncomeDate_KeyDown);
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.rddl_IncomeTypes.GetChildAt(0))).RightToLeft = true;
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.rddl_IncomeTypes.GetChildAt(0))).DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.rddl_IncomeTypes.GetChildAt(0))).EnableElementShadow = true;
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.rddl_IncomeTypes.GetChildAt(0))).EnableFocusBorder = true;
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.rddl_IncomeTypes.GetChildAt(0))).EnableHighlight = true;
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.rddl_IncomeTypes.GetChildAt(0))).EnableBorderHighlight = true;
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.rddl_IncomeTypes.GetChildAt(0))).BorderHighlightThickness = 1;
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.rddl_IncomeTypes.GetChildAt(0))).ShouldPaint = true;
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.rddl_IncomeTypes.GetChildAt(0))).Shape = null;
            // 
            // txt_IncomeDescription
            // 
            this.txt_IncomeDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_IncomeDescription.BackColor = System.Drawing.Color.FloralWhite;
            this.txt_IncomeDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_IncomeDescription.Location = new System.Drawing.Point(24, 74);
            this.txt_IncomeDescription.Multiline = true;
            this.txt_IncomeDescription.Name = "txt_IncomeDescription";
            this.txt_IncomeDescription.Size = new System.Drawing.Size(753, 60);
            this.txt_IncomeDescription.TabIndex = 5;
            this.txt_IncomeDescription.TextChanged += new System.EventHandler(this.txt_IncomeDate_TextChanged);
            this.txt_IncomeDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_IncomeDate_KeyDown);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(801, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 168;
            this.label9.Text = "توضیحات";
            // 
            // txt_IncomeDate
            // 
            this.txt_IncomeDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_IncomeDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_IncomeDate.Enabled = false;
            this.txt_IncomeDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_IncomeDate.Location = new System.Drawing.Point(694, 10);
            this.txt_IncomeDate.Mask = "1000/00/00";
            this.txt_IncomeDate.Name = "txt_IncomeDate";
            this.txt_IncomeDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_IncomeDate.Size = new System.Drawing.Size(83, 20);
            this.txt_IncomeDate.TabIndex = 0;
            this.txt_IncomeDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_IncomeDate.TextChanged += new System.EventHandler(this.txt_IncomeDate_TextChanged);
            this.txt_IncomeDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_IncomeDate_KeyDown);
            // 
            // txt_ReceivedBy
            // 
            this.txt_ReceivedBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ReceivedBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ReceivedBy.Location = new System.Drawing.Point(413, 42);
            this.txt_ReceivedBy.Name = "txt_ReceivedBy";
            this.txt_ReceivedBy.Size = new System.Drawing.Size(364, 21);
            this.txt_ReceivedBy.TabIndex = 3;
            this.txt_ReceivedBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_ReceivedBy.TextChanged += new System.EventHandler(this.txt_IncomeDate_TextChanged);
            // 
            // txt_IncomePrice
            // 
            this.txt_IncomePrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_IncomePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_IncomePrice.Location = new System.Drawing.Point(58, 10);
            this.txt_IncomePrice.Name = "txt_IncomePrice";
            this.txt_IncomePrice.Size = new System.Drawing.Size(243, 21);
            this.txt_IncomePrice.TabIndex = 2;
            this.txt_IncomePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_IncomePrice.TextChanged += new System.EventHandler(this.txt_IncomeDate_TextChanged);
            this.txt_IncomePrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_IncomePrice_KeyDown);
            this.txt_IncomePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_IncomePrice_KeyPress);
            this.txt_IncomePrice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_IncomePrice_KeyUp);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(24, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 123;
            this.label4.Text = "ریال";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(787, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 123;
            this.label3.Text = "تاریخ دریافت";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(310, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 123;
            this.label5.Text = "واریز به صندوق";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(633, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 123;
            this.label2.Text = "نوع درآمد";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(781, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 123;
            this.label6.Text = "پرداخت کننده";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 123;
            this.label1.Text = "مبلغ درآمد";
            // 
            // rgv_Income
            // 
            this.rgv_Income.AutoScroll = true;
            this.rgv_Income.BackColor = System.Drawing.SystemColors.Control;
            this.rgv_Income.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_Income.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rgv_Income.EnableHotTracking = false;
            this.rgv_Income.EnableKineticScrolling = true;
            this.rgv_Income.EnterKeyMode = Telerik.WinControls.UI.RadGridViewEnterKeyMode.EnterMovesToNextRow;
            this.rgv_Income.Font = new System.Drawing.Font("Tahoma", 9F);
            this.rgv_Income.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgv_Income.GroupExpandAnimationType = Telerik.WinControls.UI.GridExpandAnimationType.Slide;
            this.rgv_Income.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_Income.Location = new System.Drawing.Point(0, 209);
            this.rgv_Income.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // 
            // 
            this.rgv_Income.MasterTemplate.AllowAddNewRow = false;
            this.rgv_Income.MasterTemplate.AllowCellContextMenu = false;
            this.rgv_Income.MasterTemplate.AllowDeleteRow = false;
            this.rgv_Income.MasterTemplate.AllowEditRow = false;
            this.rgv_Income.MasterTemplate.AllowRowResize = false;
            this.rgv_Income.MasterTemplate.AutoExpandGroups = true;
            this.rgv_Income.MasterTemplate.AutoGenerateColumns = false;
            this.rgv_Income.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn76.EnableExpressionEditor = false;
            gridViewTextBoxColumn76.FieldName = "IncomeId";
            gridViewTextBoxColumn76.HeaderText = "#";
            gridViewTextBoxColumn76.Name = "IncomeId";
            gridViewTextBoxColumn76.ReadOnly = true;
            gridViewTextBoxColumn76.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn76.Width = 30;
            gridViewTextBoxColumn77.EnableExpressionEditor = false;
            gridViewTextBoxColumn77.FieldName = "IncomePersianDate";
            gridViewTextBoxColumn77.HeaderText = "تاریخ درآمد";
            gridViewTextBoxColumn77.Name = "IncomePersianDate";
            gridViewTextBoxColumn77.ReadOnly = true;
            gridViewTextBoxColumn77.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn77.Width = 60;
            gridViewTextBoxColumn78.FieldName = "IncomeTypeId";
            gridViewTextBoxColumn78.HeaderText = "کد نوع درآمد";
            gridViewTextBoxColumn78.IsVisible = false;
            gridViewTextBoxColumn78.Name = "IncomeTypeId";
            gridViewTextBoxColumn78.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn79.EnableExpressionEditor = false;
            gridViewTextBoxColumn79.FieldName = "IncomeTypeTitle";
            gridViewTextBoxColumn79.HeaderText = "نوع درآمد";
            gridViewTextBoxColumn79.Name = "IncomeTypeTitle";
            gridViewTextBoxColumn79.ReadOnly = true;
            gridViewTextBoxColumn79.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewTextBoxColumn79.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn79.Width = 70;
            gridViewTextBoxColumn80.FieldName = "IncomePrice";
            gridViewTextBoxColumn80.HeaderText = "مبلغ درآمد";
            gridViewTextBoxColumn80.IsVisible = false;
            gridViewTextBoxColumn80.Name = "IncomePrice";
            gridViewTextBoxColumn80.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn81.EnableExpressionEditor = false;
            gridViewTextBoxColumn81.FieldName = "IncomeSeparateDigitPrice";
            gridViewTextBoxColumn81.HeaderText = "مبلغ درآمد";
            gridViewTextBoxColumn81.Name = "IncomeSeparateDigitPrice";
            gridViewTextBoxColumn81.ReadOnly = true;
            gridViewTextBoxColumn81.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn81.Width = 56;
            gridViewTextBoxColumn82.EnableExpressionEditor = false;
            gridViewTextBoxColumn82.FieldName = "ReceivedBy";
            gridViewTextBoxColumn82.HeaderText = "دریافت از طریق";
            gridViewTextBoxColumn82.Name = "ReceivedBy";
            gridViewTextBoxColumn82.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn82.Width = 86;
            gridViewTextBoxColumn83.FieldName = "FundId";
            gridViewTextBoxColumn83.HeaderText = "کد صندوق";
            gridViewTextBoxColumn83.IsVisible = false;
            gridViewTextBoxColumn83.Name = "FundId";
            gridViewTextBoxColumn83.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn84.EnableExpressionEditor = false;
            gridViewTextBoxColumn84.FieldName = "FundTitle";
            gridViewTextBoxColumn84.HeaderText = "واریز به صندوق";
            gridViewTextBoxColumn84.Name = "FundTitle";
            gridViewTextBoxColumn84.ReadOnly = true;
            gridViewTextBoxColumn84.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn84.Width = 83;
            gridViewTextBoxColumn85.FieldName = "FundOldValueSeparateDigit";
            gridViewTextBoxColumn85.HeaderText = "مانده قبلی صندوق";
            gridViewTextBoxColumn85.Name = "FundOldValueSeparateDigit";
            gridViewTextBoxColumn85.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn85.Width = 83;
            gridViewTextBoxColumn86.EnableExpressionEditor = false;
            gridViewTextBoxColumn86.FieldName = "FundCurrentValueSeparateDigit";
            gridViewTextBoxColumn86.HeaderText = "مانده جاری صندوق";
            gridViewTextBoxColumn86.Name = "FundCurrentValueSeparateDigit";
            gridViewTextBoxColumn86.ReadOnly = true;
            gridViewTextBoxColumn86.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn86.Width = 59;
            gridViewTextBoxColumn87.EnableExpressionEditor = false;
            gridViewTextBoxColumn87.FieldName = "IncomeCreationUserName";
            gridViewTextBoxColumn87.HeaderText = "کاربر ثبت کننده";
            gridViewTextBoxColumn87.Name = "IncomeCreationUserName";
            gridViewTextBoxColumn87.ReadOnly = true;
            gridViewTextBoxColumn87.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn87.Width = 70;
            gridViewTextBoxColumn88.EnableExpressionEditor = false;
            gridViewTextBoxColumn88.FieldName = "IncomePersianCreationDate";
            gridViewTextBoxColumn88.HeaderText = "تاریخ ایجاد";
            gridViewTextBoxColumn88.Name = "IncomePersianCreationDate";
            gridViewTextBoxColumn88.ReadOnly = true;
            gridViewTextBoxColumn88.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn88.Width = 64;
            gridViewTextBoxColumn89.EnableExpressionEditor = false;
            gridViewTextBoxColumn89.FieldName = "IncomePersianLastUpate";
            gridViewTextBoxColumn89.HeaderText = "تاریخ آخرین ویرایش";
            gridViewTextBoxColumn89.Name = "IncomePersianLastUpate";
            gridViewTextBoxColumn89.ReadOnly = true;
            gridViewTextBoxColumn89.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn89.Width = 63;
            gridViewTextBoxColumn90.EnableExpressionEditor = false;
            gridViewTextBoxColumn90.FieldName = "Description";
            gridViewTextBoxColumn90.HeaderText = "توضیحات";
            gridViewTextBoxColumn90.Name = "Description";
            gridViewTextBoxColumn90.ReadOnly = true;
            gridViewTextBoxColumn90.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn90.Width = 121;
            this.rgv_Income.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn76,
            gridViewTextBoxColumn77,
            gridViewTextBoxColumn78,
            gridViewTextBoxColumn79,
            gridViewTextBoxColumn80,
            gridViewTextBoxColumn81,
            gridViewTextBoxColumn82,
            gridViewTextBoxColumn83,
            gridViewTextBoxColumn84,
            gridViewTextBoxColumn85,
            gridViewTextBoxColumn86,
            gridViewTextBoxColumn87,
            gridViewTextBoxColumn88,
            gridViewTextBoxColumn89,
            gridViewTextBoxColumn90});
            this.rgv_Income.MasterTemplate.EnableAlternatingRowColor = true;
            this.rgv_Income.MasterTemplate.EnableFiltering = true;
            this.rgv_Income.MasterTemplate.PageSize = 15;
            this.rgv_Income.MasterTemplate.ReadOnly = true;
            this.rgv_Income.MasterTemplate.ShowGroupedColumns = true;
            sortDescriptor6.PropertyName = "IncomeTypeTitle";
            this.rgv_Income.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor6});
            this.rgv_Income.MasterTemplate.ViewDefinition = tableViewDefinition6;
            this.rgv_Income.Name = "rgv_Income";
            this.rgv_Income.ReadOnly = true;
            this.rgv_Income.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rgv_Income.Size = new System.Drawing.Size(855, 431);
            this.rgv_Income.TabIndex = 2;
            this.rgv_Income.CurrentRowChanged += new Telerik.WinControls.UI.CurrentRowChangedEventHandler(this.MasterTemplate_CurrentRowChanged);
            this.rgv_Income.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.MasterTemplate_CellClick);
            this.rgv_Income.Click += new System.EventHandler(this.rgv_Income_Click);
            // 
            // circleShape1
            // 
            this.circleShape1.IsRightToLeft = false;
            // 
            // FrmIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 640);
            this.Controls.Add(this.rgv_Income);
            this.Controls.Add(this.pnl_Action);
            this.Controls.Add(this.pnl_Data);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "FrmIncome";
            this.ShowInTaskbar = false;
            this.Text = "فرم ورود درآمدها";
            this.Controls.SetChildIndex(this.pnl_Data, 0);
            this.Controls.SetChildIndex(this.pnl_Action, 0);
            this.Controls.SetChildIndex(this.rgv_Income, 0);
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).EndInit();
            this.pnl_Action.ResumeLayout(false);
            this.pnl_Data.ResumeLayout(false);
            this.pnl_Data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rddl_Funds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddl_IncomeTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_Income.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_Income)).EndInit();
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
        private System.Windows.Forms.TextBox txt_IncomePrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txt_IncomeDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadGridView rgv_Income;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_ReceivedBy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_IncomeDescription;
        private Telerik.WinControls.UI.RadDropDownList rddl_IncomeTypes;
        private Telerik.WinControls.UI.RadDropDownList rddl_Funds;
        private Telerik.WinControls.CircleShape circleShape1;
    }
}