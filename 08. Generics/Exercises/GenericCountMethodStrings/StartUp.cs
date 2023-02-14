namespace GenericCountMethodStrings
{
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Box<string> box = new Box<string>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                box.Add(input);
            }
            string element = Console.ReadLine();
            Console.WriteLine(box.CountElements(element));
        }
    }
}
