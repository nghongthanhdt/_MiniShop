namespace TH.InSTTVLTL
{
    partial class ReportSTT_Xprinter
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraPrinting.Shape.ShapeRectangle shapeRectangle1 = new DevExpress.XtraPrinting.Shape.ShapeRectangle();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.lblSTT = new DevExpress.XtraReports.UI.XRLabel();
            this.lblNgay = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTenVLTL = new DevExpress.XtraReports.UI.XRLabel();
            this.xrShape1 = new DevExpress.XtraReports.UI.XRShape();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.lblTenBenhVien = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblSTT,
            this.lblNgay,
            this.lblTenVLTL,
            this.xrShape1});
            this.Detail.Dpi = 100F;
            this.Detail.HeightF = 116.8334F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lblSTT
            // 
            this.lblSTT.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.lblSTT.BorderWidth = 2F;
            this.lblSTT.Dpi = 100F;
            this.lblSTT.Font = new System.Drawing.Font("Arial", 58F);
            this.lblSTT.LocationFloat = new DevExpress.Utils.PointFloat(153.9165F, 9.541672F);
            this.lblSTT.Name = "lblSTT";
            this.lblSTT.SizeF = new System.Drawing.SizeF(109.0835F, 85.24999F);
            this.lblSTT.StylePriority.UseBorders = false;
            this.lblSTT.StylePriority.UseBorderWidth = false;
            this.lblSTT.StylePriority.UseFont = false;
            this.lblSTT.StylePriority.UsePadding = false;
            this.lblSTT.StylePriority.UseTextAlignment = false;
            this.lblSTT.Text = "12";
            this.lblSTT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lblNgay
            // 
            this.lblNgay.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.lblNgay.BorderWidth = 0F;
            this.lblNgay.Dpi = 100F;
            this.lblNgay.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblNgay.LocationFloat = new DevExpress.Utils.PointFloat(11.49998F, 4.041653F);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblNgay.SizeF = new System.Drawing.SizeF(144.9165F, 23F);
            this.lblNgay.StylePriority.UseBorders = false;
            this.lblNgay.StylePriority.UseBorderWidth = false;
            this.lblNgay.StylePriority.UseFont = false;
            this.lblNgay.StylePriority.UseTextAlignment = false;
            this.lblNgay.Text = "21/05/2018 10:50 AM";
            this.lblNgay.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lblTenVLTL
            // 
            this.lblTenVLTL.CanGrow = false;
            this.lblTenVLTL.Dpi = 100F;
            this.lblTenVLTL.Font = new System.Drawing.Font("Tahoma", 13F);
            this.lblTenVLTL.LocationFloat = new DevExpress.Utils.PointFloat(11.50001F, 27.04167F);
            this.lblTenVLTL.Name = "lblTenVLTL";
            this.lblTenVLTL.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblTenVLTL.SizeF = new System.Drawing.SizeF(142.4165F, 73.75001F);
            this.lblTenVLTL.StylePriority.UseFont = false;
            this.lblTenVLTL.Text = "Kỹ thuật kéo nắn bằng máy kéo dãn";
            this.lblTenVLTL.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.lblTenVLTL_BeforePrint);
            // 
            // xrShape1
            // 
            this.xrShape1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrShape1.Dpi = 100F;
            this.xrShape1.LineWidth = 2;
            this.xrShape1.LocationFloat = new DevExpress.Utils.PointFloat(1.500003F, 0F);
            this.xrShape1.Name = "xrShape1";
            this.xrShape1.Shape = shapeRectangle1;
            this.xrShape1.SizeF = new System.Drawing.SizeF(271.5F, 116.8334F);
            this.xrShape1.StylePriority.UseBorders = false;
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblTenBenhVien});
            this.TopMargin.Dpi = 100F;
            this.TopMargin.HeightF = 23.00002F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lblTenBenhVien
            // 
            this.lblTenBenhVien.Dpi = 100F;
            this.lblTenBenhVien.Font = new System.Drawing.Font("Arial", 11F);
            this.lblTenBenhVien.LocationFloat = new DevExpress.Utils.PointFloat(9.999974F, 0F);
            this.lblTenBenhVien.Name = "lblTenBenhVien";
            this.lblTenBenhVien.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblTenBenhVien.SizeF = new System.Drawing.SizeF(253F, 23.00002F);
            this.lblTenBenhVien.StylePriority.UseBorders = false;
            this.lblTenBenhVien.StylePriority.UseBorderWidth = false;
            this.lblTenBenhVien.StylePriority.UseFont = false;
            this.lblTenBenhVien.StylePriority.UseTextAlignment = false;
            this.lblTenBenhVien.Text = "BV PHỤC HỒI CHỨC NĂNG";
            this.lblTenBenhVien.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Dpi = 100F;
            this.BottomMargin.HeightF = 0F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // ReportSTT_Xprinter
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.Margins = new System.Drawing.Printing.Margins(0, 0, 23, 0);
            this.PageHeight = 160;
            this.PageWidth = 273;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.Version = "16.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        public DevExpress.XtraReports.UI.XRLabel lblNgay;
        public DevExpress.XtraReports.UI.XRLabel lblSTT;
        public DevExpress.XtraReports.UI.XRLabel lblTenVLTL;
        public DevExpress.XtraReports.UI.XRLabel lblTenBenhVien;
        private DevExpress.XtraReports.UI.XRShape xrShape1;
    }
}
