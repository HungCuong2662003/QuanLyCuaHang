using BusinessLayer;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;
using DataLayer;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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
using Excel = Microsoft.Office.Interop.Excel;
using static DevExpress.XtraEditors.Mask.MaskSettings;
using System.IO;


namespace QL_Quan_Kho_Hang
{
    public partial class FrmNhapNB : DevExpress.XtraEditors.XtraForm
    {
        public FrmNhapNB()
        {
            InitializeComponent();
        } 
        public FrmNhapNB(tb_SYS_User user, int right)
        {
            InitializeComponent();
            this._user = user;
            this._right = right;
        }
        tb_SYS_User _user;
        int _right;
        CONGTY _congty;
        DONVI _donvi;
        List<TRANGTHAI> _trangthai;
        CHUNGTU _chungtu;
        CHUNGTU_CT _chungtuct;
        SYS_SEQUENCE _SYSSEQUENCE;
        HANGHOA _hanghoa;

        BindingSource _bdCHUNGTUCT;
        BindingSource _bdCHUNGTU;
        Guid _khoa;
        Guid pkhoa;
        tb_SYS_SEQUENCE _seq;
        List<tb_ChungTu> _lstchungTu;
        bool _them=false;


        private void FrmNhapNB_Load(object sender, EventArgs e)
        {
            _congty = new CONGTY();
            _donvi = new DONVI();
            _chungtu = new CHUNGTU();
            _chungtuct = new CHUNGTU_CT();
            _hanghoa = new HANGHOA();
            _SYSSEQUENCE = new SYS_SEQUENCE();
            _bdCHUNGTU = new BindingSource();
            _bdCHUNGTUCT = new BindingSource();
            date_tu.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            date_den.Value = DateTime.Now;
            _bdCHUNGTU.PositionChanged += _bdCHUNGTU_PositionChanged;
            loadCty();
            cbb_congty_chinhanh.SelectedValue = myFunctions._macty;
            cbb_congty_chinhanh.SelectedIndexChanged += Cbb_congty_chinhanh_SelectedIndexChanged;
            _trangthai = TRANGTHAI.getList();
            cbo_trangthai.DataSource = _trangthai;
            cbo_trangthai.DisplayMember = "_display";
            cbo_trangthai.ValueMember = "_value";
            loaddonvi();
            loaddonvinhap();
            loadDvixuat();
            _lstchungTu = _chungtu.getphieunhap(2, date_tu.Value, date_den.Value.AddDays(1), cbo_dvi.SelectedValue.ToString());
            _bdCHUNGTU.DataSource = _lstchungTu;
            gcds.DataSource = _bdCHUNGTU;
            tabCHUNGTU.SelectedTabPage = xtra_ds;
            xuatthongtin();
            cbo_dvi.SelectedIndexChanged += Cbo_dvi_SelectedIndexChanged;
            cb_dis.CheckedChanged += Cb_dis_CheckedChanged;
            txt_sophieu.Enabled = false;
            btn_taoma.Enabled = false;
            _edControl(false);
            if (myFunctions._madvi != "~")
            {
                cbo_dvi.Text= myFunctions._madvi;
                cbo_dvi.Enabled=false;
            }
           

        }

        private void Cb_dis_CheckedChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Cbo_dvi_SelectedIndexChanged(object sender, EventArgs e)
        {
            //loaddonvi();
            _lstchungTu = _chungtu.getphieunhap(2, date_tu.Value, date_den.Value.AddDays(1), cbo_dvi.SelectedValue.ToString());
            _bdCHUNGTU.DataSource = _lstchungTu;
            gcds.DataSource = _bdCHUNGTU;
            xuatthongtin();
        }

        private void Cbb_congty_chinhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            loaddonvi();
            loadDvixuat();
            loaddonvinhap();
        }

        private void _bdCHUNGTU_PositionChanged(object sender, EventArgs e)
        {
            if (!_them)
            {
                xuatthongtin();
            }
        }
        private void LoadData()
        {
            // Nếu CheckBox được tích, gọi getList()
            if (cb_dis.Checked)
            {
                _lstchungTu = _chungtu.getListbycheck(2, date_tu.Value, date_den.Value.AddDays(1), cbo_dvi.SelectedValue.ToString());
            }
            else
            {
                // Nếu CheckBox không được tích, gọi getList với các tham số
                _lstchungTu = _chungtu.getphieunhap(2, date_tu.Value, date_den.Value.AddDays(1), cbo_dvi.SelectedValue.ToString());
            }

            // Cập nhật lại dữ liệu cho BindingSource và DataSource của GridControl
            _bdCHUNGTU.DataSource = _lstchungTu;
            gcds.DataSource = _bdCHUNGTU;
            xuatthongtin();
        }
        void loadCty()
        {
            cbb_congty_chinhanh.DataSource = _congty.getALL();
            cbb_congty_chinhanh.DisplayMember = "TenCty";
            cbb_congty_chinhanh.ValueMember = "MaCty";
        }
        void loadDvixuat()
        {
            cbo_donvixuat.DataSource = _donvi.getItemListKho(cbb_congty_chinhanh.SelectedValue.ToString(), true);
            cbo_donvixuat.DisplayMember = "TenDvi";
            cbo_donvixuat.ValueMember = "MaDvi";
        }
        void loaddonvi()

