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
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenVLTL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoHienTai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnInSo = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnCauHinh = new DevExpress.XtraEditors.SimpleButton();
            this.timerLamMoi = new System.Windows.Forms.Timer();
            this.btnLamMoi = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcVLTL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVLTL)).BeginInit();
            this.SuspendLayout();
            // 
            // gcVLTL
            // 
            this.gcVLTL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcVLTL.Location = new System.Drawing.Point(12, 66);
            this.gcVLTL.MainView = this.gvVLTL;
            this.gcVLTL.Name = "gcVLTL";
            this.gcVLTL.Size = new System.Drawing.Size(708, 539);
            this.gcVLTL.TabIndex = 0;
            this.gcVLTL.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvVLTL});
            this.gcVLTL.Click += new System.EventHandler(this.gcVLTL_Click);
            this.gcVLTL.DoubleClick += new System.EventHandler(this.gcVLTL_DoubleClick);
            // 
            // gvVLTL
            // 
            this.gvVLTL.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.gvVLTL.Appearance.FocusedRow.Options.UseFont = true;
            this.gvVLTL.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 14F);
            this.gvVLTL.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvVLTL.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 14F);
            this.gvVLTL.Appearance.Row.Options.UseFont = true;
            this.gvVLTL.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
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
            // colID
            // 
            this.colID.AppearanceCell.Options.UseTextOptions = true;
            this.colID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colID.AppearanceHeader.Options.UseTextOptions = true;
            this.colID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colID.Caption = "ID";
            this.colID.Name = "colID";
            // 
            // colTenVLTL
            // 
            this.colTenVLTL.Caption = "Tên VLTL";
            this.colTenVLTL.FieldName = "TenVLTL";
            this.colTenVLTL.Name = "colTenVLTL";
            this.colTenVLTL.Visible = true;
            this.colTenVLTL.VisibleIndex = 1;
            this.colTenVLTL.Width = 247;
            // 
            // colSoHienTai
            // 
            this.colSoHienTai.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.colSoHienTai.AppearanceCell.ForeColor = System.Drawing.Color.Green;
            this.colSoHienTai.AppearanceCell.Options.UseFont = true;
            this.colSoHienTai.AppearanceCell.Options.UseForeColor = true;
            this.colSoHienTai.AppearanceCell.Options.UseTextOptions = true;
            this.colSoHienTai.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSoHienTai.AppearanceHeader.Options.UseTextOptions = true;
            this.colSoHienTai.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSoHienTai.Caption = "Số hiện tại";
            this.colSoHienTai.FieldName = "SoHienTai";
            this.colSoHienTai.Name = "colSoHienTai";
            this.colSoHienTai.Visible = true;
            this.colSoHienTai.VisibleIndex = 2;
            this.colSoHienTai.Width = 112;
            // 
            // colNgayIn
            // 
            this.colNgayIn.AppearanceCell.ForeColor = System.Drawing.Color.Gray;
            this.colNgayIn.AppearanceCell.Options.UseForeColor = true;
            this.colNgayIn.Caption = "Ngày giờ in";
            this.colNgayIn.DisplayFormat.FormatString = "g";
            this.colNgayIn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNgayIn.FieldName = "NgayIn";
            this.colNgayIn.Name = "colNgayIn";
            this.colNgayIn.Visible = true;
            this.colNgayIn.VisibleIndex = 3;
            this.colNgayIn.Width = 281;
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
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnThoat.Location = new System.Drawing.Point(592, 12);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(128, 48);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnCauHinh
            // 
            this.btnCauHinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCauHinh.Image = ((System.Drawing.Image)(resources.GetObject("btnCauHinh.Image")));
            this.btnCauHinh.Location = new System.Drawing.Point(506, 33);
            this.btnCauHinh.Name = "btnCauHinh";
            this.btnCauHinh.Size = new System.Drawing.Size(80, 27);
            this.btnCauHinh.TabIndex = 1;
            this.btnCauHinh.Text = "Cấu hình";
            this.btnCauHinh.Click += new System.EventHandler(this.btnCauHinh_Click);
            // 
            // timerLamMoi
            // 
            this.timerLamMoi.Interval = 5000;
            this.timerLamMoi.Tick += new System.EventHandler(this.timerLamMoi_Tick);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnLamMoi.Appearance.Options.UseFont = true;
            this.btnLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.Image")));
            this.btnLamMoi.Location = new System.Drawing.Point(226, 12);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(88, 48);
            this.btnLamMoi.TabIndex = 1;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 617);
            this.Controls.Add(this.btnCauHinh);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnInSo);
            this.Controls.Add(this.gcVLTL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Timer timerLamMoi;
        private DevExpress.XtraEditors.SimpleButton btnLamMoi;
    }
}

