namespace DHG.Tools
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
            this.menuBangChiaThuoc = new DevExpress.XtraBars.BarButtonItem();
            this.menuCauHinhKetNoi = new DevExpress.XtraBars.BarButtonItem();
            this.menuThoat = new DevExpress.XtraBars.BarButtonItem();
            this.menuBenhNhan = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.menuBangChiaThuoc,
            this.menuCauHinhKetNoi,
            this.menuThoat,
            this.menuBenhNhan});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 5;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(758, 143);
            // 
            // menuBangChiaThuoc
            // 
            this.menuBangChiaThuoc.Caption = "Bảng chia thuốc";
            this.menuBangChiaThuoc.Glyph = ((System.Drawing.Image)(resources.GetObject("menuBangChiaThuoc.Glyph")));
            this.menuBangChiaThuoc.Id = 1;
            this.menuBangChiaThuoc.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("menuBangChiaThuoc.LargeGlyph")));
            this.menuBangChiaThuoc.Name = "menuBangChiaThuoc";
            // 
            // menuCauHinhKetNoi
            // 
            this.menuCauHinhKetNoi.Caption = "Cấu hình kết nối";
            this.menuCauHinhKetNoi.Glyph = ((System.Drawing.Image)(resources.GetObject("menuCauHinhKetNoi.Glyph")));
            this.menuCauHinhKetNoi.Id = 2;
            this.menuCauHinhKetNoi.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("menuCauHinhKetNoi.LargeGlyph")));
            this.menuCauHinhKetNoi.Name = "menuCauHinhKetNoi";
            this.menuCauHinhKetNoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuCauHinhKetNoi_ItemClick);
            // 
            // menuThoat
            // 
            this.menuThoat.Caption = "Thoát";
            this.menuThoat.Glyph = ((System.Drawing.Image)(resources.GetObject("menuThoat.Glyph")));
            this.menuThoat.Id = 3;
            this.menuThoat.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("menuThoat.LargeGlyph")));
            this.menuThoat.Name = "menuThoat";
            this.menuThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuThoat_ItemClick);
            // 
            // menuBenhNhan
            // 
            this.menuBenhNhan.Caption = "Bệnh nhân";
            this.menuBenhNhan.Glyph = ((System.Drawing.Image)(resources.GetObject("menuBenhNhan.Glyph")));
            this.menuBenhNhan.Id = 4;
            this.menuBenhNhan.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("menuBenhNhan.LargeGlyph")));
            this.menuBenhNhan.Name = "menuBenhNhan";
            this.menuBenhNhan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuBenhNhan_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Hệ thống";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.menuBenhNhan);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Tìm kiếm";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.menuCauHinhKetNoi);
            this.ribbonPageGroup1.ItemLinks.Add(this.menuThoat);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Hệ thống";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Admin Tools";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Nội trú";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.menuBangChiaThuoc);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // FormMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 360);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "FormMain";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DHG.Tools";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem menuBangChiaThuoc;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem menuCauHinhKetNoi;
        private DevExpress.XtraBars.BarButtonItem menuThoat;
        private DevExpress.XtraBars.BarButtonItem menuBenhNhan;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
    }
}

