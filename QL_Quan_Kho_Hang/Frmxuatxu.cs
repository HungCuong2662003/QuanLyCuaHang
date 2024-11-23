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
        }
        XUATXU _xuatxu;
        bool _them;
        int _ID;


        private void Frmxuatxu_Load(object sender, EventArgs e)
        {
            _xuatxu = new XUATXU();
            loadData();
            showHideControl(true);
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
            if (MessageBox.Show("Bạn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _xuatxu.False(int.Parse(txt_id.Text));
            }
            loadData();

        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            
            if (_them)
            {
                tb_XuatXu xuatxu = new tb_XuatXu();
                xuatxu.Ten = txt_ten.Text;
                xuatxu.Disable = cb_dis.Checked;
                _xuatxu.add(xuatxu);
            }
            else
            {
                tb_XuatXu xuatxu= _xuatxu.getItem(_ID);
                xuatxu.ID=int.Parse( txt_id.Text);
                xuatxu.Ten = txt_ten.Text;
                xuatxu.Disable = cb_dis.Checked;
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
                _ID = (int)GV_Ds.GetFocusedRowCellValue("ID");
                txt_id.Text = GV_Ds.GetFocusedRowCellValue("ID").ToString();
                txt_ten.Text = GV_Ds.GetFocusedRowCellValue("Ten").ToString();
                cb_dis.Checked = bool.Parse(GV_Ds.GetFocusedRowCellValue("Disable").ToString());

            }
        }
    }
}