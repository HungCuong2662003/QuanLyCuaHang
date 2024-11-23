using BusinessLayer;
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
using DevExpress.XtraSplashScreen;
using Excel=Microsoft.Office.Interop.Excel;
using DevExpress.DXTemplateGallery.Extensions;
using System.IO;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraRichEdit.Import.Html;
using System.Diagnostics;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;

namespace QL_Quan_Kho_Hang
{

    public partial class FrmNhapmua : DevExpress.XtraEditors.XtraForm
    {

        public FrmNhapmua()
        {
            InitializeComponent();
        }
        public FrmNhapmua(tb_SYS_User user, int right)
        {
            InitializeComponent();
            this._user = user;
            this._right = right;
        }


        tb_SYS_User _user;
        int _right;
        CONGTY _congty;
        DONVI _donvi;
        NHACC _nhACC;
        bool _them;
     
        bool _sua = false;
        List<string> _lstBarcode;
        string err = "";
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
        bool _isImport;


        private void FrmNhapmua_Load(object sender, EventArgs e)
        {

            _congty = new CONGTY();
            _donvi = new DONVI();
            _nhACC = new NHACC();

            _lstBarcode = new List<string>();
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
            cbb_congty_chinhanh.SelectedIndexChanged += Cbb_congty_chinhanh_SelectedIndexChanged;
            _trangthai = TRANGTHAI.getList();
            cbo_trangthai.DataSource = _trangthai;
            cbo_trangthai.DisplayMember = "_display";
            cbo_trangthai.ValueMember = "_value";


            loadKho();
            loadDvi();
            loadNCC();
         

            _lstchungTu = _chungtu.getList(1,date_tu.Value, date_den.Value.AddDays(1), cbo_kho.SelectedValue.ToString());
            _bdCHUNGTU.DataSource = _lstchungTu;
            gcds.DataSource = _bdCHUNGTU;
            tabCHUNGTU.SelectedTabPage = xtra_ds;


            xuatthongtin();
            cbo_donvinhap.SelectedIndexChanged += Cbo_donvinhap_SelectedIndexChanged;
            cbo_kho.SelectedIndexChanged += Cbo_kho_SelectedIndexChanged;
            cb_dis.CheckedChanged += Cb_dis_CheckedChanged;
            showHideControl(true);
            contextMenuStrip1.Enabled = false;
            txt_sophieu.Enabled = false;


        }

        private void Cb_dis_CheckedChanged(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            // Nếu CheckBox được tích, gọi getList()
            if (cb_dis.Checked)
            {
                _lstchungTu = _chungtu.getListbycheck(2,date_tu.Value, date_den.Value.AddDays(1), cbo_kho.SelectedValue.ToString());
            }
            else
            {
                // Nếu CheckBox không được tích, gọi getList với các tham số
                _lstchungTu = _chungtu.getList(1, date_tu.Value, date_den.Value.AddDays(1), cbo_kho.SelectedValue.ToString());
            }

            // Cập nhật lại dữ liệu cho BindingSource và DataSource của GridControl
            _bdCHUNGTU.DataSource = _lstchungTu;
            gcds.DataSource = _bdCHUNGTU;
            xuatthongtin();
        }

        private void Cbo_kho_SelectedIndexChanged(object sender, EventArgs e)
        {
            //loadDvi();
            _lstchungTu = _chungtu.getList(1, date_tu.Value, date_den.Value.AddDays(1), cbo_kho.SelectedValue.ToString());
            _bdCHUNGTU.DataSource = _lstchungTu;
            gcds.DataSource = _bdCHUNGTU;
            xuatthongtin();
        }

        private void Cbo_donvinhap_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void _bdCHUNGTU_PositionChanged(object sender, EventArgs e)
        {

            if (!_them)
            {
                xuatthongtin();
            }
        }

