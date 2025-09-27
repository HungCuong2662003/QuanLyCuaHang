using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ThongKeNgay
    {
        Entities db;
        public ThongKeNgay()
        {
            db = Entities.CreateEntities();
        }

        /// <summary>
        /// Lấy thống kê theo ngày với khả năng lọc theo loại thanh toán
        /// </summary>
        /// <param name="ngay">Ngày cần thống kê</param>
        /// <param name="loaiThanhToan">null: tất cả, true: chuyển khoản, false: tiền mặt</param>
        /// <param name="madvi">Mã đơn vị</param>
        /// <returns></returns>
        public Obj_ThongKeNgay GetThongKeNgay(DateTime ngay, bool? loaiThanhToan, string madvi)
        {
            try
            {
                // Lấy danh sách chứng từ theo ngày và đơn vị
                var query = db.tb_ChungTu.Where(x => 
                    x.Ngay.Value.Date == ngay.Date && 
                    x.MaDVI == madvi &&
                    x.TrangThai == 2 && // Chỉ lấy chứng từ đã hoàn thành
                    x.Delete_By == null); // Chưa bị xóa

                // Lọc theo loại thanh toán nếu có
                if (loaiThanhToan.HasValue)
                {
                    query = query.Where(x => x.ChuyenKhoan == loaiThanhToan.Value);
                }

                var lstChungTu = query.ToList();

                // Tính toán thống kê
                var tongTienMat = lstChungTu.Where(x => x.ChuyenKhoan == false).Sum(x => x.TongTien ?? 0);
                var tongTienChuyenKhoan = lstChungTu.Where(x => x.ChuyenKhoan == true).Sum(x => x.TongTien ?? 0);
                var tongTien = lstChungTu.Sum(x => x.TongTien ?? 0);
                var soHoaDon = lstChungTu.Count;

                return new Obj_ThongKeNgay
                {
                    Ngay = ngay,
                    TongTienMat = tongTienMat,
                    TongTienChuyenKhoan = tongTienChuyenKhoan,
                    TongTien = tongTien,
                    SoHoaDon = soHoaDon,
                    SoHoaDonTienMat = lstChungTu.Count(x => x.ChuyenKhoan == false),
                    SoHoaDonChuyenKhoan = lstChungTu.Count(x => x.ChuyenKhoan == true)
                };
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy thống kê ngày: " + ex.Message);
            }
        }
    }

    public class Obj_ThongKeNgay
    {
        public DateTime Ngay { get; set; }
        public double TongTienMat { get; set; }
        public double TongTienChuyenKhoan { get; set; }
        public double TongTien { get; set; }
        public int SoHoaDon { get; set; }
        public int SoHoaDonTienMat { get; set; }
        public int SoHoaDonChuyenKhoan { get; set; }
    }
}
