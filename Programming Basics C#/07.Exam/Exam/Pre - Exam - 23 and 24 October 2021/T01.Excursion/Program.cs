using System;

namespace T01.Excursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleNumber = int.Parse(Console.ReadLine());
            int numberOfNights = int.Parse(Console.ReadLine());
            int transportCards = int.Parse(Console.ReadLine());
            int museumTickets = int.Parse(Console.ReadLine());

            
            int sumAccomodation = numberOfNights * 20;
            double sumTransport = transportCards * 1.60;
            int sumMuseum = museumTickets * 6;

            double totalSum = (sumTransport + sumAccomodation + sumMuseum) * peopleNumber;
            double finalSum = totalSum + (totalSum * 0.25);

            Console.WriteLine($"{finalSum:f2}");



        }
    }
}
