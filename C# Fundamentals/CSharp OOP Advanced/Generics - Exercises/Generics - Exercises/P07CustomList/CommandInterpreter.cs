using System;

namespace P07CustomList
{
    internal class CommandInterpreter
    {
        private CustomList<string> mylist;

        public CommandInterpreter(CustomList<string> mylist)
        {
            this.mylist = mylist;
        }

        public void InterpretCommand(Command command, string[] arguments)
        {
            switch (command)
            {
                case Command.Add:
                    Add(arguments);
                    break;
                case Command.Remove:
                    Remove(arguments);
                    break;
                case Command.Contains:
                    Console.WriteLine(Contains(arguments));
                    break;
                case Command.Swap:
                    Swap(arguments);
                    break;
                case Command.Greater:
                    Console.WriteLine(Greater(arguments));
                    break;
                case Command.Max:
                    Console.WriteLine(mylist.Max());
                    break;
                case Command.Min:
                    Console.WriteLine(mylist.Min());
                    break;
                case Command.Sort:
                    mylist.Sort();
                    break;
                case Command.Print:
                    Print();
                    break;
            }
        }

        private void Print()
        {
            foreach (var item in mylist)
            {
                Console.WriteLine(item);
            }
        }

        private int Greater(string[] arguments)
        {
            var element = arguments[0];
            var count = mylist.CountGreaterThan(element);

            return count;
        }

        private void Swap(string[] arguments)
        {
            var index1 = int.Parse(arguments[0]);
            var index2 = int.Parse(arguments[1]);
            mylist.Swap(index1, index2);
        }

        private bool Contains(string[] arguments)
        {
            var element = arguments[0];
            var contains = mylist.Contains(element);
            return contains;
        }

        private void Remove(string[] arguments)
        {
            var elementIndex = int.Parse(arguments[0]);
            mylist.Remove(elementIndex);
        }

        private void Add(string[] arguments)
        {
            var element = arguments[0];
            mylist.Add(element);
        }
    }
}