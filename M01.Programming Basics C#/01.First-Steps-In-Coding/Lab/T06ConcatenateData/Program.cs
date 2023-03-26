using System;

namespace T06ConcatenateData
{
    class Program
    {
        static void Main(string[] args)
        {
            //"You are <firstName> <lastName>, a <age>-years old person from <town>."

            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            double age = double.Parse (Console.ReadLine());
            string town = Console.ReadLine();

            Console.WriteLine($"You are {firstName} {lastName}, a {age}-years old person from {town}.");
            
        }
    }
}
