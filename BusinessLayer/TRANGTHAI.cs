using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class TRANGTHAI
    {
        public int _value {  get; set; }
        public string _display {  get; set; }
        public TRANGTHAI() { }
        public TRANGTHAI(int _val, string _dis)
        {
            this._value = _val;
            this._display = _dis;   
        }
        public static List<TRANGTHAI> getList()
        {
            List<TRANGTHAI> lst = new List<TRANGTHAI>();
            TRANGTHAI[] collect = new TRANGTHAI[2]
            {
                new TRANGTHAI(1, "Chưa hoàn tất") ,
                new TRANGTHAI(2,"Đã hoàn tất")
            };
            lst.AddRange(collect);
            return lst;
        }
    }
}
