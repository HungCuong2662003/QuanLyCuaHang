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
    public partial class UserControlTuNgay : UserControl
    {
        public UserControlTuNgay()
        {
            InitializeComponent();
        }   
        public UserControlTuNgay(bool tonkho)
        {
            InitializeComponent();
            this._tonkho = tonkho;  

        }
        bool _tonkho;
        private void UserControlTuNgay_Load(object sender, EventArgs e)
        {
            date_tu.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            date_den.Value= DateTime.Now;
            if (_tonkho && _tonkho!=null)
            {
                date_tu.Enabled = false;
            }
            else
            {
                date_tu.Enabled= true;
            }
        }
        private void date_tu_ValueChanged(object sender, EventArgs e)
        {
            if (_tonkho && _tonkho != null)
            {
                date_tu.Value = new DateTime(date_tu.Value.Year, date_tu.Value.Month, 1);
            }
            else
            {
                if (date_tu.Value > date_den.Value)
                {
                    MessageBox.Show("Ngày không hợp lệ. Vui lòng chọn lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    date_tu.Select(); // Đưa con trỏ trở lại ngày bắt đầu
                    return; // Kết thúc sớm vì ngày không hợp lệ
                }
            }
           

        }

        private void date_tu_Leave(object sender, EventArgs e)
        {
            if (_tonkho && _tonkho != null)
            {
                date_tu.Value = new DateTime(date_tu.Value.Year, date_tu.Value.Month, 1);
            }
            else
            {
                if (date_tu.Value > date_den.Value)
                {
                    MessageBox.Show("Ngày không hợp lệ. Vui lòng chọn lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    date_tu.Select(); // Đưa con trỏ trở lại ngày bắt đầu
                    return; // Kết thúc sớm vì ngày không hợp lệ
                }
            }
        }

        private void date_den_ValueChanged(object sender, EventArgs e)
        {
            if (date_tu.Value > date_den.Value)
            {
                MessageBox.Show("Ngày không hợp lệ. Vui lòng chọn lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                date_tu.Select(); // Đưa con trỏ trở lại ngày bắt đầu
                return; // Kết thúc sớm vì ngày không hợp lệ
            }
        }

        private void date_den_Leave(object sender, EventArgs e)
        {
            if (date_tu.Value > date_den.Value)
            {
                MessageBox.Show("Ngày không hợp lệ. Vui lòng chọn lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                date_tu.Select(); // Đưa con trỏ trở lại ngày bắt đầu
                return; // Kết thúc sớm vì ngày không hợp lệ
            }
        }


    }
}
