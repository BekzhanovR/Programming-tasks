using System;

class Program
{
    static void Main()
    {
        Console.Write("K:");
        int K = int.Parse(Console.ReadLine());
        Console.WriteLine();
        
        Console.Write("N:");
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine();

        N = N - 2;
        int m = ((K + N) % 7) + 1;
        Console.WriteLine(m);
    }
}
