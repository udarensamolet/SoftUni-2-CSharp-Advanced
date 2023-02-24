using System;
using System.Linq;
using System.Collections.Generic;

namespace BasicStackOperations
{
    class BasicStackOperations
    {
        static void Main()
        {
            Stack<int> elements = new Stack<int>();
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int elementsToPush = numbers[0];
            int elementsToPop = numbers[1];
            int elementToBeFound = numbers[2];

            int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < elementsToPush; i++)
            {
                elements.Push(input[i]);
            }

            int limit = Math.Min(elements.Count, elementsToPop);
            for (int i = 0; i < limit; i++)
            {
                elements.Pop();
            }


            if (elements.Count !=  0)
            {
                if (elements.Contains(elementToBeFound))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(GetMinElementStack(elements));
                } 
            }
            else
            {
                Console.WriteLine(0);
            }
           
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
