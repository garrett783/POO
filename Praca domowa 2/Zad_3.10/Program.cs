using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_3._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę");
            double x, y = 1;
            x = Convert.ToDouble(Console.ReadLine());
            for (int i = 1; i <= x; i++)
            {
                y *= i;
            }
            Console.WriteLine(y);
        }
    }
}
