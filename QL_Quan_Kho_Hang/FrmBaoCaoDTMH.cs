using BusinessLayer;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;
using DataLayer;
using DevExpress.XtraCharts;
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
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace QL_Quan_Kho_Hang
{
    public partial class FrmBaoCaoDTMH : DevExpress.XtraEditors.XtraForm
    {
        public FrmBaoCaoDTMH()
        {
            InitializeComponent();
        }
        public FrmBaoCaoDTMH(tb_SYS_User user, int right)
        {
            InitializeComponent();
            this._user = user;
            this._right = right;
        }
        tb_SYS_User _user;
        int _right;
        BaocaodoanhthuNHH _report;
        ThongKeNgay _thongKeNgay;
        private void FrmBaoCaoDTMH_Load(object sender, EventArgs e)
        {
            _report = new BaocaodoanhthuNHH();
            _thongKeNgay = new ThongKeNgay();
            date_tu.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            date_den.Value = DateTime.Now;
            
            // Thiết lập checkbox mặc định
            chkTienMat.Checked = true;
            chkChuyenKhoan.Checked = true;
            
            loadCHART();
            LoadThongKeNgay();
        }
        void loadCHART()
        {
            chartdoanhthu.Series.Clear();
            Series series = new Series("Doanh thu theo nhóm hàng ", ViewType.Pie3D);
            var lst = _report.DoanhThuTheoMH(date_tu.Value, date_den.Value);
            foreach (var item in lst)
            {
                series.Points.Add(new SeriesPoint(item.tenhh, item.thanhtien));
            }
            chartdoanhthu.Series.Add(series);
            series.Label.TextPattern = "{A}: {VP: p0}";
            chartdoanhthu1.Series.Clear();
            Series series1 = new Series("Doanh thu theo nhóm hàng ", ViewType.Area3D);
            var lst1 = _report.DoanhThuTheoMH(date_tu.Value, date_den.Value);
            foreach (var item in lst1)
            {
                series1.Points.Add(new SeriesPoint(item.tenhh, item.thanhtien));
            }
            chartdoanhthu1.Series.Add(series1);
            series1.Label.TextPattern = "{A}: {VP: p0}";
            chartdoanhthu2.Series.Clear();
            Series series2 = new Series("Doanh thu theo nhóm hàng ", ViewType.Bar);
            var lst2 = _report.DoanhThuTheoMH(date_tu.Value, date_den.Value);
            foreach (var item in lst2)
            {
                series2.Points.Add(new SeriesPoint(item.tenhh, item.thanhtien));
            }
            chartdoanhthu2.Series.Add(series2);
            series2.Label.TextPattern = "{A}: {VP: p0}";
            chartdoanhthu3.Series.Clear();
            Series series3 = new Series("Doanh thu theo nhóm hàng ", ViewType.RadarLine);
            var lst3 = _report.DoanhThuTheoMH(date_tu.Value, date_den.Value);
            foreach (var item in lst3)
            {
                series3.Points.Add(new SeriesPoint(item.tenhh, item.thanhtien));
            }
            chartdoanhthu3.Series.Add(series3);
            series3.Label.TextPattern = "{A}: {VP: p0}";
        }

        void LoadThongKeNgay()
        {
            try
            {
                DateTime ngay = date_den.Value.Date;
                bool? loaiThanhToan = null;
                string madvi = MyFunctions._madvi ?? "dvi1";

                // Xác định loại thanh toán cần lọc
                if (chkTienMat.Checked && !chkChuyenKhoan.Checked)
                {
                    loaiThanhToan = false; // Chỉ tiền mặt
                }
                else if (!chkTienMat.Checked && chkChuyenKhoan.Checked)
                {
                    loaiThanhToan = true; // Chỉ chuyển khoản
                }

                // Lấy thống kê tổng quan
                var thongKe = _thongKeNgay.GetThongKeNgay(ngay, loaiThanhToan, madvi);
                
                // Hiển thị thống kê
                DisplayThongKe(thongKe);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải thống kê: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayThongKe(Obj_ThongKeNgay thongKe)
        {
            // Hiển thị thông tin thống kê trong MessageBox
            string thongTin = $"=== THỐNG KÊ NGÀY {thongKe.Ngay:dd/MM/yyyy} ===\n\n" +
                               $"💰 Tiền mặt: {thongKe.TongTienMat:N0} VNĐ ({thongKe.SoHoaDonTienMat} hóa đơn)\n" +
                               $"🏦 Chuyển khoản: {thongKe.TongTienChuyenKhoan:N0} VNĐ ({thongKe.SoHoaDonChuyenKhoan} hóa đơn)\n" +
                               $"📊 Tổng cộng: {thongKe.TongTien:N0} VNĐ ({thongKe.SoHoaDon} hóa đơn)";
            
            MessageBox.Show(thongTin, "Thống kê ngày", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void date_tu_ValueChanged(object sender, EventArgs e)
        {
            loadCHART();
            LoadThongKeNgay();
            if (date_tu.Value > date_den.Value)
            {
                MessageBox.Show("Ngày không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void date_tu_Leave(object sender, EventArgs e)
        {
            loadCHART();
            if (date_tu.Value > date_den.Value)
            {
                MessageBox.Show("Ngày không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void date_den_ValueChanged(object sender, EventArgs e)
        {
            loadCHART();
            LoadThongKeNgay();
            if (date_tu.Value > date_den.Value)
            {
                MessageBox.Show("Ngày không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void date_den_Leave(object sender, EventArgs e)
        {
            loadCHART();
            if (date_tu.Value > date_den.Value)
            {
                MessageBox.Show("Ngày không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            try
            {
                Form frm = new Form();
                CrystalReportViewer Crv = new CrystalReportViewer();

                // Cấu hình Crystal Report Viewer
                Crv.ShowGroupTreeButton = false;
                Crv.ShowParameterPanelButton = false;
                Crv.ToolPanelView = ToolPanelViewType.None;

                TableLogOnInfo Thongtin;
                ReportDocument doc = new ReportDocument();

                // Tải file báo cáo từ thư mục Reports
                string reportPath = System.Windows.Forms.Application.StartupPath + "\\Reports\\" + "SP_DOANHTHU_THEOMATHANG" + ".rpt";
               
                // Kiểm tra tệp báo cáo có tồn tại không
                if (!System.IO.File.Exists(reportPath))
                {
                    // In thông báo lỗi ra màn hình nếu không tìm thấy tệp
                    MessageBox.Show("Không tìm thấy tệp báo cáo: " + reportPath, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Dừng thực thi nếu không tìm thấy tệp
                }

                // Nếu tệp tồn tại, tải báo cáo
                doc.Load(reportPath);

                // Thiết lập thông tin kết nối cơ sở dữ liệu
                Thongtin = doc.Database.Tables[0].LogOnInfo;
                Thongtin.ConnectionInfo.ServerName = myFunctions._srv;
                Thongtin.ConnectionInfo.DatabaseName = myFunctions._db;
                Thongtin.ConnectionInfo.UserID = myFunctions._us;
                Thongtin.ConnectionInfo.Password = myFunctions._pw;

                doc.Database.Tables[0].ApplyLogOnInfo(Thongtin);
                doc.PrintOptions.PaperSize = PaperSize.DefaultPaperSize; // Hoặc PaperSize.PaperA4
                doc.PrintOptions.ApplyPageMargins(new PageMargins(10, 10, 10, 10)); // Điều chỉnh lề hợp lý
                // Thiết lập giá trị tham số cho báo cáo dựa trên điều kiện

                doc.SetParameterValue("@NGAYD", date_tu.Value);
                doc.SetParameterValue("@NGAYC", date_den.Value);


                // Cấu hình Crystal Report Viewer
                Crv.Dock = DockStyle.Fill;
                Crv.ReportSource = doc;
                frm.Controls.Add(Crv);
                Crv.Refresh();

                // Thiết lập các thuộc tính cho form hiển thị báo cáo

                frm.WindowState = FormWindowState.Maximized; // Mở form ở chế độ toàn màn hình
                frm.ShowDialog(); // Hiển thị form báo cáo dưới dạng hộp thoại
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Có lỗi NullReference: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Định dạng dữ liệu không đúng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkTienMat_CheckedChanged(object sender, EventArgs e)
        {
            // Nếu bỏ chọn cả hai thì tự động chọn lại
            if (!chkTienMat.Checked && !chkChuyenKhoan.Checked)
            {
                chkTienMat.Checked = true;
                chkChuyenKhoan.Checked = true;
            }
            else
            {
                LoadThongKeNgay();
            }
        }

        private void chkChuyenKhoan_CheckedChanged(object sender, EventArgs e)
        {
            // Nếu bỏ chọn cả hai thì tự động chọn lại
            if (!chkTienMat.Checked && !chkChuyenKhoan.Checked)
            {
                chkTienMat.Checked = true;
                chkChuyenKhoan.Checked = true;
            }
            else
            {
                LoadThongKeNgay();
            }
        }

        private void btnThongKeNgay_Click(object sender, EventArgs e)
        {
            LoadThongKeNgay();
        }
    }
}