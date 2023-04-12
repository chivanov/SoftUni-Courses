using System;

namespace Box
{
    public class StartUp
    {
        static void Main(string[] args)
        {            

            try
            {
                double length = double.Parse(Console.ReadLine());
                double width = double.Parse(Console.ReadLine());
                double hight = double.Parse(Console.ReadLine());
                Box box = new Box(length, width, hight);

                Console.WriteLine(box);
            }
            catch (ArgumentException ae)
            {

                Console.WriteLine(ae.Message);
            }            

        }
    }
}
