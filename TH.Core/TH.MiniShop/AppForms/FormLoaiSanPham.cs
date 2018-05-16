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
    public partial class FormLoaiSanPham : DevExpress.XtraEditors.XtraForm
    {

        MiniShop.Models.MiniShopEntities db = new Models.MiniShopEntities();
        public FormLoaiSanPham()
        {
            InitializeComponent();
        }

        private void FormLoaiSanPham_Load(object sender, EventArgs e)
        {
            load();
        }




        

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            themMoi();
        }    
        private void btnLuu_Click(object sender, EventArgs e)
        {
            luu();
        }        
        private void btnBoQua_Click(object sender, EventArgs e)
        {

        }



        private void load()
        {
            txtKyHieu.Enabled = false;
            btnLuu.Enabled = false;
            loadgcLoaiSanPham();

        }
        private void loadgcLoaiSanPham()
        {
            var listLoaiSanPham = db.LoaiSanPham.OrderBy(x => x.TenLoaiSanPham).ToList();
            gcLoaiSanPham.DataSource = listLoaiSanPham;
        }
        private void themMoi()
        {
            txtID.Text = "";
            txtTenLoaiSanPham.Text = "";
            txtKyHieu.Text = "";
            btnLuu.Enabled = true;
            txtTenLoaiSanPham.Focus();
        }
        private void luu()
        {
            if (!kiemtra())
            {
                return;
            }
            // thêm loại sản phẩm, tạo ký hiệu
            try
            {
                if (txtID.Text == "")
                {
                    LoaiSanPham loai = new LoaiSanPham();
                    loai.TenLoaiSanPham = txtTenLoaiSanPham.Text;
                    loai.KyHieu = "";
                    db.LoaiSanPham.Add(loai);
                    db.SaveChanges();
                    loai.KyHieu = TH.Core.Controllers.StringController.ToLeft2CharID(loai.TenLoaiSanPham, loai.MaLoaiSanPham);
                    db.SaveChanges();
                    txtTenLoaiSanPham.Text = "";
                    txtKyHieu.Text = "";
                    txtID.Text = "";
                    btnLuu.Enabled = false;
                    txtTenLoaiSanPham.Focus();
                    loadgcLoaiSanPham();
                }
                else
                {
                    int maloai = int.Parse(txtID.Text);
                    LoaiSanPham loai = db.LoaiSanPham.Find(maloai);
                    loai.TenLoaiSanPham = txtTenLoaiSanPham.Text;
                    db.SaveChanges();
                    loadgcLoaiSanPham();
                }
            }
            catch (Exception ex)
            {
                TH.Core.Forms.ThMessageBox.ShowSystemError(ex.Message);
            }
        }
        private void xoa()
        {
            if (!kiemtraxoa())
            {
                return;
            }
            try
            {
                
                if (!TH.Core.Forms.ThMessageBox.ShowConfirm("Bạn thật sự muốn xóa ?"))
                {
                    return;
                }

                int id = int.Parse(txtID.Text);
                var loai = db.LoaiSanPham.Find(id);
                db.LoaiSanPham.Remove(loai);
                db.SaveChanges();
                btnLuu.Enabled = false;
                loadgcLoaiSanPham();
            }
            catch (Exception ex)
            {
                TH.Core.Forms.ThMessageBox.ShowSystemError(ex.Message);
            }
        }
        private bool kiemtraxoa()
        {
            if (txtID.Text == "")
            {
                ThMessageBox.ShowError("Chưa chọn dữ liệu");
                return false;
            }
            return true;
        }
        private bool kiemtra()
        {
            if (txtTenLoaiSanPham.Text == "")
            {
                ThMessageBox.ShowError("Nhập tên loại sản phẩm");
                return false;
            }
            return true;
        }

        private void txtTenLoaiSanPham_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (btnLuu.Enabled == true) btnLuu.Focus();
                else btnThemMoi.Focus();
            }
        }

        private void gcLoaiSanPham_Click(object sender, EventArgs e)
        {
            try
            {
                txtID.Text = gvLoaiSanPham.GetFocusedRowCellValue("MaLoaiSanPham").ToString();
                txtTenLoaiSanPham.Text = gvLoaiSanPham.GetFocusedRowCellValue("TenLoaiSanPham").ToString();
                txtKyHieu.Text = gvLoaiSanPham.GetFocusedRowCellValue("KyHieu").ToString();
                btnLuu.Enabled = true;
            }
            catch (Exception ex)
            {
                TH.Core.Forms.ThMessageBox.ShowSystemError(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            xoa();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}