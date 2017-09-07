using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.Email_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"^(?<username>[a-zA-Z]{5,})@(?<domain>[a-z]{3,}\.(com|bg|org))$";

            int n = int.Parse(Console.ReadLine());

            var emails = new Dictionary<string, List<string>>();
            Regex regex = new Regex(pattern);
            for (int i = 0; i < n; i++)
            {
                var email = Console.ReadLine();

                if (regex.IsMatch(email))
                {
                    var match = regex.Match(email);
                    var username = match.Groups["username"].Value;
                    var domain = match.Groups["domain"].Value;

                    if (!emails.ContainsKey(domain))
                    {
                        emails[domain] = new List<string>();
                    }

                    if (!emails[domain].Contains(username))
                    {
                        emails[domain].Add(username);
                    }
                }
            }

            foreach (var email in emails.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine(email.Key + ":");
                var usernames = email.Value;

                foreach (var u in usernames)
                {
                    Console.WriteLine("### " + u);
                }
            }
        }
    }
}
