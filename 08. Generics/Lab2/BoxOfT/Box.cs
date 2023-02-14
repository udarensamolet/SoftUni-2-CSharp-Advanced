namespace BoxOfT
{
    public class Box<T>
    {
        private List<T> elements;

        public Box()
        {
            this.elements = new List<T>();
        }

        public void Add(T element)
        {
            this.elements.Add(element);
        }

        public T Remove()
        {
            T topmostElement = this.elements[this.elements.Count - 1];
            this.elements.RemoveAt(this.elements.Count - 1);
            return topmostElement;
        }

        public int Count
        {
            get
            {
                return this.elements.Count;
            }
        }
    }
}
