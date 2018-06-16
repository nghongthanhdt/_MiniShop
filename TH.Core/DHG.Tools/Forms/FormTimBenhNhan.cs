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
                                        else '' end as cungtuyentraituyen,
                                    dangky.taikhoan,
                                    nhanvien.holot || ' ' || nhanvien.ten as tennhanvien,
                                    dangky.manoigt,
                                    dangky.noigt,
                                    khambenh.maba, 
                                    khambenh.maphong, 
                                    dangky.ravien,
                                    dangky.ngayrv,
                                    case 
	                                    when khambenh.dakham = 0 then 'Chưa khám'
                                        when khambenh.dakham = 1 then 'Đã khám'
                                        when khambenh.dakham = 2 then 'Cho CLS'
                                        when khambenh.dakham = 3 then 'Cấp toa'
                                        when khambenh.dakham = 4 then 'Đang chỉnh'
                                        when khambenh.dakham = 5 then 'Nhập viện'
                                        when khambenh.dakham = 6 then 'Chuyển viện'
                                    end as xutri
                                    from current.psdangky as dangky
                                    left join current.khambenh as khambenh on dangky.makb = khambenh.makb

                                    left join current.dmbenhvien as benhvien on dangky.mabvdk = benhvien.mabv
                                    inner join current.dmnhanvien as nhanvien on dangky.taikhoan = nhanvien.taikhoan
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
            txtCungTuyenTraiTuyen.Text = gvLuotKham.GetFocusedRowCellValue("cungtuyentraituyen").ToString();
            txtMaNoiGT.Text = gvLuotKham.GetFocusedRowCellValue("manoigt").ToString();
            txtNoiGT.Text = gvLuotKham.GetFocusedRowCellValue("noigt").ToString();
            txtNhanVienNhap.Text = gvLuotKham.GetFocusedRowCellValue("tennhanvien").ToString();
            if (gvLuotKham.GetFocusedRowCellValue("manoigt").ToString() != "")
            {
                checkboxCoGiayGioiThieu.CheckState = CheckState.Checked;
            } else
            {
                checkboxCoGiayGioiThieu.CheckState = CheckState.Unchecked;
            }

            txtMaBA.Text = gvLuotKham.GetFocusedRowCellValue("maba").ToString();
            txtVaoVien.Text = gvLuotKham.GetFocusedRowCellValue("ngaykcb").ToString();
            txtNgayRV.Text = gvLuotKham.GetFocusedRowCellValue("ngayrv").ToString();
        }
        private void clearTextBoxLuotKham()
        {
            txtMaKB.Text = "";
            txtMaPhong.Text = "";
            txtNgayKB.Text = "";
            txtMaNoiGT.Text = "";
            txtNoiGT.Text = "";
            txtNhanVienNhap.Text = "";
            txtMaBA.Text = "";
            txtVaoVien.Text = "";
            txtNgayRV.Text = "";
        }

        private void gcLuotKham_Click(object sender, EventArgs e)
        {
            loadTextBoxLuotKham();
        }
    }
}