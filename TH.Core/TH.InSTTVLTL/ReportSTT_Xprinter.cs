using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace TH.InSTTVLTL
{
    public partial class ReportSTT_Xprinter : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportSTT_Xprinter()
        {
            InitializeComponent();
        }

        private void lblTenVLTL_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }
    }
}
