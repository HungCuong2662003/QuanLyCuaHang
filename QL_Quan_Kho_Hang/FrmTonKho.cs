using BusinessLayer;
using DataLayer;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.XtraEditors.Mask.MaskSettings;
using excel = Microsoft.Office.Interop.Excel;

namespace QL_Quan_Kho_Hang
{
    public partial class FrmTonKho : DevExpress.XtraEditors.XtraForm
    {
        public FrmTonKho()
        {
            InitializeComponent();
        }
        public FrmTonKho(tb_SYS_User user, int right)
        {
            InitializeComponent();
            this._user = user;
            this._right = right;
        }
        tb_SYS_User _user;
        int _right;
        CONGTY _congty;
        TONKHO _tonkho;
        DONVI _donvi;
        List<Obj_TonKho> _lstTK;
        private void FrmTonKho_Load(object sender, EventArgs e)
        {
            _congty = new CONGTY();
            _tonkho = new TONKHO();
            _donvi = new DONVI();
            _lstTK=new List<Obj_TonKho>();
            loadCty();
            loadDvi();
            cbb_congty_chinhanh.SelectedIndexChanged += Cbb_congty_chinhanh_SelectedIndexChanged;
            cbo_dvi.SelectedIndexChanged += Cbo_dvi_SelectedIndexChanged;
            date_ky.Value=DateTime.Now;
            if (myFunctions._madvi == "~")
            {
                LoadTonKhoCTy(myFunctions._macty, DateTime.Now.Year, DateTime.Now.Month);
            }
            else
            {
                cbo_dvi.Enabled = true;
                LoadTonKho(myFunctions._macty, myFunctions._madvi, DateTime.Now.Year, DateTime.Now.Month);
            }
           
            //LoadTonKho(cbb_congty_chinhanh.ToString(),date_ky.Value.Year,date_ky.Value.Month);  
            date_ky.ValueChanged += Date_ky_ValueChanged;
        }

        private void Cbo_dvi_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTonKho(cbb_congty_chinhanh.SelectedValue.ToString(), cbo_dvi.SelectedValue.ToString(), date_ky.Value.Year, date_ky.Value.Month);
        }

        private void Date_ky_ValueChanged(object sender, EventArgs e)
        {
            LoadTonKho(cbb_congty_chinhanh.SelectedValue.ToString(), cbo_dvi.SelectedValue.ToString(), date_ky.Value.Year, date_ky.Value.Month);
        }

