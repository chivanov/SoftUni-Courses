using System;

namespace T07.TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberHikingGroups = int.Parse(Console.ReadLine ());

            
            double groupMusala = 0;
            double groupMonblan = 0;
            double groupKilimangaro = 0;
            double groupK2 = 0;
            double groupEverest = 0;


            for (int i = 0; i < numberHikingGroups; i++)
            {
                int peopleInGroup = int.Parse(Console.ReadLine());

                if (peopleInGroup <= 5)
                {
                    groupMusala += peopleInGroup;
                }
                else if (peopleInGroup > 5 && peopleInGroup <= 12)
                {
                    groupMonblan += peopleInGroup;
                } 
                else if (peopleInGroup > 5 && peopleInGroup <= 25)
                {
                    groupKilimangaro += peopleInGroup;
                }
                else if (peopleInGroup > 25 && peopleInGroup <= 40)
                {
                    groupK2 += peopleInGroup;
                }
                else
                {
                    groupEverest += peopleInGroup;
                }
               
            }
            double totalPeople = groupMusala + groupMonblan + groupKilimangaro + groupK2 + groupEverest;

            double percentMusala = groupMusala / totalPeople * 100;
            double percentMonblan = groupMonblan / totalPeople * 100;
            double percentKilimangaro = groupKilimangaro / totalPeople * 100;
            double percentK2 = groupK2 / totalPeople * 100;
            double percentEverest = groupEverest / totalPeople * 100;

            Console.WriteLine($"{percentMusala:f2}%");
            Console.WriteLine($"{percentMonblan:f2}%");
            Console.WriteLine($"{percentKilimangaro:f2}%");
            Console.WriteLine($"{percentK2:f2}%");
            Console.WriteLine($"{percentEverest:F2}%");
        }
    }
}
