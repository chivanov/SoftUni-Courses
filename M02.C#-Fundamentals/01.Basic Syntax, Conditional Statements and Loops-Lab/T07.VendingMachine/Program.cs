using System;

namespace T07.VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double sum = 0;
             
            const double NUTSPRICE = 2.0;
            const double WATERPRICE = 0.7;
            const double CRIPSPRICE = 1.5;
            const double SODAPRICE = 0.8;
            const double COKEPRICE = 1.0;


            while (input != "Start")
            {
                double coin = double.Parse(input);

                if (coin == 0.1 || coin == 0.2 || coin == 0.5 || coin == 1 || coin == 2)
                {
                    sum += coin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coin}");    
                }
                input = Console.ReadLine();
            }

            string purchesInput = Console.ReadLine();
            //string product = String.Empty;

            while (purchesInput != "End")
            {
                if (purchesInput == "Nuts")
                {
                    if (sum >= NUTSPRICE)
                    {
                        Console.WriteLine("Purchased nuts");
                        sum -= NUTSPRICE;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (purchesInput == "Water")
                {
                    if (sum >= WATERPRICE)
                    {
                        Console.WriteLine("Purchased water");
                        sum -= WATERPRICE;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (purchesInput == "Crisps")
                {
                    if (sum >= CRIPSPRICE)
                    {
                        Console.WriteLine("Purchased crips");
                        sum -= CRIPSPRICE;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (purchesInput == "Soda")
                {
                    if (sum >= SODAPRICE)
                    {
                        Console.WriteLine("Purchased soda");
                        sum -= SODAPRICE;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (purchesInput == "Coke")
                {
                    if (sum >= COKEPRICE)
                    {
                        Console.WriteLine("Purchased coke");
                        sum -= COKEPRICE;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                purchesInput = Console.ReadLine();
            }

            Console.WriteLine($"Change: {sum:f2}");
        }
    }
}
