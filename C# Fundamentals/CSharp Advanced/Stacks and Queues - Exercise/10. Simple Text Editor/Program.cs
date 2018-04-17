using System;
using System.Collections.Generic;
using System.Text;

namespace _10._Simple_Text_Editor
{
    class Program
    {
        static void Main()
        {
            var text = new StringBuilder();

            var n = int.Parse(Console.ReadLine());

            var oldVersions = new Stack<string>();

            for (int i = 0; i < n; i++)
            {
                var args = Console.ReadLine().Split();

                var command = int.Parse(args[0]);

                switch (command)
                {
                    case 1:
                        var str = args[1];
                        oldVersions.Push(text.ToString());
                        text.Append(str);
                        break;
                    case 2:
                        var count = int.Parse(args[1]);
                        var startIndex = text.Length - count;
                        oldVersions.Push(text.ToString());
                        text.Remove(startIndex, count);
                        break;
                    case 3:
                        var index = int.Parse(args[1]) - 1;
                        Console.WriteLine(text[index]);
                        break;
                    case 4:
                        text.Clear();
                        text.Append(oldVersions.Pop());
                        break;
                }
            }
        }
    }
}
