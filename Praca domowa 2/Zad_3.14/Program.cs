using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_3._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę całkowitą, aby sprawdzić czy jest doskonała");
            int n, suma = 0;
            n = int.Parse(Console.ReadLine());
            for (int i = n - 1; i > 0; i--)
            {
                if (n % i == 0)
                {
                    suma += i;
                }
            }
            if (n == suma)
            {
                Console.WriteLine("Liczba jest doskonała");
            }
            else
            {
                Console.WriteLine("Liczba nie jest doskonała");
            }
        }
    }
}
