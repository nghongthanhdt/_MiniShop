namespace TH.InSTTKB
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.lblTenBenhVien = new DevExpress.XtraEditors.LabelControl();
            this.gcSTT = new DevExpress.XtraGrid.GridControl();
            this.gvSTT = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNutBam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoaiKham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoHienTai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayGioIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnCauHinh = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.txtThoiGian = new System.Windows.Forms.TextBox();
            this.txtNutNhap = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gcSTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSTT)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTenBenhVien
            // 
            this.lblTenBenhVien.Appearance.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lblTenBenhVien.Appearance.Options.UseFont = true;
            this.lblTenBenhVien.Location = new System.Drawing.Point(12, 12);
            this.lblTenBenhVien.Name = "lblTenBenhVien";
            this.lblTenBenhVien.Size = new System.Drawing.Size(463, 23);
            this.lblTenBenhVien.TabIndex = 0;
            this.lblTenBenhVien.Text = "BỆNH VIỆN PHỤC HỒI CHỨC NĂNG ĐỒNG THÁP";
            this.lblTenBenhVien.Click += new System.EventHandler(this.lblTenBenhVien_Click);
            // 
            // gcSTT
            // 
            this.gcSTT.Location = new System.Drawing.Point(12, 84);
            this.gcSTT.MainView = this.gvSTT;
            this.gcSTT.Name = "gcSTT";
            this.gcSTT.Size = new System.Drawing.Size(691, 236);
            this.gcSTT.TabIndex = 1;
            this.gcSTT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSTT});
            // 
            // gvSTT
            // 
            this.gvSTT.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNutBam,
            this.colLoaiKham,
            this.colSoHienTai,
            this.colNgayGioIn});
            this.gvSTT.GridControl = this.gcSTT;
            this.gvSTT.Name = "gvSTT";
            this.gvSTT.OptionsBehavior.Editable = false;
            this.gvSTT.OptionsBehavior.KeepGroupExpandedOnSorting = false;
            this.gvSTT.OptionsBehavior.ReadOnly = true;
            this.gvSTT.OptionsCustomization.AllowSort = false;
            this.gvSTT.OptionsView.ShowGroupPanel = false;
            // 
            // colNutBam
            // 
            this.colNutBam.Caption = "Nút bấm";
            this.colNutBam.FieldName = "Nut";
            this.colNutBam.Name = "colNutBam";
            this.colNutBam.Visible = true;
            this.colNutBam.VisibleIndex = 0;
            this.colNutBam.Width = 68;
            // 
            // colLoaiKham
            // 
            this.colLoaiKham.Caption = "Loại khám";
            this.colLoaiKham.FieldName = "TenNut";
            this.colLoaiKham.Name = "colLoaiKham";
            this.colLoaiKham.Visible = true;
            this.colLoaiKham.VisibleIndex = 1;
            this.colLoaiKham.Width = 159;
            // 
            // colSoHienTai
            // 
            this.colSoHienTai.Caption = "Số hiện tại";
            this.colSoHienTai.FieldName = "SoHienTai";
            this.colSoHienTai.Name = "colSoHienTai";
            this.colSoHienTai.Visible = true;
            this.colSoHienTai.VisibleIndex = 2;
            this.colSoHienTai.Width = 73;
            // 
            // colNgayGioIn
            // 
            this.colNgayGioIn.Caption = "Ngày giờ in";
            this.colNgayGioIn.FieldName = "NgayGioIn";
            this.colNgayGioIn.Name = "colNgayGioIn";
            this.colNgayGioIn.Visible = true;
            this.colNgayGioIn.VisibleIndex = 3;
            this.colNgayGioIn.Width = 145;
            // 
            // btnCauHinh
            // 
            this.btnCauHinh.Image = ((System.Drawing.Image)(resources.GetObject("btnCauHinh.Image")));
            this.btnCauHinh.Location = new System.Drawing.Point(12, 49);
            this.btnCauHinh.Name = "btnCauHinh";
            this.btnCauHinh.Size = new System.Drawing.Size(79, 29);
            this.btnCauHinh.TabIndex = 4;
            this.btnCauHinh.Text = "Cấu hình";
            this.btnCauHinh.Click += new System.EventHandler(this.btnCauHinh_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.Location = new System.Drawing.Point(627, 49);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(76, 29);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // timerMain
            // 
            this.timerMain.Enabled = true;
            this.timerMain.Interval = 1000;
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // txtThoiGian
            // 
            this.txtThoiGian.Enabled = false;
            this.txtThoiGian.Location = new System.Drawing.Point(140, 54);
            this.txtThoiGian.Name = "txtThoiGian";
            this.txtThoiGian.Size = new System.Drawing.Size(181, 21);
            this.txtThoiGian.TabIndex = 7;
            // 
            // txtNutNhap
            // 
            this.txtNutNhap.Location = new System.Drawing.Point(98, 54);
            this.txtNutNhap.Name = "txtNutNhap";
            this.txtNutNhap.Size = new System.Drawing.Size(36, 21);
            this.txtNutNhap.TabIndex = 8;
            this.txtNutNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNutNhap.TextChanged += new System.EventHandler(this.txtNutNhap_TextChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 332);
            this.ControlBox = false;
            this.Controls.Add(this.txtNutNhap);
            this.Controls.Add(this.txtThoiGian);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnCauHinh);
            this.Controls.Add(this.gcSTT);
            this.Controls.Add(this.lblTenBenhVien);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm bắt số thứ tự";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormMain_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.gcSTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSTT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblTenBenhVien;
        private DevExpress.XtraGrid.GridControl gcSTT;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colNutBam;
        private DevExpress.XtraGrid.Columns.GridColumn colLoaiKham;
        private DevExpress.XtraGrid.Columns.GridColumn colSoHienTai;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayGioIn;
        private DevExpress.XtraEditors.SimpleButton btnCauHinh;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.TextBox txtThoiGian;
        private System.Windows.Forms.TextBox txtNutNhap;
    }
}

