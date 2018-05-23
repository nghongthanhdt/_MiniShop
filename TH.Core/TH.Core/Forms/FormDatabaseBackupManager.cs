using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TH.Core.Lib;

namespace TH.Core.Forms
{
    public partial class FormDatabaseBackupManager : Form
    {
        public FormDatabaseBackupManager()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection();
        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            string connectionString = "Persist Security Info=False;User ID=HongThanh;Password=phcn@123;Initial Catalog=PHCN;Server=SERVER\\SQLSERVER2008R2";
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                //connection.Close();
                MessageBox.Show("Kết nối thành công.");
            } catch
            {
                connection.Close();
                MessageBox.Show("Không thể kết nối đến máy chủ.");
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            try
            {
                string backupQuery = "BACKUP DATABASE PHCN TO DISK = 'D:\\ThuNoiBo\\DB_Backup\\PHCN-" + DateTime.Now.ToString("yyyy-MM-dd-hhmmss") + ".BAK'";
                SqlCommand cmd = new SqlCommand(backupQuery, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã backup thành công !");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string path = "config.xml";
            SqlConnectionConfig config = new SqlConnectionConfig();
            config.Server = @"SERVER\SQLSERVER2008R2";
            config.UserName = "HongThanh";
            config.Password = "phcn@123";
            config.Database = "PHCN";
            try
            {
                XmlController.SaveSqlConnectionConfigToXMLFile(config, path);
                MessageBox.Show("Đã lưu thành công");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
