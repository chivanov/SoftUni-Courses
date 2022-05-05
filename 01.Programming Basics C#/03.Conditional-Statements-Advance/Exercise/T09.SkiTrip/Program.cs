using System;

namespace T09.SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            const double ROOM_FOR_ONE_PERSON = 18.00;
            const double APARTMENT = 25.00;
            const double PRESIDENT_APARTMENT = 35.00;

            //•	Първи ред -дни за престой -цяло число в интервала[0...365]
            //•	Втори ред -вид помещение - "room for one person", "apartment" или "president apartment"
            //•	Трети ред -оценка - "positive"  или "negative"

            int daysOfVacation = int.Parse(Console.ReadLine());
            string typeOfRoom = Console.ReadLine();
            string assesment = Console.ReadLine();

            int nights = daysOfVacation - 1;
            double totalCost = 0;

            switch (typeOfRoom)
            {
                case "room for one person":
                    totalCost = nights * ROOM_FOR_ONE_PERSON;
                    break;
                case "apartment":
                    totalCost = nights * APARTMENT;
                    if (daysOfVacation < 10)
                    {
                        totalCost -= totalCost * 0.3;
                    }
                    else if (daysOfVacation >= 10 && daysOfVacation <= 15)
                    {
                        totalCost -= totalCost * 0.35;
                    }
                    
                    else
                    {
                        totalCost -= totalCost * 0.5;
                    }
                    break;
                case "president apartment":
                    totalCost = nights * PRESIDENT_APARTMENT;
                    if (daysOfVacation < 10)
                    {
                        totalCost -= totalCost * 0.1;
                    }
                    else if (daysOfVacation >= 10 && daysOfVacation <= 15)
                    {
                        totalCost -= totalCost * 0.15;
                    }

                    else
                    {
                        totalCost -= totalCost * 0.2;
                    }
                    break;
            }
            switch (assesment)                
            {
                case "positive":
                    totalCost += totalCost * 0.25;
                    break;
                case "negative":
                    totalCost -= totalCost * 0.1;
                    break;
            }
            Console.WriteLine($"{totalCost:f2}");



        }
    }
}
