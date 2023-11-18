using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę elementów");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] tab = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Wprowadź {0} element");
                tab[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine(tab.Max());
            Console.WriteLine(tab.Min());
            Console.WriteLine(tab.Average());
            int liczba = 0;
            for (int i = 0;i < n; i++)
            {
                if (tab[i] >= 0)
                {
                    liczba++;
                }
            }
            Console.WriteLine(liczba);
        }
    }
}
