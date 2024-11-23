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

namespace USERMANAGERMENT
{
    public partial class FrmShowGR : DevExpress.XtraEditors.XtraForm
    {
        public FrmShowGR()
        {
            InitializeComponent();
        }
        public string _macty;
        public string _madvi;
        public int _IDUser;
        SYS_GROUP _GROUP;
        View_user_in_gr viewGr;
        FrmUser objUser = (FrmUser)Application.OpenForms["FrmUser"];

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {

           
            if (viewGr.CheckGrByUser(_IDUser, int.Parse(gv_nhom.GetFocusedRowCellValue("Iduser").ToString())))
            {
                MessageBox.Show("Người dùng đã trong nhóm này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            tb_SYS_Group gr = new tb_SYS_Group();
            gr.Iduser_in_gr = _IDUser;
            gr.Group = int.Parse(gv_nhom.GetFocusedRowCellValue("Iduser").ToString());
            _GROUP.add(gr);
            objUser.loadGRbyUser(_IDUser);
            //this.Close();

        }

        private void FrmShowGR_Load(object sender, EventArgs e)
        {

            _GROUP = new SYS_GROUP();
            viewGr = new View_user_in_gr();
            loadGR();
           
          
        }
        void loadGR()
        {
            gc_nhom.DataSource = viewGr.getGRbyUSerNotIn(_madvi, _macty);
            gv_nhom.OptionsBehavior.Editable = false;
        }
       

    }
}