using System;

namespace TP06.TruckDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kilometers = double.Parse(Console.ReadLine());

            double pricePerKilometer = 0;

            switch (season)
            {
                case "Spring":
                case "Autumn":
                    if (kilometers <= 5000)
                    {
                        pricePerKilometer = 0.75;
                    }
                    else if (kilometers > 5000 && kilometers <= 10000)
                    {
                        pricePerKilometer = 0.95;
                    }
                    else if (kilometers > 10000 && kilometers <= 20000)
                    {
                        pricePerKilometer = 1.45;
                    }
                    break;

                case "Summer":
                    if (kilometers <= 5000)
                    {
                        pricePerKilometer = 0.90;
                    }
                    else if (kilometers > 5000 && kilometers <= 10000)
                    {
                        pricePerKilometer = 1.10;
                    }
                    else if (kilometers > 10000 && kilometers <= 20000)
                    {
                        pricePerKilometer = 1.45;
                    }
                    break;
                case "Winter":
                    if (kilometers <= 5000)
                    {
                        pricePerKilometer = 1.05;
                    }
                    else if (kilometers > 5000 && kilometers <= 10000)
                    {
                        pricePerKilometer = 1.25;
                    }
                    else if (kilometers > 10000 && kilometers <= 20000)
                    {
                        pricePerKilometer = 1.45;
                    }
                    break;
            }
            double totalKilometersPerSeason = kilometers * 4;
            double seasonIncom = totalKilometersPerSeason * pricePerKilometer;
            double finalIncom = seasonIncom - (seasonIncom * 0.10);
            Console.WriteLine($"{finalIncom:f2}");
        }
    }
}
