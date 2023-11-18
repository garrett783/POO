using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] tab1 = new double[10] { 1, -2, 3, 4, -5, 6, 7, -8, 9, 10 };
            double[] tab2 = new double[10];

            for (int i = 0; i < 10; i++)
            {
                if (tab1[i] >= 0)
                {
                    tab2[i] = tab1[i];
                }
            }

            foreach (var item in tab2)
            {
                Console.Write(item + " ");
            }

        }
    }
}
