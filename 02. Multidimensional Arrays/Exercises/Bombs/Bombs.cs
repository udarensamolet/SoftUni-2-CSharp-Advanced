using System;
using System.Linq;

namespace Bombs
{
    class Bombs
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            if (n > 0)
            {
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
                string[] indexes = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int i = 0; i < indexes.Length; i++)
                {
                    int[] tokens = indexes[i]
                        .Split(',', StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();
                    int row = tokens[0];
                    int col = tokens[1];

                    int bombValue = matrix[row, col];
                    if (bombValue > 0)
                    {
                        if (row - 1 >= 0 && col - 1 >= 0)
                        {
                            if (matrix[row - 1, col - 1] > 0)
                            {
                                matrix[row - 1, col - 1] -= bombValue;
                            }
                        }
                        if (row - 1 >= 0)
                        {
                            if (matrix[row - 1, col] > 0)
                            {
                                matrix[row - 1, col] -= bombValue;
                            }
                        }
                        if (row - 1 >= 0 && col + 1 < matrix.GetLength(1))
                        {
                            if (matrix[row - 1, col + 1] > 0)
                            {
                                matrix[row - 1, col + 1] -= bombValue;
                            }
                        }
                        if (col - 1 >= 0)
                        {
                            if (matrix[row, col - 1] > 0)
                            {
                                matrix[row, col - 1] -= bombValue;
                            }
                        }
                        if (col + 1 < matrix.GetLength(1))
                        {
                            if (matrix[row, col + 1] > 0)
                            {
                                matrix[row, col + 1] -= bombValue;
                            }
                        }
                        if (row + 1 < matrix.GetLength(0) && col - 1 >= 0)
                        {
                            if (matrix[row + 1, col - 1] > 0)
                            {
                                matrix[row + 1, col - 1] -= bombValue;
                            }
                        }
                        if (row + 1 < matrix.GetLength(0))
                        {
                            if (matrix[row + 1, col] > 0)
                            {
                                matrix[row + 1, col] -= bombValue;
                            }
                        }
                        if (row + 1 < matrix.GetLength(0) && col + 1 < matrix.GetLength(1))
                        {
                            if (matrix[row + 1, col + 1] > 0)
                            {
                                matrix[row + 1, col + 1] -= bombValue;
                            }
                        }
                        matrix[row, col] = 0;
                    }
                }

                SumAndCountAliveElements(matrix);
                PrintMatrix(matrix);
            }
            else
            {
                Console.WriteLine($"Alive cells: 0");
                Console.WriteLine($"Sum: 0");
            }
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }

        static void SumAndCountAliveElements(int[,] matrix)
        {
            int sum = 0;
            int count = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] > 0)
                    {
                        sum += matrix[row, col];
                        count++;
                    }
                }
            }
            Console.WriteLine($"Alive cells: {count}");
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
