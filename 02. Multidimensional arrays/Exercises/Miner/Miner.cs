using System;
using System.Linq;

namespace Miner
{
    class Miner
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            string[] commands = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            int collectedCoalCount = 0;

            //populating the fields
            for (int row = 0; row < n; row++)
            {
                char[] colElements = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }

            //finding start position
            int minerRow = 0;
            int minerCol = 0;
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row, col] == 's')
                    {
                        minerRow = row;
                        minerCol = col;
                        break;
                    }
                }
            }

            //counting coals
            int totalCoalCount = 0;
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row, col] == 'c')
                    {
                        totalCoalCount++;
                    }
                }
            }

            bool isEnd = false;
            for (int i = 0; i < commands.Length; i++)
            {
                string command = commands[i];
                //moving the miner
                if (command == "left")
                {
                    if (minerCol - 1 >= 0)
                    {
                        minerCol--;
                    }
                }
                else if (command == "right")
                {
                    if (minerCol + 1 < matrix.GetLength(1))
                    {
                        minerCol++;
                    }
                }
                else if (command == "up")
                {
                    if (minerRow - 1 >= 0)
                    {
                        minerRow--;
                    }
                }
                else if (command == "down")
                {
                    if (minerRow + 1 < matrix.GetLength(0))
                    {
                        minerRow++;
                    }
                }

                //checking the char
                if (matrix[minerRow, minerCol] == 'c')
                {
                    collectedCoalCount++;
                    matrix[minerRow, minerCol] = '*';
                }
                if (matrix[minerRow, minerCol] == 'e')
                {
                    Console.WriteLine($"Game over! ({minerRow}, {minerCol})");
                    isEnd = true;
                    break;
                }
            }

            if (!isEnd)
            {
                if (collectedCoalCount == totalCoalCount)
                {
                    Console.WriteLine($"You collected all coals! ({minerRow}, { minerCol})");
                }
                if (totalCoalCount - collectedCoalCount > 0)
                {
                    Console.WriteLine($"{totalCoalCount - collectedCoalCount} coals left. ({minerRow}, {minerCol})");
                }
            }
        }
    }
}
