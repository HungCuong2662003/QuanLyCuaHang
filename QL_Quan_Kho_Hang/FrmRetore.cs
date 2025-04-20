using DataLayer;
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

namespace QL_Quan_Kho_Hang
{
    public partial class FrmRetore : DevExpress.XtraEditors.XtraForm
    {
        public FrmRetore(tb_SYS_User user, int right)
        {
            InitializeComponent();
            this._user = user;
            this._right = right;
        }
        tb_SYS_User _user;
        int _right;
        SqlConnection conn = new SqlConnection($"Data Source={myFunctions._srv};Initial Catalog={myFunctions._db};User ID={myFunctions._us};Password={myFunctions._pw};trustservercertificate=True;MultipleActiveResultSets=True;App=EntityFramework");

        private void FrmRetore_Load(object sender, EventArgs e)
        {
            if (_right == 1)
            {
                BTN_DUONGDDAN.Enabled = false;

            }
            else if (_right == 2)
            {
               BTN_DUONGDDAN.Enabled=true;
            }
            txt_dd.Enabled = false;
            BTN_RETORE.Enabled = false;
        }



        private void BTN_DUONGDDAN_Click(object sender, EventArgs e)
        {
            OpenFileDialog open= new OpenFileDialog();
            open.Filter = "Backup file (.bak)|*.bak*";
            open.Title = "Phục hồi dữ liệu";
            if (open.ShowDialog() == DialogResult.OK)
            {
                txt_dd.Text=open.FileName;
                BTN_RETORE.Enabled=true;
            }
            
        }

        private void BTN_RETORE_Click(object sender, EventArgs e)
        {
            string database = conn.Database.ToString(); // Get the current database name
            conn.Open(); // Open the database connection

            try
            {
                SplashScreenManager.ShowForm(this, typeof(FrmWaitForm), true, true, false);
                // Step 1: Set the database to SINGLE_USER mode with immediate rollback
                string sql1 = $"ALTER DATABASE [{database}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE";
                SqlCommand cmd1 = new SqlCommand(sql1, conn);
                cmd1.ExecuteNonQuery();

                // Step 2: Restore the database from the backup file
                string sql2 = $"USE MASTER RESTORE DATABASE [{database}] FROM DISK = '{txt_dd.Text}' WITH REPLACE";
                SqlCommand cmd2 = new SqlCommand(sql2, conn);
                cmd2.ExecuteNonQuery();

                // Step 3: Set the database back to MULTI_USER mode
                string sql3 = $"ALTER DATABASE [{database}] SET MULTI_USER";
                SqlCommand cmd3 = new SqlCommand(sql3, conn);
                cmd3.ExecuteNonQuery();

                conn.Close(); // Close the database connection
                SplashScreenManager.CloseForm(true);
                // Display success message
                MessageBox.Show("Khôi phục dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BTN_RETORE.Enabled = false; // Disable the restore button
            }
            catch (Exception)
            {
                SplashScreenManager.CloseForm(true);
                // Handle errors and display failure message
                BTN_RETORE.Enabled = false;
                MessageBox.Show("Khôi phục dữ liệu không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}