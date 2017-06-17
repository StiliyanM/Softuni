using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Heists
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] prices = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            long jewelsPrice = prices[0];
            long goldPrice = prices[1];

            long money = 0;

            while (true)
            {
                string[] info = Console.ReadLine().Split(' ').ToArray();

                if (info[0] == "Jail" && info[1] == "Time")
                    break;

                string loot = info[0];
                long expenses = long.Parse(info[1]);

                int jewelsCnt = 0;
                int goldCnt = 0;

                for (int i = 0; i < loot.Length; i++)
                {
                    if (loot[i] == '%')
                        jewelsCnt++;
                    else if (loot[i] == '$')
                        goldCnt++;
                }

                money += jewelsCnt * jewelsPrice + goldCnt * goldPrice - expenses;

            }

            if(money >= 0)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {money}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {Math.Abs(money)}.");
            }
        }
    }
}
