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
    public partial class FrmNhomHH : DevExpress.XtraEditors.XtraForm
    {
        public FrmNhomHH()
        {
            InitializeComponent();
        }      public FrmNhomHH(tb_SYS_User user, int right)
        {
            InitializeComponent();
            this._user = user;
            this._right = right;
        }
        tb_SYS_User _user;
        int _right;
        NHOMHH _nhomhh;
        bool _them;
        string _ID;

        private void FrmNhomHH_Load(object sender, EventArgs e)
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
            _nhomhh = new NHOMHH();
            loadData();
      
            Enable(false);
            
        }
        void loadData()
        {
            GC_Ds.DataSource = _nhomhh.getALL();
            //GV_Ds.OptionsBehavior.Editable = false;


        }
        void Enable(bool t)
        {
            txt_id.Enabled = t; 
            txt_ten.Enabled = t;
        }
        void _reset()
        {
            txt_ten.Text = "";
            txt_id.Text = "";
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
            txt_id.Enabled=false;
            Enable(true);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            // Check if the textbox is empty or not
            if (string.IsNullOrWhiteSpace(txt_id.Text))
            {
                MessageBox.Show("Bạn chưa chọn nhóm hàng hóa cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Confirm deletion from the user
            if (MessageBox.Show("Bạn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    // Attempt to remove the item
                    _nhomhh.remove(txt_id.Text);
                    // Reload data to reflect changes
                    loadData();
                }
                catch (Exception ex)
                {
                    // Handle any errors that occur during the remove operation
                    MessageBox.Show("Không thể xóa nhóm hàng hóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
     
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (_them)
                {
                    if (string.IsNullOrWhiteSpace(txt_id.Text) || string.IsNullOrWhiteSpace(txt_ten.Text))
                    {
                        MessageBox.Show("ID and Name must be provided.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    tb_NhomHH nhomHH = new tb_NhomHH
                    {
                        IdNhom = txt_id.Text,
                        TenNhom = txt_ten.Text
                    };
                    _nhomhh.add(nhomHH);
                }
                else
                {
                    tb_NhomHH nhomHH = _nhomhh.getItem(_ID);
                    if (nhomHH == null)
                    {
                        MessageBox.Show("Item not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    nhomHH.IdNhom = txt_id.Text;
                    nhomHH.TenNhom = txt_ten.Text;
                    _nhomhh.update(nhomHH);
                }

                _them = false;
                loadData();
                Enable(false);
                showHideControl(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                _ID = GV_Ds.GetFocusedRowCellValue("IdNhom").ToString();
                txt_id.Text = GV_Ds.GetFocusedRowCellValue("IdNhom").ToString();
                txt_ten.Text = GV_Ds.GetFocusedRowCellValue("TenNhom").ToString();
               
            }
        }

    }
}