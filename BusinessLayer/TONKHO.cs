using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLayer
{
    
    public class TONKHO
    {
        Entities db;
        public TONKHO() {
            db = Entities.CreateEntities();
        }
        public bool TinhTon(string madvi, DateTime ngay)
        {
            try
            {
                // Gọi thủ tục tính tồn kho từ cơ sở dữ liệu
                db.TINH_TONKHO_DONVI(ngay, madvi);
                return true; // Thành công
            }
            catch (SqlException sqlEx) // Bắt lỗi liên quan đến SQL
            {
                // Log hoặc xử lý lỗi SQL cụ thể
                throw new Exception("Lỗi SQL: " + sqlEx.Message, sqlEx);
            }
            catch (Exception ex) // Bắt các lỗi khác
            {
                return false;
                // Log hoặc xử lý lỗi tổng quát
                throw new Exception("Lỗi hệ thống: " + ex.Message, ex);
            }
        }
        public List<Obj_TonKho> GetTonKhoCtyDVI(string maCty, string MaDVi, int nam, int ky)
        {
            var tonKhoList = db.tb_TONKHO
                .Where(x => x.MACTY == maCty && x.MADVI==MaDVi &&x.NAM == nam && x.KY == ky)
                .ToList();

            var resultList = new List<Obj_TonKho>();

            foreach (var item in tonKhoList)
            {
                var tonKho = new Obj_TonKho();
                tonKho.BARCODE = item.BARCODE;
                var hangHoa = db.tb_HangHoa.FirstOrDefault(h => h.BarCode == item.BARCODE);
                tonKho.TenHH = hangHoa?.TenHH; // Sử dụng null conditional operator để tránh lỗi NullReferenceException
                tonKho.DVT = hangHoa?.DVT;
                tonKho.LG_DAU = item.LG_DAU;
                tonKho.LG_NHAPMUA = item.LG_NHAPMUA;
                tonKho.LG_NHAPNB = item.LG_NHAPNB;
                tonKho.LG_XUATNB = item.LG_XUATNB;
                tonKho.LG_XUATSI = item.LG_XUATSI;
                tonKho.LG_BANLE = item.LG_BANLE;
                tonKho.LG_CUOI = item.LG_CUOI;
                tonKho.TRIGIA = item.TRIGIA;
                tonKho.TIEN_CUOI = item.TIEN_CUOI;
                tonKho.MACTY = item.MACTY;
                tonKho.MADVI = item.MADVI;
                tonKho.NAM = item.NAM;
                tonKho.KY = item.KY;

                resultList.Add(tonKho);
            }

            return resultList;
        }public List<Obj_TonKho> GetTonKhoCty(string maCty ,int nam, int ky)
        {
            var tonKhoList = db.tb_TONKHO
                .Where(x => x.MACTY == maCty &&x.NAM == nam && x.KY == ky)
                .ToList();

            var resultList = new List<Obj_TonKho>();

            foreach (var item in tonKhoList)
            {
                var tonKho = new Obj_TonKho();
                tonKho.BARCODE = item.BARCODE;
                var hangHoa = db.tb_HangHoa.FirstOrDefault(h => h.BarCode == item.BARCODE);
                tonKho.TenHH = hangHoa?.TenHH; // Sử dụng null conditional operator để tránh lỗi NullReferenceException
                tonKho.DVT = hangHoa?.DVT;
                tonKho.LG_DAU = item.LG_DAU;
                tonKho.LG_NHAPMUA = item.LG_NHAPMUA;
                tonKho.LG_NHAPNB = item.LG_NHAPNB;
                tonKho.LG_XUATNB = item.LG_XUATNB;
                tonKho.LG_XUATSI = item.LG_XUATSI;
                tonKho.LG_BANLE = item.LG_BANLE;
                tonKho.LG_CUOI = item.LG_CUOI;
                tonKho.TRIGIA = item.TRIGIA;
                tonKho.TIEN_CUOI = item.TIEN_CUOI;
                tonKho.MACTY = item.MACTY;
                tonKho.MADVI = item.MADVI;
                tonKho.NAM = item.NAM;
                tonKho.KY = item.KY;

                resultList.Add(tonKho);
            }

            return resultList;
        }




    }
}
