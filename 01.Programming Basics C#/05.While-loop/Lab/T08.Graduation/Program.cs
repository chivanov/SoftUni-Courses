using System;

namespace T08.Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();

            const double NEEDED_SCORE = 4;
            int classCounter = 1;
            int badCounter = 0;
            double totalScore = 0;

            while (classCounter <= 12)
            {
                double currentScore = double.Parse(Console.ReadLine());
                if (currentScore < NEEDED_SCORE)
                {
                    badCounter ++;
                    if (badCounter == 2)
                    {
                        Console.WriteLine($"{studentName} has been excluded at {classCounter} grade");
                        break;
                    }
                    continue;
                }

                classCounter++;
                totalScore += currentScore;
               

            }
            double avaregeScore = totalScore / 12;
            if (badCounter < 2)
            {
                Console.WriteLine($"{studentName} graduated. Average grade: {avaregeScore:f2}");
            }
        }
    }
}
