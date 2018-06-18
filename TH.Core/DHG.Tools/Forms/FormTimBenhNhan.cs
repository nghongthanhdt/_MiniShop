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
using Npgsql;
using TH.Core.Forms;

namespace DHG.Tools.Forms
{
    public partial class FormTimBenhNhan : DevExpress.XtraEditors.XtraForm
    {
        public NpgsqlConnection connection;
        public FormTimBenhNhan()
        {
            InitializeComponent();
        }

        private void FormTimBenhNhan_Load(object sender, EventArgs e)
        {
            btnXem.PerformClick();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            try
            {
                connectOpen();
                string query = @"select 
                                    current.dmbenhnhan.mabn, 
                                    current.dmbenhnhan.holot || ' ' || current.dmbenhnhan.ten as hoten, 
                                    current.dmbenhnhan.ngaysinh,
                                    case when current.dmbenhnhan.gioitinh = '1'  then 'Nam' when current.dmbenhnhan.gioitinh = '0' then 'Nữ' end as gioitinh,
                                    current.dmthebhyt.mathe,
                                    current.dmbenhnhan.diachi,
                                    current.dmthebhyt.mabvdk,                                    
                                    current.dmbenhvien.tenbv
                                    
                                from current.dmbenhnhan 
                                    left join current.dmthebhyt on current.dmbenhnhan.mabn = current.dmthebhyt.mabn
                                    left join current.dmbenhvien on current.dmthebhyt.mabvdk = current.dmbenhvien.mabv
                                        
                                ";
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                gcBenhNhan.DataSource = dt;
                connectClose();
            } catch (Exception ex)
            {
                ThMessageBox.ShowSystemError(ex.Message);
            }
            
            
        }
        private void connectOpen()
        {
            if (connection.State == ConnectionState.Closed) connection.Open();
        }
        private void connectClose()
        {
            connection.Close();
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void loadgcLuotKham(string mabn)
        {
            DataTable dt = new DataTable();
            try
            {
                connectOpen();
                string query = @"

                                select
                                    dangky.thangkt || '/' || dangky.namkt as thangkt, 
                                    khambenh.ngaykcb,
                                    khambenh.makb, 
                                    dangky.mabvdk, 
                                    benhvien.tenbv,
                                    dangky.giaycv,
                                    case 
                                        
                                        when dangky.mabvdk = '87164' then 'Cùng tuyến' 
                                        when dangky.mabvdk <> '87164' and dangky.manoigt <> '' then 'Cùng tuyến' 
                                        when dangky.mabvdk <> '87164' and dangky.manoigt = '' then 'Trái tuyến'
                                        else ''
                                    end as cungtuyentraituyen,
                                    dangky.taikhoan,
                                    nhanviennhap.holot || ' ' || nhanviennhap.ten as tennhanviennhap,
                                    nhanvienkham.holot || ' ' || nhanvienkham.ten as tennhanvienkham,
                                    bacsikham.holot || ' ' || bacsikham.ten as tenbacsikham,
                                    dangky.manoigt,
                                    dangky.noigt,
                                    khambenh.maba, 
                                    khambenh.maphong, 
                                    bnnoitru.ngayvv,
                                    bnnoitru.ngayrv,
                                    donvi.tendv,
                                    case 
                                        when chuyenvien.xoa = '1' then chuyenvien.socv || ' ( ' || chuyenvien.taikhoan || ' đã xóa) '
                                        else chuyenvien.socv
                                    end as socv,
                                    chuyenvien.mabv as mabvcv,
                                    benhvienchuyenvien.tenbv as tenbvcv,
                                    case 
                                        when khambenh.dakham = 5 then 'Nội trú'
                                        when khambenh.maba <> '' then 'Ngoại trú'
	                                    when khambenh.dakham = 0 then 'Chưa khám'
                                        when khambenh.dakham = 1 then 'Đã khám'
                                        when khambenh.dakham = 2 then 'Cho CLS'
                                        when khambenh.dakham = 3 then 'Cấp toa'
                                        when khambenh.dakham = 4 then 'Đang chỉnh'                                        
                                        when khambenh.dakham = 6 then 'Chuyển viện'
                                    end as xutri
                                    from current.psdangky as dangky
                                    left join current.khambenh as khambenh on dangky.makb = khambenh.makb
                                    left join current.dmbenhvien as benhvien on dangky.mabvdk = benhvien.mabv
                                    left join current.dmnhanvien as nhanviennhap on dangky.taikhoan = nhanviennhap.taikhoan
                                    left join current.dmnhanvien as nhanvienkham on khambenh.taikhoan = nhanvienkham.taikhoan
                                    left join current.dmnhanvien as bacsikham on khambenh.manv = bacsikham.manv
                                    left join current.bnnoitru as bnnoitru on khambenh.makb = bnnoitru.makb
                                    left join current.dmdonvi as donvi on bnnoitru.madv = donvi.madv
                                    left join current.chuyenvien as chuyenvien on khambenh.makb = chuyenvien.makb
                                    left join current.dmbenhvien as benhvienchuyenvien on chuyenvien.mabv = benhvienchuyenvien.mabv
                                    where dangky.xoa = 0
                                    
                                    and khambenh.mabn = '" + mabn+@"' order by thangkt desc, makb desc   
                                ";
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection);
                adapter.Fill(dt);
                gcLuotKham.DataSource = dt;
                
                connectClose();
            }
            catch (Exception ex)
            {
                ThMessageBox.ShowSystemError(ex.Message);
            }
        }

