using System;
using System.IO;

namespace LineNumbers
{
    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"../../../input.txt";
            string outputPath = @"../../../output.txt";

            RewriteFileWithLineNumbers(inputPath, outputPath);
        }

        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {
            StreamReader reader = new StreamReader(inputFilePath);
            using (reader)
            {
                string line = reader.ReadLine();    
                StreamWriter writer = new StreamWriter(outputFilePath);
                using (writer)
                {
                    int index = 1;
                    while (line != null)
                    {
                       writer.WriteLine($"{index}. {line}");
                        index++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
