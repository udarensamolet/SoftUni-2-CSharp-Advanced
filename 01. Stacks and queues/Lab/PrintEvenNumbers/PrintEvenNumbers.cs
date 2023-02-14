using System;
using System.Linq;
using System.Collections.Generic;

namespace PrintEvenNumbers
{
    class PrintEvenNumbers
    {
        static void Main()
        {
            int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> que = new Queue<int>();

            for (int i = 0; i < input.Length; i++)
            {
                que.Enqueue(input[i]);
            }

            List<int> result = new List<int>();
            while (que.Count != 0)
            {
                int number = que.Peek();
                if (number % 2 == 0)
                {
                    result.Add(number);
                }
                que.Dequeue();
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
