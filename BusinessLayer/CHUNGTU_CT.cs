using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public  class CHUNGTU_CT
    {
        Entities db;
        public CHUNGTU_CT() { 
            db=Entities.CreateEntities();

        }
        public tb_Chungtu_CT getItem(Guid khoa)
        {
            return db.tb_Chungtu_CT.FirstOrDefault(x => x.Khoa == khoa);
        }

        public tb_Chungtu_CT getItembyban(int idban)
        {
            return db.tb_Chungtu_CT.FirstOrDefault(x => x.idban == idban && x.TrangThai == false);
        }

        public List<obj_CHUNGTU_CT> getlistbykhoafull(Guid khoa)
        {
            var lst=db.tb_Chungtu_CT.Where(x=>x.Khoa==khoa).ToList();
            List<obj_CHUNGTU_CT> lsCT = new List<obj_CHUNGTU_CT>();
            obj_CHUNGTU_CT obj;
            foreach (var item in lst)
            {
                obj = new obj_CHUNGTU_CT();
                obj.Khoa= item.Khoa;
                obj.KhoaCT = item.KhoaCT;
                obj.Barcode = item.Barcode;
                var h=db.tb_HangHoa.FirstOrDefault(x=>x.BarCode==item.Barcode);
                obj.TenHH = h.TenHH;
                obj.DVT = h.DVT;
                obj.SoluongCT = item.SoluongCT;
                obj.Dongia = item.Dongia;
                obj.GiaBan = item.GiaBan;
                obj.Thanhtien = item.Thanhtien;
                obj.Stt = item.Stt;
                obj.Ngay = item.Ngay;
                lsCT.Add(obj);

            }
            return lsCT;    
        }     
        public List<obj_CHUNGTU_CT> getlistbyBan(int ban)
        {
            var lst=db.tb_Chungtu_CT.Where(x=>x.idban==ban && x.TrangThai==false).OrderBy(x => x.Khoa).ThenBy(x => x.Ngay).ToList();
            List<obj_CHUNGTU_CT> lsCT = new List<obj_CHUNGTU_CT>();
            obj_CHUNGTU_CT obj;
            foreach (var item in lst)
            {
                obj = new obj_CHUNGTU_CT();
                obj.Khoa= item.Khoa;
                obj.KhoaCT = item.KhoaCT;
                obj.Barcode = item.Barcode;
                var h=db.tb_HangHoa.FirstOrDefault(x=>x.BarCode==item.Barcode);
                obj.TenHH = h.TenHH;
                obj.DVT = h.DVT;
                obj.SoluongCT = item.SoluongCT;
                obj.Dongia = item.Dongia;
                obj.GiaBan = item.GiaBan;
                obj.Thanhtien = item.Thanhtien;
                obj.Stt = item.Stt;
                obj.Ngay = item.Ngay;
                if (item.TrangThai.HasValue)
                {
                    obj.TrangThai = item.TrangThai.Value;
                }
                else
                {
                    obj.TrangThai = false; // hoặc một giá trị mặc định khác nếu cần
                }
                lsCT.Add(obj);

            }
            return lsCT;    
        }
        public tb_Chungtu_CT add(tb_Chungtu_CT chungtuct)
        {
            try
            {
                db.tb_Chungtu_CT.Add(chungtuct);
                db.SaveChanges();
                return chungtuct;
            }
            catch (Exception ex)
            {
                throw new Exception("lỗi add dữ liệu" + ex.Message);
            }

        }
        public void update(tb_Chungtu_CT chungtuct)
        {
            tb_Chungtu_CT _chungtuct = db.tb_Chungtu_CT.FirstOrDefault(x=>x.KhoaCT==chungtuct.KhoaCT);
            _chungtuct.Barcode = chungtuct.Barcode;
            _chungtuct.Khoa=chungtuct.Khoa;
            _chungtuct.SoluongCT = chungtuct.SoluongCT;
            _chungtuct.Dongia=chungtuct.Dongia;
            _chungtuct.GiaBan=chungtuct.GiaBan;
            _chungtuct.Thanhtien = chungtuct.Thanhtien;
            _chungtuct.Ngay=chungtuct.Ngay;
            try
            {

                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("lỗi update dữ liệu" + ex.Message);
            }
        }

        public void deleteALL(Guid khoa)
        {
            // Lấy tất cả các bản ghi có giá trị Khoa bằng khoa
            var chungtuList = db.tb_Chungtu_CT.Where(x => x.Khoa == khoa).ToList();

            // Kiểm tra nếu danh sách không trống thì xóa
            if (chungtuList.Any())
            {
                db.tb_Chungtu_CT.RemoveRange(chungtuList);

                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("lỗi " + ex.Message);
                }
            }
        }


    }
}
