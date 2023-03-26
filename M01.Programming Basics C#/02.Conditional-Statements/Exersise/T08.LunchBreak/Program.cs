using System;

namespace T08.LunchBreak
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string episoteName = Console.ReadLine();
            int episoteTime = int.Parse(Console.ReadLine());
            int breakTime = int.Parse(Console.ReadLine());

            double lunchTime = breakTime / 8.0;
            double relaxTime = breakTime / 4.0;

            double timeForWotching = breakTime - (lunchTime + relaxTime);
            double difference = Math.Abs(episoteTime -  timeForWotching);
           

            if (timeForWotching >= episoteTime)
            {
                Console.WriteLine($"You have enough time to watch {episoteName} and left with {Math.Ceiling (difference)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {episoteName}, you need {Math.Ceiling (difference)} more minutes.");
            }
        }
    }
}
