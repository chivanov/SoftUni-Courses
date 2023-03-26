using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    internal class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;
       

        public Car()
        {
            this.Make = "VW";
            this.Model = "Golf";
            this.Year = 2025;
            this.FuelQuantity = 200;
            this.FuelConsumption = 10;
        }

        public Car(string make, string model, int year)
            :this()
        {
            this.Make = make;    
            this.Model = model;  
            this.Year = year;   
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
            :this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;   
            this.FuelConsumption = fuelConsumption; 
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires)
         
        {
            this.Make = make;
            this.Model = model; 
            this.Year= year;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.Engine = engine;
            this.Tires = tires;
        }

        public string Make
        {
            get { return make; }
            set { make = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public double FuelQuantity
        {
            get { return fuelQuantity; }
            set { fuelQuantity = value; }
        }
        public double FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }

        public int MyProperty { get; set; }

        public Engine Engine { get; set; }
        public Tire[] Tires { get; set; }
        public void Drive(double distance)
        {
            double neededFuel = distance * fuelConsumption;
            if (fuelQuantity >= neededFuel)
            {
                fuelQuantity -= neededFuel;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }
        public string WhoAmI()
        {
            string carUnfo =
                $"Make: {this.Make}\r\n" +
                $"Model: {this.Model}\r\n" +
                $"Year: {this.Year}\r\n" +
                $"Fuel: {this.FuelQuantity:F2}L";
            return carUnfo;
        }

    }
}
