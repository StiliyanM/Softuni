using System;

namespace P01EventImplementation
{
    public class NameChangeEventArgs : EventArgs
    {
        public NameChangeEventArgs(string name)
        {
            Name = name;
        }

        public string Name { get;private set; }
    }
}
