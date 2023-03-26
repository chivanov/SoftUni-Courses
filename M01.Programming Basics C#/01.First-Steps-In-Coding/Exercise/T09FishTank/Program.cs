using System;

namespace T09FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< .mine

=======
         
>>>>>>> .theirs
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double numPercent = double.Parse(Console.ReadLine());

            int area = lenght * width * height;
            double litters = area * 0.001;
            double percent = numPercent / 100.0;
            double usedArea = litters * (1 - percent);

            Console.WriteLine(usedArea);

        }
    }
}
