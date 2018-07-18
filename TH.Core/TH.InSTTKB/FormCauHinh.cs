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
using System.Xml.Serialization;
using System.IO;

namespace TH.InSTTKB
{
    public partial class FormCauHinh : DevExpress.XtraEditors.XtraForm
    {
        string _configPath = "configSTT.xml";
        DateTime _configDateTime;
        public FormCauHinh()
        {
            InitializeComponent();
        }

        private void FormCauHinh_Load(object sender, EventArgs e)
        {

            txtTenBenhVien.Focus();
            modeLockForm();
            loadConfig();
        }

        private void modeLockForm()
        {
            txtTenBenhVien.Enabled = false;
            txtTenMayIn.Enabled = false;
            txtThoiGianCho.Enabled = false;
            txtNut1.Enabled = false;
            txtNut2.Enabled = false;
            txtNut3.Enabled = false;
            txtNut4.Enabled = false;
            txtNut5.Enabled = false;
            txtNut6.Enabled = false;
            txtNut7.Enabled = false;
            txtNut8.Enabled = false;
            txtNut9.Enabled = false;
            txtNut10.Enabled = false;

            txtSoHienTai_Nut1.Enabled = false;
            txtSoHienTai_Nut2.Enabled = false;
            txtSoHienTai_Nut3.Enabled = false;
            txtSoHienTai_Nut4.Enabled = false;
            txtSoHienTai_Nut5.Enabled = false;
            txtSoHienTai_Nut6.Enabled = false;
            txtSoHienTai_Nut7.Enabled = false;
            txtSoHienTai_Nut8.Enabled = false;
            txtSoHienTai_Nut9.Enabled = false;
            txtSoHienTai_Nut10.Enabled = false;

            btnCapNhat.Enabled = true;
            btnLuuCauHinh.Enabled = false;
            
        }
        private void modeUnlockForm()
        {
            txtTenBenhVien.Enabled = true;
            txtTenMayIn.Enabled = true;
            //txtThoiGianCho.Enabled = true;
            txtNut1.Enabled = true;
            txtNut2.Enabled = true;
            txtNut3.Enabled = true;
            txtNut4.Enabled = true;
            txtNut5.Enabled = true;
            txtNut6.Enabled = true;
            txtNut7.Enabled = true;
            txtNut8.Enabled = true;
            txtNut9.Enabled = true;
            txtNut10.Enabled = true;

            txtSoHienTai_Nut1.Enabled = true;
            txtSoHienTai_Nut2.Enabled = true;
            txtSoHienTai_Nut3.Enabled = true;
            txtSoHienTai_Nut4.Enabled = true;
            txtSoHienTai_Nut5.Enabled = true;
            txtSoHienTai_Nut6.Enabled = true;
            txtSoHienTai_Nut7.Enabled = true;
            txtSoHienTai_Nut8.Enabled = true;
            txtSoHienTai_Nut9.Enabled = true;
            txtSoHienTai_Nut10.Enabled = true;

            btnCapNhat.Enabled = false;
            btnLuuCauHinh.Enabled = true;
            
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            modeUnlockForm();
            txtTenBenhVien.Focus();
        }

