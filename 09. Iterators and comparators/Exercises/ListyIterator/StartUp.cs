namespace ListyIterator
{
    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            List<string> tokens = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
            string[] inputParams = new string[tokens.Count - 1];
            tokens.RemoveAt(0);
            inputParams = tokens.ToArray();
            ListyIterator<string> listy = new ListyIterator<string>(inputParams);

            input = Console.ReadLine();

            while (input != "END")
            {
                if (input == "Move")
                {
                    Console.WriteLine(listy.Move());
                }
                else if (input == "Print")
                {
                    listy.Print();
                }
                else if(input == "HasNext")
                {
                    Console.WriteLine(listy.HasNext());
                }
                input = Console.ReadLine();
            }
        }
    }
}