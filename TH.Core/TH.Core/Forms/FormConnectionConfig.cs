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
using System.Data.SqlClient;
using TH.Core.Lib;

namespace TH.Core.Forms
{
    public partial class FormConnectionConfig : DevExpress.XtraEditors.XtraForm
    {
        private string _pathConfig = "connectionConfig.xml";
        SqlConnectionConfig config = new SqlConnectionConfig();
        public bool isConnected = false;
        public bool isCancel = false;
        public FormConnectionConfig()
        {
            InitializeComponent();
        }

        private void FormConnectionConfig_Load(object sender, EventArgs e)
        {
            modeKhoaForm();
            loadFromXML();
            //btnCapNhat.Focus();
        }

        private void modeKhoaForm()
        {
            txtServer.Enabled = false;
            txtDatabase.Enabled = false;
            txtUserName.Enabled = false;
            txtPassword.Enabled = false;
            btnLuu.Enabled = false;
            btnCapNhat.Enabled = true;
        }
        private void modeMoForm()
        {            
            txtServer.Enabled = true;
            txtDatabase.Enabled = true;
            txtUserName.Enabled = true;
            txtPassword.Enabled = true;
            btnLuu.Enabled = true;
            btnCapNhat.Enabled = false;
            
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            modeMoForm();
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //if (txtServer.Text == "")
            //{
            //    ThMessageBox.ShowError("Nhập tên máy chủ");
            //    return;
            //}
            //if (txtUserName.Text == "")
            //{
            //    ThMessageBox.ShowError("Nhập tên đăng nhập");
            //    return;
            //}
            //if (txtPassword.Text == "")
            //{
            //    ThMessageBox.ShowError("Nhập mật khẩu");
            //    return;
            //}
            //if (txtDatabase.Text == "")
            //{
            //    ThMessageBox.ShowError("Nhập tên database");
            //    return;
            //}
            try
            {
                if (!testKetNoi())
                {
                    ThMessageBox.ShowError("Không thể kết nối đến máy chủ, vui lòng kiểm tra lại");
                    return;
                } else
                {
                    ThMessageBox.Show("Đã kết nối thành công");
                    isConnected = true;
                    luuXML();
                    modeKhoaForm();
                }
                
            } catch (Exception ex)
            {
                ThMessageBox.ShowSystemError(ex.Message);
            }            
        }
        private bool testKetNoi()
        {
            string connectionString = String.Format("Server={0};" +
                    "User Id={1};Password={2};Initial Catalog={3};Connection Timeout=5",
                    txtServer.Text, txtUserName.Text,
                    txtPassword.Text, txtDatabase.Text);
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                //ThMessageBox.Show("Kết nối thành công");
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                //throw new Exception("Không thể kết nối đến máy chủ, vui lòng kiểm tra thông tin kết nối.");
                return false;
            }
        }
        private void luuXML()
        {
            try
            {
                SqlConnectionConfig config = new SqlConnectionConfig();
                config.Server = txtServer.Text;
                config.UserName = txtUserName.Text;
                config.Password = txtPassword.Text;
                config.Database = txtDatabase.Text;
                XmlController.SaveSqlConnectionConfigToXMLFile(config, _pathConfig);
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
        private void loadFromXML()
        {

            try
            {
                try
                {
                    config = XmlController.LoadSqlConnectionConfigXMLToObject(_pathConfig);
                } catch
                {
                    config = new SqlConnectionConfig();
                    XmlController.SaveSqlConnectionConfigToXMLFile(config, _pathConfig);
                }                
                txtServer.Text = config.Server;
                txtUserName.Text = config.UserName;
                txtPassword.Text = config.Password;
                txtDatabase.Text = config.Database;                            
            }
            catch (Exception ex)
            {
                ThMessageBox.ShowError(ex.Message);
            }

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
            
            
        }

        private void FormConnectionConfig_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtServer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Enter))
            {
                SendKeys.Send("{TAB}");
            }

            //return base.ProcessCmdKey(ref msg, keyData);
        }

        private void txtDatabase_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Enter))
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Enter))
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Enter))
            {
                SendKeys.Send("{TAB}");
            }
        }

        //protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        //{
        //    if (keyData == (Keys.Enter))
        //    {
        //        SendKeys.Send("{TAB}");
        //    }

        //    return base.ProcessCmdKey(ref msg, keyData);
        //}
    }
}