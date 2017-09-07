using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Play_Catch
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int catchCounter = 0;

            while (catchCounter < 3)
            {
                var tokens = Console.ReadLine().Split().ToArray();
                try
                {

                    if (tokens[0] == "Replace")
                    {
                        var index = int.Parse(tokens[1]);
                        var element = int.Parse(tokens[2]);

                        input[index] = element;
                    }
                    else if (tokens[0] == "Print")
                    {
                        var startIndex = int.Parse(tokens[1]);
                        var endIndex = int.Parse(tokens[2]);

                        var PrintInput = new List<int>();

                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            PrintInput.Add(input[i]);
                        }
                        Console.WriteLine(string.Join(", ", PrintInput));
                    }
                    else if (tokens[0] == "Show")
                    {
                        var index = int.Parse(tokens[1]);

                        Console.WriteLine(input[index]);
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("The index does not exist!");
                    catchCounter++;
                }
                catch(FormatException)
                {
                    Console.WriteLine("The variable is not in the correct format!");
                    catchCounter++;
                }
            }

            Console.WriteLine(string.Join(", ", input));
        }
    }
}
    