        {

            cbo_dvi.DataSource = _donvi.getItemListCty(cbb_congty_chinhanh.SelectedValue.ToString());
            cbo_dvi.DisplayMember = "TenDvi";
            cbo_dvi.ValueMember = "MaDvi";
        }
        //void loadkhoDS()
        //{
        //    cbo_kho.DataSource = _donvi.getItemListKho(cbb_congty_chinhanh.SelectedValue.ToString(),true);
        //    cbo_kho.DisplayMember = "TenDvi";
        //    cbo_kho.ValueMember = "MaDvi";
        //}
        void loaddonvinhap()
        {
            cbo_dvinhap.DataSource = _donvi.getItemListKho(cbb_congty_chinhanh.SelectedValue.ToString(), false);
            cbo_dvinhap.DisplayMember = "TenDvi";
            cbo_dvinhap.ValueMember = "MaDvi";
        }
        void _edControl(bool t)
        {
            txt_ghichu.Enabled = t;
            cbo_trangthai.Enabled = t;
            cbo_dvinhap.Enabled = t;
            cbo_donvixuat.Enabled = t;
            date_ngay.Enabled = t;
            txt_sophieu.Enabled = t;
            txt_sophieunhap.Enabled = t;
            date_ngaynhap.Enabled = t;

        }
   
