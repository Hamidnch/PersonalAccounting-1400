namespace PersonalAccounting.UI
{
    partial class FrmExpense
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
            _aFrmExpense = null;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn14 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn15 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn16 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn17 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn18 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn19 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor2 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor3 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor4 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewImageColumn gridViewImageColumn1 = new Telerik.WinControls.UI.GridViewImageColumn();
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn13 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExpense));
            this.uiPanelManager1 = new Janus.Windows.UI.Dock.UIPanelManager(this.components);
            this.pnl_ExpenseDocuments = new Janus.Windows.UI.Dock.UIPanel();
            this.uiPanel0Container = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            this.rgv_Expenses = new Telerik.WinControls.UI.RadGridView();
            this.pnlTop = new Janus.Windows.UI.Dock.UIPanel();
            this.pnlTopContainer = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            this.pnl_Data = new System.Windows.Forms.Panel();
            this.rgv_BuyList = new Telerik.WinControls.UI.RadGridView();
            this.pnl_TopData = new Telerik.WinControls.UI.RadPanel();
            this.btn_ExportToExcel = new System.Windows.Forms.Button();
            this.txt_ExpenseDocumentDate = new System.Windows.Forms.MaskedTextBox();
            this.lbl_DocumentId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnl_Action = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_ExpenseDocuments)).BeginInit();
            this.pnl_ExpenseDocuments.SuspendLayout();
            this.uiPanel0Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_Expenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_Expenses.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTop)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.pnlTopContainer.SuspendLayout();
            this.pnl_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_BuyList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_BuyList.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_TopData)).BeginInit();
            this.pnl_TopData.SuspendLayout();
            this.pnl_Action.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanelManager1
            // 
            this.uiPanelManager1.ContainerControl = this;
            this.uiPanelManager1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.VS2010;
            this.pnl_ExpenseDocuments.Id = new System.Guid("8e74b61a-6571-434b-b4bf-d7669b29989a");
            this.uiPanelManager1.Panels.Add(this.pnl_ExpenseDocuments);
            this.pnlTop.Id = new System.Guid("01e8259e-715c-48cb-a865-5da501cd96ee");
            this.uiPanelManager1.Panels.Add(this.pnlTop);
            // 
            // Design Time Panel Info:
            // 
            this.uiPanelManager1.BeginPanelInfo();
            this.uiPanelManager1.AddDockPanelInfo(new System.Guid("01e8259e-715c-48cb-a865-5da501cd96ee"), Janus.Windows.UI.Dock.PanelDockStyle.Fill, new System.Drawing.Size(916, 438), true);
            this.uiPanelManager1.AddDockPanelInfo(new System.Guid("8e74b61a-6571-434b-b4bf-d7669b29989a"), Janus.Windows.UI.Dock.PanelDockStyle.Bottom, new System.Drawing.Size(916, 205), true);
            this.uiPanelManager1.AddFloatingPanelInfo(new System.Guid("01e8259e-715c-48cb-a865-5da501cd96ee"), new System.Drawing.Point(422, 186), new System.Drawing.Size(200, 200), false);
            this.uiPanelManager1.AddFloatingPanelInfo(new System.Guid("8e74b61a-6571-434b-b4bf-d7669b29989a"), new System.Drawing.Point(425, 690), new System.Drawing.Size(200, 200), false);
            this.uiPanelManager1.EndPanelInfo();
            // 
            // pnl_ExpenseDocuments
            // 
            this.pnl_ExpenseDocuments.CloseButtonVisible = Janus.Windows.UI.InheritableBoolean.False;
            this.pnl_ExpenseDocuments.FloatingLocation = new System.Drawing.Point(425, 690);
            this.pnl_ExpenseDocuments.InnerContainer = this.uiPanel0Container;
            this.pnl_ExpenseDocuments.Location = new System.Drawing.Point(3, 468);
            this.pnl_ExpenseDocuments.Name = "pnl_ExpenseDocuments";
            this.pnl_ExpenseDocuments.Size = new System.Drawing.Size(916, 205);
            this.pnl_ExpenseDocuments.TabIndex = 4;
            this.pnl_ExpenseDocuments.Text = "اسناد هزینه";
            this.pnl_ExpenseDocuments.TextAlignment = Janus.Windows.UI.Dock.PanelTextAlignment.Far;
            this.pnl_ExpenseDocuments.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnl_Data_MouseClick);
            // 
            // uiPanel0Container
            // 
            this.uiPanel0Container.Controls.Add(this.rgv_Expenses);
            this.uiPanel0Container.Location = new System.Drawing.Point(1, 28);
            this.uiPanel0Container.Name = "uiPanel0Container";
            this.uiPanel0Container.Size = new System.Drawing.Size(914, 176);
            this.uiPanel0Container.TabIndex = 0;
            // 
            // rgv_Expenses
            // 
            this.rgv_Expenses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rgv_Expenses.AutoScroll = true;
            this.rgv_Expenses.BackColor = System.Drawing.SystemColors.Control;
            this.rgv_Expenses.ColumnChooserSortOrder = Telerik.WinControls.UI.RadSortOrder.Descending;
            this.rgv_Expenses.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_Expenses.EnableHotTracking = false;
            this.rgv_Expenses.EnterKeyMode = Telerik.WinControls.UI.RadGridViewEnterKeyMode.EnterMovesToNextRow;
            this.rgv_Expenses.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rgv_Expenses.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgv_Expenses.GroupExpandAnimationType = Telerik.WinControls.UI.GridExpandAnimationType.Slide;
            this.rgv_Expenses.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_Expenses.Location = new System.Drawing.Point(0, 0);
            this.rgv_Expenses.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // 
            // 
            this.rgv_Expenses.MasterTemplate.AllowAddNewRow = false;
            this.rgv_Expenses.MasterTemplate.AllowCellContextMenu = false;
            this.rgv_Expenses.MasterTemplate.AllowDeleteRow = false;
            this.rgv_Expenses.MasterTemplate.AllowEditRow = false;
            this.rgv_Expenses.MasterTemplate.AllowRowResize = false;
            this.rgv_Expenses.MasterTemplate.AutoExpandGroups = true;
            this.rgv_Expenses.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn14.EnableExpressionEditor = false;
            gridViewTextBoxColumn14.FieldName = "ExpenseDocumentId";
            gridViewTextBoxColumn14.HeaderText = "شماره سند";
            gridViewTextBoxColumn14.Name = "ExpenseDocumentId";
            gridViewTextBoxColumn14.ReadOnly = true;
            gridViewTextBoxColumn14.SortOrder = Telerik.WinControls.UI.RadSortOrder.Descending;
            gridViewTextBoxColumn14.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn14.Width = 87;
            gridViewTextBoxColumn15.EnableExpressionEditor = false;
            gridViewTextBoxColumn15.FieldName = "ExpenseDocumentPersianDate";
            gridViewTextBoxColumn15.HeaderText = "تاریخ هزینه";
            gridViewTextBoxColumn15.Name = "ExpenseDocumentPersianDate";
            gridViewTextBoxColumn15.ReadOnly = true;
            gridViewTextBoxColumn15.SortOrder = Telerik.WinControls.UI.RadSortOrder.Descending;
            gridViewTextBoxColumn15.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn15.Width = 121;
            gridViewTextBoxColumn16.EnableExpressionEditor = false;
            gridViewTextBoxColumn16.FieldName = "ExpenseDocumentCreationUserName";
            gridViewTextBoxColumn16.HeaderText = "کاربر ثبت کننده";
            gridViewTextBoxColumn16.Name = "ExpenseDocumentCreationUserName";
            gridViewTextBoxColumn16.ReadOnly = true;
            gridViewTextBoxColumn16.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn16.Width = 142;
            gridViewTextBoxColumn17.EnableExpressionEditor = false;
            gridViewTextBoxColumn17.FieldName = "ExpenseDocumentCreationPersianDate";
            gridViewTextBoxColumn17.HeaderText = "تاریخ ثبت";
            gridViewTextBoxColumn17.Name = "ExpenseDocumentCreationPersianDate";
            gridViewTextBoxColumn17.ReadOnly = true;
            gridViewTextBoxColumn17.SortOrder = Telerik.WinControls.UI.RadSortOrder.Descending;
            gridViewTextBoxColumn17.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn17.Width = 150;
            gridViewTextBoxColumn18.EnableExpressionEditor = false;
            gridViewTextBoxColumn18.FieldName = "ExpenseDocumentPersianLastUpdate";
            gridViewTextBoxColumn18.HeaderText = "تاریخ آخرین ویرایش";
            gridViewTextBoxColumn18.Name = "ExpenseDocumentPersianLastUpdate";
            gridViewTextBoxColumn18.ReadOnly = true;
            gridViewTextBoxColumn18.SortOrder = Telerik.WinControls.UI.RadSortOrder.Descending;
            gridViewTextBoxColumn18.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn18.Width = 150;
            gridViewTextBoxColumn19.EnableExpressionEditor = false;
            gridViewTextBoxColumn19.FieldName = "ExpenseDocumentDescription";
            gridViewTextBoxColumn19.HeaderText = "توضیحات";
            gridViewTextBoxColumn19.Name = "ExpenseDocumentDescription";
            gridViewTextBoxColumn19.ReadOnly = true;
            gridViewTextBoxColumn19.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn19.Width = 262;
            this.rgv_Expenses.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn14,
            gridViewTextBoxColumn15,
            gridViewTextBoxColumn16,
            gridViewTextBoxColumn17,
            gridViewTextBoxColumn18,
            gridViewTextBoxColumn19});
            this.rgv_Expenses.MasterTemplate.EnableAlternatingRowColor = true;
            this.rgv_Expenses.MasterTemplate.EnableFiltering = true;
            this.rgv_Expenses.MasterTemplate.ReadOnly = true;
            this.rgv_Expenses.MasterTemplate.ShowGroupedColumns = true;
            sortDescriptor1.Direction = System.ComponentModel.ListSortDirection.Descending;
            sortDescriptor1.PropertyName = "ExpenseDocumentId";
            sortDescriptor2.Direction = System.ComponentModel.ListSortDirection.Descending;
            sortDescriptor2.PropertyName = "ExpenseDocumentPersianDate";
            sortDescriptor3.Direction = System.ComponentModel.ListSortDirection.Descending;
            sortDescriptor3.PropertyName = "ExpenseDocumentCreationPersianDate";
            sortDescriptor4.Direction = System.ComponentModel.ListSortDirection.Descending;
            sortDescriptor4.PropertyName = "ExpenseDocumentPersianLastUpdate";
            this.rgv_Expenses.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1,
            sortDescriptor2,
            sortDescriptor3,
            sortDescriptor4});
            this.rgv_Expenses.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.rgv_Expenses.Name = "rgv_Expenses";
            this.rgv_Expenses.ReadOnly = true;
            this.rgv_Expenses.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rgv_Expenses.Size = new System.Drawing.Size(914, 176);
            this.rgv_Expenses.TabIndex = 5;
            this.rgv_Expenses.CurrentRowChanged += new Telerik.WinControls.UI.CurrentRowChangedEventHandler(this.rgvExpenses_CurrentRowChanged);
            this.rgv_Expenses.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.rgv_Expenses_CellClick);
            this.rgv_Expenses.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnl_Data_MouseClick);
            // 
            // pnlTop
            // 
            this.pnlTop.AllowPanelDrag = Janus.Windows.UI.InheritableBoolean.False;
            this.pnlTop.AllowPanelDrop = Janus.Windows.UI.InheritableBoolean.False;
            this.pnlTop.AllowResize = Janus.Windows.UI.InheritableBoolean.True;
            this.pnlTop.BorderCaption = Janus.Windows.UI.InheritableBoolean.False;
            this.pnlTop.BorderPanel = Janus.Windows.UI.InheritableBoolean.False;
            this.pnlTop.CaptionStyle = Janus.Windows.UI.Dock.PanelCaptionStyle.Light;
            this.pnlTop.CloseButtonVisible = Janus.Windows.UI.InheritableBoolean.False;
            this.pnlTop.FloatingLocation = new System.Drawing.Point(422, 186);
            this.pnlTop.InnerContainer = this.pnlTopContainer;
            this.pnlTop.Location = new System.Drawing.Point(3, 30);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(916, 438);
            this.pnlTop.TabIndex = 4;
            this.pnlTop.Text = "ورود هزینه ها";
            this.pnlTop.TextAlignment = Janus.Windows.UI.Dock.PanelTextAlignment.Far;
            this.pnlTop.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnl_Data_MouseClick);
            // 
            // pnlTopContainer
            // 
            this.pnlTopContainer.Controls.Add(this.pnl_Data);
            this.pnlTopContainer.Controls.Add(this.pnl_Action);
            this.pnlTopContainer.Location = new System.Drawing.Point(0, 23);
            this.pnlTopContainer.Name = "pnlTopContainer";
            this.pnlTopContainer.Size = new System.Drawing.Size(916, 415);
            this.pnlTopContainer.TabIndex = 0;
            // 
            // pnl_Data
            // 
            this.pnl_Data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.pnl_Data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Data.Controls.Add(this.rgv_BuyList);
            this.pnl_Data.Controls.Add(this.pnl_TopData);
            this.pnl_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Data.Location = new System.Drawing.Point(0, 39);
            this.pnl_Data.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_Data.Name = "pnl_Data";
            this.pnl_Data.Size = new System.Drawing.Size(916, 376);
            this.pnl_Data.TabIndex = 1;
            this.pnl_Data.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnl_Data_MouseClick);
            // 
            // rgv_BuyList
            // 
            this.rgv_BuyList.BackColor = System.Drawing.SystemColors.Control;
            this.rgv_BuyList.ColumnChooserSortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            this.rgv_BuyList.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_BuyList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rgv_BuyList.EnableAnalytics = false;
            this.rgv_BuyList.EnableGestures = false;
            this.rgv_BuyList.EnableHotTracking = false;
            this.rgv_BuyList.EnableTheming = false;
            this.rgv_BuyList.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.rgv_BuyList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgv_BuyList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_BuyList.Location = new System.Drawing.Point(0, 31);
            // 
            // 
            // 
            this.rgv_BuyList.MasterTemplate.AllowAddNewRow = false;
            this.rgv_BuyList.MasterTemplate.AllowColumnChooser = false;
            this.rgv_BuyList.MasterTemplate.AllowDragToGroup = false;
            this.rgv_BuyList.MasterTemplate.AllowRowResize = false;
            this.rgv_BuyList.MasterTemplate.AutoGenerateColumns = false;
            this.rgv_BuyList.MasterTemplate.ChildViewTabsPosition = Telerik.WinControls.UI.TabPositions.Bottom;
            gridViewImageColumn1.AllowSort = false;
            gridViewImageColumn1.DisableHTMLRendering = false;
            gridViewImageColumn1.EnableExpressionEditor = false;
            gridViewImageColumn1.FieldName = "DeleteRow";
            gridViewImageColumn1.Name = "DeleteRow";
            gridViewImageColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewImageColumn1.Width = 24;
            gridViewTextBoxColumn1.AllowGroup = false;
            gridViewTextBoxColumn1.AllowSort = false;
            gridViewTextBoxColumn1.DisableHTMLRendering = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "RowNumber";
            gridViewTextBoxColumn1.HeaderText = "ردیف";
            gridViewTextBoxColumn1.Name = "RowNumber";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn1.VisibleInColumnChooser = false;
            gridViewTextBoxColumn1.Width = 43;
            gridViewTextBoxColumn2.AllowGroup = false;
            gridViewTextBoxColumn2.AllowSort = false;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "ArticleId";
            gridViewTextBoxColumn2.HeaderText = "کد کالا";
            gridViewTextBoxColumn2.IsVisible = false;
            gridViewTextBoxColumn2.Name = "ArticleId";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn3.AllowGroup = false;
            gridViewTextBoxColumn3.AllowSort = false;
            gridViewTextBoxColumn3.DisableHTMLRendering = false;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "ArticleName";
            gridViewTextBoxColumn3.HeaderText = "شرح کالا";
            gridViewTextBoxColumn3.Name = "ArticleName";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn3.Width = 136;
            gridViewTextBoxColumn4.AllowGroup = false;
            gridViewTextBoxColumn4.AllowSort = false;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "FundId";
            gridViewTextBoxColumn4.HeaderText = "کد صندوق";
            gridViewTextBoxColumn4.IsVisible = false;
            gridViewTextBoxColumn4.Name = "FundId";
            gridViewTextBoxColumn4.ReadOnly = true;
            gridViewTextBoxColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn4.Width = 56;
            gridViewTextBoxColumn5.AllowGroup = false;
            gridViewTextBoxColumn5.AllowSort = false;
            gridViewTextBoxColumn5.DisableHTMLRendering = false;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "FundName";
            gridViewTextBoxColumn5.HeaderText = "صندوق هزینه";
            gridViewTextBoxColumn5.Name = "FundName";
            gridViewTextBoxColumn5.ReadOnly = true;
            gridViewTextBoxColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn5.Width = 170;
            gridViewTextBoxColumn6.AllowGroup = false;
            gridViewTextBoxColumn6.AllowSort = false;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "ByPersonId";
            gridViewTextBoxColumn6.HeaderText = "کدشخص";
            gridViewTextBoxColumn6.IsVisible = false;
            gridViewTextBoxColumn6.Name = "ByPersonId";
            gridViewTextBoxColumn6.ReadOnly = true;
            gridViewTextBoxColumn6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn6.Width = 48;
            gridViewTextBoxColumn7.AllowGroup = false;
            gridViewTextBoxColumn7.AllowSort = false;
            gridViewTextBoxColumn7.DisableHTMLRendering = false;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "ByPersonName";
            gridViewTextBoxColumn7.HeaderText = "هزینه کننده";
            gridViewTextBoxColumn7.Name = "ByPersonName";
            gridViewTextBoxColumn7.ReadOnly = true;
            gridViewTextBoxColumn7.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn7.Width = 99;
            gridViewTextBoxColumn8.AllowGroup = false;
            gridViewTextBoxColumn8.AllowSort = false;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "ForPersonId";
            gridViewTextBoxColumn8.HeaderText = "کد هزینه شونده";
            gridViewTextBoxColumn8.IsVisible = false;
            gridViewTextBoxColumn8.Name = "ForPersonId";
            gridViewTextBoxColumn8.ReadOnly = true;
            gridViewTextBoxColumn8.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn8.Width = 46;
            gridViewTextBoxColumn9.AllowGroup = false;
            gridViewTextBoxColumn9.AllowSort = false;
            gridViewTextBoxColumn9.DisableHTMLRendering = false;
            gridViewTextBoxColumn9.EnableExpressionEditor = false;
            gridViewTextBoxColumn9.FieldName = "ForPersonName";
            gridViewTextBoxColumn9.HeaderText = "هزینه شده برای";
            gridViewTextBoxColumn9.Name = "ForPersonName";
            gridViewTextBoxColumn9.ReadOnly = true;
            gridViewTextBoxColumn9.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn9.Width = 100;
            gridViewTextBoxColumn10.AllowGroup = false;
            gridViewTextBoxColumn10.AllowSort = false;
            gridViewTextBoxColumn10.EnableExpressionEditor = false;
            gridViewTextBoxColumn10.FieldName = "MeasurementUnitId";
            gridViewTextBoxColumn10.HeaderText = "کدسنجش";
            gridViewTextBoxColumn10.IsVisible = false;
            gridViewTextBoxColumn10.Name = "MeasurementUnitId";
            gridViewTextBoxColumn10.ReadOnly = true;
            gridViewTextBoxColumn10.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn10.Width = 41;
            gridViewTextBoxColumn11.AllowGroup = false;
            gridViewTextBoxColumn11.AllowSort = false;
            gridViewTextBoxColumn11.DisableHTMLRendering = false;
            gridViewTextBoxColumn11.EnableExpressionEditor = false;
            gridViewTextBoxColumn11.FieldName = "MeasurementUnitName";
            gridViewTextBoxColumn11.HeaderText = "واحد سنجش";
            gridViewTextBoxColumn11.Name = "MeasurementUnitName";
            gridViewTextBoxColumn11.ReadOnly = true;
            gridViewTextBoxColumn11.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn11.Width = 84;
            gridViewDecimalColumn1.AllowFiltering = false;
            gridViewDecimalColumn1.AllowGroup = false;
            gridViewDecimalColumn1.AllowHide = false;
            gridViewDecimalColumn1.AllowSort = false;
            gridViewDecimalColumn1.DecimalPlaces = 0;
            gridViewDecimalColumn1.DisableHTMLRendering = false;
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.ExcelExportType = Telerik.WinControls.UI.Export.DisplayFormatType.Currency;
            gridViewDecimalColumn1.FieldName = "Fi";
            gridViewDecimalColumn1.FormatInfo = new System.Globalization.CultureInfo("fa-IR");
            gridViewDecimalColumn1.FormatString = "{0:n0}";
            gridViewDecimalColumn1.HeaderText = "فی";
            gridViewDecimalColumn1.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            gridViewDecimalColumn1.Name = "Fi";
            gridViewDecimalColumn1.ShowUpDownButtons = false;
            gridViewDecimalColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDecimalColumn1.ThousandsSeparator = true;
            gridViewDecimalColumn1.Width = 120;
            gridViewDecimalColumn2.AllowGroup = false;
            gridViewDecimalColumn2.AllowSort = false;
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "Count";
            gridViewDecimalColumn2.FormatInfo = new System.Globalization.CultureInfo("fa-IR");
            gridViewDecimalColumn2.FormatString = "{0:n0}";
            gridViewDecimalColumn2.HeaderText = "تعداد";
            gridViewDecimalColumn2.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            gridViewDecimalColumn2.Name = "Count";
            gridViewDecimalColumn2.ShowUpDownButtons = false;
            gridViewDecimalColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDecimalColumn2.ThousandsSeparator = true;
            gridViewDecimalColumn2.Width = 48;
            gridViewDecimalColumn3.AllowFiltering = false;
            gridViewDecimalColumn3.AllowGroup = false;
            gridViewDecimalColumn3.AllowHide = false;
            gridViewDecimalColumn3.AllowSort = false;
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "Price";
            gridViewDecimalColumn3.FormatInfo = new System.Globalization.CultureInfo("fa-IR");
            gridViewDecimalColumn3.FormatString = "{0:n0}";
            gridViewDecimalColumn3.HeaderText = "مبلغ";
            gridViewDecimalColumn3.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            gridViewDecimalColumn3.Name = "Price";
            gridViewDecimalColumn3.ReadOnly = true;
            gridViewDecimalColumn3.ShowUpDownButtons = false;
            gridViewDecimalColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDecimalColumn3.ThousandsSeparator = true;
            gridViewDecimalColumn3.Width = 150;
            gridViewTextBoxColumn12.AcceptsReturn = true;
            gridViewTextBoxColumn12.AcceptsTab = true;
            gridViewTextBoxColumn12.AllowGroup = false;
            gridViewTextBoxColumn12.AllowSort = false;
            gridViewTextBoxColumn12.DisableHTMLRendering = false;
            gridViewTextBoxColumn12.EnableExpressionEditor = false;
            gridViewTextBoxColumn12.ExcelExportType = Telerik.WinControls.UI.Export.DisplayFormatType.Currency;
            gridViewTextBoxColumn12.FieldName = "Comment";
            gridViewTextBoxColumn12.HeaderText = "توضیحات";
            gridViewTextBoxColumn12.Name = "Comment";
            gridViewTextBoxColumn12.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn12.Width = 300;
            gridViewTextBoxColumn13.AllowGroup = false;
            gridViewTextBoxColumn13.AllowSort = false;
            gridViewTextBoxColumn13.DisableHTMLRendering = false;
            gridViewTextBoxColumn13.EnableExpressionEditor = false;
            gridViewTextBoxColumn13.FieldName = "FundCurrentValue";
            gridViewTextBoxColumn13.FormatInfo = new System.Globalization.CultureInfo("fa-IR");
            gridViewTextBoxColumn13.FormatString = "{0:n0}";
            gridViewTextBoxColumn13.HeaderText = "مانده صندوق";
            gridViewTextBoxColumn13.Name = "FundCurrentValue";
            gridViewTextBoxColumn13.ReadOnly = true;
            gridViewTextBoxColumn13.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn13.Width = 83;
            this.rgv_BuyList.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewImageColumn1,
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
            gridViewDecimalColumn1,
            gridViewDecimalColumn2,
            gridViewDecimalColumn3,
            gridViewTextBoxColumn12,
            gridViewTextBoxColumn13});
            this.rgv_BuyList.MasterTemplate.EnableGrouping = false;
            this.rgv_BuyList.MasterTemplate.EnableSorting = false;
            this.rgv_BuyList.MasterTemplate.MultiSelect = true;
            this.rgv_BuyList.MasterTemplate.ShowHeaderCellButtons = true;
            this.rgv_BuyList.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgv_BuyList.Name = "rgv_BuyList";
            this.rgv_BuyList.ReadOnly = true;
            this.rgv_BuyList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rgv_BuyList.ShowGroupPanel = false;
            this.rgv_BuyList.ShowHeaderCellButtons = true;
            this.rgv_BuyList.Size = new System.Drawing.Size(914, 343);
            this.rgv_BuyList.TabIndex = 171;
            this.rgv_BuyList.CellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.rgv_BuyList_CellFormatting);
            this.rgv_BuyList.ViewCellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.rgv_BuyList_ViewCellFormatting);
            this.rgv_BuyList.CellEndEdit += new Telerik.WinControls.UI.GridViewCellEventHandler(this.rgv_BuyList_CellEndEdit);
            this.rgv_BuyList.CellValidating += new Telerik.WinControls.UI.CellValidatingEventHandler(this.rgv_BuyList_CellValidating);
            this.rgv_BuyList.UserAddingRow += new Telerik.WinControls.UI.GridViewRowCancelEventHandler(this.rgv_BuyList_UserAddingRow);
            this.rgv_BuyList.UserDeletingRow += new Telerik.WinControls.UI.GridViewRowCancelEventHandler(this.rgv_BuyList_UserDeletingRow);
            this.rgv_BuyList.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.rgv_BuyList_CellClick);
            this.rgv_BuyList.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.rgv_BuyList_CellDoubleClick);
            this.rgv_BuyList.CellValueChanged += new Telerik.WinControls.UI.GridViewCellEventHandler(this.rgv_BuyList_CellValueChanged);
            this.rgv_BuyList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rgv_BuyList_KeyDown);
            this.rgv_BuyList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnl_Data_MouseClick);
            this.rgv_BuyList.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.rgv_BuyList_PreviewKeyDown);
            // 
            // pnl_TopData
            // 
            this.pnl_TopData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.pnl_TopData.Controls.Add(this.txt_ExpenseDocumentDate);
            this.pnl_TopData.Controls.Add(this.lbl_DocumentId);
            this.pnl_TopData.Controls.Add(this.label3);
            this.pnl_TopData.Controls.Add(this.label5);
            this.pnl_TopData.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_TopData.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_TopData.Location = new System.Drawing.Point(0, 0);
            this.pnl_TopData.Name = "pnl_TopData";
            this.pnl_TopData.Size = new System.Drawing.Size(914, 31);
            this.pnl_TopData.TabIndex = 1;
            // 
            // btn_ExportToExcel
            // 
            this.btn_ExportToExcel.BackColor = System.Drawing.Color.Transparent;
            this.btn_ExportToExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ExportToExcel.Location = new System.Drawing.Point(87, 3);
            this.btn_ExportToExcel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ExportToExcel.Name = "btn_ExportToExcel";
            this.btn_ExportToExcel.Size = new System.Drawing.Size(177, 29);
            this.btn_ExportToExcel.TabIndex = 171;
            this.btn_ExportToExcel.Text = "ارسال به اکسل";
            this.btn_ExportToExcel.UseVisualStyleBackColor = false;
            this.btn_ExportToExcel.Click += new System.EventHandler(this.btn_ExportToExcel_Click);
            // 
            // txt_ExpenseDocumentDate
            // 
            this.txt_ExpenseDocumentDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ExpenseDocumentDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ExpenseDocumentDate.Enabled = false;
            this.txt_ExpenseDocumentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_ExpenseDocumentDate.Location = new System.Drawing.Point(745, 5);
            this.txt_ExpenseDocumentDate.Mask = "1000/00/00";
            this.txt_ExpenseDocumentDate.Name = "txt_ExpenseDocumentDate";
            this.txt_ExpenseDocumentDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_ExpenseDocumentDate.Size = new System.Drawing.Size(83, 23);
            this.txt_ExpenseDocumentDate.TabIndex = 0;
            this.txt_ExpenseDocumentDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_ExpenseDocumentDate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnl_Data_MouseClick);
            this.txt_ExpenseDocumentDate.TextChanged += new System.EventHandler(this.txt_ExpenseDocumentDate_TextChanged);
            // 
            // lbl_DocumentId
            // 
            this.lbl_DocumentId.AutoSize = true;
            this.lbl_DocumentId.BackColor = System.Drawing.Color.Transparent;
            this.lbl_DocumentId.Font = new System.Drawing.Font("Tahoma", 10F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DocumentId.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_DocumentId.Location = new System.Drawing.Point(37, 5);
            this.lbl_DocumentId.Name = "lbl_DocumentId";
            this.lbl_DocumentId.Size = new System.Drawing.Size(20, 21);
            this.lbl_DocumentId.TabIndex = 170;
            this.lbl_DocumentId.Text = "0";
            this.lbl_DocumentId.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnl_Data_MouseClick);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(836, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 167;
            this.label3.Text = "تاریخ هزینه";
            this.label3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnl_Data_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(91, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 170;
            this.label5.Text = "شماره سند";
            this.label5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnl_Data_MouseClick);
            // 
            // pnl_Action
            // 
            this.pnl_Action.AutoSize = true;
            this.pnl_Action.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.pnl_Action.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Action.Controls.Add(this.btn_ExportToExcel);
            this.pnl_Action.Controls.Add(this.btnClose);
            this.pnl_Action.Controls.Add(this.btnCancel);
            this.pnl_Action.Controls.Add(this.btnDelete);
            this.pnl_Action.Controls.Add(this.btnModify);
            this.pnl_Action.Controls.Add(this.btnRegister);
            this.pnl_Action.Controls.Add(this.btnInsert);
            this.pnl_Action.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Action.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.pnl_Action.Location = new System.Drawing.Point(0, 0);
            this.pnl_Action.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_Action.Name = "pnl_Action";
            this.pnl_Action.Size = new System.Drawing.Size(916, 39);
            this.pnl_Action.TabIndex = 0;
            this.pnl_Action.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnl_Data_MouseClick);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(5, 3);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(76, 29);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "بستن";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnl_Data_MouseClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancel.Enabled = false;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(760, 2);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(31, 31);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnl_Data_MouseClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(790, 2);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(31, 31);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnl_Data_MouseClick);
            // 
            // btnModify
            // 
            this.btnModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModify.BackColor = System.Drawing.Color.White;
            this.btnModify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnModify.Enabled = false;
            this.btnModify.Image = ((System.Drawing.Image)(resources.GetObject("btnModify.Image")));
            this.btnModify.Location = new System.Drawing.Point(820, 2);
            this.btnModify.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(31, 31);
            this.btnModify.TabIndex = 2;
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            this.btnModify.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnl_Data_MouseClick);
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegister.BackColor = System.Drawing.Color.White;
            this.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRegister.Enabled = false;
            this.btnRegister.Image = ((System.Drawing.Image)(resources.GetObject("btnRegister.Image")));
            this.btnRegister.Location = new System.Drawing.Point(850, 2);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(31, 31);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            this.btnRegister.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnl_Data_MouseClick);
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsert.BackColor = System.Drawing.Color.White;
            this.btnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInsert.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnInsert.Image = ((System.Drawing.Image)(resources.GetObject("btnInsert.Image")));
            this.btnInsert.Location = new System.Drawing.Point(880, 2);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(31, 31);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            this.btnInsert.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnl_Data_MouseClick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Excel (*.xls)|*.xls";
            // 
            // FrmExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 676);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnl_ExpenseDocuments);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.KeyPreview = true;
            this.Name = "FrmExpense";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "فرم جزئیات هزینه ها";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnl_Data_MouseClick);
            this.Controls.SetChildIndex(this.pnl_ExpenseDocuments, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_ExpenseDocuments)).EndInit();
            this.pnl_ExpenseDocuments.ResumeLayout(false);
            this.uiPanel0Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgv_Expenses.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_Expenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTop)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTopContainer.ResumeLayout(false);
            this.pnlTopContainer.PerformLayout();
            this.pnl_Data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgv_BuyList.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_BuyList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_TopData)).EndInit();
            this.pnl_TopData.ResumeLayout(false);
            this.pnl_TopData.PerformLayout();
            this.pnl_Action.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.UI.Dock.UIPanelManager uiPanelManager1;
        private Janus.Windows.UI.Dock.UIPanel pnlTop;
        private Janus.Windows.UI.Dock.UIPanelInnerContainer pnlTopContainer;
        private System.Windows.Forms.MaskedTextBox txt_ExpenseDocumentDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private Telerik.WinControls.UI.RadGridView rgv_BuyList;
        private System.Windows.Forms.Panel pnl_Action;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label lbl_DocumentId;
        private Telerik.WinControls.UI.RadGridView rgv_Expenses;
        private Janus.Windows.UI.Dock.UIPanel pnl_ExpenseDocuments;
        private Janus.Windows.UI.Dock.UIPanelInnerContainer uiPanel0Container;
        private System.Windows.Forms.Panel pnl_Data;
        private Telerik.WinControls.UI.RadPanel pnl_TopData;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_ExportToExcel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}