namespace QL_Quan_Kho_Hang.Report
{
    partial class RptBarcode
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraPrinting.BarCode.Code128Generator code128Generator1 = new DevExpress.XtraPrinting.BarCode.Code128Generator();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xr_gia = new DevExpress.XtraReports.UI.XRLabel();
            this.xr_name = new DevExpress.XtraReports.UI.XRLabel();
            this.xrBarcode = new DevExpress.XtraReports.UI.XRBarCode();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xr_gia,
            this.xr_name,
            this.xrBarcode});
            this.Detail.HeightF = 129.0834F;
            this.Detail.MultiColumn.ColumnCount = 4;
            this.Detail.MultiColumn.ColumnWidth = 320F;
            this.Detail.MultiColumn.Layout = DevExpress.XtraPrinting.ColumnLayout.AcrossThenDown;
            this.Detail.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnCount;
            this.Detail.Name = "Detail";
            // 
            // xr_gia
            // 
            this.xr_gia.Font = new DevExpress.Drawing.DXFont("Arial", 12F);
            this.xr_gia.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 102.3334F);
            this.xr_gia.Multiline = true;
            this.xr_gia.Name = "xr_gia";
            this.xr_gia.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xr_gia.SizeF = new System.Drawing.SizeF(144.5834F, 22.99999F);
            this.xr_gia.StylePriority.UseFont = false;
            this.xr_gia.StylePriority.UseTextAlignment = false;
            this.xr_gia.Text = "xr_gia";
            this.xr_gia.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xr_name
            // 
            this.xr_name.Font = new DevExpress.Drawing.DXFont("Arial", 12F);
            this.xr_name.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 0F);
            this.xr_name.Multiline = true;
            this.xr_name.Name = "xr_name";
            this.xr_name.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xr_name.SizeF = new System.Drawing.SizeF(144.5834F, 23F);
            this.xr_name.StylePriority.UseFont = false;
            this.xr_name.StylePriority.UseTextAlignment = false;
            this.xr_name.Text = "xr_name";
            this.xr_name.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrBarcode
            // 
            this.xrBarcode.AutoModule = true;
            this.xrBarcode.LocationFloat = new DevExpress.Utils.PointFloat(12.5833F, 22.99999F);
            this.xrBarcode.Name = "xrBarcode";
            this.xrBarcode.Padding = new DevExpress.XtraPrinting.PaddingInfo(9, 9, 0, 0, 100F);
            this.xrBarcode.SizeF = new System.Drawing.SizeF(139.9167F, 69.70833F);
            this.xrBarcode.StylePriority.UseTextAlignment = false;
            this.xrBarcode.Symbology = code128Generator1;
            this.xrBarcode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // RptBarcode
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail});
            this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.Version = "22.2";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRBarCode xrBarcode;
        private DevExpress.XtraReports.UI.XRLabel xr_gia;
        private DevExpress.XtraReports.UI.XRLabel xr_name;
    }
}
