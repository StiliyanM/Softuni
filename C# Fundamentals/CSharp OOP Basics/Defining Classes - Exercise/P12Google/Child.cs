namespace P12Google
{
    class Child
    {
        public Child()
        {

        }
        public Child(string name, string birthday)
        {
            Name = name;
            this.Birthday = birthday;
        }

        public string Name { get; set; }
        public string Birthday { get; set; }
    }
}
