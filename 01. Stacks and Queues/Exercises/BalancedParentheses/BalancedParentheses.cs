using System;
using System.Collections.Generic;

namespace BalancedParentheses
{
    class BalancedParentheses
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Stack<char> parenthesis = new Stack<char>();
            bool result = false;
            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                switch (currentChar)
                {
                    case '{':
                    case '[':
                    case '(':
                        parenthesis.Push(currentChar);
                        break;
                    case '}':
                    case ']':
                    case ')':

                        if (parenthesis.Count > 0)
                        {
                            char correctChar = GettingCorrectRightParentheses(currentChar);
                            char lastInputChar = parenthesis.Peek();
                            if (correctChar == lastInputChar)
                            {
                                parenthesis.Pop();
                                result = true;
                            }
                        }
                        else
                        {
                            result = false;
                            break;
                        }
                        break;
                }
            }

            if (parenthesis.Count == 0 && result)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO"); 
            }
        }

        static char GettingCorrectRightParentheses(char right)
        {
            char left = ' ';
            switch (right)
            {
                case '}':
                    left = '{';
                    break;
                case ']':
                    left = '[';
                    break;
                case ')':
                    left = '(';
                    break;
            }
            return left;
        }
    }
}
