using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TH.Core.Forms;


namespace TH.InSTTVLTL
{
    public partial class FormCauHinh : Form
    {
        InSTTVLTLEntities db = new InSTTVLTLEntities();
        public FormCauHinh()
        {
            InitializeComponent();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtTenVLTL.Text = "";
            txtSTT.Text = "";
        }

        private void FormCauHinh_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            loadgcVLTL();
            loadTenBenhVien();
        }
        private void loadTenBenhVien()
        {
            try
            {
                txtTenBenhVien.Text = db.ThamSo.Find("tenbenhvien").GiaTri;
                txtTenMayIn.Text = db.ThamSo.Find("tenmayin").GiaTri;
            }
            catch (Exception ex)
            {
                ThMessageBox.ShowSystemError(ex.Message);
            }

        }

        private void loadgcVLTL()
        {
            var listVLTL = db.VLTL.OrderBy(x => x.STT).ToList();
            gcVLTL.DataSource = listVLTL;
        }
        private void btnLuuVLTL_Click(object sender, EventArgs e)
        {
            if (txtTenVLTL.Text == "")
            {
                ThMessageBox.ShowError("Nhập tên VLTL");
                return;
            }
            try
            {
                if (txtID.Text == "")
                {
                    VLTL vltl = new VLTL();
                    int stt = 1;
                    try { stt = int.Parse(txtSTT.Text); } catch { };
                    vltl.STT = stt;
                    vltl.TenVLTL = txtTenVLTL.Text;
                    vltl.SoHienTai = 0;
                    db.VLTL.Add(vltl);
                    db.SaveChanges();
                } else
                {
                    int id = int.Parse(txtID.Text);
                    int stt = 1;
                    try
                    {
                        stt = int.Parse(txtSTT.Text);
                    } catch { }                        
                    VLTL vltl = db.VLTL.Find(id);
                    vltl.TenVLTL = txtTenVLTL.Text;
                    vltl.STT = stt;
                    db.SaveChanges();
                }
                loadgcVLTL();
                txtSTT.Text = "";
                txtTenVLTL.Text = "";
                txtID.Text = "";
                
                
            } catch (Exception ex)
            {
                ThMessageBox.ShowSystemError(ex.Message);
            }
            
        }

        private void gcVLTL_Click(object sender, EventArgs e)
        {
            string id = gvVLTL.GetFocusedRowCellValue("ID").ToString();
            txtID.Text = id;
            txtSTT.Text = gvVLTL.GetFocusedRowCellValue("STT").ToString();
            txtTenVLTL.Text = gvVLTL.GetFocusedRowCellValue("TenVLTL").ToString();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (ThMessageBox.ShowConfirm("Bạn thật sự muốn xóa ?"))
            {
                if (txtID.Text == "")
                {
                    ThMessageBox.ShowError("Bạn chưa chọn dòng nào");
                    return;
                } else
                {
                    try
                    {
                        int id = int.Parse(gvVLTL.GetFocusedRowCellValue("ID").ToString());
                        VLTL vltl = db.VLTL.Find(id);
                        db.VLTL.Remove(vltl);
                        db.SaveChanges();
                        loadgcVLTL();
                        txtSTT.Text = "";
                        txtTenVLTL.Text = "";
                        txtID.Text = "";
                    } catch (Exception ex)
                    {
                        ThMessageBox.ShowError(ex.Message);
                    }                    
                }
            }
        }

        private void btnLuuCauHinh_Click(object sender, EventArgs e)
        {
            try
            {
                ThamSo ts = db.ThamSo.Find("tenbenhvien");
                ts.GiaTri = txtTenBenhVien.Text;
                ThamSo ts2 = db.ThamSo.Find("tenmayin");
                ts2.GiaTri = txtTenMayIn.Text;
                db.SaveChanges();
                ThMessageBox.Show("Lưu dữ liệu thành công");
            } catch (Exception ex)
            {
                ThMessageBox.ShowSystemError(ex.Message);
            }
            
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
