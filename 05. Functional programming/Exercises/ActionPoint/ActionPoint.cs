namespace ActionPoint
{
    class ActionPoint
    {
        static void Main()
        {
            string[] words = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Action<string> print = word => Console.WriteLine(word);

            foreach (var word in words)
            {
                print(word);
            }
        }
    }
}