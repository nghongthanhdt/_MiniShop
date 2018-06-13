using DHG.Tools.Forms;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TH.Core.Forms;

namespace DHG.Tools
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        NpgsqlConnection connection = new NpgsqlConnection();
        public FormMain()
        {
            InitializeComponent();
        }

        private void menuCauHinhKetNoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormCauHinh f = new FormCauHinh();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            getConnect();
        }
        private void getConnect()
        {
            FormCauHinh f = new FormCauHinh();
            
            
            connection = f.GetConnect();
            if (connection == null)
            {
                f.ShowDialog();
            }
            
            
        }
    }
}
