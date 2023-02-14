namespace OldestFamilyMember
{
    class StartUp
    {
        static void Main()
        {
            Family family = new Family();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string name = tokens[0];
                int age = int.Parse(Console.ReadLine());
                family.AddMember(new Person(name, age));
            }
        }
    }
}