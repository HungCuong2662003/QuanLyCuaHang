using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class KhachHang
    {

        Entities db;
        public KhachHang()
        {
            db = Entities.CreateEntities();
        }
        public List<tb_KhachHang> getItem()
        {
            return db.tb_KhachHang.ToList();
        }
        public tb_KhachHang getItem(string id)
        {
            return db.tb_KhachHang.FirstOrDefault(x => x.ID == id);
        }

        public void add(tb_KhachHang kh)
        {
            try
            {
                db.tb_KhachHang.Add(kh);
                db.SaveChanges();
              
            }
            catch (Exception ex)
            {
                throw new Exception("lỗi add dữ liệu chung tu" + ex.Message);
            }
        }
        public void update(tb_KhachHang kh)
        {
            // Tìm chứng từ trong cơ sở dữ liệu dựa trên khóa
            tb_KhachHang _kh = db.tb_KhachHang.FirstOrDefault(x => x.ID == kh.ID);

            // Kiểm tra nếu không tìm thấy bản ghi
            if (_kh == null)
            {
                throw new Exception("Không tìm thấy chứng từ để cập nhật.");
            }

            // Cập nhật các thuộc tính
            _kh.HOTEN = kh.HOTEN;
            _kh.DIENTHOAI = kh.DIENTHOAI;
            _kh.EMAIL = kh.EMAIL;
            _kh.DIACHI = kh.DIACHI;
            _kh.MASOTHUE = kh.MASOTHUE;
     

            try
            {
                // Lưu thay đổi vào cơ sở dữ liệu
                db.SaveChanges();
              
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi cập nhật dữ liệu: " + ex.Message);
            }
        }

        public void delete(string id)
        {
          

            try
            {
                tb_KhachHang kh = db.tb_KhachHang.FirstOrDefault(x => x.ID == id);
                db.tb_KhachHang.Remove(kh);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("lỗi delete dữ liệu" + ex.Message);
            }
        }

    }
}