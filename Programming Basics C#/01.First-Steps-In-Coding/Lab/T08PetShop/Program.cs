using System;

namespace T08PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Броят на опаковките храна за кучета – цяло число в интервала[0… 100]
            //2.Броят на опаковките храна за котки –  цяло число в интервала[0… 100]
            int dogFoot = int.Parse(Console.ReadLine());
            int otherFood = int.Parse(Console.ReadLine());

            const double dogFoodPrice = 2.50;
            const double otherFoodPrice = 4.00;

            double totalPrice = dogFoot * dogFoodPrice + otherFood * otherFoodPrice;
            Console.WriteLine($"{totalPrice} lv.");
                          
        }
    }
}
