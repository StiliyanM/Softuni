using System;
using System.Collections.Generic;
using System.Linq;

namespace P01JediMeditation
{
    class Program
    {
        static void Main(string[] args)
        {
            var withYoda = new string[]
           {
               "m","k","ts","p"
           };

            var withoutYoda = new string[]
            {
               "ts","m","k","p"
            };

            var linesCount = int.Parse(Console.ReadLine());

            bool hasYoda = false;
            var jedis = new List<string>(100000);
            for (int i = 0; i < linesCount; i++)
            {
                var input = Console.ReadLine().Split().ToList();

                if (hasYoda == false)
                    if (input.Any(e => e.Contains('y')))
                    {
                        hasYoda = true;
                    }
                jedis.AddRange(input);
            }

            var sortArray = withoutYoda;

            if (hasYoda)
            {
                jedis.RemoveAll(e => e.Contains('y'));
                sortArray = withYoda;
            }
            Console.WriteLine(string.Join(" ", jedis
                .OrderBy(j => Array.IndexOf(sortArray, j[0] == 's' || j[0] == 't' ? "ts" : j[0].ToString()))));
        }
    }
}
