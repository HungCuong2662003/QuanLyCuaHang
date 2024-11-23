using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BARCODE
    {
        public BARCODE() {
            
        }
        public static string buildEan13(string code)
        {
            int isum = 0;
            int idigit = 0;
            for(int i=code.Length; i >= 1; i--)
            {
                idigit= Convert.ToInt32(code.Substring(i-1,1));
                if (i % 2 == 0)
                {
                    isum += idigit * 3;

                }
                else
                {
                    isum += idigit * 1;
                }
            }
            int checkSum =(10-(isum%10))%10;
            code += checkSum.ToString();
            return code;
        }
    }
}
