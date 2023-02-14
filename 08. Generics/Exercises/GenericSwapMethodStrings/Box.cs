namespace GenericSwapMethodStrings
{
    public class Box<T>
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

        public void Swap(int indexFirst, int indexSecond)
        {
            T temp = List[indexFirst];
            List[indexFirst] = List[indexSecond];
            List[indexSecond] = temp;
        }
    }
}
