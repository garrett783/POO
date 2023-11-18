using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe elementow tablicy");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] tab = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Wprowadz {0} element tablicy", i + 1);
                tab[i] = Convert.ToDouble(Console.ReadLine());
            }

            foreach (var item in tab)
            {
                Console.Write(item + " ");
            }
        }
    }
}
