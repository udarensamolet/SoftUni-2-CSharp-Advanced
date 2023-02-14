namespace SumOfCoins
{
    public class SumOfCoins
    {
        public static void Main(string[] args)
        {
            int[] coins = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int targetSum = int.Parse(Console.ReadLine());

            Dictionary<int, int> result = ChooseCoins(coins, targetSum);

            Console.WriteLine(
                $"Number of coins to take: {result.Sum(x => x.Value)}");

            foreach (var item in result
                .OrderByDescending(x => x.Key))
            {
                Console.WriteLine($"{item.Value} coin(s) with value {item.Key}");
            }
        }

        public static Dictionary<int, int> ChooseCoins(
            IList<int> coins,
            int targetSum)
        {
            coins = coins.OrderBy(x => x).ToList();
            Dictionary<int, int> coinsCount =
                new Dictionary<int, int>();

            int index = coins.Count - 1;

            //1, 2, 5, 10, 20, 50
            //923
            while (index > -1)
            {
                // 50
                int currentCoin = coins[index];

                //923 / 50 = 18
                int result = targetSum / currentCoin;

                if (result < 1)
                {
                    index--;
                    continue;
                }

                //50, 18
                coinsCount.Add(currentCoin, result);

                //923 -= 50 * 18
                targetSum -= currentCoin * result;

                if (targetSum == 0)
                {
                    break;
                }
            }

            if (targetSum > 0)
            {
                throw new InvalidOperationException();
            }

            return coinsCount;
        }
    }
}
