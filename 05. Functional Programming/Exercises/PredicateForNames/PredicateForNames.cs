namespace PredicateForNames
{
    class PredicateForNames
    {
        static void Main()
        {
            int nameLengthInput = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Predicate<int> isRight = x => x <= nameLengthInput;


            foreach (var name in names)
            {
                if (isRight(name.Length))
                {
                    Console.WriteLine(name);
                }
            }

        }
    }
}
