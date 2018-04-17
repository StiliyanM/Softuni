using System;
using System.Collections.Generic;
using System.Linq;

namespace P10CarSalesman
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var engines = new List<Engine>();
            var cars = new List<Car>();

            var enginesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < enginesCount; i++)
            {
                var engine = ParseEngine();
                

                engines.Add(engine);
            }

            var carsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < carsCount; i++)
            {
                var car = ParseCar(engines);             
                cars.Add(car);
            }

            PrintCars(car);
           
        }

        private static void PrintCars()
        {
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine.Model}:");
                Console.WriteLine($"    Power: {car.Engine.Power}");

                if (car.Engine.Displacement != null)
                {
                    Console.WriteLine($"    Displacement: {car.Engine.Displacement}");
                }
                else
                {
                    Console.WriteLine($"    Displacement: n/a");
                }
                Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
                if (car.Weight == null)
                    Console.WriteLine($"  Weight: n/a");
                else
                    Console.WriteLine($"  Weight: {car.Weight.Value}");

                Console.WriteLine($"  Color: {car.Color}");
            }
        }

        private static Car ParseCar(List<Engine> engines)
        {
            var tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var model = tokens[0];
            var engineModel = tokens[1];
            string color = string.Empty;
            int? weight = null;

            if (tokens.Length >= 3)
            {
                var isWeight = int.TryParse(tokens[2], out int number);
                if (!isWeight)
                {
                    color = tokens[2];
                }
                else
                {
                    weight = number;
                }

                if (tokens.Length == 4)
                {
                    if (color == string.Empty)
                    {
                        color = tokens[3];
                    }
                    else
                    {
                        weight = int.Parse(tokens[3]);
                    }
                }
            }

            var car = new Car();

            var engine = engines.First(e => e.Model == engineModel);

            car.Model = model;
            car.Engine = engine;
            car.Weight = weight;
            car.Color = color;

            return car;
        }

        private static Engine ParseEngine()
        {
            var tokens = Console.ReadLine().Split();

            var model = tokens[0];
            var power = tokens[1];
            int? displacement = null;
            string efficiency = string.Empty;

            if (tokens.Length >= 3)
            {
                var isNumber = int.TryParse(tokens[2], out int number);

                if (isNumber)
                {
                    displacement = number;
                }
                else
                {
                    efficiency = tokens[2];
                }

                if (tokens.Length == 4)
                {
                    if (efficiency == string.Empty)
                    {
                        efficiency = tokens[3];
                    }
                    else
                    {
                        displacement = int.Parse(tokens[3]);
                    }
                }
            }

            var engine = new Engine
            {
                Model = model,
                Power = power,
                Displacement = displacement,
                Efficiency = efficiency
            };

            return engine;
        }
    }
}
