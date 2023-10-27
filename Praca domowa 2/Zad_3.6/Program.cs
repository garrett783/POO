using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_3._6
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Podaj swoją masę w kg:");
            double masa = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj swój wzrost w metrach");
            double wzrost = double.Parse(Console.ReadLine());
            double BMI = masa / Math.Pow(wzrost, 2);
            if (BMI < 16)
            {
                Console.WriteLine("wygłodzenie");
            }
            else if (BMI >= 16 && BMI < 17)
            {
                Console.WriteLine("wychudzenie");
            }
            else if (BMI >= 17 && BMI < 18.5)
            {
                Console.WriteLine("niedowaga");
            }
            else if (BMI >= 18.5 && BMI < 25)
            {
                Console.WriteLine("pożądana masa ciała");
            }
            else if (BMI >= 25 && BMI < 30)
            {
                Console.WriteLine("nadwaga");
            }
            else if (BMI >= 30 && BMI < 35)
            {
                Console.WriteLine("otyłość I stopnia");
            }
            else if (BMI >= 35 && BMI < 40)
            {
                Console.WriteLine("otyłość II stopnia");
            }
            else { Console.WriteLine("otyłość III stopnia"); }
        }
    }
}
