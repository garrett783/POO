using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_3._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, suma = 0;
            do
            {
                Console.WriteLine("Podaj liczbe całkowitą");
                x = int.Parse(Console.ReadLine());
                suma += x;
            } while (x != 0);
            Console.WriteLine("Suma wprowadzonych liczb wynosi: " + suma);
        }
    }
}
