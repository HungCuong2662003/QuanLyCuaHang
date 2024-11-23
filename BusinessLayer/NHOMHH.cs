using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class NHOMHH
    {
        Entities db;
        public NHOMHH()
        {
            db = Entities.CreateEntities();
        }
        public tb_NhomHH getItem(string id)
        {
            return db.tb_NhomHH.FirstOrDefault(x => x.IdNhom == id);
        }
        public List<tb_NhomHH> getALL()
        {
            return db.tb_NhomHH.ToList();
        }
        public void add(tb_NhomHH cty)
        {
            try
            {
                db.tb_NhomHH.Add(cty);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("lỗi add dữ liệu" + ex.Message);
            }
        }
        public void update(tb_NhomHH xuatxu)
        {
            
            try
            {
                tb_NhomHH _nhomhh = db.tb_NhomHH.FirstOrDefault(x => x.IdNhom == xuatxu.IdNhom);
                _nhomhh.TenNhom = xuatxu.TenNhom;
                _nhomhh.Disable=xuatxu.Disable;

                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("lỗi update dữ liệu" + ex.Message);
            }
        }
        public void Delete(string id)
        {
            
            try
            {
                tb_NhomHH xuatXu = db.tb_NhomHH.FirstOrDefault(x => x.IdNhom == id);
                db.tb_NhomHH.Remove(xuatXu);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("lỗi add dữ liệu" + ex.Message);
            }
        }
        public void False(string id)
        {
          
            try
            {
                tb_NhomHH _NhomHH = db.tb_NhomHH.FirstOrDefault(x => x.IdNhom == id);

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
