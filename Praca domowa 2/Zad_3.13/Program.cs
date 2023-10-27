using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_3._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę naturalną");
            int x, suma = 0;
            x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= x; i++)
            {
                if (i % 2 != 0) 
                {
                    suma += i; 
                }
                else
                {
                    suma -= i;
                }
            }
            Console.WriteLine(suma);
        }
    }
}
