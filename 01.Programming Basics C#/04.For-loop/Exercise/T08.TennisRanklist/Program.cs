using System;

namespace T08.TennisRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTurnaments = int.Parse(Console.ReadLine());
            int initialScore = int.Parse(Console.ReadLine());
            int totalScore = initialScore;
            int totalWins = 0;

            for (int i = 0; i < numberOfTurnaments; i++)
            {
                string finishPlace = Console.ReadLine();

                if (finishPlace == "W")
                {
                    totalScore += 2000;
                    totalWins += 1;
                }
                else if (finishPlace == "F")
                {
                    totalScore += 1200;
                }
                else if (finishPlace == "SF")
                {
                    totalScore += 720;
                }
            }
            int avarageScore = (totalScore - initialScore) / numberOfTurnaments;
            double percentWins = (double)totalWins / numberOfTurnaments * 100;

            Console.WriteLine($"Final points: {totalScore}");
            Console.WriteLine($"Average points: {avarageScore}");
            Console.WriteLine($"{percentWins:f2}%");
        }
    }
}
