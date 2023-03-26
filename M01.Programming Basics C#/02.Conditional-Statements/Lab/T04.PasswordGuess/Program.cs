using System;

namespace T04.PasswordGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            string passward = Console.ReadLine();

            if (passward == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
