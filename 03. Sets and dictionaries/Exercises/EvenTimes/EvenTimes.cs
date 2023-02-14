using System;
using System.Collections.Generic;

namespace EvenTimes
{
    class EvenTimes
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, int> numbers = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (!numbers.ContainsKey(input))
                {
                    numbers.Add(input, 1);
                }
                else
                {
                    numbers[input]++;
                }
            }

            foreach (var number in numbers) 
            {
                if (number.Value % 2 == 0)
                {
                    Console.WriteLine(number.Key);
                }
            }
        }
    }
}
 