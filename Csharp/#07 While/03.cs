using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("N:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("K:");
        int k = int.Parse(Console.ReadLine());

        int num = 0;
        while (n >= k)
        {
            n -= k;
            ++num;
        }
        Console.WriteLine(num);
        Console.WriteLine(n);
    }
}