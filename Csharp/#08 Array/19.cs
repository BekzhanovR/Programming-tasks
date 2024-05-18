using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] A = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int sumOfSquares = 0;
        foreach (int element in A)
        {
            if (element > 0)
            {
                sumOfSquares += element * element;
            }
        }

        Console.WriteLine(sumOfSquares);
    }
}