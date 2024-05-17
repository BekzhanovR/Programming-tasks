using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("N:");
        int n = int.Parse(Console.ReadLine());

        float a1 = 1, a2 = 2;
        Console.Write(a1 + " ");
        Console.Write(a2 + " ");

        float ak;
        for (int i = 3; i <= n; ++i)
        {
            ak = (a1 + 2 * a2) / 3;
            Console.Write(i + " " + ak + " ");
            a1 = a2;
            a2 = ak;
        }
    }
}