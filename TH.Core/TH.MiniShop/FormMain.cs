using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TH.Core.Forms;
using TH.MiniShop.AppForms;

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
            //ThMessageBox.Show(TH.Core.Controllers.StringController.ToLeft2CharID("Đường",33330));
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(FormLoaiSanPham))
                {
                    form.Activate();
                    return;
                }
            }                                 
            Form newForm = new FormLoaiSanPham();
            newForm.MdiParent = this;
            newForm.Show();                   
        }

        private void menuSanPham_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(FormSanPham))
                {
                    form.Activate();
                    return;
                }
            }
            Form newForm = new FormSanPham();
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void menuNhapXuatHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(FormNhapXuat))
                {
                    form.Activate();
                    return;
                }
            }
            Form newForm = new FormNhapXuat();
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void menuQuanLyNhapXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(FormQuanLyNhapXuat))
                {
                    form.Activate();
                    return;
                }
            }
            Form newForm = new FormQuanLyNhapXuat();
            newForm.MdiParent = this;
            newForm.Show();
        }
    }
}
