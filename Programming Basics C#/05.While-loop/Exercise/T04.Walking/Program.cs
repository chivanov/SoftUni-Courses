using System;

namespace T04.Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            const int STEPS_NEEDED = 10000;
            int totalSteps = 0;


            while (totalSteps < STEPS_NEEDED)
            {
                string command = Console.ReadLine();
               
                if (command == "Going home")
                {
                    int currentSteps = int.Parse(Console.ReadLine());
                    totalSteps += currentSteps;
                    break;
                }

                int steps = int.Parse(command);
                totalSteps += steps;
            }
            int difference = Math.Abs(totalSteps - STEPS_NEEDED);
            if (totalSteps > STEPS_NEEDED)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{difference} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{difference} more steps to reach goal.");
            }
        }
    }
}
