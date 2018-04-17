using System;
using System.Text;
using System.Text.RegularExpressions;
namespace P02CubicsRube
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"^\d+([A-Za-z]+)([^A-Za-z]+)*$";
            string input;

            while ((input = Console.ReadLine()) != "Over!")
            {
                var inputMessage = input;

                var count = int.Parse(Console.ReadLine());

                var match = Regex.Match(inputMessage, pattern);

                if (!match.Success && match.Groups[1].Value.Length != count)
                {
                    continue;
                }

                var message = match.Groups[1].Value;

                var decryptedMessage = new StringBuilder();

                foreach (var ch in match.ToString())
                {
                    if (!char.IsDigit(ch))
                    {
                        continue;
                    }

                    int index = (int)char.GetNumericValue(ch);

                    if(index < 0 || index >= count)
                    {
                        decryptedMessage.Append(" ");
                    }
                    else
                    {
                        decryptedMessage.Append(message[index]);
                    }
                }

                Console.WriteLine("{0} == {1}", message, decryptedMessage.ToString());
            }
        }
    }
}
