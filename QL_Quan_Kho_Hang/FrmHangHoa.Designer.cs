namespace QL_Quan_Kho_Hang
{
    partial class FrmHangHoa
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
            this.btn_them = new System.Windows.Forms.ToolStripButton();
            this.btn_sua = new System.Windows.Forms.ToolStripButton();
            this.btn_xoa = new System.Windows.Forms.ToolStripButton();
            this.btn_luu = new System.Windows.Forms.ToolStripButton();
            this.btn_boqua = new System.Windows.Forms.ToolStripButton();
            this.btn_in = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btn_thoat = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbb_id = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.GC_Ds = new DevExpress.XtraGrid.GridControl();
            this.GV_Ds = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BarCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenTat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaNCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Maxuatxu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Create_Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdNhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Create_By_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Mota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Disable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txt_tentat = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cb_dis = new System.Windows.Forms.CheckBox();
            this.cbb_nhacc = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbb_xuatxu = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_mota = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbb_dvt = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tenhang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_giaban = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_Ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_them,
            this.btn_sua,
            this.btn_xoa,
            this.btn_luu,
            this.btn_boqua,
            this.btn_in,
            this.toolStripButton1,
            this.btn_thoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1289, 44);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Image = global::QL_Quan_Kho_Hang.Properties.Resources.them;
            this.btn_them.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(53, 41);
            this.btn_them.Text = "Thêm";
            this.btn_them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Image = global::QL_Quan_Kho_Hang.Properties.Resources.sua;
            this.btn_sua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(40, 41);
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Image = global::QL_Quan_Kho_Hang.Properties.Resources.xoa;
            this.btn_xoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(40, 41);
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.Image = global::QL_Quan_Kho_Hang.Properties.Resources.luu;
            this.btn_luu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(40, 41);
            this.btn_luu.Text = "Lưu";
            this.btn_luu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_boqua
            // 
            this.btn_boqua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_boqua.Image = global::QL_Quan_Kho_Hang.Properties.Resources.boqua;
            this.btn_boqua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_boqua.Name = "btn_boqua";
            this.btn_boqua.Size = new System.Drawing.Size(62, 41);
            this.btn_boqua.Text = "Bỏ qua";
            this.btn_boqua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_boqua.Click += new System.EventHandler(this.btn_boqua_Click);
            // 
            // btn_in
            // 
            this.btn_in.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_in.Image = global::QL_Quan_Kho_Hang.Properties.Resources.print;
            this.btn_in.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(58, 41);
            this.btn_in.Text = "Export";
            this.btn_in.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_in.Click += new System.EventHandler(this.btn_in_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.Image = global::QL_Quan_Kho_Hang.Properties.Resources.barcode;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(70, 41);
            this.toolStripButton1.Text = "Barcode";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Image = global::QL_Quan_Kho_Hang.Properties.Resources.thoat;
            this.btn_thoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(53, 41);
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 44);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.GC_Ds);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1289, 590);
            this.splitContainer1.SplitterDistance = 916;
            this.splitContainer1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbb_id);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(916, 58);
            this.panel1.TabIndex = 1;
            // 
            // cbb_id
            // 
            this.cbb_id.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_id.FormattingEnabled = true;
            this.cbb_id.Location = new System.Drawing.Point(175, 17);
            this.cbb_id.Name = "cbb_id";
            this.cbb_id.Size = new System.Drawing.Size(635, 27);
            this.cbb_id.TabIndex = 0;
            this.cbb_id.SelectedIndexChanged += new System.EventHandler(this.Cbb_id_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label8.Location = new System.Drawing.Point(37, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Nhóm hàng ";
            // 
            // GC_Ds
            // 
            this.GC_Ds.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GC_Ds.Location = new System.Drawing.Point(0, 58);
            this.GC_Ds.MainView = this.GV_Ds;
            this.GC_Ds.Name = "GC_Ds";
            this.GC_Ds.Size = new System.Drawing.Size(916, 532);
            this.GC_Ds.TabIndex = 2;
            this.GC_Ds.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GV_Ds});
            // 
            // GV_Ds
            // 
            this.GV_Ds.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GV_Ds.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.GV_Ds.ColumnPanelRowHeight = 40;
            this.GV_Ds.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.BarCode,
            this.TenHH,
            this.TenTat,
            this.DVT,
            this.MaNCC,
            this.Maxuatxu,
            this.Create_Date,
            this.IdNhom,
            this.Create_By_name,
            this.Mota,
            this.Disable});
            this.GV_Ds.GridControl = this.GC_Ds;
            this.GV_Ds.Name = "GV_Ds";
            this.GV_Ds.OptionsFind.AlwaysVisible = true;
            this.GV_Ds.RowHeight = 30;
            this.GV_Ds.Click += new System.EventHandler(this.GV_Ds_Click);
            // 
            // BarCode
            // 
            this.BarCode.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarCode.AppearanceCell.Options.UseFont = true;
            this.BarCode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarCode.AppearanceHeader.Options.UseFont = true;
            this.BarCode.Caption = "BarCode";
            this.BarCode.FieldName = "BarCode";
            this.BarCode.MaxWidth = 200;
            this.BarCode.MinWidth = 100;
            this.BarCode.Name = "BarCode";
            this.BarCode.Visible = true;
            this.BarCode.VisibleIndex = 0;
            this.BarCode.Width = 106;
            // 
            // TenHH
            // 
            this.TenHH.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenHH.AppearanceCell.Options.UseFont = true;
            this.TenHH.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenHH.AppearanceHeader.Options.UseFont = true;
            this.TenHH.Caption = "Tên hàng hóa";
            this.TenHH.FieldName = "TenHH";
            this.TenHH.MaxWidth = 200;
            this.TenHH.MinWidth = 150;
            this.TenHH.Name = "TenHH";
            this.TenHH.Visible = true;
            this.TenHH.VisibleIndex = 1;
            this.TenHH.Width = 159;
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
            this.DVT.Visible = true;
            this.DVT.VisibleIndex = 2;
            this.DVT.Width = 79;
            // 
            // MaNCC
            // 
            this.MaNCC.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaNCC.AppearanceCell.Options.UseFont = true;
            this.MaNCC.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaNCC.AppearanceHeader.Options.UseFont = true;
            this.MaNCC.Caption = "Mã nhà cung cấp";
            this.MaNCC.FieldName = "MaNCC";
            this.MaNCC.Name = "MaNCC";
            // 
            // Maxuatxu
            // 
            this.Maxuatxu.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Maxuatxu.AppearanceCell.Options.UseFont = true;
            this.Maxuatxu.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Maxuatxu.AppearanceHeader.Options.UseFont = true;
            this.Maxuatxu.Caption = "Xuẩt xứ";
            this.Maxuatxu.FieldName = "Maxuatxu";
            this.Maxuatxu.Name = "Maxuatxu";
            // 
            // Create_Date
            // 
            this.Create_Date.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_Date.AppearanceCell.Options.UseFont = true;
            this.Create_Date.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_Date.AppearanceHeader.Options.UseFont = true;
            this.Create_Date.Caption = "Ngày nhập";
            this.Create_Date.FieldName = "Create_Date";
            this.Create_Date.MaxWidth = 200;
            this.Create_Date.MinWidth = 100;
            this.Create_Date.Name = "Create_Date";
            this.Create_Date.Visible = true;
            this.Create_Date.VisibleIndex = 3;
            this.Create_Date.Width = 100;
            // 
            // IdNhom
            // 
            this.IdNhom.Caption = "Nhóm";
            this.IdNhom.FieldName = "IdNhom";
            this.IdNhom.Name = "IdNhom";
            // 
            // Create_By_name
            // 
            this.Create_By_name.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_By_name.AppearanceCell.Options.UseFont = true;
            this.Create_By_name.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_By_name.AppearanceHeader.Options.UseFont = true;
            this.Create_By_name.Caption = "Người nhập";
            this.Create_By_name.FieldName = "Create_By_name";
            this.Create_By_name.MaxWidth = 200;
            this.Create_By_name.MinWidth = 100;
            this.Create_By_name.Name = "Create_By_name";
            this.Create_By_name.Visible = true;
            this.Create_By_name.VisibleIndex = 4;
            this.Create_By_name.Width = 100;
            // 
            // Mota
            // 
            this.Mota.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mota.AppearanceCell.Options.UseFont = true;
            this.Mota.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mota.AppearanceHeader.Options.UseFont = true;
            this.Mota.Caption = "Mô tả";
            this.Mota.FieldName = "Mota";
            this.Mota.MaxWidth = 300;
            this.Mota.MinWidth = 100;
            this.Mota.Name = "Mota";
            this.Mota.Visible = true;
            this.Mota.VisibleIndex = 5;
            this.Mota.Width = 150;
            // 
            // Disable
            // 
            this.Disable.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Disable.AppearanceCell.Options.UseFont = true;
            this.Disable.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Disable.AppearanceHeader.Options.UseFont = true;
            this.Disable.Caption = "Disable";
            this.Disable.FieldName = "Disable";
            this.Disable.Name = "Disable";
            this.Disable.Visible = true;
            this.Disable.VisibleIndex = 6;
            this.Disable.Width = 121;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.txt_giaban);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.txt_tentat);
            this.groupControl1.Controls.Add(this.label11);
            this.groupControl1.Controls.Add(this.label9);
            this.groupControl1.Controls.Add(this.dateTimePicker1);
            this.groupControl1.Controls.Add(this.cb_dis);
            this.groupControl1.Controls.Add(this.cbb_nhacc);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.cbb_xuatxu);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.txt_mota);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.cbb_dvt);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.txt_tenhang);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(369, 590);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin hàng hóa";
            // 
            // txt_tentat
            // 
            this.txt_tentat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tentat.Location = new System.Drawing.Point(144, 124);
            this.txt_tentat.Name = "txt_tentat";
            this.txt_tentat.Size = new System.Drawing.Size(158, 26);
            this.txt_tentat.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label11.Location = new System.Drawing.Point(39, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 19);
            this.label11.TabIndex = 20;
            this.label11.Text = "Tên tắt";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label9.Location = new System.Drawing.Point(34, 271);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "Ngày nhập";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(144, 266);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // cb_dis
            // 
            this.cb_dis.AutoSize = true;
            this.cb_dis.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_dis.Location = new System.Drawing.Point(144, 534);
            this.cb_dis.Name = "cb_dis";
            this.cb_dis.Size = new System.Drawing.Size(72, 22);
            this.cb_dis.TabIndex = 12;
            this.cb_dis.Text = "Disable";
            this.cb_dis.UseVisualStyleBackColor = true;
            // 
            // cbb_nhacc
            // 
            this.cbb_nhacc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_nhacc.FormattingEnabled = true;
            this.cbb_nhacc.Location = new System.Drawing.Point(144, 421);
            this.cbb_nhacc.Name = "cbb_nhacc";
            this.cbb_nhacc.Size = new System.Drawing.Size(121, 28);
            this.cbb_nhacc.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label7.Location = new System.Drawing.Point(33, 423);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Nhà cung cấp";
            // 
            // cbb_xuatxu
            // 
            this.cbb_xuatxu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_xuatxu.FormattingEnabled = true;
            this.cbb_xuatxu.Location = new System.Drawing.Point(144, 468);
            this.cbb_xuatxu.Name = "cbb_xuatxu";
            this.cbb_xuatxu.Size = new System.Drawing.Size(121, 28);
            this.cbb_xuatxu.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label6.Location = new System.Drawing.Point(35, 470);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Xuất xứ";
            // 
            // txt_mota
            // 
            this.txt_mota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mota.Location = new System.Drawing.Point(144, 322);
            this.txt_mota.Multiline = true;
            this.txt_mota.Name = "txt_mota";
            this.txt_mota.Size = new System.Drawing.Size(208, 80);
            this.txt_mota.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label5.Location = new System.Drawing.Point(39, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mô tả";
            // 
            // cbb_dvt
            // 
            this.cbb_dvt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_dvt.FormattingEnabled = true;
            this.cbb_dvt.Location = new System.Drawing.Point(144, 167);
            this.cbb_dvt.Name = "cbb_dvt";
            this.cbb_dvt.Size = new System.Drawing.Size(158, 28);
            this.cbb_dvt.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.Location = new System.Drawing.Point(39, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Đơn vị tính";
            // 
            // txt_tenhang
            // 
            this.txt_tenhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenhang.Location = new System.Drawing.Point(144, 81);
            this.txt_tenhang.Name = "txt_tenhang";
            this.txt_tenhang.Size = new System.Drawing.Size(158, 26);
            this.txt_tenhang.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(39, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên hàng";
            // 
            // txt_giaban
            // 
            this.txt_giaban.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_giaban.Location = new System.Drawing.Point(144, 217);
            this.txt_giaban.Name = "txt_giaban";
            this.txt_giaban.Size = new System.Drawing.Size(158, 26);
            this.txt_giaban.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(39, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "Giá bán";
            // 
            // FrmHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 634);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmHangHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHangHoa";
            this.Load += new System.EventHandler(this.FrmHangHoa_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl GC_Ds;
        private DevExpress.XtraGrid.Views.Grid.GridView GV_Ds;
        private DevExpress.XtraGrid.Columns.GridColumn BarCode;
        private DevExpress.XtraGrid.Columns.GridColumn TenHH;
        private DevExpress.XtraGrid.Columns.GridColumn TenTat;
        private DevExpress.XtraGrid.Columns.GridColumn DVT;
        private DevExpress.XtraGrid.Columns.GridColumn MaNCC;
        private DevExpress.XtraGrid.Columns.GridColumn Maxuatxu;
        private DevExpress.XtraGrid.Columns.GridColumn IdNhom;
        private System.Windows.Forms.TextBox txt_mota;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbb_dvt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tenhang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbb_nhacc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbb_xuatxu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbb_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cb_dis;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraGrid.Columns.GridColumn Create_Date;
        private DevExpress.XtraGrid.Columns.GridColumn Create_By_name;
        private DevExpress.XtraGrid.Columns.GridColumn Mota;
        private DevExpress.XtraGrid.Columns.GridColumn Disable;
        private System.Windows.Forms.TextBox txt_tentat;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStripButton btn_in;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TextBox txt_giaban;
        private System.Windows.Forms.Label label1;
    }
}