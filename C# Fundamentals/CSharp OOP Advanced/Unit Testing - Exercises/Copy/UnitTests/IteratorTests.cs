using NUnit.Framework;
using P03IteratorTest;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace UnitTests
{
    public class IteratorTests
    {
        [TestCase("Ivan")]
        [TestCase("Ivan",null)]
        public void TestValidConstructor(params string[] elements)
        {
            var iterator = new ListIterator(elements.ToList());

            var field = typeof(ListIterator)
                .GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .FirstOrDefault(f => f.FieldType == typeof(List<string>));

            var actualElements = (List<string>)field.GetValue(iterator);


            Assert.That(actualElements, Is.EquivalentTo(elements.ToList()));
        }

        [Test]
        public void ConstuctorWithNullArgument()
        {
            Assert.That(() => new ListIterator(null), Throws.ArgumentNullException);
        }

        [Test]
        public void HasNextWhenNotAtTheEndOfTheCollection()
        {
            var iterator = new ListIterator(new string[] { "1", "2" });

            Assert.That(iterator.HasNext(), Is.EqualTo(true));
        }

        [Test]
        public void HasNextWhenAtTheEndOfTheCollection()
        {
            var iterator = new ListIterator(new string[] { "1"});

            Assert.That(iterator.HasNext(), Is.EqualTo(false));
        }

        [Test]
        public void MoveWhenNotAtTheEndOfTheCollection()
        {
            var iterator = new ListIterator(new string[] { "1", "2" });

            iterator.Move();

            var currentIndex = (int)typeof(ListIterator).GetField("currentIndex", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(iterator);

            Assert.That(currentIndex, Is.EqualTo(1));
        }

        [Test]
        public void MoveWhenAtTheEndOfTheCollection()
        {
            var iterator = new ListIterator(new string[] { "1" });

            iterator.Move();

            var currentIndex = (int)typeof(ListIterator).GetField("currentIndex", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(iterator);

            Assert.That(currentIndex, Is.EqualTo(0));
        }

        [Test]
        public void PrintWhenEmptyCollection()
        {
            var iterator = new ListIterator(new string[] { });

            Assert.That(() => iterator.Print(), Throws.InvalidOperationException.With.Message.SameAs("Invalid Operation!"));
        }
    }
}
