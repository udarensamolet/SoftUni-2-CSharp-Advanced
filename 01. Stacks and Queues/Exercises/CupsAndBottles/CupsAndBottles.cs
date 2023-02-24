using System;
using System.Collections.Generic;
using System.Linq;

namespace CupsAndBottles
{
    class CupsAndBottles
    {
        static void Main()
        {
            int[] cupsInput = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] bottlesInput = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> cups = new Queue<int>(cupsInput);
            Stack<int> bottles = new Stack<int>(bottlesInput);
            int wastedWater = 0;

            while (cups.Any() || bottles.Any())
            {
                if (!cups.Any())
                {
                    Console.Write($"Bottles: ");
                    foreach (var bottle in bottles)
                    {
                        Console.Write($"{bottle} ");
                    }
                    Console.WriteLine();
                    break;
                }
                if (!bottles.Any())
                {
                    Console.Write($"Cups: ");
                    foreach (var cup in cups)
                    {
                        Console.Write($"{cup} ");
                    }
                    Console.WriteLine();
                    break;
                }

                int currentBottle = bottles.Pop();
                int currentCup = cups.Peek();

                while (currentCup - currentBottle > 0)
                {
                    currentCup -= currentBottle;
                    currentBottle = bottles.Pop();
                }
                wastedWater += (currentBottle - currentCup);
                cups.Dequeue();
            }

            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}
