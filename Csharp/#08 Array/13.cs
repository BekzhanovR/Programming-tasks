using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] A = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());

        int sum = 0;
        foreach (int element in A)
        {
            if (element >= c && element <= d)
            {
                sum += element;
            }
        }

        Console.WriteLine(sum);
    }
}
