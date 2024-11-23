using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class SYS_RIGHT_REP
    {
        Entities db;
        public SYS_RIGHT_REP()
        {
            db=Entities.CreateEntities();
        }
        public void update(int id, int Rep_code, bool right)
        {
            tb_SYS_Right_Rep tb_SYS_Right_rep = db.tb_SYS_Right_Rep.FirstOrDefault(x => x.Iduser == id && x.Rep_code == Rep_code);
            try
            {
                tb_SYS_Right_rep.UserRight = right;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("loi" + ex.Message);
            }
        }
        public List<tb_SYS_Right_Rep> GetListByUser(int idUser)
        {
            // Tạo một instance của SYS_GROUP để lấy thông tin nhóm của người dùng
            SYS_GROUP sGroup = new SYS_GROUP();
            var group = sGroup.GetGroup(idUser);

            // Nếu người dùng không thuộc nhóm nào, trả về danh sách quyền của người dùng đó
            if (group == null)
            {
                return db.tb_SYS_Right_Rep
                         .Where(x => x.Iduser == idUser && x.UserRight == true)
                         .ToList();
            }
            else
            {
                // Lấy danh sách quyền từ nhóm
                var lstByGroup = db.tb_SYS_Right_Rep
                                   .Where(x => x.Iduser == group.Group && x.UserRight == true)
                                   .ToList();

                // Lấy danh sách quyền từ chính người dùng
                var lstByUser = db.tb_SYS_Right_Rep
                                  .Where(x => x.Iduser == idUser && x.UserRight == true)
                                  .ToList();

                // Kết hợp danh sách quyền từ nhóm và từ người dùng
                var lstAll = lstByUser.Concat(lstByGroup).ToList();

                return lstAll;
            }
        }

    }
}
