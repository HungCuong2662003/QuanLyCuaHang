using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{   
    
    public class Sys_FUNC
    {
        Entities db;
        public Sys_FUNC() {
            db= Entities.CreateEntities();

        }
        public List<tb_SYS_Function> getParent()
        {
            return db.tb_SYS_Function.Where(x => x.IsGroup == true && x.Menu == true).OrderBy(s => s.Sort).ToList();

        }
        public List<tb_SYS_Function> getChill(string parent)
        {
            return db.tb_SYS_Function.Where(x => x.IsGroup == false && x.Menu == true && x.Parent== parent).OrderBy(s => s.Sort).ToList();

        }

    }
}
