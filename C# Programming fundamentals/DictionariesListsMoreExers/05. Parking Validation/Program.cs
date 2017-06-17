using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Parking_Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            var namesPlates = new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().ToArray();

                string action = input[0];


                if (action == "register")
                {
                    string name = input[1];
                    string plate = input[2];

                    if (namesPlates.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {plate}");
                    }
                    else if(PlateIsValid(plate) == false)
                    {
                        Console.WriteLine($"ERROR: invalid license plate {plate}");
                    }
                    else if (namesPlates.ContainsValue(plate))
                    {
                        Console.WriteLine($"ERROR: license plate {plate} is busy");
                    }
                    else
                    {
                        namesPlates.Add(name, plate);
                        Console.WriteLine($"{name} registered {plate} successfully");
                    }

                }
                else if(action == "unregister")
                {
                    string name = input[1];
                    if(!namesPlates.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                        continue;
                    }

                    namesPlates.Remove(name);

                    Console.WriteLine($"user {name} unregistered successfully");
                }
            }

            foreach (var item in namesPlates)
            {
                var username = item.Key;
                var plateNumber = item.Value;

                Console.WriteLine($"{username} => {plateNumber}");
            }
        }

        private static bool PlateIsValid(string plate)
        {

            if(plate.Length != 8)
            {
                return false;
            }
            var firstTwo = plate.ToCharArray().Take(2).ToList();
            var lastTwo = plate.ToCharArray().Skip(6).ToList();

            var middle = plate.ToCharArray().Skip(2).Take(4).ToList();

            foreach (var item in middle)
            {
                if(!char.IsDigit(item))
                {
                    return false;
                }
            }
            foreach (var item in firstTwo.Concat(lastTwo))
            {
                if(!char.IsUpper(item))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
