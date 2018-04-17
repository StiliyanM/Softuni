using System;
using System.Globalization;
using System.Linq;


public class Topping
{
    private string type;
    private double weight;


    public Topping(string type, double weight)
    {
        this.Type = type;
        this.Weight = weight;
    }

    public double Weight
    {
        get { return weight; }
        set
        {
            if (value < 0 || value > 50)
                throw new ArgumentException(
                    $"{CultureInfo.CurrentCulture.TextInfo.ToTitleCase(type)} weight should be in the range[1..50].");

            weight = value;
        }
    }

    public string Type
    {
        get
        {
            return type.ToLower();
        }
        set
        {
            string[] types = { "meat", "veggies", "cheese", "sauce" };

            if (!types.Contains(value.ToLower()))
            {
                throw new ArgumentException($"Cannot place {value} on top of your pizza.");
            }

            type = value;
        }
    }

    public double SumCalories()
    {
        double typeModifier = 1;

        if (this.Type == "meat")
            typeModifier = 1.2;
        else if (this.Type == "veggies")
            typeModifier = 0.8;
        else if (this.Type == "cheese")
            typeModifier = 1.1;
        else if (this.Type == "sauce")
            typeModifier = 0.9;

        double calories = (this.Weight * 2) * typeModifier;

        return calories;
    }
    public void PrintCalories()
    {
        Console.WriteLine($"{this.SumCalories():f2}");
    }
}


