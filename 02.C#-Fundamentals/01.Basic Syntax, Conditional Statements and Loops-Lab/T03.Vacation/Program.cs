using System;
class HelloWorld
{
    static void Main()
    {
        int people = int.Parse(Console.ReadLine());
        string groupType = Console.ReadLine();
        string day = Console.ReadLine();

        double vacationPrice = 0;

        switch (groupType)
        {
            case "Students":
                switch (day)
                {
                    case "Friday":
                        vacationPrice = 8.45;
                        break;
                    case "Saturday":
                        vacationPrice = 9.80;
                        break;
                    case "Sunday":
                        vacationPrice = 10.46;
                        break;
                }
                break;
            case "Business":
                switch (day)
                {
                    case "Friday":
                        vacationPrice = 10.90;
                        break;
                    case "Saturday":
                        vacationPrice = 15.60;
                        break;
                    case "Sunday":
                        vacationPrice = 16;
                        break;
                }
                break;

            case "Regular":
                switch (day)
                {
                    case "Friday":
                        vacationPrice = 15;
                        break;
                    case "Saturday":
                        vacationPrice = 20;
                        break;
                    case "Sunday":
                        vacationPrice = 22.50;
                        break;
                }
                break;
        }

        if (groupType == "Students" && people >= 30)
        {
            vacationPrice *= 0.85;
        }
        else if (groupType == "Business" && people >= 100)
        {
            people -= 10;
        }
        else if (groupType == "Regular" && people >= 10 && people <= 20)
        {
            vacationPrice *= 0.95;
        }

        double total = people * vacationPrice;
        Console.WriteLine($"Total price: {total:f2}");
    }
}