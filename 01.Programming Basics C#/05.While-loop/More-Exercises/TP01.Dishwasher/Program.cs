using System;

namespace TP01.Dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfBottels = int.Parse(Console.ReadLine());

            int totalNumbreOfDishes = 0;
            int totalNumberOfPots = 0;
            const double detergentPerDish = 5;
            const double detergentPerPot = 15;
            int numberOfPots = 0;
            int numberOfDishes = 0;

            int numberInputs = 0;

            string input = Console.ReadLine();
            double detergentCoantity = numberOfBottels * 750;
            double currentDetergent = 0;


            while (input != "End")
            {
                numberInputs++;

                if (numberInputs % 3 == 0)
                {
                    numberOfPots = int.Parse(input);
                    totalNumberOfPots += numberOfPots;
                    currentDetergent += numberOfPots * detergentPerPot;

                }
                else
                {
                    numberOfDishes = int.Parse(input);
                    totalNumbreOfDishes += numberOfDishes;
                    currentDetergent += numberOfDishes * detergentPerDish;
                }

                if (detergentCoantity < currentDetergent)
                {
                    double needDetergent = currentDetergent - detergentCoantity;
                    Console.WriteLine($"Not enough detergent, {needDetergent} ml. more necessary!");
                    break;

                }
                    input = Console.ReadLine();
            }
            double difference = (detergentCoantity - currentDetergent);
            if (input == "End")
            {
            Console.WriteLine("Detergent was enough!");
            Console.WriteLine($"{totalNumbreOfDishes} dishes and {totalNumberOfPots} pots were washed.");
            Console.WriteLine($"Leftover detergent {difference} ml.");
            }
           






        }
    }
}
