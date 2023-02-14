namespace ComparingObjects
{
    public class StartUp
    {
        public static void Main()
        {
            List<Person> people = new List<Person>();
            string input = Console.ReadLine();
            while(input != "END") 
            {
                string[] tokens = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                string town = tokens[2];

                Person person = new Person(name, age, town);
                people.Add(person);
                input = Console.ReadLine();
            }

            int n = int.Parse(Console.ReadLine()) - 1;

            int countMatches = -1;
            int countNotMatches = 0;
            int count = people.Count;

            Person personToCompare = people[n];

            foreach(var person in people) 
            {
                if(personToCompare.CompareTo(person) == 0)
                {
                    countMatches++;
                }
                else
                {
                    countNotMatches++;
                }
            }

            if (countMatches == 0)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{countMatches} {countNotMatches} {count}");
            }
        }
    }
}