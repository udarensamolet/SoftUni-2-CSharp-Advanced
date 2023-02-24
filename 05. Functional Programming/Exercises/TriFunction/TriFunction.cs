namespace TriFunction
{
    class TriFunction
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Func<string, int, bool> checkEqualOrLargerNameSum =
                (name, number) =>
                name.Sum(ch => ch) >= number;

            Func<string[], int, Func<string, int, bool>, string> getName =
                (names, number, predicate) => names.FirstOrDefault(name => predicate(name, number));

            Console.WriteLine(getName(names, number, checkEqualOrLargerNameSum));
        }
    }
}