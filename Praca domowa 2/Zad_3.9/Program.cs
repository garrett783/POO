using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_3._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę wierszy");
            int ilosc = int.Parse(Console.ReadLine());
            int i = 0;
            string star = "";
            while (i < ilosc)
            {
                Console.WriteLine(star += "*");
                i++;
            }
            Console.WriteLine();
            while(i != 0)
            {
                Console.WriteLine(star);
                star = star.Substring(0, star.Length - 1);
                i--;
            }
            Console.WriteLine();
            while (i < ilosc)
            {
                for (int j = 0; j < ilosc - (i + 1); j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < (i + 1); k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
                i++;
            }
            Console.WriteLine();
            for (int j = 0; j < ilosc; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            for (int j = 0; j < ilosc - 2; j++)
            {
                Console.Write("*");
                for (int k = 0; k < ilosc - 2; k++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                Console.WriteLine();
            }
            for (int j = 0; j < ilosc; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
