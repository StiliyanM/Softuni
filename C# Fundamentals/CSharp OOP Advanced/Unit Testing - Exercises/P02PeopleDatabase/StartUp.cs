using System;

namespace P02PeopleDatabase
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var db = new PeopleDatabase(new Person(11, "Pesho"));

            db.Add(new Person(12, "Az"));
        }
    }
}
