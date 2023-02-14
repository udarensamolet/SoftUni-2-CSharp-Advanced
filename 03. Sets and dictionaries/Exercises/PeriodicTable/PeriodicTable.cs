using System;
using System.Linq;
using System.Collections.Generic;

namespace PeriodicTable
{
    class PeriodicTable
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            SortedSet<string> elements = new SortedSet<string>();
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                for (int j = 0; j < tokens.Length; j++)
                {
                    string element = tokens[j];
                    elements.Add(element);
                }
            }
            foreach (var element in elements) 
            {
                Console.Write($"{element} ");
            }
        }
    }
}
