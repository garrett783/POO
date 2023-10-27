Console.WriteLine("Wprowadź liczbę całkowitą");
int x = int.Parse(Console.ReadLine());
string odpowiedz = (x % 2 == 0) ? "jest liczbą parzystą " : "jest liczbą nieparzystą ";
odpowiedz += (x >= 0) ? "dodatnią" : "ujemną";
Console.WriteLine($"{x} {odpowiedz}");