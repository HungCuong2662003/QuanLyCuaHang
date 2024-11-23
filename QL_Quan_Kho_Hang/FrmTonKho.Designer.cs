namespace QL_Quan_Kho_Hang
{
    partial class FrmTonKho
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_tinhton = new System.Windows.Forms.ToolStripButton();
            this.btn_ex = new System.Windows.Forms.ToolStripButton();
            this.btn_thoat = new System.Windows.Forms.ToolStripButton();
            this.tabTK = new DevExpress.XtraTab.XtraTabControl();
            this.xtra_ktonkho = new DevExpress.XtraTab.XtraTabPage();
            this.pagetonkho = new DevExpress.XtraEditors.SplitContainerControl();
            this.cbb_congty_chinhanh = new System.Windows.Forms.ComboBox();
            this.text = new System.Windows.Forms.Label();
            this.date_ky = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.gctk = new DevExpress.XtraGrid.GridControl();
            this.gvtk = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BARCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LG_DAU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LG_NHAPMUA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LG_NHAPNB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LG_XUATSI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LG_BANLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LG_CUOI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TRIGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TIEN_CUOI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cbo_dvi = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabTK)).BeginInit();
            this.tabTK.SuspendLayout();
            this.xtra_ktonkho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pagetonkho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagetonkho.Panel1)).BeginInit();
            this.pagetonkho.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pagetonkho.Panel2)).BeginInit();
            this.pagetonkho.Panel2.SuspendLayout();
            this.pagetonkho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvtk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_tinhton,
            this.btn_ex,
            this.btn_thoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1043, 67);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_tinhton
            // 
            this.btn_tinhton.AutoSize = false;
            this.btn_tinhton.Image = global::QL_Quan_Kho_Hang.Properties.Resources.icons8_inventory_32;
            this.btn_tinhton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_tinhton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_tinhton.Name = "btn_tinhton";
            this.btn_tinhton.Size = new System.Drawing.Size(64, 64);
            this.btn_tinhton.Text = "Tính tồn";
            this.btn_tinhton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_tinhton.Click += new System.EventHandler(this.btn_tinhton_Click);
            // 
            // btn_ex
            // 
            this.btn_ex.Image = global::QL_Quan_Kho_Hang.Properties.Resources.icons8_excel_48;
            this.btn_ex.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_ex.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_ex.Name = "btn_ex";
            this.btn_ex.Size = new System.Drawing.Size(62, 64);
            this.btn_ex.Text = "Export ";
            this.btn_ex.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_ex.Click += new System.EventHandler(this.btn_ex_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Image = global::QL_Quan_Kho_Hang.Properties.Resources.icons8_close_32;
            this.btn_thoat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_thoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(53, 64);
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tabTK
            // 
            this.tabTK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabTK.Location = new System.Drawing.Point(0, 67);
            this.tabTK.Name = "tabTK";
            this.tabTK.SelectedTabPage = this.xtra_ktonkho;
            this.tabTK.Size = new System.Drawing.Size(1043, 463);
            this.tabTK.TabIndex = 4;
            this.tabTK.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtra_ktonkho});
            // 
            // xtra_ktonkho
            // 
            this.xtra_ktonkho.Appearance.HeaderActive.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtra_ktonkho.Appearance.HeaderActive.Options.UseFont = true;
            this.xtra_ktonkho.Controls.Add(this.pagetonkho);
            this.xtra_ktonkho.Name = "xtra_ktonkho";
            this.xtra_ktonkho.Size = new System.Drawing.Size(1041, 432);
            this.xtra_ktonkho.Text = "Tồn kho";
            // 
            // pagetonkho
            // 
            this.pagetonkho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pagetonkho.Horizontal = false;
            this.pagetonkho.Location = new System.Drawing.Point(0, 0);
            this.pagetonkho.Name = "pagetonkho";
            // 
            // pagetonkho.Panel1
            // 
            this.pagetonkho.Panel1.Controls.Add(this.cbo_dvi);
            this.pagetonkho.Panel1.Controls.Add(this.label8);
            this.pagetonkho.Panel1.Controls.Add(this.cbb_congty_chinhanh);
            this.pagetonkho.Panel1.Controls.Add(this.text);
            this.pagetonkho.Panel1.Controls.Add(this.date_ky);
            this.pagetonkho.Panel1.Controls.Add(this.label1);
            this.pagetonkho.Panel1.Text = "Panel1";
            // 
            // pagetonkho.Panel2
            // 
            this.pagetonkho.Panel2.Controls.Add(this.gctk);
            this.pagetonkho.Panel2.Text = "Panel2";
            this.pagetonkho.Size = new System.Drawing.Size(1041, 432);
            this.pagetonkho.SplitterPosition = 65;
            this.pagetonkho.TabIndex = 2;
            // 
            // cbb_congty_chinhanh
            // 
            this.cbb_congty_chinhanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_congty_chinhanh.FormattingEnabled = true;
            this.cbb_congty_chinhanh.Location = new System.Drawing.Point(534, 23);
            this.cbb_congty_chinhanh.Name = "cbb_congty_chinhanh";
            this.cbb_congty_chinhanh.Size = new System.Drawing.Size(150, 28);
            this.cbb_congty_chinhanh.TabIndex = 5;
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.Location = new System.Drawing.Point(354, 27);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(167, 20);
            this.text.TabIndex = 4;
            this.text.Text = "Công ty - Chi nhánh";
            // 
            // date_ky
            // 
            this.date_ky.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_ky.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_ky.Location = new System.Drawing.Point(135, 27);
            this.date_ky.Name = "date_ky";
            this.date_ky.Size = new System.Drawing.Size(150, 26);
            this.date_ky.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn kỳ";
            // 
            // gctk
            // 
            this.gctk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gctk.Location = new System.Drawing.Point(0, 0);
            this.gctk.MainView = this.gvtk;
            this.gctk.Name = "gctk";
            this.gctk.Size = new System.Drawing.Size(1041, 357);
            this.gctk.TabIndex = 0;
            this.gctk.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvtk,
            this.gridView2});
            // 
            // gvtk
            // 
            this.gvtk.ColumnPanelRowHeight = 40;
            this.gvtk.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.BARCODE,
            this.TenHH,
            this.DVT,
            this.LG_DAU,
            this.LG_NHAPMUA,
            this.LG_NHAPNB,
            this.LG_XUATSI,
            this.LG_BANLE,
            this.LG_CUOI,
            this.TRIGIA,
            this.TIEN_CUOI});
            this.gvtk.GridControl = this.gctk;
            this.gvtk.Name = "gvtk";
            this.gvtk.OptionsBehavior.Editable = false;
            this.gvtk.OptionsFind.AlwaysVisible = true;
            this.gvtk.OptionsView.ShowFooter = true;
            this.gvtk.RowHeight = 30;
            // 
            // BARCODE
            // 
            this.BARCODE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BARCODE.AppearanceCell.Options.UseFont = true;
            this.BARCODE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BARCODE.AppearanceHeader.Options.UseFont = true;
            this.BARCODE.Caption = "BARCODE";
            this.BARCODE.FieldName = "BARCODE";
            this.BARCODE.Name = "BARCODE";
            this.BARCODE.Visible = true;
            this.BARCODE.VisibleIndex = 0;
            // 
            // TenHH
            // 
            this.TenHH.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenHH.AppearanceCell.Options.UseFont = true;
            this.TenHH.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenHH.AppearanceHeader.Options.UseFont = true;
            this.TenHH.Caption = "TÊN HÀNG";
            this.TenHH.FieldName = "TenHH";
            this.TenHH.Name = "TenHH";
            this.TenHH.Visible = true;
            this.TenHH.VisibleIndex = 1;
            // 
            // DVT
            // 
            this.DVT.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DVT.AppearanceCell.Options.UseFont = true;
            this.DVT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DVT.AppearanceHeader.Options.UseFont = true;
            this.DVT.Caption = "DVT";
            this.DVT.FieldName = "DVT";
            this.DVT.Name = "DVT";
            this.DVT.Visible = true;
            this.DVT.VisibleIndex = 2;
            // 
            // LG_DAU
            // 
            this.LG_DAU.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LG_DAU.AppearanceCell.Options.UseFont = true;
            this.LG_DAU.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LG_DAU.AppearanceHeader.Options.UseFont = true;
            this.LG_DAU.Caption = "LG TỒN ĐẦU ";
            this.LG_DAU.FieldName = "LG_DAU";
            this.LG_DAU.Name = "LG_DAU";
            this.LG_DAU.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LG_DAU", "SUM={0:0.##}")});
            this.LG_DAU.Visible = true;
            this.LG_DAU.VisibleIndex = 3;
            // 
            // LG_NHAPMUA
            // 
            this.LG_NHAPMUA.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LG_NHAPMUA.AppearanceCell.Options.UseFont = true;
            this.LG_NHAPMUA.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LG_NHAPMUA.AppearanceHeader.Options.UseFont = true;
            this.LG_NHAPMUA.Caption = "LG NHẬP MUA";
            this.LG_NHAPMUA.FieldName = "LG_NHAPMUA";
            this.LG_NHAPMUA.Name = "LG_NHAPMUA";
            this.LG_NHAPMUA.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LG_NHAPMUA", "SUM={0:0.##}")});
            this.LG_NHAPMUA.Visible = true;
            this.LG_NHAPMUA.VisibleIndex = 4;
            // 
            // LG_NHAPNB
            // 
            this.LG_NHAPNB.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LG_NHAPNB.AppearanceCell.Options.UseFont = true;
            this.LG_NHAPNB.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LG_NHAPNB.AppearanceHeader.Options.UseFont = true;
            this.LG_NHAPNB.Caption = "LG NHẬP NỘI BỘ";
            this.LG_NHAPNB.FieldName = "LG_NHAPNB";
            this.LG_NHAPNB.Name = "LG_NHAPNB";
            this.LG_NHAPNB.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LG_NHAPNB", "SUM={0:0.##}")});
            this.LG_NHAPNB.Visible = true;
            this.LG_NHAPNB.VisibleIndex = 5;
            // 
            // LG_XUATSI
            // 
            this.LG_XUATSI.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LG_XUATSI.AppearanceCell.Options.UseFont = true;
            this.LG_XUATSI.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LG_XUATSI.AppearanceHeader.Options.UseFont = true;
            this.LG_XUATSI.Caption = "LG XUẤT SỈ";
            this.LG_XUATSI.FieldName = "LG_XUATSI";
            this.LG_XUATSI.Name = "LG_XUATSI";
            this.LG_XUATSI.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LG_XUATSI", "SUM={0:0.##}")});
            this.LG_XUATSI.Visible = true;
            this.LG_XUATSI.VisibleIndex = 6;
            // 
            // LG_BANLE
            // 
            this.LG_BANLE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LG_BANLE.AppearanceCell.Options.UseFont = true;
            this.LG_BANLE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LG_BANLE.AppearanceHeader.Options.UseFont = true;
            this.LG_BANLE.Caption = "LG BÁN LẺ";
            this.LG_BANLE.FieldName = "LG_BANLE";
            this.LG_BANLE.Name = "LG_BANLE";
            this.LG_BANLE.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LG_BANLE", "SUM={0:0.##}")});
            this.LG_BANLE.Visible = true;
            this.LG_BANLE.VisibleIndex = 7;
            // 
            // LG_CUOI
            // 
            this.LG_CUOI.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LG_CUOI.AppearanceCell.Options.UseFont = true;
            this.LG_CUOI.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LG_CUOI.AppearanceHeader.Options.UseFont = true;
            this.LG_CUOI.Caption = "LG TỒN CUỐI";
            this.LG_CUOI.FieldName = "LG_CUOI";
            this.LG_CUOI.Name = "LG_CUOI";
            this.LG_CUOI.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LG_CUOI", "SUM={0:0.##}")});
            this.LG_CUOI.Visible = true;
            this.LG_CUOI.VisibleIndex = 8;
            // 
            // TRIGIA
            // 
            this.TRIGIA.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TRIGIA.AppearanceCell.Options.UseFont = true;
            this.TRIGIA.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TRIGIA.AppearanceHeader.Options.UseFont = true;
            this.TRIGIA.Caption = "ĐƠN GIÁ";
            this.TRIGIA.DisplayFormat.FormatString = "{0:N0}";
            this.TRIGIA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TRIGIA.FieldName = "TRIGIA";
            this.TRIGIA.Name = "TRIGIA";
            this.TRIGIA.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TRIGIA", "SUM={0:0.##}")});
            this.TRIGIA.Visible = true;
            this.TRIGIA.VisibleIndex = 9;
            // 
            // TIEN_CUOI
            // 
            this.TIEN_CUOI.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TIEN_CUOI.AppearanceCell.Options.UseFont = true;
            this.TIEN_CUOI.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TIEN_CUOI.AppearanceHeader.Options.UseFont = true;
            this.TIEN_CUOI.Caption = "THÀNH TIỀN";
            this.TIEN_CUOI.DisplayFormat.FormatString = "{0:N0}";
            this.TIEN_CUOI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TIEN_CUOI.FieldName = "TIEN_CUOI";
            this.TIEN_CUOI.Name = "TIEN_CUOI";
            this.TIEN_CUOI.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TIEN_CUOI", "SUM={0:0.##}")});
            this.TIEN_CUOI.Visible = true;
            this.TIEN_CUOI.VisibleIndex = 10;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gctk;
            this.gridView2.Name = "gridView2";
            // 
            // cbo_dvi
            // 
            this.cbo_dvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_dvi.FormattingEnabled = true;
            this.cbo_dvi.Location = new System.Drawing.Point(841, 23);
            this.cbo_dvi.Name = "cbo_dvi";
            this.cbo_dvi.Size = new System.Drawing.Size(170, 28);
            this.cbo_dvi.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(751, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Đơn vị ";
            // 
            // FrmTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 530);
            this.Controls.Add(this.tabTK);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmTonKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmTonKho_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabTK)).EndInit();
            this.tabTK.ResumeLayout(false);
            this.xtra_ktonkho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pagetonkho.Panel1)).EndInit();
            this.pagetonkho.Panel1.ResumeLayout(false);
            this.pagetonkho.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pagetonkho.Panel2)).EndInit();
            this.pagetonkho.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pagetonkho)).EndInit();
            this.pagetonkho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gctk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvtk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_tinhton;
        private System.Windows.Forms.ToolStripButton btn_ex;
        private System.Windows.Forms.ToolStripButton btn_thoat;
        private DevExpress.XtraTab.XtraTabControl tabTK;
        private DevExpress.XtraTab.XtraTabPage xtra_ktonkho;
        private DevExpress.XtraEditors.SplitContainerControl pagetonkho;
        private System.Windows.Forms.ComboBox cbb_congty_chinhanh;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.DateTimePicker date_ky;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gctk;
        private DevExpress.XtraGrid.Views.Grid.GridView gvtk;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn BARCODE;
        private DevExpress.XtraGrid.Columns.GridColumn TenHH;
        private DevExpress.XtraGrid.Columns.GridColumn DVT;
        private DevExpress.XtraGrid.Columns.GridColumn LG_DAU;
        private DevExpress.XtraGrid.Columns.GridColumn LG_NHAPMUA;
        private DevExpress.XtraGrid.Columns.GridColumn LG_NHAPNB;
        private DevExpress.XtraGrid.Columns.GridColumn LG_XUATSI;
        private DevExpress.XtraGrid.Columns.GridColumn LG_BANLE;
        private DevExpress.XtraGrid.Columns.GridColumn LG_CUOI;
        private DevExpress.XtraGrid.Columns.GridColumn TRIGIA;
        private DevExpress.XtraGrid.Columns.GridColumn TIEN_CUOI;
        private System.Windows.Forms.ComboBox cbo_dvi;
        private System.Windows.Forms.Label label8;
    }
}