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

        int maxElement = matrix[0, 0];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (matrix[i, j] > maxElement)
                {
                    maxElement = matrix[i, j];
                }
            }
        }

        int maxElementAbs = Math.Abs(maxElement);

        int[,] newMatrix = new int[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                newMatrix[i, j] = matrix[i, j] * maxElementAbs;
            }
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(newMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}