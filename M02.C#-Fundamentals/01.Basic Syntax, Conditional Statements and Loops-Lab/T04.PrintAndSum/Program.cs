using System;
class HelloWorld
{
    static void Main()
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int sum = 0;

        for (int i = num1; i <= num2; i++)
        {
            Console.Write($"{i} ");
            sum += i;
        }
        
        Console.WriteLine($"{sum}");
    }
}