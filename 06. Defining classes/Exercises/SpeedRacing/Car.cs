using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedRacing
{
    class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelCOnsumptionPerKilomter { get; set; }
        public double TravelledDistance { get; set; }

        public Car(string model, double fuelAmount, double fuelConsumptionFor1Km)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelCOnsumptionPerKilomter = fuelConsumptionFor1Km;
        }

        public void Drive(int distance)
        {
            double neededFuel = distance * this.FuelCOnsumptionPerKilomter;
            if (neededFuel <= FuelAmount)
            {
                this.FuelAmount -= neededFuel;
                this.TravelledDistance += distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
        
    }
}
