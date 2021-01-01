using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            //Convertation WAOW!
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",//Цудоуна
            };
            string str = "1", str2 = "2";

            int a = Convert.ToInt32(str);
            int b = Convert.ToInt32(str2);
            Console.WriteLine(a + b);

            str = "1.5";

            Console.WriteLine(Convert.ToDouble(str, numberFormatInfo));


        }
    }
}
