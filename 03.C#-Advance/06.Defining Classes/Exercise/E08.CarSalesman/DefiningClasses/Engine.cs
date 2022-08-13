using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Engine
    {
       
        private string model;
        private string power;
        private int? displacement;
        private string efficiency;
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public string Power
        {
            get { return power; }
            set { power = value; }
        }
        public int? Displacement
        {
            get { return displacement; }
            set { displacement = value; }
        }
        public string Efficiency
        {
            get { return efficiency; }
            set { efficiency = value; }
        }
        public Engine(string model, string power)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = null;
            this.Efficiency = "n/a";
        }

        public Engine(string model, string power, int displacement)
           : this(model, power)
        {
            this.Displacement = displacement;
        }

        public Engine(string model, string power, string efficiency)
          : this(model, power)
        {
            this.Efficiency = efficiency;
        }

        public Engine(string model, string power, int displacement, string efficiency)
            : this(model, power)
        {
            this.Displacement = displacement;
            this.Efficiency = efficiency;
        }

    }
}
