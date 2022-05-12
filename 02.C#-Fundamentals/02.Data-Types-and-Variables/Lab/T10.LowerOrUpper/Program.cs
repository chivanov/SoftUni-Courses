using System;
class HelloWorld
{
    static void Main()
    {
        char character = char.Parse(Console.ReadLine());
        if (character >= 'a' && character <= 'z')

        {
            Console.WriteLine("lower-case");
        }
        else if (character >= 'A' && character <= 'Z')
        {
            Console.WriteLine("upper-case");
        }

    }
}
