using System;
using System.Collections.Generic;
using System.Linq;

namespace PE07.OrderByAge
{
    public class Person
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} with ID: {ID} is {Age} years old.";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                string[] personInfo = input.Split();
                Person currPerson = new Person();   
                currPerson.Name = personInfo[0];
                currPerson.ID = personInfo[1];
                currPerson.Age = int.Parse(personInfo[2]); 

                people.Add(currPerson);               

            }

            foreach (Person person in people.OrderBy(person => person.Age))
            {
                Console.WriteLine(person);
            }
        }       
    }
}
