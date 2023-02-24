using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace SimpleTextEditor
{
    class SimpleTextEditor
    {
        static void Main()
        {
            Stack<char> text = new Stack<char>();
            Stack<char> trash = new Stack<char>();

            Stack<string[]> commands = new Stack<string[]>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                int command = Convert.ToInt32(tokens[0]);

                if (command == 1)
                {
                    char[] someString = tokens[1].ToCharArray();
                    AppendStrings(text, someString);
                    commands.Push(tokens);
                }
                else if (command == 2)
                {
                    int count = Convert.ToInt32(tokens[1]);
                    EraseCountElements(text, trash, count);
                    commands.Push(tokens);
                }
                else if (command == 3)
                {
                    int index = Convert.ToInt32(tokens[1]) - 1;
                    ReturnElementAtIndex(text, index);
                }
                else if (command == 4)
                {
                    UndoUndoneCommands(text, commands, trash);
                }
            }
        }

        static void AppendStrings(Stack<char> text, char[] someString)
        {
            for (int i = 0; i < someString.Length; i++)
            {
                text.Push(someString[i]);
            }            
        }

        static void EraseCountElements(Stack<char> text, Stack<char> trash, int count)
        {
            for (int i = 0; i < count; i++)
            {
                trash.Push(text.Pop());
            }
        }

        static void ReturnElementAtIndex(Stack<char> text, int index)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in text)
            {
                sb.Append(item);
            }
            string textString = sb.ToString();
            StringBuilder newSb = new StringBuilder();
            for (int i = textString.Length - 1; i >= 0; i--)
            {
                newSb.Append(textString[i]);
            }
            string finalTextString = newSb.ToString();
            Console.WriteLine(finalTextString[index]);
        }

        static void UndoUndoneCommands(Stack<char> text, Stack<string[]> commands, Stack<char> trash)
        {
            string[] tokens = commands.Pop();
            int command = Convert.ToInt32(tokens[0]);
            if (command == 1)
            {
                char[] someString = tokens[1].ToCharArray();
                for (int i = 0; i < someString.Length; i++)
                {
                    text.Pop();
                }
            }
            else if (command == 2)
            { 
                int count = Convert.ToInt32(tokens[1]);
                for (int i = 0; i < count; i++)
                {
                    text.Push(trash.Pop());
                }
            }
        }
    }
}
