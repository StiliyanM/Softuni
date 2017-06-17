using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {

            var phoneBook = new Dictionary<string, string>();

            while (true)
            {
                List<string> input = Console.ReadLine().Split().ToList();

                if(input[0] == "END")
                {
                    break;
                }
                string command = input[0];
                string name = input[1];

                if (command == "A")
                {
                    if (phoneBook.ContainsKey(name))
                        phoneBook.Clear();
                    string number = input[2];
                    phoneBook.Add(name, number);
                }
                else if (command == "S")
                {
                    if (phoneBook.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {phoneBook[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
                
            }
        }
    }
}
