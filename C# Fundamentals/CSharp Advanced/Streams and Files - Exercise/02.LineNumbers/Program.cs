using System;
using System.IO;

namespace _02.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = 1;
            using (var stream = new StreamReader("../Files/text.txt"))
            {
                using (var writer = new StreamWriter("numbered.txt"))
                {
                    while (!stream.EndOfStream)
                    {
                        var line = stream.ReadLine();
                        writer.WriteLine($"Line {counter}: {line}");
                        counter++;
                    }
                }
            }
        }
    }
}
