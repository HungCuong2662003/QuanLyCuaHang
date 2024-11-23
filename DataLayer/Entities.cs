using System;
using System.Data.Common;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DataLayer
{
    [Serializable]
    public partial class Entities
    {
        private Entities(DbConnection connectionString, bool contextOwnsConnection = true)
            : base(connectionString, contextOwnsConnection) { }

        public static Entities CreateEntities(bool contextOwnsConnection = true)
        {

            
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
                // Đọc file kết nối
                using (FileStream fs = File.Open("connectdb.dba", FileMode.Open, FileAccess.Read))
                {
                    
                    Connect cp = (Connect)bf.Deserialize(fs);
                    string servername = Encryptor.Decrypt(cp.servername, "qwertyuio" , true);
                    string username = Encryptor.Decrypt(cp.username, "qwertyuio", true);
                    string pass = Encryptor.Decrypt(cp.password, "qwertyuio", true);
                    string database = Encryptor.Decrypt(cp.database, "qwertyuio", true);
                    SqlConnectionStringBuilder sqlConnectBuilder = new SqlConnectionStringBuilder();
                    sqlConnectBuilder.DataSource = servername;
                    sqlConnectBuilder.InitialCatalog = database;
                    sqlConnectBuilder.UserID = username;
                    sqlConnectBuilder.Password = pass;

                    // Xây dựng Entity Connection
                    EntityConnectionStringBuilder entityBuilder = new EntityConnectionStringBuilder();
                    entityBuilder.Provider = "System.Data.SqlClient"; // Đảm bảo "SqlClient" được viết hoa chữ "C"
                    entityBuilder.ProviderConnectionString = sqlConnectBuilder.ConnectionString;
                    entityBuilder.Metadata = @"res://*/QL_CuaHang.csdl|res://*/QL_CuaHang.ssdl|res://*/QL_CuaHang.msl";

                    EntityConnection connection = new EntityConnection(entityBuilder.ConnectionString);
                    return new Entities(connection);
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ khi không thể đọc file
                throw new Exception("Không thể đọc file kết nối: " + ex.Message);
            }
        

        }
    }
}
