using System;
using System.Linq;
using System.Collections.Generic;

namespace KeyRevolver
{
    class KeyRevolver
    {
        static void Main()
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int gunBarrelSize = int.Parse(Console.ReadLine());
            int[] bulletsInput = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] locksInput = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int intelligenceValueInput = int.Parse(Console.ReadLine());

            Queue<int> locks = new Queue<int>(locksInput);
            Stack<int> bullets = new Stack<int>(bulletsInput);
            int counterShots = 0;
            int moneyEarned = intelligenceValueInput;

            while (locks.Count > 0 || bullets.Count > 0)
            {
                if (!bullets.Any())
                {
                    break;
                }
                if (!locks.Any())
                {
                    break;
                }
                int currentBulletSize = bullets.Peek();
                int currentLockSize = locks.Peek();
                if (currentBulletSize <= currentLockSize)
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }
                bullets.Pop();
                moneyEarned -= bulletPrice;

                counterShots++;

                if (counterShots == gunBarrelSize && bullets.Count > 0)
                {
                    Console.WriteLine("Reloading!");
                    counterShots = 0;
                }
            }

            if (bullets.Count == 0 && locks.Count > 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }

            if (locks.Count == 0)
            {
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${moneyEarned}");
            }

        }
    }
}
