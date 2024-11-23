using BusinessLayer;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using QL_Quan_Kho_Hang.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QL_Quan_Kho_Hang
{
    public partial class FrmBarcode : DevExpress.XtraEditors.XtraForm
    {
        public FrmBarcode()
        {
            InitializeComponent();
        }

        private NHOMHH _NHOMHH;
        private HANGHOA _hanghoa;

        private void FrmBarcode_Load(object sender, EventArgs e)
        {
            _NHOMHH = new NHOMHH();
            _hanghoa = new HANGHOA();
            loadnhom();
            cbo_nhom.SelectedIndexChanged += cbo_nhom_SelectedIndexChanged;
            loaddanhmuc();
        }

        private void loadnhom()
        {
            cbo_nhom.DataSource = _NHOMHH.getALL();
            cbo_nhom.DisplayMember = "TenNhom";
            cbo_nhom.ValueMember = "IdNhom";
        }

        private void cbo_nhom_SelectedIndexChanged(object sender, EventArgs e)
        {
            loaddanhmuc();
        }

        private void loaddanhmuc()
        {
            if (cbo_nhom.SelectedValue != null )
            {
                // Cập nhật danh sách barcode khi thay đổi nhóm hàng hóa
                var barcodeList = _hanghoa.getdanhmucinbarcode(cbo_nhom.SelectedValue.ToString());
                gc_danhmuc.DataSource = barcodeList;
            }
            else
            {
                gc_danhmuc.DataSource = null; // Xử lý khi không có nhóm nào được chọn
            }
        }

        private void btn_print_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            List<obj_barcode> lst = new List<obj_barcode>();

            for (int i = 0; i < gv_danhmuc.RowCount; i++)
            {
                if (gv_danhmuc.GetRowCellValue(i, "SOTEM") != null)
                {
                    int quantity = int.Parse(gv_danhmuc.GetRowCellValue(i, "SOTEM").ToString());
                    for (int j = 0; j < quantity; j++)
                    {
                        var obj = new obj_barcode
                        {
                            BarCode = gv_danhmuc.GetRowCellValue(i, "BarCode").ToString(),
                            TenHH = gv_danhmuc.GetRowCellValue(i, "TenHH").ToString(),
                            TenTat = gv_danhmuc.GetRowCellValue(i, "TenTat").ToString(),
                            DVT = gv_danhmuc.GetRowCellValue(i, "DVT").ToString(),
                            DonGia = double.Parse(gv_danhmuc.GetRowCellValue(i, "DonGia").ToString()),
                            GiaBan = double.Parse(gv_danhmuc.GetRowCellValue(i, "GiaBan").ToString())
                        };
                        lst.Add(obj);
                    }
                }
            }

            RptBarcode rptBarcode = new RptBarcode
            {
                DataSource = lst // Sử dụng danh sách lst để in
            };
            rptBarcode.ShowPreviewDialog();
        }

        private void btn_exit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
