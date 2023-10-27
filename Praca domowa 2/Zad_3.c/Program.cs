using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_3.c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dlug = 80, zJ = 50, zK = 40, odlozone = 0;
            int i = 0;
            do
            {
                odlozone += 0.2 * zJ + 0.2 * zK;
                Console.WriteLine("Dzień {0}, Spłata = {1}", i++, odlozone);
            } while (dlug > odlozone);
        }
    }
}
