using BusinessLayer;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;
using DataLayer;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.TextEditController.Win32;
using QL_Quan_Kho_Hang;
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
    public partial class FrmBanHang_QL : DevExpress.XtraEditors.XtraForm
    {
        public FrmBanHang_QL()
        {
            InitializeComponent();
        }
        public FrmBanHang_QL(tb_SYS_User user, int right)
        {
            InitializeComponent();
            this._user = user;
            this._right = right;
        }
        tb_SYS_User _user;
        public int _right;
         CONGTY _congty;
         DONVI _donvi;
         CHUNGTU _chungtu;
         CHUNGTU_CT _chungtuct;
         SYS_SEQUENCE _sequence;
         HANGHOA _hanghoa;
         tb_SYS_SEQUENCE _seq;
  
        Guid pkhoa;
        List<obj_CHUNGTU_CT> lstChungtuCT;
        List<string> _lstBarcode;
        double THANHTIEN;
        private void FrmBanHang_QL_Load(object sender, EventArgs e)
        {
            _congty = new CONGTY();
            _donvi = new DONVI();
            _chungtu = new CHUNGTU();
            _chungtuct = new CHUNGTU_CT();
            _hanghoa = new HANGHOA();
            _lstBarcode = new List<string>();   
            _sequence = new SYS_SEQUENCE();

            lstChungtuCT = new List<obj_CHUNGTU_CT>();
        }
        private void btn_In_Click(object sender, EventArgs e)
        {
            if (gvchitiet.RowCount == 0)
            {

                MessageBox.Show("Không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            luuthongtin();
            lstChungtuCT = new List<obj_CHUNGTU_CT>();
            gcchitiet.DataSource = lstChungtuCT;
            XuatReport("Ban_le", "Phiếu nhập mua");

        }

        //private void btn_luu_Click(object sender, EventArgs e)
        //{
        //    if (gvchitiet.RowCount == 0)
        //    {

        //        MessageBox.Show("Không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }
        //    luuthongtin(1);
        //    lstChungtuCT = new List<obj_CHUNGTU_CT>();
        //    gcchitiet.DataSource = lstChungtuCT;
            

        //}
        

        private void btn_chietkhau_Click(object sender, EventArgs e)
        {
            FrmChietKhau frm = new FrmChietKhau(gvchitiet);
            frm.ShowDialog();
        }

        private void btn_tra_Click(object sender, EventArgs e)
        {
            FrmTraHang frm = new FrmTraHang(lstChungtuCT,gcchitiet,gvchitiet);
            frm.ShowDialog();
        }

        private void txt_barcode_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {

                if (!MyFunctions.IsNumberUsingRegex(txt_barcode.Text))
                {
                    MessageBox.Show("Mã Barcode không hợp lệ ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var hh = _hanghoa.getItem(txt_barcode.Text);
                if (hh == null)
                {
                    MessageBox.Show("Không có mã hàng này ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                obj_CHUNGTU_CT ct = new obj_CHUNGTU_CT();
                Obj_HangHoa _hh = new Obj_HangHoa();
                _hh = _hanghoa.getlistbybarcode_Full(txt_barcode.Text).FirstOrDefault(); ;
                ct.Barcode = _hh.BarCode;
                ct.TenHH = _hh.TenHH;
                ct.DVT = _hh.DVT;
                ct.SoluongCT = 1;
                ct.Chietkhau =0;
                ct.GiaBan = _hh.GiaBan;
                ct.Thanhtien = ct.GiaBan *ct.SoluongCT;
                if (lstChungtuCT.Count > 0)
                {
                    var item = lstChungtuCT.FirstOrDefault(x=>x.Barcode==txt_barcode.Text);
                    if (item != null)
                    {
                     
                        lstChungtuCT[lstChungtuCT.IndexOf(item)].SoluongCT=item.SoluongCT+1;
                        lstChungtuCT[lstChungtuCT.IndexOf(item)].Thanhtien = lstChungtuCT[lstChungtuCT.IndexOf(item)].SoluongCT * item.GiaBan;
                    }
                    else
                    {
                        lstChungtuCT.Add(ct);
                    }
                }
                else
                {
                    lstChungtuCT.Add(ct);
                }

            

                gcchitiet.DataSource = lstChungtuCT.ToList();
               
                txt_barcode.Text = "";
                for (int i = 0; i < gvchitiet.RowCount; i++)
                {
                    gvchitiet.SetRowCellValue(i, "Stt", i + 1);
                }

            }
        }
        void chungtu_info(tb_ChungTu chungTu)
        {
            try
            {
                string madvi = "";
             
                if (MyFunctions._madvi == null)
                {
                    madvi = "dvi1";
                }
                else
                {
                    madvi = MyFunctions._madvi;
                }
               

               
                double _tongcong = 0;

                // Kiểm tra và lấy đối tượng đơn vị nếu có
                tb_DonVi dvi = _donvi.getItem(madvi);
         
                 // Kiểm tra và lấy đối tượng chuỗi hệ thống nếu có
                _seq = _sequence.getitem("BLE@" + DateTime.Today.Year.ToString() + "@" + dvi.KyHieu);
                if (_seq == null)
                {
                    _seq = new tb_SYS_SEQUENCE();
                    _seq.Name = "BLE@" + DateTime.Now.Year.ToString() + "@" + dvi.KyHieu;
                    _seq.value = 1;
                    _sequence.add(_seq);
                }

                    chungTu.LoaiCT = 4;
                    chungTu.Khoa = Guid.NewGuid();
                    chungTu.Ngay = DateTime.Now;    
                    chungTu.SoChungTu = _seq.value.Value.ToString("000000") + @"/" + DateTime.Today.Year.ToString().Substring(2, 2) + @"/BLE/" + dvi.KyHieu;
                    chungTu.Create_By = _user.Iduser;
                    chungTu.Create_Date = DateTime.Now;



                chungTu.MaCty = MyFunctions._macty;
                chungTu.MaDVI = madvi;
                chungTu.MaDVI2 = "NCC1";

                // Kiểm tra và chuyển đổi trạng thái thành boolean
                chungTu.TrangThai = 2;
                

                // Kiểm tra nếu giá trị "SoluongCT" là null hoặc không thể chuyển đổi

                chungTu.SoLuong = double.Parse(gvchitiet.Columns["SoluongCT"].SummaryItem.SummaryValue.ToString());



                // Tính tổng tiền và xử lý các dòng chi tiết
                for (int i = 0; i < gvchitiet.RowCount; i++)
                {
                    if (gvchitiet.GetRowCellValue(i, "TenHH") == null)
                    {
                        gvchitiet.DeleteRow(i);
                        goto NEXT;
                    }
                    else
                    {
                        // Kiểm tra nếu giá trị "Thanhtien" là null hoặc không thể chuyển đổi
                        double thanhtien;
                        if (double.TryParse(gvchitiet.GetRowCellValue(i, gvchitiet.Columns["Thanhtien"]).ToString(), out thanhtien))
                        {
                            _tongcong += thanhtien;
                        }
                        else
                        {
                            throw new Exception($"Thành tiền tại dòng {i + 1} không hợp lệ.");
                        }

                    }
                }
                THANHTIEN = _tongcong;
            NEXT:
                chungTu.TongTien = _tongcong;
                chungTu.Update_By = _user.Iduser;
                chungTu.Update_Date = DateTime.Now;
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi cho người dùng
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void chuntuCT_info(tb_ChungTu chungTu)
        {
            _chungtuct.deleteALL(chungTu.Khoa);
            for (int i = 0; i < gvchitiet.RowCount; i++)
            {
                // Kiểm tra nếu 'TenHH' là null thì xóa dòng
                if (gvchitiet.GetRowCellValue(i, "TenHH") == null)
                {
                    gvchitiet.DeleteRow(i);
                }
                else
                {
                    try
                    {
                        tb_Chungtu_CT _ct = new tb_Chungtu_CT();
                        _ct.KhoaCT = Guid.NewGuid();
                        _ct.Khoa = chungTu.Khoa;
                        _ct.Stt = i + 1;
                        _ct.Ngay = DateTime.Now;

                        // Kiểm tra null cho từng giá trị và gán giá trị mặc định nếu null
                        string barcode = gvchitiet.GetRowCellValue(i, "Barcode").ToString();
                        if (!string.IsNullOrEmpty(barcode))
                        {
                            _ct.Barcode = barcode;
                        }
                        else
                        {
                            // Giá trị mặc định hoặc bỏ qua dòng
                            throw new Exception("Barcode không được để trống.");
                        }

                        // Số lượng CT
                        _ct.SoluongCT = double.Parse(gvchitiet.GetRowCellValue(i, "SoluongCT").ToString());



                        // Đơn giá
                        var giabanVal = gvchitiet.GetRowCellValue(i,"GiaBan");
                        if (giabanVal != null && double.TryParse(giabanVal.ToString(), out double Giaban))
                        {
                            _ct.GiaBan = Giaban;
                        }
                        else
                        {
                            throw new Exception("Đơn giá không hợp lệ.");
                        }
                     
                        if (gvchitiet.GetRowCellValue(i, "Chietkhau") != null)
                        {
                            _ct.Chietkhau = double.Parse(gvchitiet.GetRowCellValue(i, "Chietkhau").ToString());
                        }

                        // Thành tiền
                        var thanhtienVal = gvchitiet.GetRowCellValue(i, "Thanhtien");
                        if (thanhtienVal != null && double.TryParse(thanhtienVal.ToString(), out double thanhtien))
                        {
                            _ct.Thanhtien = thanhtien;
                           
                        }
                        else
                        {
                            throw new Exception("Thành tiền không hợp lệ.");
                        }

                        // Thêm bản ghi vào cơ sở dữ liệu
                        _chungtuct.add(_ct);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi tại dòng {i + 1}: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
        private void luuthongtin()
        {
            try
            {

                tb_ChungTu ctu = new tb_ChungTu();
                chungtu_info(ctu);


                // Thêm chứng từ
                var resultCtu = _chungtu.add(ctu);
                pkhoa=resultCtu.Khoa;
                _sequence.update(_seq);
            
               

                // Thêm thông tin chi tiết
                chuntuCT_info(resultCtu);

            }
            catch (Exception ex)
            {
                // Hiển thị lỗi nếu có vấn đề xảy ra
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void XuatReport(string _reportName, string _tieude)
        {
            try
            {
                if (pkhoa != null)
                {


                    Form frm = new Form();
                    CrystalReportViewer Crv = new CrystalReportViewer();
                    Crv.ShowGroupTreeButton = false;
                    Crv.ShowParameterPanelButton = false;
                    Crv.ToolPanelView = ToolPanelViewType.None;

                    TableLogOnInfo Thongtin;
                    ReportDocument doc = new ReportDocument();
                    // Đường dẫn đầy đủ của file .rpt
                    string reportPath = System.Windows.Forms.Application.StartupPath + "\\Reports\\" + _reportName + @".rpt";

                    doc.Load(reportPath); // Sử dụng đường dẫn reportPath

                    Thongtin = doc.Database.Tables[0].LogOnInfo;


                    Thongtin.ConnectionInfo.ServerName = myFunctions._srv;

                    Thongtin.ConnectionInfo.DatabaseName = myFunctions._db;

                    Thongtin.ConnectionInfo.UserID = myFunctions._us;

                    Thongtin.ConnectionInfo.Password = myFunctions._pw;

                    doc.Database.Tables[0].ApplyLogOnInfo(Thongtin);


                    TextObject txtObject = (TextObject)doc.ReportDefinition.ReportObjects["txt_bangchu"];
                    txtObject.Text = docchu.NumberToText(THANHTIEN);



                    try
                    {
                        doc.SetParameterValue("khoa", "{" + pkhoa.ToString() + "}");

                        Crv.Dock = DockStyle.Fill;
                        Crv.ReportSource = doc;
                        frm.Controls.Add(Crv);
                        Crv.Refresh();

                        frm.Text = _tieude;
                        frm.WindowState = FormWindowState.Maximized;
                        frm.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi tải báo cáo: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Hiển thị lỗi nếu có vấn đề xảy ra
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void deleterow_Click(object sender, EventArgs e)
        {
            try
            {
                int index = gvchitiet.FocusedRowHandle;

                // Kiểm tra xem dòng hiện tại có chứa giá trị "Barcode" hay không
                if (gvchitiet.GetRowCellValue(index, "Barcode") != null)
                {
                    string barcode = gvchitiet.GetRowCellValue(index, "Barcode").ToString();

                    // Xóa dòng từ danh sách chính lstChungtuCT
                    var item = lstChungtuCT.FirstOrDefault(x => x.Barcode == barcode);
                    if (item != null)
                    {
                        lstChungtuCT.Remove(item);
                    }

                    // Xóa dòng từ giao diện gvchitiet
                    gvchitiet.DeleteSelectedRows();

                    // Cập nhật lại Stt cho các dòng còn lại
                    for (int i = 0; i < gvchitiet.RowCount; i++)
                    {
                        gvchitiet.SetRowCellValue(i, "Stt", i + 1);
                    }
                }
                else
                {
                    MessageBox.Show("Chưa chọn mẫu tin để xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                gvchitiet.RefreshData();
            }
            catch (Exception ex)
            {
                // Hiển thị lỗi nếu có vấn đề xảy ra
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deletect_Click(object sender, EventArgs e)
        {
            try
            {


                lstChungtuCT.Clear();

                for (int i = gvchitiet.RowCount - 1; i >= 0; i--)
                {

                    gvchitiet.DeleteRow(i);
                }
                gvchitiet.AddNewRow();
                gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "Stt", 1);
            }
            catch (Exception ex)
            {
                // Hiển thị lỗi nếu có vấn đề xảy ra
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gvchitiet_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "SoluongCT")
            {
                try
                {
                    // Kiểm tra "TenHH" có tồn tại hay không
                    if (gvchitiet.GetRowCellValue(gvchitiet.FocusedRowHandle, "TenHH") != null)
                    {
                        // Chuyển đổi giá trị số lượng từ chuỗi sang double
                        if (!double.TryParse(e.Value.ToString(), out double _soluong))
                        {
                            MessageBox.Show("Số lượng không hợp lệ. Vui lòng nhập số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        if (_soluong == 0)
                        {
                            MessageBox.Show("Số lượng không thể bằng 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Lấy thông tin hàng hóa theo Barcode
                        string barcode = gvchitiet.GetRowCellValue(gvchitiet.FocusedRowHandle, "Barcode")?.ToString();
                        if (string.IsNullOrEmpty(barcode))
                        {
                            MessageBox.Show("Không tìm thấy mã Barcode.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        tb_HangHoa hh = _hanghoa.getItem(barcode);
                        if (hh == null)
                        {
                            MessageBox.Show("Không tìm thấy hàng hóa với mã Barcode: " + barcode, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Lấy giá bán
                        if (!double.TryParse(gvchitiet.GetRowCellValue(gvchitiet.FocusedRowHandle, "GiaBan")?.ToString(), out double _trigiatt))
                        {
                            gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "Thanhtien", 0);
                            MessageBox.Show("Giá bán không hợp lệ hoặc chưa được nhập.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Tính thành tiền và gán giá trị
                        gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "Thanhtien", _trigiatt * _soluong);

                        // Cập nhật tổng hợp
                        gvchitiet.UpdateTotalSummary();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin hàng hóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (e.Column.FieldName == "GiaBan")
            {
                double _soluong = double.Parse(gvchitiet.GetRowCellValue(gvchitiet.FocusedRowHandle, "SoluongCT").ToString());
                double _dongia = double.Parse(gvchitiet.GetRowCellValue(gvchitiet.FocusedRowHandle, "GiaBan").ToString());
                gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "Thanhtien", _dongia * _soluong);

                // Cập nhật tổng cộng
                gvchitiet.UpdateTotalSummary();

            }
            gvchitiet.RefreshData();
        }

        private void gcchitiet_Click(object sender, EventArgs e)
        {

        }
    }
}