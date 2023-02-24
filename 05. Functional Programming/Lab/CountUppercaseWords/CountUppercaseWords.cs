namespace CountUppercaseWords
{
    class CountUppercaseWords
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Predicate<string> checker = n => n[0] == n.ToUpper()[0];
            string[] words = input
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Where(w => checker(w))
                .ToArray();

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}