using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class RaceTower
{
    private DriverFactory driverFactory = new DriverFactory();
    private TyreFactory tyreFactory = new TyreFactory();

    private int totalLaps;
    private int length;
    private int currentLap;

    private string weather = "Sunny";

    private List<Driver> racingDrivers = new List<Driver>();
    private List<Driver> failedDrivers = new List<Driver>();

    public void SetTrackInfo(int lapsNumber, int trackLength)
    {
        totalLaps = lapsNumber;
        length = trackLength;
    }

    public void RegisterDriver(List<string> commandArgs)
    {
        try
        {
            var driver = driverFactory.CreateDriver(commandArgs.ToArray());
            racingDrivers.Add(driver);
        }
        catch (Exception)
        {
            return;
        }
    }

    public void DriverBoxes(List<string> commandArgs)
    {
        var reasonToBox = commandArgs[0];

        var driverName = commandArgs[1];

        var driver = racingDrivers.First(d => d.Name == driverName);
        driver.IncreaseTotalTime(20);

        var arguments = commandArgs.Skip(2).ToArray();

        switch (reasonToBox)
        {
            case "ChangeTyres":
                ChangeTyres(driver, arguments);
                break;
            case "Refuel":
                Refuel(driver, arguments);
                break;
        }
    }

    private void Refuel(Driver driver, string[] arguments)
    {
        var fuelAmount = double.Parse(arguments[0]);
        driver.Car.Refuel(fuelAmount);
    }

    private void ChangeTyres(Driver driver, string[] arguments)
    {
        var tyre = tyreFactory.CreateTyre(arguments);

        driver.Car.ChangeTyre(tyre);
    }

    public string CompleteLaps(List<string> commandArgs)
    {
        var numberOfLaps = int.Parse(commandArgs[0]);

        var sb = new StringBuilder();

        if (currentLap + numberOfLaps > totalLaps)
        {
            return $"There is no time! On lap {currentLap}.";
        }

        for (int i = 0; i < numberOfLaps; i++)
        {
            currentLap++;

            IncreaseTimeForDrivers();

            for (int j = 0; j < racingDrivers.Count; j++)
            {
                var driver = racingDrivers[j];
                try
                {
                    double amount = length * driver.FuelConsumptionPerKm;
                    driver.Car.ReduceFuelAmount(amount);

                    driver.Car.Tyre.DegradateTyre();
                }
                catch (ArgumentException ae)
                {
                    FailDriver(driver, ae.Message);
                    j--;
                }
            }

            var result = CheckForOvertakes();

            if (!string.IsNullOrWhiteSpace(result))
                sb.AppendLine(result);
        }

        if (currentLap == totalLaps)
        {
            Finish();
        }

        return sb.ToString().TrimEnd();
    }

    private void IncreaseTimeForDrivers()
    {
        for (int i = 0; i < racingDrivers.Count; i++)
        {
            var amount = 60 / (this.length / racingDrivers[i].Speed);
            racingDrivers[i].IncreaseTotalTime(amount);
        }
    }

    private void Finish()
    {
        var winner = this.racingDrivers.OrderBy(d => d.TotalTime).First();

        Console.WriteLine($"{winner.Name} wins the race for {winner.TotalTime:f3} seconds.");

        Environment.Exit(0);
    }

    private string CheckForOvertakes()
    {
        var builder = new StringBuilder();

        var drivers = racingDrivers.OrderByDescending(d => d.TotalTime).ToList();

        for (int i = 0; i < drivers.Count - 1; i++)
        {
            var overtakingDriver = drivers[i];
            var overtakenDriver = drivers[i + 1];
            bool overtakeSuccess = overtakingDriver.TryOvertake(overtakenDriver, weather);

            if (overtakeSuccess)
            {
                builder.AppendLine($"{overtakingDriver.Name} has overtaken {overtakenDriver.Name} on lap {currentLap}.");
                i++;
            }

            if(overtakingDriver.FailureReason == "Crashed")
            {
                var driver = racingDrivers.Find(e => e == overtakingDriver);
                FailDriver(driver, "Crashed");
            }
        }


        return builder.ToString().TrimEnd();
    }

    private void CheckForCrashedDrivers()
    {
        for (int i = 0; i < racingDrivers.Count; i++)
        {
            if (racingDrivers[i].FailureReason == "Crashed")
            {
                FailDriver(racingDrivers[i], "Crashed");
                i--;

            }
        }
    }

    private void FailDriver(Driver driver, string message)
    {
        driver.FailureReason = message;
        this.racingDrivers.Remove(driver);
        this.failedDrivers.Add(driver);
    }

    public string GetLeaderboard()
    {
        var sb = new StringBuilder();

        sb.AppendLine($"Lap {currentLap}/{totalLaps}");

        int position = 1;
        foreach (var driver in racingDrivers.OrderBy(d => d.TotalTime))
        {
            sb.AppendLine($"{position} {driver.Name} {driver.TotalTime:f3}");

            position++;
        }
        failedDrivers.Reverse();
        foreach (var driver in failedDrivers)
        {
            sb.AppendLine($"{position} {driver.Name} {driver.FailureReason}");

            position++;
        }

        return sb.ToString().TrimEnd();
    }

    public void ChangeWeather(List<string> commandArgs)
    {
        this.weather = commandArgs[0];
    }

}
