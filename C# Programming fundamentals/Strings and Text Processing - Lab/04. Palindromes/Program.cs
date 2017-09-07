using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().Split(" ,.?!".ToArray(), StringSplitOptions.RemoveEmptyEntries);

            var palindromes = new List<string>();

            foreach (var word in text)
            {
                if(isPalindrome(word))
                {
                    palindromes.Add(word);
                }
            }

            palindromes = palindromes.Distinct().OrderBy(a => a).ToList();

            Console.WriteLine(string.Join(", ", palindromes));
        }

        private static bool isPalindrome(string word)
        {
            bool isPalindrome = false;
            if(word.Length == 1)
            {
                isPalindrome = true;
            }
            else if(word.Length % 2 == 0)
            {
                
                var firstPart = word.Substring(0, word.Length / 2);
                var secondPart = word.Substring(word.Length / 2);

                if(firstPart == new string(secondPart.Reverse().ToArray()))
                {
                    isPalindrome = true;
                }
            }
            else if(word.Length % 2 == 1)
            {
                var firstPart = word.Substring(0, word.Length / 2);
                var secondPart = word.Substring(word.Length / 2 + 1);

                if (firstPart == new string(secondPart.Reverse().ToArray()))
                {
                    isPalindrome = true;
                }
            }

            return isPalindrome;
        }
    }
}
