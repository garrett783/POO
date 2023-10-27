using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta;
            Console.WriteLine("Wprowadź współczynnik 'a'");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wprowadź współczynnik 'b'");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wprowadź współczynnik 'c'");
            c = Convert.ToDouble(Console.ReadLine());
            delta = Math.Pow(b, 2) - 4 * a * c;
            Console.WriteLine("delta wyinosi: " +  delta);
            Console.ReadKey();
        }
    }
}
