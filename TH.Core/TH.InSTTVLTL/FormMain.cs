using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using TH.Core.Forms;

namespace TH.InSTTVLTL
{
    public partial class FormMain : DevExpress.XtraEditors.XtraForm
    {
        InSTTVLTLEntities db = new InSTTVLTLEntities();
        string TenBenhVien = "";
        string NgayHienTai = "";
        string TenMayIn = "";
        public FormMain()
        {
            InitializeComponent();
        }



        private void btnCauHinh_Click(object sender, EventArgs e)
        {
            FormCauHinh f = new FormCauHinh();
            f.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInSo_Click(object sender, EventArgs e)
        {
            timerLamMoi.Stop();
            inSo();            
            loadgcVLTL();
            timerLamMoi.Start();
        }
        private void inSo()
        {
            int[] selectedIndexs = gvVLTL.GetSelectedRows();
            if (selectedIndexs.Length == 0)
            {
                ThMessageBox.ShowError("Chưa chọn dòng cần in");
                return;
            }
            foreach (int i in selectedIndexs)
            {

                VLTL _vltl = (VLTL)gvVLTL.GetRow(i);
                int id = _vltl.ID;
                var vltl = db.VLTL.Find(id);
                vltl.SoHienTai++;
                vltl.NgayIn = DateTime.Now;
                
                if (TenMayIn == "XP-80C")
                {
                    // máy in Xprinter
                    ReportSTT_Xprinter rp = new ReportSTT_Xprinter();
                    rp.lblTenBenhVien.Text = TenBenhVien;
                    rp.lblTenVLTL.Text = vltl.TenVLTL;
                    rp.lblSTT.Text = vltl.SoHienTai.ToString();
                    rp.lblNgay.Text = vltl.NgayIn.ToString();

                    rp.ShowPrintMarginsWarning = false;
                    try
                    {
                        using (ReportPrintTool printTool = new ReportPrintTool(rp))
                        {
                            printTool.PrinterSettings.PrinterName = TenMayIn;
                            printTool.Print();
                        }
                    }
                    catch
                    {
                        ThMessageBox.ShowError("Không thể kết nối máy in, vui lòng liên hệ quản trị.");
                    }

                }
                else
                {
                    ReportSTT rp = new ReportSTT();
                    rp.lblTenBenhVien.Text = TenBenhVien;
                    rp.lblTenVLTL.Text = vltl.TenVLTL;
                    rp.lblSTT.Text = vltl.SoHienTai.ToString();
                    rp.lblNgay.Text = vltl.NgayIn.ToString();

                    rp.ShowPrintMarginsWarning = false;
                    try
                    {
                        using (ReportPrintTool printTool = new ReportPrintTool(rp))
                        {
                            printTool.PrinterSettings.PrinterName = TenMayIn;
                            printTool.Print();
                        }
                    }
                    catch
                    {
                        ThMessageBox.ShowError("Không thể kết nối máy in, vui lòng liên hệ quản trị.");
                    }
                }
                
                // máy in cũ
                

                
                
                
            }
            db.SaveChanges();


            
        }
        
        private void FormMain_Load(object sender, EventArgs e)
        {
            try
            {
                using (InSTTVLTLEntities db = new InSTTVLTLEntities())
                {
                    
                    db.ThamSo.ToList();
                }
            }
            catch {
                ThMessageBox.Show("Chương trình bắt số không thể kết nối đến máy chủ, vui lòng liên hệ quản trị.");
                this.Close();
                return;
            }

            resetSoHienTaiTheoNgay();
            loadgcVLTL();
            loadTenBenhVien();
            timerLamMoi.Enabled = true;
            timerLamMoi.Start();
        }
        private void loadgcVLTL()
        {

            using (InSTTVLTL.InSTTVLTLEntities db2 = new InSTTVLTLEntities())
            {
                var listVLTL = db2.VLTL.OrderBy(x => x.STT).ToList();
                //gcVLTL.RefreshDataSource();
                gcVLTL.DataSource = null;
                gcVLTL.DataSource = listVLTL;
            }
            

            

        }
        private void loadTenBenhVien()
        {
            TenBenhVien = db.ThamSo.Find("tenbenhvien").GiaTri;
            NgayHienTai = db.ThamSo.Find("ngayhientai").GiaTri;
            //TenMayIn = db.ThamSo.Find("tenmayin").GiaTri;

            // load ten bv, ten may in

            LoadMayInFromXMLFile("configMayIn.xml");

        }

        private void gcVLTL_DoubleClick(object sender, EventArgs e)
        {
            timerLamMoi.Stop();
            int index = gvVLTL.FocusedRowHandle;
            if (!gvVLTL.IsRowSelected(index))
            {
                gvVLTL.SelectRow(index);
            }
            else gvVLTL.UnselectRow(index);
        }

        private void timerLamMoi_Tick(object sender, EventArgs e)
        {
            loadgcVLTL();
        }

        private void resetSoHienTaiTheoNgay()
        {
            ThamSo ts = db.ThamSo.Find("ngayhientai");

            string ngayHienTaiClient = DateTime.Now.ToString("dd/MM/yyyy");
            if (ts.GiaTri != ngayHienTaiClient)
            {
                ts.GiaTri = ngayHienTaiClient;
                using (InSTTVLTLEntities db2 = new InSTTVLTLEntities())
                {
                    var listVLTL = db2.VLTL.ToList();
                    foreach (var item in listVLTL)
                    {
                        item.SoHienTai = 0;
                        item.NgayIn = null;
                    }
                    db2.SaveChanges();
                }
                db.SaveChanges();
            }

        }

        private void gcVLTL_Click(object sender, EventArgs e)
        {
            timerLamMoi.Stop();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            timerLamMoi.Stop();
            timerLamMoi.Start();
            loadgcVLTL();
        }
        public void LoadMayInFromXMLFile(string path)
        {
            try
            {
                MayIn mayIn = new MayIn();
                XmlSerializer serializer = new XmlSerializer(typeof(MayIn));
                TextReader reader = new StreamReader(path);
                mayIn = (MayIn)serializer.Deserialize(reader);
                reader.Close();
                TenMayIn = mayIn.TenMayIn;
                //MessageBox.Show("Tên máy in: " + TenMayIn);
            }
            catch
            {
                ThMessageBox.ShowError("Chưa cấu hình máy in");
                //txtTenMayIn.Text = "<< lỗi cấu hình máy in >>";
            }

        }
    }
}
