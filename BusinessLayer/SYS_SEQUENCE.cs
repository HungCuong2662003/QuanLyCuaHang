using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class SYS_SEQUENCE
    {
        Entities db;
        public SYS_SEQUENCE(){
            db= Entities.CreateEntities();
        }
        public tb_SYS_SEQUENCE getitem(string sequence)
        {
            return db.tb_SYS_SEQUENCE.FirstOrDefault(x=>x.Name==sequence);
        }
        public void add(tb_SYS_SEQUENCE sEQUENCE)
        {
            try
            {
                db.tb_SYS_SEQUENCE.Add(sEQUENCE);
                db.SaveChanges();
            }
            catch (DbEntityValidationException ex) // Bắt lỗi DbEntityValidationException để lấy chi tiết lỗi
            {
                foreach (var validationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Debug.WriteLine($"Property: {validationError.PropertyName} Error: {validationError.ErrorMessage}");
                        Console.WriteLine($"Property: {validationError.PropertyName} Error: {validationError.ErrorMessage}");
                    }
                }
                throw new Exception("Lỗi thêm sEQUENCE: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khác khi thêm sEQUENCE: " + ex.Message);
            }
        }
        public void update(tb_SYS_SEQUENCE sEQUENCE)
        {
            

            try
            {
                var seq = db.tb_SYS_SEQUENCE.FirstOrDefault(x => x.Name == sEQUENCE.Name);
                seq.value = sEQUENCE.value + 1;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("lỗi update dữ liệu" + ex.Message);
            }
        }
        
    }
}
