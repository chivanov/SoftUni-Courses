using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person(18);

            Person person3 = new Person("Jose", 15);
            Console.WriteLine($"{person1.Name} {person1.Age}");
            Console.WriteLine($"{person2.Name} {person2.Age}");
            Console.WriteLine($"{person3.Name} {person3.Age}");
        }
    }
}
