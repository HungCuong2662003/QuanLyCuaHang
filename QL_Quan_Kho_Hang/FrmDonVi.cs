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
        }
        DONVI _dvi;
        CONGTY _congty;
        bool _them;
        string _madv;
        private void FrmDonVi_Load(object sender, EventArgs e)
        {
            _dvi = new DONVI();
            _congty = new CONGTY();
            loadCTY();
            loadData();
            showHideControl(true);
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
            ck_dis.Enabled = t;
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
            ck_dis.Checked = false;
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
            txt_Madv.Enabled = false;
         
            Enable(true);
        }

        private void btn_xoa_Click_1(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _dvi.FalseCty(_madv);
            }
            loadData();
        }

        private void btn_luu_Click_1(object sender, EventArgs e)
        {
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
                dvi.Disable = ck_dis.Checked;
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
                dvi.Disable = ck_dis.Checked;
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
            if (GV_Ds.RowCount > 0)
            {
                _madv = GV_Ds.GetFocusedRowCellValue("MaDvi").ToString();
                txt_Madv.Text = GV_Ds.GetFocusedRowCellValue("MaDvi").ToString();
                txt_tendv.Text = GV_Ds.GetFocusedRowCellValue("TenDvi").ToString();
                txt_DT.Text = GV_Ds.GetFocusedRowCellValue("DienThoai").ToString();
                txt_email.Text = GV_Ds.GetFocusedRowCellValue("Email").ToString();
                txt_diachi.Text = GV_Ds.GetFocusedRowCellValue("DiaChi").ToString();
                txt_Fax.Text = GV_Ds.GetFocusedRowCellValue("Fax").ToString();
                cbo_congty.Text = GV_Ds.GetFocusedRowCellValue("MaCty").ToString();
                txt_Kyhieu.Text = GV_Ds.GetFocusedRowCellValue("KyHieu").ToString();             
                ck_dis.Checked = bool.Parse(GV_Ds.GetFocusedRowCellValue("Disable").ToString());
                ck_kho.Checked = bool.Parse(GV_Ds.GetFocusedRowCellValue("Kho").ToString());
            }
        }

        
    }
}