using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            while (true)
            {
                string[] commands = Console.ReadLine().Split(' ').ToArray();

                switch (commands[0])
                {

                    case "Delete":

                        int element = int.Parse(commands[1]);
                        while (nums.Contains(element))
                        {
                            nums.Remove(element);
                        }
                        break;

                    case "Insert":

                        int pos = int.Parse(commands[2]);
                        nums.Insert(pos, int.Parse(commands[1]));
                        break;

                    case "Odd":

                        foreach (var item in nums)
                        {
                            if (item % 2 != 0)
                                Console.Write(item + " ");
                        }
                        return;

                    case "Even":

                        foreach (var item in nums)
                        {
                            if (item % 2 == 0)
                                Console.Write(item + " ");
                        }
                        return;
                    default:
                        break;
                }
            }
        }
    }
}
