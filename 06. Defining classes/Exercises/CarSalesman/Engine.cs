using System.Text;

namespace CarSalesman
{
    class Engine
    {
        public Engine(string model, int power)
        {
            Model = model;
            Power = power;
        }

        public Engine(string model, int power, int? displacement)
            : this(model, power)
        {
            Displacement = displacement;
        }

        public Engine(string model, int power, int? displacement, string efficiency)
            : this(model, power, displacement)
        {
            Efficiency = efficiency;
        }

        public string Model { get; set; }
        public int Power { get; set; }
        public int? Displacement { get; set; }
        public string Efficiency { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Model}");
            sb.AppendLine($"   Power: {this.Power}");
            if (this.Displacement != null)
            {
                sb.AppendLine($"      Displacement: {this.Displacement}");
            }
            else
            {
                sb.AppendLine($"      Displacement: n/a");
            }
            if (Efficiency != null)
            {
                sb.AppendLine($"      Efficiency: {this.Efficiency}");
            }
            else
            {
                sb.AppendLine($"      Efficiency: n/a");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
