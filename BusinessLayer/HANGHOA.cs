using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class HANGHOA
    {
        Entities db;
        public HANGHOA()
        {
            db = Entities.CreateEntities();
        }
        public List<tb_HangHoa> getALL()
        {
            return db.tb_HangHoa.ToList();
        }
        public tb_HangHoa getItem(string barcode)
        {
            return db.tb_HangHoa.FirstOrDefault(x => x.BarCode == barcode);
        }


        public List<tb_HangHoa> getlistbyNHOM(string id)
        {
            return db.tb_HangHoa.Where(x=>x.IdNhom == id).OrderBy(y=>y.Create_Date).ToList();
        }
        public List<Obj_HangHoa> getlistbyNHOM_Full(string id)
        {
            var lst= db.tb_HangHoa.Where(x => x.IdNhom == id).OrderBy(y => y.Create_Date).ToList();
            List<Obj_HangHoa> lsObj = new List<Obj_HangHoa>();
            Obj_HangHoa hh;
            foreach(var item in lst)
            {
                hh= new Obj_HangHoa();
                hh.BarCode = item.BarCode;
                hh.TenHH = item.TenHH;
                hh.TenTat=item.TenTat;
                hh.IdNhom = item.IdNhom;
                var n=db.tb_NhomHH.FirstOrDefault(x=>x.IdNhom==item.IdNhom);
                hh.TenNhom=n.TenNhom;
                hh.MaNCC = item.MaNCC;
                var n1 = db.tb_NhaCC.FirstOrDefault(x => x.MaNCC == item.MaNCC);
                hh.TenNCC = n1.TenNCC;
                hh.Maxuatxu = item.Maxuatxu;
                var n2 = db.tb_XuatXu.FirstOrDefault(x => x.ID == item.Maxuatxu);
                hh.TenXX=n2.Ten;
                hh.DVT = item.DVT;
                hh.DonGia = item.DonGia;
                hh.GiaBan=item.GiaBan;
                hh.Mota=item.Mota;
                hh.Create_Date = item.Create_Date;
                var listid= db.tb_SYS_User.FirstOrDefault(x => x.Iduser == item.Create_By);
                hh.Create_By = (int)item.Create_By;
                hh.Create_By_name = listid.Fullname;
                hh.Disable=item.Disable;
                lsObj.Add(hh);
            }
            return lsObj;

        }
        public List<Obj_HangHoa> getlistbybarcode_Full(string barcode)
        {
            var lst = db.tb_HangHoa.Where(x => x.BarCode == barcode).ToList();
            List<Obj_HangHoa> lsObj = new List<Obj_HangHoa>();

            foreach (var item in lst)
            {
                Obj_HangHoa hh = new Obj_HangHoa
                {
                    BarCode = item.BarCode,
                    TenHH = item.TenHH,
                    TenTat = item.TenTat,
                    IdNhom = item.IdNhom,
                    MaNCC = item.MaNCC,
                    Maxuatxu = item.Maxuatxu,
                    DVT = item.DVT,
                    DonGia = item.DonGia,
                    GiaBan = item.GiaBan,
                    Mota = item.Mota,
                    Create_Date = item.Create_Date,
                    Create_By = (int)item.Create_By,
                    Disable = item.Disable
                };

                // Kiểm tra và lấy tên nhóm hàng hóa
                var n = db.tb_NhomHH.FirstOrDefault(x => x.IdNhom == item.IdNhom);
                if (n != null)
                {
                    hh.TenNhom = n.TenNhom;
                }

                // Kiểm tra và lấy tên nhà cung cấp
                var n1 = db.tb_NhaCC.FirstOrDefault(x => x.MaNCC == item.MaNCC);
                if (n1 != null)
                {
                    hh.TenNCC = n1.TenNCC;
                }

                // Kiểm tra và lấy xuất xứ
                var n2 = db.tb_XuatXu.FirstOrDefault(x => x.ID == item.Maxuatxu);
                if (n2 != null)
                {
                    hh.TenXX = n2.Ten;
                }

                // Thêm đối tượng vào danh sách
                lsObj.Add(hh);
            }

            return lsObj;
        }

        public tb_HangHoa add(tb_HangHoa hh)
        {
            try
            {
                db.tb_HangHoa.Add(hh);
                db.SaveChanges();
                return hh;
            }
            catch (Exception ex)
            {
                throw new Exception("lỗi add dữ liệu" + ex.Message);
            }
        }
        public tb_HangHoa update(tb_HangHoa hh)
        {
            tb_HangHoa _hanghoa = db.tb_HangHoa.FirstOrDefault(x => x.BarCode == hh.BarCode);
            _hanghoa.TenHH = hh.TenHH;
            _hanghoa.TenTat = hh.TenTat;
            _hanghoa.DVT = hh.DVT;
            _hanghoa.DonGia = hh.DonGia;
            _hanghoa.GiaBan = hh.GiaBan;
            _hanghoa.MaNCC = hh.MaNCC;
            _hanghoa.Maxuatxu = hh.Maxuatxu;
            _hanghoa.IdNhom = hh.IdNhom;
            _hanghoa.Mota = hh.Mota;
            _hanghoa.Disable = hh.Disable;
            _hanghoa.Create_Date = hh.Create_Date;
            _hanghoa.Create_By = hh.Create_By;


            try
            {

                db.SaveChanges();
                return _hanghoa;
            }
            catch (Exception ex)
            {
                throw new Exception("lỗi update dữ liệu" + ex.Message);
            }
        }
        public void Falsehh(string BarCode)
        {
            tb_HangHoa _hanghoa = db.tb_HangHoa.FirstOrDefault(x => x.BarCode == BarCode);
            _hanghoa.Disable = true;
            try
            {

                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("lỗi delete dữ liệu" + ex.Message);
            }

        }
        public List<obj_barcode> getdanhmucinbarcode(string id)
        {
            var lstDM = db.tb_HangHoa.Where(x => x.IdNhom == id).ToList();
            List<obj_barcode> lstprintbarcode = new List<obj_barcode>();

            foreach (var x in lstDM)
            {
                lstprintbarcode.Add(new obj_barcode
                {
                    BarCode = x.BarCode,
                    TenHH = x.TenHH,
                    TenTat = x.TenTat,
                    DVT = x.DVT,
                    DonGia = x.DonGia,
                    GiaBan = x.GiaBan,
                    SOTEM = null
                });
            }

            return lstprintbarcode;
        }
        public List<tb_HangHoa> getListByKeyWord(string keyword)
        {
            return db.tb_HangHoa.Where(x=> x.TenHH.Contains(keyword)).ToList();
        }
        public bool checkexit(string barcode)
        {
            var h=db.tb_HangHoa.FirstOrDefault(x=>x.BarCode == barcode);
            if (h != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
