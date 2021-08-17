using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Masterkurs.Modul25_LINQ
{
    public class Extension_Methods
    {
        public Extension_Methods()
        {
            string num1 = "2021";
            int num2 = num1.ToInt() + 2;

            Console.WriteLine(num2);
        }
    }

    public static class StringExtensions
    {
        public static int ToInt(this String str)
        {
            return Convert.ToInt32(str);
        }
    }
}
