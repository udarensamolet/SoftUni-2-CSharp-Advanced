namespace Tuple
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
            string address = null;
            for (int i = 2; i < input1.Length; i++)
            {
                address = input1[i] + " ";
            }
            address.TrimEnd();
            Tuple<string, string> tuple1 = new Tuple<string, string>($"{firstName} {lastName}", address);
            Console.WriteLine($"{tuple1.Item1} -> {tuple1.Item2}");

            string[] input2 = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string name = input2[0];
            int beerLeters = int.Parse(input2[1]);
            Tuple<string, int> tuple2 = new Tuple<string, int>(name, beerLeters);
            Console.WriteLine($"{tuple2.Item1} -> {tuple2.Item2}");

            string[] input3 = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            Tuple<int, double> tuple3 = new Tuple<int, double>(int.Parse(input3[0]), double.Parse(input3[1]));
            Console.WriteLine($"{tuple3.Item1} -> {tuple3.Item2}");
        }
    }
}