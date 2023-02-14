using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ReverseAndExclude
{
    class ReverseAndExclude
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int n = int.Parse(Console.ReadLine());

            Predicate<int> isDivisible = IsDivisible(n);
            Action<int> print = n => Console.Write($"{n} ");
            Array.Reverse(numbers);

            foreach(var number in numbers)
            {
                if (!isDivisible(number))
                {
                    print(number);
                }
            }
        }

        public static Predicate<int> IsDivisible(int n)
        {
            return x => x % n == 0;
        }

        
    }
}