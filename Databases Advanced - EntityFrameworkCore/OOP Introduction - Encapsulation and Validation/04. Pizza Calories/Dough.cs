using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Dough
{
    private string type;
    private string bakingTechnique;
    private double weight;

    public Dough()
    {

    }
    public Dough(string type, string bakingTechnique, double weight)
    {
        this.Type = type;
        this.BakingTechnique = bakingTechnique;
        this.Weight = weight;
    }

    public double Weight
    {
        get { return weight; }
        set
        {
            if (value < 0 || value > 200)
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
            string[] techniques = { "crispy", "chewy", "homemade" };

            if (!techniques.Contains(value.ToLower()))
            {
                throw new ArgumentException("Invalid type of dough.");
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
            string[] types = { "white", "wholegrain" };

            if (!types.Contains(value.ToLower()))
            {
                throw new ArgumentException("Invalid type of dough.");
            }

            type = value;
        }
    }

    public double SumCalories()
    {
        double typeModifier = 1;
        double bakingTechniqueModifier = 1;

        if (this.Type == "white")
            typeModifier = 1.5;

        if (this.BakingTechnique == "crispy")
            bakingTechniqueModifier = 0.9;
        else if (this.BakingTechnique == "chewy")
            bakingTechniqueModifier = 1.1;

        double calories = (this.Weight * 2) * typeModifier * bakingTechniqueModifier;

        return calories;
    }

    public void PrintCalories()
    {
        Console.WriteLine($"{this.SumCalories():f2}"); 
    }

}

