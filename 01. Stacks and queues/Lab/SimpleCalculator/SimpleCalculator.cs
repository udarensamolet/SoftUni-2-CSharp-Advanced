using System;
using System.Linq;
using System.Collections.Generic;

namespace SimpleCalculator
{
    class SimpleCalculator
    {
        static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            Stack<string> numbers = new Stack<string>();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                numbers.Push(input[i]);
            }

            string element = null;
            int number = 0;
            int result = 0;

            int firstElement = Convert.ToInt32(numbers.Pop());
            result = firstElement;


            while (numbers.Count != 0)
            {
                element = numbers.Pop();
                if (element == "+")
                {
                    number = Convert.ToInt32(numbers.Pop());
                    result += number;
                }
                else if (element == "-")
                {
                    number = Convert.ToInt32(numbers.Pop());
                    result -= number;
                }
            }

            Console.WriteLine(result);
        }
    }
}
