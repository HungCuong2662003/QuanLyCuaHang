using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class View_Func_sys_right
    {
        Entities db;
        public View_Func_sys_right() { 
            db=Entities.CreateEntities();
        }
        public List<v_Func_SYS_Right> GetFuncByUser(int id)
        {
            return db.v_Func_SYS_Right.Where(x=> x.Iduser == id).OrderBy(x=>x.Sort).ToList();
        }
    }
}
