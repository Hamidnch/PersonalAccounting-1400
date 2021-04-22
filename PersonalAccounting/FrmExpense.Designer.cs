using PersonalAccounting.CommonLibrary.Properties;

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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn33 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn34 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn35 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn36 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn37 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn38 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor5 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor6 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor7 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor8 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition4 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewImageColumn gridViewImageColumn2 = new Telerik.WinControls.UI.GridViewImageColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn20 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn21 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn22 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn23 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn24 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn25 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn26 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn27 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn28 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn29 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn30 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn5 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn6 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn31 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn32 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition3 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExpense));
            this.uiPanelManager1 = new Janus.Windows.UI.Dock.UIPanelManager(this.components);
            this.pnl_ExpenseDocuments = new Janus.Windows.UI.Dock.UIPanel();
            this.uiPanel0Container = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            this.rgv_Expenses = new Telerik.WinControls.UI.RadGridView();
            this.pnlTop = new Janus.Windows.UI.Dock.UIPanel();
            this.pnlTopContainer = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            this.pnl_Data = new System.Windows.Forms.Panel();
            this.rgv_BuyList = new Telerik.WinControls.UI.RadGridView();
            this.status_Summary = new System.Windows.Forms.StatusStrip();
            this.lbl_SumPrice = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnl_TopData = new Telerik.WinControls.UI.RadPanel();
            this.rddl_Users = new Telerik.WinControls.UI.RadDropDownList();
            this.label1 = new System.Windows.Forms.Label();
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
            this.status_Summary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_TopData)).BeginInit();
            this.pnl_TopData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rddl_Users)).BeginInit();
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
            this.uiPanelManager1.AddDockPanelInfo(new System.Guid("01e8259e-715c-48cb-a865-5da501cd96ee"), Janus.Windows.UI.Dock.PanelDockStyle.Fill, new System.Drawing.Size(916, 394), true);
            this.uiPanelManager1.AddDockPanelInfo(new System.Guid("8e74b61a-6571-434b-b4bf-d7669b29989a"), Janus.Windows.UI.Dock.PanelDockStyle.Bottom, new System.Drawing.Size(916, 249), true);
            this.uiPanelManager1.AddFloatingPanelInfo(new System.Guid("01e8259e-715c-48cb-a865-5da501cd96ee"), new System.Drawing.Point(422, 186), new System.Drawing.Size(200, 200), false);
            this.uiPanelManager1.AddFloatingPanelInfo(new System.Guid("8e74b61a-6571-434b-b4bf-d7669b29989a"), new System.Drawing.Point(431, 786), new System.Drawing.Size(200, 200), false);
            this.uiPanelManager1.EndPanelInfo();
            // 
            // pnl_ExpenseDocuments
            // 
            this.pnl_ExpenseDocuments.CloseButtonVisible = Janus.Windows.UI.InheritableBoolean.False;
            this.pnl_ExpenseDocuments.FloatingLocation = new System.Drawing.Point(431, 786);
            this.pnl_ExpenseDocuments.InnerContainer = this.uiPanel0Container;
            this.pnl_ExpenseDocuments.Location = new System.Drawing.Point(3, 424);
            this.pnl_ExpenseDocuments.Name = "pnl_ExpenseDocuments";
            this.pnl_ExpenseDocuments.Size = new System.Drawing.Size(916, 249);
            this.pnl_ExpenseDocuments.TabIndex = 4;
            this.pnl_ExpenseDocuments.Text = "اسناد هزینه";
            this.pnl_ExpenseDocuments.TextAlignment = Janus.Windows.UI.Dock.PanelTextAlignment.Far;
            this.pnl_ExpenseDocuments.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnl_Data_MouseClick);
            // 
            // uiPanel0Container
            // 
            this.uiPanel0Container.Controls.Add(this.rgv_Expenses);
            this.uiPanel0Container.Location = new System.Drawing.Point(1, 25);
            this.uiPanel0Container.Name = "uiPanel0Container";
            this.uiPanel0Container.Size = new System.Drawing.Size(914, 223);
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
            gridViewTextBoxColumn33.EnableExpressionEditor = false;
            gridViewTextBoxColumn33.FieldName = "ExpenseDocumentId";
            gridViewTextBoxColumn33.HeaderText = "شماره سند";
            gridViewTextBoxColumn33.Name = "ExpenseDocumentId";
            gridViewTextBoxColumn33.ReadOnly = true;
            gridViewTextBoxColumn33.SortOrder = Telerik.WinControls.UI.RadSortOrder.Descending;
            gridViewTextBoxColumn33.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn33.Width = 87;
            gridViewTextBoxColumn34.EnableExpressionEditor = false;
            gridViewTextBoxColumn34.FieldName = "ExpenseDocumentPersianDate";
            gridViewTextBoxColumn34.HeaderText = "تاریخ هزینه";
            gridViewTextBoxColumn34.Name = "ExpenseDocumentPersianDate";
            gridViewTextBoxColumn34.ReadOnly = true;
            gridViewTextBoxColumn34.SortOrder = Telerik.WinControls.UI.RadSortOrder.Descending;
            gridViewTextBoxColumn34.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn34.Width = 121;
            gridViewTextBoxColumn35.EnableExpressionEditor = false;
            gridViewTextBoxColumn35.FieldName = "ExpenseDocumentCreationUserName";
            gridViewTextBoxColumn35.HeaderText = "کاربر ثبت کننده";
            gridViewTextBoxColumn35.Name = "ExpenseDocumentCreationUserName";
            gridViewTextBoxColumn35.ReadOnly = true;
            gridViewTextBoxColumn35.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn35.Width = 142;
            gridViewTextBoxColumn36.EnableExpressionEditor = false;
            gridViewTextBoxColumn36.FieldName = "ExpenseDocumentCreationPersianDate";
            gridViewTextBoxColumn36.HeaderText = "تاریخ ثبت";
            gridViewTextBoxColumn36.Name = "ExpenseDocumentCreationPersianDate";
            gridViewTextBoxColumn36.ReadOnly = true;
            gridViewTextBoxColumn36.SortOrder = Telerik.WinControls.UI.RadSortOrder.Descending;
            gridViewTextBoxColumn36.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn36.Width = 150;
            gridViewTextBoxColumn37.EnableExpressionEditor = false;
            gridViewTextBoxColumn37.FieldName = "ExpenseDocumentPersianLastUpdate";
            gridViewTextBoxColumn37.HeaderText = "تاریخ آخرین ویرایش";
            gridViewTextBoxColumn37.Name = "ExpenseDocumentPersianLastUpdate";
            gridViewTextBoxColumn37.ReadOnly = true;
            gridViewTextBoxColumn37.SortOrder = Telerik.WinControls.UI.RadSortOrder.Descending;
            gridViewTextBoxColumn37.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn37.Width = 150;
            gridViewTextBoxColumn38.EnableExpressionEditor = false;
            gridViewTextBoxColumn38.FieldName = "ExpenseDocumentDescription";
            gridViewTextBoxColumn38.HeaderText = "توضیحات";
            gridViewTextBoxColumn38.Name = "ExpenseDocumentDescription";
            gridViewTextBoxColumn38.ReadOnly = true;
            gridViewTextBoxColumn38.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn38.Width = 262;
            this.rgv_Expenses.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn33,
            gridViewTextBoxColumn34,
            gridViewTextBoxColumn35,
            gridViewTextBoxColumn36,
            gridViewTextBoxColumn37,
            gridViewTextBoxColumn38});
            this.rgv_Expenses.MasterTemplate.EnableAlternatingRowColor = true;
            this.rgv_Expenses.MasterTemplate.EnableFiltering = true;
            this.rgv_Expenses.MasterTemplate.ReadOnly = true;
            this.rgv_Expenses.MasterTemplate.ShowGroupedColumns = true;
            sortDescriptor5.Direction = System.ComponentModel.ListSortDirection.Descending;
            sortDescriptor5.PropertyName = "ExpenseDocumentId";
            sortDescriptor6.Direction = System.ComponentModel.ListSortDirection.Descending;
            sortDescriptor6.PropertyName = "ExpenseDocumentPersianDate";
            sortDescriptor7.Direction = System.ComponentModel.ListSortDirection.Descending;
            sortDescriptor7.PropertyName = "ExpenseDocumentCreationPersianDate";
            sortDescriptor8.Direction = System.ComponentModel.ListSortDirection.Descending;
            sortDescriptor8.PropertyName = "ExpenseDocumentPersianLastUpdate";
            this.rgv_Expenses.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor5,
            sortDescriptor6,
            sortDescriptor7,
            sortDescriptor8});
            this.rgv_Expenses.MasterTemplate.ViewDefinition = tableViewDefinition4;
            this.rgv_Expenses.Name = "rgv_Expenses";
            this.rgv_Expenses.ReadOnly = true;
            this.rgv_Expenses.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rgv_Expenses.Size = new System.Drawing.Size(914, 223);
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
            this.pnlTop.Size = new System.Drawing.Size(916, 394);
            this.pnlTop.TabIndex = 4;
            this.pnlTop.Text = "ورود هزینه ها";
            this.pnlTop.TextAlignment = Janus.Windows.UI.Dock.PanelTextAlignment.Far;
            this.pnlTop.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnl_Data_MouseClick);
            // 
            // pnlTopContainer
            // 
            this.pnlTopContainer.Controls.Add(this.pnl_Data);
            this.pnlTopContainer.Controls.Add(this.pnl_Action);
            this.pnlTopContainer.Location = new System.Drawing.Point(0, 20);
            this.pnlTopContainer.Name = "pnlTopContainer";
            this.pnlTopContainer.Size = new System.Drawing.Size(916, 374);
            this.pnlTopContainer.TabIndex = 0;
            // 
            // pnl_Data
            // 
            this.pnl_Data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.pnl_Data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Data.Controls.Add(this.rgv_BuyList);
            this.pnl_Data.Controls.Add(this.status_Summary);
            this.pnl_Data.Controls.Add(this.pnl_TopData);
            this.pnl_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Data.Enabled = false;
            this.pnl_Data.Location = new System.Drawing.Point(0, 39);
            this.pnl_Data.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_Data.Name = "pnl_Data";
            this.pnl_Data.Size = new System.Drawing.Size(916, 335);
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
            gridViewImageColumn2.AllowSort = false;
            gridViewImageColumn2.DisableHTMLRendering = false;
            gridViewImageColumn2.EnableExpressionEditor = false;
            gridViewImageColumn2.FieldName = "DeleteRow";
            gridViewImageColumn2.Name = "DeleteRow";
            gridViewImageColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewImageColumn2.Width = 24;
            gridViewTextBoxColumn20.AllowGroup = false;
            gridViewTextBoxColumn20.AllowSort = false;
            gridViewTextBoxColumn20.DisableHTMLRendering = false;
            gridViewTextBoxColumn20.EnableExpressionEditor = false;
            gridViewTextBoxColumn20.FieldName = "RowNumber";
            gridViewTextBoxColumn20.HeaderText = "ردیف";
            gridViewTextBoxColumn20.Name = "RowNumber";
            gridViewTextBoxColumn20.ReadOnly = true;
            gridViewTextBoxColumn20.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn20.VisibleInColumnChooser = false;
            gridViewTextBoxColumn20.Width = 43;
            gridViewTextBoxColumn21.AllowGroup = false;
            gridViewTextBoxColumn21.AllowSort = false;
            gridViewTextBoxColumn21.EnableExpressionEditor = false;
            gridViewTextBoxColumn21.FieldName = "ArticleId";
            gridViewTextBoxColumn21.HeaderText = "کد کالا";
            gridViewTextBoxColumn21.IsVisible = false;
            gridViewTextBoxColumn21.Name = "ArticleId";
            gridViewTextBoxColumn21.ReadOnly = true;
            gridViewTextBoxColumn21.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn22.AllowGroup = false;
            gridViewTextBoxColumn22.AllowSort = false;
            gridViewTextBoxColumn22.DisableHTMLRendering = false;
            gridViewTextBoxColumn22.EnableExpressionEditor = false;
            gridViewTextBoxColumn22.FieldName = "ArticleName";
            gridViewTextBoxColumn22.HeaderText = "شرح کالا";
            gridViewTextBoxColumn22.Name = "ArticleName";
            gridViewTextBoxColumn22.ReadOnly = true;
            gridViewTextBoxColumn22.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn22.Width = 136;
            gridViewTextBoxColumn23.AllowGroup = false;
            gridViewTextBoxColumn23.AllowSort = false;
            gridViewTextBoxColumn23.EnableExpressionEditor = false;
            gridViewTextBoxColumn23.FieldName = "FundId";
            gridViewTextBoxColumn23.HeaderText = "کد صندوق";
            gridViewTextBoxColumn23.IsVisible = false;
            gridViewTextBoxColumn23.Name = "FundId";
            gridViewTextBoxColumn23.ReadOnly = true;
            gridViewTextBoxColumn23.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn23.Width = 56;
            gridViewTextBoxColumn24.AllowGroup = false;
            gridViewTextBoxColumn24.AllowSort = false;
            gridViewTextBoxColumn24.DisableHTMLRendering = false;
            gridViewTextBoxColumn24.EnableExpressionEditor = false;
            gridViewTextBoxColumn24.FieldName = "FundName";
            gridViewTextBoxColumn24.HeaderText = "صندوق هزینه";
            gridViewTextBoxColumn24.Name = "FundName";
            gridViewTextBoxColumn24.ReadOnly = true;
            gridViewTextBoxColumn24.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn24.Width = 170;
            gridViewTextBoxColumn25.AllowGroup = false;
            gridViewTextBoxColumn25.AllowSort = false;
            gridViewTextBoxColumn25.EnableExpressionEditor = false;
            gridViewTextBoxColumn25.FieldName = "ByPersonId";
            gridViewTextBoxColumn25.HeaderText = "کدشخص";
            gridViewTextBoxColumn25.IsVisible = false;
            gridViewTextBoxColumn25.Name = "ByPersonId";
            gridViewTextBoxColumn25.ReadOnly = true;
            gridViewTextBoxColumn25.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn25.Width = 48;
            gridViewTextBoxColumn26.AllowGroup = false;
            gridViewTextBoxColumn26.AllowSort = false;
            gridViewTextBoxColumn26.DisableHTMLRendering = false;
            gridViewTextBoxColumn26.EnableExpressionEditor = false;
            gridViewTextBoxColumn26.FieldName = "ByPersonName";
            gridViewTextBoxColumn26.HeaderText = "هزینه کننده";
            gridViewTextBoxColumn26.Name = "ByPersonName";
            gridViewTextBoxColumn26.ReadOnly = true;
            gridViewTextBoxColumn26.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn26.Width = 99;
            gridViewTextBoxColumn27.AllowGroup = false;
            gridViewTextBoxColumn27.AllowSort = false;
            gridViewTextBoxColumn27.EnableExpressionEditor = false;
            gridViewTextBoxColumn27.FieldName = "ForPersonId";
            gridViewTextBoxColumn27.HeaderText = "کد هزینه شونده";
            gridViewTextBoxColumn27.IsVisible = false;
            gridViewTextBoxColumn27.Name = "ForPersonId";
            gridViewTextBoxColumn27.ReadOnly = true;
            gridViewTextBoxColumn27.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn27.Width = 46;
            gridViewTextBoxColumn28.AllowGroup = false;
            gridViewTextBoxColumn28.AllowSort = false;
            gridViewTextBoxColumn28.DisableHTMLRendering = false;
            gridViewTextBoxColumn28.EnableExpressionEditor = false;
            gridViewTextBoxColumn28.FieldName = "ForPersonName";
            gridViewTextBoxColumn28.HeaderText = "هزینه شده برای";
            gridViewTextBoxColumn28.Name = "ForPersonName";
            gridViewTextBoxColumn28.ReadOnly = true;
            gridViewTextBoxColumn28.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn28.Width = 100;
            gridViewTextBoxColumn29.AllowGroup = false;
            gridViewTextBoxColumn29.AllowSort = false;
            gridViewTextBoxColumn29.EnableExpressionEditor = false;
            gridViewTextBoxColumn29.FieldName = "MeasurementUnitId";
            gridViewTextBoxColumn29.HeaderText = "کدسنجش";
            gridViewTextBoxColumn29.IsVisible = false;
            gridViewTextBoxColumn29.Name = "MeasurementUnitId";
            gridViewTextBoxColumn29.ReadOnly = true;
            gridViewTextBoxColumn29.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn29.Width = 41;
            gridViewTextBoxColumn30.AllowGroup = false;
            gridViewTextBoxColumn30.AllowSort = false;
            gridViewTextBoxColumn30.DisableHTMLRendering = false;
            gridViewTextBoxColumn30.EnableExpressionEditor = false;
            gridViewTextBoxColumn30.FieldName = "MeasurementUnitName";
            gridViewTextBoxColumn30.HeaderText = "واحد سنجش";
            gridViewTextBoxColumn30.Name = "MeasurementUnitName";
            gridViewTextBoxColumn30.ReadOnly = true;
            gridViewTextBoxColumn30.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn30.Width = 84;
            gridViewDecimalColumn4.AllowFiltering = false;
            gridViewDecimalColumn4.AllowGroup = false;
            gridViewDecimalColumn4.AllowHide = false;
            gridViewDecimalColumn4.AllowSort = false;
            gridViewDecimalColumn4.DecimalPlaces = 0;
            gridViewDecimalColumn4.DisableHTMLRendering = false;
            gridViewDecimalColumn4.EnableExpressionEditor = false;
            gridViewDecimalColumn4.ExcelExportType = Telerik.WinControls.UI.Export.DisplayFormatType.Currency;
            gridViewDecimalColumn4.FieldName = "Fi";
            gridViewDecimalColumn4.FormatInfo = new System.Globalization.CultureInfo("fa-IR");
            gridViewDecimalColumn4.HeaderText = "فی";
            gridViewDecimalColumn4.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            gridViewDecimalColumn4.Name = "Fi";
            gridViewDecimalColumn4.ShowUpDownButtons = false;
            gridViewDecimalColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDecimalColumn4.ThousandsSeparator = true;
            gridViewDecimalColumn4.Width = 76;
            gridViewDecimalColumn5.AllowGroup = false;
            gridViewDecimalColumn5.AllowSort = false;
            gridViewDecimalColumn5.EnableExpressionEditor = false;
            gridViewDecimalColumn5.FieldName = "Count";
            gridViewDecimalColumn5.FormatInfo = new System.Globalization.CultureInfo("fa-IR");
            gridViewDecimalColumn5.HeaderText = "تعداد";
            gridViewDecimalColumn5.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            gridViewDecimalColumn5.Name = "Count";
            gridViewDecimalColumn5.ShowUpDownButtons = false;
            gridViewDecimalColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDecimalColumn5.ThousandsSeparator = true;
            gridViewDecimalColumn5.Width = 48;
            gridViewDecimalColumn6.AllowFiltering = false;
            gridViewDecimalColumn6.AllowGroup = false;
            gridViewDecimalColumn6.AllowHide = false;
            gridViewDecimalColumn6.AllowSort = false;
            gridViewDecimalColumn6.EnableExpressionEditor = false;
            gridViewDecimalColumn6.FieldName = "Price";
            gridViewDecimalColumn6.FormatInfo = new System.Globalization.CultureInfo("fa-IR");
            gridViewDecimalColumn6.HeaderText = "مبلغ";
            gridViewDecimalColumn6.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            gridViewDecimalColumn6.Name = "Price";
            gridViewDecimalColumn6.ReadOnly = true;
            gridViewDecimalColumn6.ShowUpDownButtons = false;
            gridViewDecimalColumn6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDecimalColumn6.ThousandsSeparator = true;
            gridViewDecimalColumn6.Width = 127;
            gridViewTextBoxColumn31.AcceptsReturn = true;
            gridViewTextBoxColumn31.AcceptsTab = true;
            gridViewTextBoxColumn31.AllowGroup = false;
            gridViewTextBoxColumn31.AllowSort = false;
            gridViewTextBoxColumn31.DisableHTMLRendering = false;
            gridViewTextBoxColumn31.EnableExpressionEditor = false;
            gridViewTextBoxColumn31.ExcelExportType = Telerik.WinControls.UI.Export.DisplayFormatType.Currency;
            gridViewTextBoxColumn31.FieldName = "Comment";
            gridViewTextBoxColumn31.HeaderText = "توضیحات";
            gridViewTextBoxColumn31.Name = "Comment";
            gridViewTextBoxColumn31.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn31.Width = 300;
            gridViewTextBoxColumn32.AllowGroup = false;
            gridViewTextBoxColumn32.AllowSort = false;
            gridViewTextBoxColumn32.DisableHTMLRendering = false;
            gridViewTextBoxColumn32.EnableExpressionEditor = false;
            gridViewTextBoxColumn32.FieldName = "FundCurrentValue";
            gridViewTextBoxColumn32.HeaderText = "مانده صندوق";
            gridViewTextBoxColumn32.IsVisible = false;
            gridViewTextBoxColumn32.Name = "FundCurrentValue";
            gridViewTextBoxColumn32.ReadOnly = true;
            gridViewTextBoxColumn32.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn32.Width = 83;
            this.rgv_BuyList.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewImageColumn2,
            gridViewTextBoxColumn20,
            gridViewTextBoxColumn21,
            gridViewTextBoxColumn22,
            gridViewTextBoxColumn23,
            gridViewTextBoxColumn24,
            gridViewTextBoxColumn25,
            gridViewTextBoxColumn26,
            gridViewTextBoxColumn27,
            gridViewTextBoxColumn28,
            gridViewTextBoxColumn29,
            gridViewTextBoxColumn30,
            gridViewDecimalColumn4,
            gridViewDecimalColumn5,
            gridViewDecimalColumn6,
            gridViewTextBoxColumn31,
            gridViewTextBoxColumn32});
            this.rgv_BuyList.MasterTemplate.EnableAlternatingRowColor = true;
            this.rgv_BuyList.MasterTemplate.EnableGrouping = false;
            this.rgv_BuyList.MasterTemplate.EnableSorting = false;
            this.rgv_BuyList.MasterTemplate.MultiSelect = true;
            this.rgv_BuyList.MasterTemplate.ShowHeaderCellButtons = true;
            this.rgv_BuyList.MasterTemplate.ViewDefinition = tableViewDefinition3;
            this.rgv_BuyList.Name = "rgv_BuyList";
            this.rgv_BuyList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rgv_BuyList.ShowGroupPanel = false;
            this.rgv_BuyList.ShowHeaderCellButtons = true;
            this.rgv_BuyList.Size = new System.Drawing.Size(914, 273);
            this.rgv_BuyList.TabIndex = 171;
            this.rgv_BuyList.CellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.rgv_BuyList_CellFormatting);
            this.rgv_BuyList.ViewCellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.rgv_BuyList_ViewCellFormatting);
            this.rgv_BuyList.CellEndEdit += new Telerik.WinControls.UI.GridViewCellEventHandler(this.rgv_BuyList_CellEndEdit);
            this.rgv_BuyList.CellValidating += new Telerik.WinControls.UI.CellValidatingEventHandler(this.rgv_BuyList_CellValidating);
            this.rgv_BuyList.UserAddingRow += new Telerik.WinControls.UI.GridViewRowCancelEventHandler(this.rgv_BuyList_UserAddingRow);
            this.rgv_BuyList.UserDeletingRow += new Telerik.WinControls.UI.GridViewRowCancelEventHandler(this.rgv_BuyList_UserDeletingRow);
            this.rgv_BuyList.UserDeletedRow += new Telerik.WinControls.UI.GridViewRowEventHandler(this.rgv_BuyList_UserDeletedRow);
            this.rgv_BuyList.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.rgv_BuyList_CellClick);
            this.rgv_BuyList.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.rgv_BuyList_CellDoubleClick);
            this.rgv_BuyList.CellValueChanged += new Telerik.WinControls.UI.GridViewCellEventHandler(this.rgv_BuyList_CellValueChanged);
            this.rgv_BuyList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rgv_BuyList_KeyDown);
            this.rgv_BuyList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnl_Data_MouseClick);
            this.rgv_BuyList.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.rgv_BuyList_PreviewKeyDown);
            // 
            // status_Summary
            // 
            this.status_Summary.AutoSize = false;
            this.status_Summary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.status_Summary.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.status_Summary.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_SumPrice});
            this.status_Summary.Location = new System.Drawing.Point(0, 304);
            this.status_Summary.Name = "status_Summary";
            this.status_Summary.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.status_Summary.Size = new System.Drawing.Size(914, 29);
            this.status_Summary.TabIndex = 1;
            // 
            // lbl_SumPrice
            // 
            this.lbl_SumPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_SumPrice.ForeColor = System.Drawing.Color.Black;
            this.lbl_SumPrice.Name = "lbl_SumPrice";
            this.lbl_SumPrice.Size = new System.Drawing.Size(899, 24);
            this.lbl_SumPrice.Spring = true;
            this.lbl_SumPrice.Text = "0";
            // 
            // pnl_TopData
            // 
            this.pnl_TopData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.pnl_TopData.Controls.Add(this.rddl_Users);
            this.pnl_TopData.Controls.Add(this.label1);
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
            // rddl_Users
            // 
            this.rddl_Users.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rddl_Users.AutoSize = false;
            this.rddl_Users.AutoSizeItems = true;
            this.rddl_Users.BackColor = System.Drawing.Color.White;
            this.rddl_Users.DropDownAnimationEasing = Telerik.WinControls.RadEasingType.InCubic;
            this.rddl_Users.DropDownSizingMode = ((Telerik.WinControls.UI.SizingMode)((Telerik.WinControls.UI.SizingMode.RightBottom | Telerik.WinControls.UI.SizingMode.UpDown)));
            this.rddl_Users.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.rddl_Users.EnableAlternatingItemColor = true;
            this.rddl_Users.Font = new System.Drawing.Font("Tornado Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rddl_Users.Location = new System.Drawing.Point(323, 3);
            this.rddl_Users.Name = "rddl_Users";
            this.rddl_Users.Size = new System.Drawing.Size(228, 22);
            this.rddl_Users.TabIndex = 201;
            this.rddl_Users.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.rddl_Users_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tornado Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(557, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 14);
            this.label1.TabIndex = 200;
            this.label1.Text = "نام کاربر";
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
            this.txt_ExpenseDocumentDate.Size = new System.Drawing.Size(83, 20);
            this.txt_ExpenseDocumentDate.TabIndex = 0;
            this.txt_ExpenseDocumentDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_ExpenseDocumentDate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnl_Data_MouseClick);
            this.txt_ExpenseDocumentDate.TextChanged += new System.EventHandler(this.txt_IncomeDate_TextChanged);
            // 
            // lbl_DocumentId
            // 
            this.lbl_DocumentId.AutoSize = true;
            this.lbl_DocumentId.BackColor = System.Drawing.Color.Transparent;
            this.lbl_DocumentId.Font = new System.Drawing.Font("Tahoma", 10F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DocumentId.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_DocumentId.Location = new System.Drawing.Point(33, 5);
            this.lbl_DocumentId.Name = "lbl_DocumentId";
            this.lbl_DocumentId.Size = new System.Drawing.Size(17, 17);
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
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 167;
            this.label3.Text = "تاریخ هزینه";
            this.label3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnl_Data_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(79, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 170;
            this.label5.Text = "شماره سند";
            this.label5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnl_Data_MouseClick);
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
            this.btnClose.Location = new System.Drawing.Point(5, 4);
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
            // FrmExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
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
            this.status_Summary.ResumeLayout(false);
            this.status_Summary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_TopData)).EndInit();
            this.pnl_TopData.ResumeLayout(false);
            this.pnl_TopData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rddl_Users)).EndInit();
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
        private System.Windows.Forms.StatusStrip status_Summary;
        private System.Windows.Forms.ToolStripStatusLabel lbl_SumPrice;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Telerik.WinControls.UI.RadDropDownList rddl_Users;
        private System.Windows.Forms.Label label1;
    }
}