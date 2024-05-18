using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        
        int columns = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            for (int j = 0; j < columns; j++)
            {
                matrix[i, j] = int.Parse(input[j]);
            }
        }

        Dictionary<int, int> elementCount = new Dictionary<int, int>();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                int element = matrix[i, j];
                if (elementCount.ContainsKey(element))
                {
                    elementCount[element]++;
                }
                else
                {
                    elementCount[element] = 1;
                }
            }
        }

        int? minRepeated = null;

        foreach (var pair in elementCount)
        {
            if (pair.Value > 1)
            {
                if (minRepeated == null || pair.Key < minRepeated)
                {
                    minRepeated = pair.Key;
                }
            }
        }

        if (minRepeated.HasValue)
        {
            Console.WriteLine(minRepeated.Value);
        }
        else
        {
            Console.WriteLine("Minimal sani joq");
        }
    }
}