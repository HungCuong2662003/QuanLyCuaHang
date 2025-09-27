using BusinessLayer;
using DataLayer;
using DevExpress.Utils.Drawing;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using DevExpress.XtraNavBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using USERMANAGERMENT;
using QL_Quan_Ban_Hang;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;
using DevExpress.XtraEditors.TextEditController.Win32;
using DevExpress.XtraGrid.Views.Grid;

namespace QL_Quan_Kho_Hang
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public MainForm(tb_SYS_User user)
        {
            InitializeComponent();
            this._user = user;
        }
        tb_SYS_User _user;
        Sys_FUNC _func;
        SYS_GROUP _sys_group;
        SYS_RIGHT _SYS_Right;
        DONVI _donvi;
        HANGHOA _hanghoa;
        QLban _QLban;
        SYS_SEQUENCE _sequence;
        CHUNGTU _chungtu;
        CHUNGTU_CT _chungtuct;
        BindingSource _bdCHUNGTUCT;
        BindingSource _bdCHUNGTU;
        Guid pkhoa;
      
        List<obj_CHUNGTU_CT> lstChungtuCT;
        tb_SYS_SEQUENCE _seq;
        GalleryItem _galleryItem= null;
        double THANHTIEN;
        string err = "";
        bool _isImport;
        string idBan;
        bool _them;
        List<tb_ChungTu> _lstchungTu;
        Guid _khoa;
        bool _sua = false;
        private void MainForm_Load(object sender, EventArgs e)
        {

            _func = new Sys_FUNC();
            _hanghoa = new HANGHOA();
            _donvi = new DONVI();
            _QLban = new QLban();
            _sequence = new SYS_SEQUENCE();
            _chungtu = new CHUNGTU();
            _chungtuct= new CHUNGTU_CT();
            _bdCHUNGTUCT = new BindingSource();
            _bdCHUNGTU = new BindingSource();
            _sys_group =new SYS_GROUP();
            _SYS_Right = new SYS_RIGHT();
            lstChungtuCT= new List<obj_CHUNGTU_CT> ();
           
            leftmenu();
            showTable();
            _bdCHUNGTU.PositionChanged += _bdCHUNGTU_PositionChanged;

        }

        private void _bdCHUNGTU_PositionChanged(object sender, EventArgs e)
        {
           xuatthongtin();
        }

        void leftmenu()
        {
            try
            {
                var i = 0;
                var _lsParent = _func.getParent();

                if (_lsParent == null || !_lsParent.Any())
                {
                    MessageBox.Show("Không có nhóm cha nào để hiển thị trong menu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                foreach (var l in _lsParent)
                {
                    if (l == null)
                    {
                        MessageBox.Show("Đã gặp lỗi: một đối tượng nhóm cha là null.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        continue;
                    }

                    NavBarGroup navGr = new NavBarGroup(l.Description)
                    {
                        Tag = l.FUNC_Code,
                        Name = l.FUNC_Code,
                        ImageOptions = { LargeImageIndex = i },
                        Appearance = { Font = new Font("Arial", 120, FontStyle.Bold) } // Tăng kích thước chữ cho NavBarGroup
                    };
                    i++;

                    navMain.Groups.Add(navGr);

                    var _lsChild = _func.getChill(l.FUNC_Code);

                    if (_lsChild == null || !_lsChild.Any())
                    {
                        MessageBox.Show($"Nhóm {l.Description} không có mục con nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        continue;
                    }

                    foreach (var _ch in _lsChild)
                    {
                        if (_ch == null)
                        {
                            MessageBox.Show("Đã gặp lỗi: một đối tượng mục con là null.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            continue;
                        }

                        NavBarItem navBarItem = new NavBarItem(_ch.Description)
                        {
                            Tag = _ch.FUNC_Code,
                            Name = _ch.FUNC_Code,
                            ImageOptions = { SmallImageIndex = 0 },
                            Appearance = { Font = new Font("Arial", 10) } // Tăng kích thước chữ cho NavBarItem
                        };

                        navGr.ItemLinks.Add(navBarItem);
                    }

                    if (navMain.Groups.Contains(navGr))
                    {
                        navMain.Groups[navGr.Name].Expanded = true;
                    }
                    else
                    {
                        MessageBox.Show($"Nhóm {navGr.Name} không được tìm thấy trong navMain.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi tạo menu bên trái: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void showTable()
            
        {
            try
            {
                GControl.Gallery.ItemImageLayout = ImageLayoutMode.ZoomInside;
                GControl.Gallery.ImageSize = new Size(100, 100);
              
                GControl.Gallery.ShowItemText = true;
                GControl.Gallery.ShowGroupCaption = true;
                //foreach(var _ch in _lsTang)
                //{
                var galleryItem = new GalleryItemGroup();
                //galleryItem.Caption = _ch.tentang;
                //galleryItem.CaptionAlignment=GalleryItemGroupCaptionAlignment.Stretch;

                var lstable = _QLban.getALL();
                foreach (var t in lstable)
                {
                    var gc_item = new GalleryItem();
                    gc_item.Caption = t.tenban;
                    gc_item.Value = t.idban;

                    var danhsach = _chungtu.getListbyban(t.idban);
                    if (danhsach.Count == 0)
                    {
                        //ban xanh
                        gc_item.ImageOptions.Image = imageList1.Images[0];

                    }
                    else
                    {
                        //bando
                        gc_item.ImageOptions.Image = imageList1.Images[1];
                    }

                    galleryItem.Items.Add(gc_item);
                }
                GControl.Gallery.Groups.Add(galleryItem);

                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi show table: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           


        }

        
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void navMain_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            try
            {
                string func_code = e.Link.Item.Tag.ToString();
                var _group = _sys_group.GetGroup(_user.Iduser);
                var _right = _SYS_Right.GetRight(_user.Iduser, func_code);
                //Kiểm tra nếu nhóm không tồn tại
                if (_group != null)
                {
                    var _grRight = _SYS_Right.GetRight(_group.Group, func_code); // Chỉ gọi khi nhóm không null

                    // So sánh quyền của người dùng
                    if (_right.UserRight < _grRight.UserRight)
                    {
                        _right.UserRight = _grRight.UserRight; // Cập nhật quyền nếu cần
                    }
                }
                if (_right.UserRight == 0)
                {
                    MessageBox.Show("khong co quyen", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
          
                    return;
                }
                else
                {
                    switch (func_code)
                    {
                        case "QUANTRINGUOIDUNG":
                            {

                                try
                                {
                                   MainFormUser frm = new MainFormUser();
                                    this.Hide();
                                    frm.ShowDialog();
                                    this.Show();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show($"Không thể mở form QUANTRINGUOIDUNG: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                break;
                            }

                        case "CONGTY":
                            {
                                FrmCongTy frm = new FrmCongTy(_user, _right.UserRight.Value);
                                this.Hide();
                                frm.ShowDialog();
                                this.Show();
                                break;
                            }
                        case "DONVI":
                            {
                                FrmDonVi frm = new FrmDonVi(_user, _right.UserRight.Value);
                                this.Hide();
                                frm.ShowDialog();
                                this.Show();
                                break;
                            }
                        case "XUATXU":
                            {
                                Frmxuatxu frm = new Frmxuatxu(_user, _right.UserRight.Value);
                                this.Hide();
                                frm.ShowDialog();
                                this.Show();
                                break;
                            }
                        case "NHOMHH":
                            {
                                FrmNhomHH frm = new FrmNhomHH(_user, _right.UserRight.Value);
                                this.Hide();
                                frm.ShowDialog();
                                this.Show();
                                break;
                            }
                        case "NHACC":
                            {
                                FrmNhaCC frm = new FrmNhaCC(_user, _right.UserRight.Value);
                                this.Hide();
                                frm.ShowDialog();
                                this.Show();
                                break;
                            }
                        case "HANGHOA":
                            {
                                FrmHangHoa frm = new FrmHangHoa(_user, _right.UserRight.Value);
                                this.Hide();
                                frm.ShowDialog();
                                this.Show();
                                
                                break;
                            }
                        case "NHAPMUA":
                            {
                                FrmNhapmua frm = new FrmNhapmua(_user, _right.UserRight.Value);
                                this.Hide();
                                frm.ShowDialog();
                                this.Show();
                                break;
                            }
                        case "XUATNB":
                            {
                                FrmXuatNB frm = new FrmXuatNB(_user, _right.UserRight.Value);
                                this.Hide();
                                frm.ShowDialog();
                                this.Show();
                                break;
                            }
                        case "NHAPNOIBO":
                            {
                                FrmNhapNB frm = new FrmNhapNB(_user, _right.UserRight.Value);
                                this.Hide();
                                frm.ShowDialog();
                                this.Show();
                                break;
                            }

                        case "BANHANGQUANLY":
                            {
                                FrmBanHang_QL frm = new FrmBanHang_QL(_user, _right.UserRight.Value);
                                this.Hide();
                                frm.ShowDialog();
                                this.Show();
                                break;
                            }
                        case "TONKHOCTY":
                            {
                                FrmTonKho frm = new FrmTonKho(_user, _right.UserRight.Value);
                                this.Hide();
                                frm.ShowDialog();
                                this.Show();
                                break;
                            }
                        case "DOANHTHUNHH":
                            {
                                FrmBaoCaoDTNHH frm = new FrmBaoCaoDTNHH(_user, _right.UserRight.Value);
                                this.Hide();
                                frm.ShowDialog();
                                this.Show();
                                break;
                            } 
                        case "DOANHTHUMH":
                            {
                                FrmBaoCaoDTMH frm = new FrmBaoCaoDTMH(_user, _right.UserRight.Value);
                                this.Hide();
                                frm.ShowDialog();
                                this.Show();
                                break;
                            }
                        case "BANSI":
                            {
                                FrmBanSi frm = new FrmBanSi(_user, _right.UserRight.Value);
                                this.Hide();
                                frm.ShowDialog();
                                this.Show();
                                break;
                            }
                        case "BACKUP":
                            {
                                Frmbackup frm = new Frmbackup(_user, _right.UserRight.Value);
                                this.Hide();
                                frm.ShowDialog();
                                this.Show();
                                break;
                            }
                        case "RETORE":
                            {
                                FrmRetore frm = new FrmRetore(_user, _right.UserRight.Value);
                                this.Hide();
                                frm.ShowDialog();
                                this.Show();
                                break;
                            }
                        case "QLDONHANG":
                            {
                                FrmQLDonHang frm = new FrmQLDonHang(_user, _right.UserRight.Value);
                                this.Hide();
                                frm.ShowDialog();
                                this.Show();
                                break;
                            }  
                        case "BAN":
                            {
                             
                                FrmQLBan frm = new FrmQLBan(_user, _right.UserRight.Value);
                                this.Hide();
                                frm.ShowDialog();
                                this.Show();
                                break;
                            }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi load menu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void popupMenu1_Popup(object sender, EventArgs e)
        {
            try
            {
                Point point = GControl.PointToClient(Control.MousePosition);
                RibbonHitInfo hit = GControl.CalcHitInfo(point);
                if (hit.InGalleryItem || hit.HitTest == RibbonHitTest.GalleryImage)
                {
                    _galleryItem = hit.GalleryItem;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi : {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        //btn_datban
        private void btn_datban_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (idBan == null)
                {
                    MessageBox.Show("Hãy chọn bàn","Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    _isImport = true;
                    FrmDanhMuc _popDm = new FrmDanhMuc(gvchitiet, ".", 2); // Truyền chuỗi trống để lấy tất cả dữ liệu
                    _popDm.ShowDialog();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi đặt bàn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        //btn_thanhtoan
        //private void btn_thanhtoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    try
        //    {
        //        // Gọi trực tiếp hàm btn_In_Click với sender là null và EventArgs.Empty
        //        btn_In_Click(null, EventArgs.Empty);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Đã xảy ra lỗi lưu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
          
        //}
 

        void refreshGalleryItems()
        {
            try
            {
                // Xóa toàn bộ các nhóm và mục hiện tại trong GalleryControl
                GControl.Gallery.Groups.Clear();

                // Tạo một nhóm mới trong GalleryControl
                var galleryItemGroup = new GalleryItemGroup();

                // Lấy danh sách bàn mới nhất từ cơ sở dữ liệu
                var lstable = _QLban.getALL(); // Giả sử `getALL` là phương thức lấy toàn bộ danh sách bàn

                // Thêm từng bàn vào GalleryControl
                foreach (var t in lstable)
                {
                    var galleryItem = new GalleryItem();
                    galleryItem.Caption = t.tenban;
                    galleryItem.Value = t.idban;

                    // Kiểm tra nếu bàn trống hoặc có khách
                    var danhsach = _chungtu.getListbyban(t.idban);
                    if (danhsach.Count == 0)
                    {
                        // Bàn trống - dùng hình ảnh xanh
                        galleryItem.ImageOptions.Image = imageList1.Images[0];
                    }
                    else
                    {
                        // Bàn có khách - dùng hình ảnh đỏ
                        galleryItem.ImageOptions.Image = imageList1.Images[1];
                    }

                    galleryItemGroup.Items.Add(galleryItem);
                }

                // Thêm nhóm mới vào GalleryControl và làm mới
                GControl.Gallery.Groups.Add(galleryItemGroup);
                GControl.Refresh(); // Làm mới GalleryControl để hiển thị các bàn mới
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi load table: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void refesGvds()
        {

            gcds.RefreshDataSource();
            gvds.RefreshData();
            _bdCHUNGTU.DataSource = _chungtu.getListbyban(int.Parse(idBan));
            gcds.DataSource = _bdCHUNGTU;
        }
        //thay doi ban
        private void GControl_Gallery_ItemClick(object sender, GalleryItemClickEventArgs e)
        {
            try
            {
                idBan = e.Item.Value.ToString();

                // Gọi phương thức load dữ liệu chi tiết cho bàn vừa click
                refreshGalleryItems();
                refesGvds();
                _bdCHUNGTU.Position = 0; // Đặt lại vị trí, hoặc bạn có thể điều chỉnh vị trí dựa theo điều kiện cụ thể
                xuatthongtin();
                tabCHUNGTU.SelectedTabPage = xtra_ds;


                tabCHUNGTU.SelectedTabPage = xtra_ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi chọn bàn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            


        }

        void chungtu_info(tb_ChungTu chungTu,bool trangthai)
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
                _seq = _sequence.getitem("BQA@" + DateTime.Today.Year.ToString() + "@" + dvi.KyHieu);
                if (_seq == null)
                {
                    _seq = new tb_SYS_SEQUENCE();
                    _seq.Name = "BQA@" + DateTime.Now.Year.ToString() + "@" + dvi.KyHieu;
                    _seq.value = 1;
                    _sequence.add(_seq);
                }
            
                if (_them)
                {
                    chungTu.LoaiCT = 5;
                    chungTu.Khoa = Guid.NewGuid();
                    chungTu.Ngay = DateTime.Now;
                    chungTu.SoChungTu = _seq.value.Value.ToString("000000") + @"/" + DateTime.Today.Year.ToString().Substring(2, 2) + @"/BQA/" + dvi.KyHieu;
                    chungTu.Create_By = _user.Iduser;
                    chungTu.Create_Date = DateTime.Now;
                }
                chungTu.MaCty = MyFunctions._macty;
                chungTu.MaDVI = madvi;
                chungTu.MaDVI2 = "NCC1";
                chungTu.ChuyenKhoan = chk_CK.Checked;
                chungTu.idban = int.Parse(idBan);
                chungTu.checkthanhtoan = trangthai;

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
                        var giabanVal = gvchitiet.GetRowCellValue(i, "GiaBan");
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
        void xuatthongtin()
        {
            try
            {
                // Lấy chứng từ hiện tại từ BindingSource
                tb_ChungTu current = (tb_ChungTu)_bdCHUNGTU.Current;

                if (current != null)
                {
                    pkhoa = current.Khoa;
                 
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


        

        private void luuthongtin(bool trangthai)
        {
            
            
            try
            {
                err = "";
                tb_ChungTu ctu  = new tb_ChungTu();

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
                   
                    chungtu_info(ctu, trangthai);
                    // Thêm chứng từ
                    var resultCtu = _chungtu.add(ctu);
                    pkhoa = resultCtu.Khoa;
                    _sequence.update(_seq);

                    // Thêm thông tin chi tiết
                    chuntuCT_info(resultCtu);

                }
                else
                {
                    
                    // Xử lý logic cập nhật
                    //tb_Chungtu_CT check = _chungtuct.getItembyban(int.Parse(idBan));
                    //StringBuilder sb = new StringBuilder();


                    //string temp=check.Khoa.ToString();

                    //ctu = _chungtu.getItem(Guid.Parse(temp));
                    //// Lặp qua từng thuộc tính của đối tượng `check`
                    //foreach (var property in ctu.GetType().GetProperties())
                    //{
                    //    sb.AppendLine($"{property.Name}: {property.GetValue(ctu)}");
                    //}

                    //pkhoa= Guid.Parse(temp);

                    // Xử lý logic cập nhật
                    ctu = _chungtu.getItem(pkhoa);
                
                    if (ctu == null)
                    {
                        MessageBox.Show("Không tìm thấy chứng từ để cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    chungtu_info(ctu, trangthai);

                    // Cập nhật chứng từ
                    var resultCtu = _chungtu.update(ctu);

                    // Cập nhật thông tin chi tiết
                    chuntuCT_info(resultCtu);
                }

                // Hiển thị thông tin sau khi lưu thành công
                xuatthongtin();

            }
            catch (Exception ex)
            {
                // Hiển thị lỗi nếu có vấn đề xảy ra
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_chietkhau_Click(object sender, EventArgs e)
        {
            try
            {
                FrmChietKhau frm = new FrmChietKhau(gvchitiet);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi lưu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvchitiet.RowCount == 0)
                {

                    MessageBox.Show("Không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                luuthongtin(false);
                lstChungtuCT = new List<obj_CHUNGTU_CT>();
                gcchitiet.DataSource = lstChungtuCT;
                tabCHUNGTU.SelectedTabPage = xtra_ds;
                refreshGalleryItems();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi lưu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

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
                        FrmDanhMuc _popDm = new FrmDanhMuc(gvchitiet, gvchitiet.GetRowCellValue(gvchitiet.FocusedRowHandle, "Barcode").ToString(),2);
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
                                    int currentRow = gvchitiet.FocusedRowHandle;


                                    for (int i = 0; i < gvchitiet.RowCount; i++)
                                    {
                                        if (i != currentRow) // Bỏ qua dòng đang nhập
                                        {
                                            var barcodeValue = gvchitiet.GetRowCellValue(i, "Barcode")?.ToString().Trim();
                                            if (!string.IsNullOrEmpty(barcodeValue))
                                            {
                                                s.Add(barcodeValue);
                                            }
                                        }
                                    }

                                    string barcodeNhap = e.Value?.ToString().Trim() ?? "";
                                    if (s.Any(x => x.Equals(barcodeNhap, StringComparison.OrdinalIgnoreCase)))
                                    {
                                        MessageBox.Show("Mã này đã có trong danh sách!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }

                                    else
                                    {
                                        gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "TenHH", hh.TenHH);
                                        gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "DVT", hh.DVT);
                                        gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "SoluongCT", 1);
                         
                                        gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "GiaBan", hh.GiaBan);
                                        gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "Thanhtien", hh.GiaBan);
                                        gvchitiet.UpdateTotalSummary();
                                    }
                                }
                                else
                                {
                                    gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "TenHH", hh.TenHH);
                                    gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "DVT", hh.DVT);
                                    gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "SoluongCT", 1);
                        
                                    gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "GiaBan", hh.GiaBan);
                                    gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "Thanhtien", hh.GiaBan);
                                    gvchitiet.UpdateTotalSummary();
                                }
                            }
                            else
                            {
                                MessageBox.Show("ma nay khong ton tai ", "loi ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("ma tai san khong chinh xac. kiem tra lai ", " loi ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
               
                    }

                }

                //thay doi so luong

                // Xử lý thay đổi số lượng
                if (e.Column.FieldName == "SoluongCT")
                {
                    try
                    {
                        // Kiểm tra nếu TenHH khác null
                        if (gvchitiet.GetRowCellValue(gvchitiet.FocusedRowHandle, "TenHH") != null)
                        {
                            // Kiểm tra và chuyển đổi số lượng thành double
                            if (double.TryParse(e.Value?.ToString(), out double soluong) && soluong != 0)
                            {
                                // Lấy giá trị chiết khấu, kiểm tra null và chuyển đổi thành double
                                double chietkhau = 0;
                                if (!double.TryParse(gvchitiet.GetRowCellValue(gvchitiet.FocusedRowHandle, "Chietkhau")?.ToString(), out chietkhau))
                                {
                            
                                    chietkhau = 0; // Nếu không thể chuyển đổi, đặt mặc định là 0
                                }

                                // Lấy giá trị giá bán, kiểm tra null và chuyển đổi thành double
                                double giaBan = 0;
                                if (double.TryParse(gvchitiet.GetRowCellValue(gvchitiet.FocusedRowHandle, "GiaBan")?.ToString(), out giaBan))
                                {
                                    // Tính thành tiền và cập nhật vào ô tương ứng
                                    gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "Thanhtien", giaBan * soluong * (1 - chietkhau / 100));
                                }
                                else
                                {
                                  
                                    gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "Thanhtien", 0);
                                }

                                gvchitiet.UpdateTotalSummary();
                            }
                            else
                            {
                                MessageBox.Show("Số lượng không thể bằng 0 hoặc không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Sản phẩm chưa được chọn hoặc giá trị TenHH là null.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }



                if (e.Column.FieldName == "GiaBan")
                {
                    try
                    {
                        // Lấy mã vạch của hàng hóa từ dòng hiện tại
                        string _barcode = gvchitiet.GetRowCellValue(gvchitiet.FocusedRowHandle, "Barcode")?.ToString();

                        // Kiểm tra và lấy số lượng
                        if (!double.TryParse(gvchitiet.GetRowCellValue(gvchitiet.FocusedRowHandle, "SoluongCT")?.ToString(), out double _soluong) || _soluong == 0)
                        {
                            MessageBox.Show("Số lượng không hợp lệ ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Kiểm tra và lấy giá bán
                        if (!double.TryParse(gvchitiet.GetRowCellValue(gvchitiet.FocusedRowHandle, "GiaBan")?.ToString(), out double _GiaBan))
                        {
                            MessageBox.Show("Giá bán không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Kiểm tra và lấy chiết khấu
                        if (!double.TryParse(gvchitiet.GetRowCellValue(gvchitiet.FocusedRowHandle, "Chietkhau")?.ToString(), out double chietkhau))
                        {
                           
                            chietkhau = 0; // Gán giá trị mặc định nếu chiết khấu không hợp lệ
                        }

                        // Tính toán thành tiền
                        gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "Thanhtien", _GiaBan * _soluong * (1 - chietkhau / 100));

                        // Cập nhật tổng cộng
                        gvchitiet.UpdateTotalSummary();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (e.Column.FieldName == "Chietkhau")
                {
                    try
                    {
                        // Lấy giá trị số lượng
                        if (!double.TryParse(gvchitiet.GetRowCellValue(gvchitiet.FocusedRowHandle, "SoluongCT")?.ToString(), out double _soluong) || _soluong <= 0)
                        {
                            MessageBox.Show("Số lượng không hợp lệ hoặc bằng 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Lấy giá trị giá bán
                        if (!double.TryParse(gvchitiet.GetRowCellValue(gvchitiet.FocusedRowHandle, "GiaBan")?.ToString(), out double _dongia) || _dongia < 0)
                        {
                            MessageBox.Show("Giá bán không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Lấy giá trị chiết khấu
                        if (!double.TryParse(gvchitiet.GetRowCellValue(gvchitiet.FocusedRowHandle, "Chietkhau")?.ToString(), out double _chietkhau) || _chietkhau < 0 || _chietkhau > 100)
                        {
                            MessageBox.Show("Chiết khấu không hợp lệ. Vui lòng nhập giá trị từ 0 đến 100.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Tính thành tiền
                        double _thanhtien = _dongia * _soluong * (1 - _chietkhau / 100);
                        gvchitiet.SetRowCellValue(gvchitiet.FocusedRowHandle, "Thanhtien", _thanhtien);

                        // Cập nhật tổng cộng
                        gvchitiet.UpdateTotalSummary();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


                gvchitiet.RefreshData();

            }
        }


        private void gvchitiet_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (gvchitiet.OptionsBehavior.Editable)
                {
                    _isImport = false;

                    if (e.KeyData == Keys.Down)
                    {
                        // Kiểm tra nếu FocusedRowHandle hợp lệ và chuyển đổi thành int một cách an toàn
                        int focusedRowHandle;
                        if (int.TryParse(gvchitiet.FocusedRowHandle.ToString(), out focusedRowHandle))
                        {
                            if (focusedRowHandle == (gvchitiet.RowCount - 1))
                            {
                                // Kiểm tra giá trị null cho cột "TenHH"
                                var tenHHValue = gvchitiet.GetRowCellValue(focusedRowHandle, "TenHH");
                                if (tenHHValue != null)
                                {
                                    gvchitiet.AddNewRow();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không thể xác định hàng hiện tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    if (e.KeyData == Keys.Up)
                    {
                        // Kiểm tra nếu FocusedRowHandle hợp lệ và chuyển đổi thành int một cách an toàn
                        int focusedRowHandle;
                        if (int.TryParse(gvchitiet.FocusedRowHandle.ToString(), out focusedRowHandle))
                        {
                            if (focusedRowHandle == (gvchitiet.RowCount - 1))
                            {
                                var focusedValue = gvchitiet.FocusedValue;
                                var tenHHValue = gvchitiet.GetRowCellValue(focusedRowHandle, "TenHH");

                                // Kiểm tra điều kiện để xóa hàng cuối nếu cần thiết
                                if ((focusedValue == null && gvchitiet.RowCount > 1) ||
                                    (tenHHValue == null && gvchitiet.RowCount > 1))
                                {
                                    gvchitiet.DeleteSelectedRows();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không thể xác định hàng hiện tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    e.Handled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_In_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvchitiet.RowCount == 0)
                {

                    MessageBox.Show("Không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (pkhoa == Guid.Empty)
                {
                    _them = true;
                }
                else
                {
                    _them = false;
                }
                luuthongtin(true);
                lstChungtuCT = new List<obj_CHUNGTU_CT>();
                gcchitiet.DataSource = lstChungtuCT;

           
                XuatReport("Ban_le", "Phiếu bán quầy");
                refreshGalleryItems();
                refesGvds();
                tabCHUNGTU.SelectedTabPage = xtra_ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi in: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
         
                    doc.PrintOptions.PaperSize = PaperSize.DefaultPaperSize; // Hoặc PaperSize.PaperA4
                    doc.PrintOptions.ApplyPageMargins(new PageMargins(10, 10, 10, 10)); // Điều chỉnh lề hợp lý
                    doc.Database.Tables[0].ApplyLogOnInfo(Thongtin);

                    var thanhtien = _chungtu.getItem(pkhoa);

                    TextObject txtObject = (TextObject)doc.ReportDefinition.ReportObjects["txt_bangchu"];
                    txtObject.Text = docchu.NumberToText(thanhtien.TongTien ?? 0);



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

        private void gcchitiet_Click(object sender, EventArgs e)
        {

        }

        private void btn_thoat_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void btn_hethong_Click(object sender, EventArgs e)
        {
            MainForm frm = new MainForm();
            frm.ShowDialog();
        }

        private void btn_baocao_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btn_tonkho_Click(object sender, EventArgs e)
        {
            FrmTonKho frm = new FrmTonKho();
            frm.ShowDialog();
        }

        private void btn_baocao_Click_1(object sender, EventArgs e)
        {
            FrmBaoCao frm = new FrmBaoCao(_user);
            frm.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void chk_CK_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void gvds_DoubleClick(object sender, EventArgs e)
        {
            if (gvds.RowCount > 0)
            {
                tabCHUNGTU.SelectedTabPage = xtra_ct;
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            _sua = false;
            pkhoa =Guid.Empty;
            var danhsach = _chungtu.getListbyban(int.Parse(idBan));
            if (danhsach.Count < 4)
            {
                _them = true;
            }
            else
            {
                _them = false;
                MessageBox.Show("Chỉ cho phép thêm tối đa 4 hóa đơn");
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
                e.Info.DisplayText = string.Format("[{0}]", (e.RowHandle + 1));
                SizeF _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                Int32 _Width = Convert.ToInt32(_Size.Width) + 20;
                BeginInvoke(new MethodInvoker(delegate { cal(_Width, gvds); }));
            }
        }
        bool cal(int _Width, GridView _View)
        {
            _View.IndicatorWidth = _View.IndicatorWidth < _Width ? _Width : _View.IndicatorWidth;
            return true;
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

        private void btnsua_Click(object sender, EventArgs e)
        {
                tb_ChungTu current = (tb_ChungTu)_bdCHUNGTU.Current;
        
                    _them = false;
                    _sua = true;
   
                    tabCHUNGTU.SelectedTabPage = xtra_ct;
                    //tabCHUNGTU.TabPages[0].PageEnabled = false;
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

        private void BTN_XOA_Click(object sender, EventArgs e)
        {
            // Xác nhận trước khi xóa
            if (MessageBox.Show("Bạn có chắc muốn hủy phiếu nhập này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                // Lấy phiếu nhập hiện tại
                tb_ChungTu current = (tb_ChungTu)_bdCHUNGTU.Current;
                int index = _bdCHUNGTU.Position;

                // Xóa phiếu nhập dựa trên khóa và loại bỏ khỏi danh sách
                _chungtu.remove(current.Khoa);
                refesGvds();
                xuatthongtin();
               
            }
            return;
        }

        private void toolStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void navMain_Click(object sender, EventArgs e)
        {

        }

        //private void btn_thembill_Click(object sender, EventArgs e)
        //{
        //    _bdCHUNGTUCT.DataSource = _chungtuct.getlistbykhoafull(_khoa);
        //    gcchitiet.DataSource = _bdCHUNGTUCT;

        //    // Thêm một dòng mới
        //    gvchitiet.AddNewRow();

        //    string madvi = "";

        //    if (MyFunctions._madvi == null)
        //    {
        //        madvi = "dvi1";
        //    }
        //    else
        //    {
        //        madvi = MyFunctions._madvi;
        //    }

        //    tb_DonVi dvi = _donvi.getItem(madvi);
        //    _seq = _sequence.getitem("BQA@" + DateTime.Today.Year.ToString() + "@" + dvi.KyHieu);
        //    _sequence.update(_seq);


        //}
    }
}
