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
        InSTTVLTLEntities db = new InSTTVLTLEntities();
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInSo_Click(object sender, EventArgs e)
        {
            inSo();
            loadgcVLTL();
        }
        private void inSo()
        {
            //int[] selectedIndexs = gvVLTL.GetSelectedRows();
            //foreach (int i in selectedIndexs)
            //{
            //    DataRow row = gvVLTL.GetDataRow(i);
            //    int id = int.Parse(row["ID"].ToString());
            //    var vltl = db.VLTL.Find(id);
            //    vltl.SoHienTai++;
            //}
            //db.SaveChanges();
            
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            loadgcVLTL();
        }
        private void loadgcVLTL()
        {
            var listVLTL = db.VLTL.OrderBy(x => x.STT).ToList();
            gcVLTL.DataSource = listVLTL;

        }

        private void gcVLTL_DoubleClick(object sender, EventArgs e)
        {
            int index = gvVLTL.FocusedRowHandle;
            if (!gvVLTL.IsRowSelected(index))
            {
                gvVLTL.SelectRow(index);
            }
            else gvVLTL.UnselectRow(index);
        }
    }
}
