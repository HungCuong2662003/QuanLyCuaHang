using BusinessLayer;
using DataLayer;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Quan_Ban_Hang
{
    public partial class FrmTraHang : DevExpress.XtraEditors.XtraForm
    {
        public FrmTraHang()
        {
            InitializeComponent();
        }
  
        public FrmTraHang(List<obj_CHUNGTU_CT> lst , GridControl gcchitiet, GridView gvchitiet)
        {
            InitializeComponent();
            this._lsCT = lst;
            this._gcchitiet = gcchitiet;
            this._gvchitiet = gvchitiet;

        }
        List<obj_CHUNGTU_CT> _lsCT;
        GridControl _gcchitiet;
        GridView _gvchitiet;
       private void FrmTraHang_Load(object sender, EventArgs e)
        {
            
        }
        double soluong =1;
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            soluong++;
            txt_soluong.Text = soluong.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (soluong >= 1)
            {
                soluong--;
                txt_soluong.Text = soluong.ToString();
            }
        }


        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            obj_CHUNGTU_CT obj;
            var item = _lsCT.FirstOrDefault(x => x.Barcode == txt_barcode.Text);
            var item1 = _lsCT.FirstOrDefault(x => x.Barcode == txt_barcode.Text && x.SoluongCT==-1);
          
          
            if (item != null )
            {
                double SoLuong = 0;

                // Duyệt qua tất cả các dòng trong GridView
                for (int i = 0; i < _gvchitiet.RowCount; i++)
                {
                    // Lấy giá trị của cột Barcode và SoluongCT
                    string barcode = _gvchitiet.GetRowCellValue(i, "Barcode")?.ToString();
                    double soluongCT = 0;
                    double.TryParse(_gvchitiet.GetRowCellValue(i, "SoluongCT")?.ToString(), out soluongCT);

                    // Kiểm tra điều kiện Barcode
                    if (barcode == txt_barcode.Text)
                    {
                        SoLuong += soluongCT;
                    }
                   
                }
                if (soluong <= SoLuong && soluong>0)
                {
                    obj = new obj_CHUNGTU_CT();

                    obj.Barcode = item.Barcode;
                    obj.TenHH = item.TenHH;
                    obj.DVT = item.DVT;
                    obj.SoluongCT = double.Parse("-" + txt_soluong.Text);
                    obj.Dongia = item.Dongia;
                    obj.Chietkhau = double.Parse(_gvchitiet.GetRowCellValue(0, "Chietkhau").ToString());
                    if (double.Parse(_gvchitiet.GetRowCellValue(0, "Chietkhau").ToString()) == 0)
                    {
                        obj.Thanhtien = obj.Dongia * obj.SoluongCT;
                    }
                    else
                    {
                        obj.Thanhtien = (1 - double.Parse(_gvchitiet.GetRowCellValue(0, "Chietkhau").ToString()) /100 ) * obj.Dongia * obj.SoluongCT;
                    }
                   


                    _lsCT.Add(obj);
                    _gcchitiet.DataSource = _lsCT.ToList();
                }
                else
                {
                    MessageBox.Show("số lượng trả lớn hơn số lượng mua ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            else
            {
                MessageBox.Show("Mã hàng chưa có trong đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
        }

  
    }
}