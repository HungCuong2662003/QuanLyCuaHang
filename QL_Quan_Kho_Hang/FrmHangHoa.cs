using BusinessLayer;
using DataLayer;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using excel = Microsoft.Office.Interop.Excel;
using DevExpress.XtraSplashScreen;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QL_Quan_Kho_Hang
{
    public partial class FrmHangHoa : DevExpress.XtraEditors.XtraForm
    {
        public FrmHangHoa()
        {
            InitializeComponent();
        }
        public FrmHangHoa(tb_SYS_User user, int right)
        {
            InitializeComponent();
            this._user = user;
            this._right = right;
        }
        
        tb_SYS_User _user;
        public int _right;
        bool _them;
        string _barcode;
        NHACC _nhacc;
        DONVITINH _donvitinh;
        NHOMHH _nhomhh;
        XUATXU _xuatxu;
        HANGHOA _hanghoa;
        SYS_SEQUENCE _SYS_SEQUENCE;
        List<Obj_HangHoa> _lsthh= new List<Obj_HangHoa>();

        private void FrmHangHoa_Load(object sender, EventArgs e)
        {
            _nhacc=new NHACC();
            _donvitinh=new DONVITINH();
            _nhomhh=new NHOMHH();
            _xuatxu=new XUATXU();
            _hanghoa=new HANGHOA();
            _SYS_SEQUENCE = new SYS_SEQUENCE();

           
            showHideControl(true);
            Enable(false);
            cbb_id.Enabled = true;
            loadnhom();
            loadxx();
            loaddvt();  
            loadncc();
    
            cbb_id.SelectedIndexChanged += Cbb_id_SelectedIndexChanged;
            cbb_id.DropDownStyle = ComboBoxStyle.DropDownList;



        }

        private void Cbb_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }

        void loadData()
        {

            try
            {
                GC_Ds.DataSource = _hanghoa.getlistbyNHOM_Full(cbb_id.SelectedValue.ToString());
               
            }
            catch (Exception ex)
            {
                // Bắt lỗi và hiển thị thông báo
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            _lsthh = _hanghoa.getlistbyNHOM_Full(cbb_id.SelectedValue.ToString());
        }

        void loadnhom()
        {
            cbb_id.DataSource = _nhomhh.getALL();
            cbb_id.DisplayMember = "TenNhom";
            cbb_id.ValueMember = "IdNhom";
            cbb_id.SelectedIndex = 0;

        }
        void loadncc()
        {
            cbb_nhacc.DataSource = _nhacc.getALL();
            cbb_nhacc.DisplayMember = "TenNCC";
            cbb_nhacc.ValueMember = "MaNCC";
        }
        void loaddvt()
        {
            cbb_dvt.DataSource = _donvitinh.getALL();
            cbb_dvt.DisplayMember = "Ten";
            cbb_dvt.ValueMember = "ID";
        }
        void loadxx()
        {
            cbb_xuatxu.DataSource = _xuatxu.getALL();
            cbb_xuatxu.DisplayMember = "Ten";
            cbb_xuatxu.ValueMember = "ID";
        }
        void Enable(bool t)
        {
            txt_tenhang.Enabled = t;
            txt_tentat.Enabled = t;
            cbb_dvt.Enabled = t;
            txt_giaban.Enabled = t;
            cbb_nhacc.Enabled = t;
            cbb_xuatxu.Enabled = t;
        
            txt_mota.Enabled = t;
            dateTimePicker1.Enabled = t;
          
            cb_dis.Enabled = t;
        }
        void _reset()
        {
            txt_tenhang.Text = "";
            txt_tentat.Text = "";
            cbb_dvt.Text = "";
            //spin_gianhap.Text = "";
            txt_giaban.Text = "";
            cbb_nhacc.Text = "";
            cbb_xuatxu.Text = "";
            
            txt_mota.Text = "";
            dateTimePicker1.Text = "";
         
            cb_dis.Checked = false;
        }
        void showHideControl(bool t)
        {
            btn_them.Visible = t;
            btn_sua.Visible = t;
            btn_xoa.Visible = t;
            btn_thoat.Visible = t;
            btn_luu.Visible = !t;
            btn_boqua.Visible = !t;
        }
      
        private void btn_them_Click(object sender, EventArgs e)
        {
            showHideControl(false);
            _them = true;
            Enable(true);
            _reset();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            showHideControl(false);
            _them = false;
            Enable(true);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _hanghoa.Falsehh(_barcode);
            }
            loadData();
        }

        tb_SYS_SEQUENCE _seq;
        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (_them)
            {
                tb_HangHoa hangHoa = new tb_HangHoa();
                _seq = _SYS_SEQUENCE.getitem("HH/"+DateTime.Now.Year.ToString()+"/"+cbb_id.SelectedValue.ToString());
                if (_seq == null)
                {
                    _seq = new tb_SYS_SEQUENCE();
                    _seq.Name = "HH/" + DateTime.Now.Year.ToString() + "/" + cbb_id.SelectedValue.ToString();
                    _seq.value = 1;
                    _SYS_SEQUENCE.add( _seq );
                }
             
                // Lấy các thành phần của mã vạch
                string idNhom = cbb_id.SelectedValue.ToString();    // Ví dụ: "NHHDC"
                string year = DateTime.Now.Year.ToString();         // Ví dụ: "2024"
                string serialNumber = _seq.value.Value.ToString("D3"); // Định dạng số thứ tự với 3 chữ số, ví dụ: "001"

                // Tạo chuỗi mã vạch theo định dạng mong muốn
                string barcodeText = $"{idNhom}{year}{serialNumber}";

                hangHoa.BarCode = barcodeText;

                //hangHoa.BarCode = BARCODE.buildEan13(DateTime.Now.Year.ToString() + cbb_id.SelectedValue.ToString() + _seq.value.Value.ToString("0000000"));
         
                hangHoa.TenHH=txt_tenhang.Text;
                hangHoa.TenTat=txt_tentat.Text;
                hangHoa.IdNhom=cbb_id.SelectedValue.ToString() ;
                hangHoa.Mota=txt_mota.Text;
                hangHoa.MaNCC = cbb_nhacc.SelectedValue.ToString();
                hangHoa.Maxuatxu = int.Parse(cbb_xuatxu.SelectedValue.ToString());
                hangHoa.DVT=cbb_dvt.Text;
                if (txt_giaban.Text == "")
                {
                    hangHoa.GiaBan = 0;
                }
                else
                {
                    hangHoa.GiaBan = double.Parse(txt_giaban.Text);
                }
                hangHoa.Disable=cb_dis.Checked;
                hangHoa.Create_Date = dateTimePicker1.Value;
                hangHoa.Create_By=_user.Iduser;
                hangHoa.DonGia=0;
           
                var hh = _hanghoa.add(hangHoa);
                //txt_Barcode.Text=hh.BarCode;
                _SYS_SEQUENCE.update(_seq);
                
            }
            else
            {
                tb_HangHoa hangHoa = _hanghoa.getItem(_barcode);     
                hangHoa.TenHH = txt_tenhang.Text;
                hangHoa.TenTat = txt_tentat.Text;
                hangHoa.IdNhom = cbb_id.SelectedValue.ToString();
                hangHoa.Mota = txt_mota.Text;
                hangHoa.MaNCC = cbb_nhacc.SelectedValue.ToString();
                hangHoa.Maxuatxu = int.Parse(cbb_xuatxu.SelectedValue.ToString());
                hangHoa.DVT = cbb_dvt.Text;
                hangHoa.GiaBan = double.Parse(txt_giaban.Text);
                hangHoa.Disable = cb_dis.Checked;
                hangHoa.Create_Date = dateTimePicker1.Value;
              
                hangHoa.Create_By = _user.Iduser;
                var hh = _hanghoa.update(hangHoa);


            }
            _them = false;
            loadData();
            Enable(false);
            showHideControl(true);
        }

        private void btn_boqua_Click(object sender, EventArgs e)
        {
            _them = false;
            showHideControl(true);
           
            Enable(false);
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GV_Ds_Click(object sender, EventArgs e)
        {
            if (GV_Ds.RowCount > 0)
            {
                _barcode = GV_Ds.GetFocusedRowCellValue("BarCode").ToString();
                txt_tenhang.Text = GV_Ds.GetFocusedRowCellValue("TenHH").ToString();
                txt_tentat.Text = GV_Ds.GetFocusedRowCellValue("TenTat").ToString();
                cbb_dvt.Text = GV_Ds.GetFocusedRowCellValue("DVT").ToString();
                //spin_gianhap.Text = GV_Ds.GetFocusedRowCellValue("DonGia").ToString();
                txt_giaban.Text = GV_Ds.GetFocusedRowCellValue("GiaBan").ToString();
                cbb_nhacc.SelectedValue= GV_Ds.GetFocusedRowCellValue("MaNCC");
                cbb_xuatxu.SelectedValue = GV_Ds.GetFocusedRowCellValue("Maxuatxu");
            
                txt_mota.Text = GV_Ds.GetFocusedRowCellValue("Mota").ToString();
                var createDate = GV_Ds.GetFocusedRowCellValue("Create_Date");
                if (createDate != null && createDate is DateTime)
                {
                    dateTimePicker1.Value = (DateTime)createDate;
                }
                else
                {
                    MessageBox.Show("Giá trị ngày không hợp lệ hoặc không tồn tại.");
                }
                
                cb_dis.Checked = bool.Parse(GV_Ds.GetFocusedRowCellValue("Disable").ToString());

            }
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            _export();
        }
        void _export()
        {
            string tenFile = "";
            SaveFileDialog saveFile=new SaveFileDialog();
            saveFile.Filter ="Excel 200-2003(.xls)|*.xls|Excel 2007 or higher (.xlsx)|*.xlsx";
            if(saveFile.ShowDialog() == DialogResult.OK)
            {
                SplashScreenManager.ShowForm(this,typeof(FrmWaitForm),true,true,false);
                tenFile=saveFile.FileName;
            }
            excel.Application app = new excel.Application();
            excel.Workbook wb = app.Workbooks.Add(Type.Missing);
            excel.Worksheet sheet = null;
            try
            {
                sheet = wb.ActiveSheet;
                // Đặt tên sheet
                sheet.Name = "Danh mục " + cbb_id.Text;

                // Merge các ô từ A1 đến L1
                sheet.Range[sheet.Cells[1, 1], sheet.Cells[1, 12]].Merge();

                // Căn lề giữa cho tiêu đề
                sheet.Cells[1, 1].HorizontalAlignment = excel.XlHAlign.xlHAlignCenter;

                // Viền xung quanh tiêu đề
                sheet.Range[sheet.Cells[1, 1], sheet.Cells[1, 12]].BorderAround(Type.Missing, excel.XlBorderWeight.xlThick, excel.XlColorIndex.xlColorIndexAutomatic);

                // Thiết lập tiêu đề cho bảng
                sheet.Cells[1, 1].Value = "Danh mục " + cbb_id.Text.ToUpper();
                sheet.Cells[1, 1].Font.Size = 20;

                sheet.Cells[2, 1].value = "BARCODE";
                sheet.Cells[2, 2].value = "Tên hàng";
                sheet.Cells[2, 3].value = "Tên tắt";
                sheet.Cells[2, 4].value = "Đơn vị tính";
                sheet.Cells[2, 5].value = "Đơn giá nhập";
                sheet.Cells[2, 6].value = "Đơn giá bán";
                //sheet.Cells[2, 7].value = "ID Nhóm";
                sheet.Cells[2, 7].value = "Nhóm";
                //sheet.Cells[2, 8].value = "Mã Nhà cung cấp";
                sheet.Cells[2, 8].value = "Nhà cung cấp";
                //sheet.Cells[2, 9].value = "Mã Xuất xứ";
                sheet.Cells[2, 9].value = "Xuất xứ";
                sheet.Cells[2, 10].value = "Mô tả";
                sheet.Cells[2, 11].value = "Ngày tạo";
                sheet.Cells[2, 12].value = "Người tạo";
                sheet.Cells[2, 13].value = "Trạng thái";
                //xuat data
                for (int i = 1; i <= _lsthh.Count; i++)
                {
                    sheet.Cells[i + 2, 1].value = _lsthh.ElementAt(i - 1).BarCode;
                    sheet.Cells[i + 2, 2].value = _lsthh.ElementAt(i - 1).TenHH;
                    sheet.Cells[i + 2, 3].value = _lsthh.ElementAt(i - 1).TenTat;
                    sheet.Cells[i + 2, 4].value = _lsthh.ElementAt(i - 1).DVT;
                    sheet.Cells[i + 2, 5].value = _lsthh.ElementAt(i - 1).DonGia;
                    sheet.Cells[i + 2, 6].value = _lsthh.ElementAt(i - 1).GiaBan;
                    // sheet.Cells[i + 2, 7].value = _lsthh.ElementAt(i - 1).IdNhom;
                    sheet.Cells[i + 2, 7].value = _lsthh.ElementAt(i - 1).TenNhom;
                    // sheet.Cells[i+2,8].value = _lsthh.ElementAt(i-1).MaNCC;
                    sheet.Cells[i + 2, 8].value = _lsthh.ElementAt(i - 1).TenNCC;
                    //sheet.Cells[i+2,9].value = _lsthh.ElementAt(i-1).Maxuatxu;
                    sheet.Cells[i + 2, 9].value = _lsthh.ElementAt(i - 1).TenXX;
                    sheet.Cells[i + 2, 10].value = _lsthh.ElementAt(i - 1).Mota;
                    sheet.Cells[i + 2, 11].value = _lsthh.ElementAt(i - 1).Create_Date;
                    sheet.Cells[i + 2, 12].value = _lsthh.ElementAt(i - 1).Create_By_name;
                    sheet.Cells[i + 2, 13].value = _lsthh.ElementAt(i - 1).Disable;


                }
                //cach ngan hon

                //for (int i = 0; i < _lsthh.Count; i++)
                //{
                //    sheet.Cells[i + 3, 1].Value = _lsthh[i].BarCode;
                //    sheet.Cells[i + 3, 2].Value = _lsthh[i].TenHH;
                //    sheet.Cells[i + 3, 3].Value = _lsthh[i].TenTat;
                //    sheet.Cells[i + 3, 4].Value = _lsthh[i].DVT;
                //    sheet.Cells[i + 3, 5].Value = _lsthh[i].DonGia;
                //    sheet.Cells[i + 3, 6].Value = _lsthh[i].TenNhom;
                //    sheet.Cells[i + 3, 7].Value = _lsthh[i].TenNCC;
                //    sheet.Cells[i + 3, 8].Value = _lsthh[i].TenXX;
                //    sheet.Cells[i + 3, 9].Value = _lsthh[i].Mota;

                //    // Định dạng ngày tháng
                //    sheet.Cells[i + 3, 10].Value = _lsthh[i].Create_Date;

                //    sheet.Cells[i + 3, 11].Value = _lsthh[i].Create_By;
                //    sheet.Cells[i + 3, 12].Value = _lsthh[i].Disable ;
                //}

                //save
                wb.SaveAs(tenFile);


            } catch (Exception ex)
            {
                SplashScreenManager.CloseForm(true);
                MessageBox.Show(ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            } finally {
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmBarcode frm = new FrmBarcode();
            this.Hide();
            frm.ShowDialog();
         
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}