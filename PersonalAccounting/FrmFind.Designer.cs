namespace PersonalAccounting.UI
{
    partial class FrmFind
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
            this.chkWholeWord = new System.Windows.Forms.CheckBox();
            this.chkMatchCase = new System.Windows.Forms.CheckBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnFindNext = new System.Windows.Forms.Button();
            this.txtSearchText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkWholeWord
            // 
            this.chkWholeWord.AutoSize = true;
            this.chkWholeWord.Location = new System.Drawing.Point(265, 103);
            this.chkWholeWord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkWholeWord.Name = "chkWholeWord";
            this.chkWholeWord.Size = new System.Drawing.Size(69, 18);
            this.chkWholeWord.TabIndex = 9;
            this.chkWholeWord.Text = "کل کلمه";
            this.chkWholeWord.UseVisualStyleBackColor = true;
            // 
            // chkMatchCase
            // 
            this.chkMatchCase.AutoSize = true;
            this.chkMatchCase.Location = new System.Drawing.Point(200, 76);
            this.chkMatchCase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkMatchCase.Name = "chkMatchCase";
            this.chkMatchCase.Size = new System.Drawing.Size(134, 18);
            this.chkMatchCase.TabIndex = 8;
            this.chkMatchCase.Text = "تطبیق با مورد جستجو";
            this.chkMatchCase.UseVisualStyleBackColor = true;
            // 
            // btnDone
            // 
            this.btnDone.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDone.Location = new System.Drawing.Point(32, 103);
            this.btnDone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(108, 24);
            this.btnDone.TabIndex = 11;
            this.btnDone.Text = "بستن";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.BtnDone_Click);
            // 
            // btnFindNext
            // 
            this.btnFindNext.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFindNext.Location = new System.Drawing.Point(32, 71);
            this.btnFindNext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFindNext.Name = "btnFindNext";
            this.btnFindNext.Size = new System.Drawing.Size(108, 24);
            this.btnFindNext.TabIndex = 10;
            this.btnFindNext.Text = "جستجوی بعدی";
            this.btnFindNext.UseVisualStyleBackColor = true;
            this.btnFindNext.Click += new System.EventHandler(this.BtnFindNext_Click);
            // 
            // txtSearchText
            // 
            this.txtSearchText.Location = new System.Drawing.Point(32, 21);
            this.txtSearchText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchText.Name = "txtSearchText";
            this.txtSearchText.Size = new System.Drawing.Size(212, 22);
            this.txtSearchText.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "جستجوی متن:";
            // 
            // FrmFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 151);
            this.Controls.Add(this.chkWholeWord);
            this.Controls.Add(this.chkMatchCase);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnFindNext);
            this.Controls.Add(this.txtSearchText);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tornado Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFind";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "جستجوی متن";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmFind_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkWholeWord;
        private System.Windows.Forms.CheckBox chkMatchCase;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnFindNext;
        private System.Windows.Forms.TextBox txtSearchText;
        private System.Windows.Forms.Label label1;
    }
}