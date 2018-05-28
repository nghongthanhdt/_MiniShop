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
using TH.Core.Forms;
using TH.MiniShop.Models;

namespace TH.MiniShop.AppForms
{
    public partial class FormSanPham : DevExpress.XtraEditors.XtraForm
    {
        MiniShop.Models.MiniShopEntities db = new Models.MiniShopEntities();
        public FormSanPham()
        {
            InitializeComponent();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            themMoi();
        }
        private void load()
        {
            txtKyHieu.Enabled = false;
            //btnLuu.Enabled = false;
            
            loadselectDonViTinh();
            loadselectLoaiSanPham();
            loadgcSanPham();

        }

        private void FormSanPham_Load(object sender, EventArgs e)
        {
            load();
        }   
        private void loadselectLoaiSanPham()
        {
            var listLoaiSanPham = db.LoaiSanPham.OrderBy(x => x.TenLoaiSanPham).ToList();
            selectLoaiSanPham.Properties.DataSource = listLoaiSanPham;
        } 
        private void loadselectDonViTinh()
        {
            var listDonViTinh = db.DonViTinh.OrderBy(x => x.TenDonViTinh).ToList();
            selectDonViTinh.Properties.DataSource = listDonViTinh;
        }
        private void loadgcSanPham()
        {
            var listSanPham = db.SanPham.OrderBy(x => x.TenSanPham).ToList();
            gcSanPham.DataSource = listSanPham;
        }
        private void themMoi()
        {
            txtID.Text = "";
            txtTenSanPham.Text = "";
            txtKyHieu.Text = "";              
            txtSoLuongBaoDong.Text = "";
            txtSoLuongToiThieu.Text = "";
            btnLuu.Enabled = true;
            txtTenSanPham.Focus();
        }
        private void luu()
        {
            if (!kiemtra())
            {
                return;
            }
            // thêm sản phẩm, tạo ký hiệu
            try
            {
                if (txtID.Text == "")
                {
                    SanPham sp = new SanPham();
                    decimal slBaoDong = 0;
                    decimal slToiThieu = 0;
                    sp.TenSanPham = txtTenSanPham.Text;
                    sp.DonViTinh = selectDonViTinh.EditValue.ToString();
                    sp.MaLoaiSanPham = int.Parse(selectLoaiSanPham.EditValue.ToString());
                    sp.KyHieu = "";
                    try { slBaoDong = decimal.Parse(txtSoLuongBaoDong.EditValue.ToString()); } catch { }
                    try { slToiThieu = decimal.Parse(txtSoLuongToiThieu.EditValue.ToString()); } catch { }
                    sp.SoLuongBaoDong = slBaoDong;
                    sp.SoLuongToiThieu = slToiThieu;
                    sp.GiaNhap = int.Parse(spinGiaNhap.EditValue.ToString());
                    sp.GiaXuatBanSi = int.Parse(spinGiaXuatBanSi.EditValue.ToString());
                    sp.GiaXuatBanLe = int.Parse(spinGiaXuatBanLe.EditValue.ToString());

                    db.SanPham.Add(sp);
                    db.SaveChanges();
                    sp.KyHieu = TH.Core.Controllers.StringController.ToProductID(sp.LoaiSanPham.KyHieu, sp.MaSanPham);
                    TonKho tk = new TonKho();
                    tk.MaSanPham = sp.MaSanPham;
                    tk.SoLuongTon = 0;
                    db.TonKho.Add(tk);
                    db.SaveChanges();



                    txtTenSanPham.Text = "";
                    txtKyHieu.Text = "";
                    txtID.Text = "";
                    btnLuu.Enabled = false;
                    txtTenSanPham.Focus();
                    loadgcSanPham();
                }
                else
                {
                    int maSanPham = int.Parse(txtID.Text);
                    decimal slBaoDong = 0;
                    decimal slToiThieu = 0;
                    SanPham sp = db.SanPham.Find(maSanPham);
                    sp.TenSanPham = txtTenSanPham.Text;
                    sp.DonViTinh = selectDonViTinh.EditValue.ToString();
                    sp.MaLoaiSanPham = int.Parse(selectLoaiSanPham.EditValue.ToString());
                    try { slBaoDong = decimal.Parse(txtSoLuongBaoDong.EditValue.ToString()); } catch { }
                    try { slToiThieu = decimal.Parse(txtSoLuongToiThieu.EditValue.ToString()); } catch { }
                    sp.SoLuongBaoDong = slBaoDong;
                    sp.SoLuongToiThieu = slToiThieu;
                    sp.GiaNhap = int.Parse(spinGiaNhap.EditValue.ToString());
                    sp.GiaXuatBanSi = int.Parse(spinGiaXuatBanSi.EditValue.ToString());
                    sp.GiaXuatBanLe = int.Parse(spinGiaXuatBanLe.EditValue.ToString());
                    db.SaveChanges();
                    loadgcSanPham();
                }
            }
            catch (Exception ex)
            {
                TH.Core.Forms.ThMessageBox.ShowSystemError(ex.Message);
            }
        }
        private void chon()
        {
            try
            {
                txtID.Text = gvSanPham.GetFocusedRowCellValue("MaSanPham").ToString();
                txtTenSanPham.Text = gvSanPham.GetFocusedRowCellValue("TenSanPham").ToString();
                txtKyHieu.Text = gvSanPham.GetFocusedRowCellValue("KyHieu").ToString();
                selectDonViTinh.EditValue = gvSanPham.GetFocusedRowCellValue("DonViTinh").ToString();
                selectLoaiSanPham.EditValue = int.Parse(gvSanPham.GetFocusedRowCellValue("MaLoaiSanPham").ToString());
                spinGiaNhap.EditValue = int.Parse(gvSanPham.GetFocusedRowCellValue("MaLoaiSanPham").ToString());
                spinGiaXuatBanSi.EditValue = int.Parse(gvSanPham.GetFocusedRowCellValue("GiaXuatBanSi").ToString());
                spinGiaXuatBanLe.EditValue = int.Parse(gvSanPham.GetFocusedRowCellValue("GiaXuatBanLe").ToString());
                txtSoLuongBaoDong.Text = gvSanPham.GetFocusedRowCellValue("SoLuongBaoDong").ToString();
                txtSoLuongToiThieu.Text = gvSanPham.GetFocusedRowCellValue("SoLuongToiThieu").ToString();
                btnLuu.Enabled = true;
            }
            catch 
            {
                //TH.Core.Forms.ThMessageBox.ShowSystemError(ex.Message);
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
                var sp = db.SanPham.Find(id);
                db.TonKho.RemoveRange(sp.TonKho);
                db.SanPham.Remove(sp);
                db.SaveChanges();
                btnThemMoi.PerformClick();
                loadgcSanPham();
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
            if (txtTenSanPham.Text == "")
            {
                ThMessageBox.ShowError("Nhập tên sản phẩm");
                return false;
            }
            if (selectDonViTinh.EditValue == null)
            {
                ThMessageBox.ShowError("Chọn đơn vị tính");
                return false;
            }
            if (selectLoaiSanPham.EditValue == null)
            {
                ThMessageBox.ShowError("Chọn loại sản phẩm");
                return false;
            }
            return true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            luu();
        }

        private void gcLoaiSanPham_Click(object sender, EventArgs e)
        {
            chon();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            xoa();
        }
    }
}