
using System.Windows.Forms;

namespace PersonalAccounting.UI.UserControl
{
    partial class RichTextBoxAdv
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.richTextBoxZ = new PersonalAccounting.UI.UserControl.RichTextBoxZ();
            this.SuspendLayout();
            // 
            // richTextBox
            // 
            this.richTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox.Cursor = System.Windows.Forms.Cursors.PanNE;
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.richTextBox.Location = new System.Drawing.Point(222, 0);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.richTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox.Size = new System.Drawing.Size(30, 174);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            this.richTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LineNumberTextBox_MouseDown);
            // 
            // richTextBoxZ
            // 
            this.richTextBoxZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxZ.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxZ.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxZ.Name = "richTextBoxZ";
            this.richTextBoxZ.Size = new System.Drawing.Size(222, 174);
            this.richTextBoxZ.TabIndex = 1;
            this.richTextBoxZ.Text = "";
            this.richTextBoxZ.SelectionChanged += new System.EventHandler(this.RichTextBoxZ_SelectionChanged);
            this.richTextBoxZ.VScroll += new System.EventHandler(this.RichTextBoxZ_VScroll);
            this.richTextBoxZ.FontChanged += new System.EventHandler(this.RichTextBoxZ_FontChanged);
            this.richTextBoxZ.TextChanged += new System.EventHandler(this.RichTextBoxZ_TextChanged);
            // 
            // RichTextBoxAdv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richTextBoxZ);
            this.Controls.Add(this.richTextBox);
            this.Name = "RichTextBoxAdv";
            this.Size = new System.Drawing.Size(252, 174);
            this.Load += new System.EventHandler(this.RichTextBoxAdv_Load);
            this.Resize += new System.EventHandler(this.RichTextBoxAdv_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox richTextBox;
        public RichTextBoxZ richTextBoxZ;
    }
}
