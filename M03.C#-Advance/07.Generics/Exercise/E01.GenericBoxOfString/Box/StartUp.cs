using System;

namespace Box
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();

                Box<string> result = new Box<string>(input);
                Console.WriteLine(result);  
            }
        }
    }
}
