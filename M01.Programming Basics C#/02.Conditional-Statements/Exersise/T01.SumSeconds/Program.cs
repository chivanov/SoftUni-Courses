using System;

namespace T01.SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstPlayer = int.Parse(Console.ReadLine());
            int secondPlayer = int.Parse(Console.ReadLine());
            int thirdPlayer = int.Parse(Console.ReadLine());

            int totalTime = firstPlayer + secondPlayer + thirdPlayer;
            int minutes = totalTime / 60;
            int seconds = totalTime % 60;

            if (seconds < 10)
            {
                Console.WriteLine($"{minutes}:{seconds:D2}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{seconds}");

            }
                
        }
    }
}
