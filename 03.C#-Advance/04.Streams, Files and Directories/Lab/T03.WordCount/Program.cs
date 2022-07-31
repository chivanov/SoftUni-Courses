using System;
using System.IO;
using System.Linq;

namespace WordCount
{
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"../../../words.txt";
            string textPath = @"../../../text.txt";
            string outputPath = @"../../../output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            StreamReader reader = new StreamReader(wordsFilePath);
            StreamReader text = new StreamReader(textFilePath); 
            using (reader)
            {
                StreamWriter writer =  new StreamWriter(outputFilePath);
                string line = reader.ReadLine();    
                using (writer)
                {
                    while (line != null)
                    {
                        if (text.)
                        {

                        }
                        
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
