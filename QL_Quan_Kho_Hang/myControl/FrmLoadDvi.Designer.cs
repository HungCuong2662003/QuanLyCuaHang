namespace QL_Quan_Kho_Hang.myControl
{
    partial class FrmLoadDvi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoadDvi));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbb_congty_chinhanh = new System.Windows.Forms.ComboBox();
            this.GC_dvi = new DevExpress.XtraGrid.GridControl();
            this.GV_dvi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaDvi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenDvi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_thoat = new DevExpress.XtraEditors.SimpleButton();
            this.btn_th = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GC_dvi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_dvi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbb_congty_chinhanh);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 73);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Công ty - chi nhánh";
            // 
            // cbb_congty_chinhanh
            // 
            this.cbb_congty_chinhanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_congty_chinhanh.FormattingEnabled = true;
            this.cbb_congty_chinhanh.Location = new System.Drawing.Point(6, 25);
            this.cbb_congty_chinhanh.Name = "cbb_congty_chinhanh";
            this.cbb_congty_chinhanh.Size = new System.Drawing.Size(519, 28);
            this.cbb_congty_chinhanh.TabIndex = 7;
            // 
            // GC_dvi
            // 
            this.GC_dvi.Dock = System.Windows.Forms.DockStyle.Top;
            this.GC_dvi.Location = new System.Drawing.Point(0, 73);
            this.GC_dvi.MainView = this.GV_dvi;
            this.GC_dvi.Name = "GC_dvi";
            this.GC_dvi.Size = new System.Drawing.Size(544, 214);
            this.GC_dvi.TabIndex = 10;
            this.GC_dvi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GV_dvi});
            // 
            // GV_dvi
            // 
            this.GV_dvi.ColumnPanelRowHeight = 40;
            this.GV_dvi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaDvi,
            this.TenDvi});
            this.GV_dvi.GridControl = this.GC_dvi;
            this.GV_dvi.Name = "GV_dvi";
            this.GV_dvi.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.GV_dvi.RowHeight = 30;
            // 
            // MaDvi
            // 
            this.MaDvi.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaDvi.AppearanceCell.Options.UseFont = true;
            this.MaDvi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaDvi.AppearanceHeader.Options.UseFont = true;
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
            this.TenDvi.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenDvi.AppearanceCell.Options.UseFont = true;
            this.TenDvi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenDvi.AppearanceHeader.Options.UseFont = true;
            this.TenDvi.Caption = "Tên đơn vị";
            this.TenDvi.FieldName = "TenDvi";
            this.TenDvi.MaxWidth = 200;
            this.TenDvi.MinWidth = 100;
            this.TenDvi.Name = "TenDvi";
            this.TenDvi.Visible = true;
            this.TenDvi.VisibleIndex = 1;
            this.TenDvi.Width = 126;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Appearance.Options.UseFont = true;
            this.btn_thoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_thoat.ImageOptions.Image")));
            this.btn_thoat.Location = new System.Drawing.Point(357, 303);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(136, 41);
            this.btn_thoat.TabIndex = 12;
            this.btn_thoat.Text = "Thoát ";
            // 
            // btn_th
            // 
            this.btn_th.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_th.Appearance.Options.UseFont = true;
            this.btn_th.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_th.ImageOptions.Image")));
            this.btn_th.Location = new System.Drawing.Point(186, 303);
            this.btn_th.Name = "btn_th";
            this.btn_th.Size = new System.Drawing.Size(136, 41);
            this.btn_th.TabIndex = 11;
            this.btn_th.Text = "Thực hiện";
            // 
            // FrmLoadDvi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 356);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_th);
            this.Controls.Add(this.GC_dvi);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmLoadDvi";
            this.Text = "FrmLoadDvi";
            this.Load += new System.EventHandler(this.FrmLoadDvi_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GC_dvi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_dvi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbb_congty_chinhanh;
        private DevExpress.XtraGrid.GridControl GC_dvi;
        private DevExpress.XtraGrid.Views.Grid.GridView GV_dvi;
        private DevExpress.XtraGrid.Columns.GridColumn MaDvi;
        private DevExpress.XtraGrid.Columns.GridColumn TenDvi;
        private DevExpress.XtraEditors.SimpleButton btn_thoat;
        private DevExpress.XtraEditors.SimpleButton btn_th;
    }
}