using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TH.Core
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMiniShop_Click(object sender, EventArgs e)
        {
            Process yourProcess = new Process();
            yourProcess.StartInfo.FileName = @"D:\_MiniShop\TH.Core\TH.MiniShop\bin\Debug\TH.MiniShop.exe";

            yourProcess.Start();
        }
    }
}
