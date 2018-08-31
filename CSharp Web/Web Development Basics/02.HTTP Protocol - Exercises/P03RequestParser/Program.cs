using System;
using System.Collections.Generic;

namespace P03RequestParser
{
    class Program
    {
        static void Main(string[] args)
        {
            var methodPaths = new Dictionary<string, HashSet<string>>();
            var statusCode = "OK";
            var statusText = $"200 {statusCode}";

            while (true)
            {
                var line = Console.ReadLine();

                if (line == "END")
                {
                    break;
                }

                var lastSlash = line.LastIndexOf('/');

                var path = line.Substring(0, lastSlash);
                var method = line.Substring(lastSlash + 1);

                if (!methodPaths.ContainsKey(method))
                {
                    methodPaths[method] = new HashSet<string>();
                }

                methodPaths[method].Add(path);
            }

            var request = Console.ReadLine();

            var requestParts = request.Split();

            var requestMethod = requestParts[0].ToLower();
            var requestPath = requestParts[1];

            if (!methodPaths.ContainsKey(requestMethod) || !methodPaths[requestMethod].Contains(requestPath))
            {
                statusCode = "Not Found";
                statusText = $"404 {statusCode}";
            }

            Console.WriteLine($"HTTP/1.1 {statusText}");
            Console.WriteLine($"Content-Length: {statusCode.Length}");
            Console.WriteLine($"Content-Type: text/plain");
            Console.WriteLine();
            Console.WriteLine($"{statusCode}");
        }
    }
}
