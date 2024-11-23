using BusinessLayer;
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
    public partial class FrmSetParam : DevExpress.XtraEditors.XtraForm
    {
        public FrmSetParam()
        {
            InitializeComponent();
        }
        CONGTY _congty;
        DONVI _donvi;
        private void FrmSetParam_Load(object sender, EventArgs e)
        {
            _congty = new CONGTY();
            _donvi = new DONVI();
            loadcongty();
            cbo_congty.SelectedIndexChanged += cbo_congty_SelectedIndexChanged;

          

        }
        private void btn_luu_Click(object sender, EventArgs e)
        {
            string macty = cbo_congty.SelectedValue.ToString();
            string madvi = (cbo_dvi.Text.Trim() == "") ? "~" : cbo_dvi.SelectedValue.ToString();
            SYS_PARAM sys = new SYS_PARAM(macty,madvi);
            sys.savefile();
            MessageBox.Show("Xác lập đơn vị sử dụng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void cbo_congty_SelectedIndexChanged(object sender, EventArgs e)
        {
            loaddonvi();
        }
        void loadcongty()
        {
            cbo_congty.DataSource=_congty.getALL();
            cbo_congty.DisplayMember = "TenCty";
            cbo_congty.ValueMember = "MaCty";

        }
        void loaddonvi()
        {
        
            // Kiểm tra nếu SelectedValue khác null
            if (cbo_congty.SelectedValue != null)
            {
                var itemList = _donvi.getItemListCty(cbo_congty.SelectedValue.ToString());
               

                if (itemList.Count == 0)
                {
                    MessageBox.Show("Không có đơn vị nào cho công ty này.");
                }

                cbo_dvi.DataSource = itemList;
                cbo_dvi.DisplayMember = "TenDvi";
                cbo_dvi.ValueMember = "MaDvi";
                cbo_dvi.SelectedIndex = -1; // Đặt lại giá trị mặc định để không có mục nào được chọn lúc đầu
            }
        }

        private void cbo_dvi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}