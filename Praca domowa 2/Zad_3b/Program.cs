Console.WriteLine("Wporwadź 2 liczby całkowite");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Liczby parzyste to:");
for (int i = x;  i <= y; i++)
{
    if (i % 2 == 0)
        Console.Write(i + ", ");
}