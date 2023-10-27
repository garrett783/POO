using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_3._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj współczynniki równania, kolejno, a, b, c");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double delta = Math.Pow(b, 2) - 4 * a * c;
            if (delta > 0)
            {
                Console.WriteLine("Równanie ma 2 pierwiastki");
            }
            else if (delta == 0)
            {
                Console.WriteLine("Równanie ma 1 pierwiastek");
            }
            else
            {
                Console.WriteLine("Równanie nie ma pierwiastków");
            }
        }
    }
}
