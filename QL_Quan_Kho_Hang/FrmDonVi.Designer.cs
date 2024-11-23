namespace QL_Quan_Kho_Hang
{
    partial class FrmDonVi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDonVi));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_them = new System.Windows.Forms.ToolStripButton();
            this.btn_sua = new System.Windows.Forms.ToolStripButton();
            this.btn_xoa = new System.Windows.Forms.ToolStripButton();
            this.btn_luu = new System.Windows.Forms.ToolStripButton();
            this.btn_boqua = new System.Windows.Forms.ToolStripButton();
            this.btn_thoat = new System.Windows.Forms.ToolStripButton();
            this.GC_Ds = new DevExpress.XtraGrid.GridControl();
            this.GV_Ds = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaDvi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenDvi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Fax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaCty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Disable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txt_Kyhieu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ck_kho = new System.Windows.Forms.CheckBox();
            this.txt_tendv = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Madv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ck_dis = new System.Windows.Forms.CheckBox();
            this.txt_DT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Fax = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_congty = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_Ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_them,
            this.btn_sua,
            this.btn_xoa,
            this.btn_luu,
            this.btn_boqua,
            this.btn_thoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1079, 38);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_them
            // 
            this.btn_them.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.Image")));
            this.btn_them.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(41, 35);
            this.btn_them.Text = "Thêm";
            this.btn_them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.Image")));
            this.btn_sua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(30, 35);
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click_1);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoa.Image")));
            this.btn_xoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(31, 35);
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click_1);
            // 
            // btn_luu
            // 
            this.btn_luu.Image = ((System.Drawing.Image)(resources.GetObject("btn_luu.Image")));
            this.btn_luu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(31, 35);
            this.btn_luu.Text = "Lưu";
            this.btn_luu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click_1);
            // 
            // btn_boqua
            // 
            this.btn_boqua.Image = ((System.Drawing.Image)(resources.GetObject("btn_boqua.Image")));
            this.btn_boqua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_boqua.Name = "btn_boqua";
            this.btn_boqua.Size = new System.Drawing.Size(48, 35);
            this.btn_boqua.Text = "Bỏ qua";
            this.btn_boqua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_boqua.Click += new System.EventHandler(this.btn_boqua_Click_1);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Image = global::QL_Quan_Kho_Hang.Properties.Resources.thoat;
            this.btn_thoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(41, 35);
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // GC_Ds
            // 
            this.GC_Ds.Dock = System.Windows.Forms.DockStyle.Top;
            this.GC_Ds.Location = new System.Drawing.Point(0, 38);
            this.GC_Ds.MainView = this.GV_Ds;
            this.GC_Ds.Name = "GC_Ds";
            this.GC_Ds.Size = new System.Drawing.Size(1079, 307);
            this.GC_Ds.TabIndex = 2;
            this.GC_Ds.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GV_Ds});
            // 
            // GV_Ds
            // 
            this.GV_Ds.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaDvi,
            this.TenDvi,
            this.DienThoai,
            this.Fax,
            this.Email,
            this.DiaChi,
            this.MaCty,
            this.Disable});
            this.GV_Ds.GridControl = this.GC_Ds;
            this.GV_Ds.Name = "GV_Ds";
            this.GV_Ds.Click += new System.EventHandler(this.GV_Ds_Click);
            // 
            // MaDvi
            // 
            this.MaDvi.Caption = "Mã đơn vị";
            this.MaDvi.FieldName = "MaDvi";
            this.MaDvi.MaxWidth = 100;
            this.MaDvi.MinWidth = 50;
            this.MaDvi.Name = "MaDvi";
            this.MaDvi.Visible = true;
            this.MaDvi.VisibleIndex = 0;
            this.MaDvi.Width = 94;
            // 
            // TenDvi
            // 
            this.TenDvi.Caption = "Tên đơn vị";
            this.TenDvi.FieldName = "TenDvi";
            this.TenDvi.MaxWidth = 200;
            this.TenDvi.MinWidth = 100;
            this.TenDvi.Name = "TenDvi";
            this.TenDvi.Visible = true;
            this.TenDvi.VisibleIndex = 1;
            this.TenDvi.Width = 126;
            // 
            // DienThoai
            // 
            this.DienThoai.Caption = "Điện thoại";
            this.DienThoai.FieldName = "DienThoai";
            this.DienThoai.MaxWidth = 200;
            this.DienThoai.MinWidth = 100;
            this.DienThoai.Name = "DienThoai";
            this.DienThoai.Visible = true;
            this.DienThoai.VisibleIndex = 2;
            this.DienThoai.Width = 100;
            // 
            // Fax
            // 
            this.Fax.Caption = "Fax";
            this.Fax.FieldName = "Fax";
            this.Fax.MaxWidth = 200;
            this.Fax.MinWidth = 100;
            this.Fax.Name = "Fax";
            this.Fax.Visible = true;
            this.Fax.VisibleIndex = 5;
            this.Fax.Width = 100;
            // 
            // Email
            // 
            this.Email.Caption = "Email";
            this.Email.FieldName = "Email";
            this.Email.MaxWidth = 200;
            this.Email.MinWidth = 100;
            this.Email.Name = "Email";
            this.Email.Visible = true;
            this.Email.VisibleIndex = 3;
            this.Email.Width = 100;
            // 
            // DiaChi
            // 
            this.DiaChi.Caption = "Địa chỉ";
            this.DiaChi.FieldName = "DiaChi";
            this.DiaChi.MaxWidth = 300;
            this.DiaChi.MinWidth = 150;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Visible = true;
            this.DiaChi.VisibleIndex = 4;
            this.DiaChi.Width = 253;
            // 
            // MaCty
            // 
            this.MaCty.Caption = "Mã công ty";
            this.MaCty.FieldName = "MaCty";
            this.MaCty.Name = "MaCty";
            this.MaCty.Visible = true;
            this.MaCty.VisibleIndex = 6;
            // 
            // Disable
            // 
            this.Disable.Caption = "Tình trạng";
            this.Disable.FieldName = "Disable";
            this.Disable.MaxWidth = 100;
            this.Disable.MinWidth = 30;
            this.Disable.Name = "Disable";
            this.Disable.Visible = true;
            this.Disable.VisibleIndex = 7;
            this.Disable.Width = 68;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cbo_congty);
            this.groupControl1.Controls.Add(this.txt_Kyhieu);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.ck_kho);
            this.groupControl1.Controls.Add(this.txt_tendv);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.txt_Madv);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.ck_dis);
            this.groupControl1.Controls.Add(this.txt_DT);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.txt_email);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.txt_diachi);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.txt_Fax);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 345);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1079, 230);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Thông  tin ";
            // 
            // txt_Kyhieu
            // 
            this.txt_Kyhieu.Location = new System.Drawing.Point(578, 177);
            this.txt_Kyhieu.Name = "txt_Kyhieu";
            this.txt_Kyhieu.Size = new System.Drawing.Size(150, 21);
            this.txt_Kyhieu.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(478, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Ký hiệu";
            // 
            // ck_kho
            // 
            this.ck_kho.AutoSize = true;
            this.ck_kho.Location = new System.Drawing.Point(852, 65);
            this.ck_kho.Name = "ck_kho";
            this.ck_kho.Size = new System.Drawing.Size(44, 17);
            this.ck_kho.TabIndex = 17;
            this.ck_kho.Text = "Kho";
            this.ck_kho.UseVisualStyleBackColor = true;
            // 
            // txt_tendv
            // 
            this.txt_tendv.Location = new System.Drawing.Point(129, 99);
            this.txt_tendv.Name = "txt_tendv";
            this.txt_tendv.Size = new System.Drawing.Size(150, 21);
            this.txt_tendv.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Tên đơn vị";
            // 
            // txt_Madv
            // 
            this.txt_Madv.Location = new System.Drawing.Point(129, 58);
            this.txt_Madv.Name = "txt_Madv";
            this.txt_Madv.Size = new System.Drawing.Size(150, 21);
            this.txt_Madv.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mã đơn vị";
            // 
            // ck_dis
            // 
            this.ck_dis.AutoSize = true;
            this.ck_dis.Location = new System.Drawing.Point(852, 99);
            this.ck_dis.Name = "ck_dis";
            this.ck_dis.Size = new System.Drawing.Size(60, 17);
            this.ck_dis.TabIndex = 12;
            this.ck_dis.Text = "Disable";
            this.ck_dis.UseVisualStyleBackColor = true;
            // 
            // txt_DT
            // 
            this.txt_DT.Location = new System.Drawing.Point(129, 141);
            this.txt_DT.Name = "txt_DT";
            this.txt_DT.Size = new System.Drawing.Size(150, 21);
            this.txt_DT.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Điện thoại";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(129, 182);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(150, 21);
            this.txt_email.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email";
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(578, 96);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(150, 21);
            this.txt_diachi.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(478, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Địa chỉ";
            // 
            // txt_Fax
            // 
            this.txt_Fax.Location = new System.Drawing.Point(578, 136);
            this.txt_Fax.Name = "txt_Fax";
            this.txt_Fax.Size = new System.Drawing.Size(150, 21);
            this.txt_Fax.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(478, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fax";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(478, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã công ty";
            // 
            // cbo_congty
            // 
            this.cbo_congty.FormattingEnabled = true;
            this.cbo_congty.Location = new System.Drawing.Point(578, 58);
            this.cbo_congty.Name = "cbo_congty";
            this.cbo_congty.Size = new System.Drawing.Size(150, 21);
            this.cbo_congty.TabIndex = 20;
     
            // 
            // FrmDonVi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 613);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.GC_Ds);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmDonVi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đơn vị";
            this.Load += new System.EventHandler(this.FrmDonVi_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_Ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_them;
        private System.Windows.Forms.ToolStripButton btn_sua;
        private System.Windows.Forms.ToolStripButton btn_xoa;
        private System.Windows.Forms.ToolStripButton btn_luu;
        private System.Windows.Forms.ToolStripButton btn_boqua;
        private System.Windows.Forms.ToolStripButton btn_thoat;
        private DevExpress.XtraGrid.GridControl GC_Ds;
        private DevExpress.XtraGrid.Views.Grid.GridView GV_Ds;
        private DevExpress.XtraGrid.Columns.GridColumn MaDvi;
        private DevExpress.XtraGrid.Columns.GridColumn TenDvi;
        private DevExpress.XtraGrid.Columns.GridColumn DienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn Fax;
        private DevExpress.XtraGrid.Columns.GridColumn Email;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn Disable;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox txt_tendv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Madv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ck_dis;
        private System.Windows.Forms.TextBox txt_DT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Fax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn MaCty;
        private System.Windows.Forms.CheckBox ck_kho;
        private System.Windows.Forms.TextBox txt_Kyhieu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbo_congty;
    }
}