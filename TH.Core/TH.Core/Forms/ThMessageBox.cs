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
        public static void ShowSystemError(string message)
        {
            MessageBox.Show(message, "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void ShowError(string message)
        {
            MessageBox.Show(message, "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static bool ShowConfirm(string mesaage)
        {
            DialogResult dr = MessageBox.Show(mesaage, "Xác nhận", MessageBoxButtons.OKCancel,
            MessageBoxIcon.Information);   
            if (dr == DialogResult.OK)
            {
                return true;
            }
            else return false;
        }
    }
}
