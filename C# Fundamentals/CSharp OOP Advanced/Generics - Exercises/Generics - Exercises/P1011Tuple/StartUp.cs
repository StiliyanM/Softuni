using System;
namespace P10Tuple
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var firstLineArgs = Console.ReadLine().Split();
            var fullName = firstLineArgs[0] + " " + firstLineArgs[1];
            var address = firstLineArgs[2];

            var firstTuple = new MyTuple<string, string>(fullName,address);

            var secondLineArgs = Console.ReadLine().Split();

            var name = secondLineArgs[0];
            var litersOfBeer = int.Parse(secondLineArgs[1]);

            var secondTuple = new MyTuple<string, int>(name, litersOfBeer);

            var thirdLineArgs = Console.ReadLine().Split();

            int first = int.Parse(thirdLineArgs[0]);
            double second = double.Parse(thirdLineArgs[1]);

            var thirtTuple = new MyTuple<int, double>(first, second);

            Console.WriteLine(firstTuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine(thirtTuple);
        }
    }
}
