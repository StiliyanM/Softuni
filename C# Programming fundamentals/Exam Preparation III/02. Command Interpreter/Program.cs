using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Command_Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            var strings = Regex.Split(Console.ReadLine(), @"\s+").ToArray();

            while (true)
            {
                var commands = Console.ReadLine().Split();

                if (commands[0] == "end")
                {
                    break;
                }

                var command = commands[0];

                int start = 0;
                int count = 0;
                switch (command)
                {
                    case "reverse":
                        start = int.Parse(commands[2]);
                        count = int.Parse(commands[4]);

                        if (!ParametersAreValid(start, count, strings.Length))
                        {
                            Console.WriteLine("Invalid input parameters.");
                            continue;
                        }

                        var reverseList = strings.Skip(start).Take(count).ToList();
                        reverseList.Reverse();

                        for (int i = 0; i < reverseList.Count(); i++)
                        {
                            strings[start] = reverseList[i];
                            start++;
                        }
                        reverseList.Clear();

                        break;
                    case "sort":
                        start = int.Parse(commands[2]);
                        count = int.Parse(commands[4]);

                        if (!ParametersAreValid(start, count, strings.Length))
                        {
                            Console.WriteLine("Invalid input parameters.");
                            continue;
                        }

                        var sortList = strings.Skip(start).Take(count).ToList();
                        sortList.Sort();

                        for (int i = 0; i < sortList.Count(); i++)
                        {
                            strings[start] = sortList[i];
                            start++;
                        }
                        sortList.Clear();
                        break;
                    case "rollLeft":
                        count = int.Parse(commands[1]);

                        if (count < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            continue;
                        }

                        strings = strings.Skip(count % strings.Length).Concat(strings.Take(count % strings.Length)).ToArray();
                        break;
                    case "rollRight":
                        count = int.Parse(commands[1]);

                        if (count < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            continue;
                        }

                        strings = strings.Skip(strings.Length - (count % strings.Length)).Concat(strings.Take(strings.Length - (count % strings.Length))).ToArray();
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine("[" + string.Join(", ", strings) + "]");
        }

        private static bool ParametersAreValid(int start, int count, int length)
        {
            bool areValid = true;

            if (start < 0 || start >= length)
                areValid = false;
            if (start + count > length || count < 0)
                areValid = false;

            return areValid;
        }
    }
}
