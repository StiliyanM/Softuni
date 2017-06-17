using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._A_Miner_Task

{
    class Program
    {
        static void Main(string[] args)
        {
            var quantities = new Dictionary<string, long>();

            int cnt = 0;
            string resource = string.Empty;
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "stop")
                {
                    foreach (var item in quantities)
                    {
                        Console.WriteLine(item.Key + " -> " + item.Value);
                    }

                    break;
                }
                else
                {
                    cnt++;
                }


                if (cnt % 2 == 1)
                {
                    resource = input;

                    if (!quantities.ContainsKey(resource))
                    {
                        quantities.Add(resource, 0);
                    }
                }
                else if(cnt % 2 == 0)
                {
                    long quantity = long.Parse(input);
                    quantities[resource] += quantity;
                    
                }
            }
        }

    }
}
