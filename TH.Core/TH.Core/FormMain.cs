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
using System.Data.SqlClient;
using TH.Core.Lib;

namespace TH.Core
{
    public partial class FormMain : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection connection = new SqlConnection();
        SqlConnectionConfig config = new SqlConnectionConfig();
        
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnCauHinhKetNoi_Click(object sender, EventArgs e)
        {
            FormConnectionConfig f = new FormConnectionConfig();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
            if (!f.isConnected)
            {
                loadKetNoi();
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
        private void loadKetNoi()
        {

        }
        //private void loadFromXML()
        //{

        //    try
        //    {
        //        try
        //        {
        //            config = XmlController.LoadSqlConnectionConfigXMLToObject(_pathConfig);
        //        }
        //        catch
        //        {
        //            config = new SqlConnectionConfig();
        //            XmlController.SaveSqlConnectionConfigToXMLFile(config, _pathConfig);
        //        }
        //        txtServer.Text = config.Server;
        //        txtUserName.Text = config.UserName;
        //        txtPassword.Text = config.Password;
        //        txtDatabase.Text = config.Database;
        //    }
        //    catch (Exception ex)
        //    {
        //        ThMessageBox.ShowError(ex.Message);
        //    }

        //}
        //private bool testKetNoiMain()
        //{
        //    string connectionString = String.Format("Server={0};" +
        //            "User Id={1};Password={2};Initial Catalog={3};Connection Timeout=5",
        //            txtServer.Text, txtUserName.Text,
        //            txtPassword.Text, txtDatabase.Text);
        //    SqlConnection conn = new SqlConnection(connectionString);
        //    try
        //    {
        //        conn.Open();
        //        //ThMessageBox.Show("Kết nối thành công");
        //        conn.Close();
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        //throw new Exception("Không thể kết nối đến máy chủ, vui lòng kiểm tra thông tin kết nối.");
        //        return false;
        //    }
        //}
    }
}