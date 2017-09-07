using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _07.Hideout
{
    class Program
    {
        static void Main(string[] args)
        {

                var map = Console.ReadLine();

                var pattern = "";
                for (int i = 0; i < 3;i++)
                {
                    var tokens = Console.ReadLine().Split();
                    var element = char.Parse(tokens[0]);
                    int minCount = int.Parse(tokens[1]);
                    pattern = "\\" + element + "+";

                    var matches = Regex.Matches(map, pattern);

                    foreach (Match m in matches)
                    {

                        if (m.Length > minCount)
                        {
                            Console.WriteLine
                                ($"Hideout found at index {m.Index}" +
                                $" and it is with size {m.ToString().Length}!");
                            return;
                        }
                    }
                }
            }
        }
    }

