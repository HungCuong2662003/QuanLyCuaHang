namespace USERMANAGERMENT
{
    partial class MainFormUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormUser));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btn_nhomnguoidung = new DevExpress.XtraBars.BarButtonItem();
            this.btn_nguoidung = new DevExpress.XtraBars.BarButtonItem();
            this.btn_capnhatthongtin = new DevExpress.XtraBars.BarButtonItem();
            this.btn_phanquyennguoidung = new DevExpress.XtraBars.BarButtonItem();
            this.btn_phanquyenbaocao = new DevExpress.XtraBars.BarButtonItem();
            this.btn_thoat = new DevExpress.XtraBars.BarButtonItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pn_nhom = new System.Windows.Forms.Panel();
            this.gc_user = new DevExpress.XtraGrid.GridControl();
            this.gv_user = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Iduser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Username = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Passwd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Fullname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Macty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Madvi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Last_PWD_Changed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Isgroup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Disable = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_user)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 7;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 16;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1037, 150);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Nhóm người dùng";
            this.barButtonItem1.Id = 11;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_nhomnguoidung_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Người dùng";
            this.barButtonItem2.Id = 12;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_nguoidung_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Cập nhật thông tin";
            this.barButtonItem3.Id = 13;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_capnhatthongtin_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Phân quyền người dùng";
            this.barButtonItem4.Id = 14;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_phanquyennguoidung_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Phân quyền báo cáo";
            this.barButtonItem5.Id = 15;
            this.barButtonItem5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.Image")));
            this.barButtonItem5.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.LargeImage")));
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Chức năng";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tài khoản";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem5);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Phân quyền";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Hệ thống";
            // 
            // btn_nhomnguoidung
            // 
            this.btn_nhomnguoidung.Caption = "Nhóm người dùng";
            this.btn_nhomnguoidung.Id = 1;
            this.btn_nhomnguoidung.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_nhomnguoidung.ImageOptions.Image")));
            this.btn_nhomnguoidung.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_nhomnguoidung.ImageOptions.LargeImage")));
            this.btn_nhomnguoidung.Name = "btn_nhomnguoidung";
            this.btn_nhomnguoidung.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_nhomnguoidung_ItemClick);
            // 
            // btn_nguoidung
            // 
            this.btn_nguoidung.Caption = "Người dùng";
            this.btn_nguoidung.Id = 2;
            this.btn_nguoidung.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_nguoidung.ImageOptions.Image")));
            this.btn_nguoidung.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_nguoidung.ImageOptions.LargeImage")));
            this.btn_nguoidung.Name = "btn_nguoidung";
            this.btn_nguoidung.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_nguoidung_ItemClick);
            // 
            // btn_capnhatthongtin
            // 
            this.btn_capnhatthongtin.Caption = "Cập nhật thông tin";
            this.btn_capnhatthongtin.Id = 3;
            this.btn_capnhatthongtin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_capnhatthongtin.ImageOptions.Image")));
            this.btn_capnhatthongtin.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_capnhatthongtin.ImageOptions.LargeImage")));
            this.btn_capnhatthongtin.Name = "btn_capnhatthongtin";
            this.btn_capnhatthongtin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_capnhatthongtin_ItemClick);
            // 
            // btn_phanquyennguoidung
            // 
            this.btn_phanquyennguoidung.Caption = "Phân quyền người dùng";
            this.btn_phanquyennguoidung.Id = 4;
            this.btn_phanquyennguoidung.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_phanquyennguoidung.ImageOptions.Image")));
            this.btn_phanquyennguoidung.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_phanquyennguoidung.ImageOptions.LargeImage")));
            this.btn_phanquyennguoidung.Name = "btn_phanquyennguoidung";
            this.btn_phanquyennguoidung.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_phanquyennguoidung_ItemClick);
            // 
            // btn_phanquyenbaocao
            // 
            this.btn_phanquyenbaocao.Caption = "Phân quyền báo cáo";
            this.btn_phanquyenbaocao.Id = 5;
            this.btn_phanquyenbaocao.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_phanquyenbaocao.ImageOptions.Image")));
            this.btn_phanquyenbaocao.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_phanquyenbaocao.ImageOptions.LargeImage")));
            this.btn_phanquyenbaocao.Name = "btn_phanquyenbaocao";
            this.btn_phanquyenbaocao.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_phanquyenbaocao_ItemClick);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Caption = "Thoát";
            this.btn_thoat.Id = 6;
            this.btn_thoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_thoat.ImageOptions.Image")));
            this.btn_thoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_thoat.ImageOptions.LargeImage")));
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_thoat_ItemClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pn_nhom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1037, 64);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(484, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đơn vị";
            // 
            // pn_nhom
            // 
            this.pn_nhom.Dock = System.Windows.Forms.DockStyle.Right;
            this.pn_nhom.Location = new System.Drawing.Point(712, 0);
            this.pn_nhom.Name = "pn_nhom";
            this.pn_nhom.Size = new System.Drawing.Size(325, 64);
            this.pn_nhom.TabIndex = 0;
            // 
            // gc_user
            // 
            this.gc_user.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_user.Location = new System.Drawing.Point(0, 214);
            this.gc_user.MainView = this.gv_user;
            this.gc_user.Name = "gc_user";
            this.gc_user.Size = new System.Drawing.Size(1037, 378);
            this.gc_user.TabIndex = 3;
            this.gc_user.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_user});
            // 
            // gv_user
            // 
            this.gv_user.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Iduser,
            this.Username,
            this.Passwd,
            this.Fullname,
            this.Macty,
            this.Madvi,
            this.Last_PWD_Changed,
            this.Isgroup,
            this.Disable});
            this.gv_user.GridControl = this.gc_user;
            this.gv_user.Name = "gv_user";
            this.gv_user.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gv_user_CustomDrawCell);
            this.gv_user.DoubleClick += new System.EventHandler(this.gv_user_DoubleClick);
            // 
            // Iduser
            // 
            this.Iduser.Caption = "Id";
            this.Iduser.FieldName = "Iduser";
            this.Iduser.Name = "Iduser";
            // 
            // Username
            // 
            this.Username.Caption = "Tài khoản";
            this.Username.FieldName = "Username";
            this.Username.MaxWidth = 200;
            this.Username.MinWidth = 80;
            this.Username.Name = "Username";
            this.Username.Visible = true;
            this.Username.VisibleIndex = 0;
            this.Username.Width = 177;
            // 
            // Passwd
            // 
            this.Passwd.Caption = "Mật khẩu";
            this.Passwd.FieldName = "Passwd";
            this.Passwd.MaxWidth = 200;
            this.Passwd.MinWidth = 80;
            this.Passwd.Name = "Passwd";
            this.Passwd.Visible = true;
            this.Passwd.VisibleIndex = 1;
            this.Passwd.Width = 177;
            // 
            // Fullname
            // 
            this.Fullname.Caption = "Họ tên";
            this.Fullname.FieldName = "Fullname";
            this.Fullname.MaxWidth = 200;
            this.Fullname.MinWidth = 100;
            this.Fullname.Name = "Fullname";
            this.Fullname.Visible = true;
            this.Fullname.VisibleIndex = 2;
            this.Fullname.Width = 194;
            // 
            // Macty
            // 
            this.Macty.Caption = "Mã cty";
            this.Macty.FieldName = "Macty";
            this.Macty.Name = "Macty";
            // 
            // Madvi
            // 
            this.Madvi.Caption = "Mã dvi";
            this.Madvi.FieldName = "Madvi";
            this.Madvi.Name = "Madvi";
            // 
            // Last_PWD_Changed
            // 
            this.Last_PWD_Changed.Caption = "Lần cuối thay đổi mật khẩu";
            this.Last_PWD_Changed.FieldName = "Last_PWD_Changed";
            this.Last_PWD_Changed.Name = "Last_PWD_Changed";
            this.Last_PWD_Changed.Visible = true;
            this.Last_PWD_Changed.VisibleIndex = 3;
            this.Last_PWD_Changed.Width = 185;
            // 
            // Isgroup
            // 
            this.Isgroup.Caption = "Isgroup";
            this.Isgroup.FieldName = "Isgroup";
            this.Isgroup.MaxWidth = 100;
            this.Isgroup.MinWidth = 50;
            this.Isgroup.Name = "Isgroup";
            this.Isgroup.Visible = true;
            this.Isgroup.VisibleIndex = 4;
            this.Isgroup.Width = 62;
            // 
            // Disable
            // 
            this.Disable.Caption = "Disable";
            this.Disable.FieldName = "Disable";
            this.Disable.MaxWidth = 100;
            this.Disable.MinWidth = 50;
            this.Disable.Name = "Disable";
            this.Disable.Visible = true;
            this.Disable.VisibleIndex = 5;
            this.Disable.Width = 50;
            // 
            // MainFormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 592);
            this.Controls.Add(this.gc_user);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "MainFormUser";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btn_nhomnguoidung;
        private DevExpress.XtraBars.BarButtonItem btn_nguoidung;
        private DevExpress.XtraBars.BarButtonItem btn_capnhatthongtin;
        private DevExpress.XtraBars.BarButtonItem btn_phanquyennguoidung;
        private DevExpress.XtraBars.BarButtonItem btn_phanquyenbaocao;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btn_thoat;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pn_nhom;
        private DevExpress.XtraGrid.GridControl gc_user;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_user;
        private DevExpress.XtraGrid.Columns.GridColumn Iduser;
        private DevExpress.XtraGrid.Columns.GridColumn Username;
        private DevExpress.XtraGrid.Columns.GridColumn Passwd;
        private DevExpress.XtraGrid.Columns.GridColumn Fullname;
        private DevExpress.XtraGrid.Columns.GridColumn Macty;
        private DevExpress.XtraGrid.Columns.GridColumn Madvi;
        private DevExpress.XtraGrid.Columns.GridColumn Last_PWD_Changed;
        private DevExpress.XtraGrid.Columns.GridColumn Isgroup;
        private DevExpress.XtraGrid.Columns.GridColumn Disable;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
    }
}