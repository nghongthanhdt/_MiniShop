namespace TH.Core
{
    partial class FormMain
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
            this.btnCauHinhKetNoi = new DevExpress.XtraEditors.SimpleButton();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCauHinhKetNoi
            // 
            this.btnCauHinhKetNoi.Location = new System.Drawing.Point(15, 25);
            this.btnCauHinhKetNoi.Name = "btnCauHinhKetNoi";
            this.btnCauHinhKetNoi.Size = new System.Drawing.Size(172, 36);
            this.btnCauHinhKetNoi.TabIndex = 0;
            this.btnCauHinhKetNoi.Text = "Cấu hình";
            this.btnCauHinhKetNoi.Click += new System.EventHandler(this.btnCauHinhKetNoi_Click);
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.Location = new System.Drawing.Point(12, 9);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(132, 13);
            this.lblThongBao.TabIndex = 1;
            this.lblThongBao.Text = "Chưa kết nối đến máy chủ";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 276);
            this.Controls.Add(this.lblThongBao);
            this.Controls.Add(this.btnCauHinhKetNoi);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCauHinhKetNoi;
        private System.Windows.Forms.Label lblThongBao;
    }
}