using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class DONVI
    {
        Entities db;
        public DONVI()
        {
            db = Entities.CreateEntities();
        }
        public tb_DonVi getItem(string madvi)
        {
            return db.tb_DonVi.FirstOrDefault(x => x.MaDvi == madvi);

        }
        public List<tb_DonVi> getItemList()
        {
            return db.tb_DonVi.ToList();
        }
        public List<tb_DonVi> getItemListCty(string macongty)
        {
            return db.tb_DonVi.Where(x => x.MaCty == macongty).ToList();
        }
        public List<tb_DonVi> getItemListKho(string macongty,bool kho)
        {
            return db.tb_DonVi.Where(x => x.MaCty == macongty && x.Kho==kho).ToList();
        }
        public void add(tb_DonVi dvi)
        {
            try
            {
                db.tb_DonVi.Add(dvi);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("loi add" + ex.Message);
            }
        }
        public void update(tb_DonVi dvi)
        {
            tb_DonVi _dvi = db.tb_DonVi.FirstOrDefault(x => x.MaDvi == dvi.MaDvi);
            _dvi.TenDvi = dvi.TenDvi;
            _dvi.DienThoai = dvi.DienThoai;
            _dvi.Email = dvi.Email;
            _dvi.Fax = dvi.Fax;
            _dvi.DiaChi = dvi.DiaChi;
            _dvi.MaCty = dvi.MaCty;
            _dvi.Kho = dvi.Kho;
            _dvi.KyHieu = dvi.KyHieu;
            _dvi.Disable = dvi.Disable;

            try
            {

                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("lỗi update dữ liệu" + ex.Message);
            }
        }
        public void FalseCty(string madv)
        {
            tb_DonVi _dvi = db.tb_DonVi.FirstOrDefault(x => x.MaDvi == madv);
            _dvi.Disable = true;
            try
            {

                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("lỗi update dữ liệu" + ex.Message);
            }

        }
    }
}
