using System;
using System.Linq;

class HelloWorld
{
    static void Main()
    {

        int numbers = int.Parse(Console.ReadLine());

        int[] numArray = new int[numbers];

        for (int i = 0; i < numArray.Length; i++)
        {
            int num = int.Parse(Console.ReadLine());
            numArray[i] = num;
        }

        //for (int i = numArray.Length - 1; i >= 0; i--)
        //{
        //    Console.Write($"{numArray[i]} ");
        //}



        Console.Write(String.Join(' ', numArray.Reverse()));

    }
}
