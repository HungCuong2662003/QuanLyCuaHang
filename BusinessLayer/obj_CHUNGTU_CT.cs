using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class obj_CHUNGTU_CT
    {
        public System.Guid KhoaCT {  get; set; }    
        public Nullable<System.Guid> Khoa { get; set; }
        public string Barcode { get; set; } 
        public string TenHH { get; set; }
        public string DVT { get; set; }
        public Nullable<double> SoluongCT { get; set; }
        public Nullable<double> Chietkhau { get; set; }
        public Nullable<double > Dongia { get; set; }   
        public Nullable<double > GiaBan { get; set; }
        public Nullable<double> Thanhtien { get; set; }
        public Nullable<int> Stt { get; set; }
        public bool TrangThai { get; set; }
        public Nullable<System.DateTime> Ngay { get; set; }
   
         
    }
}
