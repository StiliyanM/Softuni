using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class RaceTower
{
    private int laps;
    private int length;

    private int currentLap;

    private int LapsLeft => laps - currentLap;

    private string weather = "Sunny";

    static DriverFactory driverFactory = new DriverFactory();
    static TyreFactory tyreFactory = new TyreFactory();

    private List<Tyre> tyres = new List<Tyre>();
    private List<Driver> racingDrivers = new List<Driver>();

    private List<Driver> failedDrivers = new List<Driver>();

    public void SetTrackInfo(int lapsNumber, int trackLength)
    {
        this.laps = lapsNumber;
        this.length = trackLength;
    }

    public void RegisterDriver(List<string> commandArgs)
    {
        try
        {
            var type = commandArgs[0];
            var name = commandArgs[1];
            var hp = int.Parse(commandArgs[2]);
            var fuelAmount = double.Parse(commandArgs[3]);
            var tyreType = commandArgs[4];
            var hardness = double.Parse(commandArgs[5]);


            if (tyreType == "Ultrasoft")
            {
                var grip = double.Parse(commandArgs[6]);
               tyres.Add(tyreFactory.CreateTyre(hardness, grip));
            }
            else
            {
                tyres.Add(tyreFactory.CreateTyre(hardness));
            }

            var tyre = tyres.Last();

            var car = new Car(hp, fuelAmount, tyre);

            var driver = driverFactory.CreateDriver(type, name, car);
            racingDrivers.Add(driver);
        }
        catch (System.Exception)
        {
            return;
        }
    }

    public void DriverBoxes(List<string> commandArgs)
    {
        var reasonToBox = commandArgs[0];

        var driverName = commandArgs[1];

        var driver = racingDrivers.First(d => d.Name == driverName);

        driver.TotalTime += 20;

        if(reasonToBox == "Refuel")
        {
            var fuelAmount = double.Parse(commandArgs[2]);
            driver.Refuel(fuelAmount);
        }
        else if(reasonToBox == "ChangeTyres")
        {
            var typeOfTyre = commandArgs[2];

            var hardness = double.Parse(commandArgs[3]);
            if(typeOfTyre == "Ultrasoft")
            {
                var grip = double.Parse(commandArgs[4]);
                driver.Car.Tyre = new UltrasoftTyre(hardness,grip);
            }
            else
            {
                driver.Car.Tyre = new HardTyre(hardness);
            }
        }
    }

    public string CompleteLaps(List<string> commandArgs)
    {
        int numberOfLaps = int.Parse(commandArgs[0]);

        if(numberOfLaps > this.LapsLeft)
        {
            throw new ArgumentException($"There is no time! On lap {this.currentLap}.");
        }

        string overtakes = "";
        for (int i = 0; i < numberOfLaps; i++)
        {
            for (int j = 0; j < racingDrivers.Count; j++)
            {
                var driver = racingDrivers[j];
                driver.TotalTime += 60 / (length / driver.Speed);

                try
                {
                    driver.Car.FuelAmount -= length * driver.FuelConsumptionPerKm;
                    driver.Car.Tyre.DegradateTyre();
                }
                catch (ArgumentException ex)
                {
                    FailDriver(driver, ex.Message);
                }
            }
            overtakes = GetOvertakes(i);

            if(overtakes != "")
            {
                Console.WriteLine(overtakes);
            }
        }

        currentLap += numberOfLaps;

        if(LapsLeft == 0)
        {
            Finish();
        }

        return overtakes.TrimEnd();
    }

    private void Finish()
    {
        var winner = this.racingDrivers.OrderBy(d => d.TotalTime).First();

        Console.WriteLine($"{winner.Name} wins the race for {winner.TotalTime:F3} seconds.");

        Environment.Exit(0);
    }

    private void FailDriver(Driver driver, string message)
    {
        driver.FailureReason = message;
        driver.Failed = true;
        failedDrivers.Add(driver);
        racingDrivers.Remove(driver);
    }

    private string GetOvertakes(int currentLap)
    {
        var drivers = this.racingDrivers.OrderByDescending(d => d.TotalTime).ToList();

        var builder = new StringBuilder();
        for (int i = 0; i < drivers.Count - 1; i++)
        {
            try
            {
                var overtaken = drivers[i].TryOvertake(drivers[i + 1], this.weather);

                if (overtaken)
                {
                    builder.AppendLine($"{drivers[i].Name} has overtaken {drivers[i + 1].Name} on lap {currentLap}.");
                    i++;
                }
            }
            catch (InvalidOperationException ex)
            {
                FailDriver(drivers[i], ex.Message);
            }
        }

        return builder.ToString().TrimEnd();
    }

    public string GetLeaderboard()
    {
        var builder = new StringBuilder();

        var counter = 1;

        builder.AppendLine($"Lap {currentLap}/{laps}");

        foreach (var driver in racingDrivers.OrderBy(d => d.TotalTime))
        {
            builder.AppendLine($"{counter} {driver.ToString()}");

            counter++;
        }

        foreach (var driver in failedDrivers)
        {
            builder.AppendLine($"{counter} {driver.ToString()}");

            counter++;
        }


        var result = builder.ToString().TrimEnd();

        return result;
    }

    public void ChangeWeather(List<string> commandArgs)
    {
        var newWeather = commandArgs[0];

        this.weather = newWeather;
    }

}
