using System;
using System.Collections.Generic;
using System.Linq;
namespace P05BorderControl
{
    class StartUp
    {
        private static City city;

        static void Main(string[] args)
        {
            string command;

            var n = int.Parse(Console.ReadLine());

            city = new City();
            var rebels = new List<Rebel>();
            var citizens = new List<Citizen>();

            for (int i = 0; i < n; i++)
            {
                command = Console.ReadLine();
                var tokens = command.Split();

                if (tokens.Length == 3)
                {
                    var rebel = ParseRebel(tokens);
                    rebels.Add(rebel);
                }
                else
                {
                    var citizen = ParseCitizen(tokens);
                    citizens.Add(citizen);
                }

            }
            while ((command = Console.ReadLine()) != "End")
            {
                var citizen = citizens.FirstOrDefault(c => c.Name == command);
                var rebel = rebels.FirstOrDefault(r => r.Name == command);

                if(rebel == null && citizen == null)
                {
                    continue;
                }
                else if(rebel == null)
                {
                    citizen.BuyFood();
                }
                else
                {
                    rebel.BuyFood();
                }
                //var entity = tokens[0];

                //tokens = tokens.Skip(1).ToArray();
                //switch (entity)
                //{
                //    case "Citizen":
                //        var citizen = ParseCitizen(tokens);
                //        city.AddCitizen(citizen);
                //        break;
                //    case "Pet":
                //        var pet = ParsePet(tokens);
                //        city.AddPet(pet);
                //        break;
                //    case "Robot":
                //       var robot = ParseRobot(tokens);
                //        city.AddRobot(robot);
                //        break;

            }

            Console.WriteLine(citizens.Sum(c => c.Food) + rebels.Sum(r => r.Food));

            //var year = Console.ReadLine();

            //    Console.WriteLine(city.GetBirthdaysInYear(year));

        }


        private static Rebel ParseRebel(string[] tokens)
        {
            var name = tokens[0];
            var age = int.Parse(tokens[1]);
            var group = tokens[2];

            return new Rebel(name, age,group);
        }        

        private static Pet ParsePet(string[] parameters)
        {
            var name = parameters[0];
            var birthday = parameters[1];
            var pet = new Pet(name, birthday);
            city.Birthdays.Add(birthday);
            return pet;
        }

        private static Robot ParseRobot(string[] parameters)
        {
            var model = parameters[0];
            var id = parameters[1];

            var robot = new Robot(model, id);
            city.AddRobot(robot);
            city.Ids.Add(id);

            return robot;
        }

        private static Citizen ParseCitizen(string[] parameters)
        {
            var name = parameters[0];
            var age = int.Parse(parameters[1]);
            var id = parameters[2];
            var birthday = parameters[3];
            var citizen = new Citizen(name, age, id, birthday);
            city.Ids.Add(id);
            city.Birthdays.Add(birthday);
            return citizen;
        }
    }
}
