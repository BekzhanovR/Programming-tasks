using System;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine(Math.Pow(a, 2));
        Console.WriteLine(Math.Pow(a, 3));
        Console.WriteLine(Math.Pow(a, 5));
        Console.WriteLine(Math.Pow(a, 10));
        Console.WriteLine(Math.Pow(a, 15));
    }
}