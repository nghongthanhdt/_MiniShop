namespace TH.Core.Forms
{
    partial class FormDatabaseBackupManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDatabaseBackupManager));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtConfigName = new System.Windows.Forms.TextBox();
            this.txtDatabase = new DevExpress.XtraEditors.TextEdit();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.txtServer = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnKetNoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnCauHinh = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnBackupNgay = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.gcConfigName = new DevExpress.XtraGrid.GridControl();
            this.gvConfigName = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.tabThongTinChung = new DevExpress.XtraTab.XtraTabPage();
            this.txtMode = new System.Windows.Forms.TextBox();
            this.checkboxTuDongHangNgay = new System.Windows.Forms.CheckBox();
            this.timeThoiDiem = new DevExpress.XtraEditors.TimeEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.gcThoiDiem = new DevExpress.XtraGrid.GridControl();
            this.gvThoiDiem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colThoiDiem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnThemCauHinh = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatabase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcConfigName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvConfigName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.tabThongTinChung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeThoiDiem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcThoiDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThoiDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtConfigName);
            this.layoutControl1.Controls.Add(this.txtDatabase);
            this.layoutControl1.Controls.Add(this.txtPath);
            this.layoutControl1.Controls.Add(this.txtPassword);
            this.layoutControl1.Controls.Add(this.txtUserName);
            this.layoutControl1.Controls.Add(this.txtServer);
            this.layoutControl1.Location = new System.Drawing.Point(6, 48);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(506, 143);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtConfigName
            // 
            this.txtConfigName.Location = new System.Drawing.Point(110, 12);
            this.txtConfigName.Name = "txtConfigName";
            this.txtConfigName.Size = new System.Drawing.Size(384, 20);
            this.txtConfigName.TabIndex = 8;
            // 
            // txtDatabase
            // 
            this.txtDatabase.EditValue = "PHCN";
            this.txtDatabase.Location = new System.Drawing.Point(110, 84);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(384, 20);
            this.txtDatabase.StyleController = this.layoutControl1;
            this.txtDatabase.TabIndex = 7;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(110, 108);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(384, 20);
            this.txtPath.TabIndex = 3;
            this.txtPath.Text = "D:\\ThuNoiBo\\DB_Backup\\PHCN09.BAK";
            // 
            // txtPassword
            // 
            this.txtPassword.EditValue = "phcn@123";
            this.txtPassword.Location = new System.Drawing.Point(352, 60);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(142, 20);
            this.txtPassword.StyleController = this.layoutControl1;
            this.txtPassword.TabIndex = 6;
            // 
            // txtUserName
            // 
            this.txtUserName.EditValue = "hongthanh";
            this.txtUserName.Location = new System.Drawing.Point(110, 60);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(140, 20);
            this.txtUserName.StyleController = this.layoutControl1;
            this.txtUserName.TabIndex = 5;
            // 
            // txtServer
            // 
            this.txtServer.EditValue = "SERVER\\SQLSERVER2008R2";
            this.txtServer.Location = new System.Drawing.Point(110, 36);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(384, 20);
            this.txtServer.StyleController = this.layoutControl1;
            this.txtServer.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(506, 143);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtServer;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(486, 24);
            this.layoutControlItem1.Text = "Server:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(95, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtUserName;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(242, 24);
            this.layoutControlItem2.Text = "UserName:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(95, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtDatabase;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(486, 24);
            this.layoutControlItem4.Text = "Database:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(95, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtPassword;
            this.layoutControlItem3.Location = new System.Drawing.Point(242, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(244, 24);
            this.layoutControlItem3.Text = "Password:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(95, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtPath;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(486, 27);
            this.layoutControlItem5.Text = "Đường dẫn backup:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(95, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtConfigName;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(486, 24);
            this.layoutControlItem6.Text = "Tên cấu hình:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(95, 13);
            // 
            // btnKetNoi
            // 
            this.btnKetNoi.Image = ((System.Drawing.Image)(resources.GetObject("btnKetNoi.Image")));
            this.btnKetNoi.Location = new System.Drawing.Point(192, 20);
            this.btnKetNoi.Name = "btnKetNoi";
            this.btnKetNoi.Size = new System.Drawing.Size(99, 23);
            this.btnKetNoi.TabIndex = 1;
            this.btnKetNoi.Text = "Kết nối";
            this.btnKetNoi.Click += new System.EventHandler(this.btnKetNoi_Click);
            // 
            // btnCauHinh
            // 
            this.btnCauHinh.Image = ((System.Drawing.Image)(resources.GetObject("btnCauHinh.Image")));
            this.btnCauHinh.Location = new System.Drawing.Point(88, 20);
            this.btnCauHinh.Name = "btnCauHinh";
            this.btnCauHinh.Size = new System.Drawing.Size(98, 23);
            this.btnCauHinh.TabIndex = 2;
            this.btnCauHinh.Text = "Cập nhật";
            // 
            // btnLuu
            // 
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(297, 20);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(115, 23);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnBackupNgay
            // 
            this.btnBackupNgay.Image = ((System.Drawing.Image)(resources.GetObject("btnBackupNgay.Image")));
            this.btnBackupNgay.Location = new System.Drawing.Point(368, 197);
            this.btnBackupNgay.Name = "btnBackupNgay";
            this.btnBackupNgay.Size = new System.Drawing.Size(132, 40);
            this.btnBackupNgay.TabIndex = 5;
            this.btnBackupNgay.Text = "Backup ngay";
            this.btnBackupNgay.Click += new System.EventHandler(this.btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "QUẢN LÝ SAO LƯU CƠ SỞ DỮ LIỆU";
            // 
            // gcConfigName
            // 
            this.gcConfigName.Location = new System.Drawing.Point(17, 46);
            this.gcConfigName.MainView = this.gvConfigName;
            this.gcConfigName.Name = "gcConfigName";
            this.gcConfigName.Size = new System.Drawing.Size(302, 295);
            this.gcConfigName.TabIndex = 10;
            this.gcConfigName.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvConfigName});
            // 
            // gvConfigName
            // 
            this.gvConfigName.GridControl = this.gcConfigName;
            this.gvConfigName.Name = "gvConfigName";
            this.gvConfigName.OptionsView.ShowGroupPanel = false;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(331, 46);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.tabThongTinChung;
            this.xtraTabControl1.Size = new System.Drawing.Size(560, 409);
            this.xtraTabControl1.TabIndex = 11;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabThongTinChung});
            // 
            // tabThongTinChung
            // 
            this.tabThongTinChung.Controls.Add(this.txtMode);
            this.tabThongTinChung.Controls.Add(this.checkboxTuDongHangNgay);
            this.tabThongTinChung.Controls.Add(this.timeThoiDiem);
            this.tabThongTinChung.Controls.Add(this.simpleButton1);
            this.tabThongTinChung.Controls.Add(this.gcThoiDiem);
            this.tabThongTinChung.Controls.Add(this.layoutControl1);
            this.tabThongTinChung.Controls.Add(this.btnKetNoi);
            this.tabThongTinChung.Controls.Add(this.btnLuu);
            this.tabThongTinChung.Controls.Add(this.btnCauHinh);
            this.tabThongTinChung.Controls.Add(this.btnBackupNgay);
            this.tabThongTinChung.Controls.Add(this.btnThemCauHinh);
            this.tabThongTinChung.Name = "tabThongTinChung";
            this.tabThongTinChung.Size = new System.Drawing.Size(554, 381);
            this.tabThongTinChung.Text = "Thông tin chung";
            // 
            // txtMode
            // 
            this.txtMode.Enabled = false;
            this.txtMode.Location = new System.Drawing.Point(453, 22);
            this.txtMode.Name = "txtMode";
            this.txtMode.Size = new System.Drawing.Size(47, 21);
            this.txtMode.TabIndex = 13;
            this.txtMode.Text = "add";
            // 
            // checkboxTuDongHangNgay
            // 
            this.checkboxTuDongHangNgay.AutoSize = true;
            this.checkboxTuDongHangNgay.Location = new System.Drawing.Point(19, 192);
            this.checkboxTuDongHangNgay.Name = "checkboxTuDongHangNgay";
            this.checkboxTuDongHangNgay.Size = new System.Drawing.Size(155, 17);
            this.checkboxTuDongHangNgay.TabIndex = 12;
            this.checkboxTuDongHangNgay.Text = "Backup tự động hàng ngày";
            this.checkboxTuDongHangNgay.UseVisualStyleBackColor = true;
            // 
            // timeThoiDiem
            // 
            this.timeThoiDiem.EditValue = new System.DateTime(2018, 5, 25, 0, 0, 0, 0);
            this.timeThoiDiem.Location = new System.Drawing.Point(19, 340);
            this.timeThoiDiem.Name = "timeThoiDiem";
            this.timeThoiDiem.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeThoiDiem.Size = new System.Drawing.Size(100, 20);
            this.timeThoiDiem.TabIndex = 11;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(127, 338);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(59, 23);
            this.simpleButton1.TabIndex = 10;
            this.simpleButton1.Text = "Thêm";
            // 
            // gcThoiDiem
            // 
            this.gcThoiDiem.Location = new System.Drawing.Point(19, 215);
            this.gcThoiDiem.MainView = this.gvThoiDiem;
            this.gcThoiDiem.Name = "gcThoiDiem";
            this.gcThoiDiem.Size = new System.Drawing.Size(249, 119);
            this.gcThoiDiem.TabIndex = 6;
            this.gcThoiDiem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvThoiDiem});
            // 
            // gvThoiDiem
            // 
            this.gvThoiDiem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colThoiDiem});
            this.gvThoiDiem.GridControl = this.gcThoiDiem;
            this.gvThoiDiem.Name = "gvThoiDiem";
            this.gvThoiDiem.OptionsView.ShowGroupPanel = false;
            // 
            // colThoiDiem
            // 
            this.colThoiDiem.Caption = "Thời điểm";
            this.colThoiDiem.Name = "colThoiDiem";
            this.colThoiDiem.Visible = true;
            this.colThoiDiem.VisibleIndex = 0;
            // 
            // btnThemCauHinh
            // 
            this.btnThemCauHinh.Image = ((System.Drawing.Image)(resources.GetObject("btnThemCauHinh.Image")));
            this.btnThemCauHinh.Location = new System.Drawing.Point(15, 20);
            this.btnThemCauHinh.Name = "btnThemCauHinh";
            this.btnThemCauHinh.Size = new System.Drawing.Size(67, 23);
            this.btnThemCauHinh.TabIndex = 2;
            this.btnThemCauHinh.Text = "Thêm";
            this.btnThemCauHinh.Click += new System.EventHandler(this.btnThemCauHinh_Click);
            // 
            // FormDatabaseBackupManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 467);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.gcConfigName);
            this.Controls.Add(this.label2);
            this.Name = "FormDatabaseBackupManager";
            this.Text = "FormDatabaseBackupManager";
            this.Load += new System.EventHandler(this.FormDatabaseBackupManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDatabase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcConfigName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvConfigName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.tabThongTinChung.ResumeLayout(false);
            this.tabThongTinChung.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeThoiDiem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcThoiDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThoiDiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit txtDatabase;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.TextEdit txtServer;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.SimpleButton btnKetNoi;
        private DevExpress.XtraEditors.SimpleButton btnCauHinh;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private System.Windows.Forms.TextBox txtPath;
        private DevExpress.XtraEditors.SimpleButton btnBackupNgay;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConfigName;
        private DevExpress.XtraGrid.GridControl gcConfigName;
        private DevExpress.XtraGrid.Views.Grid.GridView gvConfigName;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage tabThongTinChung;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.GridControl gcThoiDiem;
        private DevExpress.XtraGrid.Views.Grid.GridView gvThoiDiem;
        private DevExpress.XtraGrid.Columns.GridColumn colThoiDiem;
        private DevExpress.XtraEditors.TimeEdit timeThoiDiem;
        private System.Windows.Forms.CheckBox checkboxTuDongHangNgay;
        private DevExpress.XtraEditors.SimpleButton btnThemCauHinh;
        private System.Windows.Forms.TextBox txtMode;
    }
}