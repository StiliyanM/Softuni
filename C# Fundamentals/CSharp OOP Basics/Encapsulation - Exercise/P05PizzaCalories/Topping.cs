using System;
using System.Linq;

public class Topping
{
    string[] types = { "meat", "veggies", "cheese", "sauce" };

    private string type;
    private double weight;


    public Topping(string type, double weight)
    {
        Type = type;
        Weight = weight;
    }

    public double Weight
    {
        get { return weight; }
        set
        {
            if (value < 1 || value > 50)
                throw new ArgumentException(
                    $"{type} weight should be in the range [1..50].");

            weight = value;
        }
    }

    public string Type
    {
        get
        {
            return type;
        }
        set
        {

            if (string.IsNullOrWhiteSpace(value) || !types.Contains(value.ToLower()))
            {
                throw new ArgumentException($"Cannot place {value} on top of your pizza.");
            }

            type = value;
        }
    }

    public double SumCalories()
    {
        double typeModifier = 1;

        switch (Type.ToLower())
        {
            case "meat":
                typeModifier = 1.2;
                break;
            case "veggies":
                typeModifier = 0.8;
                break;
            case "cheese":
                typeModifier = 1.1;
                break;
            case "sauce":
                typeModifier = 0.9;
                break;
        }

        double calories = (Weight * 2) * typeModifier;

        return calories;
    }
    public void PrintCalories()
    {
        Console.WriteLine($"{SumCalories():f2}");
    }
}


