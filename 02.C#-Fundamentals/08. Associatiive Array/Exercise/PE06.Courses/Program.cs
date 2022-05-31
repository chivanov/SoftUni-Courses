using System;
using System.Collections.Generic;

namespace PE06.Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> softUniCourses = new Dictionary<string, List<string>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string courseName = input[0];

                if (courseName == "end")
                {
                    break;
                }
                else
                {
                    string currStudent = input[1];

                    if (!softUniCourses.ContainsKey(courseName))
                    {
                        softUniCourses[courseName] = new List<string>();
                    }
                    softUniCourses[courseName].Add(currStudent);    
                }              

            }

            PrintCourses(softUniCourses);

            //foreach (var item in softUniCourses)
            //{
            //    string courseName = item.Key;
            //    List<string> students = item.Value;
            //    Console.WriteLine($"{courseName}: {students.Count}");

            //    foreach (var student in students)
            //    {
            //        Console.WriteLine($"-- {student}");
            //    }
            //}
        }
        static void PrintCourses(Dictionary<string, List<string>> softUniCourses)
        {
            foreach (var item in softUniCourses)
            {
                string courseName = item.Key;
                List<string> students = item.Value;
                Console.WriteLine($"{courseName}: {students.Count}");
                foreach (var student in students)
                {
                    Console.WriteLine($"-- {student}");
                }
            }

        }
    }
}
