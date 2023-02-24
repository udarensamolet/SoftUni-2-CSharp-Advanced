using System.Collections;

namespace Froggy
{
    public class Lake : IEnumerable<int>
    {
        public Lake(params int[] stones)
        {
            this.Stones = stones.ToList();
        }

        List<int> Stones = new List<int>();

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < this.Stones.Count; i++)
            {
                if (i % 2 == 0)
                {
                    yield return this.Stones[i];
                }
            }

            for(int i = this.Stones.Count - 1; i >= 0; i--)
            {
                if (i % 2 != 0)
                {
                    yield return this.Stones[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
            => this.GetEnumerator();
    }
}
