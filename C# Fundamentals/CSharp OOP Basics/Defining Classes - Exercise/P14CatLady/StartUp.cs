using System;
using System.Collections.Generic;
using System.Linq;
namespace P14CatLady
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var siameseCats = new List<Siamese>();
            var cymricCats = new List<Cymric>();
            var streetExtraordinaireCats = new List<StreetExtraordinaire>();

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                var tokens = command.Split();

                var type = tokens[0];
                var name = tokens[1];

                switch (type)
                {
                    case "Siamese":
                        var s = new Siamese
                        {
                            Name = name,
                            EarSize = int.Parse(tokens[2])
                        };
                        siameseCats.Add(s);
                        break;
                    case "Cymric":
                        var c = new Cymric
                        {
                            Name = name,
                            FurLength = double.Parse(tokens[2])
                        };
                        cymricCats.Add(c);
                        break;
                    case "StreetExtraordinaire":
                        var se = new StreetExtraordinaire
                        {
                            Name = name,
                            DecibelsOfMeows = int.Parse(tokens[2])
                        };
                        streetExtraordinaireCats.Add(se);
                        break;
                }
            }

            var catName = Console.ReadLine();

            var siamese = siameseCats.FirstOrDefault(c => c.Name == catName);

            if (siamese != null)
            {
                Console.WriteLine(siamese);
            }

            var cymric = cymricCats.FirstOrDefault(c => c.Name == catName);

            if(cymric != null)
            {
                Console.WriteLine(cymric);
            }

            var streetExtraordinaire = streetExtraordinaireCats
                .FirstOrDefault(c => c.Name == catName);

            if (streetExtraordinaire != null)
            {
                Console.WriteLine(streetExtraordinaire);
            }

        }
    }
}
