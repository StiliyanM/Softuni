using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = { ',', ':', ';', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']' , ' ' };

            List<string> words = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> lower = new List<string>();
            List<string> mixed = new List<string>();
            List<string> upper = new List<string>();

            for (int i = 0; i < words.Count; i++)
            {
                string word = words[i];

                int lowerCnt = 0;
                int upperCnt = 0;
                for (int j = 0; j < word.Length; j++)
                {
                    if ((word[j] >= 97 && word[j] <= 122))
                        lowerCnt++;
                    else if(word[j] >= 65 && word[j] <= 90)
                        upperCnt++;
                }

                if (lowerCnt == word.Length)
                {
                    lower.Add(word);
                }
                else if (upperCnt == word.Length)
                {
                    upper.Add(word);
                }
                else
                {
                    mixed.Add(word);
                }

            }

            Console.WriteLine("Lower-case: " + string.Join(", ", lower));
            Console.WriteLine("Mixed-case: " + string.Join(", ", mixed));
            Console.WriteLine("Upper-case: " + string.Join(", ", upper));

        }
    }
}
