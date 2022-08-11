using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                string name = input.Split()[0];
                int age = int.Parse(input.Split()[1]);

                Person person = new Person(name, age);
                family.AddMember(person);
            }

            List<Person> overThirty = family.GetOverThirty();

            foreach (var person in overThirty)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
