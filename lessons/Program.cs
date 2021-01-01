using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            byte bytik = 1; //1 байт от 0 до 255
            byte sbytik = 1; //1 байт от -128 до 127
            byte shortik = 1; //2 байт от -32768 до 32767
            byte ushortik = 1; //2 байт от 0 до 65535
            byte intik = 1; //4 байт от -2млрд до 2млрд
            byte uintik = 1; //4 байт от 0 до 4млрд
            byte longik = 1; //8 байт от -дохуя до дохуя
            byte ulongik = 1; //8 байт от 0 до хуя


            Console.WriteLine(Console.ReadLine()/*так можно lulw*/ + bytik + sbytik + shortik + ushortik + intik + uintik + longik + ulongik);
        }
    }
}
