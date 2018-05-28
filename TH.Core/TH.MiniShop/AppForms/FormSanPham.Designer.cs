namespace TH.MiniShop.AppForms
{
    partial class FormSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSanPham));
            this.gcSanPham = new DevExpress.XtraGrid.GridControl();
            this.gvSanPham = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuongBaoDong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuongToiThieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKyHieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenLoaiSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaLoaiSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.spinGiaXuatBanSi = new DevExpress.XtraEditors.SpinEdit();
            this.spinGiaXuatBanLe = new DevExpress.XtraEditors.SpinEdit();
            this.spinGiaNhap = new DevExpress.XtraEditors.SpinEdit();
            this.txtKyHieu = new DevExpress.XtraEditors.TextEdit();
            this.txtTenSanPham = new DevExpress.XtraEditors.TextEdit();
            this.selectLoaiSanPham = new DevExpress.XtraEditors.LookUpEdit();
            this.selectDonViTinh = new DevExpress.XtraEditors.LookUpEdit();
            this.txtSoLuongBaoDong = new DevExpress.XtraEditors.SpinEdit();
            this.txtSoLuongToiThieu = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnThemMoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.txtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gcSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinGiaXuatBanSi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinGiaXuatBanLe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinGiaNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKyHieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSanPham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectLoaiSanPham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectDonViTinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuongBaoDong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuongToiThieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            this.SuspendLayout();
            // 
            // gcSanPham
            // 
            this.gcSanPham.Location = new System.Drawing.Point(12, 158);
            this.gcSanPham.MainView = this.gvSanPham;
            this.gcSanPham.Name = "gcSanPham";
            this.gcSanPham.Size = new System.Drawing.Size(680, 378);
            this.gcSanPham.TabIndex = 1;
            this.gcSanPham.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSanPham});
            this.gcSanPham.Click += new System.EventHandler(this.gcLoaiSanPham_Click);
            // 
            // gvSanPham
            // 
            this.gvSanPham.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaSanPham,
            this.colTenSanPham,
            this.colSoLuongBaoDong,
            this.colSoLuongToiThieu,
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
            this.colTenSanPham.Width = 299;
            // 
            // colSoLuongBaoDong
            // 
            this.colSoLuongBaoDong.Caption = "SL Báo động";
            this.colSoLuongBaoDong.FieldName = "SoLuongBaoDong";
            this.colSoLuongBaoDong.Name = "colSoLuongBaoDong";
            this.colSoLuongBaoDong.Visible = true;
            this.colSoLuongBaoDong.VisibleIndex = 3;
            this.colSoLuongBaoDong.Width = 76;
            // 
            // colSoLuongToiThieu
            // 
            this.colSoLuongToiThieu.Caption = "SL Tối thiểu";
            this.colSoLuongToiThieu.FieldName = "SoLuongToiThieu";
            this.colSoLuongToiThieu.Name = "colSoLuongToiThieu";
            this.colSoLuongToiThieu.Visible = true;
            this.colSoLuongToiThieu.VisibleIndex = 4;
            this.colSoLuongToiThieu.Width = 76;
            // 
            // colDonViTinh
            // 
            this.colDonViTinh.Caption = "Đơn vị";
            this.colDonViTinh.FieldName = "DonViTinh";
            this.colDonViTinh.Name = "colDonViTinh";
            this.colDonViTinh.Visible = true;
            this.colDonViTinh.VisibleIndex = 2;
            this.colDonViTinh.Width = 112;
            // 
            // colKyHieu
            // 
            this.colKyHieu.Caption = "Mã SP";
            this.colKyHieu.FieldName = "KyHieu";
            this.colKyHieu.Name = "colKyHieu";
            this.colKyHieu.Visible = true;
            this.colKyHieu.VisibleIndex = 0;
            this.colKyHieu.Width = 99;
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
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.spinGiaXuatBanSi);
            this.layoutControl1.Controls.Add(this.spinGiaXuatBanLe);
            this.layoutControl1.Controls.Add(this.spinGiaNhap);
            this.layoutControl1.Controls.Add(this.txtKyHieu);
            this.layoutControl1.Controls.Add(this.txtTenSanPham);
            this.layoutControl1.Controls.Add(this.selectLoaiSanPham);
            this.layoutControl1.Controls.Add(this.selectDonViTinh);
            this.layoutControl1.Controls.Add(this.txtSoLuongBaoDong);
            this.layoutControl1.Controls.Add(this.txtSoLuongToiThieu);
            this.layoutControl1.Location = new System.Drawing.Point(1, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(703, 116);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // spinGiaXuatBanSi
            // 
            this.spinGiaXuatBanSi.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinGiaXuatBanSi.Location = new System.Drawing.Point(358, 84);
            this.spinGiaXuatBanSi.Name = "spinGiaXuatBanSi";
            this.spinGiaXuatBanSi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinGiaXuatBanSi.Properties.IsFloatValue = false;
            this.spinGiaXuatBanSi.Properties.Mask.EditMask = "N00";
            this.spinGiaXuatBanSi.Size = new System.Drawing.Size(132, 20);
            this.spinGiaXuatBanSi.StyleController = this.layoutControl1;
            this.spinGiaXuatBanSi.TabIndex = 12;
            // 
            // spinGiaXuatBanLe
            // 
            this.spinGiaXuatBanLe.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinGiaXuatBanLe.Location = new System.Drawing.Point(591, 84);
            this.spinGiaXuatBanLe.Name = "spinGiaXuatBanLe";
            this.spinGiaXuatBanLe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinGiaXuatBanLe.Properties.IsFloatValue = false;
            this.spinGiaXuatBanLe.Properties.Mask.EditMask = "N00";
            this.spinGiaXuatBanLe.Size = new System.Drawing.Size(100, 20);
            this.spinGiaXuatBanLe.StyleController = this.layoutControl1;
            this.spinGiaXuatBanLe.TabIndex = 11;
            // 
            // spinGiaNhap
            // 
            this.spinGiaNhap.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinGiaNhap.Location = new System.Drawing.Point(109, 84);
            this.spinGiaNhap.Name = "spinGiaNhap";
            this.spinGiaNhap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinGiaNhap.Properties.IsFloatValue = false;
            this.spinGiaNhap.Properties.Mask.EditMask = "N00";
            this.spinGiaNhap.Size = new System.Drawing.Size(148, 20);
            this.spinGiaNhap.StyleController = this.layoutControl1;
            this.spinGiaNhap.TabIndex = 10;
            // 
            // txtKyHieu
            // 
            this.txtKyHieu.Enabled = false;
            this.txtKyHieu.Location = new System.Drawing.Point(391, 12);
            this.txtKyHieu.Name = "txtKyHieu";
            this.txtKyHieu.Size = new System.Drawing.Size(93, 20);
            this.txtKyHieu.StyleController = this.layoutControl1;
            this.txtKyHieu.TabIndex = 9;
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Location = new System.Drawing.Point(109, 12);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtTenSanPham.Properties.Appearance.Options.UseFont = true;
            this.txtTenSanPham.Size = new System.Drawing.Size(278, 20);
            this.txtTenSanPham.StyleController = this.layoutControl1;
            this.txtTenSanPham.TabIndex = 4;
            // 
            // selectLoaiSanPham
            // 
            this.selectLoaiSanPham.Location = new System.Drawing.Point(109, 36);
            this.selectLoaiSanPham.Name = "selectLoaiSanPham";
            this.selectLoaiSanPham.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.selectLoaiSanPham.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaLoaiSanPham", "Mã loại SP", 5, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("KyHieu", "#"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenLoaiSanPham", 80, "Tên loại SP")});
            this.selectLoaiSanPham.Properties.DisplayMember = "TenLoaiSanPham";
            this.selectLoaiSanPham.Properties.NullText = "";
            this.selectLoaiSanPham.Properties.ValueMember = "MaLoaiSanPham";
            this.selectLoaiSanPham.Size = new System.Drawing.Size(582, 20);
            this.selectLoaiSanPham.StyleController = this.layoutControl1;
            this.selectLoaiSanPham.TabIndex = 6;
            // 
            // selectDonViTinh
            // 
            this.selectDonViTinh.Location = new System.Drawing.Point(585, 12);
            this.selectDonViTinh.Name = "selectDonViTinh";
            this.selectDonViTinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.selectDonViTinh.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenDonViTinh", "Đơn vị tính")});
            this.selectDonViTinh.Properties.DisplayMember = "TenDonViTinh";
            this.selectDonViTinh.Properties.NullText = "";
            this.selectDonViTinh.Properties.ValueMember = "TenDonViTinh";
            this.selectDonViTinh.Size = new System.Drawing.Size(106, 20);
            this.selectDonViTinh.StyleController = this.layoutControl1;
            this.selectDonViTinh.TabIndex = 6;
            // 
            // txtSoLuongBaoDong
            // 
            this.txtSoLuongBaoDong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSoLuongBaoDong.Location = new System.Drawing.Point(109, 60);
            this.txtSoLuongBaoDong.Name = "txtSoLuongBaoDong";
            this.txtSoLuongBaoDong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSoLuongBaoDong.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txtSoLuongBaoDong.Properties.Mask.EditMask = "n";
            this.txtSoLuongBaoDong.Size = new System.Drawing.Size(241, 20);
            this.txtSoLuongBaoDong.StyleController = this.layoutControl1;
            this.txtSoLuongBaoDong.TabIndex = 7;
            // 
            // txtSoLuongToiThieu
            // 
            this.txtSoLuongToiThieu.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSoLuongToiThieu.Location = new System.Drawing.Point(451, 60);
            this.txtSoLuongToiThieu.Name = "txtSoLuongToiThieu";
            this.txtSoLuongToiThieu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSoLuongToiThieu.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txtSoLuongToiThieu.Properties.Mask.EditMask = "n";
            this.txtSoLuongToiThieu.Size = new System.Drawing.Size(240, 20);
            this.txtSoLuongToiThieu.StyleController = this.layoutControl1;
            this.txtSoLuongToiThieu.TabIndex = 8;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem2,
            this.layoutControlItem8,
            this.layoutControlItem9});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(703, 116);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.txtTenSanPham;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(379, 24);
            this.layoutControlItem1.Text = "Tên sản phẩm:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(94, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.selectDonViTinh;
            this.layoutControlItem3.Location = new System.Drawing.Point(476, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(207, 24);
            this.layoutControlItem3.Text = "Đơn vị tính:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(94, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtSoLuongBaoDong;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(342, 24);
            this.layoutControlItem4.Text = "Số lượng báo động:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(94, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtSoLuongToiThieu;
            this.layoutControlItem5.Location = new System.Drawing.Point(342, 48);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(341, 24);
            this.layoutControlItem5.Text = "Số lượng tối thiểu:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(94, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtKyHieu;
            this.layoutControlItem6.Location = new System.Drawing.Point(379, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(97, 24);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.selectLoaiSanPham;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(683, 24);
            this.layoutControlItem7.Text = "Loại:";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(94, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.spinGiaNhap;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(249, 24);
            this.layoutControlItem2.Text = "Giá nhập:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(94, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.spinGiaXuatBanLe;
            this.layoutControlItem8.Location = new System.Drawing.Point(482, 72);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(201, 24);
            this.layoutControlItem8.Text = "Giá xuất bán lẻ:";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(94, 13);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.spinGiaXuatBanSi;
            this.layoutControlItem9.Location = new System.Drawing.Point(249, 72);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(233, 24);
            this.layoutControlItem9.Text = "Giá xuất bán sỉ:";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(94, 13);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnThemMoi.Image")));
            this.btnThemMoi.Location = new System.Drawing.Point(12, 121);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(80, 31);
            this.btnThemMoi.TabIndex = 3;
            this.btnThemMoi.Text = "Mới";
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(98, 121);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(128, 31);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(232, 121);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(104, 31);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnDong
            // 
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.Location = new System.Drawing.Point(589, 121);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(104, 31);
            this.btnDong.TabIndex = 3;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(342, 127);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(56, 21);
            this.txtID.TabIndex = 4;
            this.txtID.Visible = false;
            // 
            // FormSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 555);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.gcSanPham);
            this.Name = "FormSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSanPham";
            this.Load += new System.EventHandler(this.FormSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spinGiaXuatBanSi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinGiaXuatBanLe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinGiaNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKyHieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSanPham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectLoaiSanPham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectDonViTinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuongBaoDong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuongToiThieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcSanPham;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn colMaSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn colTenSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuongBaoDong;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuongToiThieu;
        private DevExpress.XtraGrid.Columns.GridColumn colDonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn colKyHieu;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtKyHieu;
        private DevExpress.XtraEditors.TextEdit txtTenSanPham;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.SimpleButton btnThemMoi;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private System.Windows.Forms.TextBox txtID;
        private DevExpress.XtraEditors.LookUpEdit selectDonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn colTenLoaiSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn colMaLoaiSanPham;
        private DevExpress.XtraEditors.LookUpEdit selectLoaiSanPham;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.SpinEdit txtSoLuongBaoDong;
        private DevExpress.XtraEditors.SpinEdit txtSoLuongToiThieu;
        private DevExpress.XtraEditors.SpinEdit spinGiaXuatBanSi;
        private DevExpress.XtraEditors.SpinEdit spinGiaXuatBanLe;
        private DevExpress.XtraEditors.SpinEdit spinGiaNhap;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
    }
}