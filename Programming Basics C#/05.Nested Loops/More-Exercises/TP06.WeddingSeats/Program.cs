using System;

namespace TP06.WeddingSeats
{
    class Program
    {
        static void Main(string[] args)
        {
            char sector = char.Parse(Console.ReadLine());
            int rowA = int.Parse(Console.ReadLine());
            int numberOddSeats = int.Parse(Console.ReadLine());
            int evenSeats = 0;
            int factor = 0;
            int oddSeats = 0;
            int seatCounter = 0;


            for (char sectNum = 'A'; sectNum <= sector; sectNum++, rowA++)
            {
                for (int row = 1; row <= rowA; row++)
                {
                    factor = (row % 2 == 0) ? 2 : 0;

                    for (char seat = 'a'; seat < 'a' + numberOddSeats + factor; seat++)
                    {
                        Console.WriteLine($"{sectNum}{row}{seat}");
                        seatCounter++;
                    }

                }

            }
            Console.WriteLine($"{seatCounter}");
        }
    }
}
