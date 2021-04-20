namespace PersonalAccounting.UI
{
    partial class FrmWeatherCondition
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
            AFrmWeatherCondition = null;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWeatherCondition));
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.pic_Picture = new System.Windows.Forms.PictureBox();
            this.pnl_Data = new System.Windows.Forms.Panel();
            this.ddl_Status = new Telerik.WinControls.UI.RadDropDownList();
            this.txt_Description = new Telerik.WinControls.UI.RadTextBoxControl();
            this.txt_Title = new Telerik.WinControls.UI.RadTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.pnl_Action = new System.Windows.Forms.Panel();
            this.txt_Extenstion = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.rgv_WeatherCondition = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Picture)).BeginInit();
            this.pnl_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddl_Status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Description)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Title)).BeginInit();
            this.pnl_Action.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_WeatherCondition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_WeatherCondition.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Picture
            // 
            this.pic_Picture.BackColor = System.Drawing.Color.Transparent;
            this.pic_Picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_Picture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Picture.ErrorImage = null;
            this.pic_Picture.Image = global::PersonalAccounting.UI.Properties.Resources.logo;
            this.pic_Picture.ImageLocation = "";
            this.pic_Picture.Location = new System.Drawing.Point(8, 5);
            this.pic_Picture.Name = "pic_Picture";
            this.pic_Picture.Size = new System.Drawing.Size(80, 75);
            this.pic_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Picture.TabIndex = 208;
            this.pic_Picture.TabStop = false;
            this.pic_Picture.Click += new System.EventHandler(this.Pic_Picture_Click);
            // 
            // pnl_Data
            // 
            this.pnl_Data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.pnl_Data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Data.Controls.Add(this.ddl_Status);
            this.pnl_Data.Controls.Add(this.txt_Description);
            this.pnl_Data.Controls.Add(this.txt_Title);
            this.pnl_Data.Controls.Add(this.pic_Picture);
            this.pnl_Data.Controls.Add(this.label6);
            this.pnl_Data.Controls.Add(this.label9);
            this.pnl_Data.Controls.Add(this.label1);
            this.pnl_Data.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Data.Enabled = false;
            this.pnl_Data.Location = new System.Drawing.Point(0, 27);
            this.pnl_Data.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_Data.Name = "pnl_Data";
            this.pnl_Data.Size = new System.Drawing.Size(780, 89);
            this.pnl_Data.TabIndex = 7;
            // 
            // ddl_Status
            // 
            this.ddl_Status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ddl_Status.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ddl_Status.Font = new System.Drawing.Font("Tornado Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            radListDataItem1.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            radListDataItem1.Text = "فعال";
            radListDataItem2.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            radListDataItem2.Text = "غیرفعال";
            this.ddl_Status.Items.Add(radListDataItem1);
            this.ddl_Status.Items.Add(radListDataItem2);
            this.ddl_Status.Location = new System.Drawing.Point(570, 41);
            this.ddl_Status.MaxDropDownItems = 10;
            this.ddl_Status.Name = "ddl_Status";
            this.ddl_Status.Size = new System.Drawing.Size(131, 19);
            this.ddl_Status.TabIndex = 211;
            this.ddl_Status.TextChanged += new System.EventHandler(this.Txt_Title_TextChanged);
            this.ddl_Status.SelectedValueChanged += new System.EventHandler(this.Txt_Title_TextChanged);
            // 
            // txt_Description
            // 
            this.txt_Description.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Description.BackColor = System.Drawing.Color.FloralWhite;
            this.txt_Description.Location = new System.Drawing.Point(146, 33);
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(353, 47);
            this.txt_Description.TabIndex = 210;
            this.txt_Description.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Description.TextChanged += new System.EventHandler(this.Txt_Title_TextChanged);
            // 
            // txt_Title
            // 
            this.txt_Title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Title.Font = new System.Drawing.Font("Tornado Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_Title.Location = new System.Drawing.Point(146, 8);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(555, 19);
            this.txt_Title.TabIndex = 209;
            this.txt_Title.TextChanged += new System.EventHandler(this.Txt_Title_TextChanged);
            this.txt_Title.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Title_KeyDown);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(718, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 14);
            this.label6.TabIndex = 131;
            this.label6.Text = "وضعیت";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(502, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 125;
            this.label9.Text = "توضیحات";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(727, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 123;
            this.label1.Text = "عنوان";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point(5, 4);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(76, 29);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "بستن";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancel.Enabled = false;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(624, 2);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(31, 31);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(654, 2);
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
            this.btnModify.Location = new System.Drawing.Point(684, 2);
            this.btnModify.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(31, 31);
            this.btnModify.TabIndex = 2;
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.BtnModify_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegister.BackColor = System.Drawing.Color.White;
            this.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRegister.Enabled = false;
            this.btnRegister.Image = ((System.Drawing.Image)(resources.GetObject("btnRegister.Image")));
            this.btnRegister.Location = new System.Drawing.Point(714, 2);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(31, 31);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // pnl_Action
            // 
            this.pnl_Action.AutoSize = true;
            this.pnl_Action.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.pnl_Action.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Action.Controls.Add(this.txt_Extenstion);
            this.pnl_Action.Controls.Add(this.btnClose);
            this.pnl_Action.Controls.Add(this.btnCancel);
            this.pnl_Action.Controls.Add(this.btnDelete);
            this.pnl_Action.Controls.Add(this.btnModify);
            this.pnl_Action.Controls.Add(this.btnRegister);
            this.pnl_Action.Controls.Add(this.btnInsert);
            this.pnl_Action.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Action.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.pnl_Action.Location = new System.Drawing.Point(0, 116);
            this.pnl_Action.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_Action.Name = "pnl_Action";
            this.pnl_Action.Size = new System.Drawing.Size(780, 39);
            this.pnl_Action.TabIndex = 6;
            // 
            // txt_Extenstion
            // 
            this.txt_Extenstion.Location = new System.Drawing.Point(155, 6);
            this.txt_Extenstion.Name = "txt_Extenstion";
            this.txt_Extenstion.ReadOnly = true;
            this.txt_Extenstion.Size = new System.Drawing.Size(87, 23);
            this.txt_Extenstion.TabIndex = 7;
            this.txt_Extenstion.Visible = false;
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsert.BackColor = System.Drawing.Color.White;
            this.btnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInsert.Image = ((System.Drawing.Image)(resources.GetObject("btnInsert.Image")));
            this.btnInsert.Location = new System.Drawing.Point(744, 2);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(31, 31);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // rgv_WeatherCondition
            // 
            this.rgv_WeatherCondition.AutoScroll = true;
            this.rgv_WeatherCondition.BackColor = System.Drawing.SystemColors.Control;
            this.rgv_WeatherCondition.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_WeatherCondition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rgv_WeatherCondition.EnableHotTracking = false;
            this.rgv_WeatherCondition.EnterKeyMode = Telerik.WinControls.UI.RadGridViewEnterKeyMode.EnterMovesToNextRow;
            this.rgv_WeatherCondition.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rgv_WeatherCondition.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgv_WeatherCondition.GroupExpandAnimationType = Telerik.WinControls.UI.GridExpandAnimationType.Slide;
            this.rgv_WeatherCondition.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_WeatherCondition.Location = new System.Drawing.Point(0, 155);
            this.rgv_WeatherCondition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // 
            // 
            this.rgv_WeatherCondition.MasterTemplate.AllowAddNewRow = false;
            this.rgv_WeatherCondition.MasterTemplate.AllowCellContextMenu = false;
            this.rgv_WeatherCondition.MasterTemplate.AllowDeleteRow = false;
            this.rgv_WeatherCondition.MasterTemplate.AllowEditRow = false;
            this.rgv_WeatherCondition.MasterTemplate.AllowRowResize = false;
            this.rgv_WeatherCondition.MasterTemplate.AutoExpandGroups = true;
            this.rgv_WeatherCondition.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "Id";
            gridViewTextBoxColumn1.HeaderText = "شناسه";
            gridViewTextBoxColumn1.Name = "Id";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn1.Width = 85;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Title";
            gridViewTextBoxColumn2.HeaderText = "عنوان";
            gridViewTextBoxColumn2.Name = "Title";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn2.Width = 159;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "PersianCreationDate";
            gridViewTextBoxColumn3.HeaderText = "تاریخ ثبت";
            gridViewTextBoxColumn3.Name = "PersianCreationDate";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn3.Width = 128;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "PersianLastUpdate";
            gridViewTextBoxColumn4.HeaderText = "تاریخ آخرین ویرایش";
            gridViewTextBoxColumn4.Name = "PersianLastUpdate";
            gridViewTextBoxColumn4.ReadOnly = true;
            gridViewTextBoxColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn4.Width = 118;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "CreationUser";
            gridViewTextBoxColumn5.HeaderText = "کاربر ثبت کننده";
            gridViewTextBoxColumn5.Name = "CreationUser";
            gridViewTextBoxColumn5.ReadOnly = true;
            gridViewTextBoxColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn5.Width = 105;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "Status";
            gridViewTextBoxColumn6.HeaderText = "وضعیت";
            gridViewTextBoxColumn6.Name = "Status";
            gridViewTextBoxColumn6.ReadOnly = true;
            gridViewTextBoxColumn6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn6.Width = 90;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "Description";
            gridViewTextBoxColumn7.HeaderText = "توضیحات";
            gridViewTextBoxColumn7.IsVisible = false;
            gridViewTextBoxColumn7.Name = "Description";
            gridViewTextBoxColumn7.ReadOnly = true;
            gridViewTextBoxColumn7.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn7.Width = 155;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "Picture";
            gridViewTextBoxColumn8.HeaderText = "تصویر شخص";
            gridViewTextBoxColumn8.IsVisible = false;
            gridViewTextBoxColumn8.Name = "Picture";
            gridViewTextBoxColumn8.ReadOnly = true;
            gridViewTextBoxColumn8.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.rgv_WeatherCondition.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8});
            this.rgv_WeatherCondition.MasterTemplate.EnableAlternatingRowColor = true;
            this.rgv_WeatherCondition.MasterTemplate.EnableFiltering = true;
            this.rgv_WeatherCondition.MasterTemplate.ReadOnly = true;
            this.rgv_WeatherCondition.MasterTemplate.ShowGroupedColumns = true;
            this.rgv_WeatherCondition.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgv_WeatherCondition.Name = "rgv_WeatherCondition";
            this.rgv_WeatherCondition.ReadOnly = true;
            this.rgv_WeatherCondition.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rgv_WeatherCondition.Size = new System.Drawing.Size(780, 405);
            this.rgv_WeatherCondition.TabIndex = 8;
            this.rgv_WeatherCondition.CurrentRowChanged += new Telerik.WinControls.UI.CurrentRowChangedEventHandler(this.Rgv_WeatherCondition_CurrentRowChanged);
            this.rgv_WeatherCondition.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.Rgv_WeatherCondition_CellClick);
            // 
            // FrmWeatherCondition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 560);
            this.Controls.Add(this.rgv_WeatherCondition);
            this.Controls.Add(this.pnl_Action);
            this.Controls.Add(this.pnl_Data);
            this.Font = new System.Drawing.Font("Tornado Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "FrmWeatherCondition";
            this.Text = "شرایط آب و هوا";
            this.Controls.SetChildIndex(this.pnl_Data, 0);
            this.Controls.SetChildIndex(this.pnl_Action, 0);
            this.Controls.SetChildIndex(this.rgv_WeatherCondition, 0);
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Picture)).EndInit();
            this.pnl_Data.ResumeLayout(false);
            this.pnl_Data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddl_Status)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Description)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Title)).EndInit();
            this.pnl_Action.ResumeLayout(false);
            this.pnl_Action.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_WeatherCondition.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_WeatherCondition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Picture;
        private System.Windows.Forms.Panel pnl_Data;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Panel pnl_Action;
        private System.Windows.Forms.Button btnInsert;
        private Telerik.WinControls.UI.RadGridView rgv_WeatherCondition;
        private System.Windows.Forms.TextBox txt_Extenstion;
        private Telerik.WinControls.UI.RadTextBox txt_Title;
        private Telerik.WinControls.UI.RadTextBoxControl txt_Description;
        private Telerik.WinControls.UI.RadDropDownList ddl_Status;
    }
}