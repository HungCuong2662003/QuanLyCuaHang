using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Obj_TonKho
    {
        public System.Guid KHOA { get; set; }
        public Nullable<int> NAMKY { get; set; }
        public Nullable<int> NAM { get; set; }
        public Nullable<int> KY { get; set; }
        public string MACTY { get; set; }
        public string MADVI { get; set; }
        public string BARCODE { get; set; }
        public Nullable<double> LG_DAU { get; set; }
        public Nullable<double> LG_NHAPMUA { get; set; }
        public Nullable<double> LG_NHAPNB { get; set; }
        public Nullable<double> LG_XUATNB { get; set; }
        public Nullable<double> LG_XUATSI { get; set; }
        public Nullable<double> LG_BANLE { get; set; }
        public Nullable<double> LG_CUOI { get; set; }
        public Nullable<double> TRIGIA { get; set; }
        public Nullable<double> TIEN_CUOI { get; set; }
        public System.DateTime NGAY { get; set; }
        public string TenHH { get; set; }
        public string DVT { get; set; }
    }
}
