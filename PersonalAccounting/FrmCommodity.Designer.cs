namespace PersonalAccounting.UI
{
    partial class FrmCommodity
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
            AFrmCommodity = null;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCommodity));
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
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.pnl_Action = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.pnl_Data = new System.Windows.Forms.Panel();
            this.rddl_Receiver = new Telerik.WinControls.UI.RadDropDownList();
            this.rddl_CommodityTypes = new Telerik.WinControls.UI.RadDropDownList();
            this.txt_CommodityDescription = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_CommodityDate = new System.Windows.Forms.MaskedTextBox();
            this.txt_ReceivedBy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rgv_Commodity = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).BeginInit();
            this.pnl_Action.SuspendLayout();
            this.pnl_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rddl_Receiver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddl_CommodityTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_Commodity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_Commodity.MasterTemplate)).BeginInit();
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
            this.pnl_Action.Location = new System.Drawing.Point(0, 27);
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
            this.pnl_Data.Controls.Add(this.rddl_Receiver);
            this.pnl_Data.Controls.Add(this.rddl_CommodityTypes);
            this.pnl_Data.Controls.Add(this.txt_CommodityDescription);
            this.pnl_Data.Controls.Add(this.label9);
            this.pnl_Data.Controls.Add(this.txt_CommodityDate);
            this.pnl_Data.Controls.Add(this.txt_ReceivedBy);
            this.pnl_Data.Controls.Add(this.label3);
            this.pnl_Data.Controls.Add(this.label2);
            this.pnl_Data.Controls.Add(this.label6);
            this.pnl_Data.Controls.Add(this.label1);
            this.pnl_Data.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Data.Enabled = false;
            this.pnl_Data.Location = new System.Drawing.Point(0, 66);
            this.pnl_Data.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_Data.Name = "pnl_Data";
            this.pnl_Data.Size = new System.Drawing.Size(855, 143);
            this.pnl_Data.TabIndex = 1;
            // 
            // rddl_Receiver
            // 
            this.rddl_Receiver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rddl_Receiver.AutoSize = false;
            this.rddl_Receiver.AutoSizeItems = true;
            this.rddl_Receiver.BackColor = System.Drawing.Color.White;
            this.rddl_Receiver.DropDownAnimationEasing = Telerik.WinControls.RadEasingType.InCubic;
            this.rddl_Receiver.DropDownSizingMode = ((Telerik.WinControls.UI.SizingMode)((Telerik.WinControls.UI.SizingMode.RightBottom | Telerik.WinControls.UI.SizingMode.UpDown)));
            this.rddl_Receiver.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.rddl_Receiver.EnableAlternatingItemColor = true;
            this.rddl_Receiver.Font = new System.Drawing.Font("Tornado Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rddl_Receiver.Location = new System.Drawing.Point(24, 7);
            this.rddl_Receiver.Name = "rddl_Receiver";
            this.rddl_Receiver.Size = new System.Drawing.Size(241, 29);
            this.rddl_Receiver.TabIndex = 2;
            this.rddl_Receiver.TextChanged += new System.EventHandler(this.txt_CommodityDate_TextChanged);
            // 
            // rddl_CommodityTypes
            // 
            this.rddl_CommodityTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rddl_CommodityTypes.AutoSize = false;
            this.rddl_CommodityTypes.AutoSizeItems = true;
            this.rddl_CommodityTypes.BackColor = System.Drawing.Color.White;
            this.rddl_CommodityTypes.DropDownAnimationEasing = Telerik.WinControls.RadEasingType.InCubic;
            this.rddl_CommodityTypes.DropDownSizingMode = ((Telerik.WinControls.UI.SizingMode)((Telerik.WinControls.UI.SizingMode.RightBottom | Telerik.WinControls.UI.SizingMode.UpDown)));
            this.rddl_CommodityTypes.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.rddl_CommodityTypes.EnableAlternatingItemColor = true;
            this.rddl_CommodityTypes.Font = new System.Drawing.Font("Tornado Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rddl_CommodityTypes.Location = new System.Drawing.Point(383, 7);
            this.rddl_CommodityTypes.Name = "rddl_CommodityTypes";
            this.rddl_CommodityTypes.Size = new System.Drawing.Size(241, 29);
            this.rddl_CommodityTypes.TabIndex = 1;
            this.rddl_CommodityTypes.TextChanged += new System.EventHandler(this.txt_CommodityDate_TextChanged);
            // 
            // txt_CommodityDescription
            // 
            this.txt_CommodityDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_CommodityDescription.BackColor = System.Drawing.Color.FloralWhite;
            this.txt_CommodityDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CommodityDescription.Location = new System.Drawing.Point(24, 73);
            this.txt_CommodityDescription.Multiline = true;
            this.txt_CommodityDescription.Name = "txt_CommodityDescription";
            this.txt_CommodityDescription.Size = new System.Drawing.Size(753, 60);
            this.txt_CommodityDescription.TabIndex = 4;
            this.txt_CommodityDescription.TextChanged += new System.EventHandler(this.txt_CommodityDate_TextChanged);
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
            // txt_CommodityDate
            // 
            this.txt_CommodityDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_CommodityDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CommodityDate.Enabled = false;
            this.txt_CommodityDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_CommodityDate.Location = new System.Drawing.Point(694, 10);
            this.txt_CommodityDate.Mask = "1000/00/00";
            this.txt_CommodityDate.Name = "txt_CommodityDate";
            this.txt_CommodityDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_CommodityDate.Size = new System.Drawing.Size(83, 20);
            this.txt_CommodityDate.TabIndex = 0;
            this.txt_CommodityDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_CommodityDate.TextChanged += new System.EventHandler(this.txt_CommodityDate_TextChanged);
            this.txt_CommodityDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_CommodityDate_KeyDown);
            // 
            // txt_ReceivedBy
            // 
            this.txt_ReceivedBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ReceivedBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ReceivedBy.Location = new System.Drawing.Point(383, 42);
            this.txt_ReceivedBy.Name = "txt_ReceivedBy";
            this.txt_ReceivedBy.Size = new System.Drawing.Size(394, 21);
            this.txt_ReceivedBy.TabIndex = 3;
            this.txt_ReceivedBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_ReceivedBy.TextChanged += new System.EventHandler(this.txt_CommodityDate_TextChanged);
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
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 123;
            this.label6.Text = "تحویل دهنده";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 123;
            this.label1.Text = "دریافت کننده";
            // 
            // rgv_Commodity
            // 
            this.rgv_Commodity.AutoScroll = true;
            this.rgv_Commodity.BackColor = System.Drawing.SystemColors.Control;
            this.rgv_Commodity.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_Commodity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rgv_Commodity.EnableHotTracking = false;
            this.rgv_Commodity.EnterKeyMode = Telerik.WinControls.UI.RadGridViewEnterKeyMode.EnterMovesToNextRow;
            this.rgv_Commodity.Font = new System.Drawing.Font("Tahoma", 9F);
            this.rgv_Commodity.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgv_Commodity.GroupExpandAnimationType = Telerik.WinControls.UI.GridExpandAnimationType.Slide;
            this.rgv_Commodity.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_Commodity.Location = new System.Drawing.Point(0, 209);
            this.rgv_Commodity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // 
            // 
            this.rgv_Commodity.MasterTemplate.AllowAddNewRow = false;
            this.rgv_Commodity.MasterTemplate.AllowCellContextMenu = false;
            this.rgv_Commodity.MasterTemplate.AllowDeleteRow = false;
            this.rgv_Commodity.MasterTemplate.AllowEditRow = false;
            this.rgv_Commodity.MasterTemplate.AllowRowResize = false;
            this.rgv_Commodity.MasterTemplate.AutoExpandGroups = true;
            this.rgv_Commodity.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "CommodityId";
            gridViewTextBoxColumn1.HeaderText = "#";
            gridViewTextBoxColumn1.Name = "CommodityId";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn1.Width = 60;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "CommodityPersianDate";
            gridViewTextBoxColumn2.HeaderText = "تاریخ درآمد";
            gridViewTextBoxColumn2.Name = "CommodityPersianDate";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn2.Width = 120;
            gridViewTextBoxColumn3.FieldName = "CommodityTypeId";
            gridViewTextBoxColumn3.HeaderText = "کد نوع درآمد";
            gridViewTextBoxColumn3.IsVisible = false;
            gridViewTextBoxColumn3.Name = "CommodityTypeId";
            gridViewTextBoxColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "CommodityTypeTitle";
            gridViewTextBoxColumn4.HeaderText = "نوع درآمد";
            gridViewTextBoxColumn4.Name = "CommodityTypeTitle";
            gridViewTextBoxColumn4.ReadOnly = true;
            gridViewTextBoxColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn4.Width = 140;
            gridViewTextBoxColumn5.FieldName = "ReceiverId";
            gridViewTextBoxColumn5.HeaderText = "کد دریافت کننده";
            gridViewTextBoxColumn5.IsVisible = false;
            gridViewTextBoxColumn5.Name = "ReceiverId";
            gridViewTextBoxColumn6.FieldName = "ReceiverName";
            gridViewTextBoxColumn6.HeaderText = "دریافت کننده";
            gridViewTextBoxColumn6.Name = "ReceiverName";
            gridViewTextBoxColumn6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn6.Width = 200;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "ReceivedBy";
            gridViewTextBoxColumn7.HeaderText = "تحویل دهنده";
            gridViewTextBoxColumn7.Name = "ReceivedBy";
            gridViewTextBoxColumn7.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn7.Width = 173;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "CommodityCreationUserName";
            gridViewTextBoxColumn8.HeaderText = "کاربر ثبت کننده";
            gridViewTextBoxColumn8.Name = "CommodityCreationUserName";
            gridViewTextBoxColumn8.ReadOnly = true;
            gridViewTextBoxColumn8.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn8.Width = 141;
            gridViewTextBoxColumn9.EnableExpressionEditor = false;
            gridViewTextBoxColumn9.FieldName = "CommodityPersianCreationDate";
            gridViewTextBoxColumn9.HeaderText = "تاریخ ایجاد";
            gridViewTextBoxColumn9.Name = "CommodityPersianCreationDate";
            gridViewTextBoxColumn9.ReadOnly = true;
            gridViewTextBoxColumn9.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn9.Width = 129;
            gridViewTextBoxColumn10.EnableExpressionEditor = false;
            gridViewTextBoxColumn10.FieldName = "CommodityPersianLastUpdate";
            gridViewTextBoxColumn10.HeaderText = "تاریخ آخرین ویرایش";
            gridViewTextBoxColumn10.Name = "CommodityPersianLastUpdate";
            gridViewTextBoxColumn10.ReadOnly = true;
            gridViewTextBoxColumn10.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn10.Width = 126;
            gridViewTextBoxColumn11.EnableExpressionEditor = false;
            gridViewTextBoxColumn11.FieldName = "Description";
            gridViewTextBoxColumn11.HeaderText = "توضیحات";
            gridViewTextBoxColumn11.Name = "Description";
            gridViewTextBoxColumn11.ReadOnly = true;
            gridViewTextBoxColumn11.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn11.Width = 246;
            this.rgv_Commodity.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
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
            gridViewTextBoxColumn11});
            this.rgv_Commodity.MasterTemplate.EnableAlternatingRowColor = true;
            this.rgv_Commodity.MasterTemplate.EnableFiltering = true;
            this.rgv_Commodity.MasterTemplate.ReadOnly = true;
            this.rgv_Commodity.MasterTemplate.ShowGroupedColumns = true;
            sortDescriptor1.PropertyName = "IncomeTypeTitle";
            this.rgv_Commodity.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.rgv_Commodity.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgv_Commodity.Name = "rgv_Commodity";
            this.rgv_Commodity.ReadOnly = true;
            this.rgv_Commodity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rgv_Commodity.Size = new System.Drawing.Size(855, 431);
            this.rgv_Commodity.TabIndex = 2;
            this.rgv_Commodity.CurrentRowChanged += new Telerik.WinControls.UI.CurrentRowChangedEventHandler(this.rgv_Commodity_CurrentRowChanged);
            this.rgv_Commodity.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.rgv_Commodity_CellClick);
            this.rgv_Commodity.Click += new System.EventHandler(this.rgv_Commodity_Click);
            // 
            // FrmCommodity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 640);
            this.Controls.Add(this.rgv_Commodity);
            this.Controls.Add(this.pnl_Data);
            this.Controls.Add(this.pnl_Action);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "FrmCommodity";
            this.ShowInTaskbar = false;
            this.Text = "فرم ورود دریافتی ها";
            this.Controls.SetChildIndex(this.pnl_Action, 0);
            this.Controls.SetChildIndex(this.pnl_Data, 0);
            this.Controls.SetChildIndex(this.rgv_Commodity, 0);
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).EndInit();
            this.pnl_Action.ResumeLayout(false);
            this.pnl_Data.ResumeLayout(false);
            this.pnl_Data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rddl_Receiver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddl_CommodityTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_Commodity.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_Commodity)).EndInit();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txt_CommodityDate;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadGridView rgv_Commodity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_ReceivedBy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_CommodityDescription;
        private Telerik.WinControls.UI.RadDropDownList rddl_CommodityTypes;
        private Telerik.WinControls.UI.RadDropDownList rddl_Receiver;
    }
}