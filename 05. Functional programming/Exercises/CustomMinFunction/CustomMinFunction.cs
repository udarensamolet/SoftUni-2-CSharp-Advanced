namespace CustomMinFunction
{
    class CustomMinFunction
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Func<int[], int> findSmallestNumber = nums =>
            {
                int min = int.MaxValue;
                foreach (var num in nums)
                {
                    if (num < min)
                    {
                        min = num;
                    }
                }
                return min;
            };

            Console.WriteLine(findSmallestNumber(numbers));
        }
    }
}
