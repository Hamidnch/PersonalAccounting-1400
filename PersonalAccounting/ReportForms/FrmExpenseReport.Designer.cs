
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.rgv_Expenses = new Telerik.WinControls.UI.RadGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnl_Data = new System.Windows.Forms.Panel();
            this.btn_ExportToExcel = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_Expenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_Expenses.MasterTemplate)).BeginInit();
            this.pnl_Data.SuspendLayout();
            this.SuspendLayout();
            // 
            // rgv_Expenses
            // 
            this.rgv_Expenses.AutoScroll = true;
            this.rgv_Expenses.BackColor = System.Drawing.SystemColors.Control;
            this.rgv_Expenses.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_Expenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rgv_Expenses.EnterKeyMode = Telerik.WinControls.UI.RadGridViewEnterKeyMode.EnterMovesToNextRow;
            this.rgv_Expenses.Font = new System.Drawing.Font("Tornado Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rgv_Expenses.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgv_Expenses.GroupExpandAnimationType = Telerik.WinControls.UI.GridExpandAnimationType.Slide;
            this.rgv_Expenses.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_Expenses.Location = new System.Drawing.Point(0, 65);
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
            gridViewTextBoxColumn1.FieldName = "DocumentId";
            gridViewTextBoxColumn1.HeaderText = "کد سند";
            gridViewTextBoxColumn1.Name = "DocumentId";
            gridViewTextBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn1.Width = 70;
            gridViewTextBoxColumn2.FieldName = "ExpensePersianDate";
            gridViewTextBoxColumn2.HeaderText = "تاریخ هزینه";
            gridViewTextBoxColumn2.Name = "ExpensePersianDate";
            gridViewTextBoxColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn2.Width = 180;
            gridViewTextBoxColumn3.FieldName = "ArticleGroupId";
            gridViewTextBoxColumn3.HeaderText = "کد دسته کالا";
            gridViewTextBoxColumn3.IsVisible = false;
            gridViewTextBoxColumn3.Name = "ArticleGroupId";
            gridViewTextBoxColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn3.Width = 20;
            gridViewTextBoxColumn4.FieldName = "ArticleGroupSubject";
            gridViewTextBoxColumn4.HeaderText = "دسته کالا";
            gridViewTextBoxColumn4.Name = "ArticleGroupSubject";
            gridViewTextBoxColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn4.Width = 180;
            gridViewTextBoxColumn5.FieldName = "ArticleId";
            gridViewTextBoxColumn5.HeaderText = "کد کالا";
            gridViewTextBoxColumn5.IsVisible = false;
            gridViewTextBoxColumn5.Name = "ArticleId";
            gridViewTextBoxColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn6.FieldName = "ArticleName";
            gridViewTextBoxColumn6.HeaderText = "عنوان کالا";
            gridViewTextBoxColumn6.Name = "ArticleName";
            gridViewTextBoxColumn6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn6.Width = 180;
            gridViewTextBoxColumn7.FieldName = "ByPerson";
            gridViewTextBoxColumn7.HeaderText = "کد شخص هزینه کننده";
            gridViewTextBoxColumn7.IsVisible = false;
            gridViewTextBoxColumn7.Name = "ByPersonId";
            gridViewTextBoxColumn7.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn7.Width = 20;
            gridViewTextBoxColumn8.FieldName = "ByPersonName";
            gridViewTextBoxColumn8.HeaderText = "هزینه کننده";
            gridViewTextBoxColumn8.Name = "ByPersonName";
            gridViewTextBoxColumn8.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn8.Width = 150;
            gridViewTextBoxColumn9.FieldName = "ForPersonId";
            gridViewTextBoxColumn9.HeaderText = "کد هزینه شده برای";
            gridViewTextBoxColumn9.IsVisible = false;
            gridViewTextBoxColumn9.Name = "ForPersonId";
            gridViewTextBoxColumn9.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn9.Width = 20;
            gridViewTextBoxColumn10.FieldName = "ForPersonName";
            gridViewTextBoxColumn10.HeaderText = "هزینه شده برای";
            gridViewTextBoxColumn10.Name = "ForPersonName";
            gridViewTextBoxColumn10.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn10.Width = 150;
            gridViewTextBoxColumn11.FieldName = "FundId";
            gridViewTextBoxColumn11.HeaderText = "کد صندوق";
            gridViewTextBoxColumn11.IsVisible = false;
            gridViewTextBoxColumn11.Name = "FundId";
            gridViewTextBoxColumn11.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn11.Width = 90;
            gridViewTextBoxColumn12.FieldName = "FundName";
            gridViewTextBoxColumn12.HeaderText = "هزینه شده از صندوق";
            gridViewTextBoxColumn12.Name = "FundName";
            gridViewTextBoxColumn12.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn12.Width = 150;
            gridViewTextBoxColumn13.FieldName = "Fi";
            gridViewTextBoxColumn13.FormatString = "{0:n0}";
            gridViewTextBoxColumn13.HeaderText = "فی";
            gridViewTextBoxColumn13.Name = "Fi";
            gridViewTextBoxColumn13.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn13.Width = 200;
            gridViewTextBoxColumn14.FieldName = "Count";
            gridViewTextBoxColumn14.HeaderText = "تعداد";
            gridViewTextBoxColumn14.Name = "Count";
            gridViewTextBoxColumn14.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn14.Width = 90;
            gridViewTextBoxColumn15.FieldName = "Price";
            gridViewTextBoxColumn15.FormatString = "{0:n0}";
            gridViewTextBoxColumn15.HeaderText = "قیمت";
            gridViewTextBoxColumn15.Name = "Price";
            gridViewTextBoxColumn15.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn15.Width = 200;
            gridViewTextBoxColumn16.FieldName = "MeasurementUnitId";
            gridViewTextBoxColumn16.HeaderText = "کد واحد سنجش";
            gridViewTextBoxColumn16.IsVisible = false;
            gridViewTextBoxColumn16.Name = "MeasurementUnitId";
            gridViewTextBoxColumn16.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn16.Width = 90;
            gridViewTextBoxColumn17.FieldName = "MeasurementUnitName";
            gridViewTextBoxColumn17.HeaderText = "واحد سنجش";
            gridViewTextBoxColumn17.Name = "MeasurementUnitName";
            gridViewTextBoxColumn17.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn17.Width = 150;
            gridViewTextBoxColumn18.FieldName = "ExpenseCreatedOnPersian";
            gridViewTextBoxColumn18.HeaderText = "تاریخ ایجاد";
            gridViewTextBoxColumn18.Name = "ExpenseCreatedOnPersian";
            gridViewTextBoxColumn18.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn18.Width = 150;
            gridViewTextBoxColumn19.FieldName = "CreationUserName";
            gridViewTextBoxColumn19.HeaderText = "کاربر ثبت کننده";
            gridViewTextBoxColumn19.Name = "CreationUserName";
            gridViewTextBoxColumn19.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn19.Width = 150;
            gridViewTextBoxColumn20.FieldName = "UpdateOnPersian";
            gridViewTextBoxColumn20.HeaderText = "تاریخ آخرین ویرایش";
            gridViewTextBoxColumn20.Name = "UpdateOnPersian";
            gridViewTextBoxColumn20.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn20.Width = 150;
            gridViewTextBoxColumn21.FieldName = "UpdateUserName";
            gridViewTextBoxColumn21.HeaderText = "کاربر ویرایش کننده";
            gridViewTextBoxColumn21.Name = "UpdateUserName";
            gridViewTextBoxColumn21.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn21.Width = 150;
            gridViewTextBoxColumn22.FieldName = "Comment";
            gridViewTextBoxColumn22.HeaderText = "توضیحات";
            gridViewTextBoxColumn22.Name = "Comment";
            gridViewTextBoxColumn22.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn22.Width = 200;
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
            gridViewTextBoxColumn22});
            this.rgv_Expenses.MasterTemplate.EnableAlternatingRowColor = true;
            this.rgv_Expenses.MasterTemplate.EnableFiltering = true;
            this.rgv_Expenses.MasterTemplate.ReadOnly = true;
            this.rgv_Expenses.MasterTemplate.ShowGroupedColumns = true;
            this.rgv_Expenses.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgv_Expenses.Name = "rgv_Expenses";
            this.rgv_Expenses.ReadOnly = true;
            this.rgv_Expenses.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rgv_Expenses.Size = new System.Drawing.Size(969, 525);
            this.rgv_Expenses.TabIndex = 3;
            this.rgv_Expenses.ViewCellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.rgv_Expenses_ViewCellFormatting);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point(3, 3);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(76, 29);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "بستن";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnl_Data
            // 
            this.pnl_Data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.pnl_Data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Data.Controls.Add(this.btn_ExportToExcel);
            this.pnl_Data.Controls.Add(this.btnClose);
            this.pnl_Data.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Data.Location = new System.Drawing.Point(0, 27);
            this.pnl_Data.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_Data.Name = "pnl_Data";
            this.pnl_Data.Size = new System.Drawing.Size(969, 38);
            this.pnl_Data.TabIndex = 8;
            // 
            // btn_ExportToExcel
            // 
            this.btn_ExportToExcel.BackColor = System.Drawing.Color.Transparent;
            this.btn_ExportToExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ExportToExcel.Location = new System.Drawing.Point(82, 3);
            this.btn_ExportToExcel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ExportToExcel.Name = "btn_ExportToExcel";
            this.btn_ExportToExcel.Size = new System.Drawing.Size(129, 29);
            this.btn_ExportToExcel.TabIndex = 6;
            this.btn_ExportToExcel.Text = "ارسال به اکسل";
            this.btn_ExportToExcel.UseVisualStyleBackColor = false;
            this.btn_ExportToExcel.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Excel (*.xls)|*.xls";
            // 
            // FrmExpenseReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 590);
            this.ControlBox = false;
            this.Controls.Add(this.rgv_Expenses);
            this.Controls.Add(this.pnl_Data);
            this.Font = new System.Drawing.Font("Tornado Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmExpenseReport";
            this.ShowInTaskbar = false;
            this.Text = "گزارش هزینه ها";
            this.Controls.SetChildIndex(this.pnl_Data, 0);
            this.Controls.SetChildIndex(this.rgv_Expenses, 0);
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_Expenses.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_Expenses)).EndInit();
            this.pnl_Data.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion


        private Telerik.WinControls.UI.RadGridView rgv_Expenses;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnl_Data;
        private System.Windows.Forms.Button btn_ExportToExcel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}