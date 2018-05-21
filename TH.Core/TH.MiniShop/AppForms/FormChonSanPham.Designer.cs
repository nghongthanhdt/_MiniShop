namespace TH.MiniShop.AppForms
{
    partial class FormChonSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChonSanPham));
            this.gcSanPham = new DevExpress.XtraGrid.GridControl();
            this.gvSanPham = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTonKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiaNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiaSi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiaLe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKyHieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenLoaiSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaLoaiSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnChon = new DevExpress.XtraEditors.SimpleButton();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKho = new System.Windows.Forms.TextBox();
            this.txtMaKho = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gcSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // gcSanPham
            // 
            this.gcSanPham.Location = new System.Drawing.Point(13, 36);
            this.gcSanPham.MainView = this.gvSanPham;
            this.gcSanPham.Name = "gcSanPham";
            this.gcSanPham.Size = new System.Drawing.Size(660, 359);
            this.gcSanPham.TabIndex = 2;
            this.gcSanPham.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSanPham});
            // 
            // gvSanPham
            // 
            this.gvSanPham.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaSanPham,
            this.colTenSanPham,
            this.colTonKho,
            this.colGiaNhap,
            this.colGiaSi,
            this.colGiaLe,
            this.colDonViTinh,
            this.colKyHieu,
            this.colTenLoaiSanPham,
            this.colMaLoaiSanPham});
            this.gvSanPham.GridControl = this.gcSanPham;
            this.gvSanPham.GroupCount = 1;
            this.gvSanPham.Name = "gvSanPham";
            this.gvSanPham.OptionsBehavior.AutoExpandAllGroups = true;
            this.gvSanPham.OptionsBehavior.Editable = false;
            this.gvSanPham.OptionsBehavior.ReadOnly = true;
            this.gvSanPham.OptionsView.ShowAutoFilterRow = true;
            this.gvSanPham.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTenLoaiSanPham, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colMaSanPham
            // 
            this.colMaSanPham.Caption = "Mã loại";
            this.colMaSanPham.FieldName = "MaSanPham";
            this.colMaSanPham.Name = "colMaSanPham";
            this.colMaSanPham.Width = 152;
            // 
            // colTenSanPham
            // 
            this.colTenSanPham.Caption = "Tên sản phẩm";
            this.colTenSanPham.FieldName = "TenSanPham";
            this.colTenSanPham.Name = "colTenSanPham";
            this.colTenSanPham.Visible = true;
            this.colTenSanPham.VisibleIndex = 1;
            this.colTenSanPham.Width = 132;
            // 
            // colTonKho
            // 
            this.colTonKho.Caption = "Tồn kho";
            this.colTonKho.Name = "colTonKho";
            this.colTonKho.Visible = true;
            this.colTonKho.VisibleIndex = 6;
            this.colTonKho.Width = 93;
            // 
            // colGiaNhap
            // 
            this.colGiaNhap.Caption = "Giá nhập";
            this.colGiaNhap.Name = "colGiaNhap";
            this.colGiaNhap.Visible = true;
            this.colGiaNhap.VisibleIndex = 3;
            this.colGiaNhap.Width = 101;
            // 
            // colGiaSi
            // 
            this.colGiaSi.Caption = "Giá bán sỉ";
            this.colGiaSi.Name = "colGiaSi";
            this.colGiaSi.Visible = true;
            this.colGiaSi.VisibleIndex = 5;
            // 
            // colGiaLe
            // 
            this.colGiaLe.Caption = "Giá bán lẻ";
            this.colGiaLe.Name = "colGiaLe";
            this.colGiaLe.Visible = true;
            this.colGiaLe.VisibleIndex = 4;
            // 
            // colDonViTinh
            // 
            this.colDonViTinh.Caption = "Đơn vị";
            this.colDonViTinh.FieldName = "DonViTinh";
            this.colDonViTinh.Name = "colDonViTinh";
            this.colDonViTinh.Visible = true;
            this.colDonViTinh.VisibleIndex = 2;
            this.colDonViTinh.Width = 89;
            // 
            // colKyHieu
            // 
            this.colKyHieu.Caption = "Mã SP";
            this.colKyHieu.FieldName = "KyHieu";
            this.colKyHieu.Name = "colKyHieu";
            this.colKyHieu.Visible = true;
            this.colKyHieu.VisibleIndex = 0;
            this.colKyHieu.Width = 64;
            // 
            // colTenLoaiSanPham
            // 
            this.colTenLoaiSanPham.Caption = "Loại";
            this.colTenLoaiSanPham.FieldName = "LoaiSanPham.TenLoaiSanPham";
            this.colTenLoaiSanPham.Name = "colTenLoaiSanPham";
            this.colTenLoaiSanPham.Visible = true;
            this.colTenLoaiSanPham.VisibleIndex = 1;
            // 
            // colMaLoaiSanPham
            // 
            this.colMaLoaiSanPham.Caption = "Mã loại sản phẩm";
            this.colMaLoaiSanPham.FieldName = "LoaiSanPham.MaLoaiSanPham";
            this.colMaLoaiSanPham.Name = "colMaLoaiSanPham";
            // 
            // btnChon
            // 
            this.btnChon.Image = ((System.Drawing.Image)(resources.GetObject("btnChon.Image")));
            this.btnChon.Location = new System.Drawing.Point(13, 401);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(126, 27);
            this.btnChon.TabIndex = 3;
            this.btnChon.Text = "Đồng ý";
            // 
            // btnDong
            // 
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.Location = new System.Drawing.Point(145, 401);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(126, 27);
            this.btnDong.TabIndex = 3;
            this.btnDong.Text = "Bỏ qua";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kho:";
            // 
            // txtKho
            // 
            this.txtKho.Location = new System.Drawing.Point(48, 10);
            this.txtKho.Name = "txtKho";
            this.txtKho.Size = new System.Drawing.Size(175, 21);
            this.txtKho.TabIndex = 5;
            // 
            // txtMaKho
            // 
            this.txtMaKho.Location = new System.Drawing.Point(229, 10);
            this.txtMaKho.Name = "txtMaKho";
            this.txtMaKho.Size = new System.Drawing.Size(42, 21);
            this.txtMaKho.TabIndex = 6;
            this.txtMaKho.Visible = false;
            // 
            // FormChonSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 440);
            this.Controls.Add(this.txtMaKho);
            this.Controls.Add(this.txtKho);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.gcSanPham);
            this.Name = "FormChonSanPham";
            this.Text = "ChonSanPham";
            ((System.ComponentModel.ISupportInitialize)(this.gcSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcSanPham;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn colMaSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn colTenSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn colTonKho;
        private DevExpress.XtraGrid.Columns.GridColumn colGiaNhap;
        private DevExpress.XtraGrid.Columns.GridColumn colDonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn colKyHieu;
        private DevExpress.XtraGrid.Columns.GridColumn colTenLoaiSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn colMaLoaiSanPham;
        private DevExpress.XtraEditors.SimpleButton btnChon;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraGrid.Columns.GridColumn colGiaSi;
        private DevExpress.XtraGrid.Columns.GridColumn colGiaLe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKho;
        private System.Windows.Forms.TextBox txtMaKho;
    }
}