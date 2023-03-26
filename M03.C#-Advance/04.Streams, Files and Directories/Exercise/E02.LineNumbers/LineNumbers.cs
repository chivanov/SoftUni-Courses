using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LineNumbers
{
    using System;
    public class LineNumbers
{
    static void Main()
    {
        string inputFilePath = @"../../../text.txt";
        string outputFilePath = @"../../../output.txt";

        ProcessLines(inputFilePath, outputFilePath);
    }

    public static void ProcessLines(string inputFilePath, string outputFilePath)
    {
        string[] lines = File.ReadAllLines(inputFilePath);
        int index = 0;
        List<string> outputLines = new List<string>();
        foreach (var item in lines)
        {
            index++;

            int countLetters = item.Count(char.IsLetter);
            int countSymbols = item.Count(char.IsPunctuation);

            string modifinedLine = $"Line {index}: {item} ({countLetters})({countSymbols})";
            outputLines.Add(modifinedLine);
        }

        File.WriteAllLines(outputFilePath, outputLines);
    }
}
}




