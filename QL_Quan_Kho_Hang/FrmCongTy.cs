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
        }
        CONGTY _congty;
        bool _them;
        string _macty;
        private void FrmCongTy_Load(object sender, EventArgs e)
        {
            _congty = new CONGTY();
            loadData();
            showHideControl(true);
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
            cb_dis.Enabled = t;
        }
        void _reset()
        {
            txt_ten.Text = "";
            txt_DT.Text = "";
            txt_email.Text = "";
            txt_diachi.Text = "";
            txt_Fax.Text = "";
            cb_dis.Checked = false;
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
                cty.Disable=cb_dis.Checked;
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
                cty.Disable = cb_dis.Checked;
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
            txt_Macty.Enabled=false;
            Enable(true);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {

            if(MessageBox.Show("Bạn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _congty.FalseCty(_macty);
            }
            loadData();
        }

        private void GV_Ds_Click(object sender, EventArgs e)
        {
            if (GV_Ds.RowCount > 0)
            {
                _macty = GV_Ds.GetFocusedRowCellValue("MaCty").ToString();
                txt_Macty.Text = GV_Ds.GetFocusedRowCellValue("MaCty").ToString();
                txt_ten.Text = GV_Ds.GetFocusedRowCellValue("TenCty").ToString();
                txt_DT.Text = GV_Ds.GetFocusedRowCellValue("DienThoai").ToString();
                txt_email.Text = GV_Ds.GetFocusedRowCellValue("Email").ToString();
                txt_diachi.Text = GV_Ds.GetFocusedRowCellValue("DiaChi").ToString();
                txt_Fax.Text = GV_Ds.GetFocusedRowCellValue("Fax").ToString();
                cb_dis.Checked = bool.Parse(GV_Ds.GetFocusedRowCellValue("Disable").ToString());
            }
        }

        private void GV_Ds_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.Name == "Disable" && bool.Parse(e.CellValue.ToString()) == true)
            {
                Image img = Properties.Resources.tich;
                e.Graphics.DrawImage(img, e.Bounds.X, e.Bounds.Y);
                e.Handled = true;
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}