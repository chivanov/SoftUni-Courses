using System;

namespace TP03.Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDeliveries = int.Parse(Console.ReadLine());
            
            int tonsTo3 = 0;
            int tonsTo11 = 0;
            int tonsOver12 = 0;

            const int priceOfMinibus = 200;
            const int priceOftruck = 175;
            const int priceOfTrain = 120;
            

            for (int i = 0; i < numberOfDeliveries; i++)
            {
                int tonsOfCargo = int.Parse(Console.ReadLine());

                if (tonsOfCargo <= 3)
                {
                    tonsTo3 += tonsOfCargo;
                }
                else if (tonsOfCargo >= 4 && tonsOfCargo <= 11)
                {
                    tonsTo11 += tonsOfCargo;
                }
                else
                {
                    tonsOver12 += tonsOfCargo;
                }
            }

            int totalTons = tonsTo3 + tonsTo11 + tonsOver12;

            int totalCost = tonsTo3 * priceOfMinibus + tonsTo11 * priceOftruck + tonsOver12 * priceOfTrain;

            double avaragePrice = 1.0 * totalCost / totalTons;

            double percentMinibus = (double)tonsTo3 / totalTons * 100;
            double percentTruck = (double)tonsTo11 / totalTons * 100;
            double percentTrain = (double)tonsOver12 / totalTons * 100;

            Console.WriteLine($"{avaragePrice:f2}");
            Console.WriteLine($"{percentMinibus:f2}%");
            Console.WriteLine($"{percentTruck:f2}%");
            Console.WriteLine($"{percentTrain:f2}%");
        }
    }
}
