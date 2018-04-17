using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P08MilitaryElite
{
    class StartUp
    {
        static MilitaryEliteGenerator generator = new MilitaryEliteGenerator();
        static void Main(string[] args)
        {
            string command;

            var soldiers = new List<Soldier>();

            var resultBuilder = new StringBuilder();
            while ((command = Console.ReadLine()) != "End")
            {
                var tokens = command.Split();
                var soldierType = tokens[0];
                var parameters = tokens.Skip(1).ToArray();

                var firstName = parameters[1];
                var lastName = parameters[2];
                var id = parameters[0];
                double salary;
                string corpsInput;
                switch (soldierType)
                {
                    case "Private":
                        salary = double.Parse(parameters[3]);

                        resultBuilder.AppendLine(generator.RegisterPrivate(id, firstName, lastName, salary));
                        break;
                    case "LeutenantGeneral":
                        salary = double.Parse(parameters[3]);
                        var privates = parameters.Skip(4).ToArray();

                        resultBuilder.AppendLine(generator.RegisterLeutenantGeneral(id, firstName, lastName, salary, privates));
                        break;
                    case "Engineer":
                        corpsInput = parameters[4];
                        salary = double.Parse(parameters[3]);
                        var repairsInput = parameters.Skip(5).ToArray();

                        resultBuilder.AppendLine(generator.RegisterEngineer(id, firstName, lastName, salary, corpsInput, repairsInput));
                        break;
                    case "Commando":
                        salary = double.Parse(parameters[3]);
                        var missionsInput = parameters.Skip(5).ToArray();
                        corpsInput = parameters[4];
                        resultBuilder.AppendLine(generator.RegisterCommando(id, firstName, lastName, salary, corpsInput, missionsInput));
                        break;
                    case "Spy":
                        var codeNumber = int.Parse(parameters[3]);
                        resultBuilder.AppendLine(generator.RegisterSpy(id, firstName, lastName, codeNumber));
                        break;
                }
            }

            var result = resultBuilder.ToString().TrimEnd();
            Console.WriteLine(result);
        }
    }
}