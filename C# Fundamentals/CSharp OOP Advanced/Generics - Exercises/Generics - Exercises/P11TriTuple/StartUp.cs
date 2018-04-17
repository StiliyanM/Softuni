using System;

namespace P11Threeuple
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var firstLineArgs = Console.ReadLine().Split();
            var fullName = firstLineArgs[0] + " " + firstLineArgs[1];
            var address = firstLineArgs[2];
            var town = firstLineArgs[3];
            var firstTuple = new Threeuple<string, string,string>(fullName, address,town);

            var secondLineArgs = Console.ReadLine().Split();

            var name = secondLineArgs[0];
            var litersOfBeer = int.Parse(secondLineArgs[1]);
            var drunkOrNot = secondLineArgs[2];

            var secondTuple = new Threeuple<string, int,bool>(name, litersOfBeer,drunkOrNot == "drunk" ? true : false);

            var thirdLineArgs = Console.ReadLine().Split();

            string accountName = thirdLineArgs[0];
            double accountBalance = double.Parse(thirdLineArgs[1]);
            string bankName = thirdLineArgs[2];

            var thirtTuple = new Threeuple<string, double,string>(accountName, accountBalance,bankName);

            Console.WriteLine(firstTuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine(thirtTuple);
        }
    }
}
