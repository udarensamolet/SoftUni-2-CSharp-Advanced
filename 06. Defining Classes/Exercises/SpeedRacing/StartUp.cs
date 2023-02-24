namespace SpeedRacing
{
    class StartUp
    {
        static void Main()
        {
            List<Car> cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] tokens = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string model = tokens[0];
                double fuelAmount = double.Parse(tokens[1]);
                double fuelConsumptionFor1Km = double.Parse(tokens[2]);
                cars.Add(new Car(model, fuelAmount, fuelConsumptionFor1Km));
            }

            while (true)
            {
                string input = Console.ReadLine();
                if(input == "End")
                {
                    break;
                }
                string[] tokens = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string model = tokens[1];
                int amountOfKms = int.Parse(tokens[2]);

                var targetCar = cars.FirstOrDefault(c => c.Model == model);
                targetCar.Drive(amountOfKms);
            }

            foreach(var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}