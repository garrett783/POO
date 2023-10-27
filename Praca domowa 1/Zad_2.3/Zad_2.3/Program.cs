using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double wzrost, waga, BMI;
            Console.WriteLine("Podaj swój wzrost:");
            wzrost = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj swoją wagę:");
            waga = double.Parse(Console.ReadLine());
            BMI = waga / Math.Pow(wzrost, 2);
            Console.WriteLine("Twój wskaźnim masy ciała BMI wynosi: " + BMI);
            Console.ReadKey();
        }
    }
}
