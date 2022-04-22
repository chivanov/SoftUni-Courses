using System;

namespace TP08.EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;
            for (int i = 0; i < 2 * numbers; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if (i <= 2)
                {

                    sum1 += currentNum; 
                }
                else if (i > 2 && i <= 4)
                {
                    sum2 += currentNum;
                }else if (i > 4 && i <= 6)
                {
                    sum3 += currentNum;
                }
                  
            }
        }
    }
}
