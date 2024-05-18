using System;

class Program
{
    static void Main()
    {
        int N;
        int R = 0;
        N = int.Parse(Console.ReadLine());
        while (N > 0)
        {
            int M = N % 10;
            R = R * 10 + M;
            N /= 10;
        }
        Console.WriteLine(R);
    }
}