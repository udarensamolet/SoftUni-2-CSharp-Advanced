using System;
using System.Linq;
using System.Collections.Generic;

namespace TruckTour
{
    class TruckTour
    {
        static void Main()
        {
            int stationsCount = int.Parse(Console.ReadLine());
            Queue<Tuple<int, int, int>> gasStations = new Queue<Tuple<int, int, int>>();
            for (int i = 0; i < stationsCount; i++)
            {
                int[] tokens = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int litres = tokens[0];
                int kms = tokens[1];

                Tuple<int, int, int> gasStation = new Tuple<int, int, int>(i, litres, kms);
                gasStations.Enqueue(gasStation);
            }

            bool isSuccess = false;
            while (!isSuccess)
            {
                int fuelAmountInTank = 0;
                foreach (var gasStation in gasStations)
                {
                    int index = gasStation.Item1;
                    int litres = gasStation.Item2;
                    int kms = gasStation.Item3;

                    fuelAmountInTank = fuelAmountInTank + litres - kms;
                    if (fuelAmountInTank < 0 && fuelAmountInTank < gasStations.Peek().Item2)
                    {
                        gasStations.Enqueue(gasStations.Dequeue());
                        isSuccess = false;
                        break;
                    }
                    isSuccess = true;
                }
            }
            Console.WriteLine(gasStations.Dequeue().Item1);
        }
    }
}
