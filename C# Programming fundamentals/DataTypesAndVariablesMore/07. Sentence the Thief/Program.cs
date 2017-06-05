using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sentence_the_Thief
{
    class Program
    {
        static void Main(string[] args)
        {
            string id = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            long thiefID = 0;

            long temp = long.MinValue;

            for (int i = 0; i < n; i++)
            {


                long num = long.Parse(Console.ReadLine());

                if (id == "sbyte")
                {
                    if (num <= sbyte.MaxValue)
                    {
                        if (num > temp)
                            temp = num;
                    }
                }
                else if (id == "int")
                {
                    if (num <= int.MaxValue)
                    {
                        if (num > temp)
                            temp = num;
                    }
                }
                else if (id == "long")
                {
                    if (num <= long.MaxValue)
                    {
                        if (num > temp)
                            temp = num;
                    }
                }
                thiefID = temp;
            }

            double sentence = 0;
            if(thiefID >= 0)
            {
                sentence = Math.Ceiling(thiefID / 127d);
            }
            else
            {
                sentence = Math.Ceiling(thiefID / -128d);
                sentence = Math.Abs(sentence);
            }

            if(sentence > 1)
            {
                Console.WriteLine($"Prisoner with id {thiefID} is sentenced to {sentence} years");
            }
            else
            {
                Console.WriteLine($"Prisoner with id {thiefID} is sentenced to {sentence} year");
            }
        }

    }
}