using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TH.Core.Forms;

namespace TH.MiniShop
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        MiniShop.Models.MiniShopEntities db = new Models.MiniShopEntities();
        public FormMain()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThMessageBox.Show("hihi");

        }
    }
}
