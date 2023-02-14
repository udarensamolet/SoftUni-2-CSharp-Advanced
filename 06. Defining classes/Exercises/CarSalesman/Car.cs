using System.Text;

namespace CarSalesman
{
    class Car
    {
        public Car(string model, Engine engine)
        {
            Model = model;
            Engine = engine;
        }
        public Car(string model, Engine engine, int? weight)
            : this(model, engine)
        {
            Weight = weight;
        }

        public Car(string model, Engine engine, int? weight, string? color)
            : this(model, engine)
        {
            Weight = weight;
            Color = color;
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int? Weight { get; set; }
        public string? Color { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Model}:");
            sb.AppendLine($"   {this.Engine.ToString()}");
            if (Weight != null)
            {
                sb.AppendLine($"   Weight: {this.Weight}");
            }
            else
            {
                sb.AppendLine($"   Weight: n/a");
            }
            if (Color != null)
            {
                sb.AppendLine($"   Color: {this.Color}");
            }
            else
            {
                sb.AppendLine($"   Color: n/a");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
