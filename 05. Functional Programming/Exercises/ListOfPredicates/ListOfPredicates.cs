namespace ListOfPredicates
{
    class ListOfPredicates
    {
        static void Main()
        {
            int lowerBound = 1;
            int upperBound = int.Parse(Console.ReadLine());

            int[] dividers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Func<int, int[], bool> checker = (number, dividers) =>
            {
                foreach (var divider in dividers)
                {
                    if (number % divider != 0)
                    {
                        return false;
                    }
                }
                return true;
            };

            List<int> result = new List<int>();

            for (int i = lowerBound; i <= upperBound; i++)
            {
                result.Add(i);
            }

            result.Where(x => checker(x, dividers)).ToList().ForEach(x => Console.Write(x + " "));
        }
    }
}