        private void gvBenhNhan_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                string maBenhNhan = gvBenhNhan.GetFocusedRowCellValue("mabn").ToString();
                txtMaBN.Text = maBenhNhan;
                txtHoTen.Text = gvBenhNhan.GetFocusedRowCellValue("hoten").ToString();
                txtNgaySinh.Text = gvBenhNhan.GetFocusedRowCellValue("ngaysinh").ToString();
                txtGioiTinh.Text = gvBenhNhan.GetFocusedRowCellValue("gioitinh").ToString();
                txtMaTheBHYT.Text = gvBenhNhan.GetFocusedRowCellValue("mathe").ToString();
                txtMaNoiDK.Text = gvBenhNhan.GetFocusedRowCellValue("mabvdk").ToString();
                txtTenNoiDK.Text = gvBenhNhan.GetFocusedRowCellValue("tenbv").ToString();
                txtDiaChi.Text = gvBenhNhan.GetFocusedRowCellValue("diachi").ToString();

                
                
                loadgcLuotKham(maBenhNhan);
                clearTextBoxLuotKham();
            }
            catch (Exception ex)
            {
                //ThMessageBox.ShowSystemError(ex.Message);
            }
        }

        private void gcBenhNhan_Click(object sender, EventArgs e)
        {

        }

        private void gvLuotKham_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            
            
        }
        private void loadTextBoxLuotKham()
        {
            txtMaKB.Text = gvLuotKham.GetFocusedRowCellValue("makb").ToString();
            txtMaPhong.Text = gvLuotKham.GetFocusedRowCellValue("maphong").ToString();
            txtNgayKB.Text = gvLuotKham.GetFocusedRowCellValue("ngaykcb").ToString();
            if (txtMaTheBHYT.Text != "")
            {
                txtCungTuyenTraiTuyen.Text = gvLuotKham.GetFocusedRowCellValue("cungtuyentraituyen").ToString();
            } else
            {
                txtCungTuyenTraiTuyen.Text = "";
            }
            
            txtMaNoiGT.Text = gvLuotKham.GetFocusedRowCellValue("manoigt").ToString();
            txtNoiGT.Text = gvLuotKham.GetFocusedRowCellValue("noigt").ToString();
            txtTenNhanVienNhap.Text = gvLuotKham.GetFocusedRowCellValue("tennhanviennhap").ToString();
            txtTenNhanVienKham.Text = gvLuotKham.GetFocusedRowCellValue("tennhanvienkham").ToString();
            txtTenBacSiKham.Text = gvLuotKham.GetFocusedRowCellValue("tenbacsikham").ToString();
            if (gvLuotKham.GetFocusedRowCellValue("manoigt").ToString() != "")
            {
                checkboxCoGiayGioiThieu.CheckState = CheckState.Checked;
            } else
            {
                checkboxCoGiayGioiThieu.CheckState = CheckState.Unchecked;
            }
            
            string maBA = gvLuotKham.GetFocusedRowCellValue("maba").ToString();
            if (maBA != "")
            {
                if (maBA.Contains('N'))
                {
                    txtLoaiNhapVien.Text = "Ngoại trú";
                }
                else
                {
                    txtLoaiNhapVien.Text = "Nội trú";
                }
            } else
            {
                txtLoaiNhapVien.Text = "";
            }
            
            txtMaBA.Text = maBA;
            txtTenKhoaDieuTri.Text = gvLuotKham.GetFocusedRowCellValue("tendv").ToString();
            txtNgayVV.Text = gvLuotKham.GetFocusedRowCellValue("ngayvv").ToString();
            txtNgayRV.Text = gvLuotKham.GetFocusedRowCellValue("ngayrv").ToString();

            txtSoChuyenVien.Text = gvLuotKham.GetFocusedRowCellValue("socv").ToString();
            txtMaBenhVienChuyenVien.Text = gvLuotKham.GetFocusedRowCellValue("mabvcv").ToString();
            txtTenBenhVienChuyenVien.Text = gvLuotKham.GetFocusedRowCellValue("tenbvcv").ToString();

        }
        private void clearTextBoxLuotKham()
        {
            txtMaKB.Text = "";
            txtMaPhong.Text = "";
            txtNgayKB.Text = "";
            txtMaNoiGT.Text = "";
            txtNoiGT.Text = "";
            txtTenNhanVienNhap.Text = "";
            txtTenNhanVienKham.Text = "";
            txtTenBacSiKham.Text = "";
            txtMaBA.Text = "";
            txtNgayVV.Text = "";
            txtNgayRV.Text = "";
            txtCungTuyenTraiTuyen.Text = "";
            checkboxCoGiayGioiThieu.CheckState = CheckState.Unchecked;
            txtLoaiNhapVien.Text = "";
            txtMaBA.Text = "";
            txtTenKhoaDieuTri.Text = "";
            txtSoChuyenVien.Text = "";
            txtMaBenhVienChuyenVien.Text = "";
            txtTenBenhVienChuyenVien.Text = "";
        }

        private void gcLuotKham_Click(object sender, EventArgs e)
        {
            loadTextBoxLuotKham();
        }
    }
}