using System;

class Program
{
    static void Main()
    {
        Console.Write();
        int A = int.Parse(Console.ReadLine());
        Console.Write();
        int B = int.Parse(Console.ReadLine());

        long totalProduct = 1;
        for (int num = A; num <= B; num++)
        {
            totalProduct *= num;
        }

        Console.WriteLine(totalProduct);
    }
}