namespace RawData
{
    class StartUp
    {
        static void Main()
        {
            List<Car> cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string model = tokens[0];
                int engineSpeed = int.Parse(tokens[1]);
                int enginePower = int.Parse(tokens[2]);
                int cargoWeight = int.Parse(tokens[3]);
                string cargoType = tokens[4];
                double tyrePressure1 = double.Parse(tokens[5]);
                int tyreYear1 = int.Parse(tokens[6]);
                double tyrePressure2 = double.Parse(tokens[7]);
                int tyreYear2 = int.Parse(tokens[8]);
                double tyrePressure3 = double.Parse(tokens[9]);
                int tyreYear3 = int.Parse(tokens[10]);
                double tyrePressure4 = double.Parse(tokens[11]);
                int tyreYear4 = int.Parse(tokens[12]);

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);
                Tyre[] tyres = new Tyre[4]
                {
                    new Tyre(tyrePressure1, tyreYear1),
                    new Tyre(tyrePressure2, tyreYear2),
                    new Tyre(tyrePressure3, tyreYear3),
                    new Tyre(tyrePressure4, tyreYear4),
                };

                Car car = new Car(model, engine, cargo, tyres);
                cars.Add(car);
            }

            string cargoTypeCriteria = Console.ReadLine();
            if (cargoTypeCriteria == "fragile")
            {
                foreach (var car in cars.Where(c => c.Cargo.CargoType == "fragile"))
                {
                    foreach (var tyre in car.Tyres)
                    {
                        if (tyre.Pressure < 1)
                        {
                            Console.WriteLine(car.Model);
                            break;
                        }
                    }
                }
            }
            else if (cargoTypeCriteria == "flamable")
            {
                foreach(var car in cars.Where(c => c.Engine.EnginePower > 250 && c.Cargo.CargoType == "flamable"))
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}