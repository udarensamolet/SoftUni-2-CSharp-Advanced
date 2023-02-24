using System;
using System.Numerics;
using System.Linq;

namespace PascalTriangle
{
    class PascalTriangle
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger[][] triangle = new BigInteger[n][];

            if (n == 1)
            {
                triangle[0] = new BigInteger[1];
                triangle[0][0] = 1;
                Console.WriteLine(triangle[0][0]);
            }
            else if (n == 2)
            {
                triangle[1] = new BigInteger[2];
                triangle[1][0] = 1;
                triangle[1][1] = 1;
                Console.WriteLine($"{triangle[1][0]} {triangle[1][1]}");
            }
            else
            {
                triangle[0] = new BigInteger[1];
                triangle[0][0] = 1;
                triangle[1] = new BigInteger[2];
                triangle[1][0] = 1;
                triangle[1][1] = 1;
                for (int row = 2; row < n; row++)
                {
                    triangle[row] = new BigInteger[row + 1];
                    triangle[row][0] = 1;

                    for (int col = 1; col <= row - 1; col++)
                    {
                        triangle[row][col] = triangle[row - 1][col - 1] + triangle[row - 1][col];
                    }
                    triangle[row][row] = 1;
                }

                for (int row = 0; row < triangle.GetLength(0); row++)
                {
                    for (int col = 0; col < triangle[row].Length; col++)
                    {
                        Console.Write($"{triangle[row][col]} ");
                    }
                    Console.WriteLine();
                }
            } 
        }
    }
}
