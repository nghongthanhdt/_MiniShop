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
using TH.Core.Lib;

namespace DHG.Tools.Forms
{
    public partial class FormCauHinh : DevExpress.XtraEditors.XtraForm
    {
        private string _pathConfig = "config.xml";
        public FormCauHinh()
        {
            InitializeComponent();
        }

        private void FormCauHinh_Load(object sender, EventArgs e)
        {
            modeKhoaForm();
            loadXML();
        }
        private void loadXML()
        {
            SqlConnectionConfig config = XmlController.LoadSqlConnectionConfigXMLToObject(_pathConfig);
            try
            {
                //testKetNoi(config);
            } catch (Exception ex)
            {
                ThMessageBox.ShowError(ex.Message);
            }
            
        }
        private void modeKhoaForm()
        {
            txtServer.Enabled = false;
            txtPort.Enabled = false;
            txtDatabase.Enabled = false;
            txtUserName.Enabled = false;
            txtPassword.Enabled = false;
        }
        private void modeMoForm()
        {
            txtServer.Enabled = true;
            txtPort.Enabled = true;
            txtDatabase.Enabled = true;
            txtUserName.Enabled = true;
            txtPassword.Enabled = true;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            SqlConnectionConfig config = XmlController.LoadSqlConnectionConfigXMLToObject(_pathConfig);
            if (!testKetNoi(config))
            {
                ThMessageBox.ShowError("Kết nối chưa thành công");
                Application.Exit();
            }
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            modeMoForm();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //testKetNoi();
            modeKhoaForm();
            luuXML();
        }
        private bool testKetNoi()
        {
            string connectionString = String.Format("Server={0};Port={1};" +
                    "User Id={2};Password={3};Database={4};",
                    txtServer.Text, txtPort.Text, txtUserName.Text,
                    txtPassword.Text, txtDatabase.Text);
            NpgsqlConnection conn = new NpgsqlConnection(connectionString);
            try
            {
                conn.Open();
                ThMessageBox.Show("Kết nối thành công");
                return true;
            } catch (Exception ex)
            {
                ThMessageBox.ShowError(ex.Message);
                return false;
            }
            

        }
        private bool testKetNoi(SqlConnectionConfig config)
        {
            string connectionString = String.Format("Server={0};Port={1};" +
                    "User Id={2};Password={3};Database={4};",
                    config.Server, config.Port, config.UserName,
                    config.Password, config.Database);
            NpgsqlConnection conn = new NpgsqlConnection(connectionString);
            try
            {
                conn.Open();
                ThMessageBox.Show("Kết nối thành công");
                return true;
            }
            catch (Exception ex)
            {
                ThMessageBox.ShowError(ex.Message);
                return false;
            }
        }
        

        public NpgsqlConnection GetConnect()
        {
            SqlConnectionConfig config = XmlController.LoadSqlConnectionConfigXMLToObject(_pathConfig);
            string connectionString = String.Format("Server={0};Port={1};" +
                    "User Id={2};Password={3};Database={4};",
                    config.Server, config.Port, config.UserName,
                    config.Password, config.Database);
            NpgsqlConnection conn = new NpgsqlConnection(connectionString);
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                return conn;
            }
            catch (Exception ex)
            {
                ThMessageBox.ShowError("Không thể kết nối đến máy chủ, lỗi: " + ex.Message);
                return null;
            }
        }
        private void luuXML()
        {
            SqlConnectionConfig config = new SqlConnectionConfig();
            config.Server = txtServer.Text;
            config.UserName = txtUserName.Text;
            config.Password = txtPassword.Text;
            config.Port = txtPort.Text;
            config.Database = txtDatabase.Text;
            XmlController.SaveSqlConnectionConfigToXMLFile(config, _pathConfig);
        }
    }
}