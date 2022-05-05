using System;

namespace T04VacationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {          
            int numberOfBookPages = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int daysForReading = int.Parse(Console.ReadLine());

            int readingTime = numberOfBookPages / pagesPerHour;
            int hoursPerDay = readingTime / daysForReading;
            Console.WriteLine(hoursPerDay);

        }
    }
}
