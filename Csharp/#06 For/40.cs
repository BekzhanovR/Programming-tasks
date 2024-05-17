using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("A:");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("B:");
        int b = int.Parse(Console.ReadLine());

        for (int i = 1; i <= b - a + 1; ++i)
        {
            for (int j = 1; j <= i; ++j)
            {
                Console.Write(a + i - 1 + " ");
            }
        }
    }
}