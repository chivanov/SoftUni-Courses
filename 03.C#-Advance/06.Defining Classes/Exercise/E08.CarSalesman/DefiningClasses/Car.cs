using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {

        private string model;
        private Engine engine;
        private int? weight;
        private string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public int? Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }

        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = null;
            this.Color = "n/a";
        }
        public Car(string model, Engine engine, int weight)
         : this(model, engine)
        {
            this.Weight = weight;
        }

        public Car(string model, Engine engine, string color)
        : this(model, engine)
        {
            this.Color = color;
        }


        public Car(string model, Engine engine, int weight, string color)
            : this(model, engine)
        {
            this.Weight = weight;
            this.Color = color;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{this.Model}:");
            sb.AppendLine($"  {this.Engine.Model}:");
            sb.AppendLine($"   Power: {this.Engine.Power}");
            if (this.Engine.Displacement == null)
            {
                sb.AppendLine("   Displacement: n/a");
            }

            else
            {
                sb.AppendLine($"   Displacement: {this.Engine.Displacement}");
            }

            sb.AppendLine($"   Efficiency: {this.Engine.Efficiency}");
            if (this.Weight == null)
            {
                sb.AppendLine("  Weight: n/a");
            }

            else
            {
                sb.AppendLine($"  Weight: {this.Weight}");
            }

            sb.AppendLine($"  Color: {this.Color}");
            return sb.ToString().Trim();
        }
    }
}
