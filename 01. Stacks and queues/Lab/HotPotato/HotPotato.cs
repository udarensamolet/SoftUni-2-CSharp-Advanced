using System;
using System.Linq;
using System.Collections.Generic;

namespace HotPotato
{
    class HotPotato
    {
        static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            int toss = int.Parse(Console.ReadLine());

            Queue<string> kids = new Queue<string>(input);

            while (kids.Count != 1)
            {
                for (int i = 0; i < toss - 1; i++)
                {
                    kids.Enqueue(kids.Dequeue());
                }
                Console.WriteLine($"Removed {kids.Dequeue()}");
            }
            Console.WriteLine($"Last is {kids.Peek()}");
        }
    }
}
