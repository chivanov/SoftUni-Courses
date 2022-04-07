using System;

namespace T07.AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();

            if (figureType == "square")
            {
                double side = double.Parse(Console.ReadLine());
                double squareArea = side * side;
                Console.WriteLine($"{squareArea:F3}");
            }
            else if (figureType == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                double rectangleArea = sideA * sideB;
                Console.WriteLine($"{rectangleArea:F3}");
            }
            else if (figureType == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                //S = πr²
                double circleArea = (radius * radius) * Math.PI;
                Console.WriteLine($"{circleArea:F3}");
            }
            else if (figureType == "triangle")
            {
                double sideA = double.Parse(Console.ReadLine()); 
                double sideB = double.Parse(Console.ReadLine());
                double triangleArea = sideA * sideB / 2;
                Console.WriteLine($"{triangleArea:F3}");
            }
        }
    }
}
