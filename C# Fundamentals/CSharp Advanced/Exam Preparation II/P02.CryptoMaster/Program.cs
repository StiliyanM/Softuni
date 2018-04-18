using System;
using System.Linq;

namespace P02CryptoMaster
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var maxLength = 0;
            for (int startingIndex = 0; startingIndex < numbers.Length; startingIndex++)
            {
                var step = 1;

                for (int stepIndex = 0; stepIndex < numbers.Length; stepIndex++)
                {
                    var length = 0;
                    var lastNumber = int.MinValue;

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        var index = (startingIndex + step * i) % (numbers.Length);
                        if (numbers[index] > lastNumber)
                        {
                            lastNumber = numbers[index];
                            length++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (length > maxLength)
                    {
                        maxLength = length;
                    }
                    step++;
                }

            }

            Console.WriteLine(maxLength);
        }
    }
}
