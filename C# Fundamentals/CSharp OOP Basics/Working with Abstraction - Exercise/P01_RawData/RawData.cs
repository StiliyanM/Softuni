using System;
using System.Collections.Generic;
using System.Linq;

class RawData
{
    static void Main(string[] args)
    {
        List<Car> cars = new List<Car>();
        int lines = int.Parse(Console.ReadLine());

        for (int i = 0; i < lines; i++)
        {
            string[] parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Car car = GetCar(parameters);

            cars.Add(car);
        }

        string filter = Console.ReadLine();

        PrintCarsByFilter(cars, filter);
    }

    private static void PrintCarsByFilter(List<Car> cars, string filter)
    {
        var carsToPrint = new List<Car>();

        if (filter == "fragile")
        {
            carsToPrint = cars
                .FindAll(c => c.CargoType == "fragile" && c.Tires.Any(t => t.Pressure < 1));

        }
        else
        {
            carsToPrint = cars.FindAll(c => c.CargoType == "flamable" && c.EnginePower > 250);
        }

        Console.WriteLine(string.Join(Environment.NewLine, carsToPrint));
    }

    private static Car GetCar(string[] parameters)
    {
        string model = parameters[0];
        int engineSpeed = int.Parse(parameters[1]);
        int enginePower = int.Parse(parameters[2]);
        int cargoWeight = int.Parse(parameters[3]);
        string cargoType = parameters[4];

        Car car = new Car(model, engineSpeed, enginePower, cargoWeight, cargoType);

        var tires = GetTires(parameters.Skip(5).ToArray());

        car.Tires = tires;

        return car;
    }

    private static List<Tire> GetTires(string[] tiresInfo)
    {

        var tires = new List<Tire>();
        for (int i = 0; i < tiresInfo.Length; i += 2)
        {
            double tirePressure = double.Parse(tiresInfo[i]);
            int tireage = int.Parse(tiresInfo[i + 1]);

            var tire = new Tire(tirePressure, tireage);

            tires.Add(tire);
        }

        return tires;

    }
}

