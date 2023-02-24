using System.Reflection;

namespace CarSalesman
{
    class StartUp
    {
        static void Main()
        {
            List<Engine> engines = new List<Engine>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string model = tokens[0];
                int power = int.Parse(tokens[1]);
                int? displacement = null;
                string efficiency = string.Empty;

                if (tokens.Length == 3)
                {
                    if (!int.TryParse(tokens[2], out int checkDisplacement))
                    {
                        efficiency = tokens[2];
                    }
                    else
                    {
                        displacement = checkDisplacement;
                    }
                }
                else if (tokens.Length == 4)
                {
                    displacement = int.Parse(tokens[2]);
                    efficiency = tokens[3];
                }
                Engine engine = new Engine(model, power, displacement, efficiency);
                engines.Add(engine);
            }

            List<Car> cars = new List<Car>();
            int m = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();


                string model = tokens[0];
                string engineModel = tokens[1];
                Engine engine = engines.FirstOrDefault(e => e.Model == engineModel);
                int? weight = null;
                string color = null;
                if (tokens.Length == 3)
                {
                    if (!int.TryParse(tokens[2], out int checkWeight))
                    {
                        color = tokens[2];
                    }
                    else
                    {
                        weight = checkWeight;
                    }
                }
                else if (tokens.Length == 4)
                {
                    weight = int.Parse(tokens[2]);
                    color = tokens[3];
                }

                Car car = new Car(model, engine, weight, color);
                cars.Add(car);

            }

            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}