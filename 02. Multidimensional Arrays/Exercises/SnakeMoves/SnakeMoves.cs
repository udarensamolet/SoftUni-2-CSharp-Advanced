using System;
using System.Text;
using System.Linq;

namespace SnakeMoves
{
    class SnakeMoves
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

            string snake = Console.ReadLine();

            int lentgthWholeSnake = rows * cols;
            int snakeLength = snake.Length;
            string wholeSnake = null;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < lentgthWholeSnake / snakeLength; i++)
            {
                sb.Append(snake);
            }
            for (int i = 0; i < lentgthWholeSnake - ((lentgthWholeSnake / snakeLength) * snakeLength); i++)
            {
                sb.Append(snake[i]);
            }
            wholeSnake = sb.ToString();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        string element = wholeSnake.Substring(0, 1);
                        wholeSnake = wholeSnake.Remove(0, 1);
                        matrix[row, col] = element;
                    }
                }
                else
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        string element = wholeSnake.Substring(0, 1);
                        wholeSnake = wholeSnake.Remove(0, 1);
                        matrix[row, col] = element;
                    }
                }
            }

            PrintMatrix(matrix);

        }
        static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]}");
                }
                Console.WriteLine();
            }
        }
    }
}
