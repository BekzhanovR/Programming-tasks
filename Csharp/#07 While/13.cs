using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("A:");
        float a = float.Parse(Console.ReadLine());

        int k = 0;
        float temp = 0;
        while (temp <= a)
        {
            ++k;
            temp += 1 / (float)k;
        }
        Console.WriteLine(k);
        Console.WriteLine(temp);
    }
}