using System;
using System.Linq;

namespace MatrixShuffling
{
    class MatrixShuffling
    {
        static void Main()
        {
            int[] dimensions = Console.ReadLine()
               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            string[,] matrix = new string[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            while (true)
            {
                string[] tokens = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (tokens[0] == "END")
                {
                    break;
                }

                string command = tokens[0];
                if (command == "swap" && tokens.Length == 5)
                {
                    int row1 = Convert.ToInt32(tokens[1]);
                    int col1 = Convert.ToInt32(tokens[2]);
                    int row2 = Convert.ToInt32(tokens[3]);
                    int col2 = Convert.ToInt32(tokens[4]);

                    if (row1 < matrix.GetLength(0) && row2 < matrix.GetLength(0)
                        && col1 < matrix.GetLength(1) && col2 < matrix.GetLength(1))
                    {
                        string tempElement = matrix[row1, col1];
                        matrix[row1, col1] = matrix[row2, col2];
                        matrix[row2, col2] = tempElement;

                        PrintMatrix(matrix);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }

        static void PrintMatrix(string[,] matrix)
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
    }
}
