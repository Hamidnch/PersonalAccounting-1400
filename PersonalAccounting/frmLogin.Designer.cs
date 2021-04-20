namespace PersonalAccounting.UI
{
    partial class FrmLogin
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
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.pnl_Data = new Klik.Windows.Forms.v1.EntryLib.ELPanel();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pic_Login = new System.Windows.Forms.PictureBox();
            this.btn_Enter = new VistaButton.VistaButton();
            this.btn_Exit = new VistaButton.VistaButton();
            this.elEntryBoxButton1 = new Klik.Windows.Forms.v1.EntryLib.ELEntryBoxButton();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_Data)).BeginInit();
            this.pnl_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Login)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Data
            // 
            this.pnl_Data.BackgroundStyle.GradientAngle = 45F;
            this.pnl_Data.BackgroundStyle.GradientEndColor = System.Drawing.Color.LightSteelBlue;
            this.pnl_Data.BackgroundStyle.GradientStartColor = System.Drawing.Color.White;
            this.pnl_Data.Controls.Add(this.txt_Password);
            this.pnl_Data.Controls.Add(this.txt_UserName);
            this.pnl_Data.Controls.Add(this.label3);
            this.pnl_Data.Controls.Add(this.label2);
            this.pnl_Data.Controls.Add(this.label1);
            this.pnl_Data.Controls.Add(this.pic_Login);
            this.pnl_Data.Controls.Add(this.btn_Enter);
            this.pnl_Data.Controls.Add(this.btn_Exit);
            this.pnl_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Data.Location = new System.Drawing.Point(0, 0);
            this.pnl_Data.Name = "pnl_Data";
            this.pnl_Data.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernSilver;
            this.pnl_Data.Size = new System.Drawing.Size(373, 172);
            this.pnl_Data.TabIndex = 3;
            this.pnl_Data.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom;
            // 
            // txt_Password
            // 
            this.txt_Password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Password.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_Password.Location = new System.Drawing.Point(101, 71);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(187, 26);
            this.txt_Password.TabIndex = 1;
            this.txt_Password.Text = "Element**";
            this.txt_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // txt_UserName
            // 
            this.txt_UserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_UserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_UserName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_UserName.Location = new System.Drawing.Point(101, 30);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(187, 26);
            this.txt_UserName.TabIndex = 0;
            this.txt_UserName.Text = "Admin";
            this.txt_UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(11, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(354, 2);
            this.label3.TabIndex = 23;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(303, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "کلمه عبور";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(303, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "نام کاربری";
            // 
            // pic_Login
            // 
            this.pic_Login.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_Login.BackColor = System.Drawing.Color.Transparent;
            this.pic_Login.Image = ((System.Drawing.Image)(resources.GetObject("pic_Login.Image")));
            this.pic_Login.Location = new System.Drawing.Point(11, 18);
            this.pic_Login.Name = "pic_Login";
            this.pic_Login.Size = new System.Drawing.Size(78, 75);
            this.pic_Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Login.TabIndex = 6;
            this.pic_Login.TabStop = false;
            // 
            // btn_Enter
            // 
            this.btn_Enter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Enter.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Enter.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Enter.ButtonColor = System.Drawing.SystemColors.MenuText;
            this.btn_Enter.ButtonText = "ورود";
            this.btn_Enter.CornerRadius = 2;
            this.btn_Enter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Enter.GlowColor = System.Drawing.Color.DarkViolet;
            this.btn_Enter.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Enter.Image = ((System.Drawing.Image)(resources.GetObject("btn_Enter.Image")));
            this.btn_Enter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Enter.Location = new System.Drawing.Point(286, 132);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(82, 32);
            this.btn_Enter.TabIndex = 2;
            this.btn_Enter.Click += new System.EventHandler(this.btn_Enter_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Exit.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Exit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Exit.ButtonColor = System.Drawing.SystemColors.MenuText;
            this.btn_Exit.ButtonText = "خروج";
            this.btn_Exit.CornerRadius = 2;
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.GlowColor = System.Drawing.Color.DarkViolet;
            this.btn_Exit.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Exit.Location = new System.Drawing.Point(202, 132);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(82, 32);
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // elEntryBoxButton1
            // 
            this.elEntryBoxButton1.BackgroundStyle.GradientAngle = 45F;
            this.elEntryBoxButton1.Text = "(F4)...";
            this.elEntryBoxButton1.TextStyle.Text = "(F4)...";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 172);
            this.Controls.Add(this.pnl_Data);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرم ورود به سیستم";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLogin_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pnl_Data)).EndInit();
            this.pnl_Data.ResumeLayout(false);
            this.pnl_Data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Login)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Klik.Windows.Forms.v1.EntryLib.ELPanel pnl_Data;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic_Login;
        private VistaButton.VistaButton btn_Enter;
        private VistaButton.VistaButton btn_Exit;
        private Klik.Windows.Forms.v1.EntryLib.ELEntryBoxButton elEntryBoxButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_UserName;
    }
}

