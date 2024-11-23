namespace QL_Quan_Kho_Hang
{
    partial class FrmBaoCaoDTNHH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBaoCaoDTNHH));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Export = new System.Windows.Forms.ToolStripButton();
            this.btn_thoat = new System.Windows.Forms.ToolStripButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.date_den = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.date_tu = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.chartdoanhthu = new DevExpress.XtraCharts.ChartControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chartdoanhthu1 = new DevExpress.XtraCharts.ChartControl();
            this.chartdoanhthu2 = new DevExpress.XtraCharts.ChartControl();
            this.chartdoanhthu3 = new DevExpress.XtraCharts.ChartControl();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartdoanhthu)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartdoanhthu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartdoanhthu2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartdoanhthu3)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Export,
            this.btn_thoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(828, 44);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_Export
            // 
            this.btn_Export.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Export.Image = ((System.Drawing.Image)(resources.GetObject("btn_Export.Image")));
            this.btn_Export.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(63, 41);
            this.btn_Export.Text = "Export";
            this.btn_Export.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Image = global::QL_Quan_Kho_Hang.Properties.Resources.thoat;
            this.btn_thoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(58, 41);
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 44);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.date_den);
            this.splitContainerControl1.Panel1.Controls.Add(this.label2);
            this.splitContainerControl1.Panel1.Controls.Add(this.date_tu);
            this.splitContainerControl1.Panel1.Controls.Add(this.label1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(828, 578);
            this.splitContainerControl1.SplitterPosition = 66;
            this.splitContainerControl1.TabIndex = 3;
            // 
            // date_den
            // 
            this.date_den.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.date_den.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_den.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_den.Location = new System.Drawing.Point(514, 20);
            this.date_den.Name = "date_den";
            this.date_den.Size = new System.Drawing.Size(150, 26);
            this.date_den.TabIndex = 7;
            this.date_den.ValueChanged += new System.EventHandler(this.date_den_ValueChanged);
            this.date_den.Leave += new System.EventHandler(this.date_den_Leave);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(453, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Đến";
            // 
            // date_tu
            // 
            this.date_tu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_tu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_tu.Location = new System.Drawing.Point(157, 22);
            this.date_tu.Name = "date_tu";
            this.date_tu.Size = new System.Drawing.Size(150, 26);
            this.date_tu.TabIndex = 5;
            this.date_tu.ValueChanged += new System.EventHandler(this.date_tu_ValueChanged);
            this.date_tu.Leave += new System.EventHandler(this.date_tu_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Từ";
            // 
            // chartdoanhthu
            // 
            this.chartdoanhthu.AccessibleName = "";
            this.chartdoanhthu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartdoanhthu.Location = new System.Drawing.Point(3, 3);
            this.chartdoanhthu.Name = "chartdoanhthu";
            this.chartdoanhthu.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartdoanhthu.Size = new System.Drawing.Size(408, 245);
            this.chartdoanhthu.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.chartdoanhthu3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.chartdoanhthu2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chartdoanhthu1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.chartdoanhthu, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(828, 502);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // chartdoanhthu1
            // 
            this.chartdoanhthu1.AccessibleName = "";
            this.chartdoanhthu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartdoanhthu1.Location = new System.Drawing.Point(417, 3);
            this.chartdoanhthu1.Name = "chartdoanhthu1";
            this.chartdoanhthu1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartdoanhthu1.Size = new System.Drawing.Size(408, 245);
            this.chartdoanhthu1.TabIndex = 1;
            // 
            // chartdoanhthu2
            // 
            this.chartdoanhthu2.AccessibleName = "";
            this.chartdoanhthu2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartdoanhthu2.Location = new System.Drawing.Point(3, 254);
            this.chartdoanhthu2.Name = "chartdoanhthu2";
            this.chartdoanhthu2.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartdoanhthu2.Size = new System.Drawing.Size(408, 245);
            this.chartdoanhthu2.TabIndex = 2;
            // 
            // chartdoanhthu3
            // 
            this.chartdoanhthu3.AccessibleName = "";
            this.chartdoanhthu3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartdoanhthu3.Location = new System.Drawing.Point(417, 254);
            this.chartdoanhthu3.Name = "chartdoanhthu3";
            this.chartdoanhthu3.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartdoanhthu3.Size = new System.Drawing.Size(408, 245);
            this.chartdoanhthu3.TabIndex = 3;
            // 
            // FrmBaoCaoDTNHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 622);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmBaoCaoDTNHH";
            this.Text = "FrmBaoCaoDTNHH";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmBaoCaoDTNHH_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            this.splitContainerControl1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartdoanhthu)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartdoanhthu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartdoanhthu2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartdoanhthu3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_Export;
        private System.Windows.Forms.ToolStripButton btn_thoat;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.DateTimePicker date_den;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date_tu;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraCharts.ChartControl chartdoanhthu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraCharts.ChartControl chartdoanhthu3;
        private DevExpress.XtraCharts.ChartControl chartdoanhthu2;
        private DevExpress.XtraCharts.ChartControl chartdoanhthu1;
    }
}