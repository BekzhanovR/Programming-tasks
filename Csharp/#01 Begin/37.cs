using System;

class Program
{
    static void Main()
    {
        int v1 = int.Parse(Console.ReadLine());
        int v2 = int.Parse(Console.ReadLine());
        int s = int.Parse(Console.ReadLine());
        int t = int.Parse(Console.ReadLine());

        int result = s - ((v1 * t) + (v2 * t));
        Console.WriteLine(result);
    }
}