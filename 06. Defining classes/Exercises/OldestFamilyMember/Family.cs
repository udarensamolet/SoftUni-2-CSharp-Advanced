namespace OldestFamilyMember
{
    class Family
    {
        public Family()
        {
            this.Members = new List<Person>();
        }

        public List<Person> Members { get; set; } 

        public void AddMember(Person member)
        {
            this.Members.Add(member);
        }

        public Person GetOldestMember()
        {
            return Members.OrderByDescending(m => m.Age).First();
        }
    }
}
