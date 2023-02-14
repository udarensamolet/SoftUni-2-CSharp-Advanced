namespace Exercises
{
    class StartUp
    {
        static void Main()
        {
            CustomStack stack = new CustomStack();
            stack.Push(10);
            stack.Push(20);  
            stack.Push(30);
            stack.Push(40);
            stack.Push(50);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
    }
};