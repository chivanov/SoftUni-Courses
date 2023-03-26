using System;

namespace T08.BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputs = int.Parse (Console.ReadLine ());

            double biggestKeg = 0;
            string currModel = string.Empty;

            for (int i = 0; i < inputs; i++)
            {
                string kegModel = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int hieght = int.Parse(Console.ReadLine());

                double kegVolume = Math.PI * ((radius * radius) * hieght);

               
                if (kegVolume > biggestKeg)
                {
                    biggestKeg=kegVolume;
                    currModel = kegModel;

                }
            }

            Console.WriteLine($"{currModel}");
           


        }
    }
}
