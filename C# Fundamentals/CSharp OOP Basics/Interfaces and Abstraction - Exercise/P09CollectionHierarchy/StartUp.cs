namespace P09CollectionHierarchy
{
    using Models;
    using System.Text;
    using System;

    class StartUp
    {
        static void Main()
        {
            var addCollection = new AddCollection<string>();
            AddRemoveCollection<string> addRemoveCollection = new AddRemoveCollection<string>();
            MyList<string> myList = new MyList<string>();

            var manipulator = new CollectionManipulator();

            var elementsToAdd = Console.ReadLine().Split();

            manipulator.FillCollection<string>(elementsToAdd, addCollection);
            manipulator.FillCollection<string>(elementsToAdd, addRemoveCollection);
            manipulator.FillCollection<string>(elementsToAdd, myList);

            var numberOfRemovals = int.Parse(Console.ReadLine());

            manipulator.Remove(numberOfRemovals, addRemoveCollection);
            manipulator.Remove(numberOfRemovals, myList);

            Console.WriteLine(manipulator.GetOperationsInfo());
        }
    }
}
