using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH.InSTTVLTL
{
    public partial class FormCauHinh : Form
    {
        public FormCauHinh()
        {
            InitializeComponent();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtTenVLTL.Text = "";
            txtSTT.Text = "";
        }

        private void FormCauHinh_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
        }

        private void btnLuuVLTL_Click(object sender, EventArgs e)
        {
            VLTL vltl = new VLTL();

            int stt = 1;
            try { stt = int.Parse(txtSTT.Text); } catch { };
            vltl.STT = stt;
            vltl.TenVLTL = txtTenVLTL.Text;
        }
    }
}
