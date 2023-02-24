using System.Net.Http.Headers;

namespace PredicateParty
{
    class PredicateParty
    {
        static void Main()
        {
            List<string> people = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Party!")
                {
                    break;
                }

                string[] tokens = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string action = tokens[0];
                string criteria = tokens[1];
                string value = tokens[2];

                if (action == "Remove")
                {
                    people.RemoveAll(GetPredicate(criteria, value));
                }
                else if (action == "Double")
                {
                    List<string> newPeople = people.FindAll(GetPredicate(criteria, value));
                    int index = people.FindIndex(GetPredicate(criteria, value));    
                    people.InsertRange(index, newPeople);
                }
            }

            if (people.Any())
            {
                Console.WriteLine($"{string.Join(", ", people)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }

        }

        public static Predicate<string> GetPredicate(string criteria, string value)
        {
            switch (criteria)
            {
                case "StartsWith":
                    return s => s.StartsWith(value);
                case "EndsWith":
                    return s => s.EndsWith(value);
                case "Length":
                    return s => s.Length == int.Parse(value);
                default:
                    return null;
            }
        }
    }
}