using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_3._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1, i = 0;
            while (x <= 100)
            {
                x += i;
                i++;
                Console.WriteLine("Liczba nr " + i + ", suma = " + x);
            }
            Console.WriteLine("Aby suma przekroczyła 100 należy dodać do siebie " + i + " kolejnych liczb.");
        }
    }
}
