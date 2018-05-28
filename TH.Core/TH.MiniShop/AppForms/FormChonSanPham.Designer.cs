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
            this.txtKho = new System.Windows.Forms.TextBox();
            this.txtLoaiPhieu = new System.Windows.Forms.TextBox();
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
            this.gcSanPham.Click += new System.EventHandler(this.gcSanPham_Click);
            this.gcSanPham.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gcSanPham_MouseDoubleClick);
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
            this.colMaSanPham.FieldName = "SanPham.MaSanPham";
            this.colMaSanPham.Name = "colMaSanPham";
            this.colMaSanPham.Width = 152;
            // 
            // colTenSanPham
            // 
            this.colTenSanPham.Caption = "Tên sản phẩm";
            this.colTenSanPham.FieldName = "SanPham.TenSanPham";
            this.colTenSanPham.Name = "colTenSanPham";
            this.colTenSanPham.Visible = true;
            this.colTenSanPham.VisibleIndex = 1;
            this.colTenSanPham.Width = 132;
            // 
            // colTonKho
            // 
            this.colTonKho.Caption = "Tồn kho";
            this.colTonKho.DisplayFormat.FormatString = "{0:#,#}";
            this.colTonKho.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colTonKho.FieldName = "SoLuongTon";
            this.colTonKho.Name = "colTonKho";
            this.colTonKho.Visible = true;
            this.colTonKho.VisibleIndex = 6;
            this.colTonKho.Width = 93;
            // 
            // colGiaNhap
            // 
            this.colGiaNhap.Caption = "Giá nhập";
            this.colGiaNhap.DisplayFormat.FormatString = "{0:#,#}";
            this.colGiaNhap.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colGiaNhap.FieldName = "SanPham.GiaNhap";
            this.colGiaNhap.Name = "colGiaNhap";
            this.colGiaNhap.Visible = true;
            this.colGiaNhap.VisibleIndex = 3;
            this.colGiaNhap.Width = 101;
            // 
            // colGiaSi
            // 
            this.colGiaSi.Caption = "Giá bán sỉ";
            this.colGiaSi.DisplayFormat.FormatString = "{0:#,#}";
            this.colGiaSi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colGiaSi.FieldName = "SanPham.GiaXuatBanSi";
            this.colGiaSi.Name = "colGiaSi";
            this.colGiaSi.Visible = true;
            this.colGiaSi.VisibleIndex = 5;
            // 
            // colGiaLe
            // 
            this.colGiaLe.Caption = "Giá bán lẻ";
            this.colGiaLe.DisplayFormat.FormatString = "{0:#,#}";
            this.colGiaLe.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colGiaLe.FieldName = "SanPham.GiaXuatBanLe";
            this.colGiaLe.Name = "colGiaLe";
            this.colGiaLe.Visible = true;
            this.colGiaLe.VisibleIndex = 4;
            // 
            // colDonViTinh
            // 
            this.colDonViTinh.Caption = "Đơn vị";
            this.colDonViTinh.FieldName = "SanPham.DonViTinh";
            this.colDonViTinh.Name = "colDonViTinh";
            this.colDonViTinh.Visible = true;
            this.colDonViTinh.VisibleIndex = 2;
            this.colDonViTinh.Width = 89;
            // 
            // colKyHieu
            // 
            this.colKyHieu.Caption = "Mã SP";
            this.colKyHieu.FieldName = "SanPham.KyHieu";
            this.colKyHieu.Name = "colKyHieu";
            this.colKyHieu.Visible = true;
            this.colKyHieu.VisibleIndex = 0;
            this.colKyHieu.Width = 64;
            // 
            // colTenLoaiSanPham
            // 
            this.colTenLoaiSanPham.Caption = "Loại";
            this.colTenLoaiSanPham.FieldName = "SanPham.LoaiSanPham.TenLoaiSanPham";
            this.colTenLoaiSanPham.Name = "colTenLoaiSanPham";
            this.colTenLoaiSanPham.Visible = true;
            this.colTenLoaiSanPham.VisibleIndex = 1;
            // 
            // colMaLoaiSanPham
            // 
            this.colMaLoaiSanPham.Caption = "Mã loại sản phẩm";
            this.colMaLoaiSanPham.FieldName = "SanPham.LoaiSanPham.MaLoaiSanPham";
            this.colMaLoaiSanPham.Name = "colMaLoaiSanPham";
            // 
            // btnChon
            // 
            this.btnChon.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnChon.Appearance.Options.UseFont = true;
            this.btnChon.Image = ((System.Drawing.Image)(resources.GetObject("btnChon.Image")));
            this.btnChon.Location = new System.Drawing.Point(201, 401);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(126, 27);
            this.btnChon.TabIndex = 3;
            this.btnChon.Text = "Đồng ý";
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnDong
            // 
            this.btnDong.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.Location = new System.Drawing.Point(333, 401);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(126, 27);
            this.btnDong.TabIndex = 3;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // txtKho
            // 
            this.txtKho.Enabled = false;
            this.txtKho.Location = new System.Drawing.Point(124, 9);
            this.txtKho.Name = "txtKho";
            this.txtKho.Size = new System.Drawing.Size(147, 21);
            this.txtKho.TabIndex = 5;
            // 
            // txtLoaiPhieu
            // 
            this.txtLoaiPhieu.Enabled = false;
            this.txtLoaiPhieu.Location = new System.Drawing.Point(13, 9);
            this.txtLoaiPhieu.Name = "txtLoaiPhieu";
            this.txtLoaiPhieu.Size = new System.Drawing.Size(105, 21);
            this.txtLoaiPhieu.TabIndex = 5;
            // 
            // FormChonSanPham
            // 
            this.AcceptButton = this.btnChon;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnDong;
            this.ClientSize = new System.Drawing.Size(685, 440);
            this.ControlBox = false;
            this.Controls.Add(this.txtLoaiPhieu);
            this.Controls.Add(this.txtKho);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.gcSanPham);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormChonSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn sản phẩm";
            this.Load += new System.EventHandler(this.FormChonSanPham_Load);
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
        public System.Windows.Forms.TextBox txtKho;
        public System.Windows.Forms.TextBox txtLoaiPhieu;
    }
}