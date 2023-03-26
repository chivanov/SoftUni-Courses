using System;
using System.Collections.Generic;
using System.Linq;

namespace E07.TruckTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pumps = int.Parse(Console.ReadLine());
          

            Queue<string> queue = new Queue<string>();

            for (int i = 0; i < pumps; i++)
            {              
                queue.Enqueue(Console.ReadLine());   
            }

            int index = 0;

            while (true)
            {
                int totalPetrol = 0;
                foreach (var item in queue)
                {
                    int currPetrol = int.Parse(item.Split()[0]);
                    int distance = int.Parse(item.Split()[1]);  

                    totalPetrol += currPetrol - distance;

                    if (totalPetrol < 0)
                    {
                        queue.Enqueue(queue.Dequeue());
                        index++;
                        break;
                    }
                }
                if (totalPetrol >= 0)
                {
                    break;
                }
            }       
            
            Console.WriteLine($"{index}");
        }
    }
}
