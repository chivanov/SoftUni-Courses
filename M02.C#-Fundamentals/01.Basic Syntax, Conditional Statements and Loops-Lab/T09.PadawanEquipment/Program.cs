using System;

namespace T09.PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double money = double.Parse(Console.ReadLine());
            byte students = byte.Parse(Console.ReadLine());
            double lightsabersPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            double costLightsabers = lightsabersPrice * (Math.Ceiling(students * 1.1));
            double costRobes = robesPrice * students;
            int belts = students;
            if (students >= 6)
            {
                belts = students - (students / 6);
            }
            double costBelts = beltsPrice * belts;


            double total = costLightsabers + costRobes + costBelts;

            if (money >= total)
            {
                Console.WriteLine($"The money is enough - it would cost {total:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {(total - money):f2}lv more.");
            }

        }
    }
}
