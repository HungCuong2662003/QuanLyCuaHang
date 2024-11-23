using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class NHACC
    {
        Entities db;
        public NHACC()
        {
            db = Entities.CreateEntities();
        }
        public tb_NhaCC getItem(string MaNCC)
        {
            return db.tb_NhaCC.FirstOrDefault(x => x.MaNCC == MaNCC);
        }
        public List<tb_NhaCC> getALL()
        {
            return db.tb_NhaCC.ToList();
        }
        public void add(tb_NhaCC nhacc)
        {
            try
            {
                db.tb_NhaCC.Add(nhacc);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("lỗi add dữ liệu" + ex.Message);
            }
        }
        public void update(tb_NhaCC xuatxu)
        {

            try
            {
                tb_NhaCC _nhacc = db.tb_NhaCC.FirstOrDefault(x => x.MaNCC == xuatxu.MaNCC);
                _nhacc.TenNCC = xuatxu.TenNCC;
                _nhacc.DienThoai = xuatxu.DienThoai;
                _nhacc.Email = xuatxu.Email;
                _nhacc.Fax = xuatxu.Fax;
                _nhacc.DiaChi = xuatxu.DiaChi;
                _nhacc.Disable = xuatxu.Disable;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("lỗi update dữ liệu" + ex.Message);
            }
        }
        public void Delete(string mancc)
        {

            try
            {
                tb_NhaCC xuatXu = db.tb_NhaCC.FirstOrDefault(x => x.MaNCC == mancc);
                db.tb_NhaCC.Remove(xuatXu);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("lỗi add dữ liệu" + ex.Message);
            }
        }
        public void False(string mancc)
        {

            try
            {
                tb_NhaCC _NhomHH = db.tb_NhaCC.FirstOrDefault(x => x.MaNCC == mancc);

                _NhomHH.Disable = true;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("lỗi update dữ liệu" + ex.Message);
            }

        }
    }
}

