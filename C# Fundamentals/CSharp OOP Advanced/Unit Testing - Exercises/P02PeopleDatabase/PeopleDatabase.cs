namespace P02PeopleDatabase
{
    using System;
    using P01Database;
    using System.Linq;

    public class PeopleDatabase : Database<Person>
    {
        public PeopleDatabase(params Person[] values) : base(values)
        {
        }

        public override void Add(Person person)
        {
            if (this.values.Any(p => p?.Id == person.Id || p?.Username == person.Username))
            {
                throw new InvalidOperationException();
            }

            base.Add(person);
        }

        public Person FindByUsername(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                throw new ArgumentNullException();
            }

            var person = base.values.FirstOrDefault(p => p?.Username == username);

            if(person == null)
            {
                throw new InvalidOperationException();
            }

            return person;
        }

        public Person FindById(long id)
        {
            if(id < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            var person = base.values.FirstOrDefault(p => p?.Id == id);

            if(person == null)
            {
                throw new InvalidOperationException();
            }

            return person;
        }
    }
}
