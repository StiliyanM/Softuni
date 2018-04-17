using System;
using System.Collections.Generic;
using System.Linq;

namespace P01Vehicles
{
    class StartUp
    {
        static Car car;
        static Truck truck;
        static Bus bus;
        static void Main(string[] args)
        { 
            var carInfo = Console.ReadLine()
                .Split()
                .Skip(1)
                .Select(double.Parse)
                .ToArray();

            var truckInfo = Console.ReadLine()
                .Split()
                .Skip(1)
                .Select(double.Parse)
                .ToArray();

            var busInfo = Console.ReadLine()
                .Split()
                .Skip(1)
                .Select(double.Parse)
                .ToArray();

            car = new Car(carInfo[0], carInfo[1], (int)carInfo[2]);
            truck = new Truck(truckInfo[0], truckInfo[1],(int)truckInfo[2]);
            bus = new Bus(busInfo[0], busInfo[1],(int)busInfo[2]);

            var vehicles = new List<Vehicle> {car,truck ,bus};


            var commandsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsCount; i++)
            {
                var tokens = Console.ReadLine().Split();
                var command = tokens[0];
                var vehicleType = tokens[1];

                double distance;
                switch (command)
                {
                    case "Drive":
                        distance = double.Parse(tokens[2]);
                        TryDrive(distance, vehicleType);
                        break;
                    case "Refuel":
                        var fuelAmount = double.Parse(tokens[2]);
                        TryRefuel(fuelAmount, vehicleType);
                        break;
                    case "DriveEmpty":
                        distance = double.Parse(tokens[2]);
                        bus.WithPeople = false;
                        Console.WriteLine(bus.Drive(distance));
                        break;
                }
            }

            foreach (var v in vehicles)
            {
                Console.WriteLine(v);
            }
        }

        private static void TryDrive(double distance, string vehicleType)
        {
            if (vehicleType == "Car")
            {
                Console.WriteLine(car.Drive(distance));
            }
            else if(vehicleType == "Truck")
            {
                Console.WriteLine(truck.Drive(distance));
            }
            else
            {
                bus.WithPeople = true;

                Console.WriteLine(bus.Drive(distance));
            }
        }

        private static void TryRefuel(double fuelAmount, string vehicleType)
        {
            if (vehicleType == "Car")
            {
                car.Refuel(fuelAmount);
            }
            else if(vehicleType == "Truck")
            {
                truck.Refuel(fuelAmount);
            }
            else
            {
                bus.Refuel(fuelAmount);
            }
        }
    }
}
