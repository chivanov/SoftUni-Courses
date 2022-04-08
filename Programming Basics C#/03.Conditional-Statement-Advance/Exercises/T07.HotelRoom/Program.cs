using System;

namespace T07.HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string month = Console.ReadLine(); 
            int nights = int.Parse(Console.ReadLine ());
            double totalCostStudio = 0;
            double totalCostApartment = 0;
                      
            if (month == "May" || month == "October")
            {
                totalCostStudio = nights * 50;
                totalCostApartment = nights * 65;
                if (nights > 7 && nights <= 13)
                {
                    totalCostStudio -= totalCostStudio * 0.05;
                }
                else if (nights > 14)
                {
                    totalCostStudio -= totalCostStudio * 0.3;
                    totalCostApartment -= totalCostApartment * 0.1;
                }                
            }
            else if (month == "June" || month == "September")
            {
                totalCostStudio = nights * 75.20;
                totalCostApartment = nights * 68.70;

                if (nights > 14)
                {
                    totalCostStudio -= totalCostStudio * 0.2;
                    totalCostApartment -= totalCostApartment * 0.1;
                }
            }
            else if (month == "August" || month == "July")
            {
                totalCostStudio = nights * 76;
                totalCostApartment = nights * 77;                
                if (nights > 14)
                {  
                    totalCostApartment -= totalCostApartment * 0.1;
                }
            }
          
            Console.WriteLine($"Apartment: {totalCostApartment:F2} lv.");
            Console.WriteLine($"Studio: {totalCostStudio:F2} lv.");
             
        }
    }
}
