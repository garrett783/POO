using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_2._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int powierzchnia = 100, osoby = 10;
            double gestoscZaludnienia = osoby / powierzchnia;
            Console.WriteLine(gestoscZaludnienia);
            Console.ReadKey();

            // po zmianie
            gestoscZaludnienia = (double)osoby / powierzchnia;
            Console.WriteLine(gestoscZaludnienia);
        }
    }
}
