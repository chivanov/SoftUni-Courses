using System;

namespace Fishland
{
    class Program
    {
        static void Main(string[] args)
        {        

            double priceOfSkumriq = double.Parse(Console.ReadLine());
            double priceOfCaca = double.Parse(Console.ReadLine());
            double kiloPalamut = double.Parse(Console.ReadLine());
            double kiloSafrid = double.Parse(Console.ReadLine());
            double kiloMidi = double.Parse(Console.ReadLine());
            
            const double priceOfMidi = 7.50;
            double priceOfPalamud = priceOfSkumriq + (priceOfSkumriq * 0.6);
            double priceOfSafrid = priceOfCaca + (priceOfCaca * 0.8);

          
            double palamud = kiloPalamut * priceOfPalamud;
            double safrid = kiloSafrid * priceOfSafrid;
            double midi = kiloMidi * priceOfMidi;

            double totalSum = palamud + safrid + midi;

            Console.WriteLine($"{totalSum:F2}");

        }
    }
}
