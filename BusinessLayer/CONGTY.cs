using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CONGTY
    {
        Entities db;
        public CONGTY()
        {
            db= Entities.CreateEntities();
        }
        public tb_CongTy getItem(string macty)
        {
            return db.tb_CongTy.FirstOrDefault(x=>x.MaCty==macty);  
        }
        public List<tb_CongTy> getALL()
        {
            return db.tb_CongTy.ToList();
        }
        public void add(tb_CongTy cty)
        {
            try
            {
                db.tb_CongTy.Add(cty);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("lỗi add dữ liệu" + ex.Message);
            }
        }
        public void update(tb_CongTy cty)
        {
            tb_CongTy _cty= db.tb_CongTy.FirstOrDefault(x=>x.MaCty==cty.MaCty);
            _cty.TenCty = cty.TenCty;
            _cty.DienThoai = cty.DienThoai;
            _cty.Fax = cty.Fax;
            _cty.Email = cty.Email;
            _cty.Disable = cty.Disable;
            _cty.DiaChi = cty.DiaChi;

            try
            {
                
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("lỗi update dữ liệu" + ex.Message);
            }
        }
        public void FalseCty(string macty)
        {
            tb_CongTy _cty = db.tb_CongTy.FirstOrDefault(x => x.MaCty == macty);
            if (_cty != null)
            {
                _cty.Disable = true;
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi khi cập nhật trạng thái công ty: " + ex.Message);
                }
            }
            else
            {
                throw new Exception("Không tìm thấy công ty với mã: " + macty);
            }
        }   
        public void remove(string macty)
        {
            tb_CongTy _cty = db.tb_CongTy.FirstOrDefault(x => x.MaCty == macty);
            if (_cty != null)
            {
                try
                {
                    db.tb_CongTy.Remove(_cty);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi khi khi xóa công ty công ty: " + ex.Message);
                }
            }
            else
            {
                throw new Exception("Không tìm thấy công ty với mã: " + macty);
            }
        }

    }
}
