using System;
using System.Linq;

public class Dough
{
    private string[] bakingTechniques = { "crispy", "chewy", "homemade" };
    private string[] types = { "white", "wholegrain" };

    private const string invalidDoughType = "Invalid type of dough.";
    
    private string type;
    private string bakingTechnique;
    private double weight;


    public Dough()
    {

    }
    public Dough(string type, string bakingTechnique, double weight)
    {
        Type = type;
        BakingTechnique = bakingTechnique;
        Weight = weight;
    }

    public double Weight
    {
        get { return weight; }
        set
        {
            if (value < 1 || value > 200)
                throw new ArgumentException("Dough weight should be in the range [1..200].");

            weight = value;
        }
    }

    public string BakingTechnique
    {
        get
        {
            return bakingTechnique.ToLower();
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value) || !bakingTechniques.Contains(value.ToLower()))
            {
                throw new ArgumentException(invalidDoughType);
            }

            bakingTechnique = value;
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
            if (string.IsNullOrWhiteSpace(value) || !types.Contains(value.ToLower()))
            {
                throw new ArgumentException(invalidDoughType);
            }

            type = value;
        }
    }

    public double SumCalories()
    {
        double typeModifier = 1;
        double bakingTechniqueModifier = 1;

        if (Type == "white")
            typeModifier = 1.5;

        if (BakingTechnique == "crispy")
            bakingTechniqueModifier = 0.9;
        else if (BakingTechnique == "chewy")
            bakingTechniqueModifier = 1.1;

        double calories = (Weight * 2) * typeModifier * bakingTechniqueModifier;

        return calories;
    }

    public void PrintCalories()
    {
        Console.WriteLine($"{SumCalories():f2}"); 
    }

}

