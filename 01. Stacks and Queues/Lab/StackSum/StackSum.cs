using System;
using System.Linq;
using System.Collections.Generic;

namespace StackSum
{
    class StackSum
    {
        static void Main()
        {
            int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Stack<int> stack = new Stack<int>();

            foreach (int number in input)
            {
                stack.Push(number);
            }

            string[] command = Console.ReadLine().ToLower().Split(' ').ToArray();
            while (command[0] != "end")
            {
                if (command[0] == "add")
                {
                    int numberToBeAdded1 = Convert.ToInt32(command[1]);
                    int numberToBeAdded2 = Convert.ToInt32(command[2]);
                    stack.Push(numberToBeAdded1);
                    stack.Push(numberToBeAdded2);
                }
                else if (command[0] == "remove")
                {
                    int numbersToBeRemoved = Convert.ToInt32(command[1]);
                    if (numbersToBeRemoved <= stack.Count)
                    {
                        int counter = 0;
                        while (counter < numbersToBeRemoved)
                        {
                            stack.Pop();
                            counter++;
                        }
                    }
                }
                command = Console.ReadLine().ToLower().Split(' ').ToArray();
            }

            int sum = 0;
            foreach (int number in stack)
            {
                sum += number; 
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
