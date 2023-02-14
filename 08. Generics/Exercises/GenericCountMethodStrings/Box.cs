namespace GenericCountMethodStrings
{
    public class Box<T> where T : IComparable<T>
    {
        public List<T> List;

        public Box()
        {
            List = new List<T>();
        }

        public void Add(T item)
        {
            List.Add(item);
        }

        public int CountElements(T element)
        {
            int count = 0;
            for(int i = 0; i < List.Count; i++)
            {
                if (List[i].CompareTo(element) >= 0);
                {
                    count++;
                }
            }
            return count;
        }
    }
}
