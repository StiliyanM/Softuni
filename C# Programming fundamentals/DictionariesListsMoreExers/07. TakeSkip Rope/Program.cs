using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.TakeSkip_Rope
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            var numbersList = new List<char>();
            var nonNumbersList = new List<char>();
            for (int i = 0; i < str.Length; i++)
            {
                if(char.IsDigit(str[i]))
                {
                    numbersList.Add(str[i]);
                }
                else
                {
                    nonNumbersList.Add(str[i]);
                }
            }

            var skipList = numbersList.Where(x => numbersList.IndexOf(x) % 2 == 0).ToList();
            var takeList = numbersList.Where(x => numbersList.IndexOf(x) % 2 == 1).ToList();

            string result = string.Empty;
            int total = 0;
            for(int i = 0; i < skipList.Count();i++)
            {
                
                string temp = new string(nonNumbersList.Skip(skipList[i] + total).Take(takeList[i]).ToArray());
                result += temp;
                total += skipList[i] + takeList[i];

            }

            Console.WriteLine(result);
        }
    }
}
