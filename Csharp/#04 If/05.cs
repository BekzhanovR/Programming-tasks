using System;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int s = 0; 

        if (a > 0)
        {
            s++;
        }
        if (b > 0)
        {
            s++;
        }
        if (c > 0)
        {
            s++;
        }

        Console.WriteLine(s);
        Console.WriteLine(3 - s);
    }
}