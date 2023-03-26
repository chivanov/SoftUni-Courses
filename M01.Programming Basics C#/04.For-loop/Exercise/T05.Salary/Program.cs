using System;

namespace _05.Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            const int FACEBOOK = 150;
            const int INSTAGRAM = 100;
            const int REDDIT = 50;

            

            for (int i = 0; i < numberOfTabs; i++)
            {
                string tab = Console.ReadLine ();

                if (tab == "Facebook")
                {
                    salary -= FACEBOOK;
                }
                else if (tab == "Instagram")
                {
                    salary -= INSTAGRAM;
                }
                else if (tab == "Reddit")
                {
                    salary -= REDDIT;
                }
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }               
            }
            if (salary > 0)
            {
                Console.WriteLine($"{salary}");
            }


        }
    }
}
