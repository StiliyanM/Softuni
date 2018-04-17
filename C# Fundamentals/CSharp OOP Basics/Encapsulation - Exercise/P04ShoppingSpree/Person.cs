using System;
using System.Collections.Generic;

class Person
{
    private string name;
    private decimal money;
    private List<string> products;

    public Person(string name, decimal money)
    {
        this.Name = name;
        this.Money = money;

        this.Products = new List<string>();
    }

    public string Name
    {
        get
        { return this.name; }
        set
        {
            if(string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Name cannot be empty");

            }

            this.name = value;
        }
    }

    public decimal Money
    {
        get { return this.money; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }

            this.money = value;
        }
    }

    public List<string> Products
    {
        get
        {
            return this.products;
        }
        set { this.products = value; }
    }

    public void BuyProduct(Product product)
    {
        money = this.Money;

        decimal price = product.Price;

        var newMoney = money - price;

        if (newMoney < 0)
        {
            Console.WriteLine($"{this.Name} can't afford {product.Name}");
            return;
        }

        this.Money = newMoney;
        this.Products.Add(product.Name);

        Console.WriteLine($"{this.Name} bought {product.Name}");
    }

    public override string ToString()
    {
        if(this.Products.Count != 0)
        {
            return $"{this.Name}" + " - " + string.Join(", ", this.Products);
        }
        else return $"{this.Name}" + " - " + "Nothing bought";
    }
}

