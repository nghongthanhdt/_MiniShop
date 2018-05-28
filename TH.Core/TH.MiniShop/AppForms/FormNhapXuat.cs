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
    public partial class FormNhapXuat : DevExpress.XtraEditors.XtraForm
    {
        MiniShopEntities db = new MiniShopEntities();
        List<SanPham> listSanPhamDaChon = new List<SanPham>();
        DataTable dtSanPhamDangChon = new DataTable();
        public string maLoaiPhieu = "";
        public FormNhapXuat()
        {
            InitializeComponent();
            thietlapDataTable();
            init();
        }
        
        private void thietlapDataTable()
        {
            dtSanPhamDangChon.Columns.Add("STT", typeof(int));
            dtSanPhamDangChon.Columns.Add("TenSanPham", typeof(string));
            dtSanPhamDangChon.Columns.Add("DonViTinh", typeof(string));
            dtSanPhamDangChon.Columns.Add("SoLuong", typeof(decimal));
            dtSanPhamDangChon.Columns.Add("DonGia", typeof(int));
            dtSanPhamDangChon.Columns.Add("ThanhTien", typeof(decimal));
        }
        private void FormNhapXuat_Load(object sender, EventArgs e)
        {
            load();
        }       
        private void load()
        {
            loadselectHinhThuc(maLoaiPhieu);
            loadselectLoaiPhieu(maLoaiPhieu);
        }
        private void init()
        {
            //loadselectLoaiPhieu("");

            loadselectKho();            
            loadselectKhachHang();                    
            dateNgayNhap.EditValue = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            dateNgayLapPhieu.EditValue = DateTime.Now;
            dateNgayLapPhieu.Enabled = false;
            selectKhachHang.EditValue = 0;
        }
        private void loadselectLoaiPhieu(string maLoaiPhieu)
        {
            var listLoaiPhieu = new List<LoaiPhieu>();
            if (maLoaiPhieu == "PN")
            {
                listLoaiPhieu = db.LoaiPhieu.Where(x => x.MaLoaiPhieu == "PN").ToList();
            } else if (maLoaiPhieu == "PX")
            {
                listLoaiPhieu = db.LoaiPhieu.Where(x => x.MaLoaiPhieu == "PX").ToList();
            } else
            {
                listLoaiPhieu = db.LoaiPhieu.ToList();
            }

            selectLoaiPhieu.Properties.DataSource = listLoaiPhieu;
            selectLoaiPhieu.EditValue = listLoaiPhieu.First().MaLoaiPhieu;
        }
        private void loadselectKho()
        {
            var listKho = db.Kho.ToList();
            selectKho.Properties.DataSource = listKho;
            selectKho.Properties.NullText = "Chọn kho...";
        }
        private void loadselectHinhThuc(string loaiPhieu)
        {
            var listHinhThuc = new List<HinhThucNhapXuat>();
            if (loaiPhieu == "PN")
            {
                listHinhThuc = db.HinhThucNhapXuat.Where(x => x.Nhap == true).OrderBy(x => x.STT).ToList();
            } else if (loaiPhieu == "PX")
            {
                listHinhThuc = db.HinhThucNhapXuat.Where(x => x.Nhap == false).OrderBy(x => x.STT).ToList();
            }
            else
            {
                listHinhThuc = db.HinhThucNhapXuat.OrderBy(x => x.STT).ToList();
            }                                                  
            selectHinhThuc.Properties.DataSource = listHinhThuc;
            selectHinhThuc.EditValue = listHinhThuc.First().MaHinhThuc;
        }
        private void loadselectKhachHang()
        {
            var listKhachHang = db.KhachHang.ToList();
            selectKhachHang.Properties.DataSource = listKhachHang;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            luu();
        }
        private void luu()
        {
            if (!kiemtraPhieu())
            {
                return;
            }
            if (!themKhachHang())
            {
                return;
            }
        }
        private bool kiemtraPhieu()
        {
            if (selectKho.EditValue == null)
            {
                ThMessageBox.ShowError("Chưa chọn kho");
                return false;
            }
            return true;
        }
        private bool themKhachHang()
        {
            try
            {
                if (selectKhachHang.EditValue == null)
                {
                    string tenKhachHang = txtKhachHangMoi.Text;
                    string diaChi = txtDiaChi.Text;
                    string dienThoai = txtDienThoai.Text;

                    if (tenKhachHang == "")
                    {
                        ThMessageBox.ShowError("Nhập tên khách hàng");
                        return false;
                    }
                    if (kiemtraKhachHangdaTonTai(tenKhachHang))
                    {
                        if (!ThMessageBox.ShowConfirm("Khách hàng '" + tenKhachHang + "' đã tồn tại, bạn có muốn thêm nữa ?"))
                        {
                            var listKhachHang = db.KhachHang.Where(x => x.TenKhachHang == tenKhachHang && x.Xoa == false).ToList();
                            selectKhachHang.EditValue = listKhachHang.First().MaKhachHang;
                            txtKhachHangMoi.Text = "";
                            return false;
                        }                            
                    }
                    KhachHang kh = new KhachHang();
                    kh.TenKhachHang = tenKhachHang;
                    kh.DiaChi = txtDiaChi.Text;
                    kh.DienThoai = txtDienThoai.Text;
                    if (checkboxNhaCungCap.CheckState == CheckState.Checked)
                    {
                        kh.LaNhaCungCap = true;
                    }
                    else
                    {
                        kh.LaNhaCungCap = false;
                    }
                    db.KhachHang.Add(kh);
                    db.SaveChanges();
                    loadselectKhachHang();
                    selectKhachHang.EditValue = kh.MaKhachHang;
                    txtKhachHangMoi.Text = "";
                    return true;
                }
                else
                {
                    int maKhachHang = int.Parse(selectKhachHang.EditValue.ToString());
                    KhachHang kh = db.KhachHang.Find(maKhachHang);
                    kh.DiaChi = txtDiaChi.Text;
                    kh.DienThoai = txtDienThoai.Text;
                    if (checkboxNhaCungCap.CheckState == CheckState.Checked)
                    {
                        kh.LaNhaCungCap = true;
                    }
                    else
                    {
                        kh.LaNhaCungCap = false;
                    }
                    db.SaveChanges();
                }
                return true;
            } catch (Exception ex)
            {
                ThMessageBox.ShowSystemError(ex.Message);
                return false;
            }
            
        }
        private bool kiemtraKhachHangdaTonTai(string tenKhachHang)
        {
            try
            {
                var listKhachHang = db.KhachHang.Where(x => x.TenKhachHang == tenKhachHang && x.Xoa == false).ToList();
                if (listKhachHang.Any()) return true;
            } catch (Exception ex)
            {
                ThMessageBox.ShowSystemError(ex.Message);
                return false;
            }
            return false;
        }

        private void btnBoTrong_Click(object sender, EventArgs e)
        {
            selectKhachHang.EditValue = null;
            txtKhachHangMoi.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            checkboxNhaCungCap.CheckState = CheckState.Unchecked;
        }

        private void selectKhachHang_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                int maKhachHang = int.Parse(selectKhachHang.EditValue.ToString());
                var kh = db.KhachHang.Find(maKhachHang);
                txtDiaChi.Text = kh.DiaChi;
                txtDienThoai.Text = kh.DienThoai;
                if (kh.LaNhaCungCap)
                {
                    checkboxNhaCungCap.CheckState = CheckState.Checked;
                } else
                {
                    checkboxNhaCungCap.CheckState = CheckState.Unchecked;
                }

            }
            catch { }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemHang_Click(object sender, EventArgs e)
        {
            
            if (selectKho.EditValue == null)
            {
                ThMessageBox.ShowError("Chưa chọn kho");
                return;
            }

            FormChonSanPham f = new FormChonSanPham();
            f.txtKho.Text = selectKho.Text;
            f.txtLoaiPhieu.Text = selectLoaiPhieu.Text;
            f.maLoaiPhieu = selectLoaiPhieu.EditValue.ToString();
            f.ShowDialog();
            if (f.boQua == true)
            {
                return;
            }
            int selectedMaSanPham = f.selectedMaSanPham;
            
            if (selectedMaSanPham == 0)
            {
                ThMessageBox.ShowError("Chưa chọn được sản phẩm, vui lòng chọn lại");
                return;
            }

            // lấy sẩn phẩm load lên gcSanPham
            if (listSanPhamDaChon.Exists(x => x.MaSanPham == selectedMaSanPham))
            {
                ThMessageBox.Show("Sản phẩm này đã chọn rồi");
                return;
            }
            var sanPham = db.SanPham.Find(selectedMaSanPham);
            DataRow row = dtSanPhamDangChon.NewRow();
            row["STT"] = dtSanPhamDangChon.Rows.Count + 1;
            row["TenSanPham"] = sanPham.TenSanPham;
            row["DonViTinh"] = sanPham.DonViTinh;
            row["DonGia"] = sanPham.GiaNhap;
            row["SoLuong"] = 1;
            row["ThanhTien"] = sanPham.GiaNhap;
            dtSanPhamDangChon.Rows.Add(row);

            gcSanPham.RefreshDataSource();
            gcSanPham.DataSource = dtSanPhamDangChon;



        }

        private void selectLoaiPhieu_EditValueChanged(object sender, EventArgs e)
        {
            string loaiPhieu = selectLoaiPhieu.EditValue.ToString();
            loadselectHinhThuc(loaiPhieu);
        }

        private void gvSanPham_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            int soLuong = int.Parse(gvSanPham.GetFocusedRowCellValue("SoLuong").ToString());
            int donGia = int.Parse(gvSanPham.GetFocusedRowCellValue("DonGia").ToString());
            gvSanPham.SetFocusedRowCellValue("ThanhTien", soLuong * donGia);
        }
    }
}