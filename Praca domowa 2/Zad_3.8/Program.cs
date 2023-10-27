using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_3._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj średnią ocen");
            double srednia = Convert.ToDouble(Console.ReadLine());
            if (srednia >= 2 && srednia < 4)
            {
                Console.WriteLine("Kwota stypendium wynosi 0.00 zł");
            }
            else if (srednia >= 4 && srednia < 4.8)
            {
                Console.WriteLine("Kwota stypendium wynosi 350,00 zł");
            }
            else if (srednia >= 4.8 && srednia <= 5)
            {
                Console.WriteLine("Kwota stypendium wynosi  550,00 zł");
            }
            else 
            { 
                Console.WriteLine("Podano niewłaściwą wartość"); 
            }
        }
    }
}
