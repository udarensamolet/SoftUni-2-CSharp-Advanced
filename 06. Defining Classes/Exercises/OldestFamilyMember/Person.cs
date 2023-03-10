namespace OldestFamilyMember
{
    class Person
    {
        private string name;
        private int age;

        public Person()
        {
            this.Name = "No name";
            this.Age = 1;
        }

        public Person(int age) :
            this()
        {
            this.Name = "No name";
            this.Age = age;
        }

        public Person(string name, int age) :
            this(age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}