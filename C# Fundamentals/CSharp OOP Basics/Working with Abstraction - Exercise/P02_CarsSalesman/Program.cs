using System;
using System.Collections.Generic;
using System.Linq;

class CarSalesman
{
    static void Main(string[] args)
    {
        List<Car> cars = new List<Car>();
        List<Engine> engines = new List<Engine>();

        int engineCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < engineCount; i++)
        {
            string[] parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

           var engine = ParseEngine(parameters);

            engines.Add(engine);
        }
        int carCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < carCount; i++)
        {
            string[] parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var car = ParseCar(engines, parameters);

            cars.Add(car);
        }

        foreach (var car in cars)
        {
            Console.WriteLine(car);
        }
    }

    private static Car ParseCar(List<Engine> engines, string[] parameters)
    {
        var car = new Car();

        string model = parameters[0];
        string engineModel = parameters[1];
        Engine engine = engines.FirstOrDefault(x => x.Model == engineModel);

        int weight = -1;

        car = new Car(model, engine);

        if (parameters.Length >= 3)
        {
           var isNumber =  int.TryParse(parameters[2], out weight);

            if (isNumber)
            {
                car.Weight = weight;
            }
            else
            {
                car.Color = parameters[2];
            }
        
            if(parameters.Length == 4)
            {
                if (isNumber)
                {
                    car.Color = parameters[3];
                }
                else
                {
                    car.Weight = int.Parse(parameters[3]);
                }
            }
        }

        return car;
    }

    private static Engine ParseEngine(string[] parameters)
    {
        string model = parameters[0];
        int power = int.Parse(parameters[1]);

        var engine = new Engine(model, power);
        int displacement = -1;

        if (parameters.Length >= 3)
        {
            var isNumber = int.TryParse(parameters[2], out displacement);

            if (isNumber)
            {
                engine.Displacement = displacement;
            }
            else
            {
                engine.Efficiency = parameters[2];
            }

            if (parameters.Length == 4)
            {
                if (isNumber)
                {
                    engine.Efficiency = parameters[3];
                }
                else
                {
                    engine.Displacement = int.Parse(parameters[3]);
                }
            }
        }

        return engine;
    }
}


