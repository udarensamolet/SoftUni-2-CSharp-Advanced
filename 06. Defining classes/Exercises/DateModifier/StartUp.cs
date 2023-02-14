namespace DateModifier
{
    class StartUp
    {
        static void Main()
        {
            string date1 = Console.ReadLine();
            string date2 = Console.ReadLine();

            int result = DateModifier.CalculateDifference(date1, date2);
            Console.WriteLine(result);
        }
    }
}
