using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] A = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int c = int.Parse(Console.ReadLine());

        int d = int.Parse(Console.ReadLine());

        int M = int.Parse(Console.ReadLine());

        var positiveElements = A.Where(element => element >= c && element <= d && element > 0).ToList();

        if (positiveElements.Count < M)
        {
            Console.WriteLine("Error");
            return;
        }

        int sum = positiveElements.Skip(positiveElements.Count - M).Sum();

        Console.WriteLine(sum);
    }
}