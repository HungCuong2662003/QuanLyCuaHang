using BusinessLayer;
using DataLayer;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Drawing;

namespace USERMANAGERMENT
{
    public partial class FrmPhanQuyen : DevExpress.XtraEditors.XtraForm
    {
        public FrmPhanQuyen()
        {
            InitializeComponent();
        }
        public string _macty;
        public string _madvi;
        public int _id;
        SYS_USER _sysuser;
        SYS_RIGHT _sysright;
        private void FrmPhanQuyen_Load(object sender, EventArgs e)
        {
          
            _sysuser = new SYS_USER();
            _sysright = new SYS_RIGHT();
            loadUser();
            loadFunc();
            gv_cn.RowStyle += gv_cn_RowStyle;       
        }

        private void gv_cn_RowStyle(object sender, RowStyleEventArgs e)
        {
           GridView gv = sender as GridView;
            if (e.RowHandle >= 0)
            {
                bool isRed = Convert.ToBoolean(gv.GetRowCellValue(e.RowHandle, gv.Columns["IsGroup"]));
                if (isRed)
                {
                    e.Appearance.BackColor=Color.DeepSkyBlue;
                    e.Appearance.ForeColor=Color.White;
                    e.Appearance.Font = new Font("Tahoma",10, FontStyle.Bold);
                }
            }
        }

        void loadUser()
        {
            if (_macty == null && _madvi == null)
            {
                gc_user.DataSource = _sysuser.GetAllDisable();
                gv_user.OptionsBehavior.Editable = false;
            }
            else
            {
                gc_user.DataSource = _sysuser.GetAllbyDVIDisable(_macty, _madvi);
                gv_user.OptionsBehavior.Editable = false;
            }

        }
        void loadFunc()
        {
            View_Func_sys_right view_Func_Sys_Right = new View_Func_sys_right();

            gc_cn.DataSource = view_Func_Sys_Right.GetFuncByUser(_id);
            gv_cn.OptionsBehavior.Editable = false;
            for (int i = 0; i < gv_user.RowCount; i++)
            {
                if (int.Parse(gv_user.GetRowCellValue(i, "Iduser").ToString())==_id)
                {
                    gv_user.ClearSelection();
                    gv_user.FocusedRowHandle = i;
                    gv_cn.ClearSelection();
                } 
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

        private void mn_xoaquyen_Click(object sender, EventArgs e)
        {
            for(int i=0;i<gv_cn.RowCount; i++)
            {
                if (gv_cn.IsRowSelected(i))
                {
                    _sysright.update(_id, gv_cn.GetRowCellValue(i, "FUNC_Code").ToString(), 0);

                }
            }
            loadFunc();
        }

        private void mn_chixem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gv_cn.RowCount; i++)
            {
                if (gv_cn.IsRowSelected(i))
                {
                    _sysright.update(_id, gv_cn.GetRowCellValue(i, "FUNC_Code").ToString(), 1);

                }
            }
            loadFunc();
        }

        private void mn_toanquyen_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gv_cn.RowCount; i++)
            {
                if (gv_cn.IsRowSelected(i))
                {
                    _sysright.update(_id, gv_cn.GetRowCellValue(i, "FUNC_Code").ToString(), 2);

                }
            }
            loadFunc();

        }

        private void gv_user_Click(object sender, EventArgs e)
        {
            _id=int.Parse(gv_user.GetFocusedRowCellValue("Iduser").ToString());
            loadFunc();
        }
    }
}