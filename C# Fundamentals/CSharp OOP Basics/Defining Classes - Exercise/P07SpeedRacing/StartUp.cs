using System;
using System.Collections.Generic;
using System.Globalization;

class StartUp
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var cars = new List<Car>();
        for (int i = 0; i < n; i++)
        {
            var args = Console.ReadLine().Split();
            var car = new Car();
            var model = args[0];
            var fuelAmount = decimal.Parse(args[1]);
            var fuelConsumptionFor1km = decimal.Parse(args[2],CultureInfo.InvariantCulture);

            car.Model = model;
            car.FuelAmount = fuelAmount;
            car.FuelConsumptionFor1km = fuelConsumptionFor1km;

            cars.Add(car);
        }

        while (true)
        {
            var args = Console.ReadLine().Split();

            if (args[0] == "End")
                break;

            var carModel = args[1];
            var amountOfKm = decimal.Parse(args[2]);

            cars.Find(c => c.Model == carModel).Drive(amountOfKm);
        }

        foreach (var car in cars)
        {
            Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.DistanceTraveled}");
        }
    }
}

