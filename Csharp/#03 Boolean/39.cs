using System;

class Program
{
    static void Main()
    {
        int x1 = int.Parse(Console.ReadLine());
        int y1 = int.Parse(Console.ReadLine());
        int x2 = int.Parse(Console.ReadLine());
        int y2 = int.Parse(Console.ReadLine());

        Console.WriteLine(Math.Abs(x1 - x2) == Math.Abs(y1 - y2) || x1 == x2 || y1 == y2);
    }
}