using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Vehicle_Catalogue
{
    class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public decimal HorsePower { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var vehicles = new List<Vehicle>();

            while (true)
            {
                var vehiclesInput = Console.ReadLine().Split().ToArray();

                if (vehiclesInput[0] == "End")
                {
                    break;
                }
                string type = vehiclesInput[0].ToLower();
                string model = vehiclesInput[1].ToLower();
                string color = vehiclesInput[2];
                decimal horsePower = decimal.Parse(vehiclesInput[3]);

                Vehicle vehicle = new Vehicle();
                {
                    vehicle.Type = type;
                    vehicle.Model = model;
                    vehicle.Color = color;
                    vehicle.HorsePower = horsePower;
                }
                vehicles.Add(vehicle);
            }

            while (true)
            {
                var model = Console.ReadLine();

                if (model == "Close the Catalogue")
                {
                    break;
                }

                foreach (var vehicle in vehicles)
                {
                    if (vehicle.Model == model.ToLower())
                    {
                        Console.WriteLine("Type: " + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(vehicle.Type));
                        Console.WriteLine("Model: " + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(vehicle.Model));
                        Console.WriteLine("Color: " + vehicle.Color);
                        Console.WriteLine("Horsepower: " + vehicle.HorsePower);
                    }
                }
            }

            decimal carSum = 0;
            decimal truckSum = 0;
            int carCnt = 0;
            int truckCnt = 0;
            foreach (var v in vehicles)
            {
                if(v.Type == "car")
                {
                    carSum += v.HorsePower;
                    carCnt++;
                }
                else if(v.Type == "truck")
                {
                    truckSum += v.HorsePower;
                    truckCnt++;
                }
            }
            decimal carAvg = carSum;
            if (carCnt > 0)
                carAvg = carSum / carCnt;

            decimal truckAvg = truckSum;
            if (truckCnt > 0)
                truckAvg = truckSum / truckCnt;

            Console.WriteLine($"Cars have average horsepower of: {carAvg:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {truckAvg:f2}.");


        }
    }
}
