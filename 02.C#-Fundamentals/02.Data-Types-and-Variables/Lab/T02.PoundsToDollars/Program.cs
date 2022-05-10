using System;
class HelloWorld
{
    static void Main()
    {
        double pounds = double.Parse(Console.ReadLine());
        decimal dolars = (decimal)(pounds * 1.31);

        Console.WriteLine($"{dolars:f3}");

    }
}
