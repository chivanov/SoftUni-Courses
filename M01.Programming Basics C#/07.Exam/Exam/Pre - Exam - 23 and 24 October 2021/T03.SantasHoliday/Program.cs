using System;

namespace T03.SantasHoliday
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string typeRoom = Console.ReadLine();
            string review = Console.ReadLine();

            const double SINGLE_ROOM = 18.00;
            const double APARTMENT = 25.00;
            const double PRECIDENT_APARTMENT = 35.00;

            double roomPrice = 0;
            int nignts = days - 1;

            switch (typeRoom)
            {
               case "room for one person":
                    if (days < 10)
                    {
                        roomPrice = SINGLE_ROOM;

                    }
                    else if (days >= 10 && days <15)
                    {
                        roomPrice = SINGLE_ROOM;
                    }
                    else if (days >= 15)
                    {
                        roomPrice = SINGLE_ROOM;
                    }
                    break;
                       
                case "apartment":
                    if (days < 10)
                    {
                        roomPrice = APARTMENT * 0.70;

                    }
                    else if (days >= 10 && days < 15)
                    {
                        roomPrice = APARTMENT * 0.65;
                    }
                    else if (days >= 15)
                    {
                        roomPrice = APARTMENT * 0.50;
                    }
                    break;
                case "president apartment":
                    if (days < 10)
                    {
                        roomPrice = PRECIDENT_APARTMENT * 0.10;


                    }
                    else if (days >= 10 && days < 15)
                    {
                        roomPrice = PRECIDENT_APARTMENT * 0.85;
                    }
                    else if (days >= 15)
                    {
                        roomPrice = PRECIDENT_APARTMENT * 0.80;

                    }
                    break;
            }

            double totalSum = nignts * roomPrice;


            if (review == "positive")
            {
                totalSum += totalSum * 0.25;
            }
            else if (review == "negative")
            {
                totalSum -= totalSum * 0.10;
            }

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
