using System;

namespace Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double roomLength = double.Parse(Console.ReadLine());
            double roomWidth = double.Parse(Console.ReadLine());

            int coridorWidth = 100;
            int workPlaceWidth = 70;
            int workPlaceLength = 120;

            double usedRoomWidthCm = roomWidth * 100 - coridorWidth;
            
            double numberRaws = Math.Floor(usedRoomWidthCm / workPlaceWidth);
            double numberComoms = Math.Floor((roomLength *100) / workPlaceLength);

            double totalWorkPlaces = (numberRaws * numberComoms) - 3;

            Console.WriteLine(totalWorkPlaces);

        }
    }
}
