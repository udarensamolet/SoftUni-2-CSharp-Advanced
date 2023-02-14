using System.Globalization;

namespace Threeuple
{
    public class StartUp
    {
        public static void Main()
        {
            string[] input1 = Console.ReadLine()
               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
               .ToArray();
            string firstName = input1[0];
            string lastName = input1[1];
            string address = input1[2];
            string town = null;
            for (int i = 3; i < input1.Length; i++)
            {
                town += input1[i] + " ";
            }
            town.TrimEnd();
            Threeuple<string, string, string> threeuple1 = new Threeuple<string, string, string>($"{firstName} {lastName}", address, town);
            Console.WriteLine($"{threeuple1.Item1} -> {threeuple1.Item2} -> {threeuple1.Item3}");

            string[] input2 = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string name = input2[0];
            double beerLeters = double.Parse(input2[1]);
            string state = input2[2];
            bool isDrunk = false;
            if (state == "drunk")
            {
                isDrunk = true;
            }
            Threeuple<string, double, bool> threeuple2 = new Threeuple<string, double, bool>(name, beerLeters, isDrunk);
            Console.WriteLine($"{threeuple2.Item1} -> {threeuple2.Item2} -> {threeuple2.Item3}");

            string[] input3 = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string name2 = input3[0];
            double accountBalance = double.Parse(input3[1]);
            string bankName = input3[2];
            Threeuple<string, double, string> threeuple3 = new Threeuple<string, double, string>(name2, accountBalance, bankName);
            Console.WriteLine($"{threeuple3.Item1} -> {threeuple3.Item2} -> {threeuple3.Item3}");
        }
    }
}
