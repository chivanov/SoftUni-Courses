using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", 6);  
                Engine engine = new Engine();
                Cargo cargo = new Cargo();
                List<Tire> tires = new List<Tire>();

                string model = input[0];
                engine.Speed = int.Parse(input[1]);
                engine.Power = int.Parse(input[2]);
                cargo.Weight = int.Parse(input[3]);
                cargo.Type = input[4];

                var splitTires = input[5].Split();

                for (int j = 0; j < splitTires.Length; j+=2)
                {
                    Tire tire = new Tire();
                    tire.Pressure = double.Parse(splitTires[j]);
                    tire.Age = int.Parse(splitTires[j + 1]);
                    tires.Add(tire);
                }
                Car car = new Car(model, engine, cargo, tires.ToArray());
                cars.Add(car);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                DisplayFragile(cars);
            }
            else if (command == "flammable")
            {
                DisplayFlamable(cars);
            }

            static void DisplayFragile(List<Car> cars)
            {
                foreach (var car in cars)
                {
                    string model = string.Empty;
                    foreach (var tire in car.Tires)
                    {

                        if (tire.Pressure < 1 && car.Model != model)
                        {
                            model = car.Model;
                            Console.WriteLine($"{car.Model}");
                        }
                    }

                }
            }

            static void DisplayFlamable(List<Car> cars)
            {
                foreach (var car in cars)
                {
                    if (car.Engine.Power > 250)
                        Console.WriteLine($"{car.Model}");
                }
            }
        }
    }
    
}
