using System;
using System.Linq;

namespace T09.KaminoFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sequencesLength = int.Parse(Console.ReadLine());

            int[] arr = new int[sequencesLength];
            string input = Console.ReadLine();
            int seqCounter = 0;
            int winCounter = 0;
            int index = 0;

            while (input != "Clone them!")
            {
                arr = input
                    .Split('!', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == arr[i+1])
                    {
                        seqCounter++;

                        if (seqCounter>winCounter)
                        {
                            winCounter = seqCounter;
                            index = arr[i];

                        }
                        else
                        {
                            seqCounter = 0; 
                        }
                    }
                }

                input = Console.ReadLine();
            }

           







        }
    }
}
