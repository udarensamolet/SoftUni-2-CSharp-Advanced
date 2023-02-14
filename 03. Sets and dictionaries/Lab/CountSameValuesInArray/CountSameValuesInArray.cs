using System;
using System.Linq;
using System.Collections.Generic;

namespace CountSameValuesInArray
{
    class CountSameValuesInArray
    {
        static void Main()
        {
            double[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
            Dictionary<double, int> values = new Dictionary<double, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!values.ContainsKey(input[i]))
                {
                    values.Add(input[i], 1);
                }
                else
                {
                    values[input[i]]++;
                }
            }

            foreach (var value in values)
            {
                Console.WriteLine($"{value.Key} - {value.Value} times");
            }
        }
    }
}
