using FoodShortage.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShortage.Models
{
    public class Rebel : IBuyer
    {
        public Rebel(string name, int age, string group)
        {
            this.Name = name;
            this.Age = age;
            this.Group = group;
        }
        public string Name { get; }

        public int Food { get; private set; }
        public int Age { get; private set; }
        public string Group { get; private set; }

        public void BuyFood()
        {
            this.Food += 5;
        }
    }
}
