namespace KnightsOfHonor
{
    class KnightsOfHonor
    {
        static void Main()
        {
            string[] names = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Action<string> print = name => Console.WriteLine($"Sir {name}");

            foreach (string name in names)
            {
                print(name);
            }
        }
    }
}