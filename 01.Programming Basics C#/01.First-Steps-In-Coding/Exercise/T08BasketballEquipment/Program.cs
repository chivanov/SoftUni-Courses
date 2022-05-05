using System;

namespace T08BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int trainingFee = int.Parse(Console.ReadLine());


            double shoos = trainingFee - (trainingFee * 0.40);
            double clothing = shoos - (shoos* 0.20);
            double ball = clothing / 4;
            double accesories = ball / 5;

            double anualPrice = trainingFee + shoos + clothing + ball + accesories;
            Console.WriteLine(anualPrice);



        }
    }
}
