namespace QL_Quan_Kho_Hang
{
    partial class FrmBarcode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBarcode));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btn_print = new DevExpress.XtraBars.BarButtonItem();
            this.btn_exit = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbo_nhom = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gc_danhmuc = new DevExpress.XtraGrid.GridControl();
            this.gv_danhmuc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BarCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenTat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SOTEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaBan = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_danhmuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_danhmuc)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btn_print,
            this.btn_exit});
            this.barManager1.MaxItemId = 2;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_print),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_exit)});
            this.bar1.Text = "Tools";
            // 
            // btn_print
            // 
            this.btn_print.Caption = "Print Barcode";
            this.btn_print.Id = 0;
            this.btn_print.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_print.ImageOptions.Image")));
            this.btn_print.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_print.ImageOptions.LargeImage")));
            this.btn_print.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.ItemAppearance.Normal.Options.UseFont = true;
            this.btn_print.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            this.btn_print.Name = "btn_print";
            this.btn_print.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_print.Size = new System.Drawing.Size(0, 50);
            this.btn_print.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_print_ItemClick);
            // 
            // btn_exit
            // 
            this.btn_exit.Caption = "Thoát";
            this.btn_exit.Id = 1;
            this.btn_exit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.ImageOptions.Image")));
            this.btn_exit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_exit.ImageOptions.LargeImage")));
            this.btn_exit.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ItemAppearance.Normal.Options.UseFont = true;
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_exit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_exit_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(963, 50);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 572);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(963, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 50);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 522);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(963, 50);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 522);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbo_nhom);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(963, 65);
            this.panel1.TabIndex = 4;
            // 
            // cbo_nhom
            // 
            this.cbo_nhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_nhom.FormattingEnabled = true;
            this.cbo_nhom.Location = new System.Drawing.Point(188, 24);
            this.cbo_nhom.Name = "cbo_nhom";
            this.cbo_nhom.Size = new System.Drawing.Size(297, 28);
            this.cbo_nhom.TabIndex = 1;
            this.cbo_nhom.SelectedIndexChanged += new System.EventHandler(this.cbo_nhom_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(98, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(82, 20);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Nhóm hàng";
            // 
            // gc_danhmuc
            // 
            this.gc_danhmuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_danhmuc.Location = new System.Drawing.Point(0, 115);
            this.gc_danhmuc.MainView = this.gv_danhmuc;
            this.gc_danhmuc.MenuManager = this.barManager1;
            this.gc_danhmuc.Name = "gc_danhmuc";
            this.gc_danhmuc.Size = new System.Drawing.Size(963, 457);
            this.gc_danhmuc.TabIndex = 5;
            this.gc_danhmuc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_danhmuc});
            // 
            // gv_danhmuc
            // 
            this.gv_danhmuc.ColumnPanelRowHeight = 40;
            this.gv_danhmuc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.BarCode,
            this.TenHH,
            this.TenTat,
            this.DVT,
            this.DonGia,
            this.GiaBan,
            this.SOTEM});
            this.gv_danhmuc.GridControl = this.gc_danhmuc;
            this.gv_danhmuc.Name = "gv_danhmuc";
            this.gv_danhmuc.OptionsFind.AlwaysVisible = true;
            this.gv_danhmuc.RowHeight = 30;
            // 
            // BarCode
            // 
            this.BarCode.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarCode.AppearanceCell.Options.UseFont = true;
            this.BarCode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarCode.AppearanceHeader.Options.UseFont = true;
            this.BarCode.Caption = "BarCode";
            this.BarCode.FieldName = "BarCode";
            this.BarCode.Name = "BarCode";
            this.BarCode.OptionsColumn.AllowEdit = false;
            this.BarCode.Visible = true;
            this.BarCode.VisibleIndex = 0;
            // 
            // TenHH
            // 
            this.TenHH.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenHH.AppearanceCell.Options.UseFont = true;
            this.TenHH.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenHH.AppearanceHeader.Options.UseFont = true;
            this.TenHH.Caption = "Tên hàng";
            this.TenHH.FieldName = "TenHH";
            this.TenHH.Name = "TenHH";
            this.TenHH.OptionsColumn.AllowEdit = false;
            this.TenHH.Visible = true;
            this.TenHH.VisibleIndex = 1;
            // 
            // TenTat
            // 
            this.TenTat.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenTat.AppearanceCell.Options.UseFont = true;
            this.TenTat.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenTat.AppearanceHeader.Options.UseFont = true;
            this.TenTat.Caption = "Tên tắt";
            this.TenTat.FieldName = "TenTat";
            this.TenTat.Name = "TenTat";
            this.TenTat.OptionsColumn.AllowEdit = false;
            this.TenTat.Visible = true;
            this.TenTat.VisibleIndex = 2;
            // 
            // DVT
            // 
            this.DVT.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DVT.AppearanceCell.Options.UseFont = true;
            this.DVT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DVT.AppearanceHeader.Options.UseFont = true;
            this.DVT.Caption = "Đơn vị tính";
            this.DVT.FieldName = "DVT";
            this.DVT.Name = "DVT";
            this.DVT.OptionsColumn.AllowEdit = false;
            this.DVT.Visible = true;
            this.DVT.VisibleIndex = 3;
            // 
            // DonGia
            // 
            this.DonGia.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonGia.AppearanceCell.Options.UseFont = true;
            this.DonGia.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonGia.AppearanceHeader.Options.UseFont = true;
            this.DonGia.Caption = "Đơn giá";
            this.DonGia.FieldName = "DonGia";
            this.DonGia.Name = "DonGia";
            this.DonGia.OptionsColumn.AllowEdit = false;
            this.DonGia.Visible = true;
            this.DonGia.VisibleIndex = 4;
            // 
            // SOTEM
            // 
            this.SOTEM.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SOTEM.AppearanceCell.Options.UseFont = true;
            this.SOTEM.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SOTEM.AppearanceHeader.Options.UseFont = true;
            this.SOTEM.Caption = "Số lượng ";
            this.SOTEM.FieldName = "SOTEM";
            this.SOTEM.Name = "SOTEM";
            this.SOTEM.Visible = true;
            this.SOTEM.VisibleIndex = 6;
            // 
            // GiaBan
            // 
            this.GiaBan.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GiaBan.AppearanceCell.Options.UseFont = true;
            this.GiaBan.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GiaBan.AppearanceHeader.Options.UseFont = true;
            this.GiaBan.Caption = "GiaBan";
            this.GiaBan.FieldName = "GiaBan";
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.Visible = true;
            this.GiaBan.VisibleIndex = 5;
            // 
            // FrmBarcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(963, 572);
            this.Controls.Add(this.gc_danhmuc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmBarcode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmBarcode";
            this.Load += new System.EventHandler(this.FrmBarcode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_danhmuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_danhmuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btn_print;
        private DevExpress.XtraBars.BarButtonItem btn_exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbo_nhom;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gc_danhmuc;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_danhmuc;
        private DevExpress.XtraGrid.Columns.GridColumn BarCode;
        private DevExpress.XtraGrid.Columns.GridColumn TenHH;
        private DevExpress.XtraGrid.Columns.GridColumn TenTat;
        private DevExpress.XtraGrid.Columns.GridColumn DVT;
        private DevExpress.XtraGrid.Columns.GridColumn DonGia;
        private DevExpress.XtraGrid.Columns.GridColumn SOTEM;
        private DevExpress.XtraGrid.Columns.GridColumn GiaBan;
    }
}