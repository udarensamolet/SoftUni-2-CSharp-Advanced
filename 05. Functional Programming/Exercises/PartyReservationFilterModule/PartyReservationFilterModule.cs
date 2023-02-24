namespace PartyReservationFilterModule
{
    class PartyReservationFilterModule
    {
        static void Main()
        {
            List<string> people = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            Dictionary<string, Predicate<string>> filtered = new Dictionary<string, Predicate<string>>();


            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Print")
                {
                    break;
                }

                string[] tokens = command
                    .Split(';', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string action = tokens[0];
                string criteria = tokens[1];
                string value = tokens[2];

                if (action == "Add filter")
                {
                    filtered.Add(criteria + value, Predicate(criteria, value));
                }
                else if (action == "Remove filter")
                {
                    filtered.Remove(criteria + value);
                }
            }
            foreach(var filter in filtered)
            {
                people.RemoveAll(filter.Value);
            }
            Console.WriteLine(string.Join(" ", people));
        }

        public static Predicate<string> Predicate(string criteria, string value)
        {
            switch (criteria)
            {
                case "Starts with":
                    return s => s.StartsWith(value);
                case "Ends with":
                    return s => s.EndsWith(value);
                case "Length":
                    return s => s.Length == int.Parse(value);
                case "Contains":
                    return s => s.Contains(value);
                default:
                    return null;
            }
        }
    }
}