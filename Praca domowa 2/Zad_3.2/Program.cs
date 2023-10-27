using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj 2 liczby");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            if (a % b == 0)
            {
                Console.WriteLine("liczba {1} jest dzielnikiem liczby {0}", a, b);
            }
            else
            {
                Console.WriteLine("liczba {1} nie jest dzielnikiem liczby {0}", a, b);
            }
        }
    }
}
