using System;

namespace TP04.CarNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            int sum2And3 = 0;

            for (int i = startNum; i <= endNum; i++)
            {
                for (int j = startNum; j <= endNum; j++)
                {
                    for (int k = startNum; k <= endNum; k++)
                    {
                        for (int l = startNum; l <= endNum; l++)
                        {
                            sum2And3 = j + k;
                            if ( i > l && ((i % 2 == 0 && l % 2 != 0) || (i % 2 != 0 && l % 2 == 0)) && (sum2And3 % 2 == 0))
                            {
                                Console.Write($"{i}{j}{k}{l} ");
                            }
                        }
                    }
                }
            }



        }
    }
}
