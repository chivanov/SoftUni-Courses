using System;

namespace T05.ExcursionSale
{
    class Program
    {
        static void Main(string[] args)
        {
            int seaTrips = int.Parse(Console.ReadLine());
            int montainTrips = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            double totalSum = 0;
            int seeCounter = 0;
            int montainCounter = 0;

            int selsCounter = 0;
            //int trips = 0;
            int totalTrips = seaTrips + montainTrips;


            while (input != "Stop")
            {
               
                              
                            
                if (input == "sea")
                {
                    if (seeCounter == seaTrips)
                    {
                        totalSum += 0;
                       
                    }
                    else
                    {
                    totalSum += 680;
                        seeCounter++;
                    selsCounter++;

                    }
                }
                else if (input == "mountain")
                {
                   if (montainCounter == montainTrips)
                    {
                        totalSum += 0;                        
                    }
                    else
                    {
                    totalSum += 499;
                    montainCounter++;
                    selsCounter++;
                    }
                }

                if (selsCounter == totalTrips)
                {
                    break;
                }

                input = Console.ReadLine(); //"sea" или "mountain"
            }

            if (selsCounter >= (seaTrips + montainTrips))
            {
                Console.WriteLine($"Good job! Everything is sold.");
            }
            Console.WriteLine($"Profit: {totalSum} leva.");

  

        }
    }
}
