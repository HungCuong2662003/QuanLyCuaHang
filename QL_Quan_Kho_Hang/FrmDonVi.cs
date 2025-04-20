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

namespace QL_Quan_Kho_Hang
{
    public partial class FrmDonVi : DevExpress.XtraEditors.XtraForm
    {
     
        public FrmDonVi()
        {
            InitializeComponent();
        }   public FrmDonVi(tb_SYS_User user, int right)
        {
            InitializeComponent(); this._user = user;
            this._right = right;
        }
        tb_SYS_User _user;
        int _right;
        DONVI _dvi;
        CONGTY _congty;
        bool _them;
        string _madv;
        private void FrmDonVi_Load(object sender, EventArgs e)
        {
            if (_right == 1)
            {
                btn_them.Enabled = false;
                btn_sua.Enabled = false;
                btn_xoa.Enabled = false;
                //btn_thoat.Enabled = false;
                btn_luu.Enabled = false;
                btn_boqua.Enabled = false;

            }
            else if (_right == 2)
            {
                showHideControl(true);
            }
            _dvi = new DONVI();
            _congty = new CONGTY();
            loadCTY();
            loadData();
   
            Enable(false);
            txt_Madv.Enabled = false;
            cbo_congty.SelectedIndexChanged += Cbo_congty_SelectedIndexChanged;

        }

        private void Cbo_congty_SelectedIndexChanged(object sender, EventArgs e)
        {
           loadBYCty();
        }

  
        void loadBYCty()
        {
            GC_Ds.DataSource = _dvi.getItemListCty(cbo_congty.SelectedValue.ToString());
            GV_Ds.OptionsBehavior.Editable = false;

        }
        void loadCTY()
        {
            cbo_congty.DataSource = _congty.getALL();
            cbo_congty.DisplayMember = "TenCty";
            cbo_congty.ValueMember = "MaCty";
        }
        void loadData()
        {
            GC_Ds.DataSource = _dvi.getItemList();
            //GV_Ds.OptionsBehavior.Editable = false;


        }
        void Enable(bool t)
        {
            txt_tendv.Enabled = t;
            txt_DT.Enabled = t;
            txt_email.Enabled = t;
            txt_diachi.Enabled = t;
            txt_Fax.Enabled = t;
         
            txt_Kyhieu.Enabled = t;
      
            ck_kho.Enabled = t;
        }
        void _reset()
        {
            txt_tendv.Text = "";
            txt_DT.Text = "";
            txt_email.Text = "";
            txt_diachi.Text = "";
            txt_Fax.Text = "";
            cbo_congty.Text = "";
            txt_Kyhieu.Text = "";
        
            ck_kho.Checked = false;
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
            txt_Madv.Enabled = true;
            _them = true;
            Enable(true);
            _reset();
        }

        private void btn_sua_Click_1(object sender, EventArgs e)
        {
            showHideControl(false);
            _them = false;
             txt_Madv.Enabled= false;
         
            Enable(true);
        }

        private void btn_xoa_Click_1(object sender, EventArgs e)
        {
            // Check if the textbox is empty or not
            if (string.IsNullOrWhiteSpace(txt_Madv.Text))
            {
                MessageBox.Show("Bạn chưa chọn đơn vị cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Confirm deletion from the user
            if (MessageBox.Show("Bạn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    _dvi.remove(txt_Madv.Text);
                
                    loadData();
                }
                catch (Exception ex)
                {
                    // Handle any errors that occur during the remove operation
                    MessageBox.Show("Không thể xóa đơn vị: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
         
        }

        private void btn_luu_Click_1(object sender, EventArgs e)
        {
            if (cbo_congty.SelectedValue == null)
            {
                // Hiển thị thông báo yêu cầu chọn công ty
                MessageBox.Show("Vui lòng chọn công ty trước khi lưu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng thực thi nếu không chọn công ty
            }
            if (_them)
            {
                tb_DonVi dvi=new tb_DonVi();
                dvi.MaDvi = txt_Madv.Text;
                dvi.TenDvi = txt_tendv.Text;
                dvi.DienThoai = txt_DT.Text;
                dvi.Email = txt_email.Text;
                dvi.DiaChi = txt_diachi.Text;
                dvi.Fax=txt_Fax.Text;
                dvi.MaCty=cbo_congty.SelectedValue.ToString();
                dvi.KyHieu=txt_Kyhieu.Text;
         
                dvi.Kho = ck_kho.Checked;
                _dvi.add(dvi);
            }
            else
            {
                tb_DonVi dvi =_dvi.getItem(_madv);
                dvi.MaDvi = txt_Madv.Text;
                dvi.TenDvi = txt_tendv.Text;
                dvi.DienThoai = txt_DT.Text;
                dvi.Email = txt_email.Text;
                dvi.DiaChi = txt_diachi.Text;
                dvi.Fax = txt_Fax.Text;
                dvi.MaCty = cbo_congty.SelectedValue.ToString();
                dvi.KyHieu = txt_Kyhieu.Text;
     
                dvi.Kho = ck_kho.Checked;
              
                _dvi.update(dvi);
            }
            _them = false;
            loadData();
            Enable(false);
            showHideControl(true);
            txt_Madv.Enabled = false;
        }

        private void btn_boqua_Click_1(object sender, EventArgs e)
        {
            _them = false;
            showHideControl(true);
            txt_Madv.Enabled = false;
            Enable(false);
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void GV_Ds_Click(object sender, EventArgs e)
        {
            if (GV_Ds.RowCount > 0 && GV_Ds.FocusedRowHandle >= 0)
            {
                try
                {
                    _madv = GV_Ds.GetFocusedRowCellValue("MaDvi")?.ToString() ?? string.Empty;
                    txt_Madv.Text = _madv;

                    txt_tendv.Text = GV_Ds.GetFocusedRowCellValue("TenDvi")?.ToString() ?? string.Empty;
                    txt_DT.Text = GV_Ds.GetFocusedRowCellValue("DienThoai")?.ToString() ?? string.Empty;
                    txt_email.Text = GV_Ds.GetFocusedRowCellValue("Email")?.ToString() ?? string.Empty;
                    txt_diachi.Text = GV_Ds.GetFocusedRowCellValue("DiaChi")?.ToString() ?? string.Empty;
                    txt_Fax.Text = GV_Ds.GetFocusedRowCellValue("Fax")?.ToString() ?? string.Empty;
                    cbo_congty.Text = GV_Ds.GetFocusedRowCellValue("MaCty")?.ToString() ?? string.Empty;
                    txt_Kyhieu.Text = GV_Ds.GetFocusedRowCellValue("KyHieu")?.ToString() ?? string.Empty;

                    // Safely parse boolean values
                    bool disable = false;
                    var disableValue = GV_Ds.GetFocusedRowCellValue("Disable")?.ToString();
                    bool.TryParse(disableValue, out disable);
                

                    bool kho = false;
                    var khoValue = GV_Ds.GetFocusedRowCellValue("Kho")?.ToString();
                    bool.TryParse(khoValue, out kho);
                    ck_kho.Checked = kho;
                }
                catch (Exception ex)
                {
                    // Handle the exception (e.g., log it)
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void GV_Ds_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            // Kiểm tra nếu cột là "Delete_By" và giá trị của ô là 1
            if (e.Column.FieldName == "Disable" && e.CellValue != null && e.CellValue.ToString() == "true")
            {
                Image img = Properties.Resources.tich; // Hình ảnh xóa

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
    
    }
}