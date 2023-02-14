using System;
using System.Linq;

namespace SumMatrixColumns
{
    class SumMatrixColumns
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
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = colElements[j];
                }
            }

          
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int sumCol = 0;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sumCol += matrix[row, col];
                }
                Console.WriteLine(sumCol);
            }


        }
    }
}
