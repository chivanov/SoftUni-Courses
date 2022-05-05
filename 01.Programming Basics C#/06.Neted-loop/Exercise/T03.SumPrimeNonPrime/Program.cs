using System;

namespace T03.SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int sumPirmeNumbers = 0;
            int sumNonPrimeNumbers = 0;

            while (input != "stop")
            {
                int num = int.Parse(input);
                if (num < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    int count = 0;
                    for (int i = ; i <= num; i++)
                    {
                        if (num % i == 0  )
                        {
                            count++;
                        }
                    }
                    if (count == 2)
                    {
                        sumPirmeNumbers += num;
                    }
                    else
                    {
                        sumNonPrimeNumbers += num;

                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumPirmeNumbers}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrimeNumbers}");

        }
    }
}
