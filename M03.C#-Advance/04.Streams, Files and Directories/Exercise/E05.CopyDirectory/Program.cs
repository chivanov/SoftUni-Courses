using System;

namespace CopyDirectory
{
    using System;
    using System.IO;

    public class CopyDirectory
    {
        static void Main()
        {
            string inputPath = @$"{Console.ReadLine()}";
            string outputPath = @$"{Console.ReadLine()}";

            CopyAllFiles(inputPath, outputPath);
        }

        public static void CopyAllFiles(string inputPath, string outputPath)
        {
            if (Directory.Exists(outputPath))
            {
                Directory.Delete(outputPath, true);
            }
           //1.create output directory
            Directory.CreateDirectory(outputPath);
            //2. take all files from input directory
            string[] files = Directory.GetFiles(inputPath);
            //3. copy each file into output directory
            foreach (var file in files)
            {
                var fileName = Path.GetFileName(file);
                var copyDestination = Path.Combine(outputPath, fileName);   
                File.Copy(file, copyDestination);
            }
        }
    }
}
