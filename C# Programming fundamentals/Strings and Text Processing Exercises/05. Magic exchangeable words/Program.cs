using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Magic_exchangeable_words
{
    class Program
    {
        static void Main(string[] args)
        {
            var tokens = Console.ReadLine().Split();
            var str1 = tokens[0].Distinct().ToArray();
            var str2 = tokens[1].Distinct().ToArray();

            if (str1.Length == str2.Length)
                Console.WriteLine("true"); 
            else
                Console.WriteLine("false");

            //var longer = "";
            //var shorter = "";
            //if(str1.Length > str2.Length)
            //{
            //    longer = str1;
            //    shorter = str2;
            //}
            //else
            //{
            //    longer = str2;
            //    shorter = str1;
            //}
            //var charsCorrespondingToOtherChars = new Dictionary<char, char>();

            //bool areExchangeable = true;


            //for (int i = 0; i < shorter.Length; i++)
            //{
            //    if (!charsCorrespondingToOtherChars.ContainsKey(shorter[i]))
            //    {
            //        charsCorrespondingToOtherChars[shorter[i]] = longer[i];
            //    }
            //    else
            //    {
            //        if (charsCorrespondingToOtherChars[shorter[i]] != longer[i])
            //        {
            //            areExchangeable = false;
            //            break;
            //        }
            //    }
            //}

            //foreach (var c in longer)
            //{
            //    if (!charsCorrespondingToOtherChars.ContainsValue(c))
            //        areExchangeable = false;
            //}


            //Console.WriteLine(areExchangeable.ToString().ToLower());

        }
    }
}
        
    

