using System;
using System.Collections.Generic;
using System.Linq;

namespace TE05.BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            List<int> bomb = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();


            for (int i = 0; i < numbers.Count; i++)
            {
               //int currNum = numbers[i];    
                
                if (numbers[i] == bomb[0])
                {
                    for (int j = 1; j <= bomb[1]; j++)
                    {
                        if (i-j < 0)
                        {
                            break;
                        }

                        else
                        {
                            numbers[i - j] = 0; 
                        }
                    }

                    for (int k = 1; k <= bomb[1]; k++)
                    {
                        if (i+k > numbers.Count-1)
                        {
                            break;
                        }
                        else
                        {
                            numbers[i + k] = 0; 
                        }
                    }

                    numbers[i] = 0;
                }
                
            }
            int sum = numbers.Sum();

            Console.WriteLine(sum);
        }
       

    }
}
