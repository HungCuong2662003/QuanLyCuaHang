namespace QL_Quan_Ban_Hang
{
    partial class FrmBanHang_QL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBanHang_QL));
            this.txt_barcode = new System.Windows.Forms.TextBox();
            this.btn_In = new DevExpress.XtraEditors.SimpleButton();
            this.btn_tra = new DevExpress.XtraEditors.SimpleButton();
            this.btn_chietkhau = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gcchitiet = new DevExpress.XtraGrid.GridControl();
            this.gvchitiet = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Barcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoluongCT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Chietkhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Thanhtien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleterow = new System.Windows.Forms.ToolStripMenuItem();
            this.deletect = new System.Windows.Forms.ToolStripMenuItem();
            this.chk_CK = new System.Windows.Forms.CheckBox();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcchitiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvchitiet)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_barcode
            // 
            this.txt_barcode.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_barcode.Location = new System.Drawing.Point(25, 89);
            this.txt_barcode.Name = "txt_barcode";
            this.txt_barcode.Size = new System.Drawing.Size(247, 40);
            this.txt_barcode.TabIndex = 1;
            this.txt_barcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_barcode_KeyDown);
            // 
            // btn_In
            // 
            this.btn_In.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_In.Appearance.Options.UseFont = true;
            this.btn_In.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_In.ImageOptions.Image")));
            this.btn_In.Location = new System.Drawing.Point(493, 91);
            this.btn_In.Name = "btn_In";
            this.btn_In.Size = new System.Drawing.Size(164, 41);
            this.btn_In.TabIndex = 2;
            this.btn_In.Text = "IN BILL";
            this.btn_In.Click += new System.EventHandler(this.btn_In_Click);
            // 
            // btn_tra
            // 
            this.btn_tra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_tra.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tra.Appearance.Options.UseFont = true;
            this.btn_tra.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_tra.ImageOptions.Image")));
            this.btn_tra.Location = new System.Drawing.Point(915, 91);
            this.btn_tra.Name = "btn_tra";
            this.btn_tra.Size = new System.Drawing.Size(164, 41);
            this.btn_tra.TabIndex = 3;
            this.btn_tra.Text = "TRẢ HÀNG";
            this.btn_tra.Click += new System.EventHandler(this.btn_tra_Click);
            // 
            // btn_chietkhau
            // 
            this.btn_chietkhau.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_chietkhau.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chietkhau.Appearance.Options.UseFont = true;
            this.btn_chietkhau.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_chietkhau.ImageOptions.Image")));
            this.btn_chietkhau.Location = new System.Drawing.Point(693, 92);
            this.btn_chietkhau.Name = "btn_chietkhau";
            this.btn_chietkhau.Size = new System.Drawing.Size(164, 41);
            this.btn_chietkhau.TabIndex = 4;
            this.btn_chietkhau.Text = "CHIẾT KHẤU";
            this.btn_chietkhau.Click += new System.EventHandler(this.btn_chietkhau_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "BARCODE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QL_Quan_Ban_Hang.Properties.Resources.tải_xuống__9_;
            this.pictureBox1.Location = new System.Drawing.Point(103, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // gcchitiet
            // 
            this.gcchitiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcchitiet.Location = new System.Drawing.Point(0, 0);
            this.gcchitiet.MainView = this.gvchitiet;
            this.gcchitiet.Name = "gcchitiet";
            this.gcchitiet.Size = new System.Drawing.Size(1091, 401);
            this.gcchitiet.TabIndex = 8;
            this.gcchitiet.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvchitiet});
            this.gcchitiet.Click += new System.EventHandler(this.gcchitiet_Click);
            // 
            // gvchitiet
            // 
            this.gvchitiet.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvchitiet.Appearance.Row.Options.UseFont = true;
            this.gvchitiet.ColumnPanelRowHeight = 40;
            this.gvchitiet.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Barcode,
            this.TenHH,
            this.SoluongCT,
            this.DVT,
            this.GiaBan,
            this.Chietkhau,
            this.Thanhtien});
            this.gvchitiet.GridControl = this.gcchitiet;
            this.gvchitiet.GroupRowHeight = 30;
            this.gvchitiet.Name = "gvchitiet";
            this.gvchitiet.OptionsView.ShowFooter = true;
            this.gvchitiet.OptionsView.ShowGroupPanel = false;
            this.gvchitiet.RowHeight = 30;
            this.gvchitiet.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvchitiet_CellValueChanged);
            // 
            // Barcode
            // 
            this.Barcode.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Barcode.AppearanceCell.Options.UseFont = true;
            this.Barcode.AppearanceCell.Options.UseTextOptions = true;
            this.Barcode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Barcode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Barcode.AppearanceHeader.Options.UseFont = true;
            this.Barcode.AppearanceHeader.Options.UseTextOptions = true;
            this.Barcode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Barcode.Caption = "Barcode";
            this.Barcode.FieldName = "Barcode";
            this.Barcode.Name = "Barcode";
            this.Barcode.Visible = true;
            this.Barcode.VisibleIndex = 0;
            // 
            // TenHH
            // 
            this.TenHH.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenHH.AppearanceCell.Options.UseFont = true;
            this.TenHH.AppearanceCell.Options.UseTextOptions = true;
            this.TenHH.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TenHH.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenHH.AppearanceHeader.Options.UseFont = true;
            this.TenHH.AppearanceHeader.Options.UseTextOptions = true;
            this.TenHH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TenHH.Caption = "Tên hàng hóa";
            this.TenHH.FieldName = "TenHH";
            this.TenHH.Name = "TenHH";
            this.TenHH.Visible = true;
            this.TenHH.VisibleIndex = 2;
            // 
            // SoluongCT
            // 
            this.SoluongCT.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoluongCT.AppearanceCell.Options.UseFont = true;
            this.SoluongCT.AppearanceCell.Options.UseTextOptions = true;
            this.SoluongCT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SoluongCT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoluongCT.AppearanceHeader.Options.UseFont = true;
            this.SoluongCT.AppearanceHeader.Options.UseTextOptions = true;
            this.SoluongCT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SoluongCT.Caption = "Số lượng ";
            this.SoluongCT.DisplayFormat.FormatString = "N0";
            this.SoluongCT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SoluongCT.FieldName = "SoluongCT";
            this.SoluongCT.Name = "SoluongCT";
            this.SoluongCT.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SoluongCT", "{0:N0}")});
            this.SoluongCT.Visible = true;
            this.SoluongCT.VisibleIndex = 1;
            // 
            // DVT
            // 
            this.DVT.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DVT.AppearanceCell.Options.UseFont = true;
            this.DVT.AppearanceCell.Options.UseTextOptions = true;
            this.DVT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DVT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DVT.AppearanceHeader.Options.UseFont = true;
            this.DVT.AppearanceHeader.Options.UseTextOptions = true;
            this.DVT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DVT.Caption = "Đơn vị tính";
            this.DVT.FieldName = "DVT";
            this.DVT.Name = "DVT";
            this.DVT.Visible = true;
            this.DVT.VisibleIndex = 3;
            // 
            // GiaBan
            // 
            this.GiaBan.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GiaBan.AppearanceCell.Options.UseFont = true;
            this.GiaBan.AppearanceCell.Options.UseTextOptions = true;
            this.GiaBan.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GiaBan.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GiaBan.AppearanceHeader.Options.UseFont = true;
            this.GiaBan.AppearanceHeader.Options.UseTextOptions = true;
            this.GiaBan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GiaBan.Caption = "Giá bán";
            this.GiaBan.DisplayFormat.FormatString = "N0";
            this.GiaBan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaBan.FieldName = "GiaBan";
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Dongia", "{0:N0}")});
            this.GiaBan.Visible = true;
            this.GiaBan.VisibleIndex = 4;
            // 
            // Chietkhau
            // 
            this.Chietkhau.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chietkhau.AppearanceCell.Options.UseFont = true;
            this.Chietkhau.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chietkhau.AppearanceHeader.Options.UseFont = true;
            this.Chietkhau.Caption = "Chiết khấu (%)";
            this.Chietkhau.FieldName = "Chietkhau";
            this.Chietkhau.Name = "Chietkhau";
            this.Chietkhau.Visible = true;
            this.Chietkhau.VisibleIndex = 5;
            // 
            // Thanhtien
            // 
            this.Thanhtien.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thanhtien.AppearanceCell.Options.UseFont = true;
            this.Thanhtien.AppearanceCell.Options.UseTextOptions = true;
            this.Thanhtien.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Thanhtien.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thanhtien.AppearanceHeader.Options.UseFont = true;
            this.Thanhtien.AppearanceHeader.Options.UseTextOptions = true;
            this.Thanhtien.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Thanhtien.Caption = "Thành tiền";
            this.Thanhtien.DisplayFormat.FormatString = "N0";
            this.Thanhtien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Thanhtien.FieldName = "Thanhtien";
            this.Thanhtien.Name = "Thanhtien";
            this.Thanhtien.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Thanhtien", "{0:N0}")});
            this.Thanhtien.Visible = true;
            this.Thanhtien.VisibleIndex = 6;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleterow,
            this.deletect});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(154, 56);
            // 
            // deleterow
            // 
            this.deleterow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleterow.Name = "deleterow";
            this.deleterow.Size = new System.Drawing.Size(153, 26);
            this.deleterow.Text = "Xóa dòng";
            this.deleterow.Click += new System.EventHandler(this.deleterow_Click);
            // 
            // deletect
            // 
            this.deletect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletect.Name = "deletect";
            this.deletect.Size = new System.Drawing.Size(153, 26);
            this.deletect.Text = "Xóa chi tiết";
            this.deletect.Click += new System.EventHandler(this.deletect_Click);
            // 
            // chk_CK
            // 
            this.chk_CK.AutoSize = true;
            this.chk_CK.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_CK.Location = new System.Drawing.Point(306, 98);
            this.chk_CK.Name = "chk_CK";
            this.chk_CK.Size = new System.Drawing.Size(164, 27);
            this.chk_CK.TabIndex = 18;
            this.chk_CK.Text = "Chuyển khoản";
            this.chk_CK.UseVisualStyleBackColor = true;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.chk_CK);
            this.splitContainerControl1.Panel1.Controls.Add(this.txt_barcode);
            this.splitContainerControl1.Panel1.Controls.Add(this.btn_In);
            this.splitContainerControl1.Panel1.Controls.Add(this.label1);
            this.splitContainerControl1.Panel1.Controls.Add(this.btn_tra);
            this.splitContainerControl1.Panel1.Controls.Add(this.btn_chietkhau);
            this.splitContainerControl1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.gcchitiet);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1091, 621);
            this.splitContainerControl1.SplitterPosition = 210;
            this.splitContainerControl1.TabIndex = 19;
            // 
            // FrmBanHang_QL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 621);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "FrmBanHang_QL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmBanHang_QL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmBanHang_QL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcchitiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvchitiet)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            this.splitContainerControl1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_barcode;
        private DevExpress.XtraEditors.SimpleButton btn_In;
        private DevExpress.XtraEditors.SimpleButton btn_tra;
        private DevExpress.XtraEditors.SimpleButton btn_chietkhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraGrid.GridControl gcchitiet;
        private DevExpress.XtraGrid.Views.Grid.GridView gvchitiet;
        private DevExpress.XtraGrid.Columns.GridColumn Barcode;
        private DevExpress.XtraGrid.Columns.GridColumn TenHH;
        private DevExpress.XtraGrid.Columns.GridColumn SoluongCT;
        private DevExpress.XtraGrid.Columns.GridColumn DVT;
        private DevExpress.XtraGrid.Columns.GridColumn GiaBan;
        private DevExpress.XtraGrid.Columns.GridColumn Thanhtien;
        private DevExpress.XtraGrid.Columns.GridColumn Chietkhau;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleterow;
        private System.Windows.Forms.ToolStripMenuItem deletect;
        private System.Windows.Forms.CheckBox chk_CK;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
    }
}