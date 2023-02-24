namespace ClassPerson
{
    class Person 
    {
        private string name;
        private int age;

        public Person()
        { 
        }

        public Person(string name, int age):
            this()
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }
    }
}