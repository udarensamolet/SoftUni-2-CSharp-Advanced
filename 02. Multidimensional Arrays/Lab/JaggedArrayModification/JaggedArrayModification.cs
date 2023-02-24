using System;
using System.Linq;

namespace JaggedArrayModification
{
    class JaggedArrayModification
    {
        static void Main()
        {
            int d = int.Parse(Console.ReadLine());

            int[,] matrix = new int[d, d];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] colElements = Console.ReadLine()
                                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = colElements[j];
                }
            }

            string[] tokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (tokens[0] != "END")
            {
                string command = tokens[0];
                int row = Convert.ToInt32(tokens[1]);
                int col = Convert.ToInt32(tokens[2]);
                int value = Convert.ToInt32(tokens[3]);


                if (row >= matrix.GetLength(0) || col >= matrix.GetLength(1)
                    || row < 0 || col < 0)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else
                {
                    if (command == "Add")
                    {
                        matrix[row, col] += value;
                    }
                    else if (command == "Subtract")
                    {
                        matrix[row, col] -= value;
                    }
                }
                

                tokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }

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
