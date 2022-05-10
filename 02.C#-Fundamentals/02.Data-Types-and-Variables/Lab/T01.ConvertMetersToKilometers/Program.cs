using System;
class HelloWorld
{
    static void Main()
    {
        int metres = int.Parse(Console.ReadLine());
        decimal kilometres = (decimal)(metres / 1000.0);
        Console.WriteLine($"{kilometres:f2}");
    }
}
