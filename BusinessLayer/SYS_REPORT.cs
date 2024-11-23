using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class SYS_REPORT
    {
        Entities db;

        // Constructor để khởi tạo đối tượng db
        public SYS_REPORT()
        {
            db = Entities.CreateEntities();
        }

        // Phương thức lấy một bản ghi từ tb_SYS_report theo mã báo cáo
        public tb_SYS_report getItem(int rep_code)
        {
            return db.tb_SYS_report.FirstOrDefault(x => x.Rep_code == rep_code);
        }

        // Phương thức trả về danh sách tất cả các bản ghi từ tb_SYS_report
        public List<tb_SYS_report> getList()
        {
            return db.tb_SYS_report.ToList();
        }

        // Phương thức trả về danh sách các bản ghi tb_SYS_report dựa trên danh sách quyền
        public List<tb_SYS_report> getListByRight(List<tb_SYS_Right_Rep> lst)
        {
            List<int> rep = lst.Select(x => x.Rep_code).ToList();
            return db.tb_SYS_report
                     .Where(x => rep.Contains(x.Rep_code))
                     .OrderBy(x => x.Rep_code)
                     .ToList();
        }


    }

}
