using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());


            string message = string.Empty;
            for (int i = 0; i < n; i++)
            {
                char ch = char.Parse(Console.ReadLine());
                message += (char)(ch + key);
            }

            Console.WriteLine(message);
        }
    }
}
