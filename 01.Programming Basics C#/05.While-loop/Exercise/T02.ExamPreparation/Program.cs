using System;

namespace T02.ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberFails = int.Parse(Console.ReadLine());
            int totalScore = 0;

            int tasksCount = 0;
            int badCounter = 0;
            string lastTask = "";

            string taskName = Console.ReadLine();

            const int BAD_SCORE = 4;

            while (taskName != "Enough")
            {
                int currentScoure = int.Parse(Console.ReadLine());
                tasksCount++;
                lastTask = taskName;
                totalScore += currentScoure;
                if (currentScoure <= BAD_SCORE)
                {
                    badCounter++;
                    if (badCounter == numberFails)
                    {
                        Console.WriteLine($"You need a break, {badCounter} poor grades.");
                        break;
                    }
                }
                taskName = Console.ReadLine();
            }
            double avarageScore = 1.0 * totalScore / tasksCount;
            if (taskName == "Enough")
            {
                Console.WriteLine($"Average score: {avarageScore:f2}");
                Console.WriteLine($"Number of problems: {tasksCount}");
                Console.WriteLine($"Last problem: {lastTask}");
            }

        }
    }
}
