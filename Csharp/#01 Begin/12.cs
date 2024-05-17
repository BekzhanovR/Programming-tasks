using System;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        double c = Math.Sqrt(a * a + b * b);

        Console.WriteLine(c);
        Console.WriteLine(a + b + c);
    }
}
