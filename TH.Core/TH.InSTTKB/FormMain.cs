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
using Hotkeys;
using Microsoft.Win32;

namespace TH.InSTTKB
{
    public partial class FormMain : DevExpress.XtraEditors.XtraForm
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        private Hotkeys.GlobalHotkey ghk0;
        private Hotkeys.GlobalHotkey ghk1;
        private Hotkeys.GlobalHotkey ghk2;
        private Hotkeys.GlobalHotkey ghk3;
        private Hotkeys.GlobalHotkey ghk4;
        private Hotkeys.GlobalHotkey ghk5;
        private Hotkeys.GlobalHotkey ghk6;
        private Hotkeys.GlobalHotkey ghk7;
        private Hotkeys.GlobalHotkey ghk8;
        private Hotkeys.GlobalHotkey ghk9;
        string _configPath = "configSTT.xml";
        private void HandleHotkey(string code)
        {
            string nut = "";
            switch (code)
            {
                case "6291456":
                    nut = "0";
                    break;
                case "6356992":
                    nut = "1";
                    break;
                case "6422528":
                    nut = "2";
                    break;
                case "6488064":
                    nut = "3";
                    break;
                case "6553600":
                    nut = "4";
                    break;
                case "6619136":
                    nut = "5";
                    break;
                case "6684672":
                    nut = "6";
                    break;
                case "6750208":
                    nut = "7";
                    break;
                case "6815744":
                    nut = "8";
                    break;
                case "6881280":
                    nut = "9";
                    break;
                default:
                    break;

            }                
            batSo(nut);
        }
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Hotkeys.Constants.WM_HOTKEY_MSG_ID)
                HandleHotkey(m.LParam.ToString());
            base.WndProc(ref m);
        }        
        ConfigBatSoTT config = new ConfigBatSoTT();
        public FormMain()
        {
            InitializeComponent();
            ghk0 = new Hotkeys.GlobalHotkey(Constants.NOMOD, Keys.NumPad0, this);
            ghk1 = new Hotkeys.GlobalHotkey(Constants.NOMOD, Keys.NumPad1, this);
            ghk2 = new Hotkeys.GlobalHotkey(Constants.NOMOD, Keys.NumPad2, this);
            ghk3 = new Hotkeys.GlobalHotkey(Constants.NOMOD, Keys.NumPad3, this);
            ghk4 = new Hotkeys.GlobalHotkey(Constants.NOMOD, Keys.NumPad4, this);
            ghk5 = new Hotkeys.GlobalHotkey(Constants.NOMOD, Keys.NumPad5, this);
            ghk6 = new Hotkeys.GlobalHotkey(Constants.NOMOD, Keys.NumPad6, this);
            ghk7 = new Hotkeys.GlobalHotkey(Constants.NOMOD, Keys.NumPad7, this);
            ghk8 = new Hotkeys.GlobalHotkey(Constants.NOMOD, Keys.NumPad8, this);
            ghk9 = new Hotkeys.GlobalHotkey(Constants.NOMOD, Keys.NumPad9, this);
        }                                                                        
        private void FormMain_Load(object sender, EventArgs e)
        {
            loadConfigSTT();
            if (config.ThoiDiemReset < DateTime.Now)
            {
                resetSoHienTai();
                DateTime dt = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day).AddHours(12);
                config.ThoiDiemReset = dt;
                SaveConfigToXMLFile(config, _configPath);
            }
            if (config.ThoiDiemReset < DateTime.Now)
            {
                resetSoHienTai();
                config.ThoiDiemReset = config.ThoiDiemReset.AddHours(12);                        
                SaveConfigToXMLFile(config, _configPath);
            }
            loadConfigSTT();
            if (!ghk0.Register()) ThMessageBox.ShowSystemError("Lỗi các nút bấm, vui lòng liên hệ quản trị."); 
            ghk1.Register(); 
            ghk2.Register(); 
            ghk3.Register(); 
            ghk4.Register(); 
            ghk5.Register(); 
            ghk6.Register(); 
            ghk7.Register(); 
            ghk8.Register(); 
            ghk9.Register(); 
            setAutoStart();
        }
        private void btnCauHinh_Click(object sender, EventArgs e)
        {
            FormCauHinh f = new FormCauHinh();
            timerMain.Stop();
            f.ShowDialog();
            timerMain.Start();
            txtNutNhap.Focus();
            loadConfigSTT();
        } 
        private void btnThoat_Click(object sender, EventArgs e)
        {
            timerMain.Stop();
            if (ThMessageBox.ShowConfirm("Bạn thật sự muốn thoát ?"))
                this.Close();
            else timerMain.Start();
        }
        private void resetSoHienTai()
        {                   
            foreach (var stt in config.listSTT)
            {
                stt.SoHienTai = 0;
                stt.NgayGioIn = DateTime.MinValue;               
            }            
            SaveConfigToXMLFile(config,_configPath);            
        }
        private void loadConfigSTT()
        {
            config = LoadXMLToConfigBatSoTT(_configPath);   
            lblTenBenhVien.Text = config.TenBenhVien;
            if (lblTenBenhVien.Text == "")
            {
                lblTenBenhVien.Text = "[Chưa cấu hình]";
            }
            DataTable dt = new DataTable();
            dt.Columns.Add("Nut", typeof(int));
            dt.Columns.Add("TenNut", typeof(string));
            dt.Columns.Add("SoHienTai", typeof(int));
            dt.Columns.Add("NgayGioIn", typeof(string));
            DataRow row;
            var listSTT = config.listSTT.Where(x => x.TenNut != "").ToList();
            foreach (var item in listSTT)
            {
                row = dt.NewRow();
                row["Nut"] = item.Nut;
                row["TenNut"] = item.TenNut;
                row["SoHienTai"] = item.SoHienTai;
                string ngayGioIn = (item.NgayGioIn != DateTime.MinValue) ? (item.NgayGioIn.ToString()) : "";
                row["NgayGioIn"] = ngayGioIn;
                dt.Rows.Add(row);
            }
            gcSTT.DataSource = dt;
            timerMain.Interval = 1000;
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
        private void FormMain_Shown(object sender, EventArgs e)
        {
            txtNutNhap.Focus();
        }
        private void lblTenBenhVien_Click(object sender, EventArgs e)
        {

        }
        private void batSo(string nut)
        {
            switch (nut)
            {
                case "0":
                    //txtNutNhap.Focus();

                    
                    config.listSTT.Where(x => x.Nut == 1).First().SoHienTai++;
                    config.listSTT.Where(x => x.Nut == 1).First().NgayGioIn = DateTime.Now;
                    
                    break;
                case "1":
                    
                    config.listSTT.Where(x => x.Nut == 2).First().SoHienTai++;
                    config.listSTT.Where(x => x.Nut == 2).First().NgayGioIn = DateTime.Now;
                    
                    break;
                case "2":                    
                    
                    config.listSTT.Where(x => x.Nut == 3).First().SoHienTai++;
                    config.listSTT.Where(x => x.Nut == 3).First().NgayGioIn = DateTime.Now;
                    
                    break;
                case "3":                    
                    
                    config.listSTT.Where(x => x.Nut == 4).First().SoHienTai++;
                    config.listSTT.Where(x => x.Nut == 4).First().NgayGioIn = DateTime.Now;
                    
                    break;
                case "4":                    
                    
                    config.listSTT.Where(x => x.Nut == 5).First().SoHienTai++;
                    config.listSTT.Where(x => x.Nut == 5).First().NgayGioIn = DateTime.Now;
                    
                    break;
                case "5":                    
                    
                    config.listSTT.Where(x => x.Nut == 6).First().SoHienTai++;
                    config.listSTT.Where(x => x.Nut == 6).First().NgayGioIn = DateTime.Now;
                    
                    break;
                case "6":                    
                    
                    config.listSTT.Where(x => x.Nut == 7).First().SoHienTai++;
                    config.listSTT.Where(x => x.Nut == 7).First().NgayGioIn = DateTime.Now;
                    
                    break;
                case "7":                    
                    
                    config.listSTT.Where(x => x.Nut == 8).First().SoHienTai++;
                    config.listSTT.Where(x => x.Nut == 8).First().NgayGioIn = DateTime.Now;
                    
                    break;
                case "8":                    
                    
                    config.listSTT.Where(x => x.Nut == 9).First().SoHienTai++;
                    config.listSTT.Where(x => x.Nut == 9).First().NgayGioIn = DateTime.Now;
                    
                    break;
                case "9":                    
                    
                    config.listSTT.Where(x => x.Nut == 10).First().SoHienTai++;
                    config.listSTT.Where(x => x.Nut == 10).First().NgayGioIn = DateTime.Now;
                    
                    break;
                default:                    
                    break;
                    
            }
            SaveConfigToXMLFile(config, _configPath);
            loadConfigSTT();

        }
        private void timerMain_Tick(object sender, EventArgs e)
        {
            hienThiGioHienTai();
            txtNutNhap.Focus();
            this.Activate();
            this.WindowState = FormWindowState.Normal;
        }
        private void hienThiGioHienTai()
        {
            txtThoiGian.Text = DateTime.Now.ToString();
        }    
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            ghk0.Unregiser();
            ghk1.Unregiser();
            ghk2.Unregiser();
            ghk3.Unregiser();
            ghk4.Unregiser();
            ghk5.Unregiser();
            ghk6.Unregiser();
            ghk7.Unregiser();
            ghk8.Unregiser();
            ghk9.Unregiser();                
        }
        private void txtNutNhap_TextChanged(object sender, EventArgs e)
        {
            batSo(txtNutNhap.Text);
            txtNutNhap.Text = "";
        }         
        private void setAutoStart()
        {
            string StartupKey = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";
            string StartupValue = "TH.InSTTKB";
            RegistryKey key = Registry.CurrentUser.OpenSubKey(StartupKey, true);
            key.SetValue(StartupValue, Application.ExecutablePath.ToString());
        }
        private void unsetAutoStart()
        {
            // chưa sử dụng
            try
            {
                string StartupKey = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";
                string StartupValue = "TH.InSTTKB";
                RegistryKey key = Registry.CurrentUser.OpenSubKey(StartupKey, true);
                key.DeleteValue(StartupValue);
            }
            catch { }

        }
    }
}
