using System;
using System.Collections.Generic;
using System.Linq;

namespace PL07.VehicleCatalogue
{
    class Truck
    {
        public Truck(string Brand, string Model, int Weight)
        {
            this.Brand = Brand;
            this.Model = Model;
            this.Weight = Weight;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }

    }

    class Car
    {
        public Car(string Brand, string Model, int HorsePower)
        {
            this.Brand = Brand;
            this.Model = Model;
            this.HorsePower = HorsePower;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }

    class Catalog
    {
        public Catalog()
        {
            this.Trucks = new List<Truck>();
            this.Cars = new List<Car>();
        }
        public List<Truck> Trucks { get; set; }
        public List<Car> Cars { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Catalog catalogObgect = new Catalog();

            while (command != "end")
            {
                string[] input = command.Split('/', StringSplitOptions.RemoveEmptyEntries);
                string type = input[0];
                string brand = input[1];
                string model = input[2];
                int thirdElement = int.Parse(input[3]);

                if (type == "Car")
                {
                    Car newCar = new Car(brand, model, thirdElement);
                    catalogObgect.Cars.Add(newCar);
                }


                if (type == "Truck")
                {
                    Truck newTruck = new Truck(brand, model, thirdElement);
                    catalogObgect.Trucks.Add(newTruck);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("Cars:");
            List<Car> orderedCars = catalogObgect.Cars.OrderBy(car => car.Brand).ToList();

            foreach (Car car in orderedCars)
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }

            Console.WriteLine("Trucks:");

            List<Truck> orderedTrucks = catalogObgect.Trucks.OrderBy(truck => truck.Brand).ToList();

            foreach (Truck truck in orderedTrucks)
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
        }
    }
}
