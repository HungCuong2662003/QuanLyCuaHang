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
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace USERMANAGERMENT
{
    public partial class FrmUser : DevExpress.XtraEditors.XtraForm
    {
        public FrmUser()
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
        View_user_in_gr view_User_In_Gr;

        private void FrmUser_Load(object sender, EventArgs e)
        {
            _sysuser = new SYS_USER();
            _sysgroup = new SYS_GROUP();
            if (!_them)
            {
                var user = _sysuser.getitem(_IdUser);
                txt_tendangnhap.Text = user.Username;
                txt_hovaten.Text=user.Fullname;
                _macty = user.Macty;
                _madvi = user.Madvi;
                ck_dis.Checked=user.Disable.Value;
                txt_mk.Text = Encryptor.Decrypt(user.Passwd, "xyZtabc@!123", true);
                txt_mk1.Text = Encryptor.Decrypt(user.Passwd, "xyZtabc@!123", true);
                txt_tendangnhap.ReadOnly = true;
                loadGRbyUser(_IdUser);

            }
            else
            {
                txt_hovaten.Text = "";
                txt_mk.Text = "";
                txt_mk1.Text = "";
                ck_dis.Checked = false;
            }
        }
        void savedata()
        {
            if (_them)
            {
                bool checkUser = _sysuser.checkuserexits(_macty, _madvi, txt_tendangnhap.Text.Trim());
                if (checkUser)
                {
                    MessageBox.Show("Nhóm đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_tendangnhap.SelectAll();
                    txt_hovaten.Focus();
                    return;
                }
                _tb_user = new tb_SYS_User();
                _tb_user.Username = txt_tendangnhap.Text.Trim();
                _tb_user.Fullname = txt_hovaten.Text;
                _tb_user.Passwd = Encryptor.Encrypt(txt_mk.Text.Trim(), "xyZtabc@!123", true);
                _tb_user.Isgroup = false;
                _tb_user.Disable = false;
                _tb_user.Macty = _macty;
                _tb_user.Madvi = _madvi;
                _tb_user.Last_PWD_Changed = DateTime.Now;
                _sysuser.add(_tb_user);


            }
            else
            {
                _tb_user = _sysuser.getitem(_IdUser);
                _tb_user.Fullname = txt_hovaten.Text;
                _tb_user.Passwd = Encryptor.Encrypt(txt_mk.Text.Trim(), "xyZtabc@!123", true);
                _tb_user.Isgroup = false;
                _tb_user.Disable = ck_dis.Checked;
                _tb_user.Macty = _macty;
                _tb_user.Madvi = _madvi;
                _tb_user.Last_PWD_Changed = DateTime.Now;
                _sysuser.update(_tb_user);
            }
            objMain.loadUser(_macty, _madvi);
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (txt_tendangnhap .Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập tên người dùng. Nhập tên không dấu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tendangnhap.SelectAll();
                txt_tendangnhap.Focus();
                return;
            }
            if (!txt_mk.Text.Equals(txt_mk1.Text))
            {
                MessageBox.Show("Mật khẩu không khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tendangnhap.SelectAll();
                txt_tendangnhap.Focus();
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
            FrmShowGR frm = new FrmShowGR();
            frm._IDUser=_IdUser;
            frm._macty = _macty;
            frm._madvi = _madvi;
            frm.ShowDialog();
        }
        public void loadGRbyUser(int idgr)
        {
            view_User_In_Gr= new View_user_in_gr();
            gc_thanhvien.DataSource = view_User_In_Gr.getGRbyUSer(_madvi, _macty, _IdUser);
            gv_thanhvien.OptionsBehavior.Editable = false;
        }

        private void gc_thanhvien_Click(object sender, EventArgs e)
        {

        }

        private void btn_bottv_Click(object sender, EventArgs e)
        {
            _sysgroup.remove(_IdUser, int.Parse(gv_thanhvien.GetFocusedRowCellValue("Iduser").ToString()));
            loadGRbyUser(_IdUser);
        }
    }
}