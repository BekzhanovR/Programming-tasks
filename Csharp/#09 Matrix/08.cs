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
        
        for (int i = 0; i < rows; i++)
        {
            int sum = 0;
            for (int j = 0; j < columns; j++)
            {
                if (matrix[i, j] > 0 && matrix[i, j] % 2 == 0)
                {
                    sum += matrix[i, j];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
