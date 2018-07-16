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

        private void HandleHotkey(string code)
        {

            //            MessageBox.Show(code);
            string nut = "";
            switch (code)
            {
                case "6291456":
                    nut = "0";
                    txtNutNhap.Focus();
                    txtNutNhap.Text = nut;
                    batSo(nut);
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
            ////MessageBox.Show("Hotkey pressed! " + nut);
            batSo(nut);

        }
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Hotkeys.Constants.WM_HOTKEY_MSG_ID)
                //HandleHotkey(m.LParam.ToString());
                HandleHotkey(m.LParam.ToString());
            base.WndProc(ref m);
        }

        string _configPath = "configSTT.xml";
        ConfigBatSoTT config = new ConfigBatSoTT();
        public FormMain()
        {
            InitializeComponent();
            //ghk = new Hotkeys.GlobalHotkey(Constants.ALT + Constants.SHIFT, Keys.O, this);
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
            

            if (!ghk0.Register()) MessageBox.Show("Hotkey 0 failed to register!"); ;
            if (!ghk1.Register()) MessageBox.Show("Hotkey 1 failed to register!"); ;
            if (!ghk2.Register()) MessageBox.Show("Hotkey 2 failed to register!"); ;
            if (!ghk3.Register()) MessageBox.Show("Hotkey 3 failed to register!"); ;
            if (!ghk4.Register()) MessageBox.Show("Hotkey 4 failed to register!"); ;
            if (!ghk5.Register()) MessageBox.Show("Hotkey 5 failed to register!"); ;
            if (!ghk6.Register()) MessageBox.Show("Hotkey 6 failed to register!"); ;
            if (!ghk7.Register()) MessageBox.Show("Hotkey 7 failed to register!"); ;
            if (!ghk8.Register()) MessageBox.Show("Hotkey 8 failed to register!"); ;
            if (!ghk9.Register()) MessageBox.Show("Hotkey 9 failed to register!"); ;
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
            if (ThMessageBox.ShowConfirm("Bạn thật sự muốn thoát ?"))
            this.Close();
        }

        private void btnThuNho_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void resetSoHienTai()
        {
            foreach (var stt in config.listSTT)
            {
                stt.SoHienTai = 0;
                
            }
            config.ThoiDiemReset = config.ThoiDiemReset.AddHours(12);
            SaveConfigToXMLFile(config,_configPath);
            MessageBox.Show(config.ThoiDiemReset.ToString());
        }
        private void loadConfigSTT()
        {
            config = LoadXMLToConfigBatSoTT(_configPath);
            if (config.ThoiDiemReset < DateTime.Now)
            {
                resetSoHienTai();
            }

            lblTenBenhVien.Text = config.TenBenhVien;
            //statusThongBao.Text = "[" + config.ThoiDiemReset.ToString("dd/MM/yyyy") + "] - Mời bắt số ...";

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

            timerMain.Interval = config.ThoiGianCho * 1000;

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
                    txtNutNhap.Focus();
                    config = LoadXMLToConfigBatSoTT(_configPath);
                    config.listSTT.Where(x => x.Nut == 1).Last().SoHienTai++;
                    config.listSTT.Where(x => x.Nut == 1).Last().NgayGioIn = DateTime.Now;
                    SaveConfigToXMLFile(config, _configPath);
                    loadConfigSTT();
                    break;
                case "1":                    
                    config = LoadXMLToConfigBatSoTT(_configPath);
                    config.listSTT.Where(x => x.Nut == 2).Last().SoHienTai++;
                    config.listSTT.Where(x => x.Nut == 2).Last().NgayGioIn = DateTime.Now;
                    SaveConfigToXMLFile(config, _configPath);
                    loadConfigSTT();
                    break;
                case "2":                    
                    config = LoadXMLToConfigBatSoTT(_configPath);
                    config.listSTT.Where(x => x.Nut == 3).Last().SoHienTai++;
                    config.listSTT.Where(x => x.Nut == 3).Last().NgayGioIn = DateTime.Now;
                    SaveConfigToXMLFile(config, _configPath);
                    loadConfigSTT();
                    break;
                case "3":                    
                    config = LoadXMLToConfigBatSoTT(_configPath);
                    config.listSTT.Where(x => x.Nut == 4).Last().SoHienTai++;
                    config.listSTT.Where(x => x.Nut == 4).Last().NgayGioIn = DateTime.Now;
                    SaveConfigToXMLFile(config, _configPath);
                    loadConfigSTT();
                    break;
                case "4":                    
                    config = LoadXMLToConfigBatSoTT(_configPath);
                    config.listSTT.Where(x => x.Nut == 5).Last().SoHienTai++;
                    config.listSTT.Where(x => x.Nut == 5).Last().NgayGioIn = DateTime.Now;
                    SaveConfigToXMLFile(config, _configPath);
                    loadConfigSTT();
                    break;
                case "5":                    
                    config = LoadXMLToConfigBatSoTT(_configPath);
                    config.listSTT.Where(x => x.Nut == 6).Last().SoHienTai++;
                    config.listSTT.Where(x => x.Nut == 6).Last().NgayGioIn = DateTime.Now;
                    SaveConfigToXMLFile(config, _configPath);
                    loadConfigSTT();
                    break;
                case "6":                    
                    config = LoadXMLToConfigBatSoTT(_configPath);
                    config.listSTT.Where(x => x.Nut == 7).Last().SoHienTai++;
                    config.listSTT.Where(x => x.Nut == 7).Last().NgayGioIn = DateTime.Now;
                    SaveConfigToXMLFile(config, _configPath);
                    loadConfigSTT();
                    break;
                case "7":                    
                    config = LoadXMLToConfigBatSoTT(_configPath);
                    config.listSTT.Where(x => x.Nut == 8).Last().SoHienTai++;
                    config.listSTT.Where(x => x.Nut == 8).Last().NgayGioIn = DateTime.Now;
                    SaveConfigToXMLFile(config, _configPath);
                    loadConfigSTT();
                    break;
                case "8":                    
                    config = LoadXMLToConfigBatSoTT(_configPath);
                    config.listSTT.Where(x => x.Nut == 9).Last().SoHienTai++;
                    config.listSTT.Where(x => x.Nut == 9).Last().NgayGioIn = DateTime.Now;
                    SaveConfigToXMLFile(config, _configPath);
                    loadConfigSTT();
                    break;
                case "9":                    
                    config = LoadXMLToConfigBatSoTT(_configPath);
                    config.listSTT.Where(x => x.Nut == 10).Last().SoHienTai++;
                    config.listSTT.Where(x => x.Nut == 10).Last().NgayGioIn = DateTime.Now;
                    SaveConfigToXMLFile(config, _configPath);
                    loadConfigSTT();
                    break;
                default:                    
                    break;
            }


        }

        private void FormMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            
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
            if (!ghk0.Unregiser())
                MessageBox.Show("Hotkey failed to unregister!");
            if (!ghk1.Unregiser())
                MessageBox.Show("Hotkey failed to unregister!");
            if (!ghk2.Unregiser())
                MessageBox.Show("Hotkey failed to unregister!");
            if (!ghk3.Unregiser())
                MessageBox.Show("Hotkey failed to unregister!");
            if (!ghk4.Unregiser())
                MessageBox.Show("Hotkey failed to unregister!");
            if (!ghk5.Unregiser())
                MessageBox.Show("Hotkey failed to unregister!");
            if (!ghk6.Unregiser())
                MessageBox.Show("Hotkey failed to unregister!");
            if (!ghk7.Unregiser())
                MessageBox.Show("Hotkey failed to unregister!");
            if (!ghk8.Unregiser())
                MessageBox.Show("Hotkey failed to unregister!");
            if (!ghk9.Unregiser())
                MessageBox.Show("Hotkey failed to unregister!");
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
