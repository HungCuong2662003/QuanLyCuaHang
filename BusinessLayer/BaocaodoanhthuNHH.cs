using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BaocaodoanhthuNHH
    {
        Entities db;
        public BaocaodoanhthuNHH()
        {
            db = Entities.CreateEntities();
            // Force refresh để đảm bảo sử dụng stored procedure mới
            db.Configuration.LazyLoadingEnabled = false;
            db.Configuration.ProxyCreationEnabled = false;
        }
        public List<Obj_report_nhh> DoanhThuTheoNhomHangHoa(DateTime tu_ngay, DateTime den_ngay, bool tm,bool ck)
        {
            // Debug: Log parameters
            System.Diagnostics.Debug.WriteLine($"DoanhThuTheoNhomHangHoa: tu_ngay={tu_ngay}, den_ngay={den_ngay}, tm={tm}, ck={ck}");

            List<Obj_report_nhh> lstDoanhThuNhom = new List<Obj_report_nhh>();
            var lstNhom = db.FN_DOANHTHU_THEONHOMHANG(tu_ngay, den_ngay,tm,ck).ToList();
            
            // Debug: Log result count
            System.Diagnostics.Debug.WriteLine($"DoanhThuTheoNhomHangHoa result count: {lstNhom.Count}");

            foreach (var item in lstNhom)
            {
                Obj_report_nhh nhomhh = new Obj_report_nhh(); // Tạo đối tượng mới cho mỗi phần tử
                nhomhh.Idnhom = item.IDNHOM;
                nhomhh.tennhom = item.TENNHOM;
                nhomhh.thanhtien = item.THANHTIEN;
                lstDoanhThuNhom.Add(nhomhh);
            }

            return lstDoanhThuNhom;

        }
        public List<Obj_report_nhh> DoanhThuTheoMH(DateTime tu_ngay, DateTime den_ngay, bool tm, bool ck)
        {
            // Debug: Log parameters
            System.Diagnostics.Debug.WriteLine($"DoanhThuTheoMH: tu_ngay={tu_ngay}, den_ngay={den_ngay}, tm={tm}, ck={ck}");

            List<Obj_report_nhh> lstDoanhThuNhom = new List<Obj_report_nhh>();
            var lstNhom =db.SP_DOANHTHU_THEOMATHANG (tu_ngay, den_ngay,tm,ck).ToList();
            
            // Debug: Log result count
            System.Diagnostics.Debug.WriteLine($"DoanhThuTheoMH result count: {lstNhom.Count}");

            foreach (var item in lstNhom)
            {
                Obj_report_nhh nhomhh = new Obj_report_nhh(); // Tạo đối tượng mới cho mỗi phần tử
                nhomhh.barcode = item.Barcode;
                nhomhh.tenhh = item.tenhh;
                nhomhh.soluong=item.SOLUONG;
                nhomhh.thanhtien = item.THANHTIEN;
                lstDoanhThuNhom.Add(nhomhh);
            }

            return lstDoanhThuNhom;

        }

    }
}
