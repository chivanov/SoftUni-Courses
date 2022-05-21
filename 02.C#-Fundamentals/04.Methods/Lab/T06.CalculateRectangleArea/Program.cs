using System;

namespace T06.CalculateRectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double wigth = double.Parse(Console.ReadLine());
            double hight = double.Parse(Console.ReadLine());
            double rectangleArea = CalculateRectangleArea (wigth, hight);
            Console.WriteLine(rectangleArea);

        }

        static double CalculateRectangleArea(double width, double hight)
        {
            return width * hight;
        }
    }
}
