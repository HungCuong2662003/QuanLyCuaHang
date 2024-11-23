using DataLayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    [Serializable]
    public class SYS_PARAM
    {
        string _macty;
        string _madvi;
        public string macty
        {
            set { _macty = value; }
            get { return _macty; }
        }
         public string madvi
        {
            set { _madvi = value; }
            get { return _madvi; }
        }
        public SYS_PARAM(string macty, string madvi)
        {
           this._macty=macty;
            this._madvi=madvi;

        }
        public void savefile()
        {
            if (File.Exists("sysparam.ini"))
            {
                File.Delete("sysparam.ini");
            }
            FileStream fs = File.Open("sysparam.ini", FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter(); 
            bf.Serialize(fs, this);
            fs.Close();
        }
    }
}
