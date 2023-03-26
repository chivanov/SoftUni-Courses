using System;

namespace T06.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int cakeLenght = int.Parse(Console.ReadLine());
            int cakeWidth = int.Parse(Console.ReadLine());

            int cakePeases = cakeLenght * cakeWidth;

            while (cakePeases > 0)
            {
                string input = Console.ReadLine();
                if (input == "STOP")
                {
                    break;
                }
                int peases = int.Parse(input);
                cakePeases -= peases;
            }
            if (cakePeases >= 0)
            {
                Console.WriteLine($"{cakePeases} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(cakePeases)} pieces more.");
            }


        }
    }
}
