using System;
using System.IO;

namespace OddLines
{
    public class OddLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\Files\input.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);
        }

        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            StreamReader reader = new StreamReader(inputFilePath);

            using (reader)
            {
                StreamWriter writer = new StreamWriter(outputFilePath);
                using (writer)
                {
                    string line = reader.ReadLine();
                    int index = 0;
                    while (line != null)
                    {
                        if (index % 2 != 0)
                        {
                            writer.WriteLine(line);
                        }
                        index++;
                        line = reader.ReadLine();
                    }

                }
            }
        }
    }
}

