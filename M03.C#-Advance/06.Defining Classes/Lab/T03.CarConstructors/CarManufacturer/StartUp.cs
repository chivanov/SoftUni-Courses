using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            string make = Console.ReadLine();
            string model = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            double fuelQuantity = double.Parse(Console.ReadLine());
            double fuelConsumption = double.Parse(Console.ReadLine());

            Car firstCar = new Car();
            Console.WriteLine($"{firstCar.Make} {firstCar.Model} {firstCar.Year} {firstCar.FuelQuantity} {firstCar.FuelConsumption}");

            Car secondCar = new Car(make, model, year);
            Console.WriteLine($"{secondCar.Make} {secondCar.Model} {secondCar.Year} {secondCar.FuelQuantity} {secondCar.FuelConsumption}");

            Car thirdCar = new Car(make, model, year, fuelQuantity, fuelConsumption);
            Console.WriteLine($"{thirdCar.Make} {thirdCar.Model} {thirdCar.Year} {thirdCar.FuelQuantity} {thirdCar.FuelConsumption}");
        }



    }
}
