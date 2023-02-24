namespace SortEvenNumbers
{
    class SortEvenNumbers
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(x => x % 2 == 0)
                .OrderBy(x => x)
                .ToArray();
            string result = string.Join(", ", numbers);
            Console.WriteLine(result);
        }
    }
}