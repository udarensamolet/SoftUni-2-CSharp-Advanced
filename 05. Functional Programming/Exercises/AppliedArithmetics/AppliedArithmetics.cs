using System.Security.Cryptography.X509Certificates;

namespace AppliedArithmetics
{
    class AppliedArithmetics
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Func<int[], int[]> add = n => n.Select(x => x + 1).ToArray();
            Func<int[], int[]> multiply = n => n.Select(x => x * 2).ToArray();
            Func<int[], int[]> subtract = n => n.Select(x => x - 1).ToArray();
            Action<int[]> Print = n => Console.WriteLine(String.Join(" ", n));

            while (true)
            {
                string command = Console.ReadLine();
                switch (command)
                {
                    
                    case "add":
                        numbers = add(numbers);
                        break;
                    case "multiply":
                        numbers = multiply(numbers);
                        break;
                    case "subtract":
                        numbers = subtract(numbers);
                        break;
                    case "print":
                        Print(numbers);
                        break;
                    case "end":
                        break;
                }
            }
        }
    }
}