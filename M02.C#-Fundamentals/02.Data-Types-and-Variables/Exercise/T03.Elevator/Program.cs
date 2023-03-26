using System;

namespace T03.Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            double rounds = Math.Ceiling ((double)numberOfPeople / capacity);

            Console.WriteLine($"{rounds}");
        }
    }
}
