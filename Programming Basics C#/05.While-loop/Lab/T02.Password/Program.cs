using System;

namespace T02.Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string password = Console.ReadLine();

            string passwordInput= Console.ReadLine ();

            while (passwordInput != password)
            {
                passwordInput = Console.ReadLine();
            }

            Console.WriteLine($"Welcome {name}!");
        }
    }
}
