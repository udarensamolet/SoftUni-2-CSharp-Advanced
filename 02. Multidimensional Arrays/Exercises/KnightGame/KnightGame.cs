using System;
using System.Linq;

namespace KnightGame
{
    class KnightGame
    {
        static void Main()
        {
            int k = int.Parse(Console.ReadLine());
            char[,] board = new char[k, k];
            for (int row = 0; row < k; row++)
            {
                char[] rowElements = Console.ReadLine().ToCharArray();
                for (int col = 0; col < k; col++)
                {
                    board[row, col] = rowElements[col];
                }
            }

            int minKnightsRemoved = 0;
            bool safeBoard = false;

            while (!safeBoard)
            {
                int maxHits = int.MinValue;
                int maxHitsRow = 0;
                int maxHitsCol = 0;
                for (int row = 0; row < board.GetLength(0); row++)
                {
                    for (int col = 0; col < board.GetLength(1); col++)
                    {
                        int hits = 0;
                        if (board[row, col] == 'K')
                        {
                            if (row - 2 >= 0 && col - 1 >= 0)
                            {
                                if (board[row - 2, col - 1] == 'K')
                                {
                                    hits++;
                                }
                            }
                            if (row - 2 >= 0 && col + 1 < board.GetLength(1))
                            {
                                if (board[row - 2, col + 1] == 'K')
                                {
                                    hits++;
                                }
                            }
                            if (row - 1 >= 0 && col - 2 >= 0)
                            {
                                if (board[row - 1, col - 2] == 'K')
                                {
                                    hits++;
                                }
                            }
                            if (row - 1 >= 0 && col + 2 < board.GetLength(1))
                            {
                                if (board[row - 1, col + 2] == 'K')
                                {
                                    hits++;
                                }
                            }
                            if (row + 1 < board.GetLength(0) && col - 2 >= 0)
                            {
                                if (board[row + 1, col - 2] == 'K')
                                {
                                    hits++;
                                }
                            }
                            if (row + 1 < board.GetLength(0) && col + 2 < board.GetLength(1))
                            {
                                if (board[row + 1, col + 2] == 'K')
                                {
                                    hits++;
                                }
                            }
                            if (row + 2 < board.GetLength(0) && col - 1 >= 0)
                            {
                                if (board[row + 2, col - 1] == 'K')
                                {
                                    hits++;
                                }
                            }
                            if (row + 2 < board.GetLength(0) && col + 1 < board.GetLength(1))
                            {
                                if (board[row + 2, col + 1] == 'K')
                                {
                                    hits++;
                                }
                            }

                            if (hits > maxHits)
                            {
                                maxHits = hits;
                                maxHitsRow = row;
                                maxHitsCol = col;
                            }

                            if (maxHits == 0)
                            {
                                safeBoard = true;
                            }
                            else
                            {
                                safeBoard = false;
                            }
                        }
                    }
                }

                if (!safeBoard)
                {
                    board[maxHitsRow, maxHitsCol] = '0';
                    minKnightsRemoved++;
                }
            }
            Console.WriteLine(minKnightsRemoved);

        }
    }
}