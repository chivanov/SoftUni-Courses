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
                int input = int.Parse(Console.ReadLine());

                Box<int> result = new Box<int>(input);
                Console.WriteLine(result);  
            }
        }
    }
}
