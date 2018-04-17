using System;
using System.Collections.Generic;
using System.Linq;
namespace P04Hospital
{
    class Program
    {
        static void Main()
        {
            var doctorPatients = new Dictionary<string, List<string>>();

            var departments = new Dictionary<string, List<string>>();

            string input;

            while ((input = Console.ReadLine()) != "Output")
            {
                var tokens = input.Split();

                var department = tokens[0];
                var doctor = tokens[1] + " " + tokens[2];
                var patient = tokens.Last();

                if (!departments.ContainsKey(department))
                {
                    departments[department] = new List<string>();
                }

                if (!doctorPatients.ContainsKey(doctor))
                {
                    doctorPatients[doctor] = new List<string>();
                }

                if (departments[department].Count < 60)
                {
                    departments[department].Add(patient);
                    doctorPatients[doctor].Add(patient);
                }
            }

            while ((input = Console.ReadLine()) != "End")
            {
                var tokens = input.Split();

                if (tokens.Length == 1)
                {
                    foreach (var patient in departments[tokens[0]])
                    {
                        Console.WriteLine(patient);
                    }
                }
                else
                {
                    var isRoomNumber = int.TryParse(tokens[1], out int roomNumber);

                    if (isRoomNumber)
                    {
                        var department = tokens[0];

                        var patientsToPrint = departments[department]
                                                .Skip((roomNumber - 1) * 3)
                                                .Take(3)
                                                .OrderBy(e => e)
                                                .ToArray();

                        foreach (var patient in patientsToPrint)
                        {
                            Console.WriteLine(patient);
                        }
                    }
                    else
                    {
                        var doctor = tokens[0] + " " + tokens[1];

                        foreach (var patient in doctorPatients[doctor].OrderBy(e => e))
                        {
                            Console.WriteLine(patient);
                        }
                    }
                }
            }
        }
    }
}
