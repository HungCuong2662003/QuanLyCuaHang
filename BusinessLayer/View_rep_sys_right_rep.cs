using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class View_rep_sys_right_rep
    {
        Entities db;
        public View_rep_sys_right_rep()
        {
            db = Entities.CreateEntities();
        }
        public List<V_rep_sys_right_rep> getRep()
        {
            return db.V_rep_sys_right_rep.ToList();
        }
        public List<V_rep_sys_right_rep> getRepByUser(int id)
        {
            return db.V_rep_sys_right_rep.Where(x=>x.Iduser==id).ToList();
        }
    }
}
