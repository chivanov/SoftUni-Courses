﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace T05.FilterByAge
{
    class Student
    {
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ");
                string studentName = input[0];
                int studentAge = int.Parse(input[1]);

                students.Add(new Student(studentName, studentAge));
            }

            string filterInput = Console.ReadLine();
            int filterAge = int.Parse(Console.ReadLine());
            string formatInput = Console.ReadLine();

            Func<Student, int, bool> filter = GetFilter(filterInput);
            students = students.Where(x => filter(x, filterAge)).ToList();
            Action<Student> printer = GetPrinter(formatInput);
            students.ForEach(printer);
        }

        private static Action<Student> GetPrinter(string formatInput)
        {
            switch (formatInput)
            {
                case "name":
                    return s => Console.WriteLine(s.Name);
                case "age":
                    return s => Console.WriteLine(s.Age);
                case "name age":
                    return s => Console.WriteLine($"{s.Name} - {s.Age}");
                default:
                    return null;
            }
        }

        private static Func<Student, int, bool> GetFilter(string filterInput)
        {
            switch (filterInput)
            {
                case "older":
                    return (s, age) => s.Age >= age;
                case "younger":
                    return (s, age) => s.Age < age;
                default:
                    return null;                   
            }
        }
    }
}
