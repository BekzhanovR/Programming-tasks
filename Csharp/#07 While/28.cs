using System;

class Program
{
    static void Main()
    {
        Console.Write("e: ");
        float e = float.Parse(Console.ReadLine());
        
        float ak1 = 0, ak = 2;
        int k = 1;

        while (Math.Abs(ak - ak1) >= e)
        {
            ++k;
            ak1 = ak;
            ak = 2 + 1 / ak1;
        }

        Console.WriteLine($"K= {k}, A(k-1)= {ak1}, A(k)= {ak}");
    }
}
