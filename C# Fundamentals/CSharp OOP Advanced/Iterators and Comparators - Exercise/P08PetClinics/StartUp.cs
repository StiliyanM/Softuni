using System;
using System.Collections.Generic;
using System.Linq;

namespace P08PetClinics
{
    class StartUp
    {
        static List<Pet> pets = new List<Pet>();
        static List<Clinic> clinics = new List<Clinic>();

        static void Main()
        {
            var commandsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsCount; i++)
            {
                string[] arguments = Console.ReadLine().Split();

                var command = arguments[0];

                try
                {
                    ExecuteCommand(command,arguments.Skip(1).ToArray());
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private static void ExecuteCommand(string command, string[] arguments)
        {
            switch (command)
            {
                case "Create":
                    CreateCommand(arguments);
                    break;
                case "Add":
                    AddCommand(arguments);
                    break;
                case "Release":
                    ReleaseCommand(arguments);
                    break;
                case "HasEmptyRooms":
                    HasEmptyRoomsCommand(arguments);
                    break;
                case "Print":
                    PrintCommand(arguments);
                    break;
            }
        }

        private static void PrintCommand(string[] arguments)
        {
            var clinicName = arguments[0];
            var clinic = FindClinic(clinicName);

            if (arguments.Length == 1)
            {
                clinic.Print();
            }
            else
            {
                clinic.Print(int.Parse(arguments[1]));
            }
        }

        private static void HasEmptyRoomsCommand(string[] arguments)
        {
            var clinicName = arguments[0];
            var clinic = FindClinic(clinicName);
            Console.WriteLine(clinic.HasEmptyRooms()); 
        }

        private static void ReleaseCommand(string[] arguments)
        {
            var clinicName = arguments[0];
            var clinic = FindClinic(clinicName);
            Console.WriteLine(clinic.ReleasePet()); 
        }

        private static void AddCommand(string[] arguments)
        {
            var petName = arguments[0];
            var clinicName = arguments[1];
            var pet = pets.First(p => p.Name == petName);
            Clinic clinic = FindClinic(clinicName);
            Console.WriteLine(clinic.AddPet(pet)); 
        }

        private static Clinic FindClinic(string clinicName)
        {
            return clinics.FirstOrDefault(c => c.Name == clinicName);
        }

        private static void CreateCommand(string[] arguments)
        {
            var type = arguments[0];
            var name = arguments[1];

            if (type == "Pet")
            {
                var age = int.Parse(arguments[2]);
                var kind = arguments[3];

                var pet = new Pet(name, age, kind);
                pets.Add(pet);
            }
            else if (type == "Clinic")
            {
                var roomsCount = int.Parse(arguments[2]);
                var clinic = new Clinic(name, roomsCount);

                clinics.Add(clinic);
            }
        }
    }
}
