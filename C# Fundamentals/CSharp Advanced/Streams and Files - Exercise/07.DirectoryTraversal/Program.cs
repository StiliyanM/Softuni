using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace _07.DirectoryTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = Console.ReadLine();

            var fileDictionary = new Dictionary<string, List<FileInfo>>();

            var files = Directory.GetFiles(path);

            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);

                var extension = fileInfo.Extension;

                if (!fileDictionary.ContainsKey(extension))
                {
                    fileDictionary[extension] = new List<FileInfo>();
                }

                fileDictionary[extension].Add(fileInfo);
            }

            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fullFileName = desktop + "\\" +  "report.txt";

            using (var writer = new StreamWriter(fullFileName))
            {
                foreach (var pair in fileDictionary
                                    .OrderByDescending(e => e.Value.Count)
                                    .ThenBy(e => e.Key))
                {
                    var extension = pair.Key;
                    writer.WriteLine(extension);

                    var fileInfos = pair.Value;
                    foreach (var fileInfo in fileInfos.OrderByDescending(fi => fi.Length))
                    {
                        double fileSize = fileInfo.Length / 1024.0; 

                        writer.WriteLine($"--{fileInfo.Name} - {fileSize}kb");
                    }
                }
            }


        }
    }
}
