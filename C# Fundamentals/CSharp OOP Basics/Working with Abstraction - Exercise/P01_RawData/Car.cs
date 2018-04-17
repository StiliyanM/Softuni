using System.Collections.Generic;

class Car
{
    public Car(string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType)
    {
        this.Model = model;
        this.EngineSpeed = engineSpeed;
        this.EnginePower = enginePower;
        this.CargoWeight = cargoWeight;
        this.CargoType = cargoType;
    }

    public Car()
    {

    }

    public string Model { get; set; }
    public int EngineSpeed { get; set; }
    public int EnginePower { get; set; }
    public int CargoWeight { get; set; }
    public string CargoType { get; set; }
    public List<Tire> Tires { get; set; } = new List<Tire>();

    public override string ToString()
    {
        return $"{this.Model}";
    }
}

