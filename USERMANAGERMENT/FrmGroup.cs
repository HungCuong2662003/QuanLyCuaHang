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
using DataLayer;
using BusinessLayer;

namespace USERMANAGERMENT
{
    public partial class FrmGroup : DevExpress.XtraEditors.XtraForm
    {
        public FrmGroup()
        {
            InitializeComponent();
        }
        
        MainFormUser objMain = (MainFormUser)Application.OpenForms["MainFormUser"];
        public string _macty;
        public string _madvi;
        public int _IdUser;
        public string _fullname;
        public bool _them;
        SYS_USER _sysuser;
        SYS_GROUP _sysgroup;
        tb_SYS_User _tb_user;
        View_user_in_gr _User_In_Gr;
        private void FrmGroup_Load(object sender, EventArgs e)
        {
            _sysuser = new SYS_USER();
            _sysgroup = new SYS_GROUP();
           
            if (!_them)
            {
                var user=_sysuser.getitem(_IdUser);
                txt_tennhom.Text=user.Username;
                _macty=user.Macty;
                _madvi=user.Madvi;
                txt_mota.Text=user.Fullname;
                txt_tennhom.ReadOnly = true;
                loadUserInGR(_IdUser);

            }
            else
            {
                txt_mota.Text = "";
                txt_tennhom.Text = "";
            }
        }
        public void loadUserInGR(int idGr)
        {
            _User_In_Gr = new View_user_in_gr();
            gc_thanhvien.DataSource = _User_In_Gr.GetUserinGR(_madvi,_macty, idGr);
            gv_thanhvien.OptionsBehavior.Editable = false;
        }
        void savedata()
        {
            if (_them)
            {
                bool checkUser = _sysuser.checkuserexits(_macty, _madvi, txt_tennhom.Text.Trim());
                if (checkUser)
                {
                    MessageBox.Show("Nhóm đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_tennhom.SelectAll();
                    txt_tennhom.Focus();
                    return;
                }
                _tb_user = new tb_SYS_User();
                _tb_user.Username = txt_tennhom.Text.Trim(); 
                _tb_user.Fullname=txt_mota.Text;
                _tb_user.Isgroup = true;
                _tb_user.Disable = false;
                _tb_user.Macty=_macty;
                _tb_user.Madvi=_madvi;
                _tb_user.Last_PWD_Changed=DateTime.Now;
                _sysuser.add(_tb_user);
                

            }
            else
            {
                _tb_user= _sysuser.getitem(_IdUser);
                _tb_user.Fullname = txt_mota.Text.Trim();
                _sysuser.update(_tb_user);
            }
            objMain.loadUser(_macty, _madvi);
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (txt_tennhom.Text.Trim()=="") 
            {
                MessageBox.Show("Chưa nhập tên nhóm. Nhập tên nhóm không dấu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tennhom.SelectAll();
                return;
            }
            savedata();

        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            Frm_showmember frm = new Frm_showmember();  
            frm._IDgr=_IdUser;
            frm._macty=_macty;
            frm._madvi=_madvi;
            frm.ShowDialog();
        }

        private void btn_bottv_Click(object sender, EventArgs e)
        {
            if (gv_thanhvien.GetFocusedRowCellValue("Iduser") != null)
            {
                _sysgroup.remove(int.Parse(gv_thanhvien.GetFocusedRowCellValue("Iduser").ToString()), _IdUser);
                loadUserInGR(_IdUser);
            }
        }
    }
}