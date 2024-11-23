using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class XUATXU
    {
        Entities db;
        public XUATXU()
        {
            db = Entities.CreateEntities();
        }
        public tb_XuatXu getItem(int id)
        {
            return db.tb_XuatXu.FirstOrDefault(x => x.ID == id);
        }
        public List<tb_XuatXu> getALL()
        {
            return db.tb_XuatXu.ToList();
        }
        public void add(tb_XuatXu cty)
        {
            try
            {
                db.tb_XuatXu.Add(cty);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("lỗi add dữ liệu" + ex.Message);
            }
        }
        public void update(tb_XuatXu xuatxu)
        {
            
            try
            {
                tb_XuatXu _XuatXu = db.tb_XuatXu.FirstOrDefault(x => x.ID == xuatxu.ID);
                _XuatXu.Ten = xuatxu.Ten;
                _XuatXu.Disable = xuatxu.Disable;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("lỗi update dữ liệu" + ex.Message);
            }
        }
        public void Delete(int id)
        {
            
            try
            {
                tb_XuatXu xuatXu = db.tb_XuatXu.FirstOrDefault(x => x.ID == id);
                db.tb_XuatXu.Remove(xuatXu);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("lỗi add dữ liệu" + ex.Message);
            }
        }
        public void False(int id)
        {
          
            try
            {
                tb_XuatXu _XuatXu = db.tb_XuatXu.FirstOrDefault(x => x.ID == id);
                _XuatXu.Disable = true;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("lỗi update dữ liệu" + ex.Message);
            }

        }
    }
}
