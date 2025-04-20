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
    public partial class Frmxuatxu : DevExpress.XtraEditors.XtraForm
    {
        public Frmxuatxu()
        {
            InitializeComponent();
        }public Frmxuatxu(tb_SYS_User user, int right)
        {
            InitializeComponent();
            this._user = user;
            this._right = right;
        }
        tb_SYS_User _user;
        int _right;
        XUATXU _xuatxu;
        bool _them;
        int _ID;


        private void Frmxuatxu_Load(object sender, EventArgs e)
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
            _xuatxu = new XUATXU();
            loadData();
         
            Enable(false);
            txt_id.Enabled = false;
        }
        void loadData()
        {
            GC_Ds.DataSource = _xuatxu.getALL();
            //GV_Ds.OptionsBehavior.Editable = false;


        }
        void Enable(bool t)
        {
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
            txt_id.Enabled = false;
            Enable(true);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            // Check if the textbox is empty or not
            if (string.IsNullOrWhiteSpace(txt_id.Text))
            {
                MessageBox.Show("Bạn chưa chọn nơi xuất xứ  cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Confirm deletion from the user
            if (MessageBox.Show("Bạn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    _xuatxu.remove(int.Parse(txt_id.Text));
                    loadData();
                }
                catch (Exception ex)
                {
                    // Handle any errors that occur during the remove operation
                    MessageBox.Show("Không thể xóa nơi xuất xứ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        

        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            
            if (_them)
            {
                tb_XuatXu xuatxu = new tb_XuatXu();
                xuatxu.Ten = txt_ten.Text;
             
                _xuatxu.add(xuatxu);
            }
            else
            {
                tb_XuatXu xuatxu= _xuatxu.getItem(_ID);
                xuatxu.ID=int.Parse( txt_id.Text);
                xuatxu.Ten = txt_ten.Text;
          
                _xuatxu.update(xuatxu);
            }
            loadData();
            _them = false;
            Enable(false);
            showHideControl(true); 
        }

        private void btn_boqua_Click(object sender, EventArgs e)
        {

            _them = false;
            showHideControl(true);
            txt_id.Enabled = false;
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
                // Initialize _ID with a default value or declare it appropriately if not done earlier
                int _ID = 0;

                // Safely attempt to retrieve and parse the ID value
                object idValue = GV_Ds.GetFocusedRowCellValue("ID");
                if (idValue != null && int.TryParse(idValue.ToString(), out _ID))
                {
                    txt_id.Text = _ID.ToString();
                }
                else
                {
                    // Handle the case where ID is null or not an integer
                    MessageBox.Show("ID value is invalid or missing.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_id.Clear(); // Clear or reset the text box as appropriate
                }

                // Safely assign the Ten value, checking for null
                object nameValue = GV_Ds.GetFocusedRowCellValue("Ten");
                txt_ten.Text = nameValue?.ToString() ?? "";
            }
            else
            {
                MessageBox.Show("No rows are selected or the grid is empty.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_id.Clear();
                txt_ten.Clear();
            }

        }
    }
}