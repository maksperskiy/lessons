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
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };
            
            string str = "5";

            int a = int.Parse(str);
            Console.WriteLine(a + 5);
            
            str = "5,6";
            double b = double.Parse(str);
            Console.WriteLine(b - 1);

            str = "5.6";
            b = double.Parse(str, numberFormatInfo);
            Console.WriteLine(b + 1);

            str = "5,4";
            double.TryParse(str, out b);
            // если не парсит, то 0, иначе value. Look's like a little bit пиздато
            Console.WriteLine(b != 0 ? b.ToString() : "lol"); 

        }
    }
}
