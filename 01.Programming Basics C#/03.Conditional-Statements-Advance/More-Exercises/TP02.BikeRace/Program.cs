using System;
class HelloWorld
{
    static void Main()
    {
        int juniorCyclistNumber = int.Parse(Console.ReadLine());
        int seniorCyclistNumber = int.Parse(Console.ReadLine());
        string typeOfRoad = Console.ReadLine();
        double discount = 0.05;
        double juniorFee = 0;
        double seniorFee = 0;
        double totalCyclists = juniorCyclistNumber + seniorCyclistNumber;

        switch (typeOfRoad)
        {
            case "trail":
                juniorFee = 5.50;
                seniorFee = 7.00;
                break;
            case "cross-country":
                juniorFee = 8.00;
                seniorFee = 9.50;
                if (totalCyclists >= 50)
                {
                    juniorFee = juniorFee - (juniorFee * 0.25);
                    seniorFee = seniorFee - (seniorFee * 0.25);
                }
                break;
            case "downhill":
                juniorFee = 12.25;
                seniorFee = 13.75;
                break;
            case "road":
                juniorFee = 20.00;
                seniorFee = 21.50;
                break;
        }
        double totalSum = (juniorCyclistNumber * juniorFee + seniorCyclistNumber * seniorFee);
        double finalSum = totalSum - (totalSum * discount);
        Console.WriteLine($"{finalSum:f2}");
    }
}
