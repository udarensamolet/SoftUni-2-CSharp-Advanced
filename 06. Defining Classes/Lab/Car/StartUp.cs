using System.ComponentModel;
using System.Linq;

namespace CarManufacturer
{
    class StartUp
    {
        static void Main()
        {
            List<Tire[]> allTires = new List<Tire[]>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "No more tires")
                {
                    break;
                }

                string[] tokens = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                int year1 = int.Parse(tokens[0]);
                double pressure1 = double.Parse(tokens[1]);
                int year2 = int.Parse(tokens[2]);
                double pressure2 = double.Parse(tokens[3]);
                int year3 = int.Parse(tokens[4]);
                double pressure3 = double.Parse(tokens[5]);
                int year4 = int.Parse(tokens[6]);
                double pressure4 = double.Parse(tokens[7]);
                Tire[] tires =
                {
                    new Tire(year1, pressure1),
                    new Tire(year2, pressure2),
                    new Tire(year3, pressure3),
                    new Tire(year4, pressure4)
                };
                allTires.Add(tires);
            }

            List<Engine> engines = new List<Engine>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Engines done")
                {
                    break;
                }

                string[] tokens = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                int horsePower = int.Parse(tokens[0]);
                double cubicCapacity = double.Parse(tokens[1]);
                engines.Add(new Engine(horsePower, cubicCapacity));
            }

            List<Car> cars = new List<Car>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Show special")
                {
                    break;
                }

                string[] tokens = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string make = tokens[0];
                string models = tokens[1];
                int year = int.Parse(tokens[2]);
                double fuelQuantity = double.Parse(tokens[3]);
                double fuelConsumption = double.Parse(tokens[4]);
                int engineIndex = int.Parse(tokens[5]);
                int tiresIndex = int.Parse(tokens[6]);

                Car car = new Car(make, models, year, fuelQuantity, fuelConsumption, engines[engineIndex], allTires[tiresIndex]);
                cars.Add(car);
            }

            Predicate<Car> isSpecial = c => c.Year >= 2017
                                            && c.Engine.HorsePower > 300
                                            && c.Tires.Sum(t => t.Pressure) >= 9
                                            && c.Tires.Sum(t => t.Pressure) <= 10;
            cars.Where(c => isSpecial(c)).ToList().ForEach(c => c.Drive(20));
            cars.Where(c => isSpecial(c)).ToList().ForEach(c => c.WhoAmI());
        }
    }
}