using System;

namespace Tuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] input1 = Console.ReadLine().Split();

            string name = $"{input1[0]} {input1[1]}";
            string town = input1[2];

            string[] input2 = Console.ReadLine().Split();
            string firstName = input2[0];
            int beer = int.Parse(input2[1]);

            string[] input3 = Console.ReadLine().Split();
            int num = int.Parse(input3[0]); 
            double num2 = double.Parse(input3[1]);

            Tuple<string, string> firstTuple = new Tuple<string, string>(name, town);
            Tuple<string, int> secontTuple = new Tuple<string, int>(firstName, beer);
            Tuple<int, double> thirdTuple = new Tuple<int, double>(num, num2);

            Console.WriteLine(firstTuple);
            Console.WriteLine(secontTuple);
            Console.WriteLine(thirdTuple);


        }
    }
}
