using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Files
{
    class Program
    {
        class File
        {
            public string Name { get; set; }
            public string Extention { get; set; }
            public string Size { get; set; }
        }
        static void Main(string[] args)
        {
            var rootsFiles = new Dictionary<string, List<File>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var fileInput = Console.ReadLine().Split('\\');

                var root = fileInput.First();
                string filenameExtSize = fileInput.Last();
                string size = filenameExtSize.Split(';').Last();
                var fileName = filenameExtSize.Split(';').First();
                var extention = fileName.Split('.').Last();

                if(!rootsFiles.ContainsKey(root))
                {
                    rootsFiles[root] = new List<File>();

                }

                var match = rootsFiles[root].FirstOrDefault(x => x.Name == fileName);

                if(match != null)
                {
                    match.Size = size;
                }
                else
                {
                    File file = new File();

                    file.Name = fileName;
                    file.Extention = extention;
                    file.Size = size;

                    rootsFiles[root].Add(file);
                }
            }

            var command = Console.ReadLine().Split();

            var extNeeded = command[0];
            var rootToSearchIn = command[2];

            if(rootsFiles.ContainsKey(rootToSearchIn))
            {
                if(rootsFiles[rootToSearchIn].Count(x => x.Extention == extNeeded) > 0)
                {
                    foreach (var item in rootsFiles[rootToSearchIn].
                        OrderByDescending(x => x.Size).
                        OrderBy(x => x.Name))
                    {
                        if(item.Extention == extNeeded)
                        Console.WriteLine($"{item.Name} - {item.Size} KB");
                    }
                }
                if(rootsFiles[rootToSearchIn].Count(x => x.Extention == extNeeded) == 0)
                {
                    Console.WriteLine("No");
                }
            }
        }
    }
}
