namespace CustomComparator
{
    class CustomComparator
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Predicate<int> isEven = x => x % 2 == 0;
            Predicate<int> isOdd = x => x % 2 != 0;

            Action<int> print = x => Console.Write($"{x} ");
            Array.Sort(numbers);
            foreach(var number in numbers)
            {
                if (isEven(number))
                {
                    print(number);
                }
            }

            foreach(var number in numbers)
            {
                if (isOdd(number))
                {
                    print(number);
                }
            }
        }
    }
}