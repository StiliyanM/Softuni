using NUnit.Framework;

namespace P06Twitter
{
    using P08CustomLinkedList;

    public class CustomLinkedListTests
    {
        [Test]
        public void TestValidCoundOnNewListCreation()
        {
            DynamicList<int> list = new DynamicList<int>();
            int initialCount = list.Count;

            Assert.AreEqual(0, initialCount, "A newly created list should have a count of 0.");
        }

        [Test]
        public void TestListCountAfterAddOneElementToList()
        {
            DynamicList<int> list = new DynamicList<int>();
            list.Add(1);
            int count = list.Count;

            Assert.AreEqual(1, count, "List count should be 1 after adding one element.");
        }

        [Test]
        public void TestAddOneElementToList()
        {
            DynamicList<int> list = new DynamicList<int>();
            list.Add(15);
            int value = list[0];

            Assert.AreEqual(15, value, "The value at index 0 should be equal to the value entered.");
        }

        [Test]
        public void TestCountAfterAddTwoElementsToList()
        {
            DynamicList<int> list = new DynamicList<int>();
            list.Add(1);
            list.Add(2);

            int count = list.Count;

            Assert.AreEqual(2, count, "List count should be 2 after adding two elements.");
        }

        [Test]
        public void TestElementsAddedInSequenceAfterAddingTwoElements()
        {
            DynamicList<string> list = new DynamicList<string>();
            list.Add("first");
            list.Add("second");

            string firstElement = list[0];
            string secondElement = list[1];

            Assert.AreEqual("first", firstElement, "The element at index 0 should be the first element added to the list.");
            Assert.AreEqual("second", secondElement, "The element at index 1 should be the second element added to the list.");
        }

        [Test]
        public void TestGetNegativeIndexException()
        {
            DynamicList<int> list = new DynamicList<int>();

            Assert.That(() => list[-1], Throws.Exception);
        }

        [Test]
        public void TestGetIndexGreaterThanCountException()
        {
            DynamicList<int> list = new DynamicList<int>();
            list.Add(0);

            Assert.That(() => list[1], Throws.Exception);
        }

        [Test]
        public void TestSetOnValidIndex()
        {
            DynamicList<string> list = new DynamicList<string>();
            list.Add("initial");
            list[0] = "changed";

            string newValue = list[0];

            Assert.AreEqual("changed", newValue, "The value at index 0 should be changed through the indexer.");
        }

        [Test]
        public void TestRemoveAtOnNegativeIndex()
        {
            DynamicList<int> list = new DynamicList<int>();

            Assert.That(() => list.RemoveAt(-1), Throws.Exception);
        }

        [Test]
        public void TestRemoveAtOnIndexGreaterThanCount()
        {
            DynamicList<int> list = new DynamicList<int>();
            list.Add(0);
            list.Add(1);

            Assert.That(() => list.RemoveAt(2), Throws.Exception);
        }

        [Test]
        public void TestListCountAfterRemoveAt()
        {
            DynamicList<int> list = new DynamicList<int>();
            list.Add(0);
            list.RemoveAt(0);

            int count = list.Count;

            Assert.AreEqual(0, count);
        }

        [Test]
        public void TestRemoveAt()
        {
            DynamicList<int> list = new DynamicList<int>();
            list.Add(0);
            list.Add(1);
            list.Add(2);
            list.RemoveAt(1);

            int firstNumber = list[0];
            int secondNumber = list[1];

            Assert.AreEqual(0, firstNumber, "The first number should be the first entered in the list.");
            Assert.AreEqual(2, secondNumber, "The second number should be the third entered after removing the second from the list.");
        }

        [Test]
        public void TestCountAfterRemoveNonExistingElementFromList()
        {
            DynamicList<string> list = new DynamicList<string>();
            list.Add("one");
            list.Add("two");
            int count = list.Count;

            Assert.AreEqual(2, count, "The count of the list should remain unchanged after trying to remove a non-existing element.");
        }

        [Test]
        public void TestReturnValueAfterRemoveNonExistingElementFromList()
        {
            DynamicList<string> list = new DynamicList<string>();
            list.Add("one");
            list.Add("two");
            int index = list.Remove("three");

            Assert.AreEqual(-1, index, "The returned index of a non-existing element should be -1.");
        }

        [Test]
        public void TestCountAfterRemoveElementFromList()
        {
            DynamicList<string> list = new DynamicList<string>();
            list.Add("first");
            list.Add("second");
            list.Add("third");

            list.Remove("second");
            int count = list.Count;

            Assert.AreEqual(2, count, "The count of elements of the list should be 2 after removing an element.");
        }

        [Test]
        public void TestReturnValueAfterRemoveElementFromList()
        {
            DynamicList<string> list = new DynamicList<string>();
            list.Add("first");
            list.Add("second");
            list.Add("third");

            int index = list.Remove("second");

            Assert.AreEqual(1, index, "The index of the removed element should be 1.");
        }

        [Test]
        public void TestValidListItemsAfterRemove()
        {
            DynamicList<string> list = new DynamicList<string>();
            list.Add("first");
            list.Add("second");
            list.Add("third");

            list.Remove("second");
            string first = list[0];
            string second = list[1];

            Assert.AreEqual("first", first, "The first element of the list should be the first one entered.");
            Assert.AreEqual("third", second, "The second element in the list should be the third one entered after removing an element.");
        }

        [Test]
        public void TestIndexOfNonExistingElement()
        {
            DynamicList<string> list = new DynamicList<string>();
            list.Add("first");
            list.Add("second");

            int index = list.IndexOf("third");

            Assert.AreEqual(-1, index, "The return value when searching for a non-existing element should be -1.");
        }

        [Test]
        public void TestIndexOfExistingElement()
        {
            DynamicList<string> list = new DynamicList<string>();
            list.Add("first");
            list.Add("second");

            int index = list.IndexOf("second");

            Assert.AreEqual(1, index, "The index of the searched element should be 1.");
        }

        [Test]
        public void TestContainsOnNonExisingElement()
        {
            DynamicList<string> list = new DynamicList<string>();
            list.Add("first");
            list.Add("second");

            bool isFound = list.Contains("third");

            Assert.IsFalse(isFound, "The element is not in the list and Contains should return false.");
        }

        [Test]
        public void TestContainsOnExisingElement()
        {
            DynamicList<string> list = new DynamicList<string>();
            list.Add("first");
            list.Add("second");

            bool isFound = list.Contains("second");

            Assert.IsTrue(isFound, "The element is in the list and Contains should return true.");
        }
    }
}
   

