using System;

namespace EP01.TheBiscuitFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double biscuitsPerDayPerWorker = int.Parse(Console.ReadLine());
            double workersNumber = int.Parse(Console.ReadLine());
            double biscuitsOfOtherCompanies = int.Parse(Console.ReadLine());

            const int workingDays = 30;
            double totalBiscuits = 0;

            for (int day = 1; day <= workingDays; day++)
            {
                double totalBiscuitsPerDay = biscuitsPerDayPerWorker * workersNumber;
                if (day % 3 == 0)
                {
                    totalBiscuits += totalBiscuitsPerDay * 0.75;
                    totalBiscuits = Math.Floor(totalBiscuits);
                }
                else
                {
                    totalBiscuits += totalBiscuitsPerDay;
                }
            }

            if (totalBiscuits < biscuitsOfOtherCompanies)
            {
                double difference = biscuitsOfOtherCompanies - totalBiscuits;
                double percent = difference / biscuitsOfOtherCompanies * 100;
                Console.WriteLine($"You have produced {totalBiscuits} biscuits for the past month.");
                Console.WriteLine($"You produce {percent:f2} percent less biscuits.");
            }
            else
            {
                double difference = Math.Abs(biscuitsOfOtherCompanies - totalBiscuits);
                double percent = difference / biscuitsOfOtherCompanies * 100;
                Console.WriteLine($"You have produced {totalBiscuits} biscuits for the past month.");
                Console.WriteLine($"You produce {percent:f2} percent more biscuits.");
            }


        }
    }
}