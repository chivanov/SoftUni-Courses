using System;

namespace T05.Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double totalMoney = 0;

            if (budget <= 100)
            {
                if (season == "summer")
                {
                    totalMoney = budget * 0.30;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Camp - {totalMoney:F2}");
                }
                else
                {
                    totalMoney = budget * 0.70;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Hotel - {totalMoney:F2}");
                }


            }
            else if (budget > 100 && budget <= 1000)
            {
                if (season == "summer")
                {
                    totalMoney = budget * 0.40;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Camp - {totalMoney:F2}");
                }
                else
                {
                    totalMoney = budget * 0.80;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Hotel - {totalMoney:F2}");
                }
            }
            else if (budget > 1000)
            {
                totalMoney = budget * 0.90;
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine($"Hotel - {totalMoney:F2}");
            }           
        }
    }
}
