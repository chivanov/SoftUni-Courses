using System;

namespace Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Първи ред – цена на скумрията на килограм.Реално число в интервала[0.00…40.00]
            //•	Втори ред – цена на цацата на килограм.Реално число в интервала[0.00…30.00]
            //•	Трети ред – килограма паламуд. Реално число в интервала[0.00…50.00]
            //•	Четвърти ред – килограма сафрид. Реално число в интервала[0.00… 70.00]
            //•	Пети ред – килограма миди. Цяло число в интервала[0... 100]

            double priceOfSkumriq = double.Parse(Console.ReadLine());
            double priceOfCaca = double.Parse(Console.ReadLine());
            double kiloPalamut = double.Parse(Console.ReadLine());
            double kiloSafrid = double.Parse(Console.ReadLine());
            double kiloMidi = double.Parse(Console.ReadLine());
            
            const double priceOfMidi = 7.50;
            double priceOfPalamud = priceOfSkumriq + (priceOfSkumriq * 0.6);
            double priceOfSafrid = priceOfCaca + (priceOfCaca * 0.8);

            //паламуд, сафрид и миди.

            double palamud = kiloPalamut * priceOfPalamud;
            double safrid = kiloSafrid * priceOfSafrid;
            double midi = kiloMidi * priceOfMidi;

            double totalSum = palamud + safrid + midi;

            Console.WriteLine($"{totalSum:F2}");

        }
    }
}
