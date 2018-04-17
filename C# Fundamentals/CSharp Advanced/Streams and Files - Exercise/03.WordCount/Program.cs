using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;
namespace _03.WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = new Dictionary<string,int>();

            var allWords = new List<string>();
            using (var stream = new StreamReader("../Files/words.txt"))
            {
                while (!stream.EndOfStream)
                {
                    var word = stream.ReadLine();
                    if (!words.ContainsKey(word))
                    {
                        words[word] = 0;
                    }
                    allWords.Add(word);
                }
            }

            var text = "";

            using (var stream = new StreamReader("../Files/text.txt"))
            {
                text = stream.ReadToEnd();
            }

            foreach (var w in allWords)
            {
                var matches = Regex.Matches(text, $"(?i)\\b{w}\\b");
                words[w] = matches.Count;
            }

            using (var writer = new StreamWriter("result.txt"))
            {
                foreach (var w in words.OrderByDescending(w => w.Value))
                {
                    writer.WriteLine($"{w.Key} - {w.Value}");
                }
            }

        }
    }
}
