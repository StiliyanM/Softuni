using System;

namespace P10ExplicitInterfaces
{
    using Contracts;
    class StartUp
    {
        static void Main(string[] args)
        {
            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                var tokens = command.Split();

                var name = tokens[0];
                var country = tokens[1];
                var age = int.Parse(tokens[2]);

                var citizen = new Citizen(name, country, age);

                IPerson person = citizen;
                IResident resident = citizen;

                Console.WriteLine(person.GetName());
                Console.WriteLine(resident.GetName());
            }
        }
    }
}
