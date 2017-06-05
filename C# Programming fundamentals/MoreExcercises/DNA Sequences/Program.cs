using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNA_Sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = int.Parse(Console.ReadLine());

            char a = 'a';
            char b = 'b';
            char c = 'c';

            int cnt = 0;

            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    for (int k = 1; k < 5; k++)
                    {
                        char special = 'X';

                        if (i == 1)
                            a = 'A';
                        else if (i == 2)
                            a = 'C';
                        else if (i == 3)
                            a = 'G';
                        else if (i == 4)
                            a = 'T';

                        if (j == 1)
                            b = 'A';
                        else if (j == 2)
                            b = 'C';
                        else if (j == 3)
                            b = 'G';
                        else if (j == 4)
                            b = 'T';

                        if (k == 1)
                            c = 'A';
                        else if (k == 2)
                            c = 'C';
                        else if (k == 3)
                            c = 'G';
                        else if (k == 4)
                            c = 'T';

                        cnt++; 

                        if (i + j + k >= sum)
                            special = 'O';

                        Console.Write(special);
                        Console.Write(a);
                        Console.Write(b);
                        Console.Write(c);
                        Console.Write(special);

                        if (cnt % 4 != 0)
                        Console.Write(' ');
                        else
                            Console.WriteLine();

                    }
                }
            }
        }
    }
}
