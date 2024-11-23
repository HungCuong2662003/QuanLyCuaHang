using BusinessLayer;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using QL_Quan_Ban_Hang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Quan_Kho_Hang
{
    public partial class FrmChietKhau : DevExpress.XtraEditors.XtraForm
    {
        public FrmChietKhau()
        {
            InitializeComponent();
        }
        public FrmChietKhau(GridView grid)
        {
            InitializeComponent();
            this._gvchitiet=grid;
        }
        GridView _gvchitiet;
        

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_nhap_Click(object sender, EventArgs e)
        {
            if (MyFunctions.IsNumberUsingRegex(txt_ck.Text))
            {
                for (int i = 0; i < _gvchitiet.RowCount-1; i++)
                {
                    // Kiểm tra null trước khi sử dụng SetRowCellValue
                    var giaBanValue = _gvchitiet.GetRowCellValue(i, "GiaBan");
                    var soLuongValue = _gvchitiet.GetRowCellValue(i, "SoluongCT");

                    if (giaBanValue != null && soLuongValue != null)
                    {
                        double giaBan = double.Parse(giaBanValue.ToString());
                        double soLuong = double.Parse(soLuongValue.ToString());
                        double chietKhau = double.Parse(txt_ck.Text);

                        // Set giá trị chiết khấu
                        _gvchitiet.SetRowCellValue(i, "Chietkhau", txt_ck.Text);

                        // Tính thành tiền với chiết khấu
                        double thanhTien = giaBan * soLuong * (1 - chietKhau / 100);
                        _gvchitiet.SetRowCellValue(i, "Thanhtien", thanhTien.ToString());
                    }
                    else
                    {
                        MessageBox.Show($"Dòng {i + 1} có giá trị trống cho cột 'GiaBan' hoặc 'SoluongCT'", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                _gvchitiet.RefreshData();
                this.Close();
            }
            else
            {
                MessageBox.Show("Chiết khấu phải là số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmChietKhau_Load(object sender, EventArgs e)
        {

        }
    }
}