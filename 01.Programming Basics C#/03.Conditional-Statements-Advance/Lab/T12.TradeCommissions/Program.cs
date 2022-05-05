using System;

namespace T12.TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sells = double.Parse(Console.ReadLine());
            double commicion = 0;



            switch (town)
            {
                case "Sofia":
                    if (sells >= 0 && sells <= 500)
                    {
                        commicion = 0.05;
                    }
                    else if (sells > 500 && sells <= 1000)
                    {
                        commicion = 0.07;
                    }
                    else if (sells > 1000 && sells <= 10000)
                    {
                        commicion = 0.08;
                    }
                    else if (sells > 10000)
                    {
                        commicion = 0.12;
                    }
                    break;
                case "Varna":
                    if (sells >= 0 && sells <= 500)
                    {
                        commicion = 0.045;
                    }
                    else if (sells > 500 && sells <= 1000)
                    {
                        commicion = 0.075;
                    }
                    else if (sells > 1000 && sells <= 10000)
                    {
                        commicion = 0.1;
                    }
                    else if (sells > 10000)
                    {
                        commicion = 0.13;
                    }
                    break;
                case "Plovdiv":
                    if (sells >= 0 && sells <= 500)
                    {
                        commicion = 0.055;
                    }
                    else if (sells > 500 && sells <= 1000)
                    {
                        commicion = 0.08;
                    }
                    else if (sells > 1000 && sells <= 10000)
                    {
                        commicion = 0.12;
                    }
                    else if (sells > 10000)
                    {
                        commicion = 0.145;
                    }
                    break;
                
            }
            double total = sells * commicion;
            if (total > 0)
            {
                Console.WriteLine($"{total:F2}");
            }
            else
            {
                Console.WriteLine("error");
            }



        }
    }
}
