using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace FilterByAge
{
    class FilterByAge
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<KeyValuePair<string, int>> people = new List<KeyValuePair<string, int>>();
            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string personName = info[0];
                int personAge = int.Parse(info[1]);

                people.Add(new KeyValuePair<string, int>(personName, personAge));
            }

            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            Func<int, bool> tester = CreateTester(condition, age);
            Action<KeyValuePair<string, int>> printer = CreatePrinter(format);
            PrintFilteredStudent(people, tester, printer);


        }

        public static Action<KeyValuePair<string, int>> CreatePrinter(string format)
        {
            switch (format)
            {
                case "age":
                    return person => Console.WriteLine($"{person.Value}");
                case "name":
                    return person => Console.WriteLine($"{person.Key}");
                case "name age":
                    return person => Console.WriteLine($"{person.Key} - {person.Value}");
                default:
                    return null;
            }
        }
        public static Func<int, bool> CreateTester(string condition, int age)
        {
            switch (condition)
            {
                case "younger":
                    return x => x < age;
                case "older":
                    return x => x >= age;
                default:
                    return null;
            }
        }

        static void PrintFilteredStudent(List<KeyValuePair<string, int>> people, Func<int, bool> tester, Action<KeyValuePair<string, int>> printer)
        {
            foreach (var person in people)
            {
                if (tester(person.Value))
                {
                    printer(person);
                }
            }
        }
    }
}