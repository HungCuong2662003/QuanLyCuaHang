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
    public partial class FrmNhaCC : DevExpress.XtraEditors.XtraForm
    {
        public FrmNhaCC()
        {
            InitializeComponent();
        }
        NHACC _nhacc;
        bool _them;
        string mancc;

        private void FrmNhaCC_Load(object sender, EventArgs e)
        {
            _nhacc = new NHACC();
            loadData();
            showHideControl(true);
            Enable(false);
            txt_mancc.Enabled = false;
        }
        void loadData()
        {
            GC_Ds.DataSource = _nhacc.getALL();
            //GV_Ds.OptionsBehavior.Editable = false;


        }
        void Enable(bool t)
        {
            txt_tenncc.Enabled = t;
            txt_dt.Enabled = t;
            txt_mail.Enabled = t;
            txt_fax.Enabled = t;
            txt_diachi.Enabled = t;
            cb_dis.Enabled = t;
            txt_tenncc.Enabled = t;
        }
        void _reset()
        {
            txt_mancc.Text = "";
            txt_tenncc.Text = "";
            txt_tenncc.Text = "";
            txt_dt.Text = "";
            txt_mail.Text = "";
            txt_fax.Text = "";
            txt_diachi.Text = "";
            cb_dis.Text = "";
            txt_tenncc.Text = "";

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
            txt_mancc.Enabled = true;
            Enable(true);
            _reset();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {

            showHideControl(false);
            _them = false;
            txt_mancc.Enabled = false;
            Enable(true);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _nhacc.False(mancc);
            }
            loadData();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (txt_mancc.Text == "")
            {
                MessageBox.Show("Mã không được để trống", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error) ;
                return;

            }
            if (_them)
            {
                tb_NhaCC Nhacc = new tb_NhaCC();
                Nhacc.MaNCC=txt_mancc.Text;
                Nhacc.TenNCC = txt_tenncc.Text;
                Nhacc.DienThoai = txt_dt.Text;
                Nhacc.Email = txt_mail.Text;
                Nhacc.Fax = txt_fax.Text;
                Nhacc.DiaChi = txt_dt.Text;
                Nhacc.Disable = cb_dis.Checked;
                _nhacc.add(Nhacc);
            }
            else
            {
                tb_NhaCC Nhacc = _nhacc.getItem(mancc);
      
                Nhacc.TenNCC = txt_tenncc.Text;
                Nhacc.DienThoai = txt_dt.Text;
                Nhacc.Email = txt_mail.Text;
                Nhacc.Fax = txt_fax.Text;
                Nhacc.DiaChi = txt_dt.Text;
                Nhacc.Disable = cb_dis.Checked;
                _nhacc.update(Nhacc);
            }
            _them = false;
            loadData();
            Enable(false);
            showHideControl(true);
            txt_mancc.Enabled = false;
        }

        private void btn_boqua_Click(object sender, EventArgs e)
        {
            _them = false;
            showHideControl(true);
            txt_mancc.Enabled = false;
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
                mancc = GV_Ds.GetFocusedRowCellValue("MaNCC").ToString();
                txt_mancc.Text = GV_Ds.GetFocusedRowCellValue("MaNCC").ToString();
                txt_tenncc.Text = GV_Ds.GetFocusedRowCellValue("TenNCC").ToString();
                txt_dt.Text = GV_Ds.GetFocusedRowCellValue("DienThoai").ToString();
                txt_mail.Text = GV_Ds.GetFocusedRowCellValue("Email").ToString();
                txt_fax.Text = GV_Ds.GetFocusedRowCellValue("Fax").ToString();
                txt_diachi.Text = GV_Ds.GetFocusedRowCellValue("DiaChi").ToString();
                cb_dis.Checked = bool.Parse(GV_Ds.GetFocusedRowCellValue("Disable").ToString());

            }
        }

       
    }
}