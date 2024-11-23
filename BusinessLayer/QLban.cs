using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class QLban
    {
        Entities db;
        public QLban()
        {
            db = Entities.CreateEntities();

        }
        public List<tb_Qlban> getALL()
        {
            return db.tb_Qlban.ToList();
        }
        public tb_Qlban getItem(int id)
        {
            return db.tb_Qlban.FirstOrDefault(x => x.idban == id);
        }
        public void add(tb_Qlban Qlban)
        {
            try
            {
                db.tb_Qlban.Add(Qlban);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("lỗi add dữ liệu" + ex.Message);
            }
        }
        public void update(tb_Qlban Qlban)
        {
            tb_Qlban _Qlban = db.tb_Qlban.FirstOrDefault(x => x.idban == Qlban.idban);
            _Qlban.tenban=Qlban.tenban;
           
            _Qlban.trangthai = Qlban.trangthai;
        

            try
            {

                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("lỗi update dữ liệu" + ex.Message);
            }
        }
        public void FalseQlban(int id)
        {
            tb_Qlban _Qlban = db.tb_Qlban.FirstOrDefault(x => x.idban == id);
            _Qlban.trangthai = true;
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
