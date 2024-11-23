namespace USERMANAGERMENT
{
    partial class FrmGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGroup));
            this.xtratab = new DevExpress.XtraTab.XtraTabControl();
            this.page_nhom = new DevExpress.XtraTab.XtraTabPage();
            this.txt_mota = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tennhom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.page_thanhvien = new DevExpress.XtraTab.XtraTabPage();
            this.btn_bottv = new DevExpress.XtraEditors.SimpleButton();
            this.gc_thanhvien = new DevExpress.XtraGrid.GridControl();
            this.gv_thanhvien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Iduser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Username = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_them = new DevExpress.XtraEditors.SimpleButton();
            this.btn_luu = new DevExpress.XtraEditors.SimpleButton();
            this.btn_dong = new DevExpress.XtraEditors.SimpleButton();
            Fullname = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.xtratab)).BeginInit();
            this.xtratab.SuspendLayout();
            this.page_nhom.SuspendLayout();
            this.page_thanhvien.SuspendLayout();
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
            Fullname.Width = 321;
            // 
            // xtratab
            // 
            this.xtratab.Dock = System.Windows.Forms.DockStyle.Top;
            this.xtratab.Location = new System.Drawing.Point(0, 0);
            this.xtratab.Name = "xtratab";
            this.xtratab.SelectedTabPage = this.page_nhom;
            this.xtratab.Size = new System.Drawing.Size(548, 289);
            this.xtratab.TabIndex = 0;
            this.xtratab.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.page_nhom,
            this.page_thanhvien});
            this.xtratab.Tag = "";
            // 
            // page_nhom
            // 
            this.page_nhom.Controls.Add(this.txt_mota);
            this.page_nhom.Controls.Add(this.label2);
            this.page_nhom.Controls.Add(this.txt_tennhom);
            this.page_nhom.Controls.Add(this.label1);
            this.page_nhom.Name = "page_nhom";
            this.page_nhom.Size = new System.Drawing.Size(546, 264);
            this.page_nhom.Text = "Thông tin nhóm";
            // 
            // txt_mota
            // 
            this.txt_mota.Location = new System.Drawing.Point(226, 144);
            this.txt_mota.Name = "txt_mota";
            this.txt_mota.Size = new System.Drawing.Size(134, 21);
            this.txt_mota.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mô tả";
            // 
            // txt_tennhom
            // 
            this.txt_tennhom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_tennhom.Location = new System.Drawing.Point(226, 74);
            this.txt_tennhom.Name = "txt_tennhom";
            this.txt_tennhom.Size = new System.Drawing.Size(134, 21);
            this.txt_tennhom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên nhóm ";
            // 
            // page_thanhvien
            // 
            this.page_thanhvien.Controls.Add(this.btn_bottv);
            this.page_thanhvien.Controls.Add(this.gc_thanhvien);
            this.page_thanhvien.Controls.Add(this.btn_them);
            this.page_thanhvien.Name = "page_thanhvien";
            this.page_thanhvien.Size = new System.Drawing.Size(546, 264);
            this.page_thanhvien.Text = "Thành viên";
            // 
            // btn_bottv
            // 
            this.btn_bottv.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_bottv.ImageOptions.Image")));
            this.btn_bottv.Location = new System.Drawing.Point(374, 200);
            this.btn_bottv.Name = "btn_bottv";
            this.btn_bottv.Size = new System.Drawing.Size(132, 40);
            this.btn_bottv.TabIndex = 3;
            this.btn_bottv.Text = "Bớt thành viên";
            this.btn_bottv.Click += new System.EventHandler(this.btn_bottv_Click);
            // 
            // gc_thanhvien
            // 
            this.gc_thanhvien.Dock = System.Windows.Forms.DockStyle.Top;
            this.gc_thanhvien.Location = new System.Drawing.Point(0, 0);
            this.gc_thanhvien.MainView = this.gv_thanhvien;
            this.gc_thanhvien.Name = "gc_thanhvien";
            this.gc_thanhvien.Size = new System.Drawing.Size(546, 182);
            this.gc_thanhvien.TabIndex = 0;
            this.gc_thanhvien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_thanhvien});
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
            this.Username.Width = 200;
            // 
            // btn_them
            // 
            this.btn_them.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.ImageOptions.Image")));
            this.btn_them.Location = new System.Drawing.Point(134, 200);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(128, 40);
            this.btn_them.TabIndex = 1;
            this.btn_them.Text = "Thêm thành viên";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_luu.ImageOptions.Image")));
            this.btn_luu.Location = new System.Drawing.Point(206, 295);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(75, 45);
            this.btn_luu.TabIndex = 1;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_dong
            // 
            this.btn_dong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_dong.ImageOptions.Image")));
            this.btn_dong.Location = new System.Drawing.Point(366, 295);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(75, 45);
            this.btn_dong.TabIndex = 2;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // FrmGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 352);
            this.Controls.Add(this.btn_dong);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.xtratab);
            this.Name = "FrmGroup";
            this.Text = "Nhóm người dùng";
            this.Load += new System.EventHandler(this.FrmGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtratab)).EndInit();
            this.xtratab.ResumeLayout(false);
            this.page_nhom.ResumeLayout(false);
            this.page_nhom.PerformLayout();
            this.page_thanhvien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_thanhvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_thanhvien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtratab;
        private DevExpress.XtraTab.XtraTabPage page_nhom;
        private DevExpress.XtraTab.XtraTabPage page_thanhvien;
        private System.Windows.Forms.TextBox txt_mota;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tennhom;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btn_luu;
        private DevExpress.XtraEditors.SimpleButton btn_dong;
        private DevExpress.XtraGrid.GridControl gc_thanhvien;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_thanhvien;
        private DevExpress.XtraEditors.SimpleButton btn_them;
        private DevExpress.XtraEditors.SimpleButton btn_bottv;
        private DevExpress.XtraGrid.Columns.GridColumn Iduser;
        private DevExpress.XtraGrid.Columns.GridColumn Username;
    }
}