        void xuatthongtin()
        {

            try
            {
                // Lấy chứng từ hiện tại từ BindingSource
                tb_ChungTu current = (tb_ChungTu)_bdCHUNGTU.Current;

                if (current != null)
                {
                    pkhoa = current.Khoa;
                    // Kiểm tra và gán ngày nếu không null
                    if (current.Ngay.HasValue)
                    {
                        date_ngay.Value = current.Ngay.Value;
                    }
                    else
                    {
                        date_ngay.Value = DateTime.Now;
                    }
                    if (current.Ngay2.HasValue)
                    {
                        date_ngaynhap.Value = current.Ngay2.Value;
                    }
         
                    txt_sophieunhap.Text= current.SoChungTu2 ?? string.Empty;
                    // Gán các giá trị khác từ chứng từ hiện tại
                    txt_sophieu.Text = current.SoChungTu ?? string.Empty; // Gán giá trị hoặc rỗng nếu null
                    txt_ghichu.Text = current.GhiChu ?? string.Empty;      // Gán giá trị hoặc rỗng nếu null

                    // Kiểm tra và gán giá trị cho ComboBox, tránh lỗi khi MaDVI hoặc MaDVI2 bị null
                    if (!string.IsNullOrEmpty(current.MaDVI))
                    {
                        cbo_donvixuat.SelectedValue = current.MaDVI;
                    }
                    else
                    {
                        cbo_donvixuat.SelectedIndex = -1;
                    }

                    if (!string.IsNullOrEmpty(current.MaDVI2))
                    {
                        cbo_dvinhap.SelectedValue = current.MaDVI2;
                    }
                    else
                    {
                        cbo_dvinhap.SelectedIndex = -1;
                    }

                    // Gán trạng thái chứng từ
                    cbo_trangthai.SelectedValue = current.TrangThai;

                    // Kiểm tra trạng thái Delete_By
                    if (current.SoChungTu2 != null)
                    {
                        btn_taoma.Enabled = false;
                    }
                    else
                    {
                        btn_taoma.Enabled = true;
                    }

                    // Gán danh sách chi tiết chứng từ
                    _bdCHUNGTUCT.DataSource = _chungtuct.getlistbykhoafull(current.Khoa);
                    gcchitiet.DataSource = _bdCHUNGTUCT;
                    gvchitiet.OptionsBehavior.Editable = false;

                    // Cập nhật cột "Stt" cho mỗi hàng
                    for (int i = 0; i < gvchitiet.RowCount; i++)
                    {
                        gvchitiet.SetRowCellValue(i, "Stt", i + 1);
                    }
                }
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có vấn đề xảy ra
                MessageBox.Show($"Đã xảy ra lỗi khi xuất thông tin: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btn_in_Click(object sender, EventArgs e)
        {
            XuatReport("Phieu_nhap_mua_ncc", "Phiếu nhập mua");
        }
        private void XuatReport(string _reportName, string _tieude)
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
                doc.PrintOptions.PaperSize = PaperSize.DefaultPaperSize; // Hoặc PaperSize.PaperA4
                doc.PrintOptions.ApplyPageMargins(new PageMargins(10, 10, 10, 10)); // Điều chỉnh lề hợp lý
                doc.Database.Tables[0].ApplyLogOnInfo(Thongtin);



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
                    MessageBox.Show("Lỗi khi tải báo cáo: " + ex.Message + "djhfjdhfdjfjdf");
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void gvds_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {

            if (e.Column.FieldName == "TrangThai")
            {
                if (e.CellValue != null && e.CellValue.ToString() == "1")
                {
                    e.DisplayText = "Chưa hoàn tất";
                }
                else
                {
                    e.DisplayText = "Đã hoàn tất";
                }
            }
            // Kiểm tra nếu cột là "Delete_By" và giá trị của ô là 1
            if (e.Column.FieldName == "Delete_By" && e.CellValue != null && e.CellValue.ToString() == "1")
            {
                Image img = Properties.Resources.xoa; // Hình ảnh xóa

                // Xác định kích thước của ô
                int imgWidth = 16;  // Chiều rộng của hình ảnh
                int imgHeight = 16; // Chiều cao của hình ảnh

                // Tính toán vị trí để hình ảnh nằm giữa ô
                int x = e.Bounds.X + (e.Bounds.Width - imgWidth) / 2;
                int y = e.Bounds.Y + (e.Bounds.Height - imgHeight) / 2;

                // Vẽ hình ảnh với kích thước xác định
                e.Graphics.DrawImage(img, new Rectangle(x, y, imgWidth, imgHeight));

                // Đánh dấu sự kiện đã được xử lý để ngăn việc vẽ lại giá trị "1"
                e.Handled = true;
            }
        }

        private void gvds_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {

            if (e.Column.FieldName == "Stt")
            {
                // Hiển thị số thứ tự tự động tăng theo thứ tự hàng
                e.DisplayText = (e.ListSourceRowIndex + 1).ToString();
            }
            if (e.Column.FieldName == "TrangThai") // Tên cột "Trạng thái"
            {
                if (e.Value != null)
                {
                    int trangThai = Convert.ToInt32(e.Value);
                    if (trangThai == 1)
                    {
                        e.DisplayText = "chưa hoàn thành"; // Hiển thị "chưa hoàn thành" nếu giá trị là 1
                    }
                    else if (trangThai == 0)
                    {
                        e.DisplayText = "đã hoàn thành"; // Hiển thị "đã hoàn thành" nếu giá trị là 0
                    }
                }
            }
        }

        private void gvchitiet_KeyDown(object sender, KeyEventArgs e)
        {
            if (gvchitiet.OptionsBehavior.Editable)
            {
            

                if (e.KeyData == Keys.Down)
                {
                    if (int.Parse(gvchitiet.FocusedRowHandle.ToString()) == (gvchitiet.RowCount - 1))
                    {
                        if (gvchitiet.GetRowCellValue(gvchitiet.FocusedRowHandle, "TenHH") != null)
                        {
                            gvchitiet.AddNewRow();
                        }
                    }
                }

                if (e.KeyData == Keys.Up)
                {
                    if (int.Parse(gvchitiet.FocusedRowHandle.ToString()) == (gvchitiet.RowCount - 1))
                    {
                        if ((gvchitiet.FocusedValue == null && gvchitiet.RowCount > 1) ||
                            (gvchitiet.GetRowCellValue(gvchitiet.FocusedRowHandle, "TenHH") == null && gvchitiet.RowCount > 1))
                        {
                            gvchitiet.DeleteSelectedRows();
                        }
                    }
                }
            }
            else
            {
                e.Handled = false;
            }
        }

        private void gvchitiet_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (!gvchitiet.IsGroupRow(e.RowHandle))
            {
                if (e.Info.IsRowIndicator)
                {
                    if (e.RowHandle < 0)
                    {
                        e.Info.ImageIndex = 0;
                        e.Info.DisplayText = string.Empty;
                    }
                    else
                    {
                        e.Info.ImageIndex = -1;
                        e.Info.DisplayText = (e.RowHandle + 1).ToString();
                    }

                    SizeF _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                    Int32 _Width = Convert.ToInt32(_Size.Width) + 20;
                    BeginInvoke(new MethodInvoker(delegate { cal(_Width, gvchitiet); }));
                }
            }
            else
            {
                e.Info.ImageIndex = -1;
                e.Info.DisplayText = string.Format("[{0}]", (e.RowHandle * -1));
                SizeF _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                Int32 _Width = Convert.ToInt32(_Size.Width) + 20;
                BeginInvoke(new MethodInvoker(delegate { cal(_Width, gvchitiet); }));
            }
        }

        private void gvds_DoubleClick(object sender, EventArgs e)
        {
            if (gvds.RowCount > 0)
            {
                tabCHUNGTU.SelectedTabPage = xtra_ct;
            }
        }

        private void date_tu_ValueChanged(object sender, EventArgs e)
        {
            if (date_tu.Value > date_den.Value)
            {
                MessageBox.Show("Ngày không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void date_tu_Leave(object sender, EventArgs e)
        {
            if (date_tu.Value > date_den.Value)
            {
                MessageBox.Show("Ngày không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void date_den_ValueChanged(object sender, EventArgs e)
        {
            if (date_tu.Value > date_den.Value)
            {
                MessageBox.Show("Ngày không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void date_den_Leave(object sender, EventArgs e)
        {
            if (date_tu.Value > date_den.Value)
            {
                MessageBox.Show("Ngày không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        bool cal(int _Width, GridView _View)
        {
            _View.IndicatorWidth = _View.IndicatorWidth < _Width ? _Width : _View.IndicatorWidth;
            return true;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvds_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (!gvds.IsGroupRow(e.RowHandle))
            {
                if (e.Info.IsRowIndicator)
                {
                    if (e.RowHandle < 0)
                    {
                        e.Info.ImageIndex = 0;
                        e.Info.DisplayText = string.Empty;
                    }
                    else
                    {
                        e.Info.ImageIndex = -1;
                        e.Info.DisplayText = (e.RowHandle + 1).ToString();
                    }

                    SizeF _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                    Int32 _Width = Convert.ToInt32(_Size.Width) + 20;
                    BeginInvoke(new MethodInvoker(delegate { cal(_Width, gvds); }));
                }
            }
            else
            {
                e.Info.ImageIndex = -1;
                e.Info.DisplayText = string.Format("[{0}]", (e.RowHandle * -1));
                SizeF _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                Int32 _Width = Convert.ToInt32(_Size.Width) + 20;
                BeginInvoke(new MethodInvoker(delegate { cal(_Width, gvds); }));
            }
        }

        private void btn_taoma_Click(object sender, EventArgs e)
        {
            if (_right == 1)
            {
                MessageBox.Show("Không có quyền thao tác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                tb_ChungTu ctu;
                tb_DonVi dvi = _donvi.getItem(cbo_dvi.SelectedValue.ToString());

                _seq = _SYSSEQUENCE.getitem("NNB@" + DateTime.Today.Year.ToString() + "@" + dvi.KyHieu);
                if (_seq == null)
                {
                    _seq = new tb_SYS_SEQUENCE();
                    _seq.Name = "NNB@" + DateTime.Now.Year.ToString() + "@" + dvi.KyHieu;
                    _seq.value = 1;
                    _SYSSEQUENCE.add(_seq);
                }

                // Xử lý logic cập nhật
                ctu = (tb_ChungTu)_bdCHUNGTU.Current;
                ctu = _chungtu.getItem(ctu.Khoa);
                ctu.SoChungTu2 = _seq.value.Value.ToString("000000") + @"/" + DateTime.Today.Year.ToString().Substring(2, 2) + @"/NNB/" + dvi.KyHieu;
                ctu.Ngay2=DateTime.Now;
                if (ctu == null)
                {
                    MessageBox.Show("Không tìm thấy chứng từ để cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Cập nhật chứng từ
                var resultCtu = _chungtu.update(ctu);
                _SYSSEQUENCE.update(_seq);
                // Cập nhật danh sách
                _lstchungTu = null;
                _lstchungTu = _chungtu.getphieunhap(2, date_ngay.Value, date_den.Value.AddDays(1), cbo_donvixuat.SelectedValue.ToString());
                _bdCHUNGTU.DataSource = _lstchungTu;

                gvds.ClearSorting();
                gvds.RefreshData();

                // Di chuyển con trỏ đến chứng từ mới cập nhật
                var obj = _bdCHUNGTU.List.OfType<tb_ChungTu>().ToList().Find(c => c.SoChungTu == resultCtu.SoChungTu);
                _bdCHUNGTU.Position = _bdCHUNGTU.IndexOf(obj);
                xuatthongtin();

            }
       

        }

  
    }
}