using System.Collections;

namespace CustomStack
{
    public class CustomStack<T> : IEnumerable<T>
    {
        private List<T> items;

        public CustomStack()
        {
            this.items = new List<T>();
        }

        public void Push(T element)
        {
            items.Add(element);
        }

        public void Pop()
        {
            items.RemoveAt(this.items.Count - 1);
        }
        
        
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.items.Count - 1; i >= 0; i--)
            {
                yield return this.items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
            => this.GetEnumerator();
    }
}