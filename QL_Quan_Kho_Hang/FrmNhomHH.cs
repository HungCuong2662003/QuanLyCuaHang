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
        }
        NHOMHH _nhomhh;
        bool _them;
        string _ID;

        private void FrmNhomHH_Load(object sender, EventArgs e)
        {
            _nhomhh = new NHOMHH();
            loadData();
            showHideControl(true);
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
        
            Enable(true);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _nhomhh.False(txt_id.Text);
            }
            loadData();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (_them)
            {
                tb_NhomHH nhomHH = new tb_NhomHH();
                nhomHH.IdNhom = txt_id.Text;
                nhomHH.TenNhom=txt_ten.Text;
                _nhomhh.add(nhomHH);
            }
            else
            {
                tb_NhomHH nhomHH = _nhomhh.getItem(_ID);
                nhomHH.IdNhom = txt_id.Text;
                nhomHH.TenNhom = txt_ten.Text;
                _nhomhh.update(nhomHH);
            }
            _them = false;
            loadData();
            Enable(false);
            showHideControl(true);
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