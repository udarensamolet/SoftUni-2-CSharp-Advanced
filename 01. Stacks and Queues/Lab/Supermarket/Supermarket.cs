using System;
using System.Collections.Generic;

namespace Supermarket
{
    class Supermarket
    {
        static void Main()
        {
            Queue<string> que = new Queue<string>();
            string input = Console.ReadLine();
            while (input != "End")
            {
                if (input == "Paid")
                {
                    while (que.Count != 0)
                    {
                        Console.WriteLine(que.Dequeue());
                    }
                }
                else
                {
                    que.Enqueue(input);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"{que.Count} people remaining.");
        }
    }
}
