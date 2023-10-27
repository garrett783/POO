using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_2._4_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2.4
            int x = 100;
            Console.WriteLine(++x * 2);
            Console.ReadKey();

            //2.5
            x = 2;
            int y = 3;
            x *= y * 2;
            Console.WriteLine(x);
            Console.ReadKey();

            //2.6
            y = 4;
            x = (y -= 2);
            Console.WriteLine(x);
            x = y++;
            Console.WriteLine(x);
            x = y--;
            Console.WriteLine(x);
            Console.ReadKey();

            //2.7
            y = 5;
            x = ++y * 2;
            Console.WriteLine(x);
            x = y++;
            Console.WriteLine(x);
            x = y--;
            Console.WriteLine(x);
            Console.WriteLine(++y);
            Console.ReadKey();

            //2.8
            bool z;
            x = 1;
            y = 1;
            z = (y == 1 && x++ == 1);
            Console.WriteLine(z);
            
        }
    }
}
