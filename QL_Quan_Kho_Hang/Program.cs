using DataLayer;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;


namespace QL_Quan_Kho_Hang
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");

            if (File.Exists("connectdb.dba"))
            {
                
                string conStr = "";
                try
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    using (FileStream fs = File.Open("connectdb.dba", FileMode.Open, FileAccess.Read))
                    {
                        Connect con = (Connect)bf.Deserialize(fs);
                        string servername = Encryptor.Decrypt(con.servername, "qwertyuio", true);
                        string username = Encryptor.Decrypt(con.username, "qwertyuio", true);
                        string pass = Encryptor.Decrypt(con.password, "qwertyuio", true);
                        string database = Encryptor.Decrypt(con.database, "qwertyuio", true);

                        conStr = $"Data Source={servername};Initial Catalog={database};User ID={username};Password={pass};trustservercertificate=True;MultipleActiveResultSets=True;App=EntityFramework";
                        myFunctions._srv = servername;
                        myFunctions._us = username;
                        myFunctions._pw = pass;
                        myFunctions._db = database;
                    
                        QL_Quan_Ban_Hang.myFunctions._srv = servername;
                        QL_Quan_Ban_Hang.myFunctions._us = username;
                        QL_Quan_Ban_Hang.myFunctions._pw = pass;
                        QL_Quan_Ban_Hang.myFunctions._db = database;
                    }
                   

                    using (SqlConnection cp = new SqlConnection(conStr))
                    {
                        cp.Open();
                        // Kết nối thành công
                        //Application.Run(new MainForm());
                    }
                    if (File.Exists("sysparam.ini"))
                    {
                        Application.Run(new FrmLogin());
                    }
                    else
                    {
                        Application.Run(new FrmSetParam());
                    }
                }
                catch (FileNotFoundException fnfEx)
                {
                    MessageBox.Show("Tập tin kết nối không tồn tại: " + fnfEx.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Run(new frmketNoiDB());
                }
                catch (SerializationException serEx)
                {
                    MessageBox.Show("Lỗi khi đọc tập tin kết nối: " + serEx.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Run(new frmketNoiDB());
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("Lỗi khi kết nối cơ sở dữ liệu: " + sqlEx.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Run(new frmketNoiDB());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi không xác định: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Run(new frmketNoiDB());
                }
            }
            else
            {
                Application.Run(new frmketNoiDB());
            }
        }

        public static string connoi = "";
    }
}
