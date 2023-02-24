using System;
using System.Linq;

namespace JaggedArrayManipulator
{
    class JaggedArrayManipulator
    {
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            double[][] matrix = new double[rows][];
            for (int row = 0; row < rows; row++)
            {
                matrix[row] = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();
            }

            for (int row = 0; row < rows - 1; row++)
            {
                if (matrix[row].Length == matrix[row + 1].Length)
                {
                    for (int i = 0; i < matrix[row].Length; i++)
                    {
                        matrix[row][i] *= 2;
                        matrix[row + 1][i] *= 2;
                    }
                }
                else
                {
                    for (int i = 0; i < matrix[row].Length; i++)
                    {
                        matrix[row][i] /= 2;
                    }
                    for (int i = 0; i < matrix[row + 1].Length; i++)
                    {
                        matrix[row + 1][i] /= 2;
                    }
                }
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    PrintJaggedArray(matrix);
                    break;
                }

                string[] tokens = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string command = tokens[0];
                int row = Convert.ToInt32(tokens[1]);
                int col = Convert.ToInt32(tokens[2]);
                int value = Convert.ToInt32(tokens[3]);

                if (command == "Add")
                {
                    if (row >= 0 && row < rows && col >= 0 && col <= matrix[row].Length - 1)
                    {
                        matrix[row][col] += value;
                    }
                }
                else if (command == "Subtract") 
                {
                    if (row >= 0 && row < rows && col >= 0 && col <= matrix[row].Length - 1)
                    {
                        matrix[row][col] -= value;
                    }
                }


            }

        }

        static void PrintJaggedArray(double[][] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write($"{matrix[row][col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
