using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var emailBook = new Dictionary<string, string>();

            int cnt = 0;
            string name = string.Empty;

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "stop")
                {
                    foreach (var item in emailBook)
                    {
                        Console.WriteLine(item.Key + " -> " + item.Value);
                    }
                    break;
                }
                else
                {
                    cnt++;
                }

                if (cnt % 2 == 1)
                {
                    name = input;
                }
                else
                {
                    string email = input;
                    char[] lastTwoLetters = email.ToCharArray().Skip(email.Length - 2).ToArray();
                    string thingToCheck = lastTwoLetters[0].ToString() + lastTwoLetters[1].ToString();
                    thingToCheck = thingToCheck.ToLower();
                    if(!(thingToCheck.EndsWith("us") || thingToCheck.EndsWith("uk")))
                    emailBook.Add(name, email);
                }
            }
        }
    }
}
