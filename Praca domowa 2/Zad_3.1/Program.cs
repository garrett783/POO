﻿Console.WriteLine("Podaj rok");
int rok = Convert.ToInt32(Console.ReadLine());
if (rok % 4 == 0 && (rok % 100 != 0 || rok % 400 == 0))
{
    Console.WriteLine("Rok jest przestępny");
}
else
{
    Console.WriteLine("Rok nie jest przestępny");
}
