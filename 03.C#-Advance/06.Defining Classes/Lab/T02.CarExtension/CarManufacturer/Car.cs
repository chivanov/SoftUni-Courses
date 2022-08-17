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

        //WhoAmI() : string – returns the following message: 
        //    "Make: {this.Make}
        //     Model: {this.Model
        //        }
        //        Year: {this.Year}
        //        Fuel: {this.FuelQuantity:F2}"
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
