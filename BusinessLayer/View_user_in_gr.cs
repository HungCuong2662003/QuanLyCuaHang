using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class View_user_in_gr
    {
        Entities db;
        public View_user_in_gr()
        {

            db = Entities.CreateEntities();
        }
        public List<V_user_in_gr> GetUserinGR(string madvi, string macty, int idgr)
        {
            return db.V_user_in_gr.Where(x=>x.Madvi == madvi && x.Macty==macty && x.Group==idgr && x.Isgroup==false && x.Disable==false).ToList();

        }
        public List<tb_SYS_User> getGRbyUSer(string madvi, string macty, int iduser)
        {
            List<tb_SYS_User> lstgr = new List<tb_SYS_User>();
            List<V_user_in_gr> lst = db.V_user_in_gr.Where(x => x.Iduser_in_gr == iduser && x.Madvi == madvi && x.Macty == macty).ToList();
            tb_SYS_User u;
            foreach (var gr in lst)
            {
                u=new tb_SYS_User();
                u=db.tb_SYS_User.FirstOrDefault(x=>x.Iduser==gr.Group);
                lstgr.Add(u);
            }
            return lstgr;
        }
         public List<tb_SYS_User> getGRbyUSerNotIn(string madvi, string macty)
        {
           return db.tb_SYS_User.Where(x=>x.Macty==macty && x.Madvi==madvi && x.Isgroup==true).ToList();
        }
        public bool CheckGrByUser(int iduser, int idgr)
        {
            // Sử dụng Any() để kiểm tra xem có bản ghi nào thỏa mãn điều kiện hay không
            return db.tb_SYS_Group.Any(x => x.Iduser_in_gr == iduser && x.Group == idgr);

        }


    }
}
