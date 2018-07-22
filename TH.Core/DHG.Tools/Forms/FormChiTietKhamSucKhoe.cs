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
    public partial class FormChiTietKhamSucKhoe : DevExpress.XtraEditors.XtraForm
    {
        public NpgsqlConnection connection;
        public string makb = "";
        public FormChiTietKhamSucKhoe()
        {
            InitializeComponent();
        }

        private void FormChiTietKhamSucKhoe_Load(object sender, EventArgs e)
        {
            loadThongTinKSK();
        }

        private void loadThongTinKSK()
        {
            DataTable dtThuChi = new DataTable();
            try
            {
                connectOpen();
                string query = @"

                                select 
                                    makb,
                                    mabn,
                                    ngayct,
                                    lydo,
                                    nguoigiao,
                                    tongtien,
                                    khct,
                                    quyen,
                                    sobl,
                                    (nhanvien.holot || ' ' || nhanvien.ten) as nguoithu
                                from 
                                    current.thuchi as thuchi
                                    left join current.dmnhanvien as nhanvien on thuchi.taikhoan = nhanvien.taikhoan
                                where makb = '" + makb + @"'
                                    
                                ";
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection);
                adapter.Fill(dtThuChi);
                
                connectClose();
            }
            catch (Exception ex)
            {
                ThMessageBox.ShowSystemError(ex.Message);
            }


            DataTable dtCLS = new DataTable();
            try
            {
                connectOpen();
                string query = @"

                                select 
                                    chidinhcls.macls as MaCLS,
                                    chidinhcls.thanhtien as ThanhTien,
                                    dmcls.tencls as TenCLS
                                from 
                                    current.chidinhcls as chidinhcls
                                    left join current.dmcls as dmcls on chidinhcls.macls = dmcls.macls
                                where makb = '" + makb + @"'
                                    and dmcls.macha = ''
                                ";
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection);
                adapter.Fill(dtCLS);
                gcCLS.DataSource = dtCLS;
                connectClose();
            }
            catch (Exception ex)
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
    }
}