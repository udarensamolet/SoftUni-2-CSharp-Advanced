using System;
using System.Collections.Generic;
using System.Linq;

namespace TrafficJam
{
    class TrafficJam
    {
        static void Main()
        {
            int carsPassAtGreenLight = int.Parse(Console.ReadLine());
            int counter = 0;
            Queue<string> cars = new Queue<string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }

                if (input != "green")
                {
                    cars.Enqueue(input);
                }
                else
                {
                    for (int i = 0; i < carsPassAtGreenLight && cars.Any(); i++)
                    {
                        Console.WriteLine($"{cars.Dequeue()} passed!");
                        counter++;
                    }
                }
            }
            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}
