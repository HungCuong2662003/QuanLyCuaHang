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
    public partial class FrmCongTy : DevExpress.XtraEditors.XtraForm
    {
        public FrmCongTy()
        {
            InitializeComponent();
        }   public FrmCongTy(tb_SYS_User user, int right)
        {
            InitializeComponent(); this._user = user;
            this._right = right;
        }
        tb_SYS_User _user;
        int _right;
        CONGTY _congty;
        bool _them;
        string _macty;
        private void FrmCongTy_Load(object sender, EventArgs e)
        {

            if (_right == 1)
            {
                btn_them.Enabled = false;
                btn_sua.Enabled = false;
                btn_xoa.Enabled = false;
             
                btn_luu.Enabled = false;
                btn_boqua.Enabled = false;

            }
            else if (_right == 2)
            {
                showHideControl(true);
            }
            _congty = new CONGTY();
            loadData();
           
            Enable(false);
            txt_Macty.Enabled = false;
        }
        void loadData()
        {
            GC_Ds.DataSource = _congty.getALL();
            //GV_Ds.OptionsBehavior.Editable = false;
        }
        void Enable(bool t)
        {
    
            txt_ten.Enabled = t;
            txt_DT.Enabled = t;
            txt_email.Enabled = t;
            txt_diachi.Enabled = t;
            txt_Fax.Enabled = t;
       
        }
        void _reset()
        {
            txt_ten.Text = "";
            txt_DT.Text = "";
            txt_email.Text = "";
            txt_diachi.Text = "";
            txt_Fax.Text = "";
          
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
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            showHideControl(false);
            txt_Macty.Enabled = true;
            _them = true;
            Enable(true);
            _reset();
        }
        private void btn_luu_Click(object sender, EventArgs e)
        {
            
            if (_them)
            {
                tb_CongTy cty=new tb_CongTy();
                cty.MaCty=txt_Macty.Text;
                cty.TenCty=txt_ten.Text;
                cty.DienThoai=txt_DT.Text;  
                cty.Email=txt_email.Text;
                cty.DiaChi=txt_diachi.Text;
                cty.Fax=txt_Fax.Text;
               
                _congty.add(cty);
            }
            else
            {
                tb_CongTy cty = _congty.getItem(_macty);
                cty.TenCty = txt_ten.Text;
                cty.DienThoai = txt_DT.Text;
                cty.Email = txt_email.Text;
                cty.DiaChi = txt_diachi.Text;
                cty.Fax = txt_Fax.Text;
             
                _congty.update(cty);
            }
            _them = false;
            loadData();
            Enable(false);
            showHideControl(true);
        }

        private void btn_boqua_Click(object sender, EventArgs e)
        {
            _them=false;
            showHideControl(true);
            txt_Macty.Enabled=false;
            Enable(false);
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            showHideControl(false);
            _them=false;
            txt_Macty.Enabled = false;
            Enable(true);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            // Check if the textbox is empty or not
            if (string.IsNullOrWhiteSpace(txt_Macty.Text))
            {
                MessageBox.Show("Bạn chưa chọn công ty cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Confirm deletion from the user
            if (MessageBox.Show("Bạn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    _congty.remove(txt_Macty.Text);
                    loadData();
                }
                catch (Exception ex)
                {
                    // Handle any errors that occur during the remove operation
                    MessageBox.Show("Không thể xóa công ty: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
      
        }

        private void GV_Ds_Click(object sender, EventArgs e)
        {
            if (GV_Ds.RowCount > 0 && GV_Ds.FocusedRowHandle >= 0)
            {
                try
                {
                    _macty = GV_Ds.GetFocusedRowCellValue("MaCty")?.ToString() ?? string.Empty;
                    txt_Macty.Text = _macty;

                    txt_ten.Text = GV_Ds.GetFocusedRowCellValue("TenCty")?.ToString() ?? string.Empty;
                    txt_DT.Text = GV_Ds.GetFocusedRowCellValue("DienThoai")?.ToString() ?? string.Empty;
                    txt_email.Text = GV_Ds.GetFocusedRowCellValue("Email")?.ToString() ?? string.Empty;
                    txt_diachi.Text = GV_Ds.GetFocusedRowCellValue("DiaChi")?.ToString() ?? string.Empty;
                    txt_Fax.Text = GV_Ds.GetFocusedRowCellValue("Fax")?.ToString() ?? string.Empty;

                    // Safely parse the "Disable" field
                    bool disable = false;
                    var disableValue = GV_Ds.GetFocusedRowCellValue("Disable")?.ToString();
                    bool.TryParse(disableValue, out disable);
                 
                }
                catch (Exception ex)
                {
                    // Handle any potential exceptions
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void GV_Ds_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
        
            // Kiểm tra nếu cột là "Delete_By" và giá trị của ô là 1
            if (e.Column.FieldName == "Disable" && e.CellValue != null && e.CellValue.ToString() == "True")
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

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}