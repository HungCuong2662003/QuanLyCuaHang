using BusinessLayer;
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
    public partial class UserControlCty : UserControl
    {
        public UserControlCty()
        {
            InitializeComponent();
        }

        CONGTY _congty;
        private void UserControlCty_Load(object sender, EventArgs e)
        {
            _congty = new CONGTY();
            loadCty();
        }
        void loadCty()
        {
            cbb_congty_chinhanh.DataSource = _congty.getALL();
            cbb_congty_chinhanh.DisplayMember = "TenCty";
            cbb_congty_chinhanh.ValueMember = "MaCty";
            cbb_congty_chinhanh.SelectedValue = myFunctions._macty;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
