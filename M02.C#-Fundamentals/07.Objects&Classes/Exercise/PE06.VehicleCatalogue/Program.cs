using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PE06.VehicleCatalogue
{

    internal class Program
    {
        internal enum VehicleType
        {
            Car,
            Truck,
        }
        internal class Vehicle
        {
            public Vehicle(VehicleType type, string model, string color, double horsePower)
            {
                this.Type = type;
                this.Model = model;
                this.Color = color;
                this.HorsePower = horsePower;
            }
            public VehicleType Type { get; }
            public string Model { get; }
            public string Color { get; }
            public double HorsePower { get; }

            public override string ToString()
            {
                StringBuilder builder = new StringBuilder();
                builder.AppendLine($"Type: {this.Type}");
                builder.AppendLine($"Model: {this.Model}");
                builder.AppendLine($"Color: {this.Color}");
                builder.AppendLine($"Horsepower: {this.HorsePower}");
                return builder.ToString().TrimEnd();
            }
            static void Main(string[] args)
            {
                List<Vehicle> vehicles = new List<Vehicle>();

                while (true)
                {
                    string command = Console.ReadLine();

                    if (command == "End")
                    {
                        break;
                    }
                    string[] input = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    VehicleType vehicleType;
                    bool isVehicleTypeParsable = Enum.TryParse(input[0], true, out vehicleType);
                    if (isVehicleTypeParsable)
                    {
                        string currModel = input[1];
                        string currColor = input[2];
                        double currHorsePower = double.Parse(input[3]);

                        var currVehicle = new Vehicle(vehicleType, currModel, currColor, currHorsePower);

                        vehicles.Add(currVehicle);
                    }

                }
                while (true)
                {
                    string cmd = Console.ReadLine();

                    if (cmd == "Close the Catalogue")
                    {
                        break;
                    }
                    Vehicle desireVehicle = vehicles.FirstOrDefault(vehicle => vehicle.Model == cmd);
                    Console.WriteLine(desireVehicle);
                }
                var cars = vehicles.Where(car => car.Type == VehicleType.Car);
                var trucks = vehicles.Where(truck => truck.Type == VehicleType.Truck);
                double carAvrHp = cars.Any() ? cars.Average(car => car.HorsePower) : 0.0;
                double truckAvrHp = trucks.Any() ? trucks.Average(truck => truck.HorsePower) : 0.0;
                Console.WriteLine($"Cars have average horsepower of: {carAvrHp:f2}.");
                Console.WriteLine($"Trucks have average horsepower of: {truckAvrHp:f2}.");
            }
        }
    }
}
