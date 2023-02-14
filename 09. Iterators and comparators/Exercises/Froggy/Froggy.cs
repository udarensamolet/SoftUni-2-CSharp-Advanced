namespace Froggy
{
    public class Froggy
    {
        public static void Main()
        {
            int[] stones = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Lake lake = new Lake(stones);
            foreach(var stone in lake)
            {
                Console.Write(stone + ", ");
            }
        }
    }
}