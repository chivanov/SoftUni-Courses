using System;

namespace T08BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int trainingFee = int.Parse(Console.ReadLine());

            //•	Баскетболни кецове – цената им е 40 % по - малка от таксата за една година
            //•	Баскетболен екип – цената му е 20 % по - евтина от тази на кецовете
            //•	Баскетболна топка – цената ѝ е 1 / 4 от цената на баскетболния екип
            //•	Баскетболни аксесоари – цената им е 1 / 5 от цената на баскетболната топка

            double shoos = trainingFee - (trainingFee * 0.40);
            double clothing = shoos - (shoos* 0.20);
            double ball = clothing / 4;
            double accesories = ball / 5;

            double anualPrice = trainingFee + shoos + clothing + ball + accesories;
            Console.WriteLine(anualPrice);



        }
    }
}
