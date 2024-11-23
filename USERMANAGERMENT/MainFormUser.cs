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
using USERMANAGERMENT.myCombonents;

namespace USERMANAGERMENT
{
    public partial class MainFormUser : DevExpress.XtraEditors.XtraForm
    {
        public MainFormUser()
        {
            InitializeComponent();
        }
        MyTreeViewCombo _treeView;
        CONGTY _congty;
        DONVI _donvi;
        SYS_USER _sysuser;
        //bool _isRoot;
        string _macty;
        string _madvi;

        private void btn_nhomnguoidung_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_treeView.Text == "")
            {
                MessageBox.Show("Vui lòng chọn đơn vị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            FrmGroup frm = new FrmGroup();
            frm._them = true;
            frm._macty = _macty;
            frm._madvi = _madvi;
            frm.ShowDialog();
        }

        private void btn_nguoidung_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_treeView.Text == "")
            {
                MessageBox.Show("Vui lòng chọn đơn vị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            FrmUser frm = new FrmUser();
            frm._them = true;
            frm._macty = _macty;
            frm._madvi = _madvi;
            frm._IdUser = int.Parse(gv_user.GetFocusedRowCellValue("Iduser").ToString());
            frm.ShowDialog();
        }

        private void btn_capnhatthongtin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gv_user.RowCount > 0 && gv_user.GetFocusedRowCellValue("Isgroup").Equals(true))
            {
                FrmGroup frm = new FrmGroup();
                frm._them = false;
                frm._IdUser = int.Parse(gv_user.GetFocusedRowCellValue("Iduser").ToString());
                frm.ShowDialog();
            }
            else
            {
                FrmUser frm = new FrmUser();
                frm._them = false;
                frm._IdUser = int.Parse(gv_user.GetFocusedRowCellValue("Iduser").ToString());
                frm.ShowDialog();
            }

        }

        private void btn_phanquyennguoidung_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmPhanQuyen frm = new FrmPhanQuyen();
            frm._macty = _macty;
            frm._madvi = _madvi;
            frm._id = int.Parse(gv_user.GetFocusedRowCellValue("Iduser").ToString());
        
            frm.ShowDialog();
           
        }

        private void btn_phanquyenbaocao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmPhanQuyenBC frm = new FrmPhanQuyenBC();
            frm._macty = _macty;
            frm._madvi = _madvi;
            frm._id = int.Parse(gv_user.GetFocusedRowCellValue("Iduser").ToString());
            frm.ShowDialog();

        }

        private void btn_thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _congty = new CONGTY();
            _donvi = new DONVI();
            _sysuser = new SYS_USER();
            loadTreeView();
            loadUser(_macty, _madvi);
        }
        void loadTreeView()
        {
            _treeView = new MyTreeViewCombo(pn_nhom.Width, 300);
            _treeView.Font = new Font("Tahoma", 10, FontStyle.Bold);
            var lstCty = _congty.getALL();
            foreach (var item in lstCty)
            {
                TreeNode parentNode = new TreeNode();
                parentNode.Text = item.MaCty + " - " + item.TenCty;
                parentNode.Tag = item.MaCty;
                parentNode.Name = item.MaCty;
                _treeView.TreeView.Nodes.Add(parentNode);
                var donvi = _donvi.getItemListCty(item.MaCty);
                foreach (var dvi in donvi)
                {
                    TreeNode childNode = new TreeNode();
                    childNode.Text = dvi.MaDvi + " - " + dvi.TenDvi;
                    childNode.Tag = dvi.MaCty + "." + dvi.MaDvi;
                    childNode.Name = dvi.MaCty + "." + dvi.MaDvi;
                    _treeView.TreeView.Nodes[parentNode.Name].Nodes.Add(childNode);
                }
            }
            _treeView.TreeView.ExpandAll();
            pn_nhom.Controls.Add(_treeView);
            _treeView.Width = pn_nhom.Width;
            _treeView.Height = pn_nhom.Height;
            _treeView.TreeView.AfterSelect += TreeView_AfterSelect;

        }
        public void loadUser(string macty, string madvi)
        {
            _sysuser = new SYS_USER();

            if (string.IsNullOrEmpty(_macty) || _madvi == "~")
            {
                // Nếu madvi rỗng hoặc là "~", tải toàn bộ người dùng
                gc_user.DataSource = _sysuser.GetAll();
                gv_user.OptionsBehavior.Editable = false;
            }
            else
            {
                // Nếu có giá trị madvi, tải dữ liệu theo đơn vị và công ty
                gc_user.DataSource = _sysuser.GetAllbyDVI(macty, madvi);
                gv_user.OptionsBehavior.Editable = false;
            }
        }

        private void TreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            _treeView.Text = _treeView.TreeView.SelectedNode.Text;
            if (_treeView.TreeView.SelectedNode.Parent == null)
            {
                //_isRoot = true;
                _macty = _treeView.TreeView.SelectedNode.Tag.ToString();
                _madvi = "~";
            }
            else
            {
                //_isRoot = false;
                _macty = _treeView.TreeView.SelectedNode.Name.Substring(0, 4);
                _madvi = _treeView.TreeView.SelectedNode.Name.Substring(5);
            }
            loadUser(_macty, _madvi);
            _treeView.dropDown.Close();
        }

        private void gv_user_DoubleClick(object sender, EventArgs e)
        {
            if (gv_user.RowCount > 0 && gv_user.GetFocusedRowCellValue("Isgroup").Equals(true))
            {
                FrmGroup frm = new FrmGroup();
                frm._them = false;
                frm._IdUser = int.Parse(gv_user.GetFocusedRowCellValue("Iduser").ToString());
                frm.ShowDialog();
            }
            else
            {
                FrmUser frm = new FrmUser();
                frm._them = false;
                frm._IdUser = int.Parse(gv_user.GetFocusedRowCellValue("Iduser").ToString());
                frm.ShowDialog();
            }
        }

        private void gv_user_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.Name == "Isgroup" && bool.Parse(e.CellValue.ToString()) == true)
            {
                Image img = Properties.Resources.team;
                int checkboxSize = 16;

                // Xác định vị trí để vẽ ảnh, căn giữa theo chiều dọc trong ô checkbox
                int xPos = e.Bounds.X + (e.Bounds.Width - checkboxSize) / 2;  // Căn giữa theo chiều ngang
                int yPos = e.Bounds.Y + (e.Bounds.Height - checkboxSize) / 2; // Căn giữa theo chiều dọc

                // Tạo hình chữ nhật có kích thước của checkbox
                Rectangle imgRect = new Rectangle(xPos, yPos, checkboxSize, checkboxSize);

                // Vẽ hình ảnh đã được thu nhỏ theo kích thước checkbox
                e.Graphics.DrawImage(img, imgRect);
                e.Handled = true;
            }
            if (e.Column.Name == "Isgroup" && bool.Parse(e.CellValue.ToString()) == false)
            {
                Image img = Properties.Resources.alone;
                int checkboxSize = 16;
                int xPos = e.Bounds.X + (e.Bounds.Width - checkboxSize) / 2;
                int yPos = e.Bounds.Y + (e.Bounds.Height - checkboxSize) / 2;
                Rectangle imgRect = new Rectangle(xPos, yPos, checkboxSize, checkboxSize);
                e.Graphics.DrawImage(img, imgRect);
                e.Handled = true;
            }
            if (e.Column.Name == "Disable" && bool.Parse(e.CellValue.ToString()) == true)
            {
                Image img = Properties.Resources.xoa;
                int checkboxSize = 16;
                int xPos = e.Bounds.X + (e.Bounds.Width - checkboxSize) / 2;
                int yPos = e.Bounds.Y + (e.Bounds.Height - checkboxSize) / 2;
                Rectangle imgRect = new Rectangle(xPos, yPos, checkboxSize, checkboxSize);
                e.Graphics.DrawImage(img, imgRect);
                e.Handled = true;
            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmPhanQuyenBC frm = new FrmPhanQuyenBC();
            frm._macty = _macty;
            frm._madvi = _madvi;
            frm._id = int.Parse(gv_user.GetFocusedRowCellValue("Iduser").ToString());

            frm.ShowDialog();
        }
    }
}
       




