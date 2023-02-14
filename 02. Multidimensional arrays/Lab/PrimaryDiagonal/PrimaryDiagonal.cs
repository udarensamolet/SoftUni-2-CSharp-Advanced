using System;
using System.Linq;

namespace PrimaryDiagonal
{
    class PrimaryDiagonal
    {
        static void Main()
        {
            int d = int.Parse(Console.ReadLine());

            int[,] matrix = new int[d, d];
            for (int row = 0; row < d; row++)
            {
                int[] colElements = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < d; col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }

            int sumDiagonal = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row == col)
                    {
                        sumDiagonal += matrix[row, col];
                    }
                }
            }

            Console.WriteLine(sumDiagonal);
        }
    }
}
