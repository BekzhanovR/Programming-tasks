using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("X:");
        float x = float.Parse(Console.ReadLine());

        Console.WriteLine("N:");
        int n = int.Parse(Console.ReadLine());

        float x1 = x, rez = x;

        for (int i = 2; i <= n; ++i)
        {
            x1 *= -1 * x;
            rez += x1 / i;
        }
        Console.WriteLine(rez);
    }
}