using DataLayer;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace QL_Quan_Kho_Hang
{
    public partial class frmketNoiDB : DevExpress.XtraEditors.XtraForm
    {
        public frmketNoiDB()
        {
            InitializeComponent();
        }
        SqlConnection GetConnection(string server, string username, string pass, string database)
        {
            return new SqlConnection("Data Source=" + server + "; Initial Catalog=" + database + "; User ID=" + username + "; Password=" + pass + ";");
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_KT_Click(object sender, EventArgs e)
        {
            SqlConnection conn = GetConnection(txt_server.Text, txt_user.Text, txt_pass.Text, Cbb_Database.Text);
            try
            {
                conn.Open();
                MessageBox.Show("Kết nối thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối thất bại", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
            frmketNoiDB frmketNoi = new frmketNoiDB();
            frmketNoi.Hide();
        }

        private void cbb_Database_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbb_Database_MouseClick(object sender, MouseEventArgs e)
        {
            Cbb_Database.Items.Clear();
            try
            {
                string connString = "Data Source=" + txt_server.Text + "; User ID=" + txt_user.Text + "; Password=" + txt_pass.Text + ";";
                using (SqlConnection con = new SqlConnection(connString))
                {
                    con.Open();

                    // Sửa câu lệnh SQL: thêm dấu ngoặc đơn đóng
                    string sql = "SELECT name FROM sys.databases WHERE name NOT IN ('master', 'tempdb', 'model', 'msdb')";
                    SqlCommand cmd = new SqlCommand(sql, con);

                    // Sử dụng using để đảm bảo IDataReader được giải phóng
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Cbb_Database.Items.Add(dr[0].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string svEncrypt = Encryptor.Encrypt(txt_server.Text, "qwertyuio", true);
            string usEncrypt = Encryptor.Encrypt(txt_user.Text, "qwertyuio", true);
            string psEncrypt = Encryptor.Encrypt(txt_pass.Text, "qwertyuio", true);
            string dbEncrypt = Encryptor.Encrypt(Cbb_Database.Text, "qwertyuio", true);
            Connect cn = new Connect(svEncrypt, usEncrypt, psEncrypt, dbEncrypt);
            cn.SaveFile();
            MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //SaveFileDialog sf = new SaveFileDialog();
            //sf.Title = "Chọn nơi lưu trữ";
            //sf.Filter = "Text Files(*.dba)|*.dba|ALLFiles(*.*)|*.*";
            //if(sf.ShowDialog() == DialogResult.OK)
            //{
            //    Connect cn = new Connect(svEncrypt, usEncrypt, psEncrypt,dbEncrypt);
            //    cn.ConnectData(sf.FileName);
            //    MessageBox.Show("Lưu file thành công");
            //}
        }



        private void frmketNoiDB_Load(object sender, EventArgs e)
        {

        }

        private void Cbb_Database_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btn_docfile_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Chọn tập tin";
            op.Filter = "Text Files(*.dba)|*.dba|ALLFiles(*.*)|*.*";
            if (op.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = File.Open(op.FileName, FileMode.Open, FileAccess.Read);
                Connect con = (Connect)bf.Deserialize(fs);
                string svDecrypt = Encryptor.Decrypt(con.servername, "qwertyuio", true);
                string usDecrypt = Encryptor.Decrypt(con.username, "qwertyuio", true);
                string psDecrypt = Encryptor.Decrypt(con.password, "qwertyuio", true);
                string dbDecrypt = Encryptor.Decrypt(con.database, "qwertyuio", true);
                txt_server.Text = svDecrypt;
                txt_user.Text = usDecrypt;
                txt_pass.Text = psDecrypt;
                Cbb_Database.Text = dbDecrypt;
            }
        }
    }
}