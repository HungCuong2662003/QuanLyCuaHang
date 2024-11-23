namespace QL_Quan_Kho_Hang
{
    partial class FrmNhaCC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNhaCC));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_them = new System.Windows.Forms.ToolStripButton();
            this.btn_sua = new System.Windows.Forms.ToolStripButton();
            this.btn_xoa = new System.Windows.Forms.ToolStripButton();
            this.btn_luu = new System.Windows.Forms.ToolStripButton();
            this.btn_boqua = new System.Windows.Forms.ToolStripButton();
            this.btn_thoat = new System.Windows.Forms.ToolStripButton();
            this.GC_Ds = new DevExpress.XtraGrid.GridControl();
            this.GV_Ds = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaNCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenNCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Fax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Disable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_fax = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_dt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_dis = new System.Windows.Forms.CheckBox();
            this.txt_mancc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tenncc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.toolStrip1.Size = new System.Drawing.Size(1035, 38);
            this.toolStrip1.TabIndex = 2;
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
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoa.Image")));
            this.btn_xoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(31, 35);
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.Image = ((System.Drawing.Image)(resources.GetObject("btn_luu.Image")));
            this.btn_luu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(31, 35);
            this.btn_luu.Text = "Lưu";
            this.btn_luu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_boqua
            // 
            this.btn_boqua.Image = ((System.Drawing.Image)(resources.GetObject("btn_boqua.Image")));
            this.btn_boqua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_boqua.Name = "btn_boqua";
            this.btn_boqua.Size = new System.Drawing.Size(48, 35);
            this.btn_boqua.Text = "Bỏ qua";
            this.btn_boqua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_boqua.Click += new System.EventHandler(this.btn_boqua_Click);
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
            this.GC_Ds.Size = new System.Drawing.Size(1035, 307);
            this.GC_Ds.TabIndex = 3;
            this.GC_Ds.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GV_Ds});
            // 
            // GV_Ds
            // 
            this.GV_Ds.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaNCC,
            this.TenNCC,
            this.DienThoai,
            this.Email,
            this.Fax,
            this.DiaChi,
            this.Disable});
            this.GV_Ds.GridControl = this.GC_Ds;
            this.GV_Ds.Name = "GV_Ds";
            this.GV_Ds.Click += new System.EventHandler(this.GV_Ds_Click);
            // 
            // MaNCC
            // 
            this.MaNCC.Caption = "Mã nhà cung cấp";
            this.MaNCC.FieldName = "MaNCC";
            this.MaNCC.MaxWidth = 200;
            this.MaNCC.MinWidth = 100;
            this.MaNCC.Name = "MaNCC";
            this.MaNCC.Visible = true;
            this.MaNCC.VisibleIndex = 0;
            this.MaNCC.Width = 147;
            // 
            // TenNCC
            // 
            this.TenNCC.Caption = "Tên nhà cung cấp";
            this.TenNCC.FieldName = "TenNCC";
            this.TenNCC.MaxWidth = 300;
            this.TenNCC.MinWidth = 100;
            this.TenNCC.Name = "TenNCC";
            this.TenNCC.Visible = true;
            this.TenNCC.VisibleIndex = 1;
            this.TenNCC.Width = 294;
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
            // Email
            // 
            this.Email.Caption = "Email";
            this.Email.FieldName = "Email";
            this.Email.MaxWidth = 200;
            this.Email.MinWidth = 100;
            this.Email.Name = "Email";
            this.Email.Visible = true;
            this.Email.VisibleIndex = 3;
            this.Email.Width = 150;
            // 
            // Fax
            // 
            this.Fax.Caption = "Fax";
            this.Fax.FieldName = "Fax";
            this.Fax.MaxWidth = 200;
            this.Fax.MinWidth = 100;
            this.Fax.Name = "Fax";
            this.Fax.Visible = true;
            this.Fax.VisibleIndex = 4;
            this.Fax.Width = 100;
            // 
            // DiaChi
            // 
            this.DiaChi.Caption = "Địa chỉ";
            this.DiaChi.FieldName = "DiaChi";
            this.DiaChi.MaxWidth = 300;
            this.DiaChi.MinWidth = 200;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Visible = true;
            this.DiaChi.VisibleIndex = 5;
            this.DiaChi.Width = 200;
            // 
            // Disable
            // 
            this.Disable.Caption = "Tình trạng";
            this.Disable.FieldName = "Disable";
            this.Disable.MaxWidth = 100;
            this.Disable.MinWidth = 50;
            this.Disable.Name = "Disable";
            this.Disable.Visible = true;
            this.Disable.VisibleIndex = 6;
            this.Disable.Width = 100;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txt_diachi);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.txt_mail);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.txt_fax);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.txt_dt);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.cb_dis);
            this.groupControl1.Controls.Add(this.txt_mancc);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.txt_tenncc);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 345);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1035, 269);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Thông  tin ";
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(589, 165);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(150, 21);
            this.txt_diachi.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(489, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Địa chỉ";
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(589, 62);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(150, 21);
            this.txt_mail.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(489, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Email";
            // 
            // txt_fax
            // 
            this.txt_fax.Location = new System.Drawing.Point(589, 112);
            this.txt_fax.Name = "txt_fax";
            this.txt_fax.Size = new System.Drawing.Size(150, 21);
            this.txt_fax.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(489, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Fax";
            // 
            // txt_dt
            // 
            this.txt_dt.Location = new System.Drawing.Point(186, 168);
            this.txt_dt.Name = "txt_dt";
            this.txt_dt.Size = new System.Drawing.Size(150, 21);
            this.txt_dt.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Điện thoại";
            // 
            // cb_dis
            // 
            this.cb_dis.AutoSize = true;
            this.cb_dis.Location = new System.Drawing.Point(809, 115);
            this.cb_dis.Name = "cb_dis";
            this.cb_dis.Size = new System.Drawing.Size(60, 17);
            this.cb_dis.TabIndex = 15;
            this.cb_dis.Text = "Disable";
            this.cb_dis.UseVisualStyleBackColor = true;
            // 
            // txt_mancc
            // 
            this.txt_mancc.Location = new System.Drawing.Point(186, 65);
            this.txt_mancc.Name = "txt_mancc";
            this.txt_mancc.Size = new System.Drawing.Size(150, 21);
            this.txt_mancc.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mã nhà cung cấp";
            // 
            // txt_tenncc
            // 
            this.txt_tenncc.Location = new System.Drawing.Point(186, 115);
            this.txt_tenncc.Name = "txt_tenncc";
            this.txt_tenncc.Size = new System.Drawing.Size(150, 21);
            this.txt_tenncc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên nhà cung cấp";
            // 
            // FrmNhaCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 614);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.GC_Ds);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmNhaCC";
            this.Text = "FrmNhaCC";
            this.Load += new System.EventHandler(this.FrmNhaCC_Load);
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
        private DevExpress.XtraGrid.Columns.GridColumn MaNCC;
        private DevExpress.XtraGrid.Columns.GridColumn TenNCC;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_fax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_dt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cb_dis;
        private System.Windows.Forms.TextBox txt_mancc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tenncc;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn DienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn Email;
        private DevExpress.XtraGrid.Columns.GridColumn Fax;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn Disable;
    }
}