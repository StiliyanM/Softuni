using NUnit.Framework;
using P02PeopleDatabase;

namespace UnitTests
{
    public class PersonDatabaseTests
    {
        [Test]
        public void TestAddWithExistingUsername()
        {
            var username = "Pesho";

            var db = new PeopleDatabase(new Person(11, username));

            Assert.That(() => db.Add(new Person(1, username)), Throws.InvalidOperationException);
        }

        [Test]
        public void TestAddWithExistingId()
        {
            var id = 12;

            var db = new PeopleDatabase(new Person(id,"Az"));

            Assert.That(() => db.Add(new Person(id,"Ti")), Throws.InvalidOperationException);
        }

        [Test]
        public void TestValidFindById()
        {
            var person = new Person(12, "Pesho");
            var db = new PeopleDatabase();

            db.Add(person);

            Assert.That(person, Is.EqualTo(db.FindById(12)));
        }

        [Test]
        public void TestValidFindByUsername()
        {
            string username = "Pesho";
            var db = new PeopleDatabase();

            var person = new Person(12, username);

            db.Add(person);
            Assert.That(person, Is.EqualTo(db.FindByUsername(username)));
        }

        [TestCase("pesho")]
        [TestCase("Ivan")]
        public void FindByUsernameWhenDoesntExist(string username)
        {
            var db = new PeopleDatabase(new Person(11,"Pesho"));

            Assert.That(() => db.FindByUsername(username), Throws.InvalidOperationException);
        }

        [Test]
        public void FindByUsernameWhenArgumentIsNull()
        {
            var db = new PeopleDatabase();

            Assert.That(() => db.FindByUsername(null), Throws.ArgumentNullException);
        }

        [Test]
        public void FindByIdWhenArgumentIsNegative()
        {
            var db = new PeopleDatabase();

            Assert.That(() => db.FindById(-5), Throws.ArgumentException);
        }

        [Test]
        public void FindByIdWhenIdNotPresent()
        {
            var db = new PeopleDatabase();

            db.Add(new Person(11, "Pesho"));

            Assert.That(() => db.FindById(1), Throws.InvalidOperationException);
        }

        [Test]
        public void FindByIdWhenValid()
        {
            var db = new PeopleDatabase();

            var person = new Person(11, "Pesho");

            db.Add(person);

            Assert.That(db.FindById(11), Is.EqualTo(person));
        }
    }
}
