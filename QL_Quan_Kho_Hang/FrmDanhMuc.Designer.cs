namespace QL_Quan_Kho_Hang
{
    partial class FrmDanhMuc
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
            this.gcdanhsach = new DevExpress.XtraGrid.GridControl();
            this.gvdanhsach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BarCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Import = new DevExpress.XtraEditors.SimpleButton();
            this.exit = new DevExpress.XtraEditors.SimpleButton();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cbb_id = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gcdanhsach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvdanhsach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcdanhsach
            // 
            this.gcdanhsach.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcdanhsach.Location = new System.Drawing.Point(12, 45);
            this.gcdanhsach.MainView = this.gvdanhsach;
            this.gcdanhsach.Name = "gcdanhsach";
            this.gcdanhsach.Size = new System.Drawing.Size(888, 458);
            this.gcdanhsach.TabIndex = 0;
            this.gcdanhsach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvdanhsach});
            // 
            // gvdanhsach
            // 
            this.gvdanhsach.ColumnPanelRowHeight = 30;
            this.gvdanhsach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.BarCode,
            this.TenHH,
            this.DVT,
            this.DonGia,
            this.GiaBan});
            this.gvdanhsach.GridControl = this.gcdanhsach;
            this.gvdanhsach.GroupRowHeight = 30;
            this.gvdanhsach.Name = "gvdanhsach";
            this.gvdanhsach.NewItemRowText = "30";
            this.gvdanhsach.OptionsSelection.MultiSelect = true;
            this.gvdanhsach.RowHeight = 30;
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
            this.BarCode.Visible = true;
            this.BarCode.VisibleIndex = 0;
            // 
            // TenHH
            // 
            this.TenHH.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenHH.AppearanceCell.Options.UseFont = true;
            this.TenHH.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenHH.AppearanceHeader.Options.UseFont = true;
            this.TenHH.Caption = "TenHH";
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
            // DonGia
            // 
            this.DonGia.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonGia.AppearanceCell.Options.UseFont = true;
            this.DonGia.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonGia.AppearanceHeader.Options.UseFont = true;
            this.DonGia.Caption = "DonGia";
            this.DonGia.DisplayFormat.FormatString = "N0";
            this.DonGia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DonGia.FieldName = "DonGia";
            this.DonGia.Name = "DonGia";
            this.DonGia.Visible = true;
            this.DonGia.VisibleIndex = 3;
            // 
            // GiaBan
            // 
            this.GiaBan.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GiaBan.AppearanceCell.Options.UseFont = true;
            this.GiaBan.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GiaBan.AppearanceHeader.Options.UseFont = true;
            this.GiaBan.Caption = "GiaBan";
            this.GiaBan.DisplayFormat.FormatString = "N0";
            this.GiaBan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaBan.FieldName = "GiaBan";
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.Visible = true;
            this.GiaBan.VisibleIndex = 4;
            // 
            // Import
            // 
            this.Import.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Import.Appearance.Options.UseFont = true;
            this.Import.Location = new System.Drawing.Point(330, 519);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(105, 36);
            this.Import.TabIndex = 1;
            this.Import.Text = "Import";
            this.Import.Click += new System.EventHandler(this.Import_Click);
            // 
            // exit
            // 
            this.exit.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Appearance.Options.UseFont = true;
            this.exit.Location = new System.Drawing.Point(485, 519);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(105, 36);
            this.exit.TabIndex = 2;
            this.exit.Text = "Exit";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // cbb_id
            // 
            this.cbb_id.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_id.FormattingEnabled = true;
            this.cbb_id.Location = new System.Drawing.Point(177, 12);
            this.cbb_id.Name = "cbb_id";
            this.cbb_id.Size = new System.Drawing.Size(635, 27);
            this.cbb_id.TabIndex = 17;
           
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label8.Location = new System.Drawing.Point(43, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "Nhóm hàng ";
            // 
            // FrmDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 589);
            this.Controls.Add(this.cbb_id);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.Import);
            this.Controls.Add(this.gcdanhsach);
            this.Name = "FrmDanhMuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmDanhMuc";
            this.Load += new System.EventHandler(this.FrmDanhMuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcdanhsach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvdanhsach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcdanhsach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvdanhsach;
        private DevExpress.XtraGrid.Columns.GridColumn BarCode;
        private DevExpress.XtraGrid.Columns.GridColumn TenHH;
        private DevExpress.XtraGrid.Columns.GridColumn DVT;
        private DevExpress.XtraGrid.Columns.GridColumn DonGia;
        private DevExpress.XtraEditors.SimpleButton Import;
        private DevExpress.XtraEditors.SimpleButton exit;
        private DevExpress.XtraGrid.Columns.GridColumn GiaBan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.ComboBox cbb_id;
        private System.Windows.Forms.Label label8;
    }
}