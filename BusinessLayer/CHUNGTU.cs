using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CHUNGTU
    {

        Entities db;
        public CHUNGTU()
        {
            db = Entities.CreateEntities();
        }
        public List<tb_ChungTu> getItem()
        {
            return db.tb_ChungTu.ToList();
        }
        public tb_ChungTu getItem(Guid khoa)

        {

            return db.tb_ChungTu.FirstOrDefault(x => x.Khoa == khoa);
        }
        public tb_ChungTu getItem(string sct)
        {
            return db.tb_ChungTu.FirstOrDefault(x => x.SoChungTu == sct);
        }
        public List<tb_ChungTu> getList(int lct, DateTime tungay, DateTime denngay, string madvi)
        {
      
            // Lọc dữ liệu từ cơ sở dữ liệu dựa trên các điều kiện
            return db.tb_ChungTu.Where(x => x.Ngay >= tungay
                                             && x.Ngay <= denngay
                                             && x.MaDVI == madvi && x.LoaiCT==lct).ToList();
        }
        public List<tb_ChungTu> getListbycheck(int lct,DateTime tungay, DateTime denngay, string madvi)
        {

            // Lọc dữ liệu từ cơ sở dữ liệu dựa trên các điều kiện
            return db.tb_ChungTu.Where(x => x.Ngay >= tungay
                                             && x.Ngay <= denngay
                                             && x.MaDVI == madvi && x.Delete_By!=null && x.LoaiCT==lct ).ToList();
        }

        public tb_ChungTu add(tb_ChungTu ctu)
        {
            try
            {
                db.tb_ChungTu.Add(ctu);
                db.SaveChanges();
                return ctu;
            }
            catch (Exception ex)
            {
                throw new Exception("lỗi add dữ liệu chung tu" + ex.Message);
            }
        }

        public tb_ChungTu update(tb_ChungTu ctu)
        {
            // Tìm chứng từ trong cơ sở dữ liệu dựa trên khóa
            tb_ChungTu _ctu = db.tb_ChungTu.FirstOrDefault(x => x.Khoa == ctu.Khoa);

            // Kiểm tra nếu không tìm thấy bản ghi
            if (_ctu == null)
            {
                throw new Exception("Không tìm thấy chứng từ để cập nhật.");
            }

            // Cập nhật các thuộc tính
            _ctu.SoChungTu = ctu.SoChungTu;
            _ctu.Ngay = ctu.Ngay;
            _ctu.SoChungTu2 = ctu.SoChungTu2;
            _ctu.Ngay2 = ctu.Ngay2;
            _ctu.SoLuong = ctu.SoLuong;
            _ctu.TongTien = ctu.TongTien;
            _ctu.GhiChu = ctu.GhiChu;
            _ctu.MaCty = ctu.MaCty;
            _ctu.MaDVI = ctu.MaDVI;
            _ctu.TrangThai = ctu.TrangThai;
            _ctu.Create_Date = ctu.Create_Date;
            _ctu.Create_By = ctu.Create_By;
            _ctu.Update_Date = ctu.Update_Date;
            _ctu.Update_By = ctu.Update_By;
            _ctu.Delete_Date = ctu.Delete_Date;
            _ctu.Delete_By = ctu.Delete_By;

            try
            {
                // Lưu thay đổi vào cơ sở dữ liệu
                db.SaveChanges();
                return _ctu; // Trả về đối tượng đã cập nhật
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi cập nhật dữ liệu: " + ex.Message);
            }
        }

        public void delete(Guid khoa, int Delete_By)
        {
            tb_ChungTu _ctu = db.tb_ChungTu.FirstOrDefault(x => x.Khoa == khoa);
            _ctu.Delete_By = Delete_By;
            
            try
            {

                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("lỗi delete dữ liệu" + ex.Message);
            }

        }    
        public void redelete(Guid khoa)
        {

        
            tb_ChungTu _ctu = db.tb_ChungTu.FirstOrDefault(x => x.Khoa == khoa);
            _ctu.Delete_By = null;
            
            try
            {

                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("lỗi delete dữ liệu" + ex.Message);
            }

        }
    }
}
