using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            while (true)
            {
                var input = Console.ReadLine();

                if(input == "end")
                {
                    break;
                }

                var tokens = input.Split();

                var command = tokens[0];

                if(command == "exchange")
                {
                    var index = int.Parse(tokens[1]);

                    if(index < 0 || index > arr.Length - 1)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    arr = Exchange(arr, index);
                }
                else if(command == "max" || command == "min")
                {
                    if(!arr.Any())
                    {
                        Console.WriteLine("No matches");
                        continue;
                    }
                    var OddOrEven = tokens[1];

                    PrintMinOrMax(arr, command, OddOrEven);
                }
                else if(command == "first" || command == "last")
                {
                    var OddOrEven = tokens[2];
                    var count = int.Parse(tokens[1]);

                    if(count > arr.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }
                    PrintFirstOrLast(command,OddOrEven,count,arr);
                }
            }

            Console.WriteLine("[" + string.Join(", ",arr) + "]");
        }

        private static void PrintFirstOrLast(string command, string oddOrEven, int count,int[] arr)
        {
            if(oddOrEven == "even")
            {
                arr = arr.Where(x => x % 2 == 0).ToArray();
            }
            else if(oddOrEven == "odd")
            {
                arr = arr.Where(x => x % 2 == 1).ToArray();
            }

            if(arr.Length == 0)
            {
                Console.WriteLine("[]");
                return;
            }

            if(command == "first")
            {
                arr = arr.Take(count).ToArray();
            }
            else if(command == "last")
            {
                arr = arr.Reverse().Take(count).ToArray();
            }

            Console.WriteLine("[" + string.Join(", ", arr) + "]");
        }

        private static void PrintMinOrMax(int[] arr, string command, string oddOrEven)
        {

            int index = -1;
            var isEven = true;
            if (oddOrEven == "odd")
                isEven = false;
            int max = 0;
            int min = 0;

            try
            {
                if (isEven)
                {
                    max = arr.Where(x => x % 2 == 0).Max();
                    min = arr.Where(x => x % 2 == 0).Min();
                }
                else
                {
                    max = arr.Where(x => x % 2 == 1).Max();
                    min = arr.Where(x => x % 2 == 1).Min();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("No matches");
                return;
            }

            if (command == "max")
            {
                if(isEven)
                for (int i = 0; i < arr.Length; i++)
                {
                    if((arr[i] % 2 == 0))
                    {
                       if(arr[i] == max)
                        {
                            index = i;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if ((arr[i] % 2 == 1))
                        {
                            if (arr[i] == max)
                            {
                                index = i;
                            }
                        }
                    }
                }
            }
            else if(command == "min")
            {
                if (isEven)
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if ((arr[i] % 2 == 0) == isEven)
                        {
                            if (arr[i] == min)
                            {
                                index = i;
                            }
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if ((arr[i] % 2 == 1))
                        {
                            if (arr[i] == min)
                            {
                                index = i;
                            }
                        }
                    }
                }
            }
            
            if(index == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            Console.WriteLine(index);
        }

        private static int[] Exchange(int[] arr, int index)
        {
            return arr.Skip(index + 1).Concat(arr.Take(index + 1)).ToArray();
        }
    }
}
