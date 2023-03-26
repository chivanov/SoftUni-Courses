using System;

namespace TP07.SchoolCamp
{
    class Program
    {
        static void Main(string[] args)
        {

            string season = Console.ReadLine();
            string groupType = Console.ReadLine();
            int studentNumber = int.Parse(Console.ReadLine());
            int numberOfNifgts = int.Parse(Console.ReadLine());

            double roomRate = 0;
            string sportType = "";

           
            //2.Видът на групата – текст - “boys”, “girls” или “mixed”;

            switch (season)
            {
                case "Winter":
                    switch (groupType)
                    {
                        case "boys":
                            sportType ="Judo";
                            roomRate = 9.60;
                            break;
                        case "girls":
                            sportType = "Gymnastics";
                            roomRate = 9.60;
                            break;
                        case "mixed":
                            sportType = "Ski";
                            roomRate = 10.00;
                            break;
                    }
                    break;
                case "Spring":
                    switch (groupType)
                    {
                        case "boys":
                            sportType = "Tennis";
                            roomRate = 7.20;
                            break;
                        case "girls":
                            sportType = "Athletics";
                            roomRate = 7.20;
                            break;
                        case "mixed":
                            sportType = "Cycling";
                            roomRate = 9.50;
                            break;
                    }
                    break;
                case "Summer":
                    switch (groupType)
                    {
                        case "boys":
                            sportType = "Football";
                            roomRate = 15.00;
                            break;
                        case "girls":
                            sportType = "Volleyball";
                            roomRate = 15.00;
                            break;
                        case "mixed":
                            sportType = "Swimming";
                            roomRate = 20.00;
                            break;
                    }
                    break;
            }
            double totalPrice = numberOfNifgts * studentNumber * roomRate;

            if (studentNumber >= 10 && studentNumber < 20)
            {
                totalPrice -= totalPrice * 0.05;
            }
            else if (studentNumber >= 20 && studentNumber < 50)
            {
                totalPrice -= totalPrice * 0.15;
            }
            else if (studentNumber >= 50)
            {
                totalPrice -= totalPrice * 0.50;
            }

            Console.WriteLine($"{sportType} {totalPrice:f2} lv.");
        }
    }
}
