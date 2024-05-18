using System;

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

        int sumOfMinElements = 0;
        int[] minElementCoordinates = new int[columns]; 

        for (int j = 0; j < columns; j++)
        {
            int minElement = matrix[0, j];
            int minRowIndex = 0; 
            
            for (int i = 1; i < rows; i++)
            {
                if (matrix[i, j] < minElement)
                {
                    minElement = matrix[i, j];
                    minRowIndex = i;
                }
            }

            sumOfMinElements += minElement;
            
            minElementCoordinates[j] = minRowIndex;
        }

        Console.WriteLine(sumOfMinElements);
        for (int j = 0; j < columns; j++)
        {
            Console.WriteLine(minElementCoordinates[j]);
        }
    }
}