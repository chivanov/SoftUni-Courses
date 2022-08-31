using System;

namespace Tuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] input1 = Console.ReadLine().Split();

            string name = $"{input1[0]} {input1[1]}";
            string address = input1[2];
            string town = input1.Length > 4 ? $"{input1[3]} {input1[4]}" : $"{input1[3]}";

            string[] input2 = Console.ReadLine().Split();
            string firstName = input2[0];
            int beer = int.Parse(input2[1]);
            var isDrunk = input2[2] == "drunk" ? true : false;  

            string[] input3 = Console.ReadLine().Split();
            string nameOfPerson = input3[0];
            double num2 = double.Parse(input3[1]);
            string bank = input3[2];    

            Threeuple<string, string, string> firstTuple = new Threeuple<string, string, string>(name, address, town);
            Threeuple<string, int, bool> secontTuple = new Threeuple<string, int, bool>(firstName, beer, isDrunk);
            Threeuple<string, double, string> thirdTuple = new Threeuple<string, double, string>(nameOfPerson, num2, bank);

            Console.WriteLine(firstTuple);
            Console.WriteLine(secontTuple);
            Console.WriteLine(thirdTuple);


        }
    }
}
