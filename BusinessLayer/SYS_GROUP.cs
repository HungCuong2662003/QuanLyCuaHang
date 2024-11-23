using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class SYS_GROUP
    {
        Entities db;
        public SYS_GROUP() { 
            db=Entities.CreateEntities();
        }
        public void add(tb_SYS_Group gr) {
            try
            {
                db.tb_SYS_Group.Add(gr);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("loi add vao group"+ ex.Message);
            }
        }
        public void remove(int IDuser, int idgr)
        {
            var gr= db.tb_SYS_Group.FirstOrDefault(x=>x.Iduser_in_gr==IDuser && x.Group==idgr);
            if (gr != null)
            {
                try
                {
                    db.tb_SYS_Group.Remove(gr);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("loi xoa khoi gr" + ex.Message);
                }
            }
        }
        public tb_SYS_Group GetGroup(int IDuser)
        {
            return db.tb_SYS_Group.FirstOrDefault(x=>x.Iduser_in_gr==IDuser);
        }

    }
}
