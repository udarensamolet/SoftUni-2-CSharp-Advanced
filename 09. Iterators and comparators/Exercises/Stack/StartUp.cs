namespace CustomStack
{
    public class StartUp
    {
        public static void Main()
        {
            char[] delimiters = new char[] { ' ', ',' };
            CustomStack<int> stack = new CustomStack<int>();
            string input = Console.ReadLine();
            while(input != "END")
            {
                string[] tokens = input
                .Split(delimiters, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
                string command = tokens[0];
                
                if (command == "Push")
                {
                    for (int i = 1; i < tokens.Length; i++)
                    {
                        stack.Push(int.Parse(tokens[i]));
                    }
                }
                else if (command == "Pop")
                {
                    stack.Pop();
                }
                input = Console.ReadLine();
            }
            
            for (int i = 0; i < 2; i++)
            {
                foreach(var item in stack)
                {
                    Console.WriteLine(item);
                }
            }
            
            
        }
    }
}