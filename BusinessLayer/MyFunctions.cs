using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class MyFunctions
    {
        public static string _macty;
        public static string _madvi;
        public static string _srv;
        public static string _us;
        public static string _pw;
        public static string _db;

        // Method 1: Kiểm tra xem một chuỗi có phải là số hay không bằng cách lặp qua từng ký tự
        public static bool IsNumberUsingLoop(string pValue)
        {
            foreach (char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        // Method 2: Kiểm tra xem một chuỗi có phải là số hay không bằng cách sử dụng biểu thức thông thường


        //public static bool IsNumberUsingRegex(string pText)
        //{
        //    Regex regex = new Regex(@"^[+-]?[0-9]*\.?[0-9]+$");
        //    return regex.IsMatch(pText);
        //}
        public static bool IsNumberUsingRegex(string pText)
        {
            // Chấp nhận các chuỗi chứa chữ cái và số, không có ký tự đặc biệt
            Regex regex = new Regex(@"^[a-zA-Z0-9]+$");
            return regex.IsMatch(pText);
        }

    }
}
