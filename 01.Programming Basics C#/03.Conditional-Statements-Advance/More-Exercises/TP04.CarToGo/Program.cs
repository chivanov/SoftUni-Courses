using System;

namespace TP04.CarToGo
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string typeOfCar = "";
            string classOfCar = "";

            switch (season)
            {
                case "Summer":
                    if (budget < 100)
                    {
                        classOfCar = "Economy class";
                        typeOfCar = "Cabrio";
                        budget *= 0.35;
                    }
                    else if (budget > 100 && budget <= 500)
                    {
                        classOfCar = "Compact class";
                        typeOfCar = "Cabrio";
                        budget *= 0.45;
                    }
                    else
                    {
                        classOfCar = "Luxury class";
                        typeOfCar = "Jeep";
                        budget *= 0.90;
                    }
                    break;

                case "Winter":
                    if (budget < 100)
                    {
                        classOfCar = "Economy class";
                        typeOfCar = "Jeep";
                        budget *= 0.65;
                    }
                    else if (budget > 100 && budget <= 500)
                    {
                        classOfCar = "Compact class";
                        typeOfCar = "Jeep";
                        budget *= 0.80;
                    }
                    else
                    {
                        classOfCar = "Luxury class";
                        typeOfCar = "Jeep";
                        budget *= 0.90;
                    }
                    break;
            }
            Console.WriteLine($"{classOfCar}");
            Console.WriteLine($"{typeOfCar} - {budget:f2}");

        }
    }
}
