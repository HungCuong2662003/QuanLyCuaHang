using BusinessLayer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Quan_Kho_Hang.myControl
{
    public partial class UserControlDvi : UserControl
    {
        public UserControlDvi()
        {
            InitializeComponent();
        }
        CONGTY _congty;
        DONVI _donvi;


        private void Cbb_congty_chinhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDvi();
        }

        private void UserControlDvi_Load(object sender, EventArgs e)
        {
            _congty = new CONGTY();
            _donvi = new DONVI();
            loadCty();
            loadDvi();
            cbb_congty_chinhanh.Enabled = false;
            cbb_congty_chinhanh.SelectedIndexChanged += Cbb_congty_chinhanh_SelectedIndexChanged;
            if (myFunctions._madvi == "~")
            {
                // Bật ComboBox để cho phép người dùng chọn đơn vị
                cbo_donvi.Enabled = true;
            }
            else
            {
                // Đặt giá trị mặc định và khóa ComboBox
                cbo_donvi.SelectedValue = myFunctions._madvi;
                cbo_donvi.Enabled = false;
            }

        }
        void loadCty()
        {
            cbb_congty_chinhanh.DataSource = _congty.getALL();
            cbb_congty_chinhanh.DisplayMember = "TenCty";
            cbb_congty_chinhanh.ValueMember = "MaCty";
            cbb_congty_chinhanh.SelectedValue = myFunctions._macty;
        }
        void loadDvi()
        {
            cbo_donvi.DataSource = _donvi.getItemListCty(cbb_congty_chinhanh.SelectedValue.ToString());
            cbo_donvi.DisplayMember = "TenDvi";
            cbo_donvi.ValueMember = "MaDvi";
            cbo_donvi.SelectedValue = myFunctions._madvi;
        }

    }
}
