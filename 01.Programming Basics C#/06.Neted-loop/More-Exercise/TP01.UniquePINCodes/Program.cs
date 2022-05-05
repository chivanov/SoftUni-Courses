using System;

namespace TP01.UniquePINCodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int limitNum1 = int.Parse(Console.ReadLine());
            int limitNum2 = int.Parse(Console.ReadLine());
            int limitNum3 = int.Parse(Console.ReadLine());


            for (int i = 2; i <= limitNum1; i+= 2)
            {
                for (int j = 2; j <= limitNum2; j++)
                {
                    if (j == 2 || j == 3 || j == 5 || j == 7)
                    {
                        for (int r = 2; r <= limitNum3; r += 2)
                        {
                            Console.WriteLine($"{i} {j} {r} ");
                        }
                    }
                }

            }
        }
    }
}
