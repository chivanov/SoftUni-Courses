using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.Name = "Petar";
            person1.Age = 20;


            Person person2 = new Person("Georgi", 18);
            Person person3 = new Person("Jose", 15);
            Console.WriteLine($"{person1.Name} {person1.Age}");
            Console.WriteLine($"{person2.Name} {person2.Age}");
            Console.WriteLine($"{person3.Name} {person3.Age}");
        }
    }
}
