using System;
using NUnit.Framework;
using P01Database;
using System.Reflection;
using System.Linq;

namespace UnitTests
{
    public class DatabaseTests
    {
        [Test]
        public void CapacityIsCorrect()
        {
            var assembly = Assembly.GetAssembly(typeof(Database<>));

            var types = assembly.GetTypes();
            var field = assembly
                .GetTypes()
                .First(t => t == typeof(IntDatabase))
                .GetField("values", BindingFlags.Instance | BindingFlags.NonPublic);

            var instance = Activator.CreateInstance(typeof(IntDatabase),new object[] { });

            var length = ((int[])field.GetValue(instance)).Length;

            Assert.That(length, Is.EqualTo(16));
        }

        [Test]
        public void AddIsValid()
        {
            var db = new IntDatabase();

            db.Add(1);

            FieldInfo field = GetDataArray();

            var values = (int[])field.GetValue(db);

            Assert.That(values[0], Is.EqualTo(1));
        }

        private static FieldInfo GetDataArray()
        {
            return typeof(IntDatabase)
                .GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .FirstOrDefault(f => f.FieldType == typeof(int[]));
        }

        [Test]
        public void TestAddWhenFull()
        {
            var db = new IntDatabase(new int[16]);

            Assert.That(() => db.Add(1), Throws.InvalidOperationException);
        }

        [Test]
        public void TestRemoveValid()
        {
            var db = new IntDatabase(1);

            db.Remove();
            var field = GetDataArray();

            var values = (int[])field.GetValue(db);

            Assert.That(values[0], Is.EqualTo(0));
        }

        [Test]
        public void RemoveWhenEmptyArray()
        {
            var db = new IntDatabase();

            Assert.That(() => db.Remove(), Throws.InvalidOperationException);
        }

        [TestCase(-20)]
        [TestCase(1,2,3,4,5)]
        [TestCase()]
        [TestCase(0)]
        public void TestConstructorValid(params int[] values)
        {
            var db = new IntDatabase(values);

            var field = GetDataArray();

            var actualValues = (int[])field.GetValue(db);

            var desiredValues = new int[16];

            for (int i = 0; i < values.Length; i++)
            {
                desiredValues[i] = values[i];
            }

            Assert.That(() => desiredValues, Is.EquivalentTo(actualValues));
        }

        [Test]
        public void TestConstructorInvalid()
        {        
            Assert.That(() => new IntDatabase(new int[17]), Throws.InvalidOperationException);
        }

        [TestCase(1, 3, 4, 5)]
        [TestCase(-2)]
        [TestCase()]
        public void TestValidFetch(params int[] input)
        {
            var db = new IntDatabase(input);

            var field = GetDataArray();

            var actualValues = (int[])field.GetValue(db);

            var values = new int[16];

            for (int i = 0; i < input.Length; i++)
            {
                values[i] = input[i];
            }

            Assert.That(values, Is.EquivalentTo(actualValues));
        }
    }
}
