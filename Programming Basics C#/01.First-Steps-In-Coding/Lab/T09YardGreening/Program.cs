using System;

namespace T09YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double area = double.Parse(Console.ReadLine());

            const double oneSquireMeter = 7.61;

            double price = area * oneSquireMeter;
            double discount = price * 0.18;
            double finalPrice = price - discount;

            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
            
           
            
        }
    }
}
