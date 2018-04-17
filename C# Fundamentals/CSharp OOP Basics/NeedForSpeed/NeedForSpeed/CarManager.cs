using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class CarManager
{

    public Dictionary<int, Car> Cars { get; set; } = new Dictionary<int, Car>();

    public Dictionary<int, Race> Races { get; set; } = new Dictionary<int, Race>();

    Garage garage = new Garage();

    public void Register(int id, string type, string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
    {
        Car car = null;
        switch (type)
        {
            case "Performance":
                car = new PerformanceCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability);
                break;

            case "Show":
                car = new ShowCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability);
                break;
        }

        if (!Cars.ContainsKey(id))
        {
            Cars.Add(id, car);
        }
    }

    public string Check(int id)
    {
        var car = this.Cars[id];

        return car.ToString();
    }

    public void Open(int id, string type, int length, string route, int prizePool)
    {
        if (!this.Races.ContainsKey(id))
        {
            switch (type)
            {
                case "Casual":
                    this.Races[id] = new CasualRace(length, route, prizePool);
                    break;
                case "Drag":
                    this.Races[id] = new DragRace(length, route, prizePool);
                    break;
                case "Drift":
                    this.Races[id] = new DriftRace(length, route, prizePool);
                    break;
            }
        }
    }

    public void Participate(int carId, int raceId)
    {
        var car = this.Cars[carId];

        if (car.Parked)
        {
            return;
        }

        car.CanBeParked = false;
        this.Races[raceId].Participants.Add(car);
    }

    public string Start(int id)
    {
        var race = this.Races[id];

        var builder = new StringBuilder();

        var winners = race.GetWinners();

        if(winners.Count == 0)
        {
            return "Cannot start the race with zero participants.";
        }

        builder.AppendLine($"{race.Route} - {race.Length}");

        builder.AppendLine(string.Join(Environment.NewLine, race.GetWinners()));

        var result = builder.ToString().TrimEnd();

        for (int i = 0; i < race.Participants.Count; i++)
        {
            race.Participants[i].CanBeParked = true;
        }
        Races.Remove(id);

        return result;
    }

    public void Park(int id)
    {
        var car = this.Cars[id];

        if (!car.CanBeParked)
        {
            return;
        }

        car.Parked = true;
        car.CanBeParked = false;

        garage.ParkedCars.Add(car);
    }

    public void Unpark(int id)
    {
        var car = this.Cars[id];

        car.Parked = false;
        car.CanBeParked = true;
        garage.ParkedCars.Remove(car);
    }

    public void Tune(int tuneIndex, string addOn)
    {
        foreach (var car in garage.ParkedCars)
        {
            car.Tune(tuneIndex, addOn);
        }
    }

}
