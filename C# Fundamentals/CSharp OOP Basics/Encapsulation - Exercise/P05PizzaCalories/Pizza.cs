using System;
using System.Collections.Generic;

public class Pizza
{
    private string name;
    private List<Topping> toppings;
    private Dough dough;
    private int numberOfToppings;

    public Pizza(string name)
    {
        Name = name;
        Dough = new Dough();
        Toppings = new List<Topping>();

    }
    public Pizza(string name, List<Topping> toppings, Dough dough)
    {
        Name = name;
        Toppings = toppings;
        Dough = dough;
    }

    public int NumberOfToppings
    {
        get { return Toppings.Count; }
        set
        {
            if (value > 10)
                throw new ArgumentException("Number of toppings should be in range [0..10].");

            numberOfToppings = value;
        }
    }

    public Dough Dough
    {
        get { return dough; }
        set { dough = value; }
    }


    public List<Topping> Toppings
    {
        get { return toppings; }
        set { toppings = value; }
    }


    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length > 15)
                throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");

            name = value;
        }
    }

    public void AddTopping(Topping topping)
    {
        Toppings.Add(topping);
        if (NumberOfToppings > 10)
            throw new ArgumentException("Number of toppings should be in range [0..10].");
    }

    public double GetTotalCalories()
    {
        double totalCalories = 0;

        totalCalories += Dough.SumCalories();

        foreach (var t in Toppings)
        {
            totalCalories += t.SumCalories();
        }

        return totalCalories;
    }
}
