using System;
using System.Collections.Generic;


namespace MatchingBrackets
{
    class MatchingBrackets
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++) 
            {
                char ch = input[i];
                if (ch == '(')
                {
                    stack.Push(i);
                }
                else if (ch == ')')
                {
                    int startIndex = stack.Pop();
                    int endIndex = i;
                    Console.WriteLine(input.Substring(startIndex, endIndex - startIndex + 1));
                }
                
            }
        }
    }
}
