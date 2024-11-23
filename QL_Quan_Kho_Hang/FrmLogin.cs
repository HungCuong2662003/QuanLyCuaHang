using BusinessLayer;
using DataLayer;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Quan_Kho_Hang
{
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        SYS_PARAM _PARAM;
        SYS_USER _USER;

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            if (txt_tk.Text.Trim()=="")
            {
                MessageBox.Show("tai khoan khong duoc de trong", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            bool us;

            if (_PARAM.madvi == "~")
            {
                 us = _USER.checkuserexitsCTY(_PARAM.macty, txt_tk.Text.Trim());
            }
            else
            {
                 us = _USER.checkuserexits(_PARAM.macty, _PARAM.madvi, txt_tk.Text.Trim());
            }
          

            if (!us)
            {
                MessageBox.Show("tai khoan khong ton tai", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            string pass = Encryptor.Encrypt(txt_mk.Text, "xyZtabc@!123", true);
            tb_SYS_User user;
            if (_PARAM.madvi == "~")
            {
                 user = _USER.getitemUserCTY(txt_tk.Text.Trim(), _PARAM.macty);
            }
            else
            {
                 user = _USER.getitemUser(txt_tk.Text.Trim(), _PARAM.macty, _PARAM.madvi);
            }
           
            if (user.Passwd.Equals(pass))
            {
                MainForm mainForm = new MainForm(user);
                mainForm.ShowDialog();
                this.Hide();

            }
            else
            {
                MessageBox.Show("mat khau khong chinh xac", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            _USER = new SYS_USER();
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = File.Open("sysparam.ini", FileMode.Open,FileAccess.Read);
            _PARAM=(SYS_PARAM)bf.Deserialize(fs);
            fs.Close();
            myFunctions._macty = _PARAM.macty;
            myFunctions._madvi = _PARAM.madvi;

        }
    }
}