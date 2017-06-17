using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            while (true)
            {
                List<string> commands = Console.ReadLine().Split(' ').ToList();

                string command = commands[0];
                switch (command)
                {
                    case "add":
                        numbers.Insert(int.Parse(commands[1]), int.Parse(commands[2]));
                        break;

                    case "addMany":

                        int[] numsToAdd = new int[commands.Count - 2];

                        for (int i = 0; i < numsToAdd.Length; i++)
                        {
                            numsToAdd[i] = int.Parse(commands[i + 2]);
                        }
                        numbers.InsertRange(int.Parse(commands[1]),numsToAdd);
                        break;

                    case "contains":

                        if(numbers.Contains(int.Parse(commands[1])))
                        {
                            //numbers.Find(int.Parse(a => a = commands[1]))
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if(numbers[i] == int.Parse(commands[1]))
                                {
                                    Console.WriteLine(i);
                                    break;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine(-1);
                            break;
                        }
                        break;

                    case "remove":
                        numbers.RemoveAt(int.Parse(commands[1]));
                            break;

                    case "shift":
                        int positions = int.Parse(commands[1]);

                      numbers = numbers.Skip(positions).Concat(numbers.Take(positions)).ToList();
                        break;

                    case "sumPairs":
                        for (int i = 0; i < numbers.Count - 1; i++)
                        {
                            int sum = numbers[i] + numbers[i + 1];
                            numbers.RemoveRange(i, 2);
                            numbers.Insert(i, sum);
                        }
                        break;

                    case "print":
                        Console.WriteLine("[" + string.Join(", ", numbers) + "]");
                        return;
                    default:
                        break;
                }
            }
        }
    }
}
