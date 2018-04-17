using System;
using System.IO;

namespace _01.OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = 0;
            using (var stream = new StreamReader("../Files/text.txt"))
            {
                while (!stream.EndOfStream)
                {
                    var line = stream.ReadLine();
                    if(counter % 2 == 1)
                    {
                        Console.WriteLine(line);
                    }
                    counter++;
                }
            }
        }
    }
}
