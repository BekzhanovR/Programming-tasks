using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int xy = n / 10;
        int z = n % 10;

        int result = z * 100 + xy;
        Console.WriteLine(result);
    }
}