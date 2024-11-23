using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class View_user_notin_gr
    {
        Entities db;
        public View_user_notin_gr()
        {
            db = Entities.CreateEntities();
        }
        public List<v_user_not_in_group> getUserNotInGr(string _madvi, string _macty)
        {
            return db.v_user_not_in_group.Where(x => x.Madvi == _madvi && x.Macty == _macty && x.Isgroup==false && x.Disable==false).ToList();
        }
     
    }
   
}
