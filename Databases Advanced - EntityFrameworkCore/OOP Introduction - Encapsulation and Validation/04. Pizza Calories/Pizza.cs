using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Pizza
{
    private string name;
    private List<Topping> toppings;
    private Dough dough;
    private int numberOfToppings;

    public Pizza(string name)
    {
        this.Name = name;
        this.Dough = new Dough();
        this.Toppings = new List<Topping>();

    }
    public Pizza(string name, List<Topping> toppings, Dough dough)
    {
        this.Name = name;
        this.Toppings = toppings;
        this.Dough = dough;
    }

    public int NumberOfToppings
    {
        get { return this.Toppings.Count; }
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
            if (value.Length < 0 || value.Length > 15)
                throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");

            name = value;
        }
    }

    public void AddTopping(Topping topping)
    {
        this.Toppings.Add(topping);
        if (this.NumberOfToppings > 10)
            throw new ArgumentException("Number of toppings should be in range [0..10].");
    }

    public double GetTotalCalories()
    {
        double totalCalories = 0;

        totalCalories += this.Dough.SumCalories();

        foreach (var t in this.Toppings)
        {
            totalCalories += t.SumCalories();
        }

        return totalCalories;
    }
}
