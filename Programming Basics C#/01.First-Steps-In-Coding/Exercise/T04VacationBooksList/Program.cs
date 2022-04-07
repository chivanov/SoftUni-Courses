using System;

namespace T04VacationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Брой страници в текущата книга – цяло число в интервала[1…1000]
            //2.Страници, които прочита за 1 час – цяло число в интервала[1…1000]
            //3.Броят на дните, за които трябва да прочете книгата – цяло число в интервала[1…1000

            int numberOfBookPages = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int daysForReading = int.Parse(Console.ReadLine());

            int readingTime = numberOfBookPages / pagesPerHour;
            int hoursPerDay = readingTime / daysForReading;
            Console.WriteLine(hoursPerDay);

        }
    }
}
