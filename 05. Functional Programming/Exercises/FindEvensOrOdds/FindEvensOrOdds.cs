namespace FindEvensOrOdds
{
    class FindEvensOrOdds
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int lowerBound = numbers[0];
            int upperBound = numbers[1];
            string command = Console.ReadLine();

            Predicate<int> isRigth = PickNumbers(command);
            Action<int> print = n => Console.Write($"{n} ");

            for (int i = lowerBound; i <= upperBound; i++)
            {
                if (isRigth(i))
                {
                    print(i);
                }
            }
        }

        private static Predicate<int> PickNumbers(string criteria)
        {
            switch (criteria)
            {
                case "odd":
                    return n => n % 2 != 0;
                case "even":
                    return n => n % 2 == 0;
                default:
                    return null;
            }
        }
    }
}