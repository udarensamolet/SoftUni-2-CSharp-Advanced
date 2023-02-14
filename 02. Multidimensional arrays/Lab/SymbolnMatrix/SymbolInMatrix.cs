using System;
using System.Linq;

namespace SymbolnMatrix
{
    class SymbolnMatrix
    {
        static void Main()
        {
            int d = int.Parse(Console.ReadLine());

            char[,] matrix = new char[d, d];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string colElements = Console.ReadLine();
                for (int col = 0; col < colElements.Length; col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }

            char symbol = char.Parse(Console.ReadLine());
            bool symbolPresent = false;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == symbol)
                    {
                        symbolPresent = true;
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                }
            }

            if (symbolPresent == false)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}
