using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TH.MiniShop.Models;
using TH.Core.Forms;

namespace TH.MiniShop.AppForms
{
    public partial class FormChonSanPham : DevExpress.XtraEditors.XtraForm
    {
        MiniShopEntities db = new MiniShopEntities();
        public int selectedMaSanPham = 0;
        public string maLoaiPhieu = "";
        public bool boQua = false;
        public FormChonSanPham()
        {
            InitializeComponent();
        }

        private void FormChonSanPham_Load(object sender, EventArgs e)
        {
            load();
        }
        private void load()
        {
            var listTonKho = db.TonKho.OrderBy(x => x.SanPham.TenSanPham).ToList();
            gcSanPham.DataSource = listTonKho;
            if (maLoaiPhieu == "PN")
            {
                colGiaSi.Visible = false;
                colGiaLe.Visible = false;
            }
        }

        private void gcSanPham_Click(object sender, EventArgs e)
        {
            
            try
            {
                selectedMaSanPham = int.Parse(gvSanPham.GetFocusedRowCellValue("MaSanPham").ToString());
            }
            catch { };
        }

        private void gcSanPham_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            btnChon.PerformClick();
        }

        private void gcSanPham_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            boQua = true;
            this.Close();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            try
            {
                selectedMaSanPham = int.Parse(gvSanPham.GetFocusedRowCellValue("MaSanPham").ToString());
            }
            catch { };
            this.Close();
        }
    }
}