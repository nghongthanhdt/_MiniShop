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
                                    case when current.dmbenhnhan.gioitinh = 0  then 'Nam' else 'Nữ' end as gioitinh,
                                    current.dmthebhyt.mathe,
                                    current.dmbenhnhan.diachi                                    
                                from current.dmbenhnhan left join current.dmthebhyt on current.dmbenhnhan.mabn = current.dmthebhyt.mabn
                                        
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
                                    dangky.thangkt || '/' || dangky.namkt as thangkt, khambenh.ngaykcb,
                                    dangky.makb, khambenh.maba, khambenh.maphong, 

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
                                    where dangky.xoa = 0
                                    and khambenh.mabn = '"+mabn+@"' order by thangkt desc, makb desc   
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
                txtDiaChi.Text = gvBenhNhan.GetFocusedRowCellValue("diachi").ToString();
                loadgcLuotKham(maBenhNhan);
            }
            catch (Exception ex)
            {
                //ThMessageBox.ShowSystemError(ex.Message);
            }
        }
    }
}