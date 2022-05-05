using System;

namespace TP07.FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            int stadiumCapacity = int.Parse(Console.ReadLine());
            int numberOfFans = int.Parse(Console.ReadLine());
            int aTotalFans = 0;
            int bTotalFans = 0;
            int vTotalFans = 0;
            int gTotalfans = 0;
            
            for (int i = 0; i < numberOfFans; i++)
            {
                string sector = Console.ReadLine();
                if (sector == "A")
                {
                    aTotalFans++;
                }
                else if (sector == "B")
                {
                    bTotalFans++;
                }
                else if (sector == "V")
                {
                    vTotalFans++;
                }
                else if (sector == "G")
                {
                    gTotalfans++;
                }

            }
            double percentSectorA = (double)aTotalFans / numberOfFans * 100;
            double percentSectorB = (double)bTotalFans / numberOfFans * 100;
            double percentSectorV = (double)vTotalFans / numberOfFans * 100;
            double percentSectorG = (double)gTotalfans / numberOfFans * 100;
            double percentAllFans = 1.0 * (aTotalFans + bTotalFans + vTotalFans + gTotalfans) / stadiumCapacity * 100;

            Console.WriteLine($"{percentSectorA:f2}%");
            Console.WriteLine($"{percentSectorB:f2}%");
            Console.WriteLine($"{percentSectorV:f2}%");
            Console.WriteLine($"{percentSectorG:f2}%");
            Console.WriteLine($"{percentAllFans:f2}%");
        }
    }
}
