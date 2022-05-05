using System;

namespace T06.WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {

            double worldRecord = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timePerMeter = double.Parse(Console.ReadLine());

            double time = distance * timePerMeter;
            double reduceTime = Math.Floor(distance / 15) * 12.5;
            double realTime = time + reduceTime;

            double difference = realTime - worldRecord;

            if (realTime < worldRecord)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {realTime:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {difference:F2} seconds slower.");
            }



        }
    }
}
