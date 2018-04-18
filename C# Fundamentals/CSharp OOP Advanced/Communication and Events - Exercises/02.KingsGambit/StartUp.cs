namespace _02.KingsGambit
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using _02.KingsGambit.Units;

    class StartUp
    {
        static void Main()
        {
            string input = Console.ReadLine();

            var king = new King(input);
            var guards = new List<Unit>();
            var battleField = new BattleField();

            input = Console.ReadLine();

            foreach (var guardName in input.Split(' '))
            {
                guards.Add(new RoyalGuard(guardName));
            }

            input = Console.ReadLine();

            foreach (var footmandName in input.Split(' '))
            {
                guards.Add(new Footman(footmandName));
            }

            battleField.AttackHandler += king.Respond;
            foreach (var guard in guards)
            {
                battleField.AttackHandler += guard.Respond;
            }

            while ((input = Console.ReadLine()) != "End")
            {
                string[] data = input.Split(' ');

                string command = data[0];

                switch (command)
                {
                    case "Attack": battleField.Attack(); break;
                    case "Kill":
                        string name = data[1];

                        Unit guard = guards.FirstOrDefault(u => u.Name == name);

                        if (guard != null)
                        {
                            guard.Kill();

                            if (!guard.IsAlive)
                            {
                                battleField.AttackHandler -= guard.Respond;
                            }
                        }
                        break;
                }
            }
        }
    }
}
