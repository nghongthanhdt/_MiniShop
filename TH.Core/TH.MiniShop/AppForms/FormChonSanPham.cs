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
        public FormChonSanPham()
        {
            InitializeComponent();
        }
        private void loadgcSanPham()
        {
            
            
        }

        private void FormChonSanPham_Load(object sender, EventArgs e)
        {
            var listSanPham = db.SanPham.ToList();
            gcSanPham.DataSource = listSanPham;
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            try
            {
                selectedMaSanPham = int.Parse(gvSanPham.GetFocusedRowCellValue("MaSanPham").ToString());
            } catch { }
            if (selectedMaSanPham == 0)
            {
                ThMessageBox.ShowError("Chưa chọn sản phẩm");
                return;
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}