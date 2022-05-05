using System;

namespace T04.Workout
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double kilometresdayOne = int.Parse(Console.ReadLine());
            double totalKilometers = kilometresdayOne;

            for (int i = 0; i < days; i++)
            {
                int percentIncrease = int.Parse(Console.ReadLine());
               
                kilometresdayOne += kilometresdayOne * percentIncrease / 100.00;
                totalKilometers += kilometresdayOne;
            }

            double difference = Math.Abs (1000 - totalKilometers);

            if (totalKilometers >= 1000)
            {
                Console.WriteLine($"You've done a great job running {Math.Ceiling(difference)} more kilometers!");
            }
            else
            {
                Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {Math.Ceiling(difference)} more kilometers");
            }

        }

    }
}
