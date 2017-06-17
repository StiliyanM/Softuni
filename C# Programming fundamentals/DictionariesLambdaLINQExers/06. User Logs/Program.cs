using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {

            var UsernameIpCounter = new SortedDictionary<string, Dictionary<string, int>>();

            while (true)
            {
                var output = Console.ReadLine().Split().ToList();

                if (output[0] == "end")
                {
                    foreach (var user in UsernameIpCounter)
                    {
                        var username = user.Key;
                        Console.WriteLine(username + ": ");

                        var IpCounter = user.Value;
                        int forCnt = 0;
                        foreach (var ip in IpCounter)
                        {
                            int cnt = ip.Value;
                            var ips = ip.Key;
                            Console.Write(ips + " => " + cnt);
                            forCnt++;
                            if (IpCounter.Count > forCnt)
                            {
                                Console.Write(", ");
                            }
                        }
                        Console.WriteLine(".");
                    }
                    break;
                }

                string IP = output[0].Substring(3);
                string userName = output[2].Substring(5);
                int counter = 1;

                if (!UsernameIpCounter.ContainsKey(userName))
                {
                    UsernameIpCounter[userName] = new Dictionary<string, int>();
                }

                if (!UsernameIpCounter[userName].ContainsKey(IP))
                {
                    UsernameIpCounter[userName][IP] = 0;
                }

                UsernameIpCounter[userName][IP] += counter;
            }
        }
    }
}
