namespace TH.InSTTVLTL
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.gcVLTL = new DevExpress.XtraGrid.GridControl();
            this.gvVLTL = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnInSo = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnCauHinh = new DevExpress.XtraEditors.SimpleButton();
            this.colTenVLTL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoHienTai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcVLTL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVLTL)).BeginInit();
            this.SuspendLayout();
            // 
            // gcVLTL
            // 
            this.gcVLTL.Location = new System.Drawing.Point(12, 66);
            this.gcVLTL.MainView = this.gvVLTL;
            this.gcVLTL.Name = "gcVLTL";
            this.gcVLTL.Size = new System.Drawing.Size(707, 302);
            this.gcVLTL.TabIndex = 0;
            this.gcVLTL.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvVLTL});
            this.gcVLTL.DoubleClick += new System.EventHandler(this.gcVLTL_DoubleClick);
            // 
            // gvVLTL
            // 
            this.gvVLTL.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.gvVLTL.Appearance.FocusedRow.Options.UseFont = true;
            this.gvVLTL.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gvVLTL.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvVLTL.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gvVLTL.Appearance.Row.Options.UseFont = true;
            this.gvVLTL.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.gvVLTL.Appearance.SelectedRow.Options.UseFont = true;
            this.gvVLTL.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colTenVLTL,
            this.colSoHienTai,
            this.colNgayIn});
            this.gvVLTL.GridControl = this.gcVLTL;
            this.gvVLTL.Name = "gvVLTL";
            this.gvVLTL.OptionsBehavior.Editable = false;
            this.gvVLTL.OptionsBehavior.ReadOnly = true;
            this.gvVLTL.OptionsSelection.CheckBoxSelectorColumnWidth = 50;
            this.gvVLTL.OptionsSelection.MultiSelect = true;
            this.gvVLTL.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gvVLTL.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.True;
            this.gvVLTL.OptionsView.ShowGroupPanel = false;
            // 
            // btnInSo
            // 
            this.btnInSo.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnInSo.Appearance.Options.UseFont = true;
            this.btnInSo.Image = ((System.Drawing.Image)(resources.GetObject("btnInSo.Image")));
            this.btnInSo.Location = new System.Drawing.Point(12, 12);
            this.btnInSo.Name = "btnInSo";
            this.btnInSo.Size = new System.Drawing.Size(208, 48);
            this.btnInSo.TabIndex = 1;
            this.btnInSo.Text = "In số";
            this.btnInSo.Click += new System.EventHandler(this.btnInSo_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnThoat.Location = new System.Drawing.Point(435, 12);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(128, 48);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnCauHinh
            // 
            this.btnCauHinh.Image = ((System.Drawing.Image)(resources.GetObject("btnCauHinh.Image")));
            this.btnCauHinh.Location = new System.Drawing.Point(349, 12);
            this.btnCauHinh.Name = "btnCauHinh";
            this.btnCauHinh.Size = new System.Drawing.Size(80, 27);
            this.btnCauHinh.TabIndex = 1;
            this.btnCauHinh.Text = "Cấu hình";
            this.btnCauHinh.Click += new System.EventHandler(this.btnCauHinh_Click);
            // 
            // colTenVLTL
            // 
            this.colTenVLTL.Caption = "Tên VLTL";
            this.colTenVLTL.FieldName = "TenVLTL";
            this.colTenVLTL.Name = "colTenVLTL";
            this.colTenVLTL.Visible = true;
            this.colTenVLTL.VisibleIndex = 1;
            this.colTenVLTL.Width = 336;
            // 
            // colSoHienTai
            // 
            this.colSoHienTai.Caption = "Số hiện tại";
            this.colSoHienTai.FieldName = "SoHienTai";
            this.colSoHienTai.Name = "colSoHienTai";
            this.colSoHienTai.Visible = true;
            this.colSoHienTai.VisibleIndex = 2;
            this.colSoHienTai.Width = 92;
            // 
            // colNgayIn
            // 
            this.colNgayIn.Caption = "Ngày giờ in";
            this.colNgayIn.FieldName = "NgayIn";
            this.colNgayIn.Name = "colNgayIn";
            this.colNgayIn.Visible = true;
            this.colNgayIn.VisibleIndex = 3;
            this.colNgayIn.Width = 220;
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.Name = "colID";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 380);
            this.Controls.Add(this.btnCauHinh);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnInSo);
            this.Controls.Add(this.gcVLTL);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In số thứ tự VLTL";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcVLTL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVLTL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcVLTL;
        private DevExpress.XtraGrid.Views.Grid.GridView gvVLTL;
        private DevExpress.XtraEditors.SimpleButton btnInSo;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnCauHinh;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colTenVLTL;
        private DevExpress.XtraGrid.Columns.GridColumn colSoHienTai;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayIn;
    }
}

