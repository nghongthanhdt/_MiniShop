namespace TH.MiniShop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.menuLoaiSanPham = new DevExpress.XtraBars.BarButtonItem();
            this.menuSanPham = new DevExpress.XtraBars.BarButtonItem();
            this.menuNhapXuatHang = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.menuQuanLyNhapXuat = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.menuLoaiSanPham,
            this.menuSanPham,
            this.menuNhapXuatHang,
            this.menuQuanLyNhapXuat});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 5;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(758, 143);
            // 
            // menuLoaiSanPham
            // 
            this.menuLoaiSanPham.Caption = "Loại sản phẩm";
            this.menuLoaiSanPham.Glyph = ((System.Drawing.Image)(resources.GetObject("menuLoaiSanPham.Glyph")));
            this.menuLoaiSanPham.Id = 1;
            this.menuLoaiSanPham.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("menuLoaiSanPham.LargeGlyph")));
            this.menuLoaiSanPham.Name = "menuLoaiSanPham";
            this.menuLoaiSanPham.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // menuSanPham
            // 
            this.menuSanPham.Caption = "Sản phẩm";
            this.menuSanPham.Glyph = ((System.Drawing.Image)(resources.GetObject("menuSanPham.Glyph")));
            this.menuSanPham.Id = 2;
            this.menuSanPham.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("menuSanPham.LargeGlyph")));
            this.menuSanPham.Name = "menuSanPham";
            this.menuSanPham.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuSanPham_ItemClick);
            // 
            // menuNhapXuatHang
            // 
            this.menuNhapXuatHang.Caption = "Nhập xuất hàng";
            this.menuNhapXuatHang.Glyph = ((System.Drawing.Image)(resources.GetObject("menuNhapXuatHang.Glyph")));
            this.menuNhapXuatHang.Id = 3;
            this.menuNhapXuatHang.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("menuNhapXuatHang.LargeGlyph")));
            this.menuNhapXuatHang.Name = "menuNhapXuatHang";
            this.menuNhapXuatHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuNhapXuatHang_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.menuLoaiSanPham);
            this.ribbonPageGroup1.ItemLinks.Add(this.menuSanPham);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Danh mục";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.menuQuanLyNhapXuat);
            this.ribbonPageGroup2.ItemLinks.Add(this.menuNhapXuatHang);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // menuQuanLyNhapXuat
            // 
            this.menuQuanLyNhapXuat.Caption = "Quản lý nhập xuất";
            this.menuQuanLyNhapXuat.Glyph = ((System.Drawing.Image)(resources.GetObject("menuQuanLyNhapXuat.Glyph")));
            this.menuQuanLyNhapXuat.Id = 4;
            this.menuQuanLyNhapXuat.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("menuQuanLyNhapXuat.LargeGlyph")));
            this.menuQuanLyNhapXuat.Name = "menuQuanLyNhapXuat";
            this.menuQuanLyNhapXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuQuanLyNhapXuat_ItemClick);
            // 
            // FormMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 609);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "FormMain";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TH.Softs Quản lý bán hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem menuLoaiSanPham;
        private DevExpress.XtraBars.BarButtonItem menuSanPham;
        private DevExpress.XtraBars.BarButtonItem menuNhapXuatHang;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem menuQuanLyNhapXuat;
    }
}

