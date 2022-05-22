using System;
using System.Collections.Generic;
using System.Linq;

namespace TE01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> peopleInVagons = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            int vagonCapacity = int.Parse(Console.ReadLine());
             
           //List<string> entranceData = Console.ReadLine().Split(' ').ToList();

           //string command = entranceData[0];
           string command = Console.ReadLine(); 

            while (command != "end")    
            {          
                List<string> input = command.Split(' ').ToList();
               
                if (input.Count == 2 )
                {                   
                    int lastVagon = int.Parse(input[1]);
                    peopleInVagons.Add(lastVagon);
                }

                else
                {
                    int people = int.Parse (input[0]);

                    for (int i = 0; i < peopleInVagons.Count; i++)
                    {
                       int allPeople = peopleInVagons[i] + people;  
                        
                        if (allPeople <= vagonCapacity)
                        {
                            peopleInVagons [i] = allPeople;
                            break;
                        }
                        //else
                        //{

                        //}
                    }
                }
                command = Console.ReadLine();
                //entranceData = Console.ReadLine().Split(' ').ToList();
            }
            Console.WriteLine(string.Join(' ', peopleInVagons));
        }
    }
}