        private void Cbb_congty_chinhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadKho();
            loadDvi();
            loadNCC();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {

            if (_right == 1)
            {
                MessageBox.Show("khong co quyen thao tac", "thongbao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Đặt lại nguồn dữ liệu
            _bdCHUNGTUCT.DataSource = _chungtuct.getlistbykhoafull(_khoa);
            gcchitiet.DataSource = _bdCHUNGTUCT;

            // Thêm một dòng mới
            gvchitiet.AddNewRow();

            // Chuyển đến tab chứa chi tiết
            tabCHUNGTU.SelectedTabPage = xtra_ct;

            // Kích hoạt chế độ chỉnh sửa
            gvchitiet.OptionsBehavior.Editable = true;
            contextMenuStrip1.Enabled = true;

            // Đặt cờ trạng thái để biết đang thêm mới
            _them = true;
            _sua = false;

            showHideControl(false);
            _edControl(true);
            _reset();

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {

            if (_right == 1)
            {
                MessageBox.Show("Không có quyền thao tác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                tb_ChungTu current = (tb_ChungTu)_bdCHUNGTU.Current;
                if (current.TrangThai == 1)
                {
                    _them = false;
                    _sua = true;
                    showHideControl(false);
                    _edControl(true);
                    tabCHUNGTU.SelectedTabPage = xtra_ct;
                    tabCHUNGTU.TabPages[0].PageEnabled = false;
                    gvchitiet.OptionsBehavior.Editable = true;
                    contextMenuStrip1.Enabled = true;
                    //cbo_donvinhap.Enabled = false;

                    if (gvchitiet.RowCount == 0)
                    {
                        List<V_Chungtu_CT> _lstChiTiet = new List<V_Chungtu_CT>();
                        _bdCHUNGTU.DataSource = _lstChiTiet;
                        gcchitiet.DataSource = _bdCHUNGTU;
                        gvchitiet.AddNewRow();
                        gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "Stt", 1);
                    }
                }
                else
                {
                    MessageBox.Show("Không được phép chỉnh sửa chứng từ đã hoàn tất.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {

            // Kiểm tra quyền người dùng
            if (_right == 1)
            {
                MessageBox.Show("Không có quyền thao tác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                // Xác nhận trước khi xóa
                if (MessageBox.Show("Bạn có chắc muốn hủy phiếu nhập này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    // Lấy phiếu nhập hiện tại
                    tb_ChungTu current = (tb_ChungTu)_bdCHUNGTU.Current;
                    int index = _bdCHUNGTU.Position;

                    // Xóa phiếu nhập dựa trên khóa và loại bỏ khỏi danh sách
                    _chungtu.delete(current.Khoa, 1);

                    // Cập nhật giá trị cột "Delete_By" trên gridview tại hàng hiện tại
                    gvds.SetRowCellValue(index, "Delete_By", 1);

                    // Đảm bảo nút xóa được hiển thị sau khi xóa
                    btn_xoa.Visible = true;
                }
            }
            return;
        }


        private void btn_luu_Click(object sender, EventArgs e)
        {

            luuthongtin();
            _them = false;
            _sua = false;
            //gvchitiet.OptionsBehavior.Editable = false;
            contextMenuStrip1.Enabled = false;
            tabCHUNGTU.TabPages[0].PageEnabled = true;
            showHideControl(true);
            _edControl(false);
        }

        private void btn_boqua_Click(object sender, EventArgs e)
        {

            _them = false;
            _sua = false;
            showHideControl(true);
            _reset();
            xuatthongtin();
            tabCHUNGTU.TabPages[0].PageEnabled = true;
            tabCHUNGTU.SelectedTabPage = xtra_ds;
            gvchitiet.OptionsBehavior.Editable = false;
            contextMenuStrip1.Enabled = false;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        void loadCty()
        {
            cbb_congty_chinhanh.DataSource = _congty.getALL();
            cbb_congty_chinhanh.DisplayMember = "TenCty";
            cbb_congty_chinhanh.ValueMember = "MaCty";
        }
        void loadDvi()
        {
            cbo_donvinhap.DataSource = _donvi.getItemListKho(cbb_congty_chinhanh.SelectedValue.ToString(), true);
            cbo_donvinhap.DisplayMember = "TenDvi";
            cbo_donvinhap.ValueMember = "MaDvi";
        }
        void loadKho()
        {
            cbo_kho.DataSource = _donvi.getItemListKho(cbb_congty_chinhanh.SelectedValue.ToString(), true);
            cbo_kho.DisplayMember = "TenDvi";
            cbo_kho.ValueMember = "MaDvi";
        }

        void loadNCC()
        {
            cbo_dvincc.DataSource = _nhACC.getALL();
            cbo_dvincc.DisplayMember = "TenNCC";
            cbo_dvincc.ValueMember = "MaNCC";
        }
        void _edControl(bool t)
        {
            txt_ghichu.Enabled = t;
            cbo_trangthai.Enabled = t;
            cbo_donvinhap.Enabled = t;
            cbo_dvincc.Enabled = t;
            date_ngay.Enabled = t;

        }
        void _reset()
        {
            txt_sophieu.Text = "";
            txt_ghichu.Text = "";
        }
        void showHideControl(bool t)
        {
            btn_them.Visible = t;
            btn_sua.Visible = t;
            btn_xoa.Visible = t;
            btn_luu.Visible = !t;
            btn_boqua.Visible = !t;
        }
        private void gvchitiet_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

            if (!_isImport)
            {
                if (e.Column.FieldName == "Barcode")
                {

                    if (gvchitiet.GetRowCellValue(gvchitiet.FocusedRowHandle, "Barcode").ToString().IndexOf(".") == 0)
                    {
                        _isImport = true;
                        FrmDanhMuc _popDm = new FrmDanhMuc(gvchitiet, gvchitiet.GetRowCellValue(gvchitiet.FocusedRowHandle, "Barcode").ToString(),1);
                        _popDm.ShowDialog();

                    }
                    else
                    {
                        tb_HangHoa hh = _hanghoa.getItem(e.Value.ToString());
                        if (hh != null)
                        {
                            if (_hanghoa.checkexit(hh.BarCode))
                            {
                                List<string> s = new List<string>();
                                if (gvchitiet.RowCount > 1)
                                {
                                    for (int i = 0; i < gvchitiet.RowCount; i++)
                                    {
                                        s.Add(gvchitiet.GetRowCellValue(i, "Barcode").ToString());
                                    }
                                    if (s.Find(x => x.Equals(e.Value.ToString())) != null)
                                    {
                                        MessageBox.Show("ma nay da co ", "loi nhap lieu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                    else
                                    {
                                        gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "TenHH", hh.TenHH);
                                        gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "DVT", hh.DVT);
                                        gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "SoluongCT", 1);
                                        gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "Dongia", hh.DonGia);
                                        gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "GiaBan", hh.GiaBan);
                                        gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "Thanhtien", hh.DonGia);
                                        gvchitiet.UpdateTotalSummary();
                                    }
                                }
                                else
                                {
                                    gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "TenHH", hh.TenHH);
                                    gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "DVT", hh.DVT);
                                    gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "SoluongCT", 1);
                                    gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "Dongia", hh.DonGia);
                                    gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "GiaBan", hh.GiaBan);
                                    gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "Thanhtien", hh.DonGia);
                                    gvchitiet.UpdateTotalSummary();
                                }
                            }
                            else
                            {
                                MessageBox.Show("ma nay da duoc nhap ", "loi ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("ma tai san khong chinh xac. kiem tra lai ", " loi ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        gvchitiet.RefreshData();
                    }

                }
                //thay doi so luong
                if (e.Column.FieldName == "SoluongCT")
                {
                    if (gvchitiet.GetRowCellValue(gvchitiet.FocusedRowHandle, "TenHH") != null)
                    {
                        double _soluong = double.Parse(e.Value.ToString());
                        if (_soluong != 0)
                        {
                            tb_HangHoa hh = _hanghoa.getItem(gvchitiet.GetRowCellValue(gvchitiet.FocusedRowHandle, "Barcode").ToString());
                            if (gvchitiet.GetRowCellValue(gvchitiet.FocusedRowHandle, "Dongia") != null)
                            {
                                double _trigiatt = double.Parse(gvchitiet.GetRowCellValue(gvchitiet.FocusedRowHandle, "Dongia").ToString());
                                gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "Thanhtien", _trigiatt * _soluong);

                            }
                            else
                            {
                                gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "Thanhtien", 0);
                            }
                            gvchitiet.UpdateTotalSummary();

                        }
                        else
                        {
                            MessageBox.Show("so luong khong the bang 0 ", " loi ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        return;

                    }

                }
                if (e.Column.FieldName == "Dongia")
                {
                    // Lấy mã vạch của hàng hóa từ dòng hiện tại
                    string _barcode = gvchitiet.GetRowCellValue(gvchitiet.FocusedRowHandle, "Barcode").ToString();

                    // Lấy đối tượng hàng hóa dựa trên mã vạch
                    tb_HangHoa hangHoa = _hanghoa.getItem(_barcode);

                    // Cập nhật thông tin hàng hóa từ các điều khiển trên form
                    hangHoa.DonGia = double.Parse(gvchitiet.GetRowCellValue(gvchitiet.FocusedRowHandle, "Dongia").ToString());
             
                    // Gọi hàm cập nhật hàng hóa
                    var hh = _hanghoa.update(hangHoa);

          
                    double _soluong = double.Parse(gvchitiet.GetRowCellValue(gvchitiet.FocusedRowHandle, "SoluongCT").ToString());
                    double _dongia = double.Parse(gvchitiet.GetRowCellValue(gvchitiet.FocusedRowHandle, "Dongia").ToString());
                    gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "Thanhtien", _dongia * _soluong);

                    // Cập nhật tổng cộng
                    gvchitiet.UpdateTotalSummary();


                }
                if (e.Column.FieldName == "GiaBan")
                {
                    // Lấy mã vạch của hàng hóa từ dòng hiện tại
                    string _barcode = gvchitiet.GetRowCellValue(gvchitiet.FocusedRowHandle, "Barcode").ToString();

                    // Lấy đối tượng hàng hóa dựa trên mã vạch
                    tb_HangHoa hangHoa = _hanghoa.getItem(_barcode);

                    // Cập nhật thông tin hàng hóa từ các điều khiển trên form
                 
       
                    hangHoa.GiaBan = double.Parse(gvchitiet.GetRowCellValue(gvchitiet.FocusedRowHandle, "GiaBan").ToString());
                    // Gọi hàm cập nhật hàng hóa
                    var hh = _hanghoa.update(hangHoa);

                   
                }
                gvchitiet.RefreshData();
            }
        }
        void chungtu_info(tb_ChungTu chungTu)
        {
            try
            {
                double _tongcong = 0;

                // Kiểm tra và lấy đối tượng đơn vị nếu có
                tb_DonVi dvi = _donvi.getItem(cbo_donvinhap.SelectedValue.ToString());



                if (dvi == null)
                {
                    throw new Exception("Đơn vị nhập không hợp lệ.");
                }

                // Kiểm tra và lấy đối tượng chuỗi hệ thống nếu có
                _seq = _SYSSEQUENCE.getitem("NHM@" + DateTime.Today.Year.ToString() + "@" + dvi.KyHieu);
                if (_seq == null)
                {
                    _seq = new tb_SYS_SEQUENCE();
                    _seq.Name = "NHM@" + DateTime.Now.Year.ToString() + "@" + dvi.KyHieu;
                    _seq.value = 1;
                    _SYSSEQUENCE.add(_seq);
                }


                if (_them)
                {
                    chungTu.LoaiCT = 1;
                    chungTu.Khoa = Guid.NewGuid();
                    chungTu.Ngay = date_ngay.Value;
                    chungTu.SoChungTu = _seq.value.Value.ToString("000000") + @"/" + DateTime.Today.Year.ToString().Substring(2, 2) + @"/NHM/" + dvi.KyHieu;
                    chungTu.Create_By = _user.Iduser;
                    chungTu.Create_Date = DateTime.Now;
                }
                chungTu.SoChungTu = _seq.value.Value.ToString("000000") + @"/" + DateTime.Today.Year.ToString().Substring(2, 2) + @"/NHM/" + dvi.KyHieu;
                chungTu.MaCty = cbb_congty_chinhanh.SelectedValue.ToString();
                chungTu.MaDVI = cbo_donvinhap.SelectedValue.ToString();
                if (cbo_dvincc.SelectedValue.ToString() == null)
                {
                    MessageBox.Show("Chưa nhập đơn vị cung cấp", "thông báo", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    chungTu.MaDVI2 = cbo_dvincc.SelectedValue.ToString();
                }
               

                // Kiểm tra và chuyển đổi trạng thái thành boolean
                chungTu.TrangThai = int.Parse(cbo_trangthai.SelectedValue.ToString());
                chungTu.GhiChu = txt_ghichu.Text;

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
            NEXT:
                chungTu.TongTien = _tongcong;
                chungTu.Update_By = 1;
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
                        _ct.Ngay = date_ngay.Value;

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
                        var dongiaVal = gvchitiet.GetRowCellValue(i, "Dongia");
                        if (dongiaVal != null && double.TryParse(dongiaVal.ToString(), out double dongia))
                        {
                            _ct.Dongia = dongia;
                        }
                        else
                        {
                            _ct.Dongia = 0;
                        }
                  
                        var GiaBanVal = gvchitiet.GetRowCellValue(i, "GiaBan");
                        if (GiaBanVal != null && double.TryParse(GiaBanVal.ToString(), out double GiaBan))
                        {
                            _ct.GiaBan = GiaBan;
                        }
                        else
                        {
                            _ct.GiaBan = 0;
                           
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
                err = "";
                tb_ChungTu ctu;

                // Kiểm tra nếu không có chi tiết
                if (gvchitiet.RowCount == 0)
                {
                    err += "Chi tiết phiếu xuất không được rỗng.\r\n";
                    MessageBox.Show("Chi tiết phiếu xuất không được rỗng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra nếu chỉ có một dòng nhưng không có dữ liệu
                if (gvchitiet.RowCount == 1 && gvchitiet.GetRowCellValue(0, "Barcode") == null)
                {
                    err += "Chi tiết phiếu xuất không được rỗng.";
                    MessageBox.Show("Chi tiết phiếu xuất không được rỗng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Xử lý logic thêm mới
                if (_them)
                {
                    ctu = new tb_ChungTu();
                    chungtu_info(ctu);


                    // Thêm chứng từ
                    var resultCtu = _chungtu.add(ctu);

                    //foreach (var prop in resultCtu.GetType().GetProperties())
                    //{
                    //    var value = prop.GetValue(resultCtu, null) ?? "null";
                    //    Debug.WriteLine($"{prop.Name}: {value}");
                    //    // Hoặc sử dụng Console.WriteLine nếu là ứng dụng console
                    //    Console.WriteLine($"{prop.Name}: {value}");
                    //}
                    _SYSSEQUENCE.update(_seq);

                    // Thêm thông tin chi tiết
                    chuntuCT_info(resultCtu);

                    _bdCHUNGTU.Add(resultCtu);
                    _bdCHUNGTU.MoveLast();
                }
                else
                {
                    // Xử lý logic cập nhật
                    ctu = (tb_ChungTu)_bdCHUNGTU.Current;
                    ctu = _chungtu.getItem(ctu.Khoa);

                    if (ctu == null)
                    {
                        MessageBox.Show("Không tìm thấy chứng từ để cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    chungtu_info(ctu);

                    // Cập nhật chứng từ
                    var resultCtu = _chungtu.update(ctu);

                    // Cập nhật thông tin chi tiết
                    chuntuCT_info(resultCtu);

                    // Cập nhật danh sách
                    _lstchungTu = null;
                    _lstchungTu = _chungtu.getList(1, date_ngay.Value, date_den.Value.AddDays(1), cbo_donvinhap.SelectedValue.ToString());
                    _bdCHUNGTU.DataSource = _lstchungTu;

                    gvds.ClearSorting();
                    gvds.RefreshData();

                    // Di chuyển con trỏ đến chứng từ mới cập nhật
                    var obj = _bdCHUNGTU.List.OfType<tb_ChungTu>().ToList().Find(c => c.SoChungTu == resultCtu.SoChungTu);
                    _bdCHUNGTU.Position = _bdCHUNGTU.IndexOf(obj);
                }

                // Hiển thị thông tin sau khi lưu thành công
                xuatthongtin();

                _them = false;
                tabCHUNGTU.SelectedTabPage = xtra_ds;
            }
            catch (Exception ex)
            {
                // Hiển thị lỗi nếu có vấn đề xảy ra
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

                    // Gán các giá trị khác từ chứng từ hiện tại
                    txt_sophieu.Text = current.SoChungTu ?? string.Empty; // Gán giá trị hoặc rỗng nếu null
                    txt_ghichu.Text = current.GhiChu ?? string.Empty;      // Gán giá trị hoặc rỗng nếu null

                    // Kiểm tra và gán giá trị cho ComboBox, tránh lỗi khi MaDVI hoặc MaDVI2 bị null
                    if (!string.IsNullOrEmpty(current.MaDVI))
                    {
                        cbo_donvinhap.SelectedValue = current.MaDVI;
                    }
                    else
                    {
                        cbo_donvinhap.SelectedIndex = -1;
                    }

                    if (!string.IsNullOrEmpty(current.MaDVI2))
                    {
                        cbo_dvincc.SelectedValue = current.MaDVI2;
                    }
                    else
                    {
                        cbo_dvincc.SelectedIndex = -1;
                    }

                    // Gán trạng thái chứng từ
                    cbo_trangthai.SelectedValue = current.TrangThai;

                    // Kiểm tra trạng thái Delete_By
                    if (current.Delete_By == 0)
                    {
                        btn_xoa.Enabled = false;  // Nếu đã xóa, không cho phép xóa lại
                    }
                    else
                    {
                        btn_xoa.Enabled = true;   // Nếu chưa xóa, cho phép xóa
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




        private void deleterow_Click(object sender, EventArgs e)
        {
            int index = 0;
            if (gvchitiet.GetRowCellValue(gvchitiet.FocusedRowHandle, "Barcode") != null)
            {
                if (_them)
                {
                    gvchitiet.DeleteSelectedRows();
                }
                else
                {
                    index = gvchitiet.FocusedRowHandle;
                    _lstBarcode.Add(gvchitiet.GetRowCellValue(gvchitiet.FocusedRowHandle, "Barcode").ToString());
                    gvchitiet.DeleteSelectedRows();

                }
                if (gvchitiet.RowCount == 0)
                {
                    gvchitiet.AddNewRow();
                    gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "Stt", 1);
                }
                else
                {
                    for (int i = 0; i < gvchitiet.RowCount; i++)
                    {
                        gvchitiet.FocusedRowHandle = i;
                        gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "Stt", i + 1);
                    }
                }
                gvchitiet.FocusedRowHandle = index;
            }
            else
            {
                MessageBox.Show("chua chon mau tin ", " loi ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void deletect_Click(object sender, EventArgs e)
        {
            _lstBarcode.Clear();
            for (int i = gvchitiet.RowCount - 1; i >= 0; i--)
            {
                _lstBarcode.Add(gvchitiet.GetRowCellValue(gvchitiet.FocusedRowHandle, "Barcode").ToString());
                gvchitiet.DeleteRow(i);
            }
            gvchitiet.AddNewRow();
            gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "Stt", 1);
        }

        private void import_Click(object sender, EventArgs e)
        {
            importExcel();
        }
        void importExcel()
        {
            string filename = "";
            List<errExport> err = new List<errExport>();
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Excel 2000-2003 (.xls)|*.xls|Excel 2007 (.xlsx)|*.xlsx";
            if (op.ShowDialog() == DialogResult.OK)
            {
                SplashScreenManager.ShowForm(this, typeof(FrmWaitForm), true, true, false);
                _isImport = true;
                List<string> s = new List<string>();
                List<string> _exist = new List<string>();

                if (gvchitiet.RowCount > 1)
                {
                    if (gvchitiet.GetRowCellValue(gvchitiet.RowCount - 1, "TenHH") != null)
                    {
                        for (int i = 0; i < gvchitiet.RowCount; i++)
                        {
                            _exist.Add(gvchitiet.GetRowCellValue(i, "Barcode").ToString());
                        }
                    }
                    else
                    {
                        for (int i = 0; i < gvchitiet.RowCount; i++)
                        {
                            _exist.Add(gvchitiet.GetRowCellValue(i, "Barcode").ToString());
                        }
                    }
                }

                filename = op.FileName;
                // Đọc file excel
                // Tạo đối tượng Excel


                Excel.Application app = new Excel.Application();

                // Kết nối với tệp tin Excel
                Excel.Workbook wb = app.Workbooks.Open(filename);
                List<obj_CHUNGTU_CT> lstCTCT = new List<obj_CHUNGTU_CT>();

                try
                {
                    // Kết nối với sheet cần đọc
                    Excel._Worksheet sheet = wb.Sheets["Sheet1"];

                    // Giới hạn đọc từ dòng có dữ liệu đến dòng cột nào
                    Excel.Range range = sheet.UsedRange;
                    double tongdong = range.Rows.Count;

                    for (float i = 2; i <= range.Rows.Count; i++)
                    {
                        tb_HangHoa hh = _hanghoa.getItem(range.Cells[i, 1].Value.ToString());

                        if (hh == null)
                        {
                            errExport _err = new errExport();
                            _err._barcode = range.Cells[i, 1].Value.ToString();
                            _err._soluong = double.Parse(range.Cells[i, 2].Value.ToString());
                            _err._errcode = "Barcode không tồn tại";
                            err.Add(_err);
                            continue;
                        }
                        else
                        {
                            if (_exist.Find(x => x.Equals(hh.BarCode)) != null)
                            {
                                errExport _err = new errExport();
                                _err._barcode = range.Cells[i, 1].Value.ToString();
                                _err._soluong = double.Parse(range.Cells[i, 2].Value.ToString());
                                _err._errcode = "Trùng Barcode";
                                err.Add(_err);
                                continue;
                            }
                            else
                            {
                                s.Add(range.Cells[i, 1].Value.ToString() + "," + range.Cells[i, 2].Value.ToString());
                                _exist.Add(range.Cells[i, 1].Value.ToString());
                            }

                        }
                    }
                    //releaseobject(sheet)
                    ///
                    foreach (string _validItem in s)
                    {
                        string[] item = _validItem.Split(',');
                        string _BARCODE = item[0].ToString();
                        double _soluong = double.Parse(item[1].ToString());
                        Obj_HangHoa _h = _hanghoa.getlistbybarcode_Full(_BARCODE).FirstOrDefault();


                        if (gvchitiet.RowCount > 1)
                        {
                            int mautin = gvchitiet.RowCount;
                            gvchitiet.SelectRow(mautin - 1);


                            if (gvchitiet.GetRowCellValue(gvchitiet.FocusedRowHandle, "TenHH") == null)
                            {
                                gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "Stt", mautin);
                                gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "Barcode", _h.BarCode);
                                gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "DVT", _h.DVT);
                                gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "TenHH", _h.TenHH);
                                gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "SoluongCT", _soluong);

                                gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "Dongia", _h.DonGia);
                                gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "Thanhtien", _h.DonGia * _soluong);
                            }
                            else
                            {
                                gvchitiet.AddNewRow();
                                gvchitiet.SelectRow(mautin);
                                mautin++;
                                gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "Stt", mautin);
                                gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "Barcode", _h.BarCode);
                                gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "DVT", _h.DVT);
                                gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "TenHH", _h.TenHH);
                                gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "SoluongCT", _soluong);

                                gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "Dongia", _h.DonGia);
                                gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "Thanhtien", _h.DonGia * _soluong);
                            }
                        }
                        else
                        {
                            if (gvchitiet.RowCount == 0)
                            {
                                gvchitiet.AddNewRow();
                            }

                            int mautin = gvchitiet.RowCount;
                            gvchitiet.SelectRow(mautin - 1);

                            if (gvchitiet.GetRowCellValue(gvchitiet.FocusedRowHandle, "TenHH") == null)
                            {
                                gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "Stt", mautin);
                                gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "Barcode", _h.BarCode);
                                gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "DVT", _h.DVT);
                                gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "TenHH", _h.TenHH);
                                gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "SoluongCT", _soluong);

                                gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "Dongia", _h.DonGia);
                                gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "Thanhtien", _h.DonGia * _soluong);
                            }
                            else
                            {
                                gvchitiet.AddNewRow();
                                gvchitiet.SelectRow(mautin);
                                mautin++;
                                gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "Stt", mautin);
                                gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "Barcode", _h.BarCode);
                                gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "DVT", _h.DVT);
                                gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "TenHH", _h.TenHH);
                                gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "SoluongCT", _soluong);

                                gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "Dongia", _h.DonGia);
                                gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "Thanhtien", _h.DonGia * _soluong);
                            }

                        }

                    }
                    gvchitiet.AddNewRow();
                    gvchitiet.SelectRow(gvchitiet.RowCount - 1);
                    gvchitiet.DeleteSelectedRows();
                    _isImport = false;

                }
                catch (Exception ex)
                {
                    app.Workbooks.Close();
                    SplashScreenManager.CloseForm(false);
                    MessageBox.Show("Import khong thanh cong" + ex.Message, "thong bao");
                }
                finally
                {
                    wb.Close(true);
                    app.Quit();
                    releaseObject(wb);
                    releaseObject(app);
                }


            }
            // Xuất mã lỗi ra Excel
            if (err.Count != 0)
            {
                Excel.Application app = new Excel.Application();
                Excel.Workbook wb = app.Workbooks.Add(Type.Missing);
                Excel._Worksheet sheet = null;

                try
                {
                    // Lấy sheet hiện tại
                    sheet = wb.ActiveSheet;

                    // Đặt tên sheet
                    sheet.Name = "Lỗi Import";

                    // Gộp 7 cột thành 1 cột
                    sheet.Range[sheet.Cells[1, 1], sheet.Cells[1, 3]].Merge();

                    // Căn lề text
                    sheet.Cells[1, 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                    // Tạo viền
                    sheet.Range[sheet.Cells[1, 1], sheet.Cells[1, 3]].BorderAround(Type.Missing, Excel.XlBorderWeight.xlThick, Excel.XlColorIndex.xlColorIndexAutomatic);

                    // Thiết lập giá trị các ô
                    sheet.Cells[1, 1].Value = "LỖI IMPORT";
                    sheet.Cells[1, 1].Font.Size = 20;
                    sheet.Cells[2, 1].Value = "BARCODE";
                    sheet.Cells[2, 2].Value = "SỐ LƯỢNG";
                    sheet.Cells[2, 3].Value = "LỖI";

                    // Khởi tạo biến đếm dòng
                    //int iDong = 1 + lstHH.Count;

                    // Xuất dữ liệu lỗi ra file và tương tác progressbar
                    for (int i = 1; i <= err.Count; i++)
                    {
                        sheet.Cells[i + 2, 1].Value = err.ElementAt(i - 1)._barcode;
                        sheet.Cells[i + 2, 2].Value = err.ElementAt(i - 1)._soluong;
                        sheet.Cells[i + 2, 3].Value = err.ElementAt(i - 1)._errcode;
                    }

                    // Lưu vào file xuất
                    string t = System.IO.Path.GetDirectoryName(filename) + @"\" + System.IO.Path.GetFileNameWithoutExtension(filename) + "_log.xlsx";
                    if (File.Exists(t))
                    {
                        File.Delete(t);
                    }
                    wb.SaveAs(t);

                }
                catch (Exception ex)
                {
                    SplashScreenManager.CloseForm(false);
                    MessageBox.Show(ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    wb.Close(true);
                    app.Quit();
                    releaseObject(wb);
                    releaseObject(app);
                    SplashScreenManager.CloseForm(false);

                }
                MessageBox.Show("Có lỗi phát sinh trong quá trình import. Xem chi tiết trong file log.", "Lỗi import", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                SplashScreenManager.CloseForm(false);
                MessageBox.Show("import thanh cong", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void gvds_DoubleClick(object sender, EventArgs e)
        {
            if (gvds.RowCount > 0)
            {
                tabCHUNGTU.SelectedTabPage = xtra_ct;
            }
        }

        private void tabCHUNGTU_SelectedPageChanged_1(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (_sua == false && tabCHUNGTU.SelectedTabPage == xtra_ct)
            {
                gvchitiet.OptionsBehavior.Editable = false;
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
            else
            {
                _lstchungTu = _chungtu.getList(1, date_tu.Value, date_den.Value.AddDays(1), cbo_kho.SelectedValue.ToString());
                _bdCHUNGTU.DataSource = _lstchungTu;
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
            else
            {
                _lstchungTu = _chungtu.getList(1, date_tu.Value, date_den.Value.AddDays(1), cbo_kho.SelectedValue.ToString());
                _bdCHUNGTU.DataSource = _lstchungTu;
            }
        }
        bool cal(int _Width, GridView _View)
        {
            _View.IndicatorWidth = _View.IndicatorWidth < _Width ? _Width : _View.IndicatorWidth;
            return true;
        }


        private void gvds_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
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
                e.Info.DisplayText = string.Format("[{0}]", (e.RowHandle + 1));
                SizeF _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                Int32 _Width = Convert.ToInt32(_Size.Width) + 20;
                BeginInvoke(new MethodInvoker(delegate { cal(_Width, gvds); }));
            }
        }

        private void gvchitiet_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
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

        private void gvchitiet_KeyDown(object sender, KeyEventArgs e)
        {
            if (gvchitiet.OptionsBehavior.Editable)
            {
                _isImport = false;

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


        private void btnSua_Click(object sender, EventArgs e)
        {
            if (_right == 1)
            {
                MessageBox.Show("Không có quyền thao tác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                tb_ChungTu current = (tb_ChungTu)_bdCHUNGTU.Current;
                if (current.TrangThai == 1)
                {
                    _them = false;
                    _sua = true;
                    showHideControl(false);
                    _edControl(true);
                    tabCHUNGTU.SelectedTabPage = xtra_ct;
                    tabCHUNGTU.TabPages[0].PageEnabled = false;
                    gvchitiet.OptionsBehavior.Editable = true;
                    contextMenuStrip1.Enabled = true;
                    //cbo_donvinhap.Enabled = false;

                    if (gvchitiet.RowCount == 0)
                    {
                        List<V_Chungtu_CT> _lstChiTiet = new List<V_Chungtu_CT>();
                        _bdCHUNGTU.DataSource = _lstChiTiet;
                        gcchitiet.DataSource = _bdCHUNGTU;
                        gvchitiet.AddNewRow();
                        gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "Stt", 1);
                    }
                }
                else
                {
                    MessageBox.Show("Không được phép chỉnh sửa chứng từ đã hoàn tất.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
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

        private void btn_luuds_Click(object sender, EventArgs e)
        {
            luuthongtin();
            _them = false;
            _sua = false;
            //gvchitiet.OptionsBehavior.Editable = false;
            contextMenuStrip1.Enabled = false;
            tabCHUNGTU.TabPages[0].PageEnabled = true;
            showHideControl(true);
            _edControl(false);

        }

        private void gvds_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
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

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Kiểm tra quyền người dùng
            if (_right == 1)
            {
                MessageBox.Show("Không có quyền thao tác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                // Xác nhận trước khi xóa
                if (MessageBox.Show("Bạn có chắc muốn hủy phiếu nhập này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    // Lấy phiếu nhập hiện tại
                    tb_ChungTu current = (tb_ChungTu)_bdCHUNGTU.Current;
                    int index = _bdCHUNGTU.Position;

                    // Xóa phiếu nhập dựa trên khóa và loại bỏ khỏi danh sách
                    _chungtu.redelete(current.Khoa);

                    // Cập nhật giá trị cột "Delete_By" trên gridview tại hàng hiện tại
                    gvds.SetRowCellValue(index, "Delete_By", "");

                    // Đảm bảo nút xóa được hiển thị sau khi xóa
                    btn_xoa.Visible = true;
                }
            }
            return;
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
                    MessageBox.Show("Lỗi khi tải báo cáo: " + ex.Message );
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu","Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
    
}