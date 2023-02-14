using System;
using System.Text;
using System.Collections.Generic;

namespace Crossroads
{
    class Crossroads
    {
        static void Main()
        {
            int durationGreenLightSeconds = int.Parse(Console.ReadLine());
            int durationFreeWindowSeconds = int.Parse(Console.ReadLine());
           
            Queue<string> lane = new Queue<string>();

            int passedCars = 0;
            bool isEveryoneSafe = true;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END" || !isEveryoneSafe)
                {
                    break;
                }
                else if (input == "green")
                {
                    int greenLightSeconds = durationGreenLightSeconds;
                    int freeWindowSeconds = durationFreeWindowSeconds;
                    int passingTimeSeconds = greenLightSeconds + freeWindowSeconds;

                    while (passingTimeSeconds > 0 && lane.Count > 0)
                    {
                        string currentCar = null;
                        string currentCarFullName = null;

                        for (int i = 0; i < greenLightSeconds; i++)
                        {
                            if (String.IsNullOrEmpty(currentCar))
                            {
                                if (lane.Count == 0)
                                {
                                    break;
                                }
                                else
                                {
                                    passedCars++;
                                    isEveryoneSafe = true;
                                }
                                currentCar = lane.Dequeue();
                                StringBuilder sb = new StringBuilder();
                                currentCarFullName = sb.Append(currentCar).ToString();
                            }
                            currentCar = currentCar.Remove(0, 1);
                            passingTimeSeconds--;
                        }

                        for (int i = 0; i < freeWindowSeconds; i++)
                        {
                            if (String.IsNullOrEmpty(currentCar))
                            {
                                passingTimeSeconds = 0;
                                break;
                            }
                            currentCar = currentCar.Remove(0, 1);
                            passingTimeSeconds--;
                        }

                        if (!String.IsNullOrEmpty(currentCar))
                        {
                            Console.WriteLine("A crash happened!");
                            Console.WriteLine($"{currentCarFullName} was hit at {currentCar[0]}.");
                            isEveryoneSafe = false;
                            return;
                        }
                    }
                }
                else
                {
                    string car = input;
                    lane.Enqueue(car);
                }
            }

            if (isEveryoneSafe)
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{passedCars} total cars passed the crossroads.");
            }
        }
    }
}