        private void loadConfig()
        {
            ConfigBatSoTT config = new ConfigBatSoTT();
            config = LoadXMLToConfigBatSoTT(_configPath);
            txtTenBenhVien.Text = config.TenBenhVien;
            txtTenMayIn.Text = config.TenMayIn;
            txtThoiGianCho.Text = "1";
            try
            {
                txtNut1.Text = config.listSTT.Where(x => x.Nut == 1).First().TenNut;
                txtNut2.Text = config.listSTT.Where(x => x.Nut == 2).First().TenNut;
                txtNut3.Text = config.listSTT.Where(x => x.Nut == 3).First().TenNut;
                txtNut4.Text = config.listSTT.Where(x => x.Nut == 4).First().TenNut;
                txtNut5.Text = config.listSTT.Where(x => x.Nut == 5).First().TenNut;
                txtNut6.Text = config.listSTT.Where(x => x.Nut == 6).First().TenNut;
                txtNut7.Text = config.listSTT.Where(x => x.Nut == 7).First().TenNut;
                txtNut8.Text = config.listSTT.Where(x => x.Nut == 8).First().TenNut;
                txtNut9.Text = config.listSTT.Where(x => x.Nut == 9).First().TenNut;
                txtNut10.Text = config.listSTT.Where(x => x.Nut == 10).First().TenNut;

                txtSoHienTai_Nut1.Text = config.listSTT.Where(x => x.Nut == 1).First().SoHienTai.ToString();
                txtSoHienTai_Nut2.Text = config.listSTT.Where(x => x.Nut == 2).First().SoHienTai.ToString();
                txtSoHienTai_Nut3.Text = config.listSTT.Where(x => x.Nut == 3).First().SoHienTai.ToString();
                txtSoHienTai_Nut4.Text = config.listSTT.Where(x => x.Nut == 4).First().SoHienTai.ToString();
                txtSoHienTai_Nut5.Text = config.listSTT.Where(x => x.Nut == 5).First().SoHienTai.ToString();
                txtSoHienTai_Nut6.Text = config.listSTT.Where(x => x.Nut == 6).First().SoHienTai.ToString();
                txtSoHienTai_Nut7.Text = config.listSTT.Where(x => x.Nut == 7).First().SoHienTai.ToString();
                txtSoHienTai_Nut8.Text = config.listSTT.Where(x => x.Nut == 8).First().SoHienTai.ToString();
                txtSoHienTai_Nut9.Text = config.listSTT.Where(x => x.Nut == 9).First().SoHienTai.ToString();
                txtSoHienTai_Nut10.Text = config.listSTT.Where(x => x.Nut == 10).First().SoHienTai.ToString();
            }
            catch { }
            
        }
        private void saveConfig()
        {
            try
            {

                try
                {                    
                    if (int.Parse(txtThoiGianCho.Text) < 1)
                    {
                        MessageBox.Show("Thời gian chờ ít nhất 1 giây, vui lòng nhập lại");
                        return;
                    }
                } catch
                {
                    MessageBox.Show("Sai thời gian chờ, vui lòng kiểm tra lại");
                    return;
                }

                ConfigBatSoTT config = new ConfigBatSoTT();
                config.TenBenhVien = txtTenBenhVien.Text;
                config.TenMayIn = txtTenMayIn.Text;
                config.ThoiGianCho = int.Parse(txtThoiGianCho.Text);
                config.ThoiDiemReset = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day).AddHours(12);
                

                
                List<STT> listSTT = new List<STT>();
                STT stt;
                //
                stt = new STT();
                stt.Nut = 1;
                stt.TenNut = txtNut1.Text;
                stt.SoHienTai = int.Parse(txtSoHienTai_Nut1.Text);
                stt.NgayGioIn = DateTime.MinValue;
                listSTT.Add(stt);
                //
                stt = new STT();
                stt.Nut = 2;
                stt.TenNut = txtNut2.Text;
                stt.SoHienTai = int.Parse(txtSoHienTai_Nut2.Text);
                stt.NgayGioIn = DateTime.MinValue;
                listSTT.Add(stt);
                //
                stt = new STT();
                stt.Nut = 3;
                stt.TenNut = txtNut3.Text;
                stt.SoHienTai = int.Parse(txtSoHienTai_Nut3.Text);
                stt.NgayGioIn = DateTime.MinValue;
                listSTT.Add(stt);
                //
                stt = new STT();
                stt.Nut = 4;
                stt.TenNut = txtNut4.Text;
                stt.SoHienTai = int.Parse(txtSoHienTai_Nut4.Text);
                stt.NgayGioIn = DateTime.MinValue;
                listSTT.Add(stt);
                //
                stt = new STT();
                stt.Nut = 5;
                stt.TenNut = txtNut5.Text;
                stt.SoHienTai = int.Parse(txtSoHienTai_Nut5.Text);
                stt.NgayGioIn = DateTime.MinValue;
                listSTT.Add(stt);
                //
                stt = new STT();
                stt.Nut = 6;
                stt.TenNut = txtNut6.Text;
                stt.SoHienTai = int.Parse(txtSoHienTai_Nut6.Text);
                stt.NgayGioIn = DateTime.MinValue;
                listSTT.Add(stt);
                //
                stt = new STT();
                stt.Nut = 7;
                stt.TenNut = txtNut7.Text;
                stt.SoHienTai = int.Parse(txtSoHienTai_Nut7.Text);
                stt.NgayGioIn = DateTime.MinValue;
                listSTT.Add(stt);
                //
                stt = new STT();
                stt.Nut = 8;
                stt.TenNut = txtNut8.Text;
                stt.SoHienTai = int.Parse(txtSoHienTai_Nut8.Text); 
                stt.NgayGioIn = DateTime.MinValue;
                listSTT.Add(stt);
                //
                stt = new STT();
                stt.Nut = 9;
                stt.TenNut = txtNut9.Text;
                stt.SoHienTai = int.Parse(txtSoHienTai_Nut9.Text);
                stt.NgayGioIn = DateTime.MinValue;
                listSTT.Add(stt);
                //
                stt = new STT();
                stt.Nut = 10;
                stt.TenNut = txtNut10.Text;
                stt.SoHienTai = int.Parse(txtSoHienTai_Nut10.Text);
                stt.NgayGioIn = DateTime.MinValue;
                listSTT.Add(stt);
                //
                config.listSTT = listSTT;
                SaveConfigToXMLFile(config, _configPath);
                ThMessageBox.Show("Đã lưu cấu hình");
                modeLockForm();
            } catch (Exception ex)
            {
                ThMessageBox.ShowSystemError(ex.Message);
            }
            
        }

        private void btnLuuCauHinh_Click(object sender, EventArgs e)
        {
            saveConfig();
        }

        public static void SaveConfigToXMLFile(ConfigBatSoTT obj, string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ConfigBatSoTT));
            TextWriter writer = new StreamWriter(path);
            serializer.Serialize(writer, obj);
            writer.Close();
        }
        public static ConfigBatSoTT LoadXMLToConfigBatSoTT(string path)
        {
            ConfigBatSoTT config;// = new ConfigBatSoTT();
            XmlSerializer serializer = new XmlSerializer(typeof(ConfigBatSoTT));
            TextReader reader = new StreamReader(path);
            config = (ConfigBatSoTT)serializer.Deserialize(reader);
            reader.Close();
            return config;
        }

    }
}