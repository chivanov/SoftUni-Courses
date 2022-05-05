using System;

namespace T06.CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int totalStudents = 0;
            int totalStandards = 0;
            int totalKids = 0;
            int totalTickets = 0;

            while (input != "Finish")
            {
                int student = 0;
                int standard = 0;
                int kid = 0;
                int freeSeats = int.Parse(Console.ReadLine());

                for (int i = 0; i < freeSeats; i++)
                {
                    string ticketType = Console.ReadLine();
                    if (ticketType == "End")
                    {
                        break;
                    }
                    switch (ticketType)
                    {
                        case "student":
                            student++;
                            break;
                        case "standard":
                            standard++;
                            break;
                        case "kid":
                            kid++;
                            break;
                    }
                }

                totalStudents += student;
                totalStandards += standard;
                totalKids += kid;
                double percentFull = (student + standard + kid) / (double)freeSeats * 100;
                Console.WriteLine($"{input} - {percentFull:f2}% full.");

                input = Console.ReadLine();
            }

            totalTickets = totalStudents + totalStandards + totalKids;
            Console.WriteLine($"Total tickets: {totalTickets}");

            double percentStudent = totalStudents / (double)totalTickets * 100;
            double percentStandards = totalStandards / (double)totalTickets * 100;
            double percentKids = totalKids / (double)totalTickets * 100;
            Console.WriteLine($"{percentStudent:f2}% student tickets.");
            Console.WriteLine($"{percentStandards:f2}% standard tickets.");
            Console.WriteLine($"{percentKids:f2}% kids tickets.");
        }
    }
}
