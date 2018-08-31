using System;
using System.Net;

namespace P01URLDecode
{
    class Program
    {
        static void Main(string[] args)
        {
            var urlString = Console.ReadLine();

            Console.WriteLine(WebUtility.UrlDecode(urlString));
        }
    }
}
