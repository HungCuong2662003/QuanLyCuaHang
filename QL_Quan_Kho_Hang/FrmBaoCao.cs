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
using DataLayer;
using BusinessLayer;
using QL_Quan_Kho_Hang.myControl;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;
namespace QL_Quan_Kho_Hang
{
    public partial class FrmBaoCao : DevExpress.XtraEditors.XtraForm
    {
        public FrmBaoCao()
        {
            InitializeComponent();
        }
        public FrmBaoCao(tb_SYS_User user)
        {
            InitializeComponent();
            _user = user;
        }
        tb_SYS_User _user;
        SYS_USER sYS_USER;
        SYS_REPORT sYS_REPORT;
        SYS_RIGHT_REP sYS_RIGHT_REP;
        Panel _panel;
        UserControlCty _UserControlCty;
        UserControlDvi _UserControlDvi;
        UserControlTuNgay _UserControlTuNgay;

        private void FrmBaoCao_Load(object sender, EventArgs e)
        {
        
            sYS_REPORT = new SYS_REPORT();
            sYS_USER = new SYS_USER();
            sYS_RIGHT_REP = new SYS_RIGHT_REP();
            // Thiết lập DataSource cho lstDanhSach từ danh sách quyền theo nhóm và người dùng
         
            List_menu.DataSource = sYS_REPORT.getListByRight(
                                        sYS_RIGHT_REP.GetListByUser(_user.Iduser));

            // Thiết lập cột hiển thị (DisplayMember) là "DESCRIPTION"
            List_menu.DisplayMember = "Description";

            // Thiết lập giá trị (ValueMember) là "Rep_code"
            List_menu.ValueMember = "Rep_code";
            List_menu.SelectedIndexChanged += List_menu_SelectedIndexChanged;
            LoadUserControls();


        }

        private void List_menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadUserControls();
        }

        void LoadUserControls()
        {
            tb_SYS_report rep = sYS_REPORT.getItem(int.Parse(List_menu.SelectedValue.ToString()));

            if (_panel != null)
            {
                _panel.Dispose();
            }

            _panel = new Panel();
            _panel.Dock = DockStyle.Top;
            _panel.MinimumSize = new Size(_panel.Width, 500);
        
            List<Control> _ctrl = new List<Control>();

            if (rep.TuNgay == true)
            {
                _UserControlTuNgay = new UserControlTuNgay(rep.tonkho.Value);

                _UserControlTuNgay.Dock = DockStyle.Top;
               
                _ctrl.Add(_UserControlTuNgay);
            }
            if (rep.Macty == true)
            {
                _UserControlCty = new UserControlCty
                {
                    Dock = DockStyle.Top
                };
                _ctrl.Add(_UserControlCty);
            }
            if (rep.madvi == true)
            {
                _UserControlDvi = new UserControlDvi
                {
                    Dock = DockStyle.Top
                };
                _ctrl.Add(_UserControlDvi);
            }
            _ctrl.Reverse();
            _panel.Controls.AddRange(_ctrl.ToArray());  
            this.splitContainerControl1.Panel2.Controls.Add(_panel);
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_th_Click(object sender, EventArgs e)
        {
            try
            {
                tb_SYS_report rp = sYS_REPORT.getItem(int.Parse(List_menu.SelectedValue.ToString()));
                Form frm = new Form();
                CrystalReportViewer Crv = new CrystalReportViewer();

                // Cấu hình Crystal Report Viewer
                Crv.ShowGroupTreeButton = false;
                Crv.ShowParameterPanelButton = false;
                Crv.ToolPanelView = ToolPanelViewType.None;

                TableLogOnInfo Thongtin;
                ReportDocument doc = new ReportDocument();

                // Tải file báo cáo từ thư mục Reports
                string reportPath = System.Windows.Forms.Application.StartupPath + "\\Reports\\" + rp.Rep_name + ".rpt";

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

                // Thiết lập giá trị tham số cho báo cáo dựa trên điều kiện
                if (rp.TuNgay == true)
                {
                    if (_UserControlTuNgay.date_tu == null || _UserControlTuNgay.date_den == null)
                        throw new Exception("Ngày bắt đầu hoặc ngày kết thúc không được chọn.");

                    doc.SetParameterValue("@NGAYD", _UserControlTuNgay.date_tu.Value);
                    doc.SetParameterValue("@NGAYC", _UserControlTuNgay.date_den.Value);
                }

                if (rp.Macty == true)
                {
                    if (_UserControlCty.cbb_congty_chinhanh.SelectedValue == null)
                        throw new Exception("Mã công ty không được chọn.");
                    doc.SetParameterValue("@MACTY", _UserControlCty.cbb_congty_chinhanh.SelectedValue.ToString());
                }

                if (rp.madvi == true)
                {
                    if (_UserControlDvi.cbo_donvi.SelectedValue == null)
                        throw new Exception("Mã đơn vị không được chọn.");
                    doc.SetParameterValue("@MADVI", _UserControlDvi.cbo_donvi.SelectedValue.ToString());
                }

                // Cấu hình Crystal Report Viewer
                Crv.Dock = DockStyle.Fill;
                Crv.ReportSource = doc;
                frm.Controls.Add(Crv);
                Crv.Refresh();

                // Thiết lập các thuộc tính cho form hiển thị báo cáo
                frm.Text = rp.Description; // Tiêu đề form lấy từ thuộc tính DESCRIPTION của báo cáo
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
    }
}