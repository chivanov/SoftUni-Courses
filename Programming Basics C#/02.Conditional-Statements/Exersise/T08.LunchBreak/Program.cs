using System;

namespace T08.LunchBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Име на сериал – текст
            //2.Продължителност на епизод  – цяло число в диапазона[10… 90]
            //3.Продължителност на почивката  – цяло число в диапазона[10… 120]

            string episoteName = Console.ReadLine();
            int episoteTime = int.Parse(Console.ReadLine());
            int breakTime = int.Parse(Console.ReadLine());

            double lunchTime = breakTime / 8.0;
            double relaxTime = breakTime / 4.0;

            double timeForWotching = breakTime - (lunchTime + relaxTime);
            double difference = Math.Abs(episoteTime -  timeForWotching);
            //•	Ако времето е достатъчно да изгледате епизода:
            //"You have enough time to watch {име на сериал} and left with {останало време} minutes free time."
            //•	Ако времето не Ви е достатъчно:
            //"You don't have enough time to watch {име на сериал}, you need {нужно време} more minutes."
            //Времето да се закръгли до най-близкото цяло число нагоре.

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
