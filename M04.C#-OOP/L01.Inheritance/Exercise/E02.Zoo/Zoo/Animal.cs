using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Animal
    {
        private string name;

        public string Name { get => name; set => name = value; }

        public Animal(string name)
        {
            this.Name = name;
        }
    }
}
