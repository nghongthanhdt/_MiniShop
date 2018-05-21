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

namespace TH.MiniShop.AppForms
{
    public partial class FormQuanLyNhapXuat : DevExpress.XtraEditors.XtraForm
    {
        MiniShopEntities db = new MiniShopEntities();
        public FormQuanLyNhapXuat()
        {
            InitializeComponent();
        }

        private void FormQuanLyNhapXuat_Load(object sender, EventArgs e)
        {
            load();
        }
        private void load()
        {
            var listPhieu = db.PhieuXuatNhap.ToList();
            gcPhieuNhapXuat.DataSource = listPhieu;
        }
    }
}