using System;
using System.Collections.Generic;
using System.IO;

namespace _05.SlicingFile
{
    class Program
    {
        static List<string> partsPaths = new List<string>();

        static void Main(string[] args)
        {
            var sourcePath = Console.ReadLine();
            var destinationDirectory = Console.ReadLine();
            var parts = int.Parse(Console.ReadLine());

            Directory.CreateDirectory(destinationDirectory);

            Slice(sourcePath, destinationDirectory, parts);

            Assemble(partsPaths, destinationDirectory);
        }

        private static void Assemble(List<string> partsPaths, string destinationDirectory)
        {
            using (var destination = new FileStream("./" + destinationDirectory + "/" + "assembeled.mp4", FileMode.Create))
            {
                foreach (var path in partsPaths)
                {
                    using (var source = new FileStream(path, FileMode.Open))
                    {

                        var buffer = new byte[source.Length];

                        int readbytes = source.Read(buffer, 0, buffer.Length);

                        destination.Write(buffer, 0, readbytes);
                    }
                }
            }
        }

        private static void Slice(string sourcePath, string destinationDirectory, int parts)
        {
            long partlength = 0;
            using (var source = new FileStream(sourcePath, FileMode.Open))
            {

                for (int i = 0; i < parts; i++)
                {
                    partlength = source.Length / parts;

                    var partPath = $"Part - {i}.mp4";
                    var destinationPath = "./" + destinationDirectory + "./" + partPath;

                    partsPaths.Add(destinationPath);

                    using (var destination = new FileStream(destinationPath, FileMode.Create))
                    {
                        var buffer = new byte[partlength];

                        int readbytes = source.Read(buffer, 0, buffer.Length);

                        destination.Write(buffer, 0, readbytes);
                    }
                }
            }
        }
    }
}
