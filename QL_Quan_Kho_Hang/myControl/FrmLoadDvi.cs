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

namespace QL_Quan_Kho_Hang.myControl
{
    public partial class FrmLoadDvi : DevExpress.XtraEditors.XtraForm
    {
        public FrmLoadDvi()
        {
            InitializeComponent();
        }     
        public FrmLoadDvi(TextBox textBox)
        {
            InitializeComponent();
            this._textBox = textBox;
        }
        TextBox _textBox;
        CONGTY _congty;
        DONVI _donvi;
        private void FrmLoadDvi_Load(object sender, EventArgs e)
        {
            _congty = new CONGTY();
            _donvi = new DONVI();
            loadCty();
            cbb_congty_chinhanh.SelectedValueChanged += Cbb_congty_chinhanh_SelectedValueChanged;

        }

        private void Cbb_congty_chinhanh_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadDonVi();    
        }
        private void LoadDonVi()
        {
            try
            {
                // Lấy danh sách đơn vị từ đối tượng _donvi với tham số là giá trị đã chọn từ combobox cboCongTy
                GC_dvi.DataSource = _donvi.getItemListCty(cbb_congty_chinhanh.SelectedValue?.ToString());

                // Thiết lập chế độ không cho phép chỉnh sửa lưới gvDanhSach
                GV_dvi.OptionsBehavior.Editable = false;
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có trong quá trình tải dữ liệu
                MessageBox.Show($"Đã xảy ra lỗi khi tải danh sách đơn vị: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void loadCty()
        {
            cbb_congty_chinhanh.DataSource = _congty.getALL();
            cbb_congty_chinhanh.DisplayMember = "TenCty";
            cbb_congty_chinhanh.ValueMember = "MaCty";
            cbb_congty_chinhanh.SelectedValue = myFunctions._macty;
        }
    }
}