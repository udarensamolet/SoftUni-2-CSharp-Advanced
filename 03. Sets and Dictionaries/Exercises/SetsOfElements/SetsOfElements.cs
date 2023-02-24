using System;
using System.Linq;
using System.Collections.Generic;

namespace SetsOfElements
{
    class SetsOfElements
    {
        static void Main()
        {
            int[] tokens = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int n = tokens[0];
            int m = tokens[1];

            HashSet<int> set1 = new HashSet<int>();
            HashSet<int> set2 = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                set1.Add(input);
            }
            for (int i = 0; i < m; i++)
            {
                int input = int.Parse(Console.ReadLine());
                set2.Add(input);
            }

            foreach (var item1 in set1)
            {
                foreach (var item2 in set2)
                {
                    if (item1 == item2)
                    {
                        Console.Write($"{item1} ");
                    }
                }
            }
        }
    }
}
