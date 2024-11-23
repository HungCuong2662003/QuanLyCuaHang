namespace USERMANAGERMENT
{
    partial class FrmShowGR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmShowGR));
            this.gc_nhom = new DevExpress.XtraGrid.GridControl();
            this.gv_nhom = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Iduser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Username = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_dong = new DevExpress.XtraEditors.SimpleButton();
            this.btn_luu = new DevExpress.XtraEditors.SimpleButton();
            Fullname = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gc_nhom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_nhom)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_nhom
            // 
            this.gc_nhom.Dock = System.Windows.Forms.DockStyle.Top;
            this.gc_nhom.Location = new System.Drawing.Point(0, 0);
            this.gc_nhom.MainView = this.gv_nhom;
            this.gc_nhom.Name = "gc_nhom";
            this.gc_nhom.Size = new System.Drawing.Size(585, 182);
            this.gc_nhom.TabIndex = 2;
            this.gc_nhom.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_nhom});
            // 
            // gv_nhom
            // 
            this.gv_nhom.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Iduser,
            this.Username,
            Fullname});
            this.gv_nhom.GridControl = this.gc_nhom;
            this.gv_nhom.Name = "gv_nhom";
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
            // Fullname
            // 
            Fullname.Caption = "Fullname";
            Fullname.FieldName = "Fullname";
            Fullname.Name = "Fullname";
            Fullname.Visible = true;
            Fullname.VisibleIndex = 1;
            Fullname.Width = 405;
            // 
            // btn_dong
            // 
            this.btn_dong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_dong.ImageOptions.Image")));
            this.btn_dong.Location = new System.Drawing.Point(462, 252);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(75, 45);
            this.btn_dong.TabIndex = 6;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_luu.ImageOptions.Image")));
            this.btn_luu.Location = new System.Drawing.Point(302, 252);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(75, 45);
            this.btn_luu.TabIndex = 5;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // FrmShowGR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 346);
            this.Controls.Add(this.btn_dong);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.gc_nhom);
            this.Name = "FrmShowGR";
            this.Text = "FrmShowGR";
            this.Load += new System.EventHandler(this.FrmShowGR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_nhom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_nhom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_nhom;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_nhom;
        private DevExpress.XtraGrid.Columns.GridColumn Iduser;
        private DevExpress.XtraGrid.Columns.GridColumn Username;
        private DevExpress.XtraEditors.SimpleButton btn_dong;
        private DevExpress.XtraEditors.SimpleButton btn_luu;
    }
}