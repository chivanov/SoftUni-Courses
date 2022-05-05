using System;

namespace T01.ReadText
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            while (name != "Stop")
            {
                Console.WriteLine(name);
                name = Console.ReadLine();
            }
        }
    }
}
