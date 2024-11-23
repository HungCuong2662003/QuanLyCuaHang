namespace USERMANAGERMENT
{
    partial class Frm_showmember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_showmember));
            this.gc_thanhvien = new DevExpress.XtraGrid.GridControl();
            this.gv_thanhvien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Iduser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Username = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_dong = new DevExpress.XtraEditors.SimpleButton();
            this.btn_luu = new DevExpress.XtraEditors.SimpleButton();
            Fullname = new DevExpress.XtraGrid.Columns.GridColumn();
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
            Fullname.Width = 405;
            // 
            // gc_thanhvien
            // 
            this.gc_thanhvien.Dock = System.Windows.Forms.DockStyle.Top;
            this.gc_thanhvien.Location = new System.Drawing.Point(0, 0);
            this.gc_thanhvien.MainView = this.gv_thanhvien;
            this.gc_thanhvien.Name = "gc_thanhvien";
            this.gc_thanhvien.Size = new System.Drawing.Size(630, 182);
            this.gc_thanhvien.TabIndex = 1;
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
            this.Username.Caption = "Username";
            this.Username.FieldName = "Username";
            this.Username.Name = "Username";
            this.Username.Visible = true;
            this.Username.VisibleIndex = 0;
            this.Username.Width = 200;
            // 
            // btn_dong
            // 
            this.btn_dong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_dong.ImageOptions.Image")));
            this.btn_dong.Location = new System.Drawing.Point(523, 286);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(75, 45);
            this.btn_dong.TabIndex = 4;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_luu.ImageOptions.Image")));
            this.btn_luu.Location = new System.Drawing.Point(363, 286);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(75, 45);
            this.btn_luu.TabIndex = 3;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // Frm_showmember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 364);
            this.Controls.Add(this.btn_dong);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.gc_thanhvien);
            this.Name = "Frm_showmember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách thành viên";
            this.Load += new System.EventHandler(this.Frm_showmember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_thanhvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_thanhvien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_thanhvien;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_thanhvien;
        private DevExpress.XtraGrid.Columns.GridColumn Iduser;
        private DevExpress.XtraGrid.Columns.GridColumn Username;
        private DevExpress.XtraEditors.SimpleButton btn_dong;
        private DevExpress.XtraEditors.SimpleButton btn_luu;
    }
}