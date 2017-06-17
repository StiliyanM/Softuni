using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Phonebook_Upgrade
{
    class Program
    {
        static void Main(string[] args)
        {

            var phoneBook = new SortedDictionary<string, string>();

            while (true)
            {
                List<string> input = Console.ReadLine().Split().ToList();

                if (input[0] == "END")
                {
                    break;
                }
                string command = input[0];


                if (command == "A")
                {

                    string name = input[1];

                    if (phoneBook.ContainsKey(name))
                        phoneBook.Remove(name);
                    string number = input[2];
                    phoneBook.Add(name, number);
                }
                else if (command == "S")
                {
                    string name = input[1];

                    if (phoneBook.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {phoneBook[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
                else if (command == "ListAll")
                {
                    foreach (var item in phoneBook)
                    {
                        Console.WriteLine(item.Key + " -> " + item.Value);
                    }
                }

            }
        }
    }
}
