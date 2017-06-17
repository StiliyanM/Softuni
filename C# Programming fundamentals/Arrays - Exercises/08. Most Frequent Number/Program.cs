using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int MostFrequency = 1;
            int firstNum = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                int frequency = 1;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        frequency++;
                        if (frequency > MostFrequency)
                        {

                            MostFrequency = frequency;
                            firstNum = array[i];
                        }
                    }
                }
            }
            Console.WriteLine(firstNum);
        }
    }
}
