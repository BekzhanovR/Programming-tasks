using System;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        if (Math.Abs(a - b) < Math.Abs(a - c))
        {
            Console.WriteLine(Math.Abs(a - b));
        }
        else
        {
            Console.WriteLine(Math.Abs(a - c));
        }
    }
}