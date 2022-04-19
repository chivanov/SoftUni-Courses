using System;

namespace T06.Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double academyScore = double.Parse(Console.ReadLine ());
            int numberOfEvaluators = int.Parse (Console.ReadLine ());
            double totalScore = academyScore;

            for (int i = 0; i < numberOfEvaluators; i++)
            {
                string nameOfEvaluator = Console.ReadLine();
                double evaluatorScore = double.Parse (Console.ReadLine());

                totalScore += (nameOfEvaluator.Length * evaluatorScore) / 2;
                if (totalScore > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {totalScore:f1}!");
                    break;
                }

            }
            double difference = Math.Abs(1250.5 - totalScore);
            if (totalScore < 1250.5)
            {
                Console.WriteLine($"Sorry, {actorName} you need {difference:f1} more!");
            }
                
        }
    }
}
