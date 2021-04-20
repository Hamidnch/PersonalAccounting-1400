namespace PersonalAccounting.UI
{
    partial class FrmMeasurementUnit
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
            AFrmMeasurementUnit = null;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMeasurementUnit));
            this.lbl_UnitName = new System.Windows.Forms.Label();
            this.txt_MeasurementUnitName = new System.Windows.Forms.TextBox();
            this.pnl_Data = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.pnl_Action = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.rlv_MeasurementUnit = new Telerik.WinControls.UI.RadListView();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).BeginInit();
            this.pnl_Data.SuspendLayout();
            this.pnl_Action.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rlv_MeasurementUnit)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_UnitName
            // 
            this.lbl_UnitName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_UnitName.AutoSize = true;
            this.lbl_UnitName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_UnitName.ForeColor = System.Drawing.Color.Black;
            this.lbl_UnitName.Location = new System.Drawing.Point(777, 15);
            this.lbl_UnitName.Name = "lbl_UnitName";
            this.lbl_UnitName.Size = new System.Drawing.Size(72, 13);
            this.lbl_UnitName.TabIndex = 14;
            this.lbl_UnitName.Text = "عنوان سنجش";
            // 
            // txt_MeasurementUnitName
            // 
            this.txt_MeasurementUnitName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_MeasurementUnitName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MeasurementUnitName.Location = new System.Drawing.Point(11, 11);
            this.txt_MeasurementUnitName.Name = "txt_MeasurementUnitName";
            this.txt_MeasurementUnitName.Size = new System.Drawing.Size(760, 23);
            this.txt_MeasurementUnitName.TabIndex = 0;
            this.txt_MeasurementUnitName.TextChanged += new System.EventHandler(this.txt_MeasurementUnitName_TextChanged);
            this.txt_MeasurementUnitName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_MeasurementUnitName_KeyDown);
            // 
            // pnl_Data
            // 
            this.pnl_Data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Data.Controls.Add(this.lbl_UnitName);
            this.pnl_Data.Controls.Add(this.txt_MeasurementUnitName);
            this.pnl_Data.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Data.Enabled = false;
            this.pnl_Data.Location = new System.Drawing.Point(0, 27);
            this.pnl_Data.Name = "pnl_Data";
            this.pnl_Data.Size = new System.Drawing.Size(862, 49);
            this.pnl_Data.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point(5, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(84, 29);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "بستن فرم";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "zodiac.gif");
            this.imgList.Images.SetKeyName(1, "balance-sheet-icon.gif");
            this.imgList.Images.SetKeyName(2, "Scale.gif");
            // 
            // pnl_Action
            // 
            this.pnl_Action.AutoSize = true;
            this.pnl_Action.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_Action.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Action.Controls.Add(this.btnCancel);
            this.pnl_Action.Controls.Add(this.btnDelete);
            this.pnl_Action.Controls.Add(this.btnModify);
            this.pnl_Action.Controls.Add(this.btnRegister);
            this.pnl_Action.Controls.Add(this.btnInsert);
            this.pnl_Action.Controls.Add(this.btnClose);
            this.pnl_Action.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Action.Location = new System.Drawing.Point(0, 76);
            this.pnl_Action.Name = "pnl_Action";
            this.pnl_Action.Size = new System.Drawing.Size(862, 40);
            this.pnl_Action.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancel.Enabled = false;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(705, 3);
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
            this.btnDelete.Location = new System.Drawing.Point(735, 3);
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
            this.btnModify.Location = new System.Drawing.Point(765, 3);
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
            this.btnRegister.Location = new System.Drawing.Point(795, 3);
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
            this.btnInsert.Location = new System.Drawing.Point(825, 3);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(31, 31);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // rlv_MeasurementUnit
            // 
            this.rlv_MeasurementUnit.AllowEdit = false;
            this.rlv_MeasurementUnit.AllowRemove = false;
            this.rlv_MeasurementUnit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rlv_MeasurementUnit.DisplayMember = "MeasurementUnitName";
            this.rlv_MeasurementUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rlv_MeasurementUnit.EnableColumnSort = true;
            this.rlv_MeasurementUnit.EnableFiltering = true;
            this.rlv_MeasurementUnit.EnableKeyMap = true;
            this.rlv_MeasurementUnit.EnableLassoSelection = true;
            this.rlv_MeasurementUnit.EnableSorting = true;
            this.rlv_MeasurementUnit.FullRowSelect = false;
            this.rlv_MeasurementUnit.ItemSpacing = -1;
            this.rlv_MeasurementUnit.Location = new System.Drawing.Point(0, 116);
            this.rlv_MeasurementUnit.Name = "rlv_MeasurementUnit";
            this.rlv_MeasurementUnit.ShowGridLines = true;
            this.rlv_MeasurementUnit.Size = new System.Drawing.Size(862, 455);
            this.rlv_MeasurementUnit.TabIndex = 2;
            this.rlv_MeasurementUnit.ValueMember = "MeasurementUnitId";
            this.rlv_MeasurementUnit.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView;
            this.rlv_MeasurementUnit.ItemMouseClick += new Telerik.WinControls.UI.ListViewItemEventHandler(this.rlv_MeasurementUnit_ItemMouseClick);
            this.rlv_MeasurementUnit.ColumnCreating += new Telerik.WinControls.UI.ListViewColumnCreatingEventHandler(this.rlv_MeasurementUnit_ColumnCreating);
            this.rlv_MeasurementUnit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rlv_MeasurementUnit_KeyDown);
            // 
            // FrmMeasurementUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 571);
            this.Controls.Add(this.rlv_MeasurementUnit);
            this.Controls.Add(this.pnl_Action);
            this.Controls.Add(this.pnl_Data);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMeasurementUnit";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "فرم جزئیات آحاد سنجش";
            this.Controls.SetChildIndex(this.pnl_Data, 0);
            this.Controls.SetChildIndex(this.pnl_Action, 0);
            this.Controls.SetChildIndex(this.rlv_MeasurementUnit, 0);
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).EndInit();
            this.pnl_Data.ResumeLayout(false);
            this.pnl_Data.PerformLayout();
            this.pnl_Action.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rlv_MeasurementUnit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_UnitName;
        private System.Windows.Forms.TextBox txt_MeasurementUnitName;
        private System.Windows.Forms.Panel pnl_Data;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.Panel pnl_Action;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnInsert;
        private Telerik.WinControls.UI.RadListView rlv_MeasurementUnit;
    }
}