using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Obj_HangHoa
    {
        public string BarCode { get; set; }
        public string TenHH { get; set; }
        public string TenTat { get; set; }
        public string DVT { get; set; }
        public Nullable<double> DonGia { get; set; }   
        public Nullable<double> GiaBan { get; set; }
        public string MaNCC { get; set; }
        public string TenNCC {  get; set; }
        public Nullable<int> Maxuatxu { get; set; }
        public string TenXX { get; set; }
        public string IdNhom { get; set; }
        public string TenNhom { get; set; }
        public string Mota { get; set; }
        public Nullable<System.DateTime> Create_Date { get; set; }
        public int Create_By { get; set; }
        public string Create_By_name { get; set; }
        public Nullable<bool> Disable { get; set; }
    }
}
