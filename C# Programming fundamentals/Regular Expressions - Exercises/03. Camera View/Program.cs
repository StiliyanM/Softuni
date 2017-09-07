using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Camera_View
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int skip = nums[0];
            int take = nums[1];

            var input = Console.ReadLine();

            var pattern = @"(?<=(\|<))[a-zA-Z]+(&|(?=|\|<))";

            var matches = Regex.Matches(input, pattern);

            var results = new List<string>();
            foreach (Match m in matches)
            {
                results.Add(new string(m.Value.Skip(skip).Take(take).ToArray()));
            }

            Console.WriteLine(string.Join(", ",results));
        }
    }
}
