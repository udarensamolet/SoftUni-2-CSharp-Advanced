using System;
using System.Linq;
using System.Collections.Generic;

namespace BasicQueueOperations
{
    class BasicQueueOperations
    {
        static void Main()
        {
            int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int elementsToEnqueue = input[0];
            int elementsToDequeue = input[1];
            int elementToBeFound = input[2];

            int[] elements = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> que = new Queue<int>();

            for (int i = 0; i < elementsToEnqueue; i++)
            {
                que.Enqueue(elements[i]);
            }


            int smallerNumber = Math.Min(que.Count, elementsToDequeue);
            for (int i = 0; i < smallerNumber; i++)
            {
                que.Dequeue();
            }

            if (que.Count > 0)
            {
                if (que.Contains(elementToBeFound))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(GetMinElementQueue(que));
                }
            }
            else
            {
                Console.WriteLine(0);
            }
        }

        static int GetMinElementQueue(Queue<int> que)
        {
            int[] arrayedQueue = que.ToArray();
            Array.Sort(arrayedQueue);
            int minElement = arrayedQueue[0];
            return minElement;
        }
    }
}
