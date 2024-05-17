using System;

class Program
{
    static void Main()
    {
        float a;
        Console.Write("A:");
        a = float.Parse(Console.ReadLine());

        int n;
        Console.Write("N:");
        n = int.Parse(Console.ReadLine());

        float a2 = 1, rez = 1;

        for (int i = 2; i <= n; ++i)
        {
            a2 *= -a;
            rez += a2;
        }

        Console.WriteLine(rez);
    }
}