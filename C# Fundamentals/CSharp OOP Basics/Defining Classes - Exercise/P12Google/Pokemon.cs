﻿namespace P12Google
{
    class Pokemon
    {
        public Pokemon()
        {

        }
        public Pokemon(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public string Name { get; set; }
        public string Type { get; set; }
    }
}