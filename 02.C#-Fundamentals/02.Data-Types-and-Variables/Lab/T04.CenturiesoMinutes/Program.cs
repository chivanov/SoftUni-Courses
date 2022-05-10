using System;
class HelloWorld
{
    static void Main()
    {
        byte centuries = byte.Parse(Console.ReadLine());
        float years = (float)(centuries * 100);
        int days = (int)(years * 365.2422);
        int hours = (days * 24);
        long minutes = (long)(hours * 60);

        Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
    }
}
