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

namespace QL_Quan_Ban_Hang
{
    public partial class FrmQLBan : DevExpress.XtraEditors.XtraForm
    {
        QLban _qlban;
        bool _them;
        int _id;
        public FrmQLBan()
        {
            InitializeComponent();
        }

        private void FrmQLBan_Load(object sender, EventArgs e)
        {
            _qlban = new QLban();
            loadData();
            showHideControl(true);
            Enable(false);
            
        }
        void loadData()
        {
            GC_Ds.DataSource = _qlban.getALL();
            //GV_Ds.OptionsBehavior.Editable = false;
        }
        
        void Enable(bool t)
        {
            
            cb_dis.Enabled = t;
        }
        void _reset()
        {
            txt_tenban.Text ="";
            check_dis.Checked = false;
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
                _qlban.FalseQlban(_id);
            }
            loadData();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra giá trị tên bàn, nếu trống thì hiển thị thông báo và dừng thực hiện
                if (string.IsNullOrWhiteSpace(txt_tenban.Text))
                {
                    MessageBox.Show("Tên bàn không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Kết thúc hàm nếu tên bàn trống
                }
                if (_them)
                {
                    tb_Qlban Qlban = new tb_Qlban();
                    Qlban.tenban = txt_tenban.Text;
                    Qlban.trangthai = check_dis.Checked;
                    _qlban.add(Qlban);
                }
                else
                {
                    tb_Qlban Qlban = _qlban.getItem(_id);
                    Qlban.tenban = txt_tenban.Text;
                    Qlban.trangthai = check_dis.Checked;
                    _qlban.update(Qlban);
                }
                _them = false;
                loadData();
                Enable(false);
                showHideControl(true);
                _reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi load lưu : {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
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
                _id = int.Parse( GV_Ds.GetFocusedRowCellValue("idban").ToString());
                txt_tenban.Text = GV_Ds.GetFocusedRowCellValue("tenban").ToString();
                check_dis.Checked = bool.Parse(GV_Ds.GetFocusedRowCellValue("trangthai").ToString());
            }
        }

        private void GV_Ds_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            try
            {
                // Kiểm tra nếu cột là "Disable"
                if (e.Column.Name == "Disable")
                {
                    // Kiểm tra giá trị của CellValue có null không trước khi chuyển đổi
                    if (e.CellValue != null && bool.TryParse(e.CellValue.ToString(), out bool isDisabled) && isDisabled)
                    {
                        // Nếu giá trị là true, hiển thị hình ảnh
                        Image img = Properties.Resources.xoa;
                        e.Graphics.DrawImage(img, e.Bounds.X, e.Bounds.Y);
                        e.Handled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi trong quá trình vẽ ô: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}