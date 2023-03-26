using System;
using System.Collections.Generic;
using System.Linq;

namespace T02.AverageStudentGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();
            for (int i = 0; i < n; i++)
            {
                string inputData = Console.ReadLine();
                string studentName = inputData.Split()[0];
                decimal grade = decimal.Parse(inputData.Split()[1]);

                if (!students.ContainsKey(studentName))
                {
                    students.Add(studentName, new List<decimal>());
                    students[studentName].Add(grade);
                }
                else
                {
                    students[studentName].Add(grade);
                }
            }

            foreach (var (item, grades) in students)
            {
                var average = grades.Average();
                Console.Write($"{item} -> ");
                foreach (var grade in grades)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.WriteLine($"(avg: {average:f2})");

            }
        }
    }
}
