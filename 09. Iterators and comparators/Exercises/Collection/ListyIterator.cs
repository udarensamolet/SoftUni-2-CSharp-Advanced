using System.Collections;
using System.Text;

namespace Collection
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        public ListyIterator(params T[] collection)
        {
            this.Index = 0;
            this.Collection = collection.ToList();
        }

        public List<T> Collection;
        public int Index { get; set; }

        public bool Move()
        {
            if (this.Index + 1 <= this.Collection.Count - 1)
            {
                this.Index++;
                return true;
            }
            return false;
        }

        public bool HasNext()
        {
            if (this.Index + 1 >= this.Collection.Count)
            {
                return false;
            }
            return true;
        }

        public void Print()
        {
            if (this.Collection.Count == 0)
            {
                throw new InvalidOperationException($"Invalid Operation!");
            }
            Console.WriteLine(this.Collection[this.Index]);
        }

        public void PrintAll()
        {
            var sb = new StringBuilder();
            foreach(var item in this.Collection)
            {
                sb.Append($"{item} ");
            }
            Console.WriteLine(sb.ToString().TrimEnd());
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in Collection)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
            => this.GetEnumerator();
    }
}
