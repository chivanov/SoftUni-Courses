using System;
using System.Collections.Generic;

namespace T07.ParkingLot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            HashSet<string> parkedCars = new HashSet<string>(); 
            while (input != "END")
            {
                string command = input.Split(", ")[0];
                string carNumberPlate = input.Split(", ")[1];
                switch (command)
                {
                    case "IN":
                        parkedCars.Add(carNumberPlate); 
                        break;
                    case "OUT":
                        parkedCars.Remove(carNumberPlate);
                        break;
                }

                input = Console.ReadLine();
            }

            if (parkedCars.Count > 0)
            {
                foreach (var car in parkedCars)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
