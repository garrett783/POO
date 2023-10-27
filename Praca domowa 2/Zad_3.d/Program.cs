using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_3.d
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ile wiersz i kolumn ma mieć kwadrat?");
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
