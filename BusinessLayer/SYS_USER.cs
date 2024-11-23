using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    
    public class SYS_USER
    {
        Entities db;
        public SYS_USER() { 
            db=Entities.CreateEntities();
        }
        public List<tb_SYS_User> GetAll()
        {
            return db.tb_SYS_User.ToList();
        }public List<tb_SYS_User> GetAllDisable()
        {
            return db.tb_SYS_User.Where(x=>x.Disable==false).OrderByDescending(x => x.Isgroup).ToList();
        }

        public List<tb_SYS_User> GetAllbyDVI(string macty, string madvi)
        {
            return db.tb_SYS_User.Where(x=>x.Macty==macty && x.Madvi==madvi).ToList();
        }public List<tb_SYS_User> GetAllbyDVIDisable(string macty, string madvi)
        {
            return db.tb_SYS_User.Where(x=>x.Macty==macty && x.Madvi==madvi && x.Disable == false).OrderByDescending(x => x.Isgroup).ToList();
        }
        public tb_SYS_User getitem(int id)
        {
            return db.tb_SYS_User.FirstOrDefault(x=>x.Iduser==id);
        }    
        public tb_SYS_User getitemUser(string user, string macty, string madvi)
        {
            return db.tb_SYS_User.FirstOrDefault(x=>x.Username==user && x.Macty==macty && x.Madvi==madvi);
        }        
        public tb_SYS_User getitemUserCTY(string user, string macty)
        {
            return db.tb_SYS_User.FirstOrDefault(x=>x.Username==user && x.Macty==macty );
        }
        public bool checkuserexits(string macty, string madvi, string username)
        {
        
            var us=db.tb_SYS_User.FirstOrDefault(x=>x.Macty==macty && x.Madvi==madvi && x.Username==username);
            if (us != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }    
        public bool checkuserexitsCTY(string macty,string username)
        {
        
            var us=db.tb_SYS_User.FirstOrDefault(x=>x.Macty==macty && x.Username==username);
            if (us != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public tb_SYS_User add(tb_SYS_User user)
        {
            try
            {
                db.tb_SYS_User.Add(user);
                db.SaveChanges();
                return user;
            }
            catch (Exception ex)
            {
                throw new Exception("loi add "+ ex.Message);
            }
        }
        public tb_SYS_User update(tb_SYS_User user)
        {
            var us=db.tb_SYS_User.FirstOrDefault(x=>x.Iduser==user.Iduser);
            us.Username = user.Username;
            us.Fullname= user.Fullname;
            us.Isgroup = user.Isgroup;
            us.Disable= user.Disable;
            us.Macty= user.Macty;
            us.Madvi= user.Madvi;
            us.Passwd= user.Passwd;
            us.Last_PWD_Changed= DateTime.Now;
            try
            {
                db.SaveChanges();
                return user;
            }
            catch (Exception ex)
            {
                throw new Exception("loi update " + ex.Message);
            }
        }

    }
}
