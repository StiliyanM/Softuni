using System;
using System.Net;
namespace P02ValidateURL
{
    class Program
    {
        static void Main(string[] args)
        {
            var urlString = WebUtility.UrlDecode(Console.ReadLine());

            var url = new Uri(urlString);

            var protocol = url.Scheme;
            var host = url.Host;
            var port = url.Port.ToString();
            var path = url.AbsolutePath;

            bool validPort = (protocol == "http" && port == "80") ||
                            (protocol == "https" && port == "443");

            var isValid = !string.IsNullOrEmpty(protocol) && !string.IsNullOrEmpty(host) && validPort;

            if (!isValid)
            {
                Console.WriteLine("Invalid URL");
                return;
            }
            var queryString = url.Query ?? "";
            var fragment = url.Fragment ?? "";

            Console.WriteLine($"Protocol: {protocol}");
            Console.WriteLine($"Host: {host}");
            Console.WriteLine($"Port: {port}");
            Console.WriteLine($"Path: {path}");
            if(queryString != "")
                Console.WriteLine($"Query: {queryString.Substring(1)}");
            if (fragment != "")
                Console.WriteLine($"Fragment: {fragment.Substring(1)}");
        }
    }
}
