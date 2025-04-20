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
        public void update(tb_NhomHH nhomHH)
        {
            try
            {
                tb_NhomHH _existing = db.tb_NhomHH.FirstOrDefault(x => x.IdNhom == nhomHH.IdNhom);
                if (_existing == null)
                {
                    throw new Exception("No matching record found to update.");
                }

                _existing.TenNhom = nhomHH.TenNhom;
                _existing.Disable = nhomHH.Disable;

                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating data: " + ex.Message, ex);
            }
        }
        public void remove(string id)
        {
            
            try
            {
                tb_NhomHH xuatXu = db.tb_NhomHH.FirstOrDefault(x => x.IdNhom == id);
                db.tb_NhomHH.Remove(xuatXu);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("lỗi delete dữ liệu" + ex.Message);
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
                throw new Exception("lỗi delete dữ liệu" + ex.Message);
            }

        }
    }
}
