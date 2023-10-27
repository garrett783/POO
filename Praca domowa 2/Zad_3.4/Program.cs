using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadz 1 licbzę");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("co chcesz zrobić? (+, -, *, /)");
            char znak = char.Parse(Console.ReadLine());
            Console.WriteLine("Wprowadz 2 liczbę");
            double y = double.Parse(Console.ReadLine());
            double wynik;

            switch (znak)
            {
                case '+':
                    wynik = x + y;
                    break;
                case '-':
                    wynik = x - y;
                    break;
                case '*':
                    wynik = x * y;
                    break;
                case '/':
                    if (y != 0)
                    {
                        wynik = x / y;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Nie można dzielić przez zero");
                        return; 
                    }
                default:
                    Console.WriteLine("Wprowadzono niepoprawny operator");
                    return;
            }
            Console.WriteLine(wynik);
        }
    }
}
