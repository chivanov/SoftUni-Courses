using System;

namespace T04InchesToCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            double inches = double.Parse (Console.ReadLine());

            const double INCH = 2.54;
            double centimetres = inches * INCH;

            Console.WriteLine(centimetres);
        }
    }
}
