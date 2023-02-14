namespace SoftUniParking
{
    class Parking
    {
        private IEnumerable<Car> cars;
        private int capacity; 
        public Parking(int capacity)
        {
            Capacity = capacity;
            Cars = new List<Car>();
        }

        public int Capacity { get; set; }
        public List<Car> Cars { get; set; }

        public int Count { get; set; }

        public string AddCar(Car car)
        {
            if (Cars.Any(c => c.RegistrationNumber == car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }
            else if(Capacity == Cars.Count())
            {
                return "Parking is full!";
            }
            else
            {
                Cars.Add(car);
                Count++;
                return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
            }
        }
    
        public string RemoveCar(string registrationNumber)
        {
            Car neededCar = Cars.FirstOrDefault(c => c.RegistrationNumber == registrationNumber);
            if (neededCar == null)
            {
                return "Car with that registration number, doesn't exist!";
            }
            else
            {
                Cars.Remove(neededCar);
                Count--;
                return $"Successfully removed {registrationNumber}";
            }
        }

        public Car GetCar(string registrationNumber)
        {
            return Cars.FirstOrDefault(c => c.RegistrationNumber == registrationNumber);
        }

        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            foreach (var registrationNumber in registrationNumbers)
            {
                Car neededCar = Cars.FirstOrDefault(c => c.RegistrationNumber == registrationNumber);
                if(neededCar != null)
                {
                    Cars.Remove(neededCar);
                    Count--;
                }
            }
            Console.WriteLine(Cars.Count);
        }
    }
}