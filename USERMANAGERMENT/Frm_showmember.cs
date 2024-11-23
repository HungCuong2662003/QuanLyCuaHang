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
    public partial class Frm_showmember : DevExpress.XtraEditors.XtraForm
    {
        public Frm_showmember()
        {
            InitializeComponent();
        }
        public string _macty;
        public string _madvi;
        public int _IDgr;
        SYS_GROUP _GROUP;
        View_user_notin_gr _User_notin_Gr;
        FrmGroup objGroup = (FrmGroup)Application.OpenForms["FrmGroup"];
        private void Frm_showmember_Load(object sender, EventArgs e)
        {
            _GROUP = new SYS_GROUP();
            _User_notin_Gr = new View_user_notin_gr();
            loadusernotingr();
        }
        void loadusernotingr()
        {
            gc_thanhvien.DataSource = _User_notin_Gr.getUserNotInGr(_madvi, _macty);
            gv_thanhvien.OptionsBehavior.Editable = false;
        }
        private void btn_luu_Click(object sender, EventArgs e)
        {
            tb_SYS_Group gr = new tb_SYS_Group();
            gr.Group=_IDgr;
            gr.Iduser_in_gr = int.Parse(gv_thanhvien.GetFocusedRowCellValue("Iduser").ToString());
            _GROUP.add(gr);
            objGroup.loadUserInGR(_IDgr);
            loadusernotingr();
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}