using System;
using System.Linq;

namespace SquareWithMaximumSum
{
    class SquareWithMaximumSum
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

            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                int[] colElements = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = colElements[j];
                }
            }

            int currSum = 0;
            int maxSum = int.MinValue;
            int maxRow = 0;
            int maxCol = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    currSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (currSum > maxSum)
                    {
                        maxSum = currSum;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }

            Console.WriteLine($"{matrix[maxRow, maxCol]} {matrix[maxRow, maxCol + 1]}");
            Console.WriteLine($"{matrix[maxRow + 1, maxCol]} {matrix[maxRow + 1, maxCol + 1]}");
            Console.WriteLine($"{maxSum}");
        }
    }
}
