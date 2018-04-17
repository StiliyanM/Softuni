using System;
using System.Collections.Generic;
using System.Linq;

namespace P08RawData
{
    class StartUp
    {
        static void Main()
        {
            var carCount = int.Parse(Console.ReadLine());

            var cars = new List<Car>();

            for (int i = 0; i < carCount; i++)
            {
                var args = Console.ReadLine().Split();

                var model = args[0];
                var engineSpeed = int.Parse(args[1]);
                var enginePower = int.Parse(args[2]);
                var cargoWeight = int.Parse(args[3]);
                var cargoType = args[4];
                var tire1Pressure = double.Parse(args[5]);
                var tire1Age = int.Parse(args[6]);
                var tire2Pressure = double.Parse(args[7]);
                var tire2Age = int.Parse(args[8]);
                var tire3Pressure = double.Parse(args[9]);
                var tire3Age = int.Parse(args[10]);
                var tire4Pressure = double.Parse(args[11]);
                var tire4Age = int.Parse(args[12]);

                var engine = new Engine(engineSpeed, enginePower);
                var cargo = new Cargo(cargoType, cargoWeight);
                var tire1 = new Tire(tire1Pressure, tire1Age);
                var tire2 = new Tire(tire2Pressure, tire2Age);
                var tire3 = new Tire(tire3Pressure, tire3Age);
                var tire4 = new Tire(tire4Pressure, tire4Age);

                var tires = new List<Tire>
                {
                    tire1,
                    tire2,
                    tire3,
                    tire4
                };

                var car = new Car(model, engine, cargo, tires);

                cars.Add(car);
            }

            var cType = Console.ReadLine();

            if (cType == "fragile")
                foreach (var c in
                        cars.
                        Where(c => c.Cargo.Type == "fragile").
                        ToList().
                        FindAll(c => c.Tires.Any(t => t.Pressure < 1)))
                {
                    Console.WriteLine(c.Model);
                }
            else
                foreach (var c in cars.Where(c => c.Cargo.Type == cType && c.Engine.Power > 250))
                {
                    Console.WriteLine(c.Model);
                }
        }
    }
}
