﻿using System;

namespace T08.OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Първият ред съдържа час на изпита – цяло число от 0 до 23.
            //•	Вторият ред съдържа минута на изпита – цяло число от 0 до 59.
            //•	Третият ред съдържа час на пристигане – цяло число от 0 до 23.
            //•	Четвъртият ред съдържа минута на пристигане – цяло число от 0 до 59.
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());

            int difference = 0;
            int hour = 0;
            int minutes = 0;

            examMinutes += examHour * 60;
            arrivalMinutes += arrivalHour * 60;

            if (arrivalMinutes > examMinutes)
            {
                Console.WriteLine("Late");
                difference = arrivalMinutes - examMinutes;
                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes after the start");
                }
                else
                {
                    hour = difference / 60;
                    minutes = difference % 60;
                    Console.WriteLine($" {hour}:{minutes:d2} hours after the start");
                }
            }
            else if (arrivalMinutes < examMinutes - 30)
            {
                Console.WriteLine("Early");
                difference = examMinutes - arrivalMinutes;
                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
                else
                {
                    hour = difference / 60;
                    minutes = difference % 60;
                    Console.WriteLine($" {hour}:{minutes:d2} hours before the start");
                }
            }
            else
            {

                difference = examMinutes - arrivalMinutes;
                if (difference == 0)
                {
                    Console.WriteLine("On time");
                }
                else
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{difference} minutes before the start");
                }

            }
        }
    }
}