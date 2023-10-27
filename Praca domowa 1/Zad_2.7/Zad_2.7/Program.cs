using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_2._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y = 5;
            x = ++y * 2;
            Console.WriteLine(x);
            x = y++;
            Console.WriteLine(x);
            x = y--;
            Console.WriteLine(x);
            Console.WriteLine(++y);
        }
    }
}