        private void Cbb_congty_chinhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_congty_chinhanh.SelectedValue != null)
            {
                LoadTonKho(cbb_congty_chinhanh.SelectedValue.ToString(), cbo_dvi.SelectedValue.ToString(), date_ky.Value.Year, date_ky.Value.Month);

            }
            else
            {
                MessageBox.Show("Chưa chọn công ty/chi nhánh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            loadDvi();
        }
        void loadDvi()
        {
            cbo_dvi.DataSource = _donvi.getItemListKho(cbb_congty_chinhanh.SelectedValue.ToString(), true);
            cbo_dvi.DisplayMember = "TenDvi";
            cbo_dvi.ValueMember = "MaDvi";
        }

        private void btn_tinhton_Click(object sender, EventArgs e)
        {
            TONKHO _tonkho = new TONKHO();

            try
            {
                string madvi;
                if (myFunctions._madvi == "~")
                {
                    madvi=cbo_dvi.SelectedValue.ToString();
                }
                else
                {
                    madvi = myFunctions._madvi;
                }
      
                if (_tonkho.TinhTon(madvi, date_ky.Value))
                {
                    // Hiển thị thông báo khi thành công
                    MessageBox.Show("Cập nhật tồn kho thành công.", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadTonKho(cbb_congty_chinhanh.SelectedValue.ToString(), cbo_dvi.SelectedValue.ToString(), date_ky.Value.Year, date_ky.Value.Month);
                }
                else
                {
                    // Hiển thị thông báo khi thất bại
                    MessageBox.Show("Cập nhật tồn kho không thành công.", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi và hiển thị thông báo lỗi
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ex_Click(object sender, EventArgs e)
        {
            _export();
        }
        void loadCty()
        {
            cbb_congty_chinhanh.DataSource = _congty.getALL();
            cbb_congty_chinhanh.DisplayMember = "TenCty";
            cbb_congty_chinhanh.ValueMember = "MaCty";
        }
        void LoadTonKho(string maCty ,string madvi, int nam, int ky)
        {
            // Gán dữ liệu từ phương thức getTonKhoCty vào DataSource của GridControl
            gctk.DataSource = _tonkho.GetTonKhoCtyDVI(maCty,madvi , nam, ky);

            // Đặt thuộc tính Editable của GridView thành false để không cho phép chỉnh sửa dữ liệu
            gvtk.OptionsBehavior.Editable = false;
       
            
        } void LoadTonKhoCTy(string maCty , int nam, int ky)
        {
            // Gán dữ liệu từ phương thức getTonKhoCty vào DataSource của GridControl
            gctk.DataSource = _tonkho.GetTonKhoCty(maCty, nam, ky);

            // Đặt thuộc tính Editable của GridView thành false để không cho phép chỉnh sửa dữ liệu
            gvtk.OptionsBehavior.Editable = false;
       
            
        }
        void _export()
        {
            string tenFile = "";
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Excel 2000-2003(.xls)|*.xls|Excel 2007 or higher (.xlsx)|*.xlsx";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                SplashScreenManager.ShowForm(this, typeof(FrmWaitForm), true, true, false);
                tenFile = saveFile.FileName;
            }
            excel.Application app = new excel.Application();
            excel.Workbook wb = app.Workbooks.Add(Type.Missing);
            excel.Worksheet sheet = null;
            try
            {
                sheet = wb.ActiveSheet;
                // Đặt tên sheet
                sheet.Name = "Danh mục tồn kho " + cbb_congty_chinhanh.Text;

                // Merge các ô từ A1 đến L1
                sheet.Range[sheet.Cells[1, 1], sheet.Cells[1, 12]].Merge();

                // Căn lề giữa cho tiêu đề
                sheet.Cells[1, 1].HorizontalAlignment = excel.XlHAlign.xlHAlignCenter;

                // Viền xung quanh tiêu đề
                sheet.Range[sheet.Cells[1, 1], sheet.Cells[1, 12]].BorderAround(Type.Missing, excel.XlBorderWeight.xlThick, excel.XlColorIndex.xlColorIndexAutomatic);

                // Thiết lập tiêu đề cho bảng
                sheet.Cells[1, 1].Value = "Danh mục tồn kho  " + cbb_congty_chinhanh.Text.ToUpper();
                sheet.Cells[1, 1].Font.Size = 20;

                sheet.Cells[2, 1].value = "BARCODE";
                sheet.Cells[2, 2].value = "Tên hàng";
                sheet.Cells[2, 3].value = "Đơn vị tính";
                sheet.Cells[2, 4].value = "Lượng tồn đầu";
                sheet.Cells[2, 5].value = "Lượng nhập";
                sheet.Cells[2, 6].value = "Lượng xuất nội bộ ";
                sheet.Cells[2, 7].value = "Lượng xuất sỉ";
                sheet.Cells[2, 8].value = "Lượng bán lẻ";
                sheet.Cells[2, 9].value = "Lượng tồn cuối";
                sheet.Cells[2, 10].value = "Đơn giá";
                sheet.Cells[2, 11].value = "Thành tiền";
                //xuat data
                _lstTK = _tonkho.GetTonKhoCty(cbb_congty_chinhanh.SelectedValue.ToString(), date_ky.Value.Year, date_ky.Value.Month);
                for (int i = 1; i <= _lstTK.Count; i++)
                {
                    sheet.Cells[i + 2, 1].value = _lstTK.ElementAt(i - 1).BARCODE;
                    sheet.Cells[i + 2, 2].value = _lstTK.ElementAt(i - 1).TenHH;
                    sheet.Cells[i + 2, 3].value = _lstTK.ElementAt(i - 1).DVT;
                    sheet.Cells[i + 2, 4].value = _lstTK.ElementAt(i - 1).LG_DAU;
                    sheet.Cells[i + 2, 5].value = _lstTK.ElementAt(i - 1).LG_NHAPMUA;
                    sheet.Cells[i + 2, 6].value = _lstTK.ElementAt(i - 1).LG_XUATNB;
                    sheet.Cells[i + 2, 7].value = _lstTK.ElementAt(i - 1).LG_XUATSI;
                    sheet.Cells[i + 2, 8].value = _lstTK.ElementAt(i - 1).LG_BANLE;
                    sheet.Cells[i + 2, 9].value = _lstTK.ElementAt(i - 1).LG_CUOI;
                    sheet.Cells[i + 2, 10].value = _lstTK.ElementAt(i - 1).TRIGIA;
                    sheet.Cells[i + 2, 11].value = _lstTK.ElementAt(i - 1).TIEN_CUOI;
             


                }
  
                wb.SaveAs(tenFile);


            }
            catch (Exception ex)
            {
                SplashScreenManager.CloseForm(true);
                MessageBox.Show(ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                wb.Close(true);
                app.Quit();
                releaseObject(wb);
                releaseObject(app);
                SplashScreenManager.CloseForm(true);
                MessageBox.Show("Xuất file thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
        void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.FinalReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show(" lỗi releaseObject" + ex.ToString());
            }
            finally
            {
                //Phát hiện và giải phóng bộ nhớ không còn được sử dụng
                GC.Collect();
            }
        }

    }
}