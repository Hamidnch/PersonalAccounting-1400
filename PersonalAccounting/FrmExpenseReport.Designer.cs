
namespace PersonalAccounting.UI
{
    partial class FrmExpenseReport
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
            AFrmExpenseReport = null;
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn13 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn14 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn15 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn16 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn17 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn18 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn19 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn20 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn21 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn22 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn23 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn24 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.rgv_Expenses = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_Expenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_Expenses.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // rgv_Expenses
            // 
            this.rgv_Expenses.AutoScroll = true;
            this.rgv_Expenses.BackColor = System.Drawing.SystemColors.Control;
            this.rgv_Expenses.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_Expenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rgv_Expenses.EnableHotTracking = false;
            this.rgv_Expenses.EnterKeyMode = Telerik.WinControls.UI.RadGridViewEnterKeyMode.EnterMovesToNextRow;
            this.rgv_Expenses.Font = new System.Drawing.Font("Tornado Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rgv_Expenses.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgv_Expenses.GroupExpandAnimationType = Telerik.WinControls.UI.GridExpandAnimationType.Slide;
            this.rgv_Expenses.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_Expenses.Location = new System.Drawing.Point(0, 27);
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
            gridViewTextBoxColumn1.FieldName = "ExpenseDate";
            gridViewTextBoxColumn1.HeaderText = "تاریخ هزینه";
            gridViewTextBoxColumn1.Name = "ExpenseDate";
            gridViewTextBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn1.Width = 150;
            gridViewTextBoxColumn2.FieldName = "DocumentId";
            gridViewTextBoxColumn2.HeaderText = "کد سند";
            gridViewTextBoxColumn2.Name = "DocumentId";
            gridViewTextBoxColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn2.Width = 90;
            gridViewTextBoxColumn3.FieldName = "ArticleGroupId";
            gridViewTextBoxColumn3.HeaderText = "کد دسته کالا";
            gridViewTextBoxColumn3.IsVisible = false;
            gridViewTextBoxColumn3.Name = "ArticleGroupId";
            gridViewTextBoxColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn4.FieldName = "ArticleGroupSubject";
            gridViewTextBoxColumn4.HeaderText = "دسته کالا";
            gridViewTextBoxColumn4.Name = "ArticleGroupSubject";
            gridViewTextBoxColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn4.Width = 150;
            gridViewTextBoxColumn5.FieldName = "ArticleId";
            gridViewTextBoxColumn5.HeaderText = "کد کالا";
            gridViewTextBoxColumn5.IsVisible = false;
            gridViewTextBoxColumn5.Name = "ArticleId";
            gridViewTextBoxColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn6.FieldName = "ArticleName";
            gridViewTextBoxColumn6.HeaderText = "عنوان کالا";
            gridViewTextBoxColumn6.Name = "ArticleName";
            gridViewTextBoxColumn6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn6.Width = 150;
            gridViewTextBoxColumn7.FieldName = "FundId";
            gridViewTextBoxColumn7.HeaderText = "کد صندوق";
            gridViewTextBoxColumn7.IsVisible = false;
            gridViewTextBoxColumn7.Name = "FundId";
            gridViewTextBoxColumn7.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn7.Width = 90;
            gridViewTextBoxColumn8.FieldName = "FundName";
            gridViewTextBoxColumn8.HeaderText = "نام صندوق";
            gridViewTextBoxColumn8.Name = "FundName";
            gridViewTextBoxColumn8.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn8.Width = 150;
            gridViewTextBoxColumn9.FieldName = "ByPerson";
            gridViewTextBoxColumn9.HeaderText = "کد شخص هزینه کننده";
            gridViewTextBoxColumn9.IsVisible = false;
            gridViewTextBoxColumn9.Name = "ByPersonId";
            gridViewTextBoxColumn9.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn9.Width = 90;
            gridViewTextBoxColumn10.FieldName = "ByPersonName";
            gridViewTextBoxColumn10.HeaderText = "نام شخص هزینه کننده";
            gridViewTextBoxColumn10.Name = "ByPersonName";
            gridViewTextBoxColumn10.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn10.Width = 150;
            gridViewTextBoxColumn11.FieldName = "ForPersonId";
            gridViewTextBoxColumn11.HeaderText = "کد هزینه شده برای";
            gridViewTextBoxColumn11.IsVisible = false;
            gridViewTextBoxColumn11.Name = "ForPersonId";
            gridViewTextBoxColumn11.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn11.Width = 90;
            gridViewTextBoxColumn12.FieldName = "ForPersonName";
            gridViewTextBoxColumn12.HeaderText = "هزینه شده برای";
            gridViewTextBoxColumn12.Name = "ForPersonName";
            gridViewTextBoxColumn12.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn12.Width = 150;
            gridViewTextBoxColumn13.FieldName = "Fi";
            gridViewTextBoxColumn13.HeaderText = "فی";
            gridViewTextBoxColumn13.Name = "Fi";
            gridViewTextBoxColumn13.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn13.Width = 150;
            gridViewTextBoxColumn14.FieldName = "Count";
            gridViewTextBoxColumn14.HeaderText = "تعداد";
            gridViewTextBoxColumn14.Name = "Count";
            gridViewTextBoxColumn14.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn14.Width = 120;
            gridViewTextBoxColumn15.FieldName = "Price";
            gridViewTextBoxColumn15.HeaderText = "قیمت";
            gridViewTextBoxColumn15.IsVisible = false;
            gridViewTextBoxColumn15.Name = "Price";
            gridViewTextBoxColumn15.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn16.FieldName = "PriceString";
            gridViewTextBoxColumn16.HeaderText = "قیمت";
            gridViewTextBoxColumn16.Name = "PriceString";
            gridViewTextBoxColumn16.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn16.Width = 150;
            gridViewTextBoxColumn17.FieldName = "MeasurementUnitId";
            gridViewTextBoxColumn17.HeaderText = "کد واحد سنجش";
            gridViewTextBoxColumn17.IsVisible = false;
            gridViewTextBoxColumn17.Name = "MeasurementUnitId";
            gridViewTextBoxColumn17.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn17.Width = 90;
            gridViewTextBoxColumn18.FieldName = "MeasurementUnitName";
            gridViewTextBoxColumn18.HeaderText = "واحد سنجش";
            gridViewTextBoxColumn18.Name = "MeasurementUnitName";
            gridViewTextBoxColumn18.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn18.Width = 150;
            gridViewTextBoxColumn19.FieldName = "CreatedBy";
            gridViewTextBoxColumn19.HeaderText = "کاربر ثبت کننده";
            gridViewTextBoxColumn19.Name = "CreatedBy";
            gridViewTextBoxColumn19.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn19.Width = 150;
            gridViewTextBoxColumn20.FieldName = "UpdateBy";
            gridViewTextBoxColumn20.HeaderText = "کاربر ویرایش کننده";
            gridViewTextBoxColumn20.Name = "UpdateBy";
            gridViewTextBoxColumn20.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn20.Width = 150;
            gridViewTextBoxColumn21.FieldName = "CreatedOn";
            gridViewTextBoxColumn21.HeaderText = "تاریخ ایجاد";
            gridViewTextBoxColumn21.IsVisible = false;
            gridViewTextBoxColumn21.Name = "CreatedOn";
            gridViewTextBoxColumn21.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn21.Width = 90;
            gridViewTextBoxColumn22.FieldName = "CreatedOnPersian";
            gridViewTextBoxColumn22.HeaderText = "تاریخ ایجاد";
            gridViewTextBoxColumn22.Name = "CreatedOnPersian";
            gridViewTextBoxColumn22.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn22.Width = 150;
            gridViewTextBoxColumn23.FieldName = "UpdateOnPersian";
            gridViewTextBoxColumn23.HeaderText = "تاریخ آخرین ویرایش";
            gridViewTextBoxColumn23.Name = "UpdateOnPersian";
            gridViewTextBoxColumn23.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn23.Width = 150;
            gridViewTextBoxColumn24.FieldName = "Comment";
            gridViewTextBoxColumn24.HeaderText = "توضیحات";
            gridViewTextBoxColumn24.Name = "Comment";
            gridViewTextBoxColumn24.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn24.Width = 200;
            this.rgv_Expenses.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
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
            gridViewTextBoxColumn14,
            gridViewTextBoxColumn15,
            gridViewTextBoxColumn16,
            gridViewTextBoxColumn17,
            gridViewTextBoxColumn18,
            gridViewTextBoxColumn19,
            gridViewTextBoxColumn20,
            gridViewTextBoxColumn21,
            gridViewTextBoxColumn22,
            gridViewTextBoxColumn23,
            gridViewTextBoxColumn24});
            this.rgv_Expenses.MasterTemplate.EnableAlternatingRowColor = true;
            this.rgv_Expenses.MasterTemplate.EnableFiltering = true;
            this.rgv_Expenses.MasterTemplate.ReadOnly = true;
            this.rgv_Expenses.MasterTemplate.ShowGroupedColumns = true;
            this.rgv_Expenses.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgv_Expenses.Name = "rgv_Expenses";
            this.rgv_Expenses.ReadOnly = true;
            this.rgv_Expenses.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rgv_Expenses.Size = new System.Drawing.Size(969, 538);
            this.rgv_Expenses.TabIndex = 3;
            // 
            // FrmExpenseReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 565);
            this.ControlBox = false;
            this.Controls.Add(this.rgv_Expenses);
            this.Font = new System.Drawing.Font("Tornado Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmExpenseReport";
            this.ShowInTaskbar = false;
            this.Text = "گزارش هزینه ها";
            this.Controls.SetChildIndex(this.rgv_Expenses, 0);
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_Expenses.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_Expenses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

         
        private Telerik.WinControls.UI.RadGridView rgv_Expenses;
    }
}