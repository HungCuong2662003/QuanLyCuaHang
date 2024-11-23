using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QL_Quan_Kho_Hang.Report
{
    public partial class RptBarcode : DevExpress.XtraReports.UI.XtraReport
    {
        public RptBarcode()
        {
            InitializeComponent();
            // Thiết lập nguồn dữ liệu của báo cáo
         

            // Thực hiện ràng buộc dữ liệu cho các điều khiển
            xr_name.DataBindings.Add("Text", this.DataSource, "TenHH");
            xrBarcode.DataBindings.Add("Text", this.DataSource, "BarCode");
            xr_gia.DataBindings.Add("Text", this.DataSource, "GiaBan", "Giá: {0:0,0} ₫");


        }

    }
}
