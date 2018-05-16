namespace TH.InSTTVLTL
{
    partial class FormCauHinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCauHinh));
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenBenhVien = new System.Windows.Forms.TextBox();
            this.gcVLTL = new DevExpress.XtraGrid.GridControl();
            this.gvVLTL = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenVLTL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSTT = new System.Windows.Forms.TextBox();
            this.btnThemMoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuuCauHinh = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuuVLTL = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenVLTL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gcVLTL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVLTL)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên bệnh viện:";
            // 
            // txtTenBenhVien
            // 
            this.txtTenBenhVien.Location = new System.Drawing.Point(121, 10);
            this.txtTenBenhVien.Name = "txtTenBenhVien";
            this.txtTenBenhVien.Size = new System.Drawing.Size(316, 20);
            this.txtTenBenhVien.TabIndex = 1;
            // 
            // gcVLTL
            // 
            this.gcVLTL.Location = new System.Drawing.Point(16, 45);
            this.gcVLTL.MainView = this.gvVLTL;
            this.gcVLTL.Name = "gcVLTL";
            this.gcVLTL.Size = new System.Drawing.Size(493, 200);
            this.gcVLTL.TabIndex = 2;
            this.gcVLTL.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvVLTL});
            // 
            // gvVLTL
            // 
            this.gvVLTL.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colSTT,
            this.colTenVLTL});
            this.gvVLTL.GridControl = this.gcVLTL;
            this.gvVLTL.Name = "gvVLTL";
            this.gvVLTL.OptionsBehavior.Editable = false;
            this.gvVLTL.OptionsBehavior.ReadOnly = true;
            this.gvVLTL.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gvVLTL.OptionsView.ShowGroupPanel = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên VLTL:";
            // 
            // txtTenVLTL
            // 
            this.txtTenVLTL.Location = new System.Drawing.Point(77, 251);
            this.txtTenVLTL.Name = "txtTenVLTL";
            this.txtTenVLTL.Size = new System.Drawing.Size(432, 20);
            this.txtTenVLTL.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "STT:";
            // 
            // txtSTT
            // 
            this.txtSTT.Location = new System.Drawing.Point(77, 277);
            this.txtSTT.Name = "txtSTT";
            this.txtSTT.Size = new System.Drawing.Size(86, 20);
            this.txtSTT.TabIndex = 1;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnThemMoi.Image")));
            this.btnThemMoi.Location = new System.Drawing.Point(169, 275);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(71, 23);
            this.btnThemMoi.TabIndex = 3;
            this.btnThemMoi.Text = "Mới";
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnLuuCauHinh
            // 
            this.btnLuuCauHinh.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnLuuCauHinh.Appearance.Options.UseFont = true;
            this.btnLuuCauHinh.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuCauHinh.Image")));
            this.btnLuuCauHinh.Location = new System.Drawing.Point(16, 313);
            this.btnLuuCauHinh.Name = "btnLuuCauHinh";
            this.btnLuuCauHinh.Size = new System.Drawing.Size(493, 36);
            this.btnLuuCauHinh.TabIndex = 4;
            this.btnLuuCauHinh.Text = "Lưu cấu hình";
            // 
            // btnLuuVLTL
            // 
            this.btnLuuVLTL.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuVLTL.Image")));
            this.btnLuuVLTL.Location = new System.Drawing.Point(246, 275);
            this.btnLuuVLTL.Name = "btnLuuVLTL";
            this.btnLuuVLTL.Size = new System.Drawing.Size(110, 23);
            this.btnLuuVLTL.TabIndex = 3;
            this.btnLuuVLTL.Text = "Lưu VLTL";
            this.btnLuuVLTL.Click += new System.EventHandler(this.btnLuuVLTL_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(362, 274);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(88, 23);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.Name = "colID";
            // 
            // colSTT
            // 
            this.colSTT.Caption = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 0;
            this.colSTT.Width = 89;
            // 
            // colTenVLTL
            // 
            this.colTenVLTL.Caption = "TênVLTL";
            this.colTenVLTL.Name = "colTenVLTL";
            this.colTenVLTL.Visible = true;
            this.colTenVLTL.VisibleIndex = 1;
            this.colTenVLTL.Width = 607;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(444, 10);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(65, 20);
            this.txtID.TabIndex = 5;
            // 
            // FormCauHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 371);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnLuuCauHinh);
            this.Controls.Add(this.btnLuuVLTL);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.gcVLTL);
            this.Controls.Add(this.txtSTT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenVLTL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenBenhVien);
            this.Controls.Add(this.label1);
            this.Name = "FormCauHinh";
            this.Text = "FormCauHinh";
            this.Load += new System.EventHandler(this.FormCauHinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcVLTL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVLTL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenBenhVien;
        private DevExpress.XtraGrid.GridControl gcVLTL;
        private DevExpress.XtraGrid.Views.Grid.GridView gvVLTL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenVLTL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSTT;
        private DevExpress.XtraEditors.SimpleButton btnThemMoi;
        private DevExpress.XtraEditors.SimpleButton btnLuuCauHinh;
        private DevExpress.XtraEditors.SimpleButton btnLuuVLTL;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colTenVLTL;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private System.Windows.Forms.TextBox txtID;
    }
}