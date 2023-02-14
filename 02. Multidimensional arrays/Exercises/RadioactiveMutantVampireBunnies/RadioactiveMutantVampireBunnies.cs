using System;
using System.Linq;

namespace RadioactiveMutantVampireBunnies
{
    class RadioactiveMutantVampireBunnies
    {
        static void Main()
        {
            int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rows = input[0];
            int cols = input[1];
            char[,] matrix = new char[rows, cols];
            //populating the matrix
            for (int row = 0; row < rows; row++)
            {
                string colElements = Console.ReadLine();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }

            //finding start position of player
            int playerRow = 0;
            int playerCol = 0;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (matrix[row, col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                        break;
                    }
                }
            }

            bool isPlayerDead = false;
            bool isPlayerOut = false;
            char[] commands = Console.ReadLine().ToCharArray();
            for (int i = 0; i < commands.Length; i++)
            {
                char command = commands[i];

                //moving the player
                matrix[playerRow, playerCol] = '.';
                if (command == 'L')
                {
                    if (playerCol - 1 >= 0)
                    {
                        playerCol--;
                    }
                    else
                    {
                        isPlayerOut = true;
                    }
                }
                else if (command == 'R')
                {
                    if (playerCol + 1 < matrix.GetLength(1))
                    {
                        playerCol++;
                    }
                    else
                    {
                        isPlayerOut = true;
                    }
                }
                else if (command == 'U')
                {
                    if (playerRow - 1 >= 0)
                    {
                        playerRow--;
                    }
                    else
                    {
                        isPlayerOut = true;
                    }
                }
                else if (command == 'D')
                {
                    if (playerRow + 1 < matrix.GetLength(0))
                    {
                        playerRow++;
                    }
                    else
                    {
                        isPlayerOut = true;
                    }
                }

                //check if player hits bunny
                if (!isPlayerOut)
                {
                    if (matrix[playerRow, playerCol] == '.')
                    {
                        matrix[playerRow, playerCol] = 'P';
                    }
                    else
                    {
                        isPlayerDead = true;
                    }
                }

                //populating the bunnies 
                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        if (matrix[row, col] == 'B')
                        {
                            if (row - 1 >= 0)
                            {
                                if (matrix[row - 1, col] == '.')
                                {
                                    matrix[row - 1, col] = 'A';
                                }
                                else if (matrix[row - 1, col] == 'P')
                                {
                                    matrix[row - 1, col] = 'A';
                                    isPlayerDead = true;
                                }
                            }
                            if (row + 1 < rows)
                            {
                                if (matrix[row + 1, col] == '.')
                                {
                                    matrix[row + 1, col] = 'A';
                                }
                                else if (matrix[row + 1, col] == 'P')
                                {
                                    matrix[row + 1, col] = 'A';
                                    isPlayerDead = true;
                                }
                            }
                            if (col - 1 >= 0)
                            {
                                if (matrix[row, col - 1] == '.')
                                {
                                    matrix[row, col - 1] = 'A';
                                }
                                else if (matrix[row, col - 1] == 'P')
                                {
                                    matrix[row, col - 1] = 'A';
                                    isPlayerDead = true;
                                }
                            }
                            if (col + 1 < cols)
                            {
                                if (matrix[row, col + 1] == '.')
                                {
                                    matrix[row, col + 1] = 'A';
                                }
                                else if (matrix[row, col + 1] == 'P')
                                {
                                    matrix[row, col + 1] = 'A';
                                    isPlayerDead = true;
                                }
                            }
                        }
                    }
                }

                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        if (matrix[row, col] == 'A')
                        {
                            matrix[row, col] = 'B';
                        }
                    }
                }

                if (isPlayerDead || isPlayerOut)
                {
                    break;
                }
            }

            PrintMatrix(matrix);

            if (isPlayerDead)
            {
                Console.WriteLine($"dead: {playerRow} {playerCol}");
            }
            else
            {
                Console.WriteLine($"won: {playerRow} {playerCol}");
            }
        }
        static void PrintMatrix(char[,] matrix)
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
