namespace USERMANAGERMENT
{
    partial class FrmPhanQuyenBC
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
            this.components = new System.ComponentModel.Container();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gc_user = new DevExpress.XtraGrid.GridControl();
            this.gv_user = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Isgroup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Username = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Fullname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Iduser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_cn = new DevExpress.XtraGrid.GridControl();
            this.gv_cn = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Rep_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.quyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IsGroupC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mn_toanquyen = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_xoaquyen = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_cn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_cn)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.gc_user);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.gc_cn);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(855, 539);
            this.splitContainerControl1.SplitterPosition = 224;
            this.splitContainerControl1.TabIndex = 1;
            // 
            // gc_user
            // 
            this.gc_user.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_user.Location = new System.Drawing.Point(0, 0);
            this.gc_user.MainView = this.gv_user;
            this.gc_user.Name = "gc_user";
            this.gc_user.Size = new System.Drawing.Size(224, 539);
            this.gc_user.TabIndex = 0;
            this.gc_user.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_user});
            // 
            // gv_user
            // 
            this.gv_user.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Isgroup,
            this.Username,
            this.Fullname,
            this.Iduser});
            this.gv_user.GridControl = this.gc_user;
            this.gv_user.Name = "gv_user";
            this.gv_user.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gv_user_CustomDrawCell);
            this.gv_user.Click += new System.EventHandler(this.gv_user_Click);
            // 
            // Isgroup
            // 
            this.Isgroup.FieldName = "Isgroup";
            this.Isgroup.Name = "Isgroup";
            this.Isgroup.Visible = true;
            this.Isgroup.VisibleIndex = 0;
            // 
            // Username
            // 
            this.Username.Caption = "Username";
            this.Username.FieldName = "Username";
            this.Username.Name = "Username";
            this.Username.Visible = true;
            this.Username.VisibleIndex = 1;
            // 
            // Fullname
            // 
            this.Fullname.Caption = "Fullname";
            this.Fullname.FieldName = "Fullname";
            this.Fullname.Name = "Fullname";
            this.Fullname.Visible = true;
            this.Fullname.VisibleIndex = 2;
            // 
            // Iduser
            // 
            this.Iduser.Caption = "Iduser";
            this.Iduser.FieldName = "Iduser";
            this.Iduser.Name = "Iduser";
            // 
            // gc_cn
            // 
            this.gc_cn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_cn.Location = new System.Drawing.Point(0, 0);
            this.gc_cn.MainView = this.gv_cn;
            this.gc_cn.Name = "gc_cn";
            this.gc_cn.Size = new System.Drawing.Size(621, 539);
            this.gc_cn.TabIndex = 0;
            this.gc_cn.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_cn});
            // 
            // gv_cn
            // 
            this.gv_cn.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Rep_code,
            this.Description,
            this.quyen,
            this.IsGroupC});
            this.gv_cn.GridControl = this.gc_cn;
            this.gv_cn.Name = "gv_cn";
            this.gv_cn.OptionsSelection.MultiSelect = true;
            // 
            // Rep_code
            // 
            this.Rep_code.Caption = "Rep_code";
            this.Rep_code.FieldName = "Rep_code";
            this.Rep_code.Name = "Rep_code";
            // 
            // Description
            // 
            this.Description.Caption = "Chức năng";
            this.Description.FieldName = "Description";
            this.Description.Name = "Description";
            this.Description.Visible = true;
            this.Description.VisibleIndex = 0;
            // 
            // quyen
            // 
            this.quyen.Caption = "Quyền";
            this.quyen.FieldName = "QUYEN";
            this.quyen.Name = "quyen";
            this.quyen.Visible = true;
            this.quyen.VisibleIndex = 1;
            // 
            // IsGroupC
            // 
            this.IsGroupC.Caption = "IsGroup";
            this.IsGroupC.FieldName = "IsGroup";
            this.IsGroupC.Name = "IsGroupC";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_toanquyen,
            this.mn_xoaquyen});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(136, 48);
            // 
            // mn_toanquyen
            // 
            this.mn_toanquyen.Name = "mn_toanquyen";
            this.mn_toanquyen.Size = new System.Drawing.Size(135, 22);
            this.mn_toanquyen.Text = "Toàn quyền";
            this.mn_toanquyen.Click += new System.EventHandler(this.mn_toanquyen_Click);
            // 
            // mn_xoaquyen
            // 
            this.mn_xoaquyen.Name = "mn_xoaquyen";
            this.mn_xoaquyen.Size = new System.Drawing.Size(135, 22);
            this.mn_xoaquyen.Text = "Xóa quyền";
            this.mn_xoaquyen.Click += new System.EventHandler(this.mn_xoaquyen_Click);
            // 
            // FrmPhanQuyenBC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 539);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "FrmPhanQuyenBC";
            this.Text = "FrmPhanQuyenBC";
            this.Load += new System.EventHandler(this.FrmPhanQuyenBC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_cn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_cn)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gc_user;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_user;
        private DevExpress.XtraGrid.Columns.GridColumn Isgroup;
        private DevExpress.XtraGrid.Columns.GridColumn Username;
        private DevExpress.XtraGrid.Columns.GridColumn Fullname;
        private DevExpress.XtraGrid.Columns.GridColumn Iduser;
        private DevExpress.XtraGrid.GridControl gc_cn;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_cn;
        private DevExpress.XtraGrid.Columns.GridColumn Rep_code;
        private DevExpress.XtraGrid.Columns.GridColumn Description;
        private DevExpress.XtraGrid.Columns.GridColumn quyen;
        private DevExpress.XtraGrid.Columns.GridColumn IsGroupC;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mn_toanquyen;
        private System.Windows.Forms.ToolStripMenuItem mn_xoaquyen;
    }
}