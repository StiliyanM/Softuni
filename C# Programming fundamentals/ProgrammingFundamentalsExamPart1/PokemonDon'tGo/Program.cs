using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDon_tGo
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(long.Parse).ToList();
            long removedValuesSum = 0;

            while (numbers.Count > 0)
            {
                var index = int.Parse(Console.ReadLine());

                long removedElValue = 0;

                if(index != 0 && numbers.Count == 1)
                {
                    removedElValue = numbers[0];
                    numbers.RemoveAt(0);
                }
                if(index < 0)
                {
                    removedElValue = numbers.First();
                    numbers[0] = numbers.Last();
                }
                else if(index >= numbers.Count)
                {
                    removedElValue = numbers.Last();
                    numbers[numbers.Count - 1] = numbers.First();
                }
                else
                {
                    removedElValue = numbers[index];
                    numbers.RemoveAt(index);
                }

                numbers = numbers.
                    Select(x => x <= removedElValue ? x += removedElValue : x -= removedElValue).
                    ToList();
                removedValuesSum += removedElValue;
            }

            Console.WriteLine(removedValuesSum);
        }
    }
}
