using System;
using System.Linq;

namespace DiagonalDifference
{
    class DiagonalDifference
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            for (int row = 0; row < n; row++)
            {
                int[] colElements = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }

            int sumDiagonalFirst = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row == col)
                    {
                        sumDiagonalFirst += matrix[row, col];
                    }
                }
            }

            int sumDiagonalSecond = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                sumDiagonalSecond += matrix[row, n - row - 1];
            }

            Console.WriteLine(Math.Abs(sumDiagonalFirst - sumDiagonalSecond));
        }
    }
}
