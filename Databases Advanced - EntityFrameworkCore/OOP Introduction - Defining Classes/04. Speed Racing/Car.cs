using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Car
{
    public string Model { get; set; }
    public decimal FuelAmount { get; set; }
    public decimal FuelConsumptionFor1km { get; set; }
    public decimal DistanceTraveled { get; set; }

    public void Drive(decimal amountOfKm)
    {
        if(amountOfKm * this.FuelConsumptionFor1km > FuelAmount)
        {
            Console.WriteLine("Insufficient fuel for the drive");
            return;
        }

        this.FuelAmount -= amountOfKm * this.FuelConsumptionFor1km;
        this.DistanceTraveled += amountOfKm;
    }
}

