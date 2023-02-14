using System;
using System.Linq;

namespace SumMatrixElements
{
    class SumMatrixElements
    {
        static void Main()
        {
            int[] tokens = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rows = tokens[0];
            int cols = tokens[1];

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {

                int[] colElements = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = colElements[j];
                }
            }

            int sum = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    sum += matrix[i, j];
                }
            }

            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(sum);
        }
    }
}
