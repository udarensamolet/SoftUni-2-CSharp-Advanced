using System;
using System.Linq;
using System.Collections.Generic;

namespace FashionBoutique
{
    class FashionBoutique
    {
        static void Main()
        {
            int[] clothesValues = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int capacityRack = int.Parse(Console.ReadLine());

            Stack<int> clothes = new Stack<int>();
            int clothesValuesSum = 0;
            int racksCount = 1;

            for (int i = 0; i < clothesValues.Length; i++)
            {
                clothes.Push(clothesValues[i]);
            }

            while (clothes.Any())
            {
                int clothesNext = clothes.Peek();

                if (clothesValuesSum + clothesNext < capacityRack)
                {
                    clothesValuesSum += clothes.Pop();
                }
                else if (clothesValuesSum + clothesNext == capacityRack)
                {
                    clothes.Pop();
                    if (clothes.Any())
                    {
                        racksCount++;
                    }
                    clothesValuesSum = 0;
                }
                else if (clothesValuesSum + clothesNext > capacityRack)
                {
                    racksCount++;
                    clothesValuesSum = 0;
                    clothesValuesSum += clothes.Pop();
                }
            }

            Console.WriteLine(racksCount);
        }
    }
}
