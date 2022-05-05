using System;

namespace T03.TimePlus15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += 15;

            if (minutes >= 60)
            {
                minutes -= 60;
                hour += 1;
            }
            if (hour >= 24)
            {
                hour = 0;
            }

            Console.WriteLine ($"{hour}:{minutes:D2}");
        }
    }
}
