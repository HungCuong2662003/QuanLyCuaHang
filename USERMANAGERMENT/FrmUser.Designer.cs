namespace USERMANAGERMENT
{
    partial class FrmUser
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
            DevExpress.XtraGrid.Columns.GridColumn Fullname;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUser));
            this.Tab_user = new DevExpress.XtraTab.XtraTabControl();
            this.page_user = new DevExpress.XtraTab.XtraTabPage();
            this.ck_dis = new System.Windows.Forms.CheckBox();
            this.txt_mk1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_mk = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_hovaten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tendangnhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.page_nhom = new DevExpress.XtraTab.XtraTabPage();
            this.btn_bottv = new DevExpress.XtraEditors.SimpleButton();
            this.btn_them = new DevExpress.XtraEditors.SimpleButton();
            this.gc_thanhvien = new DevExpress.XtraGrid.GridControl();
            this.gv_thanhvien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Iduser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Username = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_dong = new DevExpress.XtraEditors.SimpleButton();
            this.btn_luu = new DevExpress.XtraEditors.SimpleButton();
            Fullname = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Tab_user)).BeginInit();
            this.Tab_user.SuspendLayout();
            this.page_user.SuspendLayout();
            this.page_nhom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_thanhvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_thanhvien)).BeginInit();
            this.SuspendLayout();
            // 
            // Fullname
            // 
            Fullname.Caption = "Fullname";
            Fullname.FieldName = "Fullname";
            Fullname.Name = "Fullname";
            Fullname.Visible = true;
            Fullname.VisibleIndex = 1;
            // 
            // Tab_user
            // 
            this.Tab_user.Dock = System.Windows.Forms.DockStyle.Top;
            this.Tab_user.Location = new System.Drawing.Point(0, 0);
            this.Tab_user.Name = "Tab_user";
            this.Tab_user.SelectedTabPage = this.page_user;
            this.Tab_user.Size = new System.Drawing.Size(636, 300);
            this.Tab_user.TabIndex = 0;
            this.Tab_user.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.page_user,
            this.page_nhom});
            // 
            // page_user
            // 
            this.page_user.Controls.Add(this.ck_dis);
            this.page_user.Controls.Add(this.txt_mk1);
            this.page_user.Controls.Add(this.label3);
            this.page_user.Controls.Add(this.txt_mk);
            this.page_user.Controls.Add(this.label4);
            this.page_user.Controls.Add(this.txt_hovaten);
            this.page_user.Controls.Add(this.label2);
            this.page_user.Controls.Add(this.txt_tendangnhap);
            this.page_user.Controls.Add(this.label1);
            this.page_user.Name = "page_user";
            this.page_user.Size = new System.Drawing.Size(634, 275);
            this.page_user.Text = "Thông tin user";
            // 
            // ck_dis
            // 
            this.ck_dis.AutoSize = true;
            this.ck_dis.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ck_dis.Location = new System.Drawing.Point(278, 223);
            this.ck_dis.Name = "ck_dis";
            this.ck_dis.Size = new System.Drawing.Size(72, 22);
            this.ck_dis.TabIndex = 12;
            this.ck_dis.Text = "Disable";
            this.ck_dis.UseVisualStyleBackColor = true;
            // 
            // txt_mk1
            // 
            this.txt_mk1.Location = new System.Drawing.Point(279, 177);
            this.txt_mk1.Name = "txt_mk1";
            this.txt_mk1.Size = new System.Drawing.Size(276, 21);
            this.txt_mk1.TabIndex = 11;
            this.txt_mk1.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(131, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nhập lại mật khẩu";
            // 
            // txt_mk
            // 
            this.txt_mk.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_mk.Location = new System.Drawing.Point(279, 137);
            this.txt_mk.Name = "txt_mk";
            this.txt_mk.Size = new System.Drawing.Size(276, 21);
            this.txt_mk.TabIndex = 9;
            this.txt_mk.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(131, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mật khẩu";
            // 
            // txt_hovaten
            // 
            this.txt_hovaten.Location = new System.Drawing.Point(278, 96);
            this.txt_hovaten.Name = "txt_hovaten";
            this.txt_hovaten.Size = new System.Drawing.Size(276, 21);
            this.txt_hovaten.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Họ và tên";
            // 
            // txt_tendangnhap
            // 
            this.txt_tendangnhap.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_tendangnhap.Location = new System.Drawing.Point(278, 55);
            this.txt_tendangnhap.Name = "txt_tendangnhap";
            this.txt_tendangnhap.Size = new System.Drawing.Size(276, 21);
            this.txt_tendangnhap.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên đăng nhập";
            // 
            // page_nhom
            // 
            this.page_nhom.Controls.Add(this.btn_bottv);
            this.page_nhom.Controls.Add(this.btn_them);
            this.page_nhom.Controls.Add(this.gc_thanhvien);
            this.page_nhom.Name = "page_nhom";
            this.page_nhom.Size = new System.Drawing.Size(634, 275);
            this.page_nhom.Text = "Nhóm user";
            // 
            // btn_bottv
            // 
            this.btn_bottv.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_bottv.ImageOptions.Image")));
            this.btn_bottv.Location = new System.Drawing.Point(418, 207);
            this.btn_bottv.Name = "btn_bottv";
            this.btn_bottv.Size = new System.Drawing.Size(132, 40);
            this.btn_bottv.TabIndex = 5;
            this.btn_bottv.Text = "Bớt nhóm";
            this.btn_bottv.Click += new System.EventHandler(this.btn_bottv_Click);
            // 
            // btn_them
            // 
            this.btn_them.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.ImageOptions.Image")));
            this.btn_them.Location = new System.Drawing.Point(178, 207);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(128, 40);
            this.btn_them.TabIndex = 4;
            this.btn_them.Text = "Thêm nhóm";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // gc_thanhvien
            // 
            this.gc_thanhvien.Dock = System.Windows.Forms.DockStyle.Top;
            this.gc_thanhvien.Location = new System.Drawing.Point(0, 0);
            this.gc_thanhvien.MainView = this.gv_thanhvien;
            this.gc_thanhvien.Name = "gc_thanhvien";
            this.gc_thanhvien.Size = new System.Drawing.Size(634, 182);
            this.gc_thanhvien.TabIndex = 1;
            this.gc_thanhvien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_thanhvien});
            this.gc_thanhvien.Click += new System.EventHandler(this.gc_thanhvien_Click);
            // 
            // gv_thanhvien
            // 
            this.gv_thanhvien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Iduser,
            this.Username,
            Fullname});
            this.gv_thanhvien.GridControl = this.gc_thanhvien;
            this.gv_thanhvien.Name = "gv_thanhvien";
            // 
            // Iduser
            // 
            this.Iduser.Caption = "ID";
            this.Iduser.FieldName = "Iduser";
            this.Iduser.MaxWidth = 100;
            this.Iduser.MinWidth = 50;
            this.Iduser.Name = "Iduser";
            this.Iduser.Width = 100;
            // 
            // Username
            // 
            this.Username.Caption = "Uername";
            this.Username.FieldName = "Username";
            this.Username.Name = "Username";
            this.Username.Visible = true;
            this.Username.VisibleIndex = 0;
            // 
            // btn_dong
            // 
            this.btn_dong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_dong.ImageOptions.Image")));
            this.btn_dong.Location = new System.Drawing.Point(439, 370);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(87, 45);
            this.btn_dong.TabIndex = 4;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_luu.ImageOptions.Image")));
            this.btn_luu.Location = new System.Drawing.Point(333, 370);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(87, 45);
            this.btn_luu.TabIndex = 3;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 444);
            this.Controls.Add(this.btn_dong);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.Tab_user);
            this.Name = "FrmUser";
            this.Text = "Thông tin người dùng";
            this.Load += new System.EventHandler(this.FrmUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tab_user)).EndInit();
            this.Tab_user.ResumeLayout(false);
            this.page_user.ResumeLayout(false);
            this.page_user.PerformLayout();
            this.page_nhom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_thanhvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_thanhvien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl Tab_user;
        private DevExpress.XtraTab.XtraTabPage page_user;
        private DevExpress.XtraTab.XtraTabPage page_nhom;
        private DevExpress.XtraEditors.SimpleButton btn_dong;
        private DevExpress.XtraEditors.SimpleButton btn_luu;
        private DevExpress.XtraGrid.GridControl gc_thanhvien;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_thanhvien;
        private DevExpress.XtraGrid.Columns.GridColumn Iduser;
        private DevExpress.XtraGrid.Columns.GridColumn Username;
        private DevExpress.XtraEditors.SimpleButton btn_bottv;
        private DevExpress.XtraEditors.SimpleButton btn_them;
        private System.Windows.Forms.TextBox txt_hovaten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tendangnhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ck_dis;
        private System.Windows.Forms.TextBox txt_mk1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_mk;
        private System.Windows.Forms.Label label4;
    }
}