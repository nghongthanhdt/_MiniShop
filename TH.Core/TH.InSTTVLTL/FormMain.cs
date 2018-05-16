using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TH.InSTTVLTL
{
    public partial class FormMain : DevExpress.XtraEditors.XtraForm
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

        }

        private void btnCauHinh_Click(object sender, EventArgs e)
        {
            FormCauHinh f = new FormCauHinh();
            f.ShowDialog();
        }
    }
}
