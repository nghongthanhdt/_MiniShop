namespace TH.Core
{
    partial class Form1
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
            this.btnMiniShop = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnMiniShop
            // 
            this.btnMiniShop.Location = new System.Drawing.Point(210, 85);
            this.btnMiniShop.Name = "btnMiniShop";
            this.btnMiniShop.Size = new System.Drawing.Size(179, 44);
            this.btnMiniShop.TabIndex = 0;
            this.btnMiniShop.Text = "MiniShop";
            this.btnMiniShop.Click += new System.EventHandler(this.btnMiniShop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 278);
            this.Controls.Add(this.btnMiniShop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnMiniShop;
    }
}

