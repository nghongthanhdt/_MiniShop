using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH.Core.Forms
{
    public static class ThMessageBox
    {
        public static void Show(string message)
        {
            MessageBox.Show(message, "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
