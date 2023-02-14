using System;
using System.Linq;
using System.Collections.Generic;

namespace MaxAndMinElement
{
    class MaxAndMinElement
    {
        static void Main()
        {
            int countQueries = int.Parse(Console.ReadLine());
            Stack<int> elements = new Stack<int>();

            for (int i = 0; i < countQueries; i++)
            {
                int[] tokens = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int query = tokens[0];

                if (query == 1)
                {
                    int element = tokens[1];
                    elements.Push(element);
                }
                else if (query == 2)
                {
                    if (elements.Count > 0)
                    {
                        elements.Pop();
                    }
                }
                else if (query == 3)
                {
                    if (elements.Count > 0)
                    {
                        Console.WriteLine(GetMaxElementStack(elements));
                    }
                }
                else if (query == 4)
                {
                    if (elements.Count > 0)
                    {
                        Console.WriteLine(GetMinElementStack(elements));
                    }
                }
            }
            int[] elementsArrayed = elements.ToArray();
            Console.WriteLine(string.Join(", ", elementsArrayed));
        }

        static int GetMaxElementStack(Stack<int> stack)
        {
            int[] arrayedStack = stack.ToArray();
            Array.Sort(arrayedStack);
            Array.Reverse(arrayedStack);
            int maxElement = arrayedStack[0];
            return maxElement;
        }

        static int GetMinElementStack(Stack<int> stack)
        {
            int[] arrayedStack = stack.ToArray();
            Array.Sort(arrayedStack);
            int minElement = arrayedStack[0];
            return minElement;
        }
    }
}
