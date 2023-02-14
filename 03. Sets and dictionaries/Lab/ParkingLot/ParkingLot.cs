using System;
using System.Linq;
using System.Collections.Generic;

namespace ParkingLot
{
    class ParkingLot
    {
        static void Main()
        {
            HashSet<string> cars = new HashSet<string>();
            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (input[0] == "END")
                {
                    break;
                }

                string direction = input[0];
                string carNumber = input[1];

                if (direction == "IN")
                {
                    cars.Add(carNumber);
                }
                else if (direction == "OUT")
                {
                    cars.Remove(carNumber);
                }
            }

            if (cars.Any())
            {
                foreach (var car in cars)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
