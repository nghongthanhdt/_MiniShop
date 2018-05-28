using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using TH.Core.Lib;

namespace TH.Core.Forms
{
    public partial class FormDatabaseBackupManager : Form
    {
        string _path = "config.xml";
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
            //try
            //{
            //    string backupQuery = "BACKUP DATABASE PHCN TO DISK = 'D:\\ThuNoiBo\\DB_Backup\\PHCN-" + DateTime.Now.ToString("yyyy-MM-dd-hhmmss") + ".BAK'";
            //    SqlCommand cmd = new SqlCommand(backupQuery, connection);
            //    cmd.ExecuteNonQuery();
            //    MessageBox.Show("Đã backup thành công !");
            //} catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
            List<SqlConnectionConfig> list = new List<SqlConnectionConfig>();
            SqlConnectionConfig config = new SqlConnectionConfig();
            config.ConfigName = txtConfigName.Text + " (" + txtDatabase.Text + ")";
            config.Server = txtServer.Text;
            config.UserName = txtUserName.Text;
            config.Password = txtPassword.Text;
            config.Database = txtDatabase.Text;
            List<string> listtime = new List<string>();
            
            listtime.Add(timeThoiDiem.Time.ToString("hh:mm:ss tt"));
            config.DailyBackupTime = listtime;
            list.Add(config);
            list.Add(config);
            try
            {
                XmlController.SaveSqlConnectionConfigToXMLFile(list, _path);
                MessageBox.Show("Đã lưu thành công");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnThemCauHinh_Click(object sender, EventArgs e)
        {
            modeThemCauHinh();
        }
        private void modeThemCauHinh()
        {
            txtMode.Text = "add";
            txtConfigName.Text = "";
            txtServer.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtDatabase.Text = "";
            txtPath.Text = "";
            checkboxTuDongHangNgay.CheckState = CheckState.Unchecked;
            gcThoiDiem.DataSource = null;
        }

        private void FormDatabaseBackupManager_Load(object sender, EventArgs e)
        {
            load();
        }
        private void load()
        {
            loadFileConfig();
        }
        private void loadFileConfig()
        {
            List<SqlConnectionConfig> listConfig = XmlController.LoadSqlConnectionConfigFromXMLFile(_path);
            DataTable dt = new DataTable();
            dt.Columns.Add("ConfigName");
            DataRow row;
            foreach (var item in listConfig)
            {
                row = dt.NewRow();
                row["ConfigName"] = item.ConfigName;
                dt.Rows.Add(row);
            }
            gcConfigName.DataSource = dt;
            
        }
    }
}
