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
             
                string input = Console.ReadLine();

                string model = input.Split()[0];
                double fuelAmount = double.Parse(input.Split()[1]);   
                double fuelConsumptionFor1km = double.Parse(input.Split()[2]);

                Car currCar = new Car(model, fuelAmount, fuelConsumptionFor1km);

                cars.Add(currCar);  
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                //"Drive {carModel} {amountOfKm}"
                string carModel = command.Split()[1];
                double amountOfKm = double.Parse(command.Split()[2]);
                Car carToDrive = cars.First(car => car.Model == carModel);
                carToDrive.Drive(amountOfKm); 

                command = Console.ReadLine();
            }
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
