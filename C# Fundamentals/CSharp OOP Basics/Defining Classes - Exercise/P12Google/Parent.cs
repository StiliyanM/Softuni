namespace P12Google
{
    class Parent
    {
        public Parent()
        {

        }
        public Parent(string name, string birthday)
        {
            Name = name;
            this.Birthday = birthday;
        }

        public string Name { get; set; }
        public string Birthday { get; set; }
    }
}
