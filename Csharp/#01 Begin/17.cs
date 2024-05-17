using System;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        int ac = Math.Abs(a - c);
        int bc = Math.Abs(b - c);

        Console.WriteLine(ac + bc);
    }
}