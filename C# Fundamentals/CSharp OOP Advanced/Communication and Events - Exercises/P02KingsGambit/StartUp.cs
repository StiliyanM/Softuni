using System;

namespace P02KingsGambit
{
    using Models;
    using System.Linq;
    using System.Collections.Generic;

    class StartUp
    {
        static void Main(string[] args)
        {
            var kingName = Console.ReadLine();

            var king = new King(kingName);

            List<string> GuardNames = Console.ReadLine().Split().ToList();

            var footmenNames = Console.ReadLine().Split().ToList();

            foreach (var name in GuardNames)
            {
                king.AddSubordinate(new RoyalGuard(name));
            }

            foreach (var name in footmenNames)
            {
                king.AddSubordinate(new Footman(name));
            }

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                var command = input.Split()[0];
                var name = input.Split()[1];
            }

        }
    }
}
