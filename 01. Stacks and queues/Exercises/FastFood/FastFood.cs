using System;
using System.Linq;
using System.Collections.Generic;

namespace FastFood
{
    class FastFood
    {
        static void Main()
        {
            int quantityFood = int.Parse(Console.ReadLine());
            int[] quantityOrders = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> orders = new Queue<int>(quantityOrders);

            Console.WriteLine(GetMaxElementQueue(orders));

            int sumOrders = 0;

            while (orders.Count > 0)
            {
                int order = orders.Peek();
                sumOrders += order;

                if (sumOrders <= quantityFood)
                {
                    orders.Dequeue();
                }
                else
                {
                    break;
                }
            }

            if (orders.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.Write("Orders left: ");
                while (orders.Count > 0)
                {
                    Console.Write($"{orders.Dequeue()} ");
                }
            }


        }

        static int GetMaxElementQueue(Queue<int> que)
        {
            int[] arrayedQueue = que.ToArray();
            Array.Sort(arrayedQueue);
            Array.Reverse(arrayedQueue);
            int maxElement = arrayedQueue[0];
            return maxElement;
        }
    }
}
