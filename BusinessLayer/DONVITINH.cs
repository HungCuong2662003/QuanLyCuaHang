using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class DONVITINH
    {
        Entities db;
        public DONVITINH()
        {
            db = Entities.CreateEntities();
        }
        public tb_DonViTinh getItem(int id)
        {
            return db.tb_DonViTinh.FirstOrDefault(x => x.ID == id);
        }
        public List<tb_DonViTinh> getALL()
        {
            return db.tb_DonViTinh.ToList();
        }
        public void add(tb_DonViTinh cty)
        {
            try
            {
                db.tb_DonViTinh.Add(cty);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("lỗi add dữ liệu" + ex.Message);
            }
        }
        public void update(tb_DonViTinh xuatxu)
        {

            try
            {
                tb_DonViTinh _XuatXu = db.tb_DonViTinh.FirstOrDefault(x => x.ID == xuatxu.ID);
                _XuatXu.Ten = xuatxu.Ten;   
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
                tb_DonViTinh xuatXu = db.tb_DonViTinh.FirstOrDefault(x => x.ID == id);
                db.tb_DonViTinh.Remove(xuatXu);
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
                tb_DonViTinh _XuatXu = db.tb_DonViTinh.FirstOrDefault(x => x.ID == id);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("lỗi update dữ liệu" + ex.Message);
            }
        }
    }
}
