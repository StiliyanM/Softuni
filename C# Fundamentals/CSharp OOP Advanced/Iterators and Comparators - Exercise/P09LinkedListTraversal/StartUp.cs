using System;

namespace P09LinkedListTraversal
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var list = new LinkedList<int>();
            var commandsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsCount; i++)
            {
                var tokens = Console.ReadLine().Split();

                var command = tokens[0];

                var number = int.Parse(tokens[1]);

                switch (command)
                {
                    case "Add":
                        list.Add(number);
                        break;
                    case "Remove":
                        list.Remove(number);
                            break;
                }
            }

            Console.WriteLine(list.Count);
            Console.WriteLine(string.Join(" ",list));
        }
    }
}
