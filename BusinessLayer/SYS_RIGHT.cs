using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class SYS_RIGHT
    {
        Entities db;
        public SYS_RIGHT() { 
            db=Entities.CreateEntities();
        }
        public void update( int id,string fun_code, int right)
        {
            tb_SYS_Right tb_SYS_Right=db.tb_SYS_Right.FirstOrDefault(x=>x.Iduser==id && x.Func_code==fun_code);
            try
            {
                tb_SYS_Right.UserRight = right;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("loi"+ ex.Message );
            }
        }
        public tb_SYS_Right GetRight(int id, string fun_code)
        {
            return db.tb_SYS_Right.FirstOrDefault(x=>x.Iduser==id && x.Func_code==fun_code);
        }
    }
}
