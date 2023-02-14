using System;
using System.Linq;
using System.Collections.Generic;

namespace Wardrobe
{
    class Wardrobe
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string color = input[0];
                string[] clothes = input[1]
                    .Split(',', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                for (int j = 0; j < clothes.Length; j++)
                {
                    string cloth = clothes[j];

                    if (!wardrobe.ContainsKey(color))
                    {
                        wardrobe.Add(color, new Dictionary<string, int>());
                        wardrobe[color].Add(cloth, 1);
                    }
                    else
                    {
                        if (!wardrobe[color].ContainsKey(cloth))
                        {
                            wardrobe[color].Add(cloth, 1);
                        }
                        else
                        {
                            wardrobe[color][cloth]++;
                        }
                    }
                }
            }

            string[] tokens = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            string colorSearch = tokens[0];
            string clothSearch = tokens[1];

            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");
                foreach (var cloth in color.Value)
                {
                    if (color.Key == colorSearch && cloth.Key == clothSearch)
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                    }
                }
            }
        }
    }
}
