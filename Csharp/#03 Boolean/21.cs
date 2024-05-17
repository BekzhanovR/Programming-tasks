using System;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());

        int x = a / 100;
        int y = (a % 100) / 10;
        int z = a % 10;

        Console.WriteLine(x < y && y < z);
    }
}