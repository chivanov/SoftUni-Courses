using System;

namespace TP05.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string accomodation = "";
            string location = "";

            switch (season)
            {
                case "Summer":
                    if (budget <= 1000)
                    {
                        location = "Alaska  ";
                        accomodation = "Camp";
                        budget *= 0.65;
                    }
                    else if (budget > 1000 && budget <= 3000)
                    {
                        location = "Alaska  ";
                        accomodation = "Hut";
                        budget *= 0.80;
                    }
                    else
                    {
                        location = "Alaska  ";
                        accomodation = "Hotel";
                        budget *= 0.90;
                    }
                    break;

                case "Winter":
                    if (budget <= 1000)
                    {
                        location = "Morocco   ";
                        accomodation = "Camp";
                        budget *= 0.45;
                    }
                    else if (budget > 1000 && budget <= 3000)
                    {
                        location = "Morocco   ";
                        accomodation = "Hut";
                        budget *= 0.60;
                    }
                    else
                    {
                        location = "Morocco   ";
                        accomodation = "Hotel";
                        budget *= 0.90;
                    }
                    break;
            }
            Console.WriteLine($"{location} - {accomodation} - {budget:f2}");
        }
    }
}
