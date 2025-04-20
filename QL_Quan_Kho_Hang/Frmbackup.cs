using DataLayer;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.XtraEditors.Mask.MaskSettings;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QL_Quan_Kho_Hang
{
    public partial class Frmbackup : DevExpress.XtraEditors.XtraForm
    {
        public Frmbackup(tb_SYS_User user, int right)
        {
            InitializeComponent();
            this._user = user;
            this._right = right;
        }
        SqlConnection conn = new SqlConnection($"Data Source={myFunctions._srv};Initial Catalog={myFunctions._db};User ID={myFunctions._us};Password={myFunctions._pw};trustservercertificate=True;MultipleActiveResultSets=True;App=EntityFramework");


        tb_SYS_User _user;
        int _right;
        private void Frmbackup_Load(object sender, EventArgs e)
        {
            if (_right == 1)
            {
                BTN_DUONGDDAN.Enabled = false;
            }
            txt_dd.Enabled = false;
            BTN_BACKUP.Enabled = false;
        }

        private void BTN_DUONGDDAN_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dd= new FolderBrowserDialog();
            if (dd.ShowDialog() == DialogResult.OK)
            {
                txt_dd.Text=dd.SelectedPath;
                BTN_BACKUP.Enabled=true;
            }
        }

        private void BTN_BACKUP_Click(object sender, EventArgs e)
        {
            string db= conn.Database.ToString();
            if (string.IsNullOrEmpty(txt_dd.Text)){
                MessageBox.Show("vui lòng chọn đường dẫn file", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SplashScreenManager.ShowForm(this, typeof(FrmWaitForm), true, true, false);
                string sql = "BACKUP DATABASE [" + db + "] TO DISK = '" + txt_dd.Text + "\\" + db + "-" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".bak'";

                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                SplashScreenManager.CloseForm(true);

                MessageBox.Show("Backup dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BTN_BACKUP.Enabled = false;


            }
        }
    }
}