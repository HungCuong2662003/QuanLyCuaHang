namespace QL_Quan_Kho_Hang
{
    partial class Frmxuatxu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmxuatxu));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_them = new System.Windows.Forms.ToolStripButton();
            this.btn_sua = new System.Windows.Forms.ToolStripButton();
            this.btn_xoa = new System.Windows.Forms.ToolStripButton();
            this.btn_luu = new System.Windows.Forms.ToolStripButton();
            this.btn_boqua = new System.Windows.Forms.ToolStripButton();
            this.btn_thoat = new System.Windows.Forms.ToolStripButton();
            this.GC_Ds = new DevExpress.XtraGrid.GridControl();
            this.GV_Ds = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_dis = new System.Windows.Forms.CheckBox();
            this.Disable = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.toolStrip1.Size = new System.Drawing.Size(653, 38);
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
            this.GC_Ds.Size = new System.Drawing.Size(653, 307);
            this.GC_Ds.TabIndex = 3;
            this.GC_Ds.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GV_Ds});
            // 
            // GV_Ds
            // 
            this.GV_Ds.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.Ten,
            this.Disable});
            this.GV_Ds.GridControl = this.GC_Ds;
            this.GV_Ds.Name = "GV_Ds";
            this.GV_Ds.Click += new System.EventHandler(this.GV_Ds_Click);
            // 
            // ID
            // 
            this.ID.Caption = "ID xuất xứ";
            this.ID.FieldName = "ID";
            this.ID.MaxWidth = 200;
            this.ID.MinWidth = 150;
            this.ID.Name = "ID";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            this.ID.Width = 200;
            // 
            // Ten
            // 
            this.Ten.Caption = "Nơi xuất xứ";
            this.Ten.FieldName = "Ten";
            this.Ten.MaxWidth = 600;
            this.Ten.MinWidth = 400;
            this.Ten.Name = "Ten";
            this.Ten.Visible = true;
            this.Ten.VisibleIndex = 1;
            this.Ten.Width = 600;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cb_dis);
            this.groupControl1.Controls.Add(this.txt_id);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.txt_ten);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 345);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(653, 171);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Thông  tin ";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(184, 63);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(150, 21);
            this.txt_id.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "ID xuất xứ";
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(184, 113);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(150, 21);
            this.txt_ten.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nơi xuất xứ";
            // 
            // cb_dis
            // 
            this.cb_dis.AutoSize = true;
            this.cb_dis.Location = new System.Drawing.Point(442, 87);
            this.cb_dis.Name = "cb_dis";
            this.cb_dis.Size = new System.Drawing.Size(60, 17);
            this.cb_dis.TabIndex = 15;
            this.cb_dis.Text = "Disable";
            this.cb_dis.UseVisualStyleBackColor = true;
            // 
            // Disable
            // 
            this.Disable.Caption = "Tình trạng";
            this.Disable.FieldName = "Disable";
            this.Disable.MaxWidth = 100;
            this.Disable.MinWidth = 100;
            this.Disable.Name = "Disable";
            this.Disable.Visible = true;
            this.Disable.VisibleIndex = 2;
            this.Disable.Width = 100;
            // 
            // Frmxuatxu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 516);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.GC_Ds);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Frmxuatxu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục xuất xứ";
            this.Load += new System.EventHandler(this.Frmxuatxu_Load);
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
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn Ten;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cb_dis;
        private DevExpress.XtraGrid.Columns.GridColumn Disable;
    }